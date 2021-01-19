using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CanteenManager
{
    public partial class Form1 : Form
    {
        string connetionString = null;
        string server = "localhost";
        string database = "canteen_db";
        string username = "root";
        string password = "";
        int i;

        public static string Fname = "";
        public static string Lname = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            MySqlConnection cnn;
            connetionString = "server=" + server + ";database=" + database + ";Username=" + username + ";Password=" + password + ";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                i = 0;

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Managerlogin Where Username='" + Username.Text + "' and Password='" + Password.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    if (Username.Text == "" && Password.Text == "")
                    {
                        MessageBox.Show("Please input your Username and Password");
                    }
                    else if (Password.Text == "")
                    {
                        MessageBox.Show("Please input your Password");
                    }

                    else if (Username.Text == "")
                    {
                        MessageBox.Show("Please input your Username");

                    }
                    else
                    {
                        Signin.Text = "Incorrect";
                        MessageBox.Show("Incorrect Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Signin.Text = "Sign In";


                    }
                }

                else
                {

                    cnn.Close();
                    cnn.Open();


                    MySqlCommand cmdx = cnn.CreateCommand();
                    cmdx.CommandType = CommandType.Text;
                    cmdx.CommandText = "Select Firstname,LastName from managerlogin where Username='" + Username.Text + "' ";
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


                    cnn.Close();

                    MessageBox.Show("Successfully Login");
                    Main a = new Main();
                    a.Show();
                    this.Hide();
                }
            }

            
            catch (Exception)
            {

                MessageBox.Show("No Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

