using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Register_Reload_
{
    public partial class Cashier_Main_ : Form
    {
        MySqlConnection connection = new MySqlConnection(methods.con);

        //public string Firstname;
        //public string Lastname;

        public Cashier_Main_()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_AddAccounts_ a = new Cashier_AddAccounts_();
            a.Show();
            this.Hide();
        }
        public void loadCustomers()
        {
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select FirstName, MiddleName , LastName , Balance from carduser;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;

            Customers.RowTemplate.Height = 60;

            Customers.AllowUserToAddRows = false;

            Customers.DataSource = b;


            Customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            Customers.BorderStyle = BorderStyle.None;
            Customers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Customers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Customers.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Customers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Customers.BackgroundColor = Color.White;

            Customers.EnableHeadersVisualStyles = false;
            Customers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Customers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            Customers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        public void loadCanteenManager()
        {



            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from managerlogin;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;

            CanteenManager.RowTemplate.Height = 60;

            CanteenManager.AllowUserToAddRows = false;

            CanteenManager.DataSource = b;

            //Customers.DataSource = b;
            //CanteenManager.DataSource = b;
            //loadCustomers();
            //loadCanteenManager();

            CanteenManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            CanteenManager.BorderStyle = BorderStyle.None;
            CanteenManager.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            CanteenManager.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CanteenManager.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            CanteenManager.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            CanteenManager.BackgroundColor = Color.White;

            CanteenManager.EnableHeadersVisualStyles = false;
            CanteenManager.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            CanteenManager.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            CanteenManager.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
        public void loadLoads()
        {
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from loadtransactionreporttbl;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;

            Loads.RowTemplate.Height = 60;

            Loads.AllowUserToAddRows = false;

            Loads.DataSource = b;


            Loads.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            Loads.BorderStyle = BorderStyle.None;
            Loads.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Loads.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Loads.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            Loads.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Loads.BackgroundColor = Color.White;

            Loads.EnableHeadersVisualStyles = false;
            Loads.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Loads.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            Loads.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


           
        }
        private void Cashier_Main__Load(object sender, EventArgs e)
        {
            Fullname.Text = Cashier_Login_.Fname + Cashier_Login_.Lname; 

            loadLoads();
          
            loadCanteenManager();

            loadCustomers();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cashier_SuperAdminLoginEditLoad_ a = new Cashier_SuperAdminLoginEditLoad_();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier_ReloadBalance_ a = new Cashier_ReloadBalance_();
            a.Show();
            this.Hide();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void Loads_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashier_LoadSalesReport_ a = new Cashier_LoadSalesReport_();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cashier_AddManager_ a = new Cashier_AddManager_();
            a.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
