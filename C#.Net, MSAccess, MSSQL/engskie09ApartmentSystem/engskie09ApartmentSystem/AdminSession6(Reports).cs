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
    public partial class AdminSession6_Reports_ : Form
    {
        public AdminSession6_Reports_()
        {
            InitializeComponent();
        }

        private void AdminSession6_Reports__Load(object sender, EventArgs e)
        {
            setdgvCustomerCheckInOutlist();
        }

        private void setdgvCustomerCheckInOutlist()
        {
            SystemMethodsAdmin.getReportCheckInOut();

           
            dgvCustomerCheckInOutlist.DataSource = null;
            dgvCustomerCheckInOutlist.AutoGenerateColumns = false;

            dgvCustomerCheckInOutlist.Columns[0].DataPropertyName = "CustomerFirstname";
            dgvCustomerCheckInOutlist.Columns[1].DataPropertyName = "CustomerMiddlename";
            dgvCustomerCheckInOutlist.Columns[2].DataPropertyName = "CustomerLastname";
            dgvCustomerCheckInOutlist.Columns[3].DataPropertyName = "CustomerID";
            dgvCustomerCheckInOutlist.Columns[4].DataPropertyName = "CustomerGender";
            dgvCustomerCheckInOutlist.Columns[5].DataPropertyName = "CustomerCheckinDate";
            dgvCustomerCheckInOutlist.Columns[6].DataPropertyName = "CustomerCheckoutDate";
            dgvCustomerCheckInOutlist.Columns[7].DataPropertyName = "CustomerLengthofstay";
            dgvCustomerCheckInOutlist.Columns[8].DataPropertyName = "CustomerRoomNo";
            dgvCustomerCheckInOutlist.Columns[9].DataPropertyName = "CustomerRoomType";
            dgvCustomerCheckInOutlist.Columns[10].DataPropertyName = "CustomerFloorNo";
            dgvCustomerCheckInOutlist.Columns[11].DataPropertyName = "CustomerRoomAmount";
            dgvCustomerCheckInOutlist.Columns[12].DataPropertyName = "CustomerTotalAmount";
            dgvCustomerCheckInOutlist.Columns[13].DataPropertyName = "CustomerAction";

            dgvCustomerCheckInOutlist.DefaultCellStyle.WrapMode = DataGridViewTriState.True; 

            dgvCustomerCheckInOutlist.DataSource = SystemMethodsAdmin.dt;

        }

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            AdminSession6_Reports_Report_ navigate = new AdminSession6_Reports_Report_();
            navigate.ShowDialog();
        }

    }
}
