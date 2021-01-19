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
using System.IO;


namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class GeneralSession2_Membership_Type_Add_Membership__ : Form
    {
        public GeneralSession2_Membership_Type_Add_Membership__()
        {
            InitializeComponent();
        }
    
        private void GeneralSession2_Membership_Type_Add_Membership___Load(object sender, EventArgs e)
        {

        }

        String getMembershipName = "", getInstallmentplan = "";
        Int32 getMembershipPeriod = 0, getSignupfee = 0;
        Byte[] getMembershipImage = null;

        //KeyPress-----------------------------------------
        private void txtBoxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            systemMethods_InputValidation.txtBoxLetter(txt.Text, sender, e);
        }

        private void txtBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            systemMethods_InputValidation.txtBoxNumber(sender, e);
        }    

        private void txtBoxLetterNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            systemMethods_InputValidation.txtBoxLetterNumber(txt.Text, sender, e);
        }
        //KeyPress-----------------------------------------

        private void btnAddmembership_Click(object sender, EventArgs e)
        {
            try
            {
                getMembershipName = txtsetMembershipName.Text.Trim();
                getMembershipPeriod = Convert.ToInt32(txtsetMembershipPeriod.Text.Trim());
                getInstallmentplan = txtsetInstallmentplan.Text.Trim();
                getSignupfee = Convert.ToInt32(txtsetSignupfee.Text.Trim());
                //check if Membership Type Information is null.
                if (getMembershipName == "" || getMembershipPeriod == 0 || getInstallmentplan == "" || getSignupfee == 0 || getMembershipImage == null)
                {
                    GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Check your Membership Type Information Inputs ";
                    GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                    navigate.ShowDialog();
                    return;
                }
            }
            catch 
            {
                GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Check your Membership Type Information Inputs ";
                GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                navigate.ShowDialog(); 
                return;
            }    

            systemMethods_Admin_and_Staff_Session.set_Membershiptype(getMembershipImage, getMembershipName, getMembershipPeriod, getInstallmentplan, getSignupfee);
            this.Close();
        }

        private void btnUploadpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            MemoryStream ms = new MemoryStream();          

            opf.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pctBoxgetMembershipImage.Image = Image.FromFile(opf.FileName);
                pctBoxgetMembershipImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pctBoxgetMembershipImage.Image.Save(ms, pctBoxgetMembershipImage.Image.RawFormat);
                getMembershipImage = ms.GetBuffer();    
            }
            ms.Close();           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        
    }
}
