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


using System.Windows.Forms.Design;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class Admin_and_Staff_Session2_Member_Management_ : Form
    {
        public Admin_and_Staff_Session2_Member_Management_()
        {
            InitializeComponent();
        }

        private void Admin_and_Staff_Session2_Member_Management__Load(object sender, EventArgs e)
        {
            panelCustomerList.Location = new Point(34, 97);
            panelStaffList.Location = new Point(34, 97);
            PanelAccountantList.Location = new Point(34, 97);

            panelCustomerList.Visible = true;
            panelStaffList.Visible = false;
            PanelAccountantList.Visible = false;          
           
        }

        private class  MyTextbox : System.Windows.Forms.TextBox
            {
            }

        private void btnShowCustomerListOrStaffListOrAccountantList_Click(object sender, EventArgs e)
        {
            if (panelCustomerList.Visible)
            {
                panelCustomerList.Visible = false;
                panelStaffList.Visible = true;
                PanelAccountantList.Visible = false;
                

            }

            else if (panelStaffList.Visible)
            {

                panelCustomerList.Visible = false;
                panelStaffList.Visible = false;
                PanelAccountantList.Visible = true;

            }

            else if (PanelAccountantList.Visible)
            {

                panelCustomerList.Visible = true;
                panelStaffList.Visible = false;
                PanelAccountantList.Visible = false;

            }

        }

        private void btnAddcustomer_Click(object sender, EventArgs e)
        {
            Admin_and_Staff_Session2_Member_Management_Add_Member__ navigate = new Admin_and_Staff_Session2_Member_Management_Add_Member__();
            navigate.ShowDialog();
        }
    }
}
