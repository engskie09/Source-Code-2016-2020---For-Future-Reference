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
    public partial class Admin_and_Staff_Session1_Store_And_Products_Add_Product__ : Form
    {
        public Admin_and_Staff_Session1_Store_And_Products_Add_Product__()
        {
            InitializeComponent();
        }      

        private void Admin_and_Staff_Session1_Store_And_Products_Add_Product___Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            String getProduct_Name = txtsetProductname.Text;
            Int32 getProduct_Price = Convert.ToInt32(txtsetProductprice.Text);
            String getProduct_Quantity = txtsetProductquantity.Text;

            systemMethods_Admin_and_Staff_Session.set_product(getProduct_Name, getProduct_Price, getProduct_Quantity);

            this.Close();
           
        }

        
    }
}
