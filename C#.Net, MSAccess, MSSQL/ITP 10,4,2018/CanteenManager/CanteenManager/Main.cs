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

namespace CanteenManager
{
    public partial class Main : Form
    {
        public string name, pass;
        public string Firstname;
        public string Lastname;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addnewprod a = new Addnewprod();
            a.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestockUp a = new RestockUp();
            a.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drinks a = new Drinks();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderView a = new OrderView();
            a.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SalesReport a = new SalesReport();
            a.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();

                System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();


                timer1.Interval = 5000;//5 seconds
                timer1.Tick += new System.EventHandler(timer1_Tick);
                timer1.Start();
                Compare();               

            }

            catch
            {
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            LoadData();

        }

        private void LoadData()
        {
            fullname.Text = Form1.Fname + Form1.Lname;
            string MyConnectionString = "Server=localhost;Port=3306;database=canteen_db;Uid=root;Pwd=''";


            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from food_tbl;", connection);
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

            DataGridViewCellStyle style = new DataGridViewCellStyle { BackColor = Color.Red, ForeColor = Color.White };
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if ((int)dataGridView1.Rows[i].Cells[4].Value <= (int)dataGridView1.Rows[i].Cells[5].Value)
                {
                    dataGridView1.Rows[i].Cells[0].Style = style;
                    dataGridView1.Rows[i].Cells[1].Style = style;
                    dataGridView1.Rows[i].Cells[2].Style = style;
                    dataGridView1.Rows[i].Cells[3].Style = style;
                    dataGridView1.Rows[i].Cells[4].Style = style;
                    dataGridView1.Rows[i].Cells[5].Style = style;
                    dataGridView1.Rows[i].Cells[6].Style = style;
                    dataGridView1.Rows[i].Cells[7].Style = style;
                }
        }

        static int wew = 1;

        private void Compare()
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle { BackColor = Color.Red, ForeColor = Color.White};
            string item ="";
           

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if ((int)dataGridView1.Rows[i].Cells[4].Value <= (int)dataGridView1.Rows[i].Cells[5].Value) 
                {
                    item = item + dataGridView1.Rows[i].Cells[1].Value.ToString() + "\n";
                    dataGridView1.Rows[i].Cells[0].Style = style;
                    dataGridView1.Rows[i].Cells[1].Style = style;
                    dataGridView1.Rows[i].Cells[2].Style = style;
                    dataGridView1.Rows[i].Cells[3].Style = style;
                    dataGridView1.Rows[i].Cells[4].Style = style;
                    dataGridView1.Rows[i].Cells[5].Style = style;
                    dataGridView1.Rows[i].Cells[6].Style = style;
                    dataGridView1.Rows[i].Cells[7].Style = style;
                }
            if (wew == 1)
            {
                CriticalLevel add = new CriticalLevel(item);
                add.ShowDialog();
                wew = 0;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            wew = 1;
            Compare();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MonitorQueuing a = new MonitorQueuing();
            a.Show();
        }


    }
}
