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
   
    public partial class AddcartBF : Form
    {
        Double price;
        public AddcartBF()
        {
            InitializeComponent();
        }

        public static string getOrderName = "";
        public static string getOrderPrice = "";


        public static MemoryStream getOrderPicture ;

        string MyConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=canteen_db;";

        private void AddcartBF_Load(object sender, EventArgs e)
        {
            OrderName.Text = getOrderName;
            OrderPrice.Text = getOrderPrice;
            getImage();
            Quantity();



            price = Convert.ToDouble(OrderPrice.Text.ToString());

           
        }

        
        private void MinusQuantity_Click(object sender, EventArgs e)
        {

            
           
            Double sub = 0;
            Double a = Convert.ToDouble(QuantityToBuy.Text.ToString());
            Double availability = Convert.ToDouble(Availability.Text.ToString());

            if (a > 1)
            {
                a--;
                QuantityToBuy.Text = a.ToString();
                sub = a * price;
                OrderPrice.Text = sub.ToString() + ".00";

            }

        }

        private void PlusQuantity_Click(object sender, EventArgs e)
        {

           // MessageBox.Show(price.ToString());
            Double sub = 0;
            Double a = Convert.ToDouble(QuantityToBuy.Text.ToString());
            Double availability = Convert.ToDouble(Availability.Text.ToString());
           
            if (a > availability)
            {
                MessageBox.Show("Sobra na Tama na");
                QuantityToBuy.Text = (a - 1).ToString();
                sub = a * price;
            }
           else
            {
                a++;
                QuantityToBuy.Text = a.ToString();
                sub = a * price;
                OrderPrice.Text = sub.ToString() + ".00";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //  public static DataTable OrderTable = new DataTable();
        private void AddtoCrazyKart_Click(object sender, EventArgs e)
        {
            
            try { 
            int a = Convert.ToInt32(QuantityToBuy.Text);
                Double b = Convert.ToDouble(OrderPrice.Text);
                Double Total = Convert.ToDouble(OrderPrice.Text.ToString());
                Ordering.OrderTable.Rows.Add(OrderName.Text, QuantityToBuy.Text, OrderPrice.Text, Total.ToString());
            DialogSuccessAddedtoCart add = new DialogSuccessAddedtoCart();
            add.ShowDialog();

                this.Close();

                //MessageBox.Show("Successfully added to cart beach");
                //this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("The Value is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 0, 150, 200);
        }
    }
}
