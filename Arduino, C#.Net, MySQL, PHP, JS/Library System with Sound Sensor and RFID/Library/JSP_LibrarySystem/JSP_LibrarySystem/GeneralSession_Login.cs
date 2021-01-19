using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSP_LibrarySystem
{
    public partial class GeneralSession_Login : Form
    {
        public GeneralSession_Login()
        {
            InitializeComponent();
        }

        private void GeneralSession_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String get_UserRole = SystemMethods_GeneralSession.get_UserLoginCredentials(txt_getUserName.Text.Trim(), txt_getUserPassword.Text.Trim());

            if (get_UserRole == "Admin")
            {
                MessageBox.Show("Hi Admin");
                AdminSession_Main navigate = new AdminSession_Main();
                navigate.Show();
                txt_getUserName.Clear();
                txt_getUserPassword.Clear();
                this.Hide();
    
            }

            else if (get_UserRole == "Staff")
            {
                MessageBox.Show("Hi Staff");
                AdminSession_Main navigate1 = new AdminSession_Main();
                navigate1.Show();
                txt_getUserName.Clear();
                txt_getUserPassword.Clear();
                this.Hide();
            }



             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
