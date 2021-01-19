using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace engskie09ApartmentSystem
{
    public partial class CustomerSession6_Check_Out_Receipt_ : Form
    {
        public CustomerSession6_Check_Out_Receipt_()
        {
            InitializeComponent();
        }

        private void CustomerSession6_Check_Out_Receipt__Load(object sender, EventArgs e)
        {

            getCustomerInformation();
            setCustomerReceiptValue();
            this.customer_checkout_receipt.RefreshReport();

            
        }

        private String getCustomer_Firstname = "";
        private String getCustomer_Middlename = "";
        private String getCustomer_Lastname = "";
        private String getCustomer_CheckinDate = "";
        private String getCustomer_CheckoutDate = "";
        private String getCustomer_RoomNo = "";
        private String getCustomer_FloorNo = "";
        private String getCustomer_RoomType = "";
        private String getCustomer_RoomAmount = "";
        private String getCustomer_Lengthofstay = "";
        private String getCustomer_TotalAmount = "";

        private String getCustomer_WholeName = "";

        private String getCustomer_ID = "";
        private String getCustomer_Gender = "";
        private void getCustomerInformation()
        {

            getCustomer_Firstname = SystemMethodsCustomer.setCustomerRoomInformation_FirstName;
            getCustomer_Middlename = SystemMethodsCustomer.setCustomerRoomInformation_MiddleName;
            getCustomer_Lastname = SystemMethodsCustomer.setCustomerRoomInformation_LastName;
            getCustomer_CheckinDate = SystemMethodsCustomer.setCustomerRoomInformation_CheckInDate;
            getCustomer_CheckoutDate = SystemMethodsCustomer.setCustomerRoomInformation_CheckOutDate;
            getCustomer_RoomNo = SystemMethodsCustomer.setCustomerRoomInformation_RoomNo;
            getCustomer_FloorNo = SystemMethodsCustomer.setCustomerRoomInformation_FloorNo;
            getCustomer_RoomType = SystemMethodsCustomer.setCustomerRoomInformation_RoomType;
            getCustomer_RoomAmount = SystemMethodsCustomer.setCustomerRoomInformation_RoomAmount;
            getCustomer_Lengthofstay = SystemMethodsCustomer.setCustomerLengthofStay;
            getCustomer_TotalAmount = SystemMethodsCustomer.setCustomerTotalAmount;
            getCustomer_Gender = SystemMethodsCustomer.setCustomerGender; 
            getCustomer_ID = SystemMethodsCustomer.setCustomerID;
            getCustomer_WholeName = getCustomer_Firstname + " " + getCustomer_Middlename + " " + getCustomer_Lastname;

            //MessageBox.Show(getCustomer_WholeName);

            SystemMethodsAdmin.insert_CustomerCheckInOutReport(getCustomer_Firstname, getCustomer_Middlename, getCustomer_Lastname, getCustomer_ID, getCustomer_Gender,
                                          getCustomer_CheckinDate, getCustomer_CheckoutDate, Convert.ToInt32(getCustomer_Lengthofstay), Convert.ToInt32(getCustomer_RoomNo),
                                          getCustomer_RoomType, getCustomer_FloorNo, Convert.ToInt32(getCustomer_RoomAmount), Convert.ToInt32(getCustomer_TotalAmount), "Check Out"); 

        }

        private void setCustomerReceiptValue()
        {

            ReportParameterCollection rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("getWholeName", getCustomer_WholeName));
            rpc.Add(new ReportParameter("getRoomNo", getCustomer_RoomNo));
            rpc.Add(new ReportParameter("getFloorNo", getCustomer_FloorNo));
            rpc.Add(new ReportParameter("getRoomAmount", getCustomer_RoomAmount));
            rpc.Add(new ReportParameter("getLengthofstay", getCustomer_Lengthofstay));
            rpc.Add(new ReportParameter("getTotalAmount", getCustomer_TotalAmount));
            
      
            
            this.customer_checkout_receipt.LocalReport.SetParameters(rpc);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
