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


namespace JSP_LibrarySystem
{
    public partial class AdminSession_MyAccount : Form
    {
        public AdminSession_MyAccount()
        {
            InitializeComponent();
            Oldpasswordtxt.UseSystemPasswordChar = true;
            NewPasstxt.UseSystemPasswordChar = true;
           
        }

        public static String connectionString = "server=localhost;userid=root;database=db_jplhs_librarysystem";

        private static MySqlConnection connection = new MySqlConnection(connectionString); 

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (Usernametxt.Text == "" || Oldpasswordtxt.Text == "" || NewPasstxt.Text == "")
            {
                MessageBox.Show("PLEASE FILL THE FOLLOWING!");
            }

            else if (NewPasstxt.Text.Length < 6)
            {
                MessageBox.Show("Passwords must be at least 6 characters long");
                return;


            }
            else
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tbl_user_logincredentials set user_password='" + NewPasstxt.Text + "' where user_name ='" + Usernametxt.Text + "'";
                cmd.ExecuteNonQuery();
                MySqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update tbl_user_information set user_password='" + NewPasstxt.Text + "' where user_name ='" + Usernametxt.Text + "'";
                cmd1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Password Changed Successfully");
            }

            

            
        }
        
        private void showoldpasswordtxt_CheckedChanged(object sender, EventArgs e)
        {
            
            if (!showoldpasswordtxt.Checked)
            {
                showoldpasswordtxt.Text = "Hide Password";
                
                Oldpasswordtxt.UseSystemPasswordChar =true;
            }
            else
            {
                showoldpasswordtxt.Text = "Show Password";
                Oldpasswordtxt.UseSystemPasswordChar = false;
            }
            
        }

        private void AdminSession_MyAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void ShowNewPasswordtxt_CheckedChanged(object sender, EventArgs e)
        {
            if (!ShowNewPasswordtxt.Checked)
            {
                ShowNewPasswordtxt.Text = "Hide Password";
                NewPasstxt.UseSystemPasswordChar = true;
            }

            else
            {
                ShowNewPasswordtxt.Text = "Show Password";
                NewPasstxt.UseSystemPasswordChar = false;
            }
       }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
