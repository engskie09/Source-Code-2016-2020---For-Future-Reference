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
    public partial class frmWishtoSubmit : Form
    {
        public frmWishtoSubmit()
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
        string reservation_Date1 = "";
        string reservation_Time1 = "";
        string reservation_startDate1 = "";
        string reservation_endDate1 = "";
        string bus_ID1 = "";
        string driver_ID1 = "";
        string destination_ID1 = "";
        string payment1 = "";
        int total1 = 0;


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Insert();
            Insert2();
            SendEmail(email1);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void sendReservation(string reservation_id,string reservation_Date, string reservation_Time, string reservation_startDate, string reservation_endDate, string customer_ID, string bus_ID, string driver_ID, string destination_ID, Byte[] destination_landmarkimage, string payment, string email, string total)
        {
            reservation_ID = reservation_id;
            reservation_Date1 = reservation_Date;
            reservation_Time1 = reservation_Time;
            reservation_startDate1 = reservation_startDate;
            reservation_endDate1 = reservation_endDate;
            userid1 = customer_ID;
            bus_ID1 = bus_ID;
            driver_ID1 = driver_ID;
            destination_ID1 = destination_ID;
            get_Image = destination_landmarkimage;
            payment1 = payment;
            email1 = email;
            total1 = Int32.Parse(total);

        }

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
            cmd.Parameters.AddWithValue("@a2", reservation_Date1);
            cmd.Parameters.AddWithValue("@a3", reservation_Time1);
            cmd.Parameters.AddWithValue("@a4", reservation_startDate1);
            cmd.Parameters.AddWithValue("@a5", reservation_endDate1);
            cmd.Parameters.AddWithValue("@a6", userid1);
            cmd.Parameters.AddWithValue("@a7", "");
            cmd.Parameters.AddWithValue("@a8", "");
            cmd.Parameters.AddWithValue("@a9", destination_ID1);
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

            payment_ID = "Payment-" + SystemMethods_ID_Counter.get_CurrentID_Count("payment_ID");

            String queryColumn = "(payment_id, payment_mode, payment_status, reservation_id, payment_total)";
            String queryValue = "VALUES (@a1, @a2, @a3, @a4, @a5)";

            cnn.Close();
            cnn.Open();



            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + "tbl_customer_payment" + " " + queryColumn + " " + queryValue + "";
            cmd.Parameters.AddWithValue("@a1", payment_ID);
            cmd.Parameters.AddWithValue("@a2", payment1);
            cmd.Parameters.AddWithValue("@a3", "Hold");
            cmd.Parameters.AddWithValue("@a4", reservation_ID);
            cmd.Parameters.AddWithValue("@a5", total1);



            cmd.ExecuteNonQuery();

            cnn.Close();

            SystemMethods_ID_Counter.set_CurrentID_Count("payment_ID");





        }



    }

}
