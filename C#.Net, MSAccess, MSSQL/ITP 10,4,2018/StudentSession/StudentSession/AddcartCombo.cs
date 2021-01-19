using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace CanteenKiosk
{
    public partial class AddcartCombo : Form
    {
        public AddcartCombo()
        {
            InitializeComponent();

            getDrinkValue();
            setValuetoControl();
        }

        public static string getOrderName = "";
        public static string getOrderPrice = "";
        public static MemoryStream getOrderPicture;

        string MyConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=canteen_db;";

        private void AddcartCombo_Load(object sender, EventArgs e)
        {




            OrderName.Text = getOrderName;
            OrderPrice.Text = getOrderPrice;
            getImage();
            Quantity();

        }

        private void OrderName_Click()
        {

        }

        private void PlusQuantity_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(QuantityToBuy.Text.ToString());

            if (a >= 1)
            {
                a++;
                QuantityToBuy.Text = a.ToString();
            }
        }

        private void MinusQuantity_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(QuantityToBuy.Text.ToString());

            if (a > 1)
            {
                a--;
                QuantityToBuy.Text = a.ToString();
            }
        }


        public void Quantity()
        {
            MySqlConnection cnn;

            cnn = new MySqlConnection(stringpotek.koneksyon);
            // try
            //  {
            cnn.Open();



            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where name ='" + getOrderName + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                
                Availability.Text = dr["Quantity"].ToString();
            }

            cnn.Close();
        }


        public void getImage()
        {

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Close();
            connection.Open();


            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from food_tbl where name ='" + getOrderName + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {



                // MealNameList.Add(dr["image"].ToString());
                Byte[] img = (Byte[])dr["image"];
                MemoryStream ms = new MemoryStream(img);

                OrderPicture.BackgroundImage = Image.FromStream(ms);
                OrderPicture.BackgroundImageLayout = ImageLayout.Stretch;

            }



            connection.Close();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddtoCrazyKart_Click_1(object sender, EventArgs e)
        {
            try
            {
                Double a = Convert.ToDouble(QuantityToBuy.Text);
                Double b = Convert.ToDouble(OrderPrice.Text);
                Double Total = a * b;
                Ordering.OrderTable.Rows.Add(OrderName.Text, QuantityToBuy.Text, OrderPrice.Text, Total.ToString());

                DialogSuccessAddedtoCart add = new DialogSuccessAddedtoCart();
                add.ShowDialog();
                //MessageBox.Show("Successfully added to cart beach");
               
            }
            catch (Exception)
            {

                MessageBox.Show("The Value is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btbBottleSize250_Click(object sender, EventArgs e)
        {
            OrderPrice.Text = getOrderPrice;
            Double XD = Convert.ToDouble(OrderPrice.Text);
            if (lblsetDrinks.Text != "-----")
            {
                lblsetDrinkSize.Text = "250ML";
                lblsetPrice.Text = "P10"+".00";
                XD += 10;
                OrderPrice.Text = XD.ToString() + ".00";    

            }                                                                           

            else
            {
                MessageBox.Show("Please Select Drinks");
            }
        }

        private void btbBottleSize300_Click(object sender, EventArgs e)
        {
            OrderPrice.Text = getOrderPrice;
            Double XD = Convert.ToDouble(OrderPrice.Text);
            if (lblsetDrinks.Text != "-----")
            {
                lblsetDrinkSize.Text = "300ML";
                lblsetPrice.Text = "P13" +".00";
                XD += 13;
                OrderPrice.Text = XD.ToString() + ".00";

            }

            else
            {
                MessageBox.Show("Please Select Drinks");
            }
        }

        private void btbBottleSize500_Click(object sender, EventArgs e)
        {
            OrderPrice.Text = getOrderPrice;
            Double XD = Convert.ToDouble(OrderPrice.Text);
            if (lblsetDrinks.Text != "-----")
            {
                lblsetDrinkSize.Text = "500ML";
                lblsetPrice.Text = "P15" + ".00";
                XD += 15;
                OrderPrice.Text = XD.ToString() +".00";
            }

            else
            {
                MessageBox.Show("Please Select Drinks");
            }
        }

        private void pictureBoxDrinks1_Click(object sender, EventArgs e)
        {
            lblsetDrinks.Text = lblDrink1.Text;
        }

        private void pictureBoxDrinks2_Click(object sender, EventArgs e)
        {
            lblsetDrinks.Text = lblDrink2.Text;
        }

        private void pictureBoxDrinks3_Click(object sender, EventArgs e)
        {
            lblsetDrinks.Text = lblDrink3.Text;
        }

        private void pictureBoxDrinks4_Click(object sender, EventArgs e)
        {
            lblsetDrinks.Text = lblDrink4.Text;
        }

        private void lunchorderpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 170, 200);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ordering a = new Ordering();
            a.Show();
            this.Hide();
        }

        List<String> Drinks = new List<String>();
        List<MemoryStream> DrinksPhoto = new List<MemoryStream>();

        private void getDrinkValue()
        {
            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);
            MySqlCommand cmd = new MySqlCommand();

            connection.Close();
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from drink_tbl";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

       
            foreach (DataRow dr in dt.Rows)
            {
                Drinks.Add(dr["DrinkName"].ToString());


                if (DBNull.Value != (dr["DrinkImage"]))
                {

                    Byte[] xD = (Byte[])dr["DrinkImage"];

                    MemoryStream ms = new MemoryStream(xD);
                    DrinksPhoto.Add(ms);
                }

              
            }

            connection.Close();
        }

        private void setValuetoControl()
        {
            int z = 1;
          
           
            for (int x = 0; x <= 3; x++)
            {

            Control[] ShowDrinkName = this.Controls.Find("lblDrink" + z, true);
                ShowDrinkName[0].Text = Drinks[x].ToString();
            
            z++;

            }

            pictureBoxDrinks1.Image = Image.FromStream(DrinksPhoto[0]);
            pictureBoxDrinks2.Image = Image.FromStream(DrinksPhoto[1]);
            pictureBoxDrinks3.Image = Image.FromStream(DrinksPhoto[2]);
            pictureBoxDrinks4.Image = Image.FromStream(DrinksPhoto[3]);
    
        }
    }
}

