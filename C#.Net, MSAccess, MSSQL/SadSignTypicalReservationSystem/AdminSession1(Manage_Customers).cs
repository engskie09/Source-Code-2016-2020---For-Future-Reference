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
    public partial class AdminSession1_Manage_Customers_ : Form
    {
        public AdminSession1_Manage_Customers_()
        {
            InitializeComponent();
        }

        private void AdminSession1_Manage_Customers__Load(object sender, EventArgs e)
        {
            setdgvCustomerlist();            
        }

        
        String setCustomerFirstName = "";
        String setCustomerMiddleName = "";
        String setCustomerLastName = "";
        String setCustomerBirthday = "";
        String setCustomerGender = "";
        String setCustomerID = "";
        String setCustomerUsername = "";
        String setCustomerPassword = "";

        private void setCustomerInformation()
        {            
            setCustomerFirstName = txtgetFirstName.Text;
            setCustomerMiddleName = txtgetMiddleName.Text;
            setCustomerLastName = txtgetLastName.Text;
            setCustomerBirthday = dtpgetBirthday.Value.ToShortDateString();

            if (rbtngetGenderMale.Checked)
            {
                setCustomerGender = "Male";
            }

            else if (rbtngetGenderFemale.Checked)
            {
                setCustomerGender = "Female";
            }

            setCustomerID = lblgetCustomerID.Text;
            setCustomerUsername = txtgetUsername.Text;
            setCustomerPassword = txtgetPassword.Text;

            
        }
        private void setCustomerIDVal()
        {
            SystemMethodsGeneral.getCustomerID();
            lblgetCustomerID.Text = SystemMethodsGeneral.getCustomer_ID;
        }

        private void setdgvCustomerlist()
        {
            SystemMethodsAdminStaff.getAllCustomerInformation();

            dgvCustomerlist.AutoGenerateColumns = false;
            dgvCustomerlist.Columns[0].DataPropertyName = "CustomerID";
            dgvCustomerlist.Columns[1].DataPropertyName = "CustomerFirstname";
            dgvCustomerlist.Columns[2].DataPropertyName = "CustomerMiddlename";
            dgvCustomerlist.Columns[3].DataPropertyName = "CustomerLastname";

            dgvCustomerlist.DataSource = SystemMethodsAdminStaff.dt;
        }

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetButtonAction_Click(object sender, EventArgs e)
        {
            Control btncurrentControl = (Control)sender;

            if (btncurrentControl.Name == "btnAddCustomer")
            {
                btngetAction.Visible = true;
                btngetAction.Text = "Add";

                txtgetFirstName.Enabled = true;
                txtgetMiddleName.Enabled = true;
                txtgetLastName.Enabled = true;
                dtpgetBirthday.Enabled = true;
                rbtngetGenderMale.Enabled = true;
                rbtngetGenderFemale.Enabled = true;
                txtgetUsername.Enabled = true;
                txtgetPassword.Enabled = true;

                txtgetFirstName.BackColor = Color.FromArgb(224, 252, 149);
                txtgetMiddleName.BackColor = Color.FromArgb(224, 252, 149);
                txtgetLastName.BackColor = Color.FromArgb(224, 252, 149);
                txtgetUsername.BackColor = Color.FromArgb(224, 252, 149);
                txtgetPassword.BackColor = Color.FromArgb(224, 252, 149);
                setCustomerIDVal();
            }

            if (btncurrentControl.Name == "btnUpdateCustomer")
            {
                btngetAction.Visible = true;
                btngetAction.Text = "Update";

                txtgetFirstName.Enabled = true;
                txtgetMiddleName.Enabled = true;
                txtgetLastName.Enabled = true;
                dtpgetBirthday.Enabled = true;
                rbtngetGenderMale.Enabled = true;
                rbtngetGenderFemale.Enabled = true;
                txtgetUsername.Enabled = true;
                txtgetPassword.Enabled = true;

                txtgetFirstName.BackColor = Color.FromArgb(224, 252, 149);
                txtgetMiddleName.BackColor = Color.FromArgb(224, 252, 149);
                txtgetLastName.BackColor = Color.FromArgb(224, 252, 149);
                txtgetUsername.BackColor = Color.FromArgb(224, 252, 149);
                txtgetPassword.BackColor = Color.FromArgb(224, 252, 149);

            }

            if (btncurrentControl.Name == "btnDeleteCustomer")
            {
                btngetAction.Visible = true;
                btngetAction.Text = "Delete";
            }

        }

        private void btngetAction_Click(object sender, EventArgs e)
        {
            if (btngetAction.Text == "Add")
            {
                setCustomerInformation();
                SystemMethodsAdminStaff.addCustomer(setCustomerFirstName, setCustomerMiddleName, setCustomerLastName,
                                                setCustomerBirthday, setCustomerGender, setCustomerID, setCustomerUsername, setCustomerPassword);
                SystemMethodsGeneral.addUserLogin(setCustomerID, setCustomerUsername, setCustomerPassword, "Customer");
                SystemMethodsGeneral.updateCustomerID();
            } 

            if (btngetAction.Text == "Update")
            {
                setCustomerInformation();
                SystemMethodsAdmin.updateCustomer(setCustomerFirstName, setCustomerMiddleName, setCustomerLastName,
                                                setCustomerBirthday, setCustomerGender, setCustomerID, setCustomerUsername, setCustomerPassword);
                SystemMethodsGeneral.updateUserLogin(setCustomerID, setCustomerUsername, setCustomerPassword, "Customer");
            }

            if (btngetAction.Text == "Delete")
            {
                setCustomerInformation();
                SystemMethodsAdmin.deleteCustomer(setCustomerID);
                SystemMethodsGeneral.deleteUserLogin(setCustomerID);
            }

            txtgetFirstName.Enabled = false;
            txtgetMiddleName.Enabled = false;
            txtgetLastName.Enabled = false;
            dtpgetBirthday.Enabled = false;
            rbtngetGenderMale.Enabled = false;
            rbtngetGenderFemale.Enabled = false;
            txtgetUsername.Enabled = false;
            txtgetPassword.Enabled = false;

            txtgetFirstName.BackColor = Color.FromArgb(244, 255, 223);
            txtgetMiddleName.BackColor = Color.FromArgb(244, 255, 223);
            txtgetLastName.BackColor = Color.FromArgb(244, 255, 223);
            txtgetUsername.BackColor = Color.FromArgb(244, 255, 223);
            txtgetPassword.BackColor = Color.FromArgb(244, 255, 223);

            btngetAction.Visible = false;

            lblgetCustomerID.Text = "";
            txtgetFirstName.Text = "";
            txtgetMiddleName.Text = "";
            txtgetLastName.Text = "";
            dtpgetBirthday.Text = "";            
            txtgetUsername.Text = "";
            txtgetPassword.Text = "";

            setdgvCustomerlist();
        }

        private void dgvCustomerlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = e.RowIndex;

            DataRow dgvRow = SystemMethodsAdminStaff.dt.Rows[selectedRow];

            lblgetCustomerID.Text = dgvRow["CustomerID"].ToString();
            txtgetFirstName.Text = dgvRow["CustomerFirstname"].ToString();
            txtgetMiddleName.Text = dgvRow["CustomerMiddlename"].ToString();
            txtgetLastName.Text = dgvRow["CustomerLastname"].ToString();
            dtpgetBirthday.Text = dgvRow["CustomerBirthday"].ToString();

            String getgender = dgvRow["CustomerGender"].ToString();

            if (getgender == "Male")
                rbtngetGenderMale.Checked = true;
            else if (getgender == "Female")
                rbtngetGenderFemale.Checked = true;


            txtgetUsername.Text = dgvRow["CustomerUsername"].ToString();
            txtgetPassword.Text = dgvRow["CustomerPassword"].ToString();
        }
    }
}
