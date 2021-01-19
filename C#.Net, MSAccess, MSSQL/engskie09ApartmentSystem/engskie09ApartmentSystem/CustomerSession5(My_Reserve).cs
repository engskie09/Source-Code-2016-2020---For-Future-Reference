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
    public partial class CustomerSession5_My_Reserve_ : Form
    {                                                                                   
        public CustomerSession5_My_Reserve_()
        {
            InitializeComponent();
        }

        private void CustomerSession5_My_Reserve__Load(object sender, EventArgs e)
        {
            setCustomerRoomInformation();
        }

        private String getCustomer_Firstname    = "";
        private String getCustomer_Middlename = "";
        private String getCustomer_Lastname = "";
        private String getCustomer_CheckinDate = "";
        private String getCustomer_CheckoutDate = "";
        private String getCustomer_RoomNo = "";
        private String getCustomer_FloorNo = "";
        private String getCustomer_RoomType = "";
        private String getCustomer_RoomAmount = "";
        private String getCustomer_TotalAmount = "";

        private void setCustomerRoomInformation()
        {

            getCustomer_Firstname       = SystemMethodsCustomer.setCustomerRoomInformation_FirstName;
            getCustomer_Middlename      = SystemMethodsCustomer.setCustomerRoomInformation_MiddleName;
            getCustomer_Lastname        = SystemMethodsCustomer.setCustomerRoomInformation_LastName;
            getCustomer_CheckinDate     = SystemMethodsCustomer.setCustomerRoomInformation_CheckInDate;
            getCustomer_CheckoutDate    = SystemMethodsCustomer.setCustomerRoomInformation_CheckOutDate;
            getCustomer_RoomNo          = SystemMethodsCustomer.setCustomerRoomInformation_RoomNo;
            getCustomer_FloorNo         = SystemMethodsCustomer.setCustomerRoomInformation_FloorNo;
            getCustomer_RoomType        = SystemMethodsCustomer.setCustomerRoomInformation_RoomType;
            getCustomer_RoomAmount      = SystemMethodsCustomer.setCustomerRoomInformation_RoomAmount;
            getCustomer_TotalAmount     = SystemMethodsCustomer.setCustomerTotalAmount;

            lblgetCustomerFirstname.Text = getCustomer_Firstname;
            lblgetCustomerMiddlename.Text = getCustomer_Middlename;
            lblgetCustomerLastname.Text = getCustomer_Lastname;
            lblgetCustomerCheckinDate.Text = getCustomer_CheckinDate;
            lblgetCustomerCheckoutDate.Text = getCustomer_CheckoutDate;

            lblgetCustomerRoomNo_FloorNo.Text = getCustomer_RoomNo + "-" + getCustomer_FloorNo + " Floor";
            lblgetCustomerRoomType_RoomAmount.Text = getCustomer_RoomType + "-" + getCustomer_RoomAmount + " Pesos";
            lblgetCustomerTotalAmount.Text = getCustomer_TotalAmount;
        }      

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
