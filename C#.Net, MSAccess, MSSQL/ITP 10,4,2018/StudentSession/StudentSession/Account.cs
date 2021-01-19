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

namespace CanteenKiosk
{
    
    public partial class Account : Form
    {
        public string name, pass;
       
        
        int second = 0;
        public Account()
        {
            InitializeComponent();
            radius();
          
        }

        void view()
        {
            string MyConnectionString = "Server=localhost;Port=3306;database=canteen_db;Uid=root;Pwd=''";
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from food_tbl;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();

            Ordering a = new Ordering();



            b.DataSource = dt;
            
            da.Update(dt);
        }

        public void radius()
        {

            Rectangle r = new Rectangle(0, 0, button1.Width, button1.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            button1.Region = new Region(gp);

            Rectangle re = new Rectangle(0, 0, button2.Width, button2.Height);
            System.Drawing.Drawing2D.GraphicsPath gpp = new System.Drawing.Drawing2D.GraphicsPath();
            int c = 50;
            gpp.AddArc(re.X, re.Y, c, c, 180, 90);
            gpp.AddArc(re.X + re.Width - c, re.Y, c, c, 270, 90);
            gpp.AddArc(re.X + re.Width - c, re.Y + re.Height - c, c, c, 0, 90);
            gpp.AddArc(re.X, re.Y + re.Height - c, c, c, 90, 90);
            button2.Region = new Region(gpp);

            Rectangle rec = new Rectangle(0, 0, button4.Width, button4.Height);
            System.Drawing.Drawing2D.GraphicsPath gpx = new System.Drawing.Drawing2D.GraphicsPath();
            int b = 50;
            gpx.AddArc(rec.X, rec.Y, b, b, 180, 90);
            gpx.AddArc(rec.X + rec.Width - b, rec.Y, b, b, 270, 90);
            gpx.AddArc(rec.X + rec.Width - b, rec.Y + rec.Height - b, b, b, 0, 90);
            gpx.AddArc(rec.X, rec.Y + rec.Height - b, b, b, 90, 90);
            button4.Region = new Region(gpx);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            view();
            Ordering a = new Ordering();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            a.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            oras.Text = DateTime.Now.ToString();
            second = second + 1;
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*
            fnamee
           lnamee
          Mnamee
            */
        private void Account_Load(object sender, EventArgs e)
             {
               
           // fullname.Text = Form1.fnamee + Form1.Mnamee + Form1.lnamee;
                 timer1.Start();
           

        }

        private void studpic_Click(object sender, EventArgs e)
        {

        }

        private void fullname_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CheckBalance a = new CheckBalance();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountShowTransactionDialog adasd = new AccountShowTransactionDialog();
            adasd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oras_Click(object sender, EventArgs e)
        {

        }

       
        }
    }
