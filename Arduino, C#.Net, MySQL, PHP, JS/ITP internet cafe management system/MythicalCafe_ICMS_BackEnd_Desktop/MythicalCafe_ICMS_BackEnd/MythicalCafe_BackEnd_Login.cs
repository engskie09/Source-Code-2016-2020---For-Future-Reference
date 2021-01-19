using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Login : Form
    {
        public MythicalCafe_BackEnd_Login()
        {
            InitializeComponent();
        }        

        private void MythicalCafe_BackEnd_Login_Load(object sender, EventArgs e)
        {

            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Username, txtbx_Username.Text.Trim());

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Password, txtbx_Password.Text.Trim());

            MythicalCafe_Control_Propety.set_TextBox_Character_Password(txtbx_Password);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (MythicalCafe_BackEnd_Main_Method.get_Staff_Position_Information("", txtbx_Username.Text.Trim(), txtbx_Password.Text.Trim()))
            {
                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Login"
                );

                DialogResult = DialogResult.OK;
            }

            else
                new MythicalCafe_BackEnd_Dialog("Message: Try Again.").ShowDialog();
        }
    }
}
