using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenKiosk
{
    public partial class AccountShowLoadTransaction : Form
    {
        DataTable dts = new DataTable();
        public AccountShowLoadTransaction()
        {
            InitializeComponent();
        }

        private void loadlogin_TextChanged(object sender, EventArgs e)
        {
            if (loadlogin.Text.Length == 15)
            {
               
                MySqlConnection cnn;

                cnn = new MySqlConnection(stringpotek.koneksyon);
                // try
                //  {
                cnn.Open();



                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from carduser Where cardno='" + loadlogin.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);


                if (dt.Rows.Count == 1)
                {

                    cnn.Close();

                    getStudID();


                    cnn.Open();


                    MySqlCommand cmdx = cnn.CreateCommand();
                    cmdx.CommandType = CommandType.Text;
                    cmdx.CommandText = "select StudentName, AmountLoad, LoadDate from load_transaction_report_tbl where StudentID='" + getStudentIDD + "'ORDER BY LoadDate ASC";
                    cmdx.ExecuteNonQuery();

          

                    MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);


                    StudentShowLoadTransaction a = new StudentShowLoadTransaction();

                    DataTable huehue = new DataTable();
                    xda.Fill(huehue);
                    a.dataGridView1.DataSource = huehue;
                    
                    a.ShowDialog();
                    this.Hide();
                }




                cnn.Close();
                loadlogin.Clear();

            }
        }
        string getStudentIDD = "";

        public void getStudID()
        {


            MySqlConnection cnn;

            cnn = new MySqlConnection(stringpotek.koneksyon);
            // try

            //  {

            cnn.Close();
            cnn.Open();



            MySqlCommand cmdx = cnn.CreateCommand();
            cmdx.CommandType = CommandType.Text;
            cmdx.CommandText = "select * from carduser where cardno='" + loadlogin.Text + "' ";
            cmdx.ExecuteNonQuery();



            MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);

            xda.Fill(dts);


             foreach (DataRow xdr in dts.Rows)



             {
                getStudentIDD = xdr["StudentID"].ToString();
             }
            cnn.Close();

        }

        private void AccountShowLoadTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
    