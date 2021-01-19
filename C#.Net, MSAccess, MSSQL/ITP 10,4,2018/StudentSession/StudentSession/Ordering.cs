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
using System.IO;


namespace CanteenKiosk
{

    public partial class Ordering : Form
    {

        int second = 0;

        string MyConnectionString = stringpotek.koneksyon;

        MySqlConnection connection = new MySqlConnection();

        public static DataTable OrderTable = new DataTable();

        public static string day = "";

        public Ordering()
        {
            InitializeComponent();


            ShowBreakfast();
            ShowLunch();
            ShowCombo();
            ShowBestSellers();
            setPanelsLocation();
            ShowDessert();
            ShowOthers();

            OrderTable.RowChanged += table_RowChanged;
            OrderTable.RowDeleted += table_RowChanged;
            lblgetTotalorder.Text = "0";
            day = DateTime.Today.DayOfWeek.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

       

        public void setOrderTable()
        {
            OrderTable.Columns.Add("Name", typeof(String));
            OrderTable.Columns.Add("Quantity", typeof(String));
            OrderTable.Columns.Add("Price", typeof(String));
            OrderTable.Columns.Add("Total", typeof(String));
            //OrderTable.Columns.Add("Description", typeof(String));

        }
        public void setPanelsLocation()
        {
            //7, 160

            Breakfastpanel.Location = new Point(7, 160);
            lunchpanel.Location = new Point(7, 160);
            Combopanel.Location = new Point(7, 160);
        }
        private void Ordering_Load(object sender, EventArgs e)
        {
            timer1.Start();
            setOrderTable();
            

            /*
            generateProducts();


            dataGridView1.RowTemplate.Height = 100;
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 60;
            dataGridView1.AllowUserToAddRows = false;

          



            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[3];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            */
        }

        
        /*
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



        }
        */
        private void Meal_Click(object sender, EventArgs e)
        {
            /* slidepanel.Left = Meal.Left;
             slidepanel.Width = Meal.Width;

             MySqlConnection connection = new MySqlConnection(MyConnectionString);
             connection.Close();
             connection.Open();


             MySqlCommand cmd = new MySqlCommand("select * from food_tbl WHERE Type = 'Meal';", connection);
             MySqlDataAdapter da = new MySqlDataAdapter(cmd);
             da.SelectCommand = cmd;
             DataTable dt = new DataTable();
             da.Fill(dt);


             for (int x = 1; x <= dt.Rows.Count + 1; x++)
             {
                 string btnName = "btbFood" + x.ToString();
                 string lblName = "lblFood" + x.ToString();

                 string lblNewName = "";


                 foreach (DataRow dr in dt.Rows)
                 {
                     lblNewName = dr["name"].ToString();



                     // Control ctn = this.Controls["lblFood1"];
                     Control[] ctrls1 = this.Controls.Find(lblName, true);


                     ctrls1[0].Text = lblNewName;





                 }


             }


             //MessageBox.Show(dt.Rows.Count.ToString());



             connection.Close();


             /*
             MySqlConnection connection = new MySqlConnection(MyConnectionString);
             connection.Close();
             connection.Open();

             MySqlCommand cmd = new MySqlCommand("select Name,Price,Image from food_tbl WHERE Type = 'Meal';", connection);
             MySqlDataAdapter da = new MySqlDataAdapter(cmd);
             da.SelectCommand = cmd;
             DataTable dt = new DataTable();


             da.Fill(dt);
             BindingSource b = new BindingSource();

             b.DataSource = dt;
             // dataGridView1.ColumnCount = 4;
             // dataGridView1.Columns[0].Name = "Name";
             //dataGridView1.Columns[1].Name = "Price";
             // dataGridView1.Columns[3].Name = "Image";

             dataGridView1.DataSource = b;

             da.Update(dt);
             numericUpDown1.Text = "1";
             panel1.Visible = true;
             connection.Close();

             if (dataGridView1.Columns[2] is DataGridViewImageColumn)
             {

                 ((DataGridViewImageColumn)dataGridView1.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
             }*/
        }



        private void button4_Click(object sender, EventArgs e)
        {
            /*MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select Name,Price,Image from food_tbl WHERE Type = 'Drinks';", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();

            b.DataSource = dt;

            dataGridView1.DataSource = b;

            da.Update(dt);

            numericUpDown1.Text = "1";
            panel1.Visible = true;

            if (dataGridView1.Columns[2] is DataGridViewImageColumn)
            {

                ((DataGridViewImageColumn)dataGridView1.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }*/
        }




        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Sweets_Click(object sender, EventArgs e)
        {
            /*  MySqlConnection connection = new MySqlConnection(MyConnectionString);
              connection.Open();
              MySqlCommand cmd = new MySqlCommand("select  Name,Price,Image from food_tbl WHERE Type = 'Sweets';", connection);
              MySqlDataAdapter da = new MySqlDataAdapter(cmd);
              da.SelectCommand = cmd;
              DataTable dt = new DataTable();
              da.Fill(dt);
              BindingSource b = new BindingSource();

              b.DataSource = dt;

              dataGridView1.DataSource = b;

              da.Update(dt);
              numericUpDown1.Text = "1";
              panel1.Visible = true;

              if (dataGridView1.Columns[2] is DataGridViewImageColumn)
              {

                  ((DataGridViewImageColumn)dataGridView1.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
              }*/
        }

        private void Food_Click(object sender, EventArgs e)
        {
            /*  MySqlConnection connection = new MySqlConnection(MyConnectionString);
              connection.Open();
              MySqlCommand cmd = new MySqlCommand("select Name,Price,Image from food_tbl WHERE Type = 'Junkfood';", connection);
              MySqlDataAdapter da = new MySqlDataAdapter(cmd);
              da.SelectCommand = cmd;
              DataTable dt = new DataTable();
              da.Fill(dt);
              BindingSource b = new BindingSource();

              b.DataSource = dt;

              dataGridView1.DataSource = b;

              da.Update(dt);
              numericUpDown1.Text = "1";
              panel1.Visible = true;

              if (dataGridView1.Columns[2] is DataGridViewImageColumn)
              {

                  ((DataGridViewImageColumn)dataGridView1.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
              }*/
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            /*

                        try
                        {


                                label1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                                label3.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

                                panel2.Visible = true;
                                panel1.Visible = false;


                        }
                        catch (Exception)
                        {



                            MessageBox.Show("Please select an item.");
                        }
                        */

            /*
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        //---------------------------------------


        List<string> productToBuy = new List<string>();
        List<int> quantityToReduce = new List<int>();
        List<int> productQuantity = new List<int>();
        List<int> totalQuantity = new List<int>();

        //---------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {



            productToBuy.Add(label1.Text);
            quantityToReduce.Add((Convert.ToInt32(numericUpDown1.Value)));

            addtoCARTxD();
        }

        public void addtoCARTxD()
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where name ='" + label1.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            string addCartProduct = label1.Text;
            int addCartQuantity = Convert.ToInt32(numericUpDown1.Value);
            int addCartPrice = 0;
            int addCartTotal = 0;
            int CartTotal = 0;
            string addCartType = "";


            foreach (DataRow dr in dt.Rows)
            {


                //   productQuantity.Add(Convert.ToInt32(dr["quantity"].ToString()));
                addCartType = dr["Type"].ToString();
                addCartPrice = (int)dr["Price"];



            }

            connection.Close();

            addCartTotal = addCartPrice * addCartQuantity;

            CrazyKart.Rows.Add(addCartProduct, addCartQuantity.ToString(), addCartPrice.ToString(), addCartTotal.ToString(), addCartType);


            for (int x = 0; x <= CrazyKart.Rows.Count - 1; x++)
            {

                DataGridViewRow XD = CrazyKart.Rows[x];

                int XB = Convert.ToInt32(XD.Cells[3].Value.ToString());

                CartTotal += XB;

            }

            label6.Text = "Total: " + CartTotal.ToString();
            for (int x = 0; x <= CrazyKart.Rows.Count - 1; x++)
            {

                DataGridViewRow XD = CrazyKart.Rows[x];

                int XB = Convert.ToInt32(XD.Cells[3].Value.ToString());

                CartTotal += XB;

            }

            label6.Text = "Total: " + CartTotal.ToString();

        }


        int delOrderRow = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow delroww = CrazyKart.Rows[delOrderRow];
                int CartTotal = 0;
                CrazyKart.Rows.Remove(delroww);
                for (int x = 0; x <= CrazyKart.Rows.Count - 1; x++)
                {

                    DataGridViewRow XD = CrazyKart.Rows[x];

                    int XB = Convert.ToInt32(XD.Cells[3].Value.ToString());

                    CartTotal += XB;

                }

                label6.Text = "Total: " + CartTotal.ToString();

            }
            catch
            {



            }

            /*
            try
            {

                int index = papel.SelectedIndex;

                papel.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);

                int i = 0;
                int sum = 0;

                for (i = 0; i < listBox2.Items.Count; i++)
                {
                    sum = sum + Convert.ToInt32(listBox2.Items[i]);
                }

                label5.Text = sum.ToString();

            }
            catch (Exception)
            {



                MessageBox.Show("Please select an item.");
            }*/

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Meal_Click_1(object sender, EventArgs e)
        {
           
            Breakfastpanel.Visible = true;
            lunchpanel.Visible = false;
            Combopanel.Visible = false;
            Bestpanel.Visible = false;
            DessertPanel.Visible = false;
            OthersPanel.Visible = false;
            slidepanel.Left = Meal.Left;
            slidepanel.Width = Meal.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lunchpanel.Visible = true;
            Breakfastpanel.Visible = false;
            Combopanel.Visible = false;
            Bestpanel.Visible = false;
            DessertPanel.Visible = false;
            OthersPanel.Visible = false;
           
            slidepanel.Left = Lunch.Left;
            slidepanel.Width = Lunch.Width;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
          
        }
        /*
private void button5_Click_1(object sender, EventArgs e)
{


try
{
if (CrazyKart.Rows.Count < 1)
{
MessageBox.Show("Mag order ka muna");
}

}
catch (Exception)
{

Finalize a = new Finalize();
a.Show();
this.Hide();


}

//getProductQuantityXD();
//buyfinalXD();

/*   for (int x = 0; x <= productToBuy.Count - 1 ; x++)
{
MessageBox.Show(productToBuy[x].ToString() + "/n" + quantityToReduce[x].ToString());

}*/

        /*bilhin a = new bilhin();
        a.Show();
        this.Hide();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }


    public void getProductQuantityXD()
    {
        MySqlConnection connection = new MySqlConnection(MyConnectionString);
        connection.Close();


        connection.Open();


        for (int x = 0; x <= productToBuy.Count - 1; x++)
        {

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select quantity from food_tbl where name ='" + productToBuy[x] + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                productQuantity.Add(Convert.ToInt32(dr["quantity"].ToString()));

                //    MessageBox.Show(productToBuy[x] + " " + productQuantity[x].ToString());


            }


        }


        /* view
        List<string> productToBuy = new List<string>();
        List<int> quantityToReduce = new List<int>();
        List<int> productQuantity = new List<int>();
        List<int> totalQuantity = new List<int>();

        //computer Total quantity
        for (int x = 0; x <= productToBuy.Count - 1; x++)
        {

            int computeTotalQuantity = productQuantity[x] - quantityToReduce[x];
            totalQuantity.Add(computeTotalQuantity);

            // MessageBox.Show(totalQuantity[x].ToString());
        }


        connection.Close();
        connection.Open();
    }


    public void buyfinalXD()
    {


        MySqlConnection connection = new MySqlConnection(MyConnectionString);

        connection.Close();
        connection.Open();

        for (int x = 0; x <= productToBuy.Count - 1; x++)
        {

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update product set quantity = '" + totalQuantity[x] + "' where Name ='" + productToBuy[x] + "'";

            cmd.ExecuteNonQuery();
        }


        connection.Close();



        /*  MessageBox.Show(updateQuantity.ToString() + " " + selectedquantity.ToString() + " " + quantitytoReduce.ToString());

                       cmdx = cnn.CreateCommand();
                       cmdx.CommandType = CommandType.Text;
                       cmdx.CommandText = "update product set quantity ='" + updateQuantity + "' where name='" + productname + "' ";
                       cmdx.ExecuteNonQuery();*/
        //






        /*
                int quantity = (int)numericUpDown1.Value;

                papel.Items.Add(label1.Text + " " + label4.Text + " " + numericUpDown1.Text);

                listBox2.Items.Add((Convert.ToInt32(label3.Text) * (Convert.ToInt32(quantity)))).ToString();

                int i = 0;
                int sum = 0;
                for (i = 0; i < listBox2.Items.Count; i++)
                {
                    sum = sum + Convert.ToInt32(listBox2.Items[i]);
                }
                label5.Text = sum.ToString();

                //---------------------------------------
               /** productname = label1.Text;
                quantitytoReduce = (int)numericUpDown1.Value;

                MySqlConnection cnn = new MySqlConnection(MyConnectionString);

                cnn.Close();
                cnn.Open();                                                                 
                MySqlCommand cmdx = cnn.CreateCommand();
                cmdx.CommandType = CommandType.Text;
                cmdx.CommandText = "Select quantity from product where name='" + productname + "' ";
                cmdx.ExecuteNonQuery();
                DataTable dts = new DataTable();
                MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);
                xda.Fill(dts);

                int selectedquantity = 0;
                foreach (DataRow xdr in dts.Rows)
                {
                    selectedquantity = Convert.ToInt32(xdr["quantity"].ToString());


                }

                int updateQuantity = selectedquantity - quantitytoReduce;

                MessageBox.Show(updateQuantity.ToString() + " " + selectedquantity.ToString() + " " + quantitytoReduce.ToString());

                cmdx = cnn.CreateCommand();
                cmdx.CommandType = CommandType.Text;
                cmdx.CommandText = "update product set quantity ='" + updateQuantity + "' where name='" + productname + "' ";
                cmdx.ExecuteNonQuery();
        //---------------------------------------
        numericUpDown1.Text = "1";

    }

    private void CrazyKart_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        try
        {

            delOrderRow = e.RowIndex;

        }

        catch
        {



        }
    }

    private void vScrollBar1_ValueChanged(object sender, EventArgs e)
    {

    }

    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {

    }

    public void generateProducts()
    {




    }

    public void getProductName()
    {



    }

    private void button6_Click(object sender, EventArgs e)
    {
        Account a = new Account();
        a.Show();
        this.Hide();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        DynamicButtonPotek();



            // b.Click += new EventHandler(this.button_click);

        // Control ctn = this.Controls["lblFood1"];


        /* for (int i = 0; i <= 9; i++)
         {
             Button b = addbutton(i);
             flowLayoutPanel1.Controls.Add(b);
             //endposition += 100;
             b.Click += new System.EventHandler(this.ButtonClick);
         }

     }
     void ButtonClick(object sender, EventArgs e)
     {
         Button currentbutton = (Button)sender;
         MessageBox.Show(currentbutton.Text);
     }

     Button addbutton(int i)
     {
         Button b = new Button();
         b.Name = "Button" + i.ToString();
         b.Text = "Button" + i.ToString();
         b.ForeColor = Color.White;
         b.BackColor = Color.Gray;
         b.Font = new Font("Serif", 24, FontStyle.Bold);
         b.Width = 170;
         b.Height = 80;
         //b.Location = new Point(start, end);
         b.TextAlign = ContentAlignment.MiddleCenter;
         b.Margin = new Padding(5);

         return b;





     */



        /*Button addbutton(int i)
        {
            Button b = new Button();
            b.Name = "Button" + i.ToString();
            b.Text = "" + i.ToString();
            b.ForeColor = Color.White;
            b.BackColor = Color.Gray;
            b.Font = new Font("Serif", 24, FontStyle.Bold);
            b.Width = 170;
            b.Height = 80;
            //b.Location = new Point(start, end);
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Margin = new Padding(5);

            return b;

            //MessageBox.Show(dt.Rows.Count.ToString());


        }
        Label addlabel(int i)
        {
            Label l = new Label();
            l.Name = "Label" + i.ToString();
            l.Text = "" + i.ToString();
            l.ForeColor = Color.White;
            l.BackColor = Color.Gray;
            l.Font = new Font("Serif", 24, FontStyle.Bold);
            l.Width = 170;
            l.Height = 80;
            //b.Location = new Point(start, end);
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Margin = new Padding(5);

            return l;

            //MessageBox.Show(dt.Rows.Count.ToString());
            */
        public void ShowLunch()
        {
            List<String> LunchNameList = new List<String>();
            List<String> LunchPriceList = new List<String>();
            List<String> LunchDesc = new List<String>();
         
            
            List<MemoryStream> LunchPictureList = new List<MemoryStream>();

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where type ='" + "Lunch" + "' and day = '" + day + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {


                //   productQuantity.Add(Convert.ToInt32(dr["quantity"].ToString()));


                LunchNameList.Add(dr["name"].ToString());
                LunchPriceList.Add(dr["Price"].ToString());
                LunchDesc.Add(dr["Description"].ToString());
              

                Byte[] img = (Byte[])dr["image"];
                MemoryStream ms = new MemoryStream(img);
                LunchPictureList.Add(ms);
            }

            connection.Close();
            // MessageBox.Show(MealNameList[0].ToString());
            //  MessageBox.Show(MealNameList[1].ToString());

            int z = 1;

            //    MessageBox.Show(MealNameList.Count.ToString());

            for (int x = 0; x < LunchNameList.Count; x++)
            {


                Control[] ShowLunchName = this.Controls.Find("LunchName" + z, true);
                ShowLunchName[0].Text = LunchNameList[x].ToString();

                Control[] ShowLunchPrice = this.Controls.Find("LunchPrice" + z, true);
                ShowLunchPrice[0].Text = LunchPriceList[x].ToString()+".00";

                Control[] ShowLunchDesc = this.Controls.Find("LunchDesc" + z, true);
                ShowLunchDesc[0].Text = LunchDesc[x].ToString();
             

                Control[] ShowMealPicture = this.Controls.Find("lunchPicture" + z, true);
                ShowMealPicture[0].BackgroundImage = Image.FromStream(LunchPictureList[x]);
                ShowMealPicture[0].BackgroundImageLayout = ImageLayout.Stretch;

                Control[] ShowPanelXD = this.Controls.Find("lunchfastPanel" + z, true);
                ShowPanelXD[0].Visible = true;


                z++;

            }





        }

        public void ShowBreakfast()
        {
            List<String> MealNameList = new List<String>();
            List<String> mealPriceList = new List<String>();
            List<String> MealDesc = new List<String>();
            List<MemoryStream> mealPictureList = new List<MemoryStream>();

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where type ='" + "meal" + "' and day = '" + day + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {


                //   productQuantity.Add(Convert.ToInt32(dr["quantity"].ToString()));


                MealNameList.Add(dr["name"].ToString());
                mealPriceList.Add(dr["Price"].ToString());
                MealDesc.Add(dr["Description"].ToString());


                Byte[] img = (Byte[])dr["image"];
                MemoryStream ms = new MemoryStream(img);
                mealPictureList.Add(ms);
            }

            connection.Close();
            // MessageBox.Show(MealNameList[0].ToString());
            //  MessageBox.Show(MealNameList[1].ToString());

            int z = 1;

            //    MessageBox.Show(MealNameList.Count.ToString());

            for (int x = 0; x < MealNameList.Count; x++)
            {


                Control[] ShowMealName = this.Controls.Find("mealName" + z, true);
                ShowMealName[0].Text = MealNameList[x].ToString();

                Control[] ShowMealPrice = this.Controls.Find("mealPrice" + z, true);
                ShowMealPrice[0].Text = mealPriceList[x].ToString()+".00"; 

                Control[] ShowMealDesc = this.Controls.Find("MealDesc" + z, true);
                ShowMealDesc[0].Text = MealDesc[x].ToString();

                Control[] ShowMealPicture = this.Controls.Find("mealPicture" + z, true);
                ShowMealPicture[0].BackgroundImage = Image.FromStream(mealPictureList[x]);
                ShowMealPicture[0].BackgroundImageLayout = ImageLayout.Stretch;

                Control[] ShowPanelXD = this.Controls.Find("breakfastPanel" + z, true);
                ShowPanelXD[0].Visible = true;
                z++;

            }
        }

        public void ShowCombo()
        {
            List<String> ComboNameList = new List<String>();
            List<String> ComboPriceList = new List<String>();
            List<String> ComboDesc = new List<String>();
            List<MemoryStream> ComboPictureList = new List<MemoryStream>();

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where type ='" + "Combo" + "' and day = '" + day + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {


                //   productQuantity.Add(Convert.ToInt32(dr["quantity"].ToString()));


                ComboNameList.Add(dr["name"].ToString());
                ComboPriceList.Add(dr["Price"].ToString());
                ComboDesc.Add(dr["Description"].ToString());


                Byte[] img = (Byte[])dr["image"];
                MemoryStream ms = new MemoryStream(img);
                ComboPictureList.Add(ms);
            }

            connection.Close();
            // MessageBox.Show(MealNameList[0].ToString());
            //  MessageBox.Show(MealNameList[1].ToString());

            int z = 1;

            //    MessageBox.Show(MealNameList.Count.ToString());

            for (int x = 0; x < ComboNameList.Count; x++)
            {


                Control[] ShowComboName = this.Controls.Find("ComboName" + z, true);
                ShowComboName[0].Text = ComboNameList[x].ToString();

                Control[] ShowComboPrice = this.Controls.Find("ComboPrice" + z, true);
                ShowComboPrice[0].Text = ComboPriceList[x].ToString() + ".00";

                Control[] ShowComboDesc = this.Controls.Find("ComboDesc" + z, true);
                ShowComboDesc[0].Text = ComboDesc[x].ToString();

                Control[] ShowComboPicture = this.Controls.Find("ComboPicture" + z, true);
                ShowComboPicture[0].BackgroundImage = Image.FromStream(ComboPictureList[x]);
                ShowComboPicture[0].BackgroundImageLayout = ImageLayout.Stretch;

                Control[] ShowPanelXD = this.Controls.Find("combofastPanel" + z, true);
                ShowPanelXD[0].Visible = true;
                
                z++;

            }
        }
        public void ShowBestSellers()
        {
            List<String> BestSellerNameList = new List<String>();
            List<String> BestSellerPriceList = new List<String>();
            List<String> BestSellerDesc = new List<String>();
            List<MemoryStream> BestSellerPictureList = new List<MemoryStream>();

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where type ='" + "BestSeller" + "' and day = '" + day + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {


                //   productQuantity.Add(Convert.ToInt32(dr["quantity"].ToString()));


                BestSellerNameList.Add(dr["name"].ToString());
                BestSellerPriceList.Add(dr["Price"].ToString());
                BestSellerDesc.Add(dr["Description"].ToString());


                Byte[] img = (Byte[])dr["image"];
                MemoryStream ms = new MemoryStream(img);
                BestSellerPictureList.Add(ms);
            }

            connection.Close();
            // MessageBox.Show(MealNameList[0].ToString());
            //  MessageBox.Show(MealNameList[1].ToString());

            int z = 1;

            //    MessageBox.Show(MealNameList.Count.ToString());

            for (int x = 0; x < BestSellerNameList.Count; x++)
            {


                Control[] ShowBestSellerName = this.Controls.Find("BestSellerName" + z, true);
                ShowBestSellerName[0].Text = BestSellerNameList[x].ToString();

                Control[] ShowBestSellerPrice = this.Controls.Find("BestSellerPrice" + z, true);
                ShowBestSellerPrice[0].Text = BestSellerPriceList[x].ToString() + ".00";

                Control[] ShowBestSellerDesc = this.Controls.Find("BestSellerDesc" + z, true);
                ShowBestSellerDesc[0].Text = BestSellerDesc[x].ToString();

                Control[] ShowBestSellerPicture = this.Controls.Find("BestSellerPicture" + z, true);
                ShowBestSellerPicture[0].BackgroundImage = Image.FromStream(BestSellerPictureList[x]);
                ShowBestSellerPicture[0].BackgroundImageLayout = ImageLayout.Stretch;

                Control[] ShowBestSellerPanel = this.Controls.Find("BestSellerPanel" + z, true);
                ShowBestSellerPanel[0].Visible = true;
                z++;

            }
        }
        public void ShowDessert()
        {
            List<String> DessertNameList = new List<String>();
            List<String> DessertPriceList = new List<String>();
            List<String> DessertDesc = new List<String>();
            List<MemoryStream> DessertPictureList = new List<MemoryStream>();

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where type ='" + "Dessert" + "' and day = '" + day + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {


                //   productQuantity.Add(Convert.ToInt32(dr["quantity"].ToString()));


                DessertNameList.Add(dr["name"].ToString());
                DessertPriceList.Add(dr["Price"].ToString());
                DessertDesc.Add(dr["Description"].ToString());


                Byte[] img = (Byte[])dr["image"];
                MemoryStream ms = new MemoryStream(img);
                DessertPictureList.Add(ms);
            }

            connection.Close();
            // MessageBox.Show(MealNameList[0].ToString());
            //  MessageBox.Show(MealNameList[1].ToString());

            int z = 1;

            //    MessageBox.Show(MealNameList.Count.ToString());

            for (int x = 0; x < DessertNameList.Count; x++)
            {


                Control[] ShowDessertName = this.Controls.Find("DessertName" + z, true);
                ShowDessertName[0].Text = DessertNameList[x].ToString();

                Control[] ShowDessertPrice = this.Controls.Find("DessertPrice" + z, true);
                ShowDessertPrice[0].Text = DessertPriceList[x].ToString() + ".00";

                Control[] ShowDessertDesc = this.Controls.Find("DessertDesc" + z, true);
                ShowDessertDesc[0].Text = DessertDesc[x].ToString();

                Control[] ShowDessertPicture = this.Controls.Find("DessertPicture" + z, true);
                ShowDessertPicture[0].BackgroundImage = Image.FromStream(DessertPictureList[x]);
                ShowDessertPicture[0].BackgroundImageLayout = ImageLayout.Stretch;

                Control[] ShowPanelXD = this.Controls.Find("DessertfastPanel" + z, true);
                ShowPanelXD[0].Visible = true;
                z++;

            }
        }



        private void Cart_Click(object sender, EventArgs e)
        {
            OrderingCart xD = new OrderingCart();
            xD.ShowDialog();
            this.Refresh();
        }

        private void Breakfastpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void mealOrder1_Click(object sender, EventArgs e)
        {

            //AddcartBF.getOrderPicture 
            //mealPicture1.BackgroundImage.Save(AddcartBF.getOrderPicture, System.Drawing.Imaging.ImageFormat.Png);

            
        }

        private void mealOrder2_Click(object sender, EventArgs e)
        {

            //AddcartBF.getOrderPicture 
            //mealPicture1.BackgroundImage.Save(AddcartBF.getOrderPicture, System.Drawing.Imaging.ImageFormat.Png);

            
        }

        private void mealOrder3_Click(object sender, EventArgs e)
        {

            //AddcartBF.getOrderPicture 
            //mealPicture1.BackgroundImage.Save(AddcartBF.getOrderPicture, System.Drawing.Imaging.ImageFormat.Png);

            
        }

        private void FinishNa_Click(object sender, EventArgs e)
        {
            bilhin xD = new bilhin();
            xD.ShowDialog();
        /*  Finalizee xD = new Finalizee();
            xD.ShowDialog();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderTable.Clear();
          
            Account a = new Account();
          
            a.Show();
            this.Close();
          
        }

        private void mealOrder4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CheckBalance1 a = new CheckBalance1();
            a.ShowDialog();
            
        }

        private void mealOrder5_Click(object sender, EventArgs e)
        {
           
        }

        private void mealOrder6_Click(object sender, EventArgs e)
        {
            
        }

        private void mealOrder7_Click(object sender, EventArgs e)
        {
            
        }

        private void mealOrder8_Click(object sender, EventArgs e)
        {
           
        }

        private void mealOrder9_Click(object sender, EventArgs e)
        {
           
        }

        private void bforderpanel_Paint(object sender, PaintEventArgs e)
        {
            breakfastPanel1.BackColor = Color.FromArgb(80, 200, 0, 0);


            Rectangle r = new Rectangle(0, 0, breakfastPanel1.Width, breakfastPanel1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 10;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            breakfastPanel1.Region = new Region(gp);

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            breakfastPanel2.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // panel3.BackColor = Color.FromArgb(100, 200, 0, 0);
            breakfastPanel3.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {
            breakfastPanel4.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {
            breakfastPanel5.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {
            breakfastPanel6.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {
            breakfastPanel7.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            breakfastPanel8.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void panel7_Paint_1(object sender, PaintEventArgs e)
        {
            breakfastPanel9.BackColor = Color.FromArgb(80, 200, 0, 0);
        }

        private void lunchpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Breakfastpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void mealOrder1_Click_1(object sender, EventArgs e)
        {
            
            AddcartBF.getOrderName = mealName1.Text;
            AddcartBF.getOrderPrice = mealPrice1.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder2_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName2.Text;
            AddcartBF.getOrderPrice = mealPrice2.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder3_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName3.Text;
            AddcartBF.getOrderPrice = mealPrice3.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder4_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName4.Text;
            AddcartBF.getOrderPrice = mealPrice4.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder5_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName5.Text;
            AddcartBF.getOrderPrice = mealPrice5.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder6_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName6.Text;
            AddcartBF.getOrderPrice = mealPrice6.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder7_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName7.Text;
            AddcartBF.getOrderPrice = mealPrice7.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder8_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName8.Text;
            AddcartBF.getOrderPrice = mealPrice8.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void mealOrder9_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = mealName9.Text;
            AddcartBF.getOrderPrice = mealPrice9.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName1.Text;
            AddcartBF.getOrderPrice = LunchPrice1.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void lunchorderpanel_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel1.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel2_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel2.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel3_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel3.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel4_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel4.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel5_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel5.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel6_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel6.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel7_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel7.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel8_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel8.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void lunchorderpanel9_Paint(object sender, PaintEventArgs e)
        {
            lunchfastPanel9.BackColor = Color.FromArgb(150, 0, 150, 230);
        }

        private void Combopanel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Combo_Click(object sender, EventArgs e)
        {
            Combopanel.Visible = true;
            lunchpanel.Visible = false;
            Breakfastpanel.Visible = false;
            Bestpanel.Visible = false;
            DessertPanel.Visible = false;
            OthersPanel.Visible = false;
            slidepanel.Left = Combo.Left;
            slidepanel.Width = Combo.Width;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName1.Text;
            AddcartCombo.getOrderPrice = ComboPrice1.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName2.Text;
            AddcartCombo.getOrderPrice = ComboPrice2.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        

        private void Combopanel_Paint_2(object sender, PaintEventArgs e)
        {
            combofastPanel1.BackColor = Color.FromArgb(100, 100,0 , 230);
        }

        private void ComboDesc1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            CheckBalance1 a = new CheckBalance1();
            a.ShowDialog();
        }
        

       public void table_RowChanged(object sender, DataRowChangeEventArgs e)
        {
           
                lblgetTotalorder.Text = OrderTable.Rows.Count.ToString();
           


        }

        private void Others_Click(object sender, EventArgs e)
        {
            OthersPanel.Visible = true;
            DessertPanel.Visible = false;
            Bestpanel.Visible = false;
            Breakfastpanel.Visible = false;
            lunchpanel.Visible = false;
            Combopanel.Visible = false;
            

            slidepanel.Left = Others.Left;
            slidepanel.Width = Others.Width;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName2.Text;
            AddcartBF.getOrderPrice = LunchPrice2.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName3.Text;
            AddcartBF.getOrderPrice = LunchPrice3.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName4.Text;
            AddcartBF.getOrderPrice = LunchPrice4.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName5.Text;
            AddcartBF.getOrderPrice = LunchPrice5.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName6.Text;
            AddcartBF.getOrderPrice = LunchPrice6.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName7.Text;
            AddcartBF.getOrderPrice = LunchPrice7.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName8.Text;
            AddcartBF.getOrderPrice = LunchPrice8.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = LunchName9.Text;
            AddcartBF.getOrderPrice = LunchPrice9.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName3.Text;
            AddcartCombo.getOrderPrice = ComboPrice3.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName4.Text;
            AddcartCombo.getOrderPrice = ComboPrice4.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName5.Text;
            AddcartCombo.getOrderPrice = ComboPrice5.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName6.Text;
            AddcartCombo.getOrderPrice = ComboPrice6.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName7.Text;
            AddcartCombo.getOrderPrice = ComboPrice7.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName8.Text;
            AddcartCombo.getOrderPrice = ComboPrice8.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AddcartCombo.getOrderName = ComboName9.Text;
            AddcartCombo.getOrderPrice = ComboPrice9.Text;
            AddcartCombo a = new AddcartCombo();
            //a.Show();
            a.ShowDialog();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            oras.Text = DateTime.Now.ToString();
            second = second + 1;
        }

        private void combofastPanel2_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel2.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void combofastPanel3_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel1.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void combofastPanel4_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel4.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void combofastPanel5_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel4.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void combofastPanel6_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel6.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void combofastPanel7_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel7.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void combofastPanel8_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel8.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void combofastPanel9_Paint(object sender, PaintEventArgs e)
        {
            combofastPanel9.BackColor = Color.FromArgb(100, 100, 0, 230);
        }

        private void Best_Click(object sender, EventArgs e)
        {
            Bestpanel.Visible = true;
            Breakfastpanel.Visible = false;
            lunchpanel.Visible = false;
            Combopanel.Visible = false;
            DessertPanel.Visible = false;
            OthersPanel.Visible = false;
            slidepanel.Left = Best.Left;
            slidepanel.Width = Best.Width;
        }

        private void Dessert_Click(object sender, EventArgs e)
        {
            DessertPanel.Visible = true;
            Bestpanel.Visible = false;
            Breakfastpanel.Visible = false;
            lunchpanel.Visible = false;
            Combopanel.Visible = false;
            OthersPanel.Visible = false;

            slidepanel.Left = Dessert.Left;
            slidepanel.Width = Dessert.Width;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BestSellerOrder1_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName1.Text;
            AddcartBF.getOrderPrice = BestSellerPrice1.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder2_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName2.Text;
            AddcartBF.getOrderPrice = BestSellerPrice2.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder3_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName3.Text;
            AddcartBF.getOrderPrice = BestSellerPrice3.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder4_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName4.Text;
            AddcartBF.getOrderPrice = BestSellerPrice4.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder5_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName5.Text;
            AddcartBF.getOrderPrice = BestSellerPrice5.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder6_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName6.Text;
            AddcartBF.getOrderPrice = BestSellerPrice6.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder7_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName7.Text;
            AddcartBF.getOrderPrice = BestSellerPrice7.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder8_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName8.Text;
            AddcartBF.getOrderPrice = BestSellerPrice8.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void BestSellerOrder9_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = BestSellerName9.Text;
            AddcartBF.getOrderPrice = BestSellerPrice9.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DessertOrder1_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName1.Text;
            AddcartBF.getOrderPrice = DessertPrice1.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder2_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName2.Text;
            AddcartBF.getOrderPrice = DessertPrice2.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder3_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName3.Text;
            AddcartBF.getOrderPrice = DessertPrice3.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder4_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName4.Text;
            AddcartBF.getOrderPrice = DessertPrice4.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder5_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName5.Text;
            AddcartBF.getOrderPrice = DessertPrice5.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder6_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName6.Text;
            AddcartBF.getOrderPrice = DessertPrice6.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder7_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName7.Text;
            AddcartBF.getOrderPrice = DessertPrice7.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder8_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName8.Text;
            AddcartBF.getOrderPrice = DessertPrice8.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }

        private void DessertOrder9_Click(object sender, EventArgs e)
        {
            AddcartBF.getOrderName = DessertName9.Text;
            AddcartBF.getOrderPrice = DessertPrice9.Text;
            AddcartBF a = new AddcartBF();
            //a.Show();
            a.ShowDialog();
        }
        public void ShowOthers()
        {
            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select Image,Name,Price,Quantity from food_tbl where Type ='Others';", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;

            dataGridView1.RowTemplate.Height = 100;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = b;



            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[0];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        int selectedRow = 0;
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                if (dataGridView1.CurrentRow.Index - 1 >= 0)
                {


                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0];
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;

                    selectedRow = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow SelectFromKart = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                    FoodName.Text = SelectFromKart.Cells[1].Value.ToString();
                    Price.Text = SelectFromKart.Cells[2].Value.ToString() + ".00" + " PHP";
                    Availability.Text = SelectFromKart.Cells[3].Value.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

            private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                if (dataGridView1.CurrentRow.Index + 1 >= 0)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;

                    selectedRow = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow SelectFromKart = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];

                    FoodName.Text = SelectFromKart.Cells[1].Value.ToString();
                    Price.Text = SelectFromKart.Cells[2].Value.ToString()+".00" + " PHP";
                    Availability.Text = SelectFromKart.Cells[3].Value.ToString();

                }
            }
            catch (Exception)
            {
            }
        }
        
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                DataGridViewRow SelectFromKart = dataGridView1.Rows[e.RowIndex];

                FoodName.Text = SelectFromKart.Cells[1].Value.ToString();
                Price.Text = SelectFromKart.Cells[2].Value.ToString() + ".00" + " PHP";
                Availability.Text = SelectFromKart.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void OthersPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}













       /* void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("Clicked");
        }
        private void Food_Click_1(object sender, EventArgs e)
        {
        
                }
        /*
        private void Combo_Click(object sender, EventArgs e)
        {
            
            //bilhin a = new bilhin();
            //a.Show();
            slidepanel.Left = Combo.Left;
            slidepanel.Width = Combo.Width;

            Combopanel.Visible = true;
            panel1.Visible = false;

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select Combo_Name,Price,Image from Combo_tbl WHERE Type = 'Combo';", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();

            b.DataSource = dt;

            dataGridView1.DataSource = b;

            da.Update(dt);

            numericUpDown1.Text = "1";
            Combopanel.Visible = true;

            if (dataGridView1.Columns[2] is DataGridViewImageColumn)
            {

                ((DataGridViewImageColumn)dataGridView1.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }


            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[2];
            img.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
        }
        /*int A = 1;
public System.Windows.Forms.Button addnewButton()
{

System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
panel1.Controls.Add(btn);
btn.Top = A * 100;
btn.Left = 100;
btn.Text = "Button" + this.A.ToString();
btn.Name = "Meal" + A;
A = A + 1;
MessageBox.Show(btn.Name);
return btn;         

}     static List<String> bitch = new List<String>();
        MySqlDataReader reader;
        public void DynamicButtonPotek()
        {
            slidepanel.Left = Meal.Left;
            slidepanel.Width = Meal.Width;
            panel1.Visible = true;



            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


           MySqlCommand cmd = new MySqlCommand("select count(*) from food_tbl WHERE Type = 'Meal';", connection);
            int totalProduct = int.Parse(cmd.ExecuteScalar().ToString());
            //MessageBox.Show(totalProduct.ToString());


            Button[] BtnProductPicture = new Button[totalProduct];
            Label[] LblProductName = new Label[totalProduct];

            cmd.CommandText = "select Name,price,image from food_tbl where type = 'Meal';";



            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

           
           reader = cmd.ExecuteReader();
            int q = 25;
            int y = 25;
          
         
                int z = 0;
                while (reader.Read()) { 
                //Create KONTROL
                BtnProductPicture[z] = new Button();
                LblProductName[z] = new Label();

                //SET NAME KONTROL
                BtnProductPicture[z].Name = "btnFood" + z.ToString();
                LblProductName[z].Name = "lblName" + z.ToString();
                    
                    bitch.Add(LblProductName[z].Name.ToString());
                    MessageBox.Show(bitch[z]);

                    
                    //set Text Bitch!

                    Byte[] img = (Byte[])reader["image"];
                    MemoryStream ms = new MemoryStream(img);
                   

                    LblProductName[z].Text = reader["Name"].ToString() + " " + reader["Price"].ToString();
                BtnProductPicture[z].Image = Image.FromStream(ms);




                    //
                    BtnProductPicture[z].Click += new System.EventHandler(this.ButtonClick);

                    
                    //Ilagay sa Fanel
                    BtnProductPicture[z].Parent = panel1;
                    LblProductName[z].Parent = panel1;



                    BtnProductPicture[z].Location = new Point(q , y);
                    LblProductName[z].Location = new Point(q, y += 110);

                    BtnProductPicture[z].Size = new Size(100, 100);
                    LblProductName[z].Size = new Size(140, 25);
                    y += 25;
                z++;

            }

                



            



                connection.Close();
            }

        private void ButtonClick(object sender, EventArgs e)
        {

           


            Button currentbutton = (Button)sender;
            
            MessageBox.Show(currentbutton.Name);

            
            string ButtonPindot = currentbutton.Name.ToString();
            char last = ButtonPindot[ButtonPindot.Length - 1];

            MessageBox.Show(last.ToString());
            int potek = Convert.ToInt32(last);

           // string getData = bitch[potek];




            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from food_tbl WHERE Type = 'Meal' and Name = '"+""+"';", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);

            string pname= "", quantity = "" , price = "", total = "", type="";

            for (int x = 1; x <= dt.Rows.Count + 1; x++)
            {



                foreach (DataRow dr in dt.Rows)
                {
                    pname = dr["name"].ToString();
                    quantity = dr["quantity"].ToString();
                    price = dr["price"].ToString();
                    total = dr["price"].ToString();
                    type = dr["name"].ToString();
                }

                
            }
       
            CrazyKart.Rows.Add("Karekare", "10", "200", "2000", "meal");
        }
        */

    
            
 
