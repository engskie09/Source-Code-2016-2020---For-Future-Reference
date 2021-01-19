using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class Admin_and_Staff_Session1_Store_And_Products_Sell_Product__ : Form
    {
        public Admin_and_Staff_Session1_Store_And_Products_Sell_Product__()
        {
            InitializeComponent();
        }      

        private void Admin_and_Staff_Session1_Store_And_Products_Sell_Product___Load(object sender, EventArgs e)
        {
            DateTime dtmsetCurrentDate = DateTime.Now;
            lblgetCurrentDate.Text = dtmsetCurrentDate.ToString("MM/dd/yyyy");
            setcmBox_Productname();
            setcmBox_CustomerFullname();
        }

        //get Customer_Fullname and product Information.
        String getCustomer_Fullname = "";
        String getProduct_Name = "";
        //Int32 getProduct_Price = 0;
        Int32 getProduct_Quantity = 0;

        private void setcmBox_Productname()
        {
            systemMethods_Admin_and_Staff_Session.get_product();

            for (int x = 0; x <= systemMethods_Admin_and_Staff_Session.getProductName.Count - 1; x++)
            {
                cmBoxgetProductname.Items.Add(systemMethods_Admin_and_Staff_Session.getProductName[x]);
            }
        }

        private void setcmBox_CustomerFullname()
        {
            systemMethods_Admin_and_Staff_Session.getset_CustomerFullname();

            for (int x = 0; x <= systemMethods_Admin_and_Staff_Session.getCustomerFullName.Count - 1; x++)
            {
                cmBoxgetCustomerFullname.Items.Add(systemMethods_Admin_and_Staff_Session.getCustomerFullName[x]);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSellproduct_Click(object sender, EventArgs e)
        {
            getCustomer_Fullname = cmBoxgetCustomerFullname.Text;
            getProduct_Name = cmBoxgetProductname.Text;
            //getProduct_Price = 0;           
            getProduct_Quantity = Convert.ToInt32(txtsetProductquantityTobuy.Text);

            systemMethods_Admin_and_Staff_Session.getset_sellProduct(getProduct_Name, getProduct_Quantity);
            systemMethods_Admin_and_Staff_Session.setproduct_salesreport(getCustomer_Fullname, getProduct_Name, getProduct_Quantity);

            this.Close();
        }

        
    }
}
