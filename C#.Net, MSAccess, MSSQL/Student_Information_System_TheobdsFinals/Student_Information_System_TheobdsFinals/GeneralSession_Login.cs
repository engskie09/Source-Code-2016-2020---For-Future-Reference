using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System_TheobdsFinals
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

        private void txt_getUsername_Enter(object sender, EventArgs e)
        {
            if (txt_getUsername.Text.Contains("Enter your Username"))
            {
                txt_getUsername.Clear();
            }
        }

        private void txt_getUserpassword_Enter(object sender, EventArgs e)
        {
            if (txt_getUserpassword.Text.Contains("Enter your Password"))
            {
                txt_getUserpassword.Clear();
            }
        }

        private void txt_getUsername_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getUsername.Text.Trim()))
            {
                txt_getUsername.Text = "Enter your Username";
            }
        }        

        private void txt_getUserpassword_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getUserpassword.Text.Trim()))
            {
                txt_getUserpassword.Text = "Enter your Password";
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (SystemMethods_GeneralSession.select_userInformation(txt_getUsername.Text, txt_getUserpassword.Text))
            {
                GeneralSession_MessageBox.Show("Login Attempt","You`ve been login Successfully....");
                GeneralSession_Main navigate = new GeneralSession_Main();
                navigate.Show();
                this.Hide();
            }

            else
                GeneralSession_MessageBox.Show("Login Attempt", "Try Again....");
        }

        
    }
}
