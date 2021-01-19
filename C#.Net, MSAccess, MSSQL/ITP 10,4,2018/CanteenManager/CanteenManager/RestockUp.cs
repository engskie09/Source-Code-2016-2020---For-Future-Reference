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
    public partial class RestockUp : Form
    {
        string connetionString = null;
        string server = "localhost";
        string database = "canteen";
        int i;


        public static string name = "";
        public static string type = "";
        public static string quantity = "";
        public static string criticalvalue = "";
        public static string price = "";



        public RestockUp()
        {
            InitializeComponent();
        }

        private void RestockUp_Load(object sender, EventArgs e)
        {

            string MyConnectionString = "Server=localhost;Port=3306;database=canteen_db;Uid=root;Pwd=''";
           



            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Name,Price,Image,Type,CriticalValue,Quantity,Description,day from food_tbl;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;
            
            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = b;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[2];
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
           try {
                


                RestockProdUpdate update = new RestockProdUpdate();

                Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[2].Value;
                MemoryStream ms = new MemoryStream(img);
            update.pictureBox1.Image = Image.FromStream(ms);
            update.textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            update.textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            update.comboBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
               

            update.Show();
                this.Hide();
            }
           catch (Exception)
           {

                MessageBox.Show("The Value is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MyConnectionString = "Server=localhost;Port=3306;database=canteen_db;Uid=root;Pwd=''";
            DataGridViewImageColumn dgvimage = new DataGridViewImageColumn();
            dgvimage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Name,Price,Image,Type,CriticalValue,Quantity,Description from food_tbl;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;
            dataGridView1.DataSource = b;
        }
        public void delete()
        {
            string connectionstring = "Server=localhost;Port=3306;database=canteen_db;uid=root";
            MySqlConnection con = new MySqlConnection(connectionstring);
            MySqlCommand cmd;
            con.Open();
            try
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM food_tbl WHERE name=@name";
                cmd.Parameters.AddWithValue(@"name", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {

                    MessageBox.Show("Successfully deleted");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("Delete " + msg + "?", "Deleting Records", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        delete();
                        data();
                        break;
                    case DialogResult.No:
                        break;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("The Value is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       void data()
        {
            string MyConnectionString = "Server=localhost;Port=3306;database=canteen_db;Uid=root;Pwd=''";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select Name,Price,Image,Type,CriticalValue,Quantity,Description from food_tbl;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;

            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = b;

            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img = (DataGridViewImageColumn)dataGridView1.Columns[2];
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       private void button3_Click_1(object sender, EventArgs e)
       {
          

           try
           {



               Restock update = new Restock();

               Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[2].Value;
               MemoryStream ms = new MemoryStream(img);
               update.Picture.Image = Image.FromStream(ms);
               update.ProductName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
               update.Quantity.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
               update.CriticalLevel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               update.Price.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
               update.Types.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               update.Description.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

               update.Show();
               this.Hide();


           
           }
           catch (Exception)
           {

              MessageBox.Show("The Value is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }
       }
    }
}

