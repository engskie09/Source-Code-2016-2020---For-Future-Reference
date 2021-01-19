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
    public partial class frmReservation2 : Form
    {
        public frmReservation2()
        {
            InitializeComponent();
        }

        string userid1 = "";
        string fname1 = "";
        string lname1 = "";
        string email1 = "";
        string bus1 = "";
        string reservation_ID = "";
        string payment_ID = "";
        Byte[] get_Image = null;

        public void sendData(string userid, string fname, string lname, string email, string bus)
        {

            userid1 = userid;
            fname1 = fname;
            lname1 = lname;
            email1 = email;
            bus1 = bus;

            

        }

        public void getLocation()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(Program.connectionString);



            string sql = "select * from tbl_prices";
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
                         comboDestination.Items.Add(reader.GetString(0));   
                    }
                }
            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void frmReservation2_Load(object sender, EventArgs e)
        {
            getLocation();

            if (userid1 == "")
            {
                frmLogin a = new frmLogin();
                a.Show();
                this.Close();
                    
            }

            else {

                linkLogin.Visible = false;
                lnkMyAccount.Visible = true;
                linkLogout.Visible = true;

                if (bus1 == "btnHSAC")
                {

                    lblBusType.Text = "Hyundai Super Aero City";



                }

                else if (bus1 == "btnHSAI")
                {

                    lblBusType.Text = "Hyundai Super Aero Intercity";


                }

                else if (bus1 == "btnDBF")
                {

                    lblBusType.Text = "Daewoo BF106";


                }

                else if (bus1 == "btnDBH")
                {

                    lblBusType.Text = "Daewoo BH090";



                }

                else if (bus1 == "btnFFHX")
                {

                    lblBusType.Text = "Fuso FHX-80";



                }

                else if (bus1 == "btnFVR")
                {

                    lblBusType.Text = "Isuzu FVR";



                }

            }
        }

        public void Verify()
        {
            if (dateEnd.Text == String.Empty || dateStart.Text == String.Empty || comboTime.Text == String.Empty || txtPickup.Text == String.Empty || txtAddress.Text == String.Empty || comboDestination.Text == String.Empty || cmbPayment.Text == String.Empty)
            {

                MessageBox.Show("Please Complete Data");


            }
            else
            {

                frmWishtoSubmit frm = new frmWishtoSubmit();
                frm.sendReservation(reservation_ID, DateTime.Now.ToString("MM/dd/yyyy"), DateTime.Now.ToString("h:mm tt"), dateStart.Value.Date.ToString("MM/dd/yyyy"), dateEnd.Value.Date.ToString("MM/dd/yyyy"), userid1, "", "", comboDestination.Text, get_Image, cmbPayment.Text, email1, lblTotal.Text);
                frm.ShowDialog();
               
            }
        }
/*
        public void Insert()
        {

            SqlConnection cnn;
            cnn = new SqlConnection(Program.connectionString);

            SqlCommand cmd = new SqlCommand();

            reservation_ID = "Reservation-" + SystemMethods_ID_Counter.get_CurrentID_Count("reservation_ID");      

            String queryColumn = "(reservation_id, reservation_Date, reservation_Time, reservation_startDate, reservation_endDate, customer_ID, bus_ID, driver_ID, destination_ID, destination_landmarkimage)";
            String queryValue = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10)";

            cnn.Close();
            cnn.Open();

            

            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + "tbl_bus_reservation" + " " + queryColumn + " " + queryValue + "";
            cmd.Parameters.AddWithValue("@a1", reservation_ID);
            cmd.Parameters.AddWithValue("@a2", DateTime.Now.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@a3", DateTime.Now.ToString("h:mm tt"));
            cmd.Parameters.AddWithValue("@a4", dateStart.Value.Date.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@a5", dateEnd.Value.Date.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@a6", userid1);
            cmd.Parameters.AddWithValue("@a7", "");
            cmd.Parameters.AddWithValue("@a8", "");
            cmd.Parameters.AddWithValue("@a9", comboDestination.Text);
            cmd.Parameters.AddWithValue("@a10", get_Image);


            cmd.ExecuteNonQuery();

            cnn.Close();

            SystemMethods_ID_Counter.set_CurrentID_Count("reservation_ID");

          
            


        }

        public void SendEmail(string email)
        {

            try
            {
                string from = "fpurposes8@gmail.com";
                string to = email;
                string body = "Your Request is being processed";
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

        public void Insert2()
        {

            SqlConnection cnn;
            cnn = new SqlConnection(Program.connectionString);

            SqlCommand cmd = new SqlCommand();

            payment_ID = "Payment- " + SystemMethods_ID_Counter.get_CurrentID_Count("payment_ID");

            String queryColumn = "(payment_id, payment_mode, payment_status, reservation_id)";
            String queryValue = "VALUES (@a1, @a2, @a3, @a4)";

            cnn.Close();
            cnn.Open();



            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + "tbl_customer_payment" + " " + queryColumn + " " + queryValue + "";
            cmd.Parameters.AddWithValue("@a1", payment_ID);
            cmd.Parameters.AddWithValue("@a2", cmbPayment.Text);
            cmd.Parameters.AddWithValue("@a3", "Unpaid");
            cmd.Parameters.AddWithValue("@a4", reservation_ID);
           


            cmd.ExecuteNonQuery();

            cnn.Close();

            SystemMethods_ID_Counter.set_CurrentID_Count("payment_ID");





        }
*/

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Verify();
            

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pbProfilePic_Click(object sender, EventArgs e)
        {

        }

        private void lnkMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            if (dateStart.Value < DateTime.Now)
            {
                
                dateStart.Text = DateTime.Now.ToString();

               
            }
            else
            {
                dateEnd.Text = dateStart.Text;
                getPrice();
            }
          

        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dateEnd.Value < dateStart.Value)
            {

                dateEnd.Text = dateStart.Text;
            }
            else
            {
                getPrice();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmReservation hh = new frmReservation();
            hh.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            hh.Show();
        }

        private void comboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            getPrice();
        }

        public void getPrice()
        {
            int days = 1 + (dateEnd.Value - dateStart.Value).Days;
         
            lblTotal.Text = (days * Bus_Prices.get_Price(comboDestination.Text, lblBusType.Text)).ToString();
        }
    }
}
