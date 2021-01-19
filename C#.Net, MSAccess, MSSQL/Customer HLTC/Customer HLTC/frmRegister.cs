using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Net.Mail;

namespace Customer_HLTC
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=(LocalDB)\\HTLC;Initial Catalog=db_hltc;Integrated Security=True";
        string code = "";
        Byte[] get_Image = null;

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            Verify();
        }

        public void Insert()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            string customer_ID = "Customer-" + SystemMethods_ID_Counter.get_CurrentID_Count("customer_ID");
            code = RandomString(6);

            String queryColumn = "(customer_Id, customer_Firstname, customer_Lastname, customer_Birthdate, customer_EmailAddress, customer_HomeAddress, customer_Landline, customer_MobileNo, customer_Userpassword, customer_Code, customer_Status, customer_Image)";
            String queryValue = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12)";

            cnn.Close();
            cnn.Open();

            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + "tbl_customer_information" + " " + queryColumn + " " + queryValue + "";
            cmd.Parameters.AddWithValue("@a1", customer_ID);
            cmd.Parameters.AddWithValue("@a2", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@a3", txtLastName.Text);
            cmd.Parameters.AddWithValue("@a4", dtpBirthdate.Text);
            cmd.Parameters.AddWithValue("@a5", txtEmail.Text);
            cmd.Parameters.AddWithValue("@a6", txtHome.Text);
            cmd.Parameters.AddWithValue("@a7", txtLandline.Text);
            cmd.Parameters.AddWithValue("@a8", txtMobile.Text);
            cmd.Parameters.AddWithValue("@a9", txtPassword.Text);
            cmd.Parameters.AddWithValue("@a10", code);
            cmd.Parameters.AddWithValue("@a11", "Not Active");
            cmd.Parameters.AddWithValue("@a12", get_Image);

            cmd.ExecuteNonQuery();

            cnn.Close();

            SystemMethods_ID_Counter.set_CurrentID_Count("customer_ID");

            MessageBox.Show("Succesfully Registered");

            SendEmail(txtEmail.Text);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            // dtpBirthdate.Text = "";
            txtEmail.Text = "";
            txtHome.Text = "";
            txtLandline.Text = "";
            txtMobile.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";

        }


        public static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void SendEmail(string email)
        {

            try
            {
                string from = "fpurposes8@gmail.com";
                string to = email;
                string subject = "Confirmation Code.";
                string user = "fpurposes8@gmail.com";
                string pass = "@dmin123";


                MailMessage mail = new MailMessage(from, to, subject, code);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                client.Credentials = new System.Net.NetworkCredential(user, pass);
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;



                client.Send(mail);

                MessageBox.Show("The Code has bent sent to your email.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        public void Verify()
        {
            if (txtFirstName.Text == String.Empty || txtLastName.Text == String.Empty || dtpBirthdate.Text == String.Empty || txtEmail.Text == String.Empty || txtHome.Text == String.Empty || txtLandline.Text == String.Empty || txtPassword.Text == String.Empty || txtConfirm.Text == String.Empty)
            {

                MessageBox.Show("Complete the data");

            }
            else
            {
                if(txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Password Missmatch");
                }
                else
                {
                    Insert();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            string sql = "select * from tbl_customer_information where customer_EmailAddress = '" + txtEmail.Text + "'";
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
                        lblErrorEmail.Visible = true;
                        btnNext.Enabled = false;

                    }
                }

                else
                {
                    lblErrorEmail.Visible = false;
                    btnNext.Enabled = true;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtConfirm.Text)
            {
                lblErrorConfirm.Visible = true;
                btnNext.Enabled = false;
            }

            else
            {
                lblErrorConfirm.Visible = false;
                btnNext.Enabled = true;
            }
        }

        private void dtpBirthdate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpBirthdate.Value > DateTime.Now)
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            

                OpenFileDialog opf = new OpenFileDialog();
                MemoryStream ms = new MemoryStream();

                opf.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *.png; *.gif";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pbProfilePic.Image = Image.FromFile(opf.FileName);
                    pbProfilePic.Image.Save(ms, pbProfilePic.Image.RawFormat);
                    get_Image = ms.GetBuffer();
                }

                ms.Close();



            
        }


        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtFirstName.Text = FirstLetterToUpper(txtFirstName.Text);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtLastName.Text = FirstLetterToUpper(txtLastName.Text);
        }
    }
}
