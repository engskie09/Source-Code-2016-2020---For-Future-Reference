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
using System.IO;

namespace theFACTisYOU
{
    public partial class AdminSession : Form
    {
        public AdminSession()
        {
            InitializeComponent();
           
        }

        OleDbConnection koneksyon = new OleDbConnection(LoginSession.x);
        int bilang;

        public void engskie()
        {
            koneksyon.Close();
            koneksyon.Open();
            DataSet xD = new DataSet();
            OleDbDataAdapter qwerty = new OleDbDataAdapter("select * from AdminLogFile", koneksyon);

            qwerty.Fill(xD);

            bilang = xD.Tables[0].Rows.Count + 1;


            koneksyon.Close();
        }


        private void AdminSession_Load(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(50, 0, 0, 0);
            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi "+LoginSession.propaylNEYM;
            timexD.Start();
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            
            engskie();

            koneksyon.Open();

            string admin = label2.Text;
            string time = DateTime.Now.ToString("hh;mm;ss tt");
            string date = DateTime.Now.ToShortDateString();
            string note = "Logout";



            OleDbCommand utos = new OleDbCommand("insert into AdminLogFile values ('" + bilang + "','" + admin + "','" + time + "','" + date + "','" + note + "')", koneksyon);

            utos.ExecuteNonQuery();
            koneksyon.Close();

            LoginSession xD = new LoginSession();
            xD.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminProducts_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Products hays = new AdminSession_Manage_Products();
            hays.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminSession_ActivityLog_LoginAndOut xD = new AdminSession_ActivityLog_LoginAndOut();
            xD.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminStaffSession_Order_ xD = new AdminStaffSession_Order_();
            xD.Show();
            this.Hide();
        }

        private void timexD_Tick(object sender, EventArgs e)
        {
            string taym = DateTime.Now.ToLongTimeString();
            string deyt = DateTime.Now.ToShortDateString();
            string deytaym = taym + " " + deyt;
            orasanXD.Text = deytaym;
        }

        private void TransactionxD_Click(object sender, EventArgs e)
        {
            Admin_TransactionHistory_ xD = new Admin_TransactionHistory_();
            xD.Show();
            this.Hide();
        }

        private void adminInventory_Click(object sender, EventArgs e)
        {
            AdminStaffSession_Inventory_ xD = new AdminStaffSession_Inventory_();
            xD.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Accounts xD = new AdminSession_Manage_Accounts();
            xD.Show();
            this.Hide();
        }
    }
}

