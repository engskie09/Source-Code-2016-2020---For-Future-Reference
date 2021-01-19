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
using System.IO;

namespace Customer_HLTC
{
    public partial class frmMyAccount : Form
    {
        public frmMyAccount()
        {
            InitializeComponent();
        }

        string userid1 = "";
        string fname1 = "";
        string lname1 = "";
        string email1 = "";

        public string connectionString = Program.connectionString;


        public void sendData(string userid, string fname, string lname, string email)
        {

            userid1 = userid;
            fname1 = fname;
            lname1 = lname;
            email1 = email;


        }

        public void getPicture()
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
                        byte[] img = (byte[])(reader[11]);

                        MemoryStream ms = new MemoryStream(img);
                        pbProfilePicture.Image = Image.FromStream(ms);

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

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if (userid1 != "")
            {
                linkLogin.Visible = false;
                 linkLogout.Visible = true;
                getPicture();

            }
            else
            {
                linkLogin.Visible = true;
              
            }
        }

        private void lnkMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkReservation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReservation mmm = new frmReservation();
            mmm.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            mmm.Show();
        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAboutUs b = new frmAboutUs();
            b.sendData(userid1, fname1, lname1, email1);
            b.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmContactUs bb = new frmContactUs();
            bb.sendData(userid1, fname1, lname1, email1);
            bb.Show();
            this.Hide();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin a = new frmLogin();
            a.Show();
            this.Hide();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin mmm = new frmLogin();
            mmm.Show();
            this.Hide();
        }

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMainMenu a = new frmMainMenu();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword a = new frmChangePassword();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            frmEditAccount a = new frmEditAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }
    }
}
