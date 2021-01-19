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
    public partial class StaffSession2_My_Account_ : Form
    {
        public StaffSession2_My_Account_()
        {
            InitializeComponent();
        }

        private void StaffSession2_My_Account__Load(object sender, EventArgs e)
        {
            setStaffInformation();
        }

        private void setStaffInformation()
        {
            lblgetStaffFirstname.Text = SystemMethodsStaff.setStaffFirstname;
            lblgetStaffMiddlename.Text = SystemMethodsStaff.setStaffMiddlename;
            lblgetStaffLastname.Text = SystemMethodsStaff.setStaffLastname;
            lblgetStaffBirthday.Text = SystemMethodsStaff.setStaffBirthday;
            lblgetStaffGender.Text = SystemMethodsStaff.setStaffGender;
            lblgetStaffAge.Text = SystemMethodsStaff.setStaffAge;
            lblgetStaffid.Text = SystemMethodsStaff.setStaffID;
            lblgetStaffUsername.Text = SystemMethodsStaff.setStaffUsername;
            lblgetStaffPassword.Text = SystemMethodsStaff.setStaffPassword;

            string setStaffPasswordtoPasswordchar = "";

            foreach (char ch in lblgetStaffPassword.Text.ToCharArray())
            {
                setStaffPasswordtoPasswordchar = setStaffPasswordtoPasswordchar + "*";
            }
            lblgetStaffPassword.Text = setStaffPasswordtoPasswordchar;
        }      

        private void btnExitform_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
