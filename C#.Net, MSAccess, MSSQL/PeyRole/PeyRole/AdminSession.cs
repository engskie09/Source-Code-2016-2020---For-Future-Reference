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

namespace PeyRole
{
    public partial class AdminSession : Form
    {
        public AdminSession()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection();

        int count = 0;

        public void tutskie()
        {
            connection.Close();
            connection.Open();
            DataSet xD = new DataSet();
            OleDbDataAdapter qwerty = new OleDbDataAdapter("select * from AdminLogFile", connection);

            qwerty.Fill(xD);

            count = xD.Tables[0].Rows.Count + 1;


            connection.Close();
        }

        private void AdminSession_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(LoginPayroll.qwe);

            pictureBox1.ImageLocation = LoginPayroll.profilePIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = LoginPayroll.profileName;
            timestart.Start();
            
        }

        private void logout_Click(object sender, EventArgs e)
        {
            connection.Close();

            string name = label1.Text.Trim();
            string time = DateTime.Now.ToString("hh;mm;ss tt");
            string date = DateTime.Now.ToShortDateString();
            string note = "Logout";

            tutskie();

            connection.Open();
            OleDbCommand cmd = new OleDbCommand("insert into AdminLogFile values ('" + count + "','" + name + "','" + time + "','" + date + "','" + note + "')", connection);
            cmd.ExecuteNonQuery();

            connection.Close();

            LoginPayroll xD = new LoginPayroll();
            xD.Show();
            this.Hide();
        }

        private void Personel_Click(object sender, EventArgs e)
        {
            AdminSession_Employee_List_ xD = new AdminSession_Employee_List_();
            xD.Show();
            this.Hide();
        }

        private void Payroll_Click(object sender, EventArgs e)
        {
            AdminSession_Payroll_ xD = new AdminSession_Payroll_();
            xD.Show();
            this.Hide();
        }

        private void timestart_Tick(object sender, EventArgs e)
        {
            timeToday.Text = DateTime.Now.ToLongTimeString();
            datetoday.Text = DateTime.Now.ToShortDateString();
        }
    }
}
