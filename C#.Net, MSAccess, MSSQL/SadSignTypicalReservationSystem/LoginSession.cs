using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SadSignTypicalReservationSystem
{
    public partial class LoginSession : Form
    {
        public LoginSession()
        {
            InitializeComponent();

        }

        private void LoginSession_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            
            SystemMethodsGeneral.getLoginSessionName(txtsetUsername.Text.Trim(), txtsetPassword.Text.Trim());
            if (SystemMethodsGeneral.checkAccountExist)
            {
                SystemMethodsGeneral.checkAccountExist = false;

                if (SystemMethodsGeneral.getUserType == "Customer")
                {
                    SystemMethodsCustomer.LoginSessionCustomer(txtsetUsername.Text.Trim(), txtsetPassword.Text.Trim());

                    CustomerSession1_Main_ navigate = new CustomerSession1_Main_();
                    navigate.Show();
                    txtsetUsername.Clear();
                    txtsetPassword.Clear();
                    this.Hide();
                }

                else if (SystemMethodsGeneral.getUserType == "Staff")
                {
                    SystemMethodsStaff.LoginSessionStaff(txtsetUsername.Text.Trim(), txtsetPassword.Text.Trim());

                    StaffSession1_Main_ navigate = new StaffSession1_Main_();
                    navigate.Show();
                    txtsetUsername.Clear();
                    txtsetPassword.Clear();
                    this.Hide();
                }
                
            }

            else
            {
                MessageBox.Show("Try Again!");
            }
        }

        private void btnExitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
