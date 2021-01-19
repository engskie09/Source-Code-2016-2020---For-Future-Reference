using Newtonsoft.Json.Linq;
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
    public partial class MythicalCafe_BackEnd_Account_Staff_Manage_List : Form
    {
        public MythicalCafe_BackEnd_Account_Staff_Manage_List()
        {
            InitializeComponent();

            set_Control_Property();
        }

        private void MythicalCafe_BackEnd_Account_Staff_Manage_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };            
        }

        public JObject Staff_Information = null;

        public String Position = null;

        public void get_Action(String set_Action)
        {
            if (set_Action == "Insert Account")
            {
                lbl_Staff_Identity.Text = MythicalCafe_BackEnd_Main_Method.Staff_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Staff_Identity_Code) + 1000).ToString();

                lbl_Staff_Position.Text = Position;

                btn_Action.Text = set_Action;
            }

            else if (set_Action == "Update Account")
            {
                lbl_Staff_Identity.Text = Staff_Information["Staff_Identity"].ToString();

                txtbx_FirstName.Text = Staff_Information["Staff_FirstName"].ToString();
                txtbx_MiddleName.Text = Staff_Information["Staff_MiddleName"].ToString();
                txtbx_LastName.Text = Staff_Information["Staff_LastName"].ToString();              


                lbl_Staff_Position.Text = Staff_Information["Staff_Position"].ToString();

                txtbx_UserName.Text = Staff_Information["Staff_UserName"].ToString();
                txtbx_UserName.Enabled = false;

                txtbx_Password.Text = Staff_Information["Staff_Password"].ToString();

                if (Staff_Information["Staff_Status"].ToString() == "Enable")
                    chkbx_Staff_Status.Checked = true;

                else
                    chkbx_Staff_Status.Checked = false;


                btn_Action.Text = set_Action;
            }

            else
                return;
        }


        void set_Control_Property()
        {
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_FirstName, txtbx_FirstName.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_MiddleName, txtbx_MiddleName.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_LastName, txtbx_LastName.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_UserName, txtbx_UserName.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Password, txtbx_Password.Text);

            MythicalCafe_Control_Propety.set_TextBox_Character_Password(txtbx_Password);

            pnl_Product_Identity.BorderColoreFocused = Color.White;
            pnl_Product_Identity.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            pnl_Staff_Position.BorderColoreFocused = Color.White;
            pnl_Staff_Position.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            pnl_Manage_Privilege.BorderColoreFocused = Color.White;
            pnl_Manage_Privilege.BorderColoreIdle = Color.FromArgb(17, 202, 168);
        }

        String[] get_Staff_Information_Array = new String[0];

        void get_Control_Value()
        {
            if (btn_Action.Text == "Insert Account")
            {
                get_Staff_Information_Array = new String[10];

                get_Staff_Information_Array[1] = lbl_Staff_Identity.Text;
                get_Staff_Information_Array[2] = txtbx_UserName.Text;
                get_Staff_Information_Array[3] = txtbx_Password.Text;
                get_Staff_Information_Array[4] = txtbx_FirstName.Text;
                get_Staff_Information_Array[5] = txtbx_MiddleName.Text;
                get_Staff_Information_Array[6] = txtbx_LastName.Text;
                get_Staff_Information_Array[7] = lbl_Staff_Position.Text;
                get_Staff_Information_Array[8] = "";

                if (chkbx_Staff_Status.Checked)
                    get_Staff_Information_Array[9] = "Enable";

                else
                    get_Staff_Information_Array[9] = "Disable";
            }

            else if (btn_Action.Text == "Update Account")
            {
                get_Staff_Information_Array = new String[11];

                get_Staff_Information_Array[1] = "Update : Specific";
                get_Staff_Information_Array[2] = lbl_Staff_Identity.Text;
                get_Staff_Information_Array[3] = txtbx_UserName.Text;
                get_Staff_Information_Array[4] = txtbx_Password.Text;
                get_Staff_Information_Array[5] = txtbx_FirstName.Text;
                get_Staff_Information_Array[6] = txtbx_MiddleName.Text;
                get_Staff_Information_Array[7] = txtbx_LastName.Text;
                get_Staff_Information_Array[8] = lbl_Staff_Position.Text;
                get_Staff_Information_Array[9] = "";

                if (chkbx_Staff_Status.Checked)
                    get_Staff_Information_Array[10] = "Enable";

                else
                    get_Staff_Information_Array[10] = "Disable";
            }
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            get_Control_Value();

            if (btn_Action.Text == "Insert Account")
            {                
                if(MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information
                (
                    "Select : Specific : Staff_UserName",
                    null,
                    get_Staff_Information_Array[2],
                    null,
                    null
                ))
                {
                    new MythicalCafe_BackEnd_Dialog("Message: Username already exist.").ShowDialog();
                    return;
                }

                MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.insert_Staff_Information
                (
                    get_Staff_Information_Array[1],
                    get_Staff_Information_Array[2],
                    get_Staff_Information_Array[3],
                    get_Staff_Information_Array[4],
                    get_Staff_Information_Array[5],
                    get_Staff_Information_Array[6],
                    get_Staff_Information_Array[7],
                    get_Staff_Information_Array[8],
                    get_Staff_Information_Array[9]
                );

                MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Staff_Identity_Code);               
            }

            else if (btn_Action.Text == "Update Account")
            {
                MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.update_Staff_Information
                (
                    get_Staff_Information_Array[1],
                    get_Staff_Information_Array[2],
                    get_Staff_Information_Array[3],
                    get_Staff_Information_Array[4],
                    get_Staff_Information_Array[5],
                    get_Staff_Information_Array[6],
                    get_Staff_Information_Array[7],
                    get_Staff_Information_Array[8],
                    get_Staff_Information_Array[9],
                    get_Staff_Information_Array[10]
                );
            }

            else
                return;

            DialogResult = DialogResult.OK;

            Close();

        }
    }
}