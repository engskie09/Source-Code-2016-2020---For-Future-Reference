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
    public partial class AdminSession5_Manage_Staffs_ : Form
    {
        public AdminSession5_Manage_Staffs_()
        {
            InitializeComponent();
        }

        private void AdminSession5_Manage_Staffs__Load(object sender, EventArgs e)
        {
            setdgvStafflist();            
        }

        
        String setStaffFirstName = "";
        String setStaffMiddleName = "";
        String setStaffLastName = "";
        String setStaffBirthday = "";
        String setStaffGender = "";
        String setStaffID = "";
        String setStaffUsername = "";
        String setStaffPassword = "";

        private void setStaffInformation()
        {
            setStaffFirstName = txtgetFirstName.Text;
            setStaffMiddleName = txtgetMiddleName.Text;
            setStaffLastName = txtgetLastName.Text;
            setStaffBirthday = dtpgetBirthday.Value.ToShortDateString();

            if (rbtngetGenderMale.Checked)
            {
                setStaffGender = "Male";
            }

            else if (rbtngetGenderFemale.Checked)
            {
                setStaffGender = "Female";
            }

            setStaffID = lblgetStaffID.Text;
            setStaffUsername = txtgetUsername.Text;
            setStaffPassword = txtgetPassword.Text;

            
        }
        private void setStaffIDVal()
        {
            SystemMethodsGeneral.getStaffID();
            lblgetStaffID.Text = SystemMethodsGeneral.getStaff_ID;
        }

        private void setdgvStafflist()
        {
            SystemMethodsAdmin.getAllStaffInformation();

            dgvStafflist.AutoGenerateColumns = false;
            dgvStafflist.Columns[0].DataPropertyName = "StaffID";
            dgvStafflist.Columns[1].DataPropertyName = "StaffFirstname";
            dgvStafflist.Columns[2].DataPropertyName = "StaffMiddlename";
            dgvStafflist.Columns[3].DataPropertyName = "StaffLastname";

            dgvStafflist.DataSource = SystemMethodsAdmin.dt;
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

            lblgetStaffID.Text = "";
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

            if (btncurrentControl.Name == "btnAddStaff")
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
                setStaffIDVal();
            }

            if (btncurrentControl.Name == "btnUpdateStaff")
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

            if (btncurrentControl.Name == "btnDeleteStaff")
            {
                btngetAction.Visible = true;
                btngetAction.Text = "Delete";
            }
            

        }
        
        private void btngetAction_Click(object sender, EventArgs e)
        {
            if (btngetAction.Text == "Add")
            {

                setStaffInformation();
                if (setStaffFirstName == "" || setStaffMiddleName == "" || setStaffLastName == "" || setStaffBirthday == "" ||
                    setStaffGender == "" || setStaffID == "" || setStaffUsername == "" || setStaffPassword == "")
                {
                    GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                    GeneralSession_MessageBox_OK_.getValidationMessage = "Please don`t leave blank!";
                    navigate.ShowDialog();
                    return;
                }
                
                SystemMethodsAdmin.addStaff(setStaffFirstName, setStaffMiddleName, setStaffLastName,
                                                setStaffBirthday, setStaffGender, setStaffID, setStaffUsername, setStaffPassword);
                SystemMethodsGeneral.addUserLogin(setStaffID, setStaffUsername, setStaffPassword, "Staff");
                SystemMethodsGeneral.updateStaffID();
                
            } 

            if (btngetAction.Text == "Update")
            {
                setStaffInformation();
                if (setStaffFirstName == "" || setStaffMiddleName == "" || setStaffLastName == "" || setStaffBirthday == "" ||
                    setStaffGender == "" || setStaffID == "" || setStaffUsername == "" || setStaffPassword == "")
                {
                    GeneralSession_MessageBox_OK_ navigate = new GeneralSession_MessageBox_OK_();
                    GeneralSession_MessageBox_OK_.getValidationMessage = "Please don`t leave blank!";
                    navigate.ShowDialog();
                    return;
                }

                SystemMethodsAdmin.updateStaff(setStaffFirstName, setStaffMiddleName, setStaffLastName,
                                                setStaffBirthday, setStaffGender, setStaffID, setStaffUsername, setStaffPassword);
                SystemMethodsGeneral.updateUserLogin(setStaffID, setStaffUsername, setStaffPassword, "Staff");
            }

            if (btngetAction.Text == "Delete")
            {
                setStaffInformation();
                SystemMethodsAdmin.deleteStaff(setStaffID);
                SystemMethodsGeneral.deleteUserLogin(setStaffID);
            }

            clearControlsvalues();

            setdgvStafflist();
        }

        private void dgvStafflist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int32 selectedRow = e.RowIndex;

                DataRow dgvRow = SystemMethodsAdmin.dt.Rows[selectedRow];

                lblgetStaffID.Text = dgvRow["StaffID"].ToString();
                txtgetFirstName.Text = dgvRow["StaffFirstname"].ToString();
                txtgetMiddleName.Text = dgvRow["StaffMiddlename"].ToString();
                txtgetLastName.Text = dgvRow["StaffLastname"].ToString();
                dtpgetBirthday.Value = Convert.ToDateTime(dgvRow["StaffBirthday"].ToString());

                String getgender = dgvRow["StaffGender"].ToString();

                if (getgender == "Male")
                    rbtngetGenderMale.Checked = true;
                else if (getgender == "Female")
                    rbtngetGenderFemale.Checked = true;


                txtgetUsername.Text = dgvRow["StaffUsername"].ToString();
                txtgetPassword.Text = dgvRow["StaffPassword"].ToString();
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
