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
    public partial class frmContactUs : Form
    {
        public frmContactUs()
        {
            InitializeComponent();
        }

        string userid1 = "";
        string fname1 = "";
        string lname1 = "";
        string email1 = "";
        string driver_id = "";
        string evaluation_ID = "";

        public string connectionString = "Data Source=(LocalDB)\\HTLC;Initial Catalog=db_hltc;Integrated Security=True";

        public void sendData(string userid, string fname, string lname, string email)
        {

            userid1 = userid;
            fname1 = fname;
            lname1 = lname;
            email1 = email;


        }
        private void lnkMyAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        public void LoadLatest()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(Program.connectionString);



            string sql = "select * from tbl_bus_reservation where customer_ID = '" + userid1 + "'" ;
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
                        driver_id = reader.GetString(7);
                        
                             
                    }
                }
                cnn.Close();
                LoadDriver();

            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public void LoadDriver()
        {
            SqlConnection cnn;
            cnn = new SqlConnection(Program.connectionString);



            string sql = "select * from tbl_driver_information where driver_ID = '" + driver_id + "'";
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
                        txtName.Text = reader.GetString(2) + ", " + reader.GetString(1);

                    }
                }

                cnn.Close();

            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
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
                btnReserve1.Enabled = true;
                LoadLatest();
                CheckCustomer();
            }
            else
            {
                linkLogin.Visible = true;
                lnkMyAccount.Visible = false;
                btnReserve1.Enabled = false;
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

        public void Verify()
        {
            if (txtName.Text == String.Empty || txtComments.Text == String.Empty || cmbRate.Text == String.Empty)
            {
                MessageBox.Show("Please Complete Data");
            }

            else
            {
                Insert();
            }
        }

        public void Insert()
        {

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();

            string evaluation_ID = "Evaluation-" + SystemMethods_ID_Counter.get_CurrentID_Count("evaluation_ID");
           
            String queryColumn = "(evaluation_ID, customer_ID, driver_ID, evaluation_Score, evluation_Date, evaluation_Comment)";
            String queryValue = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6)";

            cnn.Close();
            cnn.Open();

            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + "tbl_report_evaluation" + " " + queryColumn + " " + queryValue + "";
            cmd.Parameters.AddWithValue("@a1", evaluation_ID);
            cmd.Parameters.AddWithValue("@a2", userid1);
            cmd.Parameters.AddWithValue("@a3", txtName.Text);
            cmd.Parameters.AddWithValue("@a4", cmbRate.Text);
            cmd.Parameters.AddWithValue("@a5", DateTime.Now.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@a6", txtComments.Text);

            cmd.ExecuteNonQuery();

            cnn.Close();

            SystemMethods_ID_Counter.set_CurrentID_Count("evaluation_ID");

            MessageBox.Show("Thank you for the Evaluation");

          

        }

        public void CheckCustomer()
        {

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);



            string sql = "select * from tbl_report_evaluation where customer_ID = '" + userid1 + "' and driver_ID = '" + driver_id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader reader;

            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    btnReserve1.Enabled = false;
                }
                else
                {
                    btnReserve1.Enabled = true;
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
        private void btnReserve1_Click(object sender, EventArgs e)
        {

            Verify();

            frmMainMenu ff = new frmMainMenu();
            ff.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            ff.Show();


        }

        private void lnkMyAccount_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMyAccount a = new frmMyAccount();
            a.sendData(userid1, fname1, lname1, email1);
            this.Hide();
            a.Show();
        }
    }
}
