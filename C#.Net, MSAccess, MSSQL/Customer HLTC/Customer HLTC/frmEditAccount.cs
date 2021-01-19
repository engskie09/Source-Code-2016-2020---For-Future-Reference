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
    public partial class frmEditAccount : Form
    {
        public frmEditAccount()
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

        private void lnkMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtFirstName.Text = FirstLetterToUpper(txtFirstName.Text);
        }

        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtLastName.Text = FirstLetterToUpper(txtLastName.Text);
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBirthdate.Value > DateTime.Now)
            {
                lblInvalidDate.Visible = true;
                dtpBirthdate.Text = DateTime.Now.ToString();
            }

            else if (dtpBirthdate.Value.AddYears(18) > DateTime.Now)
            {
                lblInvalidDate.Visible = true;
            }

            else
            {
                lblInvalidDate.Visible = false;

            }
        }

        private void frmEditAccount_Load(object sender, EventArgs e)
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
                        txtFirstName.Text = reader.GetString(1);
                        txtLastName.Text = reader.GetString(2);
                        dtpBirthdate.Text = reader.GetString(3);
                        txtEmail.Text = reader.GetString(4);
                        txtHome.Text = reader.GetString(5);
                        txtLandline.Text = reader.GetString(6);
                        txtMobile.Text = reader.GetString(7);

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

        public void Verify()
        {
            if (txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty || dtpBirthdate.Text == String.Empty || txtEmail.Text == String.Empty || txtHome.Text == String.Empty || txtLandline.Text == String.Empty)
            {

                MessageBox.Show("Complete the data");

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



            string sql = "update tbl_customer_information set customer_Firstname = '" + txtFirstName.Text + "', customer_Lastname = '" + txtLastName.Text + "', customer_Birthdate = '" + dtpBirthdate.Text + "', customer_EmailAddress = '" + txtEmail.Text + "', customer_HomeAddress = '" + txtHome.Text + "', customer_Landline = '" + txtLandline.Text + "', customer_MobileNo = '" + txtMobile.Text + "' where customer_ID = '" + userid1 + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader;

            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();

                MessageBox.Show("Successfully Updated");

                

                reader.Close();
                cmd.Dispose();
                cnn.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Verify();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
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


    }
}
