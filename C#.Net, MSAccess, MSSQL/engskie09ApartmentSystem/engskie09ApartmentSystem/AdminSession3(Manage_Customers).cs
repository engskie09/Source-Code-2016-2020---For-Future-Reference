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
    public partial class AdminSession3_Manage_Customers_ : Form
    {
        public AdminSession3_Manage_Customers_()
        {
            InitializeComponent();
        }

        private void AdminSession3_Manage_Customers__Load(object sender, EventArgs e)
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

        private void clearControlsvalues()
        {
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
            dtpgetBirthday.Value = new DateTime(1990, 1, 1);
            txtgetUsername.Text = "";
            txtgetPassword.Text = "";
        }

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetButtonAction_Click(object sender, EventArgs e)
        {
            Control btncurrentControl = (Control)sender;

            clearControlsvalues();

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
                if (setCustomerFirstName == "" || setCustomerMiddleName == "" || setCustomerLastName == "" || setCustomerBirthday == "" ||
                    setCustomerGender == "" || setCustomerID == "" || setCustomerUsername == "" || setCustomerPassword == "")
                {
                    GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                    GeneralSession_MessageBox_OK_.getValidationMessage = "Please don`t leave blank!";
                    navigate.ShowDialog();
                    return;
                }
                
                SystemMethodsAdminStaff.addCustomer(setCustomerFirstName, setCustomerMiddleName, setCustomerLastName,
                                                setCustomerBirthday, setCustomerGender, setCustomerID, setCustomerUsername, setCustomerPassword);
                SystemMethodsGeneral.addUserLogin(setCustomerID, setCustomerUsername, setCustomerPassword, "Customer");
                SystemMethodsGeneral.updateCustomerID();
                
            } 

            if (btngetAction.Text == "Update")
            {
                setCustomerInformation();
                if (setCustomerFirstName == "" || setCustomerMiddleName == "" || setCustomerLastName == "" || setCustomerBirthday == "" ||
                    setCustomerGender == "" || setCustomerID == "" || setCustomerUsername == "" || setCustomerPassword == "")
                {
                    GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                    GeneralSession_MessageBox_OK_.getValidationMessage = "Please don`t leave blank!";
                    navigate.ShowDialog();
                    return;
                }

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

            clearControlsvalues();

            setdgvCustomerlist();
        }

        private void dgvCustomerlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int32 selectedRow = e.RowIndex;

                DataRow dgvRow = SystemMethodsAdminStaff.dt.Rows[selectedRow];

                lblgetCustomerID.Text = dgvRow["CustomerID"].ToString();
                txtgetFirstName.Text = dgvRow["CustomerFirstname"].ToString();
                txtgetMiddleName.Text = dgvRow["CustomerMiddlename"].ToString();
                txtgetLastName.Text = dgvRow["CustomerLastname"].ToString();
                dtpgetBirthday.Value = Convert.ToDateTime(dgvRow["CustomerBirthday"].ToString());

                String getgender = dgvRow["CustomerGender"].ToString();

                if (getgender == "Male")
                    rbtngetGenderMale.Checked = true;
                else if (getgender == "Female")
                    rbtngetGenderFemale.Checked = true;


                txtgetUsername.Text = dgvRow["CustomerUsername"].ToString();
                txtgetPassword.Text = dgvRow["CustomerPassword"].ToString();
            }
            catch (Exception)
            { }
        }

        private void txtBoxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox currentControl = (TextBox)sender;
            SystemGeneralValidations.txtBoxLetter(currentControl.Text, sender, e);
        }

        private void txtBoxLetterNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox currentControl = (TextBox)sender;
            SystemGeneralValidations.txtBoxLetterNumber(currentControl.Text, sender, e);
        }

   

        private void pctBoxShowpassword_Click(object sender, EventArgs e)
        {

            if (txtgetPassword.PasswordChar != '\0')
                txtgetPassword.PasswordChar = '\0';

            else if (txtgetPassword.PasswordChar != '*')
                txtgetPassword.PasswordChar = '*';


        }
            
        private void dtpgetBirthday_ValueChanged(object sender, EventArgs e)
        {

            DateTime getbirthday = dtpgetBirthday.Value;
            DateTime getcurrentTime = DateTime.Now;

            Int32 getcurrentage = getcurrentTime.Year - getbirthday.Year;
            
            //MessageBox.Show(dtpgetBirthday.Value.AddYears(getcurrentage).DayOfYear.ToString() + " " + getcurrentTime.DayOfYear.ToString());


            if (dtpgetBirthday.Value.AddYears(getcurrentage) >= getcurrentTime)
                getcurrentage--;

            lblgetAge.Text = getcurrentage.ToString();

            if (getcurrentage <= 18)
            {
                GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                GeneralSession_MessageBox_OK_.getValidationMessage = "Age: "+ getcurrentage.ToString() +" Doesn`t valid!";
                navigate.ShowDialog();
                dtpgetBirthday.Value = new DateTime(1990,1,1);
                return;
            }
            if (getcurrentage >= 118)
            {
                GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                GeneralSession_MessageBox_OK_.getValidationMessage = "Age: " + getcurrentage.ToString() + " Doesn`t valid!";
                navigate.ShowDialog();
                dtpgetBirthday.Value = new DateTime(1990, 1, 1);
                return;
            }
            
            
            
        }
    }
}
