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
        /*                            
        --------------------------------------------------------------------------------------------------------------
        8 888888888o      .8.    8888888 8888888888 8 888888888o.    8 8888     ,o888888o.     8 8888          .8.          
        8 8888    `88.   .888.         8 8888       8 8888    `88.   8 8888    8888     `88.   8 8888         .888.         
        8 8888     `88  :88888.        8 8888       8 8888     `88   8 8888 ,8 8888       `8.  8 8888        :88888.        
        8 8888     ,88 . `88888.       8 8888       8 8888     ,88   8 8888 88 8888            8 8888       . `88888.       
        8 8888.   ,88'.8. `88888.      8 8888       8 8888.   ,88'   8 8888 88 8888            8 8888      .8. `88888.      
        8 888888888P'.8`8. `88888.     8 8888       8 888888888P'    8 8888 88 8888            8 8888     .8`8. `88888.     
        8 8888      .8' `8. `88888.    8 8888       8 8888`8b        8 8888 88 8888            8 8888    .8' `8. `88888.    
        8 8888     .8'   `8. `88888.   8 8888       8 8888 `8b.      8 8888 `8 8888       .8'  8 8888   .8'   `8. `88888.   
        8 8888    .888888888. `88888.  8 8888       8 8888   `8b.    8 8888    8888     ,88'   8 8888  .888888888. `88888.  
        8 8888   .8'       `8. `88888. 8 8888       8 8888     `88.  8 8888     `8888888P'     8 8888 .8'       `8. `88888.
        --------------------------------------------------------------------------------------------------------------
        */
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
        /*                            
        --------------------------------------------------------------------------------------------------------------
        8 888888888o      .8.    8888888 8888888888 8 888888888o.    8 8888     ,o888888o.     8 8888          .8.          
        8 8888    `88.   .888.         8 8888       8 8888    `88.   8 8888    8888     `88.   8 8888         .888.         
        8 8888     `88  :88888.        8 8888       8 8888     `88   8 8888 ,8 8888       `8.  8 8888        :88888.        
        8 8888     ,88 . `88888.       8 8888       8 8888     ,88   8 8888 88 8888            8 8888       . `88888.       
        8 8888.   ,88'.8. `88888.      8 8888       8 8888.   ,88'   8 8888 88 8888            8 8888      .8. `88888.      
        8 888888888P'.8`8. `88888.     8 8888       8 888888888P'    8 8888 88 8888            8 8888     .8`8. `88888.     
        8 8888      .8' `8. `88888.    8 8888       8 8888`8b        8 8888 88 8888            8 8888    .8' `8. `88888.    
        8 8888     .8'   `8. `88888.   8 8888       8 8888 `8b.      8 8888 `8 8888       .8'  8 8888   .8'   `8. `88888.   
        8 8888    .888888888. `88888.  8 8888       8 8888   `8b.    8 8888    8888     ,88'   8 8888  .888888888. `88888.  
        8 8888   .8'       `8. `88888. 8 8888       8 8888     `88.  8 8888     `8888888P'     8 8888 .8'       `8. `88888.
        --------------------------------------------------------------------------------------------------------------
        */

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }             
    }
}
