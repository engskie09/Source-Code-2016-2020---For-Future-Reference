using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class Admin_and_Staff_Session1_Store_And_Products_ : Form
    {
        public Admin_and_Staff_Session1_Store_And_Products_()
        {
            InitializeComponent();
        }


        private void Admin_and_Staff_Session1_Store_And_Products__Load(object sender, EventArgs e)
        {
            panelProductlist.Location = new Point(34, 97);
            panelSellrecords.Location = new Point(34, 97);

            panelProductlist.Visible = true;
            panelSellrecords.Visible = false;
            setDGV_ProductList();            
        }

        //set dgvProductList value.
        private void setDGV_ProductList()
        {
            systemMethods_Admin_and_Staff_Session.get_product();
            dgvProductList.AutoGenerateColumns = false;
            dgvProductList.Columns[0].DataPropertyName = "Product_Name";
            dgvProductList.Columns[1].DataPropertyName = "Product_Price";
            dgvProductList.Columns[2].DataPropertyName = "Product_Quantity";
            dgvProductList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvProductList.DataSource = systemMethods_Admin_and_Staff_Session.dt;
        }

        //set dgvSalesrecord value.
        private void setDGV_Salesrecord()
        {
            systemMethods_Admin_and_Staff_Session.get_salesrecord();
            dgvSalesrecord.AutoGenerateColumns = false;
            dgvSalesrecord.Columns[0].DataPropertyName = "Product_Name";
            dgvSalesrecord.Columns[1].DataPropertyName = "Member_Name";
            dgvSalesrecord.Columns[2].DataPropertyName = "Product_Quantity";
            dgvSalesrecord.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataTable dt = new DataTable();
            dt = systemMethods_Admin_and_Staff_Session.dt;
            dgvSalesrecord.DataSource = dt;
 
        }     


        private void btnShowWorkoutlogOrWorkoutlist_Click(object sender, EventArgs e)
        {
           
            if (panelProductlist.Visible)
            {
                panelProductlist.Visible = false;
                panelSellrecords.Visible = true;
                setDGV_Salesrecord();
            }

            else if (panelSellrecords.Visible)
            {
                panelSellrecords.Visible = false;
                panelProductlist.Visible = true;
                setDGV_ProductList();
            }

        }

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            Admin_and_Staff_Session1_Store_And_Products_Add_Product__ navigate = new Admin_and_Staff_Session1_Store_And_Products_Add_Product__();
            navigate.ShowDialog();
            setDGV_ProductList();
            
        }

        private void btnSellproduct_Click(object sender, EventArgs e)
        {
            Admin_and_Staff_Session1_Store_And_Products_Sell_Product__ navigate = new Admin_and_Staff_Session1_Store_And_Products_Sell_Product__();
            navigate.ShowDialog();           
            setDGV_Salesrecord();
            
        }
    }
}
