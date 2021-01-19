using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class GeneralSession3_Group_Add_Group__ : Form
    {
        public GeneralSession3_Group_Add_Group__()
        {
            InitializeComponent();
        }        

        private void GeneralSession3_Group_Add_Group___Load(object sender, EventArgs e)
        {

        }

        String getGroupname;
        Int32 getGroupTotalmembers;
        Byte[] getGroupImage;

        //KeyPress-----------------------------------------
        private void txtBoxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            systemMethods_InputValidation.txtBoxLetter(txt.Text, sender, e);
        }
        //KeyPress-----------------------------------------

        private void btnAddGroup_Click(object sender, EventArgs e)
        {       
            try
            {
                getGroupname = txtsetGroupName.Text.Trim();
                getGroupTotalmembers = 0;
                //check if Group Type Information is null.
                if (getGroupname == "" || getGroupImage == null)
                {
                    GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Check your Group Type Information Inputs ";
                    GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                    navigate.ShowDialog();
                    return;
                }
            }
            catch
            {
                GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Check your Group Type Information Inputs ";
                GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                navigate.ShowDialog();
                return;
            }
            
            systemMethods_Admin_and_Staff_Session.set_Group(getGroupImage, getGroupname, getGroupTotalmembers);
            this.Close();
        }

        private void btnUploadpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            MemoryStream ms = new MemoryStream();
            
            opf.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *.png; *gif";

            if (opf.ShowDialog()== DialogResult.OK)
            {
                pctBoxgetGroupImage.Image = Image.FromFile(opf.FileName);
                pctBoxgetGroupImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pctBoxgetGroupImage.Image.Save(ms, pctBoxgetGroupImage.Image.RawFormat);
                getGroupImage = ms.GetBuffer();
            }
            ms.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
