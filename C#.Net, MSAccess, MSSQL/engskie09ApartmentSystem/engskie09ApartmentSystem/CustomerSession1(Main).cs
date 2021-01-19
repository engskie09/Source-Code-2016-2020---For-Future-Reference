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
    public partial class CustomerSession1_Main_ : Form
    {
        public CustomerSession1_Main_()
        {
            InitializeComponent();
        }
       
        private void CustomerSession1_Main__Load(object sender, EventArgs e)
        {
            timergetCurrentime.Start();
            setCustomerInformation();            
        }

        //get Customer Infromation.
        private String getCustomerFirstname = "";
        private String getCustomerMiddlename = "";
        private String getCustomerLastname = "";
        private String getCustomerBirthday = "";
        private String getCustomerGender = "";
        private String getCustomerAge = "";
        private String getCustomerID = "";
        private String getCustomerUsername = "";
        private String getCustomerPassword = "";

        Int32 getCustomerRoomNo;

        //get Boolean if already Check in.
        Boolean setIfDateisBetween;

        //get Boolean to get Room No if Customer already Checkin.
        Boolean checkCustomerRoomNoIfAlreadycheckin;

        

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
            getCustomerFirstname = SystemMethodsCustomer.setCustomerFirstname;
            getCustomerMiddlename = SystemMethodsCustomer.setCustomerMiddlename;
            getCustomerLastname = SystemMethodsCustomer.setCustomerLastname;
            getCustomerBirthday = SystemMethodsCustomer.setCustomerBirthday;
            getCustomerGender = SystemMethodsCustomer.setCustomerGender;
            getCustomerAge = SystemMethodsCustomer.setCustomerAge;
            getCustomerID = SystemMethodsCustomer.setCustomerID;
            getCustomerUsername = SystemMethodsCustomer.setCustomerUsername;
            getCustomerPassword = SystemMethodsCustomer.setCustomerPassword;

            lblsetCustomerFullname.Text = getCustomerFirstname + " " + getCustomerMiddlename + " " + getCustomerLastname;
            lblsetCustomerID.Text = getCustomerID;
        }
        
        private void timergetCurrentime_Tick(object sender, EventArgs e)
        {
            lblSetCurrenttime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnViewrooms_Click(object sender, EventArgs e)
        {
            CustomerSession3_View_Rooms_ navigate = new CustomerSession3_View_Rooms_();
            navigate.ShowDialog();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            SystemMethodsCustomer.setCheckinValidation(getCustomerID);
            setIfDateisBetween = SystemMethodsCustomer.checkIfDateisBetween;

            if (setIfDateisBetween)
            {
                GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                GeneralSession_MessageBox_OK_.getValidationMessage = "You are already check-in!!!";
                navigate.ShowDialog();
            }

            else
            {
                CustomerSession2_Check_In_ navigate = new CustomerSession2_Check_In_();
                navigate.ShowDialog();               
            }
        }

        private void btnMyaccount_Click(object sender, EventArgs e)
        {
            CustomerSession4_My_Account_ navigate = new CustomerSession4_My_Account_();
            navigate.ShowDialog();

            Control[] ctrls = navigate.Controls.Find("lblgetCustomerFirstname", false);
            if (ctrls.Length > 0)
            {
                Label lbl = (Label)ctrls[0];
                lbl.Text = "Hello";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginSession navigate = new LoginSession();
            navigate.Show();
            this.Close();
        }

        private void btnExitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            SystemMethodsCustomer.getsetRoomNobyCustomerIDsetBooleanToCheckOut(getCustomerID);
            checkCustomerRoomNoIfAlreadycheckin = SystemMethodsCustomer.checkCustomerRoomNoIfcheckin;

            if (checkCustomerRoomNoIfAlreadycheckin)
            {
                getCustomerRoomNo = SystemMethodsCustomer.getCustomerRoomNo;
                MessageBox.Show(getCustomerRoomNo.ToString());
                SystemMethodsCustomer.select_customerCurrentReserve(getCustomerID);
                CustomerSession6_Check_Out_Receipt_ navigate = new CustomerSession6_Check_Out_Receipt_();
                navigate.ShowDialog();

                SystemMethodsCustomer.setRoomAvailabilityWhenCheckout(getCustomerRoomNo);
                SystemMethodsCustomer.delete_customerCheckinInformation(getCustomerID);

            
            }

            else
            {
                GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();                
                GeneralSession_MessageBox_OK_.getValidationMessage = "You are not checked-in !!";
                navigate.ShowDialog();
                
            }

        }

        private void btnMyReserve_Click(object sender, EventArgs e)
        {
            SystemMethodsCustomer.getsetRoomNobyCustomerIDsetBooleanToCheckOut(getCustomerID);
            checkCustomerRoomNoIfAlreadycheckin = SystemMethodsCustomer.checkCustomerRoomNoIfcheckin;

            if (checkCustomerRoomNoIfAlreadycheckin)
            {
                SystemMethodsCustomer.select_customerCurrentReserve(getCustomerID);
                CustomerSession5_My_Reserve_ navigate = new CustomerSession5_My_Reserve_();
                navigate.ShowDialog();
            }

            else
            {
                GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                GeneralSession_MessageBox_OK_.getValidationMessage = "You are not checked-in !!";

                //MessageBox.Show(GeneralSession_MessageBox_OK_.getValidationMessage);

                navigate.ShowDialog();
            }
        }
    }
}
