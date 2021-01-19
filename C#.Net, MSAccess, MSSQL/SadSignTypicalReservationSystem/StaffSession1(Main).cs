using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SadSignTypicalReservationSystem
{
    public partial class StaffSession1_Main_ : Form
    {
        public StaffSession1_Main_()
        {
            InitializeComponent();
        }

        private void StaffSession1_Main__Load(object sender, EventArgs e)
        {
            timergetCurrentime.Start();
        }

        private void timergetCurrentime_Tick(object sender, EventArgs e)
        {
            lblSetCurrenttime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginSession navigate = new LoginSession();
            navigate.Show();
            this.Close();
        }

        private void btnManagecustomers_Click(object sender, EventArgs e)
        {
            AdminSession1_Manage_Customers_ navigate = new AdminSession1_Manage_Customers_();
            navigate.ShowDialog();
        }

        private void btnMyaccount_Click(object sender, EventArgs e)
        {
            StaffSession2_My_Account_ navigate = new StaffSession2_My_Account_();
            navigate.ShowDialog();
        }

        private void btnExitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManagerooms_Click(object sender, EventArgs e)
        {
            AdminSession2_Manage_Rooms_ navigate = new AdminSession2_Manage_Rooms_();
            navigate.ShowDialog();
        }
    }
}
