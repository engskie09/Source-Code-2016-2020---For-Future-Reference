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

namespace CanteenManager
{
    public partial class Addnewprod : Form
    {
        MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);
        MySqlCommand command;

        public Addnewprod()
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

        private void Addnewprod_Load(object sender, EventArgs e)
        {


           
                string MyConnectionString = "Server=localhost;Port=3306;database=canteen_db;Uid=root;Pwd=''";


                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select Image,Name from food_tbl;", connection);
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
    

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();

                String insertQuery = "INSERT INTO food_tbl(Name,Type,Image,Quantity,Price,CriticalValue,Description,day) VALUES(@name, @type, @img, @quan,@price,@crit,@Desc,@day)";

                connection.Open();

                command = new MySqlCommand(insertQuery, connection);


                command.Parameters.Add("@name", MySqlDbType.VarChar, 30);
                command.Parameters.Add("@type", MySqlDbType.Text);
                command.Parameters.Add("@img", MySqlDbType.LongBlob);
                command.Parameters.Add("@quan", MySqlDbType.Text);
                command.Parameters.Add("@crit", MySqlDbType.Text);
                command.Parameters.Add("@price", MySqlDbType.Double);
                command.Parameters.Add("@Desc", MySqlDbType.Text);
                command.Parameters.Add("@day", MySqlDbType.Text);

                
                command.Parameters["@name"].Value = textBox4.Text;
                command.Parameters["@type"].Value = comboBox1.Text;
                command.Parameters["@img"].Value = img;
                command.Parameters["@quan"].Value = textBox2.Text;
                command.Parameters["@crit"].Value = textBox3.Text;
                command.Parameters["@price"].Value = Convert.ToDouble(textBox1.Text);
                command.Parameters["@Desc"].Value = textBox5.Text;
                command.Parameters["@day"].Value = comboBox2.Text;




                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");

                    {

                        textBox2.Text = String.Empty;
                        textBox4.Text = String.Empty;
                        comboBox1.Text = String.Empty;
                        textBox1.Text = String.Empty;
                        textBox3.Text = String.Empty;
                        textBox5.Text = String.Empty;
                        pictureBox1.Image = null;


                    }
                


                    connection.Close();
                }
                Main xD = new Main();
                xD.Show();
                this.Close();
            }
            catch
            {

                MessageBox.Show("Check your inserted Data!");
            }
           
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

        private void button4_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            a.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Sinigang")
            {
                textBox4.Text = ""; 

                textBox4.ForeColor = Color.Black;
           
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Sinigang";

                textBox4.ForeColor = Color.Silver;

            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Meal")
            {
                comboBox1.Text = "";

                comboBox1.ForeColor = Color.Black;

            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Meal";

                comboBox1.ForeColor = Color.Silver;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "15")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "15";

                textBox2.ForeColor = Color.Silver;

            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "5")
            {
                textBox3.Text = "";

                textBox3.ForeColor = Color.Black;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "5";

                textBox3.ForeColor = Color.Silver ;

            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Monday")
            {
                comboBox2.Text = "";

                comboBox2.ForeColor = Color.Black;

            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "Monday";

                comboBox2.ForeColor = Color.Silver;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "50")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "50";

                textBox1.ForeColor = Color.Silver;

            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
             if (textBox5.Text == "Sinigang is traditionally tamarind-based. Variations of the dish derive their sourness from ingredients such as guava, calamansi, kamias, santol or unripe mango. Seasoning powder or bouillon cubes with a tamarind base are commercial alternatives to using natural fruits. Meat in sinigang (e.g., fish, pork, beef, shrimp, or chicken) is often stewed with tamarinds, tomatoes, garlic, and onions.")
            {
                textBox5.Text = "";

                textBox5.ForeColor = Color.Silver;

            }
              }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Sinigang is traditionally tamarind-based. Variations of the dish derive their sourness from ingredients such as guava, calamansi, kamias, santol or unripe mango. Seasoning powder or bouillon cubes with a tamarind base are commercial alternatives to using natural fruits. Meat in sinigang (e.g., fish, pork, beef, shrimp, or chicken) is often stewed with tamarinds, tomatoes, garlic, and onions.";

                textBox5.ForeColor = Color.Silver;

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
