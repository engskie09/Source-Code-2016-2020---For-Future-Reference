using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engskie09ApartmentSystem
{
    public partial class AdminSession1_Main_ : Form
    {
        public AdminSession1_Main_()
        {
            InitializeComponent();
        }

        private void AdminSession1_Main__Load(object sender, EventArgs e)
        {
            timergetCurrentime.Start();

            lblsetAdminFullname.Text = SystemMethodsAdmin.setAdminFirstname + " " + SystemMethodsAdmin.setAdminMiddlename + " " + SystemMethodsAdmin.setAdminLastname;
            lblsetAdminID.Text = SystemMethodsAdmin.setAdminID;
        }  

     
        private void timergetCurrentime_Tick(object sender, EventArgs e)
        {
            lblSetCurrenttime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

  

        private void btnMyaccount_Click(object sender, EventArgs e)
        {
            AdminSession4_My_Account_ navigate = new AdminSession4_My_Account_();
            navigate.ShowDialog();

            Control[] ctrls = navigate.Controls.Find("lblgetCustomerFirstname", false);
            if (ctrls.Length > 0)
            {
                Label lbl = (Label)ctrls[0];
                lbl.Text = "Hello";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginSession navigate = new LoginSession();
            navigate.Show();
            this.Close();
        }

        private void btnExitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManagecustomers_Click(object sender, EventArgs e)
        {
            AdminSession3_Manage_Customers_ navigate = new AdminSession3_Manage_Customers_();
            navigate.ShowDialog();
        }

        private void btnManagerooms_Click(object sender, EventArgs e)
        {
            AdminSession2_Manage_Rooms_ navigate = new AdminSession2_Manage_Rooms_();
            navigate.ShowDialog();
        }

        private void btnManageStaffs_Click(object sender, EventArgs e)
        {
            AdminSession5_Manage_Staffs_ navigate = new AdminSession5_Manage_Staffs_();
            navigate.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AdminSession6_Reports_ navigate = new AdminSession6_Reports_();
            navigate.ShowDialog();
        }

       

    }
}
