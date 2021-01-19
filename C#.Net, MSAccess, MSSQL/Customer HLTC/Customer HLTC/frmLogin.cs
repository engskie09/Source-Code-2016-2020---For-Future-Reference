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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string userid = "";
        string fname = "";
        string lname = "";
        string email = "";
        string status = "";
        string contact = "";
        int cttr = 0;
        string time;
        string time2;
        DateTime dt1;
        DateTime dt2;
        Timer MyTimer = new Timer();

        public string connectionString = "Data Source=(LocalDB)\\HTLC;Initial Catalog=db_hltc;Integrated Security=True";

        
        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMainMenu mmm = new frmMainMenu();
            this.Hide();
            mmm.Show();
        }

        private void lnkReservation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReservation ss = new frmReservation();
            this.Hide();
            ss.Show();
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAboutUs a = new frmAboutUs();
            a.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmContactUs a = new frmContactUs();
            a.Show();
            this.Hide();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Verify();
            if (status == "Active")
            {

                frmMainMenu a = new frmMainMenu();
                a.sendData(userid, fname, lname, email);
                a.Show();
                this.Hide();
                
            }
            else if (status == "Not Active")
            {
                
                frmConfirmCode a = new frmConfirmCode();
                a.sendData(userid, fname, lname, email);
                a.Show();
                
            }
        }

        private void Verify()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);



            string sql = "select * from tbl_customer_information where customer_EmailAddress = '" + txtUsername.Text + "' and customer_userpassword = '" + txtPassword.Text + "'";
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


                        userid = reader.GetString(0);
                        fname = reader.GetString(1);
                        lname = reader.GetString(2);
                        email = reader.GetString(4);
                        contact = reader.GetString(7);
                        status = reader.GetString(10);


                       

                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username/ Password");
                    cttr++;
                    if (cttr > 3)
                    {
                        MessageBox.Show("Please Try Again After 5 minutes");
                        btnLogin.Enabled = false;
                        UpdateTime();
                        Timer();
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

        private void UpdateTime()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            string time = DateTime.Now.ToShortTimeString();

            string sql = "update tbl_timeout set time = '" + time + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader;

            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void getTime()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);



            string sql = "select * from tbl_timeout";
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
                        time2 = reader.GetString(0);

                        dt2 = DateTime.Parse(time2);


                        if (dt2.AddMinutes(5) < DateTime.Now)
                        {
                            btnLogin.Enabled = true;
                            cttr = 0;
                        }
                        else
                        {
                            btnLogin.Enabled = false;
                        }
                    }
                }
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Timer()
        {
            MyTimer.Interval = (60 * 5000);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            getTime();
            MyTimer.Stop();


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            getTime();
        }

        private void linkCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.Show();
            this.Hide();
        }
    }
}
