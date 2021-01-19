using Binarymission.WinForms.Controls.DateTimeControls;
using Microsoft.Reporting.WinForms;
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
    public partial class MythicalCafe_BackEnd_Log_List : Form
    {
        public MythicalCafe_BackEnd_Log_List()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Log_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            set_dgv_Log_Value();

            set_rv_Log_Value();            
        }

        public String Log_Type_String = null;

        void set_dgv_Log_Value()
        {
            MythicalCafe_BackEnd_Log_Manage_List_Method.select_User_Log_Information("Select : All : Specific [ Log_Type ]", Log_Type_String);

            dgv_Log.DataSource = null;

            dgv_Log.AutoGenerateColumns = false;

            dgv_Log.Columns["Log_Identity"].DataPropertyName = "Log_Identity";
            dgv_Log.Columns["Log_Type"].DataPropertyName = "Log_Type";
            dgv_Log.Columns["Log_DateTime"].DataPropertyName = "Log_DateTime";
            dgv_Log.Columns["User_Identity"].DataPropertyName = "User_Identity";
            dgv_Log.Columns["Log_Description"].DataPropertyName = "Log_Description";

            dgv_Log.DataSource = MythicalCafe_BackEnd_Log_Manage_List_Method.Log_DataTable_1;
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

        private void btn_DateTime_Select_Click(object sender, EventArgs e)
        {
            String get_RowFilter = null;

            get_RowFilter = "Log_DateTime >= #{0:yyyy-MM-dd}# AND Log_DateTime <= #{1:yyyy-MM-dd}#";

            (dgv_Log.DataSource as DataTable).DefaultView.RowFilter = string.Format(get_RowFilter, dp_DateTime_From.Value, DateTime.Parse(dp_DateTime_To.Value.ToString()).AddDays(1));

            set_rv_Log_Value();

        }

        void set_rv_Log_Value()
        {
            ReportDataSource get_ReportDataSource = new ReportDataSource("dt_Log", dgv_Log.DataSource as DataTable);

            String get_Date_From = DateTime.Parse(dp_DateTime_From.Value.ToString()).ToString("dd-MM-yyyy");
            String get_Date_To = DateTime.Parse(dp_DateTime_To.Value.ToString()).ToString("dd-MM-yyyy");



            ReportParameterCollection get_ReportParameterCollection = new ReportParameterCollection();

            get_ReportParameterCollection.Add(new ReportParameter("Date_From", get_Date_From));
            get_ReportParameterCollection.Add(new ReportParameter("Date_To", get_Date_To));
            get_ReportParameterCollection.Add(new ReportParameter("Branch_Identity", MythicalCafe_BackEnd_Main_Method.Branch_Identity));
            get_ReportParameterCollection.Add(new ReportParameter("Staff_Assigned_FullName", MythicalCafe_BackEnd_Main_Method.Staff_FullName));

            rv_Log.LocalReport.DataSources.Clear();
            rv_Log.LocalReport.DataSources.Add(get_ReportDataSource);

            rv_Log.LocalReport.SetParameters(get_ReportParameterCollection);

            rv_Log.LocalReport.Refresh();
            rv_Log.RefreshReport();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            rv_Log.PrintDialog();
        }
    }
}
