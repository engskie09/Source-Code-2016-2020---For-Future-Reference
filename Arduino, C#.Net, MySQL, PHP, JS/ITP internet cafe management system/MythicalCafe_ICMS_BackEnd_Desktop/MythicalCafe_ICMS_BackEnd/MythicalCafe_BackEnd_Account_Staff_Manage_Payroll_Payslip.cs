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
    public partial class MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip : Form
    {
        public MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            rv_Payroll_Payslip.RefreshReport();

            set_rv_Payroll_Payslip_Value(); 
        }

        public DataTable Staff_Attendance_DataTable = new DataTable();
        public JObject Staff_Payroll_Information = null;

        public void set_rv_Payroll_Payslip_Value()
        {
            /*MythicalCafe_BackEnd_DataSet get_DataSet = new MythicalCafe_BackEnd_DataSet();

            get_DataSet.Tables.Add(Staff_Attendance_DataTable);*/

            ReportDataSource get_ReportDataSource = new ReportDataSource("dt_Account_Attendance", Staff_Attendance_DataTable);
            
            
            ReportParameterCollection get_ReportParameterCollection = new ReportParameterCollection();

            get_ReportParameterCollection.Add(new ReportParameter("Staff_FullName", Staff_Payroll_Information["Staff_FullName"].ToString()));
            get_ReportParameterCollection.Add(new ReportParameter("Staff_Position", Staff_Payroll_Information["Staff_Position"].ToString()));
            get_ReportParameterCollection.Add(new ReportParameter("Date_From", Staff_Payroll_Information["Date_From"].ToString()));
            get_ReportParameterCollection.Add(new ReportParameter("Date_To", Staff_Payroll_Information["Date_To"].ToString()));
            get_ReportParameterCollection.Add(new ReportParameter("Payroll_Salary", Staff_Payroll_Information["Payroll_Salary"].ToString() + " Peso"));
            get_ReportParameterCollection.Add(new ReportParameter("Payroll_Salary_Net", Staff_Payroll_Information["Payroll_Salary_Net"].ToString() + " Peso"));
            get_ReportParameterCollection.Add(new ReportParameter("Payroll_Deduction", Staff_Payroll_Information["Payroll_Deduction"].ToString() + " Peso"));

            get_ReportParameterCollection.Add(new ReportParameter("Staff_Assigned_FullName", Staff_Payroll_Information["Staff_Assigned_FullName"].ToString()));
            get_ReportParameterCollection.Add(new ReportParameter("Branch_Identity", Staff_Payroll_Information["Branch_Identity"].ToString()));

            rv_Payroll_Payslip.LocalReport.DataSources.Clear();
            rv_Payroll_Payslip.LocalReport.DataSources.Add(get_ReportDataSource);

            rv_Payroll_Payslip.LocalReport.SetParameters(get_ReportParameterCollection);

            rv_Payroll_Payslip.LocalReport.Refresh();
            rv_Payroll_Payslip.RefreshReport();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            rv_Payroll_Payslip.PrintDialog();
        }
    }
}
