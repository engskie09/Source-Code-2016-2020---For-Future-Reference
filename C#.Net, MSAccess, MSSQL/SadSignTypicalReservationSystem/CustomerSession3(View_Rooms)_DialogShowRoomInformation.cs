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
    public partial class CustomerSession3_View_Rooms__DialogShowRoomInformation : Form
    {
        public CustomerSession3_View_Rooms__DialogShowRoomInformation()
        {
            InitializeComponent();
        }

        public static Int32 getRoomNo;

        private void CustomerSession3_View_Rooms__DialogShowRoomInformation_Load(object sender, EventArgs e)
        {
            SystemMethodsGeneral.getRoomInformation(getRoomNo);
            setCustomerRoomInformation();
            setImageAvailability(SystemMethodsGeneral.setRoomAvailability);
        }
     
        public void setCustomerRoomInformation()
        {

            if (SystemMethodsGeneral.setRoomNo == 0)
            {
                MessageBox.Show("This Room doesn`t exist!");
                this.Close();   
                return;                
            }
            lblgetRoomNo.Text = SystemMethodsGeneral.setRoomNo.ToString();
            lblgetFloorNo.Text = SystemMethodsGeneral.setFloorNo;
            lblgetRoomType.Text = SystemMethodsGeneral.setRoomType;
            lblgetRoomAmount.Text = SystemMethodsGeneral.setRoomAmount.ToString();
            lblgetRoomAvailability.Text = SystemMethodsGeneral.setRoomAvailability;

        }

        public void setImageAvailability(String getRoomAvailability)
        {
            if (getRoomAvailability == "0")
            {
                MessageBox.Show("Available");
                pctbxgetAvailability.BackgroundImage = Properties.Resources.AvailableSign;
            }
            else if (getRoomAvailability == "1")
            {   
                MessageBox.Show("Not Available");
                pctbxgetAvailability.BackgroundImage = Properties.Resources.NotAvailableSign;
            }
        }      

        
        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();          
        }
        
    }
}
