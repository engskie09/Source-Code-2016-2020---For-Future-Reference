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
    public partial class Bili2xNakayo : Form
    {
        public Bili2xNakayo()
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
            productsDATAGRIDVIEW.ColumnCount = 3;
            
            productsDATAGRIDVIEW.Columns[0].DataPropertyName = "Product_Name";
            productsDATAGRIDVIEW.Columns[1].DataPropertyName = "Product_Cost";
            productsDATAGRIDVIEW.Columns[2].DataPropertyName = "Product_Quantity";


            productsDATAGRIDVIEW.DataSource = table;

            connectionXD.Close();


        }

        public void final()
        {

            int x = productsDATAGRIDVIEWsale.Rows.Count - 1;

            if (x == -1)
            {
                MessageBox.Show("No order");
            }

            else
            {
                
                for (int y = 0; y <= x; y++)
                {

                    DataGridViewRow XB = productsDATAGRIDVIEWsale.Rows[y];
                    EZxD.Add(XB.Cells[0].Value.ToString().Trim());
                    EZxB.Add(XB.Cells[1].Value.ToString().Trim());
                    EZxP.Add(XB.Cells[2].Value.ToString().Trim());
                    EZxX.Add(XB.Cells[3].Value.ToString().Trim());
                    
                   
                }

            }

        }

        public void computeQuantity()
        {
            
            int a = 0;
            int b = 0;
            int c = 0;
            for (int x = 0; x <= productsDATAGRIDVIEWsale.Rows.Count - 1; x++)
            {
                
                 a = Convert.ToInt32(EZxPorig[x]);
                 b = Convert.ToInt32(EZxP[x]);
                 c = a - b;
                 EZxPorigFinal.Add(c.ToString());

                
            }

        }

        public void notoOvernightxD()
        {

            int a = 0;
            int b = 0;
            connectionXD.Close();
            connectionXD.Open();
            OleDbCommand cmd = connectionXD.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ProductsInfo Where Product_Name='" + EZxD[0].ToString() + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
            
                a = Convert.ToInt32(dr["Product_Sold"].ToString().Trim());
                b = Convert.ToInt32(EZxP[0]);
                a = a + b; ;
            }

            cmd.CommandText = "UPDATE ProductsInfo Set Product_Sold= '" + a.ToString() +"' Where Product_Name= '"+EZxD[0].ToString()+"'";
            cmd.ExecuteNonQuery();
            connectionXD.Close();
        }
        /**
        public void paengtuts()
        {
            int puyatersXD = 0;

            HelloSayoXD.Close();
            HelloSayoXD.Open();
            OleDbCommand wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha.CommandType = CommandType.Text;
            wahahahaha.CommandText = "SELECT * from CountINC WHERE CountID= '1'";
            wahahahaha.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(wahahahaha);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                puyatersXD = Convert.ToInt32(xdr["ProductInventory"].ToString()) + 1;

            }

            Hellooooo = puyatersXD;

            wahahahaha.CommandText = "UPDATE CountINC SET ProductInventory= '" + puyatersXD + "' Where CountID= '1' ";

            wahahahaha.ExecuteNonQuery();

            HelloSayoXD.Close();
        }

       **/
  
        /*
       List<String> EZxD = new List<String>(); //name
       List<String> EZxB = new List<String>(); //cost
       List<String> EZxP = new List<String>(); //quantity to buy
       List<String> EZxX = new List<String>(); //total
       List<String> EZxPorig = new List<String>(); //quantityoriginal
       List<String> EZxPorigFinal = new List<String>(); //quantityFinal
       */


       
        public void updateQuantity()
        {
            computeQuantity();
            connectionXD.Close();
            connectionXD.Open();
           

            


            for (int x = 0; x <= productsDATAGRIDVIEWsale.Rows.Count - 1; x++)
            {
                OleDbCommand cmd = connectionXD.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE ProductsInfo SET Product_Quantity =@x1 WHERE Product_Name =@x2 ";
                cmd.Parameters.AddWithValue("@x1", EZxPorigFinal[x].ToString());
                cmd.Parameters.AddWithValue("@x2", EZxD[x].ToString());
               


          
                cmd.ExecuteNonQuery();

            }
            connectionXD.Close();
        }

        public void PSold()
        {



        }

        /*
        List<String> EZxD = new List<String>(); //name
        List<String> EZxB = new List<String>(); //cost
        List<String> EZxP = new List<String>(); //quantity to buy
        List<String> EZxX = new List<String>(); //total
        List<String> EZxPorig = new List<String>(); //quantityoriginal
        List<String> EZxPorigFinal = new List<String>(); //quantityFinal
        */

        

        private void Bili2xNakayo_Load(object sender, EventArgs e)
        {
            ProductsShow();

        }

        int XD = 0;

        private void productsDATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                XD = e.RowIndex;

                DataGridViewRow XB = productsDATAGRIDVIEW.Rows[XD];
                label1.Text = XB.Cells[0].Value.ToString();
                label4.Text = XB.Cells[1].Value.ToString();
                label12.Text = XB.Cells[2].Value.ToString();


            }
            catch
            {

            }
        }

        /*
       List<String> EZxD = new List<String>(); //name
       List<String> EZxB = new List<String>(); //cost
       List<String> EZxP = new List<String>(); //quantity to buy
       List<String> EZxX = new List<String>(); //total
       List<String> EZxPorig = new List<String>(); //quantityoriginal
       List<String> EZxPorigFinal = new List<String>(); //quantityFinal
       */

        private void addtoCart_Click(object sender, EventArgs e)
        {
            if (label1.Text == "-----------")
            {

                MessageBox.Show("Please Select an Item to purchase");


            }


            else
            {
                try
                {
                    DataGridViewRow XB = productsDATAGRIDVIEW.Rows[XD];

                    string name = XB.Cells[0].Value.ToString();
                    int pcost = Convert.ToInt32(XB.Cells[1].Value);
                    int pquantity = Convert.ToInt32(buyquantity.Text.Trim());
                    int total = pcost * pquantity;

                    productsDATAGRIDVIEWsale.Rows.Add(name, pcost, pquantity, total);
                    EZxPorig.Add(label12.Text.Trim());

                }
                catch
                {
                }

            }
            label1.Text = "-----------";
            label4.Text = "-----------";
            label12.Text = "---";
            buyquantity.Text = "";
                


        }


        int tanggalsaCart = 0;
        private void productsDATAGRIDVIEWsale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tanggalsaCart = e.RowIndex;
            DataGridViewRow XB = productsDATAGRIDVIEWsale.Rows[tanggalsaCart];

            label8.Text = XB.Cells[0].Value.ToString();
            label5.Text = XB.Cells[1].Value.ToString();
            label11.Text = XB.Cells[2].Value.ToString();
        }

        private void removefromCart_Click(object sender, EventArgs e)
        {
            try
            {
                productsDATAGRIDVIEWsale.Rows.RemoveAt(tanggalsaCart);
                EZxPorig.RemoveAt(tanggalsaCart);
            }
            catch
            {

            }
        }


        List<String> EZxD = new List<String>(); //name
        List<String> EZxB = new List<String>(); //cost
        List<String> EZxP = new List<String>(); //quantity to buy
        List<String> EZxX = new List<String>(); //total
        List<String> EZxPorig = new List<String>(); //quantityoriginal
        List<String> EZxPorigFinal = new List<String>(); //quantityFinal


        private void EZbayad_Click(object sender, EventArgs e)
        {
            try
            {

                final();

                for (int x = 0; x <= productsDATAGRIDVIEWsale.Rows.Count - 1; x++)
                {
                    string[] row = { EZxD[x].ToString(), EZxB[x].ToString(), EZxP[x].ToString(), EZxX[x].ToString() };
                    ListViewItem lvi = new ListViewItem(row);
                    finalcart.Items.Add(lvi);
                    updateQuantity();
                }

                label17.Text = tutal.Text;
                label19.Text = bayadxD.Text;
                label21.Text = (Convert.ToInt32(label19.Text) - Convert.ToInt32(label17.Text)).ToString();
                
                notoOvernightxD();
            }
            catch
            {

            }
         
        }

       
        private void productsDATAGRIDVIEWsale_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }
    
        private void productsDATAGRIDVIEWsale_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int totalOrder = 0;
            DataGridViewRow XD = new DataGridViewRow();

            for (int x = 0; x <= productsDATAGRIDVIEWsale.Rows.Count - 1; x++)
            {
                XD = productsDATAGRIDVIEWsale.Rows[x];


                totalOrder = totalOrder + Convert.ToInt32(XD.Cells[3].Value.ToString());

            }

         
            tutal.Text = totalOrder.ToString();
        }

        private void productsDATAGRIDVIEWsale_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                int totalOrder = 0;
                DataGridViewRow XD = new DataGridViewRow();

                for (int x = 0; x <= productsDATAGRIDVIEWsale.Rows.Count - 1; x++)
                {
                    XD = productsDATAGRIDVIEWsale.Rows[x];


                    totalOrder = totalOrder + Convert.ToInt32(XD.Cells[3].Value.ToString());

                }

           
                tutal.Text = totalOrder.ToString();
            }
            catch
            {

                label8.Text = "----------";
                label5.Text = "----------";
                label11.Text = "----------";
                tutal.Text = "----------";
            }
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            ProductsXB poopskie = new ProductsXB();
            poopskie.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bili2xNakayo xd = new Bili2xNakayo();
            xd.Show();
            this.Hide();
        }

      


    }
}
