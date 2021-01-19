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

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
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

        private void linklblMemberRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationSession navigate = new RegistrationSession();
            navigate.ShowDialog();
            
        }

        public static String setSessionName = systemMethods_GeneralSession.setSessionName;
       
        private void btnLogin_Click(object sender, EventArgs e)
        {
       
            String setUsername = txtgetUsername.Text.Trim();
            String setPassword = txtgetPassword.Text.Trim();            

            if (setUsername != "" && setPassword != "")
            {
                systemMethods_GeneralSession.checkIfMemberExist(setUsername, setPassword);

                if (systemMethods_GeneralSession.AccountExist)
                {
                    if (systemMethods_GeneralSession.setSessionName == "Admin")
                    {
                        AdminSession navigate = new AdminSession();
                        navigate.Show();
                        this.Hide();
                    }

                    else if (systemMethods_GeneralSession.setSessionName == "staff")
                    {
                        MessageBox.Show("staff");
                    }

                    else if (systemMethods_GeneralSession.setSessionName == "Customer")
                    {
                        //CustomerSession navigate = new CustomerSession();
                        //navigate.Show();
                        //this.Hide();
                    }

                }
            }

            else
            {
                GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Please Don`t leave blank!";
                GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                navigate.ShowDialog();
            }
            setUsername = "";
            setPassword = "";
            txtgetUsername.Text = "";
            txtgetPassword.Text = "";
            
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
    }
}
