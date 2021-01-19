using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Register_Reload_
{
    public partial class Cashier_Login_ : Form
    {
        MySqlConnection connection = new MySqlConnection(methods.con);
         int i;

        public static string Fname = "";
        public static string Lname = "";

        public Cashier_Login_()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
               
            try
            {
                connection.Open();

                i = 0;

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from cashieradmin Where Username='" + inputUsername.Text + "' and Password='" + inputPassword.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    if (inputUsername.Text == "" && inputPassword.Text == "")
                    {
                        MessageBox.Show("Please input your Username and Password");
                    }
                    else if (inputPassword.Text == "")
                    {
                        MessageBox.Show("Please input your Password");
                    }

                    else if (inputUsername.Text == "")
                    {
                        MessageBox.Show("Please input your Username");

                    }
                    else
                    {
                        login.Text = "Incorrect";
                        MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        login.Text = "Sign In";


                    }
                }

                else
                {

                    connection.Close();
                    connection.Open();


                    MySqlCommand cmdx = connection.CreateCommand();
                    cmdx.CommandType = CommandType.Text;
                    cmdx.CommandText = "Select Firstname,LastName from cashieradmin where Username='" + inputUsername.Text + "' ";
                    cmdx.ExecuteNonQuery();

                    DataTable dts = new DataTable();

                    MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);

                    xda.Fill(dts);


                    foreach (DataRow xdr in dts.Rows)


                    // fnamee
                    //  lnamee
                    // Mnamee
                    {
                        Fname = xdr["FirstName"].ToString() + " ";
                        Lname = xdr["LastName"].ToString() + " ";


                    }


                    connection.Close();

                    MessageBox.Show("Successfully Login");
                    Cashier_Main_ a = new Cashier_Main_();
                    a.Show();
                    this.Hide();
                }
            }


            catch (Exception)
            {

                MessageBox.Show("No Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    

        private void Cashier_Login__Load(object sender, EventArgs e)
        {
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cashier_ForgotPassword_ a = new Cashier_ForgotPassword_();
            a.Show();
            this.Hide();
        }
    }
}
