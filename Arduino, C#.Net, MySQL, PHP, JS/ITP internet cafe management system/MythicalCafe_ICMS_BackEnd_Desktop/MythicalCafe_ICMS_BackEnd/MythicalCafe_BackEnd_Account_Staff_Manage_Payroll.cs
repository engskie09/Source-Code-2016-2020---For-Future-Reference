using Binarymission.WinForms.Controls.DateTimeControls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Account_Staff_Manage_Payroll : Form
    {
        public MythicalCafe_BackEnd_Account_Staff_Manage_Payroll()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            dp_DateTime_In_From.MaxValue = DateTime.Now;
            dp_DateTime_In_From.MinValue = new DateTime(2019, 1, 1);
            dp_DateTime_In_From.CustomFormat = "dd-MM-yyyy";
            dp_DateTime_In_From.Value = new DateTime(2019, 10, 1);

            dp_DateTime_In_To.MaxValue = DateTime.Now;
            dp_DateTime_In_To.MinValue = new DateTime(2019, 1, 1);
            dp_DateTime_In_To.CustomFormat = "dd-MM-yyyy";
            dp_DateTime_In_To.Value = new DateTime(2019, 10, 1);

            set_dgv_Account_Attendance_Value();

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Deduction, txtbx_Deduction.Text);

        }

        Double Salary
        {
            get { return Convert.ToDouble(lbl_Salary.Text.Remove(0, 8)); }

            set { lbl_Salary.Text = "Salary: " + value; }
        }

        Double Salary_Net
        {
            get { return Convert.ToDouble(lbl_Salary_Net.Text.Remove(0, 12)); }

            set { lbl_Salary_Net.Text = "Net Salary: " + value; }
        }

        public String Staff_Identity = null;

        public void set_dgv_Account_Attendance_Value()
        {

            MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Attendance_Information("Select : All : Specific : Time Out", null, Staff_Identity, null);
                  

            dgv_Account_Attendance.DataSource = null;

            dgv_Account_Attendance.AutoGenerateColumns = false;

            dgv_Account_Attendance.Columns["Attendance_Identity"].DataPropertyName = "Attendance_Identity";
            dgv_Account_Attendance.Columns["Attendance_DateTime_In"].DataPropertyName = "Attendance_DateTime_In";
            dgv_Account_Attendance.Columns["Attendance_DateTime_Out"].DataPropertyName = "Attendance_DateTime_Out";
            dgv_Account_Attendance.Columns["Staff_Salary_Amount"].DataPropertyName = "Staff_Salary_Amount";

            dgv_Account_Attendance.DataSource = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.Account_DataTable_1;
        }

        private void set_dp_DateTime_In_Validation(Object set_Object, EventArgs set_EventArgs)
        {
            BinaryDatePicker get_BinaryDatePicker = (BinaryDatePicker)set_Object;

            DateTime get_DateTime;

            if (!DateTime.TryParse(get_BinaryDatePicker.Value.ToString(), out get_DateTime))
            {
                get_BinaryDatePicker.Value = new DateTime(2019, 9, 23);

                return;
            }
        }

        private void btn_DateTime_Select_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("From: " + dp_DateTime_In_From.Value.ToString() + " To: " + dp_DateTime_In_To.Value.ToString());

            String get_RowFilter = null;

            get_RowFilter = "Attendance_DateTime_In >= #{0:yyyy-MM-dd}# AND Attendance_DateTime_In <= #{1:yyyy-MM-dd}#";            

            (dgv_Account_Attendance.DataSource as DataTable).DefaultView.RowFilter = string.Format(get_RowFilter, dp_DateTime_In_From.Value, DateTime.Parse(dp_DateTime_In_To.Value.ToString()).AddDays(1));

            Salary = 0;

            foreach (DataGridViewRow set_DataGridViewRow in dgv_Account_Attendance.Rows)
                Salary += Convert.ToDouble(set_DataGridViewRow.Cells["Staff_Salary_Amount"].Value.ToString());
            

            if (Double.TryParse(txtbx_Deduction.Text, out _))            
                Salary_Net = Salary - Convert.ToDouble(txtbx_Deduction.Text);

            else
                Salary_Net = Salary;
        }

        private void btn_Payroll_Generate_Click(object sender, EventArgs e)
        {
            if (Salary == 0)
                return;

            dynamic get_Staff_Information = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information
            (
                "Select : Specific",
                Staff_Identity,
                null,
                null,
                null
            );

            if (get_Staff_Information is Boolean)
            {
                if (!get_Staff_Information)
                    return;
            }

            else
            {
                get_Staff_Information = JObject.Parse(JObject.Parse(get_Staff_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));
                                
                String get_Date_From = DateTime.Parse(dp_DateTime_In_From.Value.ToString()).ToString("dd-MM-yyyy");
                String get_Date_To = DateTime.Parse(dp_DateTime_In_To.Value.ToString()).ToString("dd-MM-yyyy");

                String get_Deduction = txtbx_Deduction.Text;

                if (get_Deduction == "Deduction")
                    get_Deduction = "0";                

                get_Staff_Information.Merge(JObject.Parse("{ 'Date_From' : '" + get_Date_From + "', 'Date_To' : '" + get_Date_To + "' ,'Payroll_Salary' : '" + Salary + "', 'Payroll_Salary_Net' : '" + Salary_Net + "', 'Payroll_Deduction' : '" + get_Deduction + "', 'Staff_Assigned_FullName' : '" + MythicalCafe_BackEnd_Main_Method.Staff_FullName + "', 'Branch_Identity' : '" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "'}"));

                new MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip()
                {
                    Staff_Attendance_DataTable = (dgv_Account_Attendance.DataSource as DataTable),
                    Staff_Payroll_Information = get_Staff_Information
                }.ShowDialog();

                //MessageBox.Show(get_Staff_Information.ToString());
            }

        }

        private void txtbx_Deduction_OnValueChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(txtbx_Deduction.Text, out _))
                Salary_Net = Salary - Convert.ToDouble(txtbx_Deduction.Text);

            else
                Salary_Net = Salary;
        }
    }
}
