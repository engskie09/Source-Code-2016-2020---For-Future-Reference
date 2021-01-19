using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CanteenKiosk
{
    public partial class AccountShowTransactionDialog : Form
    {
        public AccountShowTransactionDialog()
        {
            InitializeComponent();
        }

        private void AccountShowTransactionDialog_Load(object sender, EventArgs e)
        {

        }
         DataTable dts = new DataTable();
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 10)
            {
               
                MySqlConnection cnn;

                cnn = new MySqlConnection(stringpotek.koneksyon);
                // try
                //  {
                cnn.Open();



                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from carduser Where cardno='" + textBox1.Text + "'";
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
                    cmdx.CommandText = "select OrderProducts, OrderQuantity, OrderPrice, OrderTotalPrice , OrderDate from transaction_report_tbl where StudentID='" + getStudentIDD + "'ORDER BY OrderDate ASC";
                    cmdx.ExecuteNonQuery();

          

                    MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);


                    StudentShowtransactions qwe = new StudentShowtransactions();

                    DataTable huehue = new DataTable();
                    xda.Fill(huehue);
                    qwe.dataGridView1.DataSource = huehue;
                    
                    qwe.ShowDialog();
                    this.Hide();
                }



                
                cnn.Close();
                textBox1.Clear();

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
            cmdx.CommandText = "select * from carduser where cardno='" + textBox1.Text + "' ";
            cmdx.ExecuteNonQuery();



            MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);

            xda.Fill(dts);


             foreach (DataRow xdr in dts.Rows)



             {
                getStudentIDD = xdr["StudentID"].ToString();
             }

             getStudentIDD = StudentShowtransactions.getStudID;

            cnn.Close();

        }
     

        private void button6_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
