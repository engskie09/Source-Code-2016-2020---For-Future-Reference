using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace theFACTisYOU
{
    public partial class AdminStaffSession_Order_ : Form
    {
        public AdminStaffSession_Order_()
        {
            InitializeComponent();
        }

        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        OleDbConnection HelloSayoXD = new OleDbConnection(LoginSession.x);
        DataTable heyHello = new DataTable();


       

        public void IkotModeXB()
        {


            try
            {
                huhu.Columns.Remove(imgCol);

            }
            catch { }

            pakGanern();


            imgCol.HeaderText = "Product Picture";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            huhu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            huhu.Columns.Add(imgCol);
            Image img;
            Object row = new Object();
            string XB = "";


            for (int lels = 0; lels <= huhu.Rows.Count - 1; lels++)
            {

                XB = puyatersXD[lels];



                img = Image.FromFile(XB);
                row = img;




                huhu.Rows[lels].Cells[6].Value = row;
                huhu.Rows[lels].Height = 50;
                row = null;

            }


        }

        List<int> haynako = new List<int>();

        public void taena()
        {

            haynako.Clear();
            foreach (DataGridViewRow item in huhu.Rows)
            {
                haynako.Add(Convert.ToInt32(item.Cells[0].Value));

            }


        }

        List<string> puyatersXD = new List<string>();
        public void pakGanern()
        {

            taena();

            puyatersXD.Clear();

            HelloSayoXD.Open();


            OleDbCommand wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha.CommandType = CommandType.Text;
            DataTable xdt = new DataTable();

            foreach (int value in haynako)
            {


                wahahahaha.CommandText = "SELECT * from ProductInventory WHERE ID= " + value;
                wahahahaha.ExecuteNonQuery();
                OleDbDataAdapter xda = new OleDbDataAdapter(wahahahaha);
                xda.Fill(xdt);

                foreach (DataRow xdr in xdt.Rows)
                {



                    puyatersXD.Add(xdr["Product_Picture"].ToString());

                }
                xdt.Clear();

            }


            HelloSayoXD.Close();
        }


        public void hahahaNuisanceXD()
        {



            HelloSayoXD.Open();

            OleDbCommand sorryForBeingAnnoying = HelloSayoXD.CreateCommand();
            OleDbDataAdapter ByeexD = new OleDbDataAdapter(sorryForBeingAnnoying);
            sorryForBeingAnnoying.CommandType = CommandType.Text;
            sorryForBeingAnnoying.CommandText = "select * from ProductInventory";
            sorryForBeingAnnoying.ExecuteNonQuery();

            ByeexD.Fill(heyHello);

            huhu.AutoGenerateColumns = false;


            huhu.Columns[0].DataPropertyName = "ID";
            huhu.Columns[1].DataPropertyName = "Product_Name";
            huhu.Columns[2].DataPropertyName = "Product_Category";
            huhu.Columns[3].DataPropertyName = "Product_Description";
            huhu.Columns[4].DataPropertyName = "Product_Cost";
            huhu.Columns[5].DataPropertyName = "Quantity_On_Hand";


            huhu.DataSource = heyHello;



            HelloSayoXD.Close();

        }

        private void AdminStaffSession_Order__Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(120, 0, 60, 104);
            hahahaNuisanceXD();
            IkotModeXB();

            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;
            timexD.Start();
        }

        public void iCHECKxD()
        {

              for (int x = 0; x <= cart.Rows.Count - 1; x++)
            {

                DataGridViewRow checkxD = cart.Rows[x];

                string berto = checkxD.Cells[0].Value.ToString();

                if (berto.ToUpper() == selectedNAME.ToUpper())
                {

                    diritsu = false;
                    break;

                }
                else
                {
                    diritsu = true;

                }

            }

        }

        bool diritsu = true;

        int silict = 0;


      
        string selectedNAME = "";
        string selectedPrice = "";
        string selectedQuantityOnHand = "";
        string pradakID = "";


        private void addtoCart_Click(object sender, EventArgs e)
        {
           

            if (nameLBL.Text != "----------" && priceLBL.Text != "----------" && lblQUANTITY.Text != "----" && quantity_input.Text != "" && lblTOTAL.Text != "----------")
            {

                iCHECKxD();

                if (diritsu)
                {
                    cart.Rows.Add(selectedNAME, selectedPrice, quantity_input.Text, lblTOTAL.Text, lblQUANTITY.Text, pradakID);
                }

                else
                {

                    MessageBox.Show("Product Name Already Exist!!");

                }
            }

            else
            {

                MessageBox.Show("Invalid!!!");

            }

            int zxcvb = 0;
            try
            {
                for (int x = 0; x <= cart.Rows.Count -1 ; x++)
                {
                DataGridViewRow qwerty = cart.Rows[x];

                int asdfgh = Convert.ToInt32(qwerty.Cells[3].Value.ToString());

                zxcvb = zxcvb + asdfgh;
                
                }
                lblTOTAL3.Text = zxcvb.ToString();
            }
            catch
            {

            }



               
          

           


        }

        private void HuehueXD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                silict = e.RowIndex;

                DataGridViewRow XB = huhu.Rows[silict];
                pradakID = XB.Cells[0].Value.ToString();
                selectedNAME = XB.Cells[1].Value.ToString();
                selectedPrice = XB.Cells[4].Value.ToString();
                selectedQuantityOnHand = XB.Cells[5].Value.ToString();

                nameLBL.Text = selectedNAME;
                priceLBL.Text = selectedPrice;
                lblQUANTITY.Text = selectedQuantityOnHand;
                quantity_input.Text = "";
                lblTOTAL.Text = "----------";
            }
            catch
            {
            }
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            AdminSession xD = new AdminSession();
            xD.Show();
            this.Close();
        }

        private void nameLBL_TextChanged(object sender, EventArgs e)
        {
            if (nameLBL.Text != "----------")
            {
                quantity_input.Visible = true;
            }
            else
            {
                quantity_input.Visible = false;

            }
        }

        private void undo_Click(object sender, EventArgs e)
        {
            nameLBL.Text = "----------";
            priceLBL.Text = "----------";
            lblQUANTITY.Text = "----------";
            quantity_input.Visible = false;
            quantity_input.Text = "";
            lblTOTAL.Text = "----------";
              
        }

        private void quantity_input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantity_input.Text == "0")
                {
                    quantity_input.Text = "";
                    return;
                }
                int a = Convert.ToInt32(lblQUANTITY.Text.ToString());
                int b = Convert.ToInt32(quantity_input.Text.Trim());
                
              if (a < b)
                {

                    MessageBox.Show("Invalid: Quantity to buy must be lower than Remain Quantity");
                    quantity_input.Clear();
                    lblTOTAL.Text = "----------";

                }


            

               

                else
                {
                    
                    double q = Convert.ToDouble(quantity_input.Text.Trim());
                    double w = Convert.ToDouble(priceLBL.Text.Trim());
                    double d = q * w;
                    lblTOTAL.Text = d.ToString();

                }
            }
            catch
            {



            }
        }

      

      

        private void quantity_input_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.Back)

	            {

                    if (quantity_input.Text.Length == 1)
                    {
                        lblTOTAL.Text = "----------";


                    }

	            }

             e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


        }

        private void timexD_Tick(object sender, EventArgs e)
        {
            string taym = DateTime.Now.ToLongTimeString();
            string deyt = DateTime.Now.ToShortDateString(   );
            string deytaym = taym + "  " + deyt;
            orasanXD.Text = deytaym;
        }

        List<string> cartlist = new List<string>();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int updelSelecta = 0;

        int invisibleCheck = 0;

        private void cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                try
            {
                updelSelecta = e.RowIndex;

                DataGridViewRow upDel = cart.Rows[updelSelecta];

                UpDelProduct.Text = upDel.Cells[0].Value.ToString();

                invisibleCheck = Convert.ToInt32(upDel.Cells[4].Value.ToString());
                //label6.Text = upDel.Cells[4].Value.ToString();
            }
            catch
            {
            }

        }


        private void UpDelProduct_TextChanged(object sender, EventArgs e)
        {
            UpDelQuantity.Visible = true;


            if (UpDelProduct.Text == "----------")
            {

                UpDelQuantity.Visible = false;

            }
            
        }

        private void UpDelQuantity_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (UpDelQuantity.Text == "0")
                {
                    UpDelQuantity.Clear();
                    return;
                }
                
                int a = Convert.ToInt32(invisibleCheck);
                int b = Convert.ToInt32(UpDelQuantity.Text.Trim()   );

                if (a < b)
                {

                    MessageBox.Show("Invalid: Quantity to buy must be lower than Remaining Quantity");
                    UpDelQuantity.Clear();
                    lblTOTAL2.Text = "----------";  

                }






                else
                {

                    double q = Convert.ToDouble(UpDelQuantity.Text.Trim());
                    double w = Convert.ToDouble(priceLBL.Text.Trim());
                    double d = q * w;
                    lblTOTAL2.Text = d.ToString();

                }
            }
            catch
            {



            }
        }

        private void updateOrderList_Click(object sender, EventArgs e)
        {
            try
            {

                if (UpDelProduct.Text != "----------")
                {
                    DataGridViewRow update = cart.Rows[updelSelecta];
                    update.Cells[2].Value = Convert.ToInt32(UpDelQuantity.Text.Trim());
                    update.Cells[3].Value = Convert.ToInt32(lblTOTAL2.Text.Trim());
                    UpDelProduct.Text = "----------";
                    lblTOTAL2.Text = "----------";
                }
                else
                {
                    MessageBox.Show("Nothing to Update, please select.");
                    return;
                }
            }
            catch
            {
            }

            int zxcvb = 0;
            try
            {
                for (int x = 0; x <= cart.Rows.Count - 1; x++)
                {
                    DataGridViewRow qwerty = cart.Rows[x];

                    int asdfgh = Convert.ToInt32(qwerty.Cells[3].Value.ToString());

                    zxcvb = zxcvb + asdfgh;

                }
                lblTOTAL3.Text = zxcvb.ToString();
            }
            catch
            {

            }


        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {

            if (UpDelProduct.Text != "----------")
            {
                DataGridViewRow removecartskie = cart.Rows[updelSelecta];
                cart.Rows.Remove(removecartskie); 
                UpDelProduct.Text = "----------";
            }
            else
            {
                MessageBox.Show("Nothing to Delete, please select.");
                return;
            }

            int zxcvb = 0;
            try
            {
                for (int x = 0; x <= cart.Rows.Count - 1; x++)
                {
                    DataGridViewRow qwerty = cart.Rows[x];

                    int asdfgh = Convert.ToInt32(qwerty.Cells[3].Value.ToString());

                    zxcvb = zxcvb + asdfgh;

                }
                lblTOTAL3.Text = zxcvb.ToString();
            }
            catch
            {

            }
          
        }

        private void UpDelQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Back)
            {

                if (UpDelQuantity.Text.Length == 1)
                {
                    lblTOTAL2.Text = "----------";


                }

            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        int x = 0;
        public void final()
        {
            x = cart.Rows.Count - 1;
            

            if (x == -1)
            {
                
                return;
            }
               
            else
            {

                for (int y = 0; y <= x; y++)
                {

                    DataGridViewRow XB = cart.Rows[y];
                    uniqeProductName.Add(XB.Cells[0].Value.ToString().Trim());
                    uniqeQuantity.Add(XB.Cells[2].Value.ToString().Trim());
                    uniqeTotalPrice.Add(XB.Cells[3].Value.ToString().Trim());
                    OriginalQuantity.Add(XB.Cells[4].Value.ToString().Trim());
                    

                    //-otherform
                  //  uniqeProductName.Add(XB.Cells[0].Value.ToString().Trim());
                    //uniqeQuantity.Add(XB.Cells[2].Value.ToString().Trim());
                  //  uniqeTotalPrice.Add(XB.Cells[3].Value.ToString().Trim());
                    /*   public static List<string> finalnamelist = new List<string>();
                         public static List<string> finalpricelist = new List<string>();
                         public static List<string> finalquantitylist = new List<string>();
                         public static List<string> finalpricelist = new List<string>();
                     * */
                    AdminStaffSession_Receipt_.finalnamelist.Add(XB.Cells[0].Value.ToString().Trim());
                    AdminStaffSession_Receipt_.finalpricelist.Add(XB.Cells[1].Value.ToString().Trim());
                    AdminStaffSession_Receipt_.finalquantitylist.Add(XB.Cells[2].Value.ToString().Trim());
                    AdminStaffSession_Receipt_.finaltotalpricelist.Add(XB.Cells[3].Value.ToString().Trim());
                    AdminStaffSession_Receipt_.finalidlist.Add(XB.Cells[5].Value.ToString().Trim());
                    
                }
                AdminStaffSession_Receipt_.ikot = x;
            }
           
        }

        public void computeQuantityxD()
        {
            for (int y = 0; y <= cart.Rows.Count -1; y++)
            {
                int a = Convert.ToInt32(OriginalQuantity[y]);
                int b = Convert.ToInt32(uniqeQuantity[y]);
                int c = a - b;

                ComputedQuantity.Add(c.ToString());

            }
        }

        public void updateQuantity()
        {

            computeQuantityxD();
            HelloSayoXD.Close();
            HelloSayoXD.Open();
    
            for (int y = 0; y <= cart.Rows.Count - 1; y++)
            {

                OleDbCommand twoweekstogo = HelloSayoXD.CreateCommand();
                twoweekstogo.CommandType = CommandType.Text;
                twoweekstogo.CommandText = "update ProductInventory set Quantity_On_Hand =@x1 where Product_Name =@x2 ";
                twoweekstogo.Parameters.AddWithValue("@x1", ComputedQuantity[y].ToString());
                twoweekstogo.Parameters.AddWithValue("@x2", uniqeProductName[y].ToString());
                twoweekstogo.ExecuteNonQuery();
             //   MessageBox.Show(uniqeProductName[y].ToString() +" " +ComputedQuantity[y].ToString());


            }

            HelloSayoXD.Close();
                


        }

        List<string> uniqeProductName = new List<string>();
        List<string> uniqeQuantity = new List<string>();
        List<string> uniqeTotalPrice = new List<string>();

        List<string> OriginalQuantity = new List<string>();
        List<string> ComputedQuantity = new List<string>();

        private void Bayad_Click(object sender, EventArgs e)
        {
            //woahhpataposnaXB();
           // MessageBox.Show(orderIDFinal);
            
        
               

                int x = cart.Rows.Count - 1;

                if (x == -1)
                {
                    MessageBox.Show("No order");
                    return;
                }
                final();

                updateQuantity();
                woahhpataposnaXB();
                salesreportsxD();
                insertPrint();
                AdminStaffSession_Receipt_.finalprice = lblTOTAL3.Text.Trim();
                AdminStaffSession_Receipt_.finalcash = cash.Text.Trim();
                AdminStaffSession_Receipt_.finalchange = change.Text.Trim();
                AdminStaffSession_Receipt_ XD = new AdminStaffSession_Receipt_();
                XD.Show();
                this.Close();
           
          //  this.Close();
        }

        private void cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {

                if (cash.Text.Length == 1)
                {
                    change.Text = "----------";


                }

            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cash_TextChanged(object sender, EventArgs e)
        {
                 
            
            try
            {

                    double q = Convert.ToDouble(lblTOTAL3.Text.Trim());
                    double w = Convert.ToDouble(cash.Text.Trim());
                    double d = w - q;
                    change.Text = d.ToString();

                
            }
            catch
            {
                    


            }
        }

        private void lblTOTAL3_TextChanged(object sender, EventArgs e)
        {
            
            if (lblTOTAL3.Text == "----------")
            {
                cash.Visible = false;
            }
            else
            {
                cash.Visible = true;
            }

            try
            {

                double q = Convert.ToDouble(lblTOTAL3.Text.Trim());
                double w = Convert.ToDouble(cash.Text.Trim());
                double d = w - q;
                change.Text = d.ToString();


            }
            catch
            {



            }
        }

        public void salesreportsxD()
        {
            pagsamasamahin();
            HelloSayoXD.Close();
            HelloSayoXD.Open();

          
                OleDbCommand hixD = HelloSayoXD.CreateCommand();
                hixD.CommandType = CommandType.Text;
                hixD.CommandText = "INSERT INTO PointOfSales (OrderID,Product_ID,Products_Sold,Products_Quantity,Products_Price,Products_Total_Quantity,Products_Total_Price,cash,Date_Order) VALUES (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9)";


                hixD.Parameters.AddWithValue("@a1", orderIDFinal);
                hixD.Parameters.AddWithValue("@a2", POSproductsID);
                hixD.Parameters.AddWithValue("@a3", POSproductssold);
                hixD.Parameters.AddWithValue("@a4", POSproductsquantity);
                hixD.Parameters.AddWithValue("@a5", POSproductsprice);
                hixD.Parameters.AddWithValue("@a6", POStotalQuantity);
                hixD.Parameters.AddWithValue("@a7", POStotalprice);
                hixD.Parameters.AddWithValue("@a8", cash.Text);
                hixD.Parameters.AddWithValue("@a9", POSdateorder);
                
               
                //   MessageBox.Show(finalidlist[wahaha] + "," + finalnamelist[wahaha] + "," + finalpricelist[wahaha] + "," + finalquantitylist[wahaha] + "," + finaltotalpricelist[wahaha]);
                hixD.ExecuteNonQuery();
            
            HelloSayoXD.Close();

        }
        /**
         * 
         *          AdminStaffSession_Receipt_.finalnamelist.Add(XB.Cells[0].Value.ToString().Trim());
                    AdminStaffSession_Receipt_.finalquantitylist.Add(XB.Cells[2].Value.ToString().Trim());
         *          AdminStaffSession_Receipt_.finalpricelist.Add(XB.Cells[1].Value.ToString().Trim());
                    AdminStaffSession_Receipt_.finaltotalpricelist.Add(XB.Cells[3].Value.ToString().Trim());
                    AdminStaffSession_Receipt_.finalidlist.Add(XB.Cells[5].Value.ToString().Trim());
        **/
        //------------------------------------------------------------------------------------------------------------------------------

        string POSproductsID, POSproductssold, POSproductsquantity, POSproductsprice, POStotalQuantity, POStotalprice, POSdateorder;
        public void pagsamasamahin()
        {

            List<int> TotalQuantity = AdminStaffSession_Receipt_.finalquantitylist.Select(int.Parse).ToList();
            List<int> TotalPrice = AdminStaffSession_Receipt_.finalpricelist.Select(int.Parse).ToList();

            POSproductsID = string.Join(",", AdminStaffSession_Receipt_.finalidlist.ToArray());
            POSproductssold = string.Join(",",AdminStaffSession_Receipt_.finalnamelist.ToArray());
            POSproductsquantity = string.Join(",", AdminStaffSession_Receipt_.finalquantitylist.ToArray());
            POSproductsprice = string.Join(",", AdminStaffSession_Receipt_.finalpricelist.ToArray());

            POStotalQuantity = TotalQuantity.Sum().ToString();
            POStotalprice = TotalPrice.Sum().ToString();
            POSdateorder = DateTime.Now.ToShortDateString();

          /**  MessageBox.Show(POSproductsID);
            MessageBox.Show(POSproductssold);
            MessageBox.Show(POSproductsquantity);
            MessageBox.Show(POSproductsprice);
            MessageBox.Show(POStotalQuantity);
            MessageBox.Show(POStotalprice);
            MessageBox.Show(POSdateorder);**/


        }

        public static string orderIDFinal = "";

        public void woahhpataposnaXB()
        {

            check();
            bool bool2x = true;
            //  checkOrderID.Add("2018-99999"); //get value from databeys
            Random random = new Random();

            int number = random.Next(10000, 99999);
            string order = DateTime.Today.ToLongDateString();
            string[] ordeer = order.Split(',');
            int year;
            int.TryParse(ordeer[2], out year);
            orderIDFinal = year.ToString() + "--" + number.ToString();
            //  MessageBox.Show("potek:"+ orderIDFinal);

            do
            {
                int x = 0;
                try
                {
                    if (orderIDFinal == checkOrderID[x])
                    {
                        //  MessageBox.Show("same" + orderIDFinal);
                        orderIDFinal = "";
                        woahhpataposnaXB();

                    }
                    if (orderIDFinal != checkOrderID[x])
                    {
                        //MessageBox.Show("no same" + orderIDFinal);
                        break;

                    }
                  
                }
                catch
                {
                    orderIDFinal = year.ToString() + "--" + number.ToString();
                    break;
                }
                x++;
            } while (bool2x);

        }
        List<String> checkOrderID = new List<string>();
        public void check()
        {
            HelloSayoXD.Close();
            HelloSayoXD.Open();

            OleDbCommand kurikongxD = HelloSayoXD.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select OrderID from PointOfSales";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();
                checkOrderID.Add(x);
                
            }

            HelloSayoXD.Close();
        }
       
        //----------------------------------------------------------------------------------------------------------------------------------------------------------


        public void insertPrint()
        {
            resetxD();
            HelloSayoXD.Close();
            HelloSayoXD.Open();

            for (int wahaha = 0; wahaha <= x; wahaha++)
            {
                OleDbCommand hixD = HelloSayoXD.CreateCommand();
                hixD.CommandType = CommandType.Text;
                hixD.CommandText = "INSERT INTO Print (Product_ID,Product_Name,Product_Price,Product_Quantity,Product_Total_Price) VALUES (@a2,@a3,@a4,@a5,@a6)";


                hixD.Parameters.AddWithValue("@a2", AdminStaffSession_Receipt_.finalidlist[wahaha]);
                hixD.Parameters.AddWithValue("@a3", AdminStaffSession_Receipt_.finalnamelist[wahaha]);
                hixD.Parameters.AddWithValue("@a4", AdminStaffSession_Receipt_.finalpricelist[wahaha]);
                hixD.Parameters.AddWithValue("@a5", AdminStaffSession_Receipt_.finalquantitylist[wahaha]);
                hixD.Parameters.AddWithValue("@a6", AdminStaffSession_Receipt_.finaltotalpricelist[wahaha]);
                //   MessageBox.Show(finalidlist[wahaha] + "," + finalnamelist[wahaha] + "," + finalpricelist[wahaha] + "," + finalquantitylist[wahaha] + "," + finaltotalpricelist[wahaha]);
                hixD.ExecuteNonQuery();
            }
            HelloSayoXD.Close();

        }

        public void resetxD()
        {

            HelloSayoXD.Close();
            HelloSayoXD.Open();


            OleDbCommand hixD = HelloSayoXD.CreateCommand();
            hixD.CommandType = CommandType.Text;
            hixD.CommandText = "Delete from print";

            hixD.ExecuteNonQuery();

            HelloSayoXD.Close();

        }

      

   

     
    }
}
