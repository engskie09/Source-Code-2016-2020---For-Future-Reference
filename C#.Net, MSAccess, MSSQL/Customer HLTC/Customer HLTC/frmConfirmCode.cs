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

namespace Customer_HLTC
{
    public partial class frmConfirmCode : Form
    {
        public frmConfirmCode()
        {
            InitializeComponent();
        }

        string userid1 = "";
        string fname1 = "";
        string lname1 = "";
        string email1 = "";
        string code = "";
        string connectionString = Program.connectionString;

        public void sendData(string userid, string fname, string lname, string email)
        {
           
            userid1 = userid;
            fname1 = fname;
            lname1 = lname;
            email1 = email;

          
            GetCode();

        }

        // Code for getting the activation key that is given by the system.
        public void GetCode()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);



            string sql = "select * from tbl_customer_information where customer_ID = '" + userid1 + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader;

            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        code = reader.GetString(9);
                       
                    }
                }


                reader.Close();
                cmd.Dispose();
                cnn.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        // Code for Updating the Table.

        public void Update()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);



            string sql = "update tbl_customer_information set customer_status = '" + "Active" + "' where customer_ID = '" + userid1 + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader;

            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();

                MessageBox.Show("Account Verified!");

                this.Close();

                reader.Close();
                cmd.Dispose();
                cnn.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtActive.Text == String.Empty)
            {
                MessageBox.Show("Please Input the Code");
            }
            else
            {
                if (txtActive.Text != code)
                {
                    MessageBox.Show("You have Entered the wrong code");
                }
                else
                {

                    Update();


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
