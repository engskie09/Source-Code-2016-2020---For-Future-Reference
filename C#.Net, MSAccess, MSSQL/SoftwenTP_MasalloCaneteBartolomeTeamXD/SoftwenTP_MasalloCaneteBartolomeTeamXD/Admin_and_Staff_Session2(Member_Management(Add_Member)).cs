/*                                                                                                                          
8 888888888o.            .8.          8 8888888888       .8.          8 8888888888   8 8888                                           
8 8888    `88.          .888.         8 8888            .888.         8 8888         8 8888                                           
8 8888     `88         :88888.        8 8888           :88888.        8 8888         8 8888                                           
8 8888     ,88        . `88888.       8 8888          . `88888.       8 8888         8 8888                                           
8 8888.   ,88'       .8. `88888.      8 888888888888 .8. `88888.      8 888888888888 8 8888                                           
8 888888888P'       .8`8. `88888.     8 8888        .8`8. `88888.     8 8888         8 8888                                           
8 8888`8b          .8' `8. `88888.    8 8888       .8' `8. `88888.    8 8888         8 8888                                           
8 8888 `8b.       .8'   `8. `88888.   8 8888      .8'   `8. `88888.   8 8888         8 8888                                           
8 8888   `8b.    .888888888. `88888.  8 8888     .888888888. `88888.  8 8888         8 8888                                           
8 8888     `88. .8'       `8. `88888. 8 8888    .8'       `8. `88888. 8 888888888888 8 888888888888                                   
                                                                                                                                      
b.             8     ,o888888o.     8 888888888o   8 8888         8 8888888888    8888888888',8888'        .8.                        
888o.          8  . 8888     `88.   8 8888    `88. 8 8888         8 8888                 ,8',8888'        .888.                       
Y88888o.       8 ,8 8888       `8b  8 8888     `88 8 8888         8 8888                ,8',8888'        :88888.                      
.`Y888888o.    8 88 8888        `8b 8 8888     ,88 8 8888         8 8888               ,8',8888'        . `88888.                     
8o. `Y888888o. 8 88 8888         88 8 8888.   ,88' 8 8888         8 888888888888      ,8',8888'        .8. `88888.                    
8`Y8o. `Y88888o8 88 8888         88 8 8888888888   8 8888         8 8888             ,8',8888'        .8`8. `88888.                   
8   `Y8o. `Y8888 88 8888        ,8P 8 8888    `88. 8 8888         8 8888            ,8',8888'        .8' `8. `88888.                  
8      `Y8o. `Y8 `8 8888       ,8P  8 8888      88 8 8888         8 8888           ,8',8888'        .8'   `8. `88888.                 
8         `Y8o.`  ` 8888     ,88'   8 8888    ,88' 8 8888         8 8888          ,8',8888'        .888888888. `88888.                
8            `Yo     `8888888P'     8 888888888P   8 888888888888 8 888888888888 ,8',8888888888888.8'       `8. `88888.               
          .         .                                                                                                                 
         ,8.       ,8.                   .8.            d888888o.           .8.          8 8888         8 8888         ,o888888o.     
        ,888.     ,888.                 .888.         .`8888:' `88.        .888.         8 8888         8 8888      . 8888     `88.   
       .`8888.   .`8888.               :88888.        8.`8888.   Y8       :88888.        8 8888         8 8888     ,8 8888       `8b  
      ,8.`8888. ,8.`8888.             . `88888.       `8.`8888.          . `88888.       8 8888         8 8888     88 8888        `8b 
     ,8'8.`8888,8^8.`8888.           .8. `88888.       `8.`8888.        .8. `88888.      8 8888         8 8888     88 8888         88 
    ,8' `8.`8888' `8.`8888.         .8`8. `88888.       `8.`8888.      .8`8. `88888.     8 8888         8 8888     88 8888         88 
   ,8'   `8.`88'   `8.`8888.       .8' `8. `88888.       `8.`8888.    .8' `8. `88888.    8 8888         8 8888     88 8888        ,8P 
  ,8'     `8.`'     `8.`8888.     .8'   `8. `88888.  8b   `8.`8888.  .8'   `8. `88888.   8 8888         8 8888     `8 8888       ,8P  
 ,8'       `8        `8.`8888.   .888888888. `88888. `8b.  ;8.`8888 .888888888. `88888.  8 8888         8 8888      ` 8888     ,88'   
,8'         `         `8.`8888. .8'       `8. `88888. `Y8888P ,88P'.8'       `8. `88888. 8 888888888888 8 888888888888 `8888888P'     
 */

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
    public partial class Admin_and_Staff_Session2_Member_Management_Add_Member__ : Form
    {
        public Admin_and_Staff_Session2_Member_Management_Add_Member__()
        {
            InitializeComponent();
        }

        private void Admin_and_Staff_Session2_Member_Management_Add_Member___Load(object sender, EventArgs e)
        {
            systemMethods_GeneralSession.getCountNameNumber("Counter_CustomerID");
            lblgetCustomerMemberid.Text = systemMethods_GeneralSession.setCustomerID;
            setcmBOX_GroupName_and_ClassName();
            
            panelPersonalContactLogin.Location = new Point(0, 126);
            panelPhysicalMore.Location = new Point(0, 126);
        }        

        //get Customer Personal Information from controls.
        String getCustomerMemberid ,getCustomerFirstname, getCustomerMiddlename, getCustomerLastname, getCustomerGender, 
               getCustomerDateofBirth, getCustomerClass, getCustomerGroup;

        //get Customer Contact Information from controls.
        String getCustomerAddress, getCustomerCity, getCustomerState, getCustomerZipcode,
               getCustomerMobilenumber, getCustomerPhone, getCustomerEmail;

        //get Customer Login Information from controls.
        String getCustomerUsername, getCustomerPassword, getCustomerRole;

        Byte[] getCustomerImage;

        //get Customer All Information from controls.
        private void getCustomerAllInformationsFromControls()
        {
            //get Customer Personal Information from controls.
            getCustomerMemberid     = lblgetCustomerMemberid.Text;
            getCustomerFirstname    = txtgetCustomerFirstname.Text;
            getCustomerMiddlename   = txtgetCustomerMiddlename.Text;
            getCustomerLastname     = txtgetCustomerLastname.Text;

            if (rbtngetCustomerGendermale.Checked)
            {
                getCustomerGender = "Male";
            }

            else if (rbtngetCustomerGenderfemale.Checked)
            {
                getCustomerGender = "Female";
            }
            
            getCustomerDateofBirth  = dtPickergetCustomerDateofBirth.Value.ToString("MM/dd/yyyy");
            getCustomerClass        = cmBoxgetCustomerClass.Text;
            getCustomerGroup        = cmBoxgetCustomerGroup.Text;

            //get Customer Contact Information from controls.
            getCustomerAddress      = txtgetCustomerAddress.Text;
            getCustomerCity         = txtgetCustomerCity.Text;
            getCustomerState        = txtgetCustomerState.Text;
            getCustomerZipcode      = txtgetCustomerZipcode.Text;
            getCustomerMobilenumber = txtgetCustomerMobilenumber.Text;
            getCustomerPhone        = txtgetCustomerPhone.Text;
            getCustomerEmail        = txtgetCustomerEmail.Text;
            
            //get Customer Login Information from controls.
            getCustomerUsername     = txtgetCustomerUsername.Text;
            getCustomerPassword     = txtgetCustomerPassword.Text;
            getCustomerRole = "Customer";

        }

        //set cmbBox Group_Name
        private void setcmBOX_GroupName_and_ClassName()
        {
            systemMethods_CustomerSession.getset_groupName();
            systemMethods_CustomerSession.getset_className();

            for (int x = 0; x <= systemMethods_CustomerSession.getGroupName.Count - 1; x++)
            {
                cmBoxgetCustomerGroup.Items.Add(systemMethods_CustomerSession.getGroupName[x]);
            }

            for (int x = 0; x <= systemMethods_CustomerSession.getClassName.Count - 1; x++)
            {
                cmBoxgetCustomerClass.Items.Add(systemMethods_CustomerSession.getClassName[x]);
            }
                
        }

        //set Customer All Information from controls.
        private void settCustomerAllInformationsFromControls()
        {
            systemMethods_CustomerSession.setcustomer_personalinformation(getCustomerMemberid, getCustomerFirstname, getCustomerMiddlename, getCustomerLastname, 
                                                                   getCustomerGender, getCustomerDateofBirth, getCustomerClass, getCustomerGroup);
            systemMethods_CustomerSession.setcustomer_contactinformation(getCustomerMemberid, getCustomerAddress, getCustomerCity, getCustomerState, 
                                                                  getCustomerZipcode, getCustomerMobilenumber, getCustomerPhone, getCustomerEmail);
            systemMethods_CustomerSession.setcustomer_Logininformation(getCustomerMemberid, getCustomerUsername, getCustomerPassword, getCustomerRole, getCustomerImage);        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            getCustomerAllInformationsFromControls();
            
            //check if Personal Information is null.
            if (getCustomerMemberid == "" || getCustomerFirstname == "" || getCustomerMiddlename == "" || getCustomerLastname == "" || getCustomerGender == "" ||
                getCustomerDateofBirth == "" || getCustomerClass == "" || getCustomerGroup == "")
            {
                GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Check your Personal Information Inputs ";
                GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                navigate.ShowDialog();
                return;
            }

            //check if Contact Information is null.
            if (getCustomerAddress == "" || getCustomerCity == "" || getCustomerState == "" || getCustomerZipcode == "" || getCustomerMobilenumber == "" ||
                getCustomerPhone == "" || getCustomerEmail == "")
            {
                GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Check your Contact Information Inputs ";
                GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                navigate.ShowDialog();
                return; 
            }

            //check if Login Information is null.
            if (getCustomerUsername == "" || getCustomerPassword == "" || getCustomerRole == "" || getCustomerImage == null)
            {
                GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Check your Login Information Inputs ";
                GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                navigate.ShowDialog();
                return;
            }     
           
            settCustomerAllInformationsFromControls();
            systemMethods_GeneralSession.updateCountIncrement("Counter_CustomerID");           
            this.Close();           

        }

        private void btnuploadCustomerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            MemoryStream ms = new MemoryStream();
            
            opf.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pctBoxgetCustomerImage.Image = Image.FromFile(opf.FileName);
                pctBoxgetCustomerImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pctBoxgetCustomerImage.Image.Save(ms, pctBoxgetCustomerImage.Image.RawFormat);
                getCustomerImage = ms.GetBuffer();              
                
            }
            ms.Close();  

        }      

        private void btnShowPanel_Click(object sender, EventArgs e)
        {
            if (panelPersonalContactLogin.Visible)
            {
                panelPersonalContactLogin.Visible = false;
                panelPhysicalMore.Visible = true;
                btnShowPanel.Text = "Page 2/2";
            }

            else if (panelPhysicalMore.Visible)
            {
                panelPersonalContactLogin.Visible = true;
                panelPhysicalMore.Visible = false; ;
                btnShowPanel.Text = "Page 1/2";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
       
    }
}
