using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pagawa_SarisariStoreOrderingSystem_
{
    public partial class ProductsXB : Form
    {
        public ProductsXB()
        {
            InitializeComponent();
        }

        OleDbConnection connectionXD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user01\Desktop\asd\Pagawa(SarisariStoreOrderingSystem)\Pagawa(SarisariStoreOrderingSystem)database.accdb");
       
        public void ProductsShow()
        {


            connectionXD.Close();
            connectionXD.Open();
            OleDbCommand command = connectionXD.CreateCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            command.CommandText = "SELECT * FROM ProductsInfo";
            command.ExecuteNonQuery();
            adapter.Fill(table);

            productsDATAGRIDVIEW.AutoGenerateColumns = false;

            productsDATAGRIDVIEW.Columns[0].DataPropertyName = "ID";
            productsDATAGRIDVIEW.Columns[1].DataPropertyName = "Product_Name";
            productsDATAGRIDVIEW.Columns[2].DataPropertyName = "Product_Cost";
            productsDATAGRIDVIEW.Columns[3].DataPropertyName = "Product_Quantity";


            productsDATAGRIDVIEW.DataSource = table;

            connectionXD.Close();


        }

        public void AddProduct()
        {
            try
            {
                connectionXD.Close();
                connectionXD.Open();
                OleDbCommand command = connectionXD.CreateCommand();
                command.CommandText = "INSERT INTO ProductsInfo(Product_Name, Product_Cost, Product_Quantity, Product_Sold) Values('" + txtproductNameAdd.Text.Trim() + "','"
                                                                                                                        + txtproductPriceAdd.Text.Trim() + "','"
                                                                                                                        + txtproductQuantityAdd.Text.Trim() + "','" + 0 + "')";
                command.ExecuteNonQuery();
                connectionXD.Close();
            }
            catch
            {
            }

        }

        public void UpdateProduct()
        {

            connectionXD.Close();
            connectionXD.Open();

            OleDbCommand cmd = connectionXD.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE ProductsInfo SET Product_Name =@x1, Product_Cost = @x2, Product_Quantity = @x3 WHERE ID = @x4  ";
            //"update ProductInventory set Product_Name = @x1, Product_Category = @x2, Product_Description = @x3, Product_Cost = @x4, Product_Picture = @x5 where ID = @x6 ";

            cmd.Parameters.AddWithValue("@x1", txtproductNameUpdate.Text.Trim());
            cmd.Parameters.AddWithValue("@x2", txtproductPriceUpdate.Text.Trim());
            cmd.Parameters.AddWithValue("@x3", txtproductQuantityUpdate.Text.Trim());
            cmd.Parameters.AddWithValue("@x4", Convert.ToInt32(lblproductIdUpdate.Text.Trim()));
            cmd.ExecuteNonQuery();


            connectionXD.Close();

        }

       
        private void returnbtn_Click(object sender, EventArgs e)
        {
            login XB = new login();
            XB.Show();
            this.Hide();
        }

        private void salesbtn_Click(object sender, EventArgs e)
        {
            BentaXD wahaha = new BentaXD();
            wahaha.Show();
            this.Hide();
        }

        private void ProductsXB_Load(object sender, EventArgs e)
        {
            productsDATAGRIDVIEW.ColumnCount = 4;
            ProductsShow();

            productaddPANEL.Visible = false;
            productupdatePANEL.Visible = false;


            productaddPANEL.Location = new Point(15, 223);
            productupdatePANEL.Location = new Point(15, 223);
            
           
        }

        private void Showaddpanel_Click(object sender, EventArgs e)
        {
            productupdatePANEL.Visible = false;
            productaddPANEL.Visible = true;
        }

        private void Showupdatepanel_Click(object sender, EventArgs e)
        {
            productaddPANEL.Visible = false;
            productupdatePANEL.Visible = true;

        }

     
 
        private void addproductbtn_Click(object sender, EventArgs e)
        {
          
                AddProduct();
                productsDATAGRIDVIEW.DataSource = null;
                ProductsShow();
           
          
        }

        private void updateproductbtn_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateProduct();
                productsDATAGRIDVIEW.DataSource = null;
                ProductsShow();
            }
            catch
            {
                MessageBox.Show("Try Again!, Something Wrong.");
            }

        }

        int XD = 0;
      

        private void productsDATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                try
                {
                    XD = e.RowIndex;

                    DataGridViewRow XB = productsDATAGRIDVIEW.Rows[XD];
                    lblproductIdDelete.Text = XB.Cells[0].Value.ToString();
                    lblproductIdUpdate.Text = XB.Cells[0].Value.ToString();
                    txtproductNameUpdate.Text = XB.Cells[1].Value.ToString();
                    txtproductPriceUpdate.Text= XB.Cells[2].Value.ToString();
                    txtproductQuantityUpdate.Text = XB.Cells[3].Value.ToString();
                    


                }
                catch
                {
                    MessageBox.Show("Try Again!, Something Wrong.");
                }
            
        }

        
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connectionXD.Close();
                connectionXD.Open();

                OleDbCommand cmd = new OleDbCommand("DELETE FROM ProductsInfo WHERE (ID= " + Convert.ToInt32(lblproductIdDelete.Text.Trim()) + ")", connectionXD);
                cmd.ExecuteNonQuery();
                connectionXD.Close();

                productsDATAGRIDVIEW.DataSource = null;
                ProductsShow();
            }
            catch
            {

            }
            /**
            HelloSayoXD.Open();
            OleDbCommand asd = new OleDbCommand("DELETE from ProductInventory WHERE (Product_Name= '" + tanggal + "')", HelloSayoXD);


            asd.ExecuteNonQuery();
            HelloSayoXD.Close();

            heyHello.Clear();


            hahahaNuisanceXD();
            IkotModeXB();**/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bili2xNakayo poopskie = new Bili2xNakayo();
            poopskie.Show();
            this.Hide();
        }
    }
}





