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
using System.Web;
using System.Net.Mail;


namespace Customer_HLTC
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        string userid1 = "";
        string fname1 = "";
        string lname1 = "";
        string email1 = "";
      
        string password = "";
        
        string connectionString = Program.connectionString;

        public void sendData(string userid, string fname, string lname, string email)
        {

            userid1 = userid;
            fname1 = fname;
            lname1 = lname;
            email1 = email;
            



        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMainMenu ff = new frmMainMenu();
            ff.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            ff.Show();
        }

        private void lnkReservation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReservation hh = new frmReservation();
            hh.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            hh.Show();
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAboutUs bb = new frmAboutUs();
            bb.sendData(userid1, fname1, lname1, email1);
            bb.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmContactUs bb = new frmContactUs();
            bb.sendData(userid1, fname1, lname1, email1);
            bb.Show();
            this.Hide();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            if (userid1 != "")
            {
                linkLogin.Visible = false;
                lnkMyAccount.Visible = true;
                linkLogout.Visible = true;
            }
            else
            {
                linkLogin.Visible = true;
                lnkMyAccount.Visible = false;
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin a = new frmLogin();
            a.Show();
            this.Hide();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin a = new frmLogin();
            a.Show();
            this.Hide();
        }


        private void lnkMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }

        public void getPassword()
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
                        password = reader.GetString(8);

                    }
                }
                else
                {

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

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (userid1 != "")
            {
                linkLogin.Visible = false;
                linkLogout.Visible = true;


            }
            else
            {
                linkLogin.Visible = true;

            }
            getPassword();
        }

        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtCurrentPassword.Text != password)
            {
                btnUpdate.Enabled = false;
                lblPassword.Visible = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                lblPassword.Visible = false;
            }
        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {
            if(txtNewPassword.Text != txtRePassword.Text)
            {
                btnUpdate.Enabled = false;
                lblMismatch.Visible = true;
            }
            else
            {
                btnUpdate.Enabled = true;
                lblMismatch.Visible = false;
            }
        }

        public void Verify()
        {
            if(txtCurrentPassword.Text == String.Empty || txtNewPassword.Text == String.Empty || txtRePassword.Text == String.Empty)
            {
                MessageBox.Show("Please Complete the Information");
            }
            else
            {
                update();
            }
        }

        public void update()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);



            string sql = "update tbl_customer_information set customer_Userpassword = '" + txtNewPassword.Text + "' where customer_ID = '" + userid1 + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader;

            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();

                MessageBox.Show("Successfully Updated");

                SendEmail(email1);

                txtCurrentPassword.Text = "";
                txtNewPassword.Text = "";
                txtRePassword.Text = "";

                reader.Close();
                cmd.Dispose();
                cnn.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Verify();
        }

        public void SendEmail(string email)
        {

            try
            {
                string from = "fpurposes8@gmail.com";
                string to = email;
                string body = "Your Password has been Changed this " + DateTime.Now.ToLongDateString();
                string subject = "Confirmation Code.";
                string user = "fpurposes8@gmail.com";
                string pass = "@dmin123";


                MailMessage mail = new MailMessage(from, to, subject, body);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                client.Credentials = new System.Net.NetworkCredential(user, pass);
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;



                client.Send(mail);

               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }
    }
}
