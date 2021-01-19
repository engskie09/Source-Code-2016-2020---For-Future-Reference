﻿using System;
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
    public partial class CustomerSession2_Check_In_ : Form
    {
        public CustomerSession2_Check_In_()
        {
            InitializeComponent();
        }

        private void CustomerSession2_Check_In__Load(object sender, EventArgs e)
        {
            setCustomerInformation();
        }

        //getCustomerinformation
        String getCustomerFirstname = SystemMethodsCustomer.setCustomerFirstname;
        String getCustomerMiddlename = SystemMethodsCustomer.setCustomerMiddlename;
        String getCustomerLastname = SystemMethodsCustomer.setCustomerLastname;
        String getCustomerBirthday = SystemMethodsCustomer.setCustomerBirthday;
        String getCustomerGender = SystemMethodsCustomer.setCustomerGender;
        String getCustomerAge = SystemMethodsCustomer.setCustomerAge;
        String getCustomerID = SystemMethodsCustomer.setCustomerID;
        String getCustomerUsername = SystemMethodsCustomer.setCustomerUsername;
        String getCustomerPassword = SystemMethodsCustomer.setCustomerPassword;
        String getCustomerCheckinDate = "";
        String getCustomerCheckoutDate= "";
        Int32 getCustomerLengthofstay = 0;
        Int32 getCustomerRoomNo = 0;
        String getCustomerRoomType = "";
        String getCustomerFloorNo = "";
        Int32 getCustomerRoomAmount = 0;
        Int32 getCustomerTotalAmount = 0;
        String getCustomerRoomAvailability = "";
        
        //getRoomNo
        public static Int32 getRoomNo;

     

        //set Customer Information to Display
        private void setCustomerInformation()
        {
            lblgetCustomerFullname.Text = getCustomerFirstname + " " + getCustomerMiddlename + " " + getCustomerLastname;
            lblgetCustomerID.Text = getCustomerID;
            lblgetCustomerGender.Text = getCustomerGender;

            DateTime dtm = DateTime.Now;
            lblgetCheckintDate.Text = dtm.ToString("dddd, MMMM d, yyyy");
        }
        
        //set CustomerInformation When Checkin
        private void setCustomerCheckinInformation()
        {       
           

            SystemMethodsCustomer.insert_CustomerCheckinInformation(getCustomerFirstname, getCustomerMiddlename, getCustomerLastname, getCustomerID, getCustomerGender,
                                          getCustomerCheckinDate, getCustomerCheckoutDate, getCustomerLengthofstay, getCustomerRoomNo,
                                          getCustomerRoomType, getCustomerFloorNo, getCustomerRoomAmount, getCustomerTotalAmount);

            SystemMethodsAdmin.insert_CustomerCheckInOutReport(getCustomerFirstname, getCustomerMiddlename, getCustomerLastname, getCustomerID, getCustomerGender,
                                          getCustomerCheckinDate, getCustomerCheckoutDate, getCustomerLengthofstay, getCustomerRoomNo,
                                          getCustomerRoomType, getCustomerFloorNo, getCustomerRoomAmount, getCustomerTotalAmount, "Check In");
        }

        //get Length of Stay by Months
        private void getCheckInOutTime()
        {
            DateTime getCurrentDate = Convert.ToDateTime(lblgetCheckintDate.Text);
            DateTime getSelectedDate = getCurrentDate.AddMonths(Convert.ToInt32(txtgetLengthofstay.Text));
            lblgetCheckoutDate.Text = getSelectedDate.ToString("dddd, MMMM d, yyyy");                       

            getCustomerCheckinDate  = getCurrentDate.ToString("MM/dd/yyyy");
            getCustomerCheckoutDate = getSelectedDate.ToString("MM/dd/yyyy");
            getCustomerLengthofstay = Convert.ToInt32(txtgetLengthofstay.Text); 
      
        }

        //set Room Information
        private void setRoomInformation()
        {
            getCustomerFloorNo    = SystemMethodsGeneral.setFloorNo;
            getCustomerRoomType   = SystemMethodsGeneral.setRoomType;
            getCustomerRoomAmount = SystemMethodsGeneral.setRoomAmount;
            getCustomerRoomAvailability = SystemMethodsGeneral.setRoomAvailability;

            if (getCustomerRoomAvailability == "0")
                lblgetCustomerRoomAvailability.Text = "Available";
            else if (getCustomerRoomAvailability == "1")
                lblgetCustomerRoomAvailability.Text = "Not Available";

            lblgetRoomType.Text     = getCustomerRoomType;
            lblgetFloorNo.Text      = getCustomerFloorNo;
            lblgetFloorAmount.Text = getCustomerRoomAmount.ToString();
            getCustomerTotalAmount = getCustomerRoomAmount * Convert.ToInt32(txtgetLengthofstay.Text.ToString());

            

            
        }
      

        private void btnViewrooms_Click(object sender, EventArgs e)
        {
            CustomerSession3_View_Rooms_ navigate = new CustomerSession3_View_Rooms_();
            navigate.ShowDialog();
        }

        private void btnCanceltransaction_Click(object sender, EventArgs e)
        {
            CustomerSession1_Main_ navigate = new CustomerSession1_Main_();
            navigate.Show(); 
            this.Close();
        }        

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (txtgetLengthofstay.Text == "" || txtGetRoomno.Text == "" || lblgetRoomType.Text == "")
            {
                GeneralSession_MessageBox_OK_ navigates = new GeneralSession_MessageBox_OK_();
                GeneralSession_MessageBox_OK_.getValidationMessage = "Please don`t leave blank!";
                navigates.ShowDialog();
                return;
                
            }

            else if (lblgetCustomerRoomAvailability.Text != "Available")
            {
                GeneralSession_MessageBox_OK_ navigates = new GeneralSession_MessageBox_OK_();
                GeneralSession_MessageBox_OK_.getValidationMessage = "This room is not currently Available!!";
                navigates.ShowDialog();
                return;
            }
               
            setCustomerCheckinInformation();
            SystemMethodsCustomer.setRoomAvailabilityWhenCheckin(getRoomNo);

            CustomerSession1_Main_ navigate = new CustomerSession1_Main_();
            navigate.Show();
            this.Close();
        }

        private void txtGetRoomno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                getRoomNo = Convert.ToInt32(txtGetRoomno.Text);
                getCustomerRoomNo = getRoomNo;
                SystemMethodsGeneral.getRoomInformation(getRoomNo);
                setRoomInformation();
            }
            catch { }
        }

        private void txtgetLengthofstay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                getCheckInOutTime();

                Int32 lengthofstay = Convert.ToInt32(txtgetLengthofstay.Text);
                if (lengthofstay >= 101)
                {
                    GeneralSession_MessageBox_OK_ navigates = new GeneralSession_MessageBox_OK_();
                    GeneralSession_MessageBox_OK_.getValidationMessage = "Length of stay is not Valid!!!";
                    navigates.ShowDialog();
                    txtgetLengthofstay.Text = "100";
                }
            }

            catch { }
        }

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            SystemGeneralValidations.txtBoxNumber(sender, e);
        }
        
    }
}
