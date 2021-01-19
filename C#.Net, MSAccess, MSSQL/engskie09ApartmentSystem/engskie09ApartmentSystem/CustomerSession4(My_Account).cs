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
    public partial class CustomerSession4_My_Account_ : Form
    {
        public CustomerSession4_My_Account_()
        {
            InitializeComponent();
            
        }
                

        private void CustomerSession4_My_Account__Load(object sender, EventArgs e)
        {
            setCustomerInformation();
          
        }
      
        private void setCustomerInformation()
        {
            lblgetCustomerFirstname.Text    = SystemMethodsCustomer.setCustomerFirstname;
            lblgetCustomerMiddlename.Text   = SystemMethodsCustomer.setCustomerMiddlename;
            lblgetCustomerLastname.Text     = SystemMethodsCustomer.setCustomerLastname;
            lblgetCustomerBirthday.Text     = SystemMethodsCustomer.setCustomerBirthday;
            lblgetCustomerGender.Text       = SystemMethodsCustomer.setCustomerGender;
            lblgetCustomerAge.Text          = SystemMethodsCustomer.setCustomerAge;
            lblgetCustomerid.Text           = SystemMethodsCustomer.setCustomerID;
            lblgetCustomerUsername.Text     = SystemMethodsCustomer.setCustomerUsername;
            lblgetCustomerPassword.Text     = SystemMethodsCustomer.setCustomerPassword;

            string setCustomerPasswordtoPasswordchar = "";

            foreach (char ch in lblgetCustomerPassword.Text.ToCharArray())
            {
                setCustomerPasswordtoPasswordchar = setCustomerPasswordtoPasswordchar+ "*";               
            }
            lblgetCustomerPassword.Text = setCustomerPasswordtoPasswordchar;
        }
 
        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pctBoxShowpassword_Click(object sender, EventArgs e)
        {
            if (lblgetCustomerPassword.Text.Contains("*"))
                lblgetCustomerPassword.Text = SystemMethodsCustomer.setCustomerPassword;
            else
                setCustomerInformation();
        }             
    }
}
