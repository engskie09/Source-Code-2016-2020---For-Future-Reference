using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManager
{
    public partial class RestockProdUpdate : Form
    {
        
        /*
        public string name;
        public string Type;
        public string CriticalValue;
        public string Quantity;
        public string Price;
        */


        public RestockProdUpdate()
        {
           
            InitializeComponent();
            FillCombo();
        }
        void FillCombo()
        {

            string Query = "Select DISTINCT Type From food_tbl;";
            MySqlConnection con = new MySqlConnection(stringpotek.koneksyon);
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string sName = myreader.GetString("Type");
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void getFoodIDvalue()
        {
            
            MySqlConnection con = new MySqlConnection(stringpotek.koneksyon);
            MySqlCommand cmd = new MySqlCommand("Select Food_ID from food_tbl where Name = '" + textBox4.Text.Trim()  + "'" ,con);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            lblgetFoodID.Text = dr["Food_ID"].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            comboBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox1.Enabled = true;
            button3.Enabled = true;
            textBox5.Enabled = true;
          
            button2.Enabled = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
            comboBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Enabled = false;
            textBox5.Enabled = false;
            button3.Enabled = false;
           
            button2.Enabled = false;

            textBox2.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox3.Text = String.Empty;
            comboBox1.Text = String.Empty;
            textBox1.Text = String.Empty;

            try
            {

                pictureBox1.Image = null;
                pictureBox1.Image.Dispose();
            }
            catch (Exception)
            {

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            RestockUp a = new RestockUp();
            a.Show();
            this.Hide();
           
        }

        private void RestockProdUpdate_Load(object sender, EventArgs e)
        {
            //fullname.Text = Form1.fnamee + Form1.Mnamee + Form1.lnamee;
            // textBox4.Text = RestockUp.name;
            // comboBox1.Text = RestockUp.type;
            // textBox2.Text = RestockUp.quantity;
            //textBox3.Text = RestockUp.criticalvalue;
            //textBox1.Text = RestockUp.price;

            getFoodIDvalue();
        }
        public void Restock()
        {
            string connectionstring = "Server=localhost;Port=3306;database=canteen_db;uid=root";

            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE food_tbl SET Quantity=@quantity where name='"+ textBox4.Text + "'";
                cmd.Parameters.AddWithValue(@"quantity", textBox2.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                    RestockUp a = new RestockUp();
                    a.Show();


                    MessageBox.Show("Item Has Successfully Restocked");
                    this.Hide();
                }

            }
        }
        public void Updateprod()
        {
            string connectionstring = "Server=localhost;Port=3306;database=canteen_db;uid=root";

            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd;

            connection.Close();
            connection.Open();
          
        
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE food_tbl SET Name=@name,Price=@price,Type=@type,CriticalValue=@criticalvalue,Description=@Desc,Quantity=@quantity, Image=@image,day=@day WHERE Food_ID='"+lblgetFoodID.Text+"'";
                
                cmd.Parameters.AddWithValue(@"name", textBox4.Text);
                cmd.Parameters.AddWithValue(@"price", textBox1.Text);
                cmd.Parameters.AddWithValue(@"type", comboBox1.Text);
                cmd.Parameters.AddWithValue(@"criticalvalue", textBox3.Text);
                cmd.Parameters.AddWithValue(@"quantity", textBox2.Text);
                cmd.Parameters.AddWithValue(@"Desc", textBox5.Text);
                cmd.Parameters.AddWithValue(@"day", comboBox2.Text);
                cmd.Parameters.AddWithValue(@"image", img);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                    RestockUp a = new RestockUp();
                    a.Show();


                    MessageBox.Show("Record successfully updated");
                    this.Hide();
                }

            }

            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Updateprod();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
  