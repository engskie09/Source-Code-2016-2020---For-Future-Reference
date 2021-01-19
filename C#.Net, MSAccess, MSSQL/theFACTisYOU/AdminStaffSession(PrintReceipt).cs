using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;

namespace theFACTisYOU
{
    public partial class AdminStaffSession_PrintReceipt_ : Form
    {

         string date = "";
         string time = "";
        public static string total = "";
        public static string cash = "";
        public static string change = "";

        OleDbConnection HelloSayoXD = new OleDbConnection(LoginSession.x);

        public AdminStaffSession_PrintReceipt_()
        {
            InitializeComponent();
            //  MessageBox.Show(total+","+cash+","+change);

            date = DateTime.Now.ToLongDateString();
            time = DateTime.Now.ToLongTimeString();

            //  MessageBox.Show(time);

         
          


         
        }

        
        public void hays()
        {

            HelloSayoXD.Close();
            HelloSayoXD.Open();

            OleDbCommand cmd = HelloSayoXD.CreateCommand();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from print";
            cmd.ExecuteNonQuery();
            da.Fill(DataSet1,DataSet1.Tables[0].TableName);

            ReportDataSource rds = new ReportDataSource("print", DataSet1.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
            HelloSayoXD.Close();

        }

        private void AdminStaffSession_PrintReceipt__Load(object sender, EventArgs e)
        {
            hays();

      
            /*
           
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("xdate", date),           
                new Microsoft.Reporting.WinForms.ReportParameter("xtime", time),
                new Microsoft.Reporting.WinForms.ReportParameter("xtotal", total),
                new Microsoft.Reporting.WinForms.ReportParameter("xcash", cash),
                new Microsoft.Reporting.WinForms.ReportParameter("xchange", change)
            };

            this.reportViewer1.LocalReport.SetParameters(rParams);*/
           

        }
    }
}
