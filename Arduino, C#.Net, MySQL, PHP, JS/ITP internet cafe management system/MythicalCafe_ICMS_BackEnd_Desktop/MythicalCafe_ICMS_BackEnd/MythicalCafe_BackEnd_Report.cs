using Binarymission.WinForms.Controls.DateTimeControls;
using Bunifu.Framework.UI;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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
    public partial class MythicalCafe_BackEnd_Report : Form
    {
        public MythicalCafe_BackEnd_Report()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Report_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Bill_Electric, txtbx_Bill_Electric.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Bill_Water, txtbx_Bill_Water.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Expenses_Other, txtbx_Expenses_Other.Text.Trim());

            MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(txtbx_Bill_Electric);
            MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(txtbx_Bill_Water);
            MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(txtbx_Expenses_Other);

            rv_Report.RefreshReport();
        }

        MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        MySqlCommand MySqlCommand = new MySqlCommand();
        MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        DataTable Report_DataTable_1 = new DataTable();

        Double Customer_Cash_Spent = 0;
        Double Product_Sold_Total = 0;
        Double Staff_Salary_Amount = 0;

        String potek_HAHAHAHAAHHAXD(String set_TableName, String set_ColumnName, DateTime set_DateTime_From, DateTime set_DateTime_To)
        {            
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();
            MySqlCommand.CommandText = "SELECT SUM(" + set_ColumnName + ") FROM " + set_TableName + " WHERE Report_DateTime BETWEEN '" + set_DateTime_From.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + set_DateTime_To.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            MySqlCommand.ExecuteNonQuery();

            Report_DataTable_1 = new DataTable();

            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(Report_DataTable_1);

            if (Report_DataTable_1.Rows.Count != 0)
            {
                DataRow get_DataRow = Report_DataTable_1.Rows[0];

                return get_DataRow["Sum(" + set_ColumnName + ")"].ToString();

                //MessageBox.Show(JsonConvert.SerializeObject(Report_DataTable_1.Rows[0], Formatting.Indented));
            }

            return "0";
        }

        String potek_HAHAHAHAAHHAXD_DDDDDDDDDDD(DateTime set_DateTime_From, DateTime set_DateTime_To)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();
            MySqlCommand.CommandText = "SELECT SUM(Staff_Salary_Amount) FROM tbl_staff_attendance_information WHERE (Attendance_DateTime_In BETWEEN '" + set_DateTime_From.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + set_DateTime_To.ToString("yyyy-MM-dd HH:mm:ss") + "') AND Attendance_Status = 'Time Out';";
            MySqlCommand.ExecuteNonQuery();

            Report_DataTable_1 = new DataTable();

            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(Report_DataTable_1);

            if (Report_DataTable_1.Rows.Count != 0)
            {
                DataRow get_DataRow = Report_DataTable_1.Rows[0];

                return get_DataRow["Sum(Staff_Salary_Amount)"].ToString();                
            }

            return "0";
        }
        void set_rv_Report_Value()
        {
            String get_Date_From = DateTime.Parse(dp_DateTime_From.Value.ToString()).ToString("dd-MM-yyyy");
            String get_Date_To = DateTime.Parse(dp_DateTime_To.Value.ToString()).ToString("dd-MM-yyyy");



            ReportParameterCollection get_ReportParameterCollection = new ReportParameterCollection();

            get_ReportParameterCollection.Add(new ReportParameter("Date_From", get_Date_From));
            get_ReportParameterCollection.Add(new ReportParameter("Date_To", get_Date_To));
            get_ReportParameterCollection.Add(new ReportParameter("Branch_Identity", MythicalCafe_BackEnd_Main_Method.Branch_Identity));
            get_ReportParameterCollection.Add(new ReportParameter("Staff_Assigned_FullName", MythicalCafe_BackEnd_Main_Method.Staff_FullName));

            Customer_Cash_Spent = 5945;

            get_ReportParameterCollection.Add(new ReportParameter("Customer_Cash_Spent", Customer_Cash_Spent.ToString() + " Pesos"));
            get_ReportParameterCollection.Add(new ReportParameter("Product_Sold_Total", Product_Sold_Total.ToString() + " Pesos"));
            get_ReportParameterCollection.Add(new ReportParameter("Staff_Salary_Amount", Staff_Salary_Amount.ToString() + " Pesos"));

            Double get_Bill_Electric = 0;            
            Double get_Bill_Water = 0;
            Double get_Expense_Other = 0;

            if (!Double.TryParse(txtbx_Bill_Electric.Text, out get_Bill_Electric))
                get_Bill_Electric = 0;

            if (!Double.TryParse(txtbx_Bill_Water.Text, out get_Bill_Water))
                get_Bill_Water = 0;

            if (!Double.TryParse(txtbx_Expenses_Other.Text, out get_Expense_Other))
                get_Expense_Other = 0;

            Double get_Expense_Total = Staff_Salary_Amount + get_Bill_Electric + get_Bill_Water + get_Expense_Other;
            Double get_Income_Net = Convert.ToDouble(Customer_Cash_Spent) + Convert.ToDouble(Product_Sold_Total) - get_Expense_Total;


            get_ReportParameterCollection.Add(new ReportParameter("Bill_Electric", get_Bill_Electric.ToString() + " Pesos"));
            get_ReportParameterCollection.Add(new ReportParameter("Bill_Water", get_Bill_Water.ToString() + " Pesos"));
            get_ReportParameterCollection.Add(new ReportParameter("Expense_Other", get_Expense_Other.ToString() + " Pesos"));
            get_ReportParameterCollection.Add(new ReportParameter("Expense_Total", get_Expense_Total.ToString() + " Pesos"));
            get_ReportParameterCollection.Add(new ReportParameter("Income_Net", get_Income_Net.ToString() + " Pesos"));

            get_ReportParameterCollection.Add(new ReportParameter("Bill_Electric_Number", txtbx_Bill_Electric_Number.Text));
            get_ReportParameterCollection.Add(new ReportParameter("Bill_Water_Number", txtbx_Bill_Water_Number.Text));

            

            rv_Report.LocalReport.SetParameters(get_ReportParameterCollection);

            rv_Report.LocalReport.Refresh();
            rv_Report.RefreshReport();
        }

        void set_dp_DateTime_Validation(Object set_Object, EventArgs set_EventArgs)
        {
            BinaryDatePicker get_BinaryDatePicker = (BinaryDatePicker)set_Object;

            DateTime get_DateTime;

            if (!DateTime.TryParse(get_BinaryDatePicker.Value.ToString(), out get_DateTime))
            {
                get_BinaryDatePicker.Value = new DateTime(2019, 9, 23);

                return;
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            rv_Report.PrintDialog();
        }

        private void btn_DateTime_Select_Click(object sender, EventArgs e)
        {
            String XDCustomer_Cash_Spent = potek_HAHAHAHAAHHAXD("tbl_customer_report_information", "Cash_Spent", DateTime.Parse(dp_DateTime_From.Value.ToString()), DateTime.Parse(dp_DateTime_To.Value.ToString()));
            String XDProduct_Sold_Total = potek_HAHAHAHAAHHAXD("tbl_product_report_information", "Product_Sold_Total", DateTime.Parse(dp_DateTime_From.Value.ToString()), DateTime.Parse(dp_DateTime_To.Value.ToString()));
            String XDStaff_Salary_Amount = potek_HAHAHAHAAHHAXD_DDDDDDDDDDD(DateTime.Parse(dp_DateTime_From.Value.ToString()), DateTime.Parse(dp_DateTime_To.Value.ToString()));

            if (!Double.TryParse(XDCustomer_Cash_Spent.ToString(), out Customer_Cash_Spent))
                Customer_Cash_Spent = 0;

            if (!Double.TryParse(XDProduct_Sold_Total.ToString(), out Product_Sold_Total))
                Product_Sold_Total = 0;

            if (!Double.TryParse(XDStaff_Salary_Amount.ToString(), out Staff_Salary_Amount))
                Staff_Salary_Amount = 0;

            set_rv_Report_Value();
        }

        private void btnimg_Bill_Electric_Image_Click(object sender, EventArgs e)
        {

        }

        private void btnimg_Bill_Water_Image_Click(object sender, EventArgs e)
        {

        }
    }
}
