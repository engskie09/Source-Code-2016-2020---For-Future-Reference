using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engskie09ApartmentSystem
{
    public partial class AdminSession4_My_Account_ : Form
    {
        public AdminSession4_My_Account_()
        {
            InitializeComponent();
            
        }


        private void AdminSession4_My_Account__Load(object sender, EventArgs e)
        {
            setCustomerInformation();
          
        }
      
        private void setCustomerInformation()
        {        

            lblgetAdminFirstname.Text    = SystemMethodsAdmin.setAdminFirstname;
            lblgetAdminMiddlename.Text   = SystemMethodsAdmin.setAdminMiddlename;
            lblgetAdminLastname.Text     = SystemMethodsAdmin.setAdminLastname;
            lblgetAdminBirthday.Text     = SystemMethodsAdmin.setAdminBirthday;
            lblgetAdminGender.Text       = SystemMethodsAdmin.setAdminGender;
            lblgetAdminAge.Text          = SystemMethodsAdmin.setAdminAge;
            lblgetAdminid.Text           = SystemMethodsAdmin.setAdminID;
            lblgetAdminUsername.Text     = SystemMethodsAdmin.setAdminUsername;
            lblgetAdminPassword.Text     = SystemMethodsAdmin.setAdminPassword;

            string setCustomerPasswordtoPasswordchar = "";

            foreach (char ch in lblgetAdminPassword.Text.ToCharArray())
            {
                setCustomerPasswordtoPasswordchar = setCustomerPasswordtoPasswordchar+ "*";               
            }
            lblgetAdminPassword.Text = setCustomerPasswordtoPasswordchar;
        }
 
        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBoxShowpassword_Click(object sender, EventArgs e)
        {
            if (lblgetAdminPassword.Text.Contains("*"))
                lblgetAdminPassword.Text = SystemMethodsAdmin.setAdminPassword;
            else
                setCustomerInformation();
        }

      

        private void btnShowTxtChangepassword_Click_1(object sender, EventArgs e)
        {
            if (txtgetNewPassword.Visible)
                txtgetNewPassword.Visible = false;
            else
                txtgetNewPassword.Visible = true;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            SystemMethodsAdmin.updateAdminPassword(lblgetAdminid.Text, txtgetNewPassword.Text);
        }             
    }
}
