using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static SqlConnection connection = new SqlConnection(Program.connectionString);
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter da = new SqlDataAdapter();

        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();
        public static DataTable dt2 = new DataTable();

        private static String tblName8 = "tbl_customer_payment";

        public static void get_payment_customer(String set_paymentID, String set_currentAction)
        {
            dt.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (set_currentAction == "All")
            {
                cmd.CommandText = "SELECT * FROM " + tblName8 + "";
                cmd.ExecuteNonQuery();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    list_paymentTotal.Add(dr["payment_total"].ToString());
                    list_paymentID.Add(dr["payment_ID"].ToString());
                }
            }

            





            connection.Close();
        }
        private static List<String> list_paymentID = new List<String>(); 
        private static List<String> list_paymentTotal = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            get_payment_customer("", "All");

            for (int x = 0; x < list_paymentTotal.Count; x++ )
            {
                chartSalary.Series["Payments"].Points.AddXY(list_paymentID[x], list_paymentTotal[x]);
            }
        }
    }
}
