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
    public partial class MythicalCafe_BackEnd_Workstation_Manage_List : Form
    {
        public MythicalCafe_BackEnd_Workstation_Manage_List(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            InitializeComponent();

            set_dgv_Workstation_Value();

            UserControl_Workstation = set_UserControl_Workstation;
        }

        void MythicalCafe_BackEnd_Workstation_Manage_List_Load(object sender, EventArgs e)
        {            

            KeyDown += delegate(Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Workstation_Name, txtbx_Workstation_Name.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Client_InternetProtocol, txtbx_Client_InternetProtocol.Text.Trim());

            if (btn_Action.Text == "Delete")
            {
                txtbx_Client_InternetProtocol.Enabled = false;
                txtbx_Workstation_Name.Enabled = false;
            }

            lbl_Server_Host.Text = MythicalCafe_BackEnd_Workstation_Server.IPEndPoint.ToString();

            pnl_Server_Host.BorderColoreFocused = Color.White;
            pnl_Server_Host.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            if(btn_Action.Text == "Move Client")
            {
                pnl_Workstation_Information.Enabled = false;

                lbl_getAction.Text = "Select available Workstation";

                MythicalCafe_BackEnd_Workstation_Method.select_Session_Information("Select : All : Active", "", "");

                Workstation_Unavailable = (from row in MythicalCafe_BackEnd_Workstation_Method.get_Workstation_DataTable_3.AsEnumerable() select row["Workstation_Identity"].ToString()).ToList();

                foreach (DataGridViewRow set_DataGridViewRow in dgv_Workstation.Rows)
                {
                    if (Workstation_Unavailable.Contains(set_DataGridViewRow.Cells["Workstation_Identity"].Value.ToString()))
                        dgv_Workstation.Rows.Remove(set_DataGridViewRow);
                }
            }
        }


        MythicalCafe_BackEnd_UserControl_Workstation UserControl_Workstation;

        List<String> Workstation_Unavailable = new List<String>();

        /* Customized Method */

        Color get_Color1 = MythicalCafe_Control_Propety.get_ThemeCurrentColor3;  /* 168, 130, 193 */
        Color get_Color2 = MythicalCafe_Control_Propety.get_ThemeCurrentColor6;  /* 193, 130, 155 */
        Color get_Color3 = MythicalCafe_Control_Propety.get_ThemeCurrentColor4;  /* 130, 76, 167 */

        void set_Control_Color()
        {
            /*get_Color1 = Color.White;
            get_Color2 = Color.White;
            get_Color3 = Color.White;*/

            BackColor = get_Color1;            

            txtbx_Client_InternetProtocol.BackColor = get_Color1;
            txtbx_Client_InternetProtocol.BorderColorIdle = get_Color3;

            txtbx_Workstation_Name.BackColor = get_Color1;
            txtbx_Workstation_Name.BorderColorIdle = get_Color3;

            btn_Action.BackColor = get_Color2;

            dgv_Workstation.BackgroundColor = get_Color3;
            dgv_Workstation.ColumnHeadersDefaultCellStyle.BackColor = get_Color1;
        }

        void set_dgv_Workstation_Value()
        {
            MythicalCafe_BackEnd_Workstation_Manage_List_Method.get_Workstation_Dictionary = MythicalCafe_BackEnd_Workstation_Manage_List_Method.select_Workstation_Information("Select : All", "");

            dgv_Workstation.DataSource = null;

            dgv_Workstation.AutoGenerateColumns = false;

            dgv_Workstation.Columns["Workstation_Identity"].DataPropertyName = "Workstation_Identity";
            dgv_Workstation.Columns["Workstation_Name"].DataPropertyName = "Workstation_Name";
            dgv_Workstation.Columns["Workstation_Client_InternetProtocol"].DataPropertyName = "Workstation_Client_InternetProtocol";
            dgv_Workstation.Columns["Workstation_Server_Host"].DataPropertyName = "Workstation_Server_Host";

            dgv_Workstation.DataSource = MythicalCafe_BackEnd_Workstation_Manage_List_Method.get_Workstation_DatatTable;

        }

        void del_Workstation_Client_Thread(String set_Workstation_Identity)
        {
            MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(set_Workstation_Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

            get_UserControl_Workstation.Connection_Thread.Abort();

            if (MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary.ContainsKey(set_Workstation_Identity))
            {
                MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[set_Workstation_Identity].Interaction_Thread.Abort();

                if(!ReferenceEquals(MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[set_Workstation_Identity].Socket, null))
                if(MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[set_Workstation_Identity].Socket.Connected)
                    MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[set_Workstation_Identity].Connection_Thread.Abort();
            }
        }

        /* Auto Generated Method */

        void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Insert Workstation")
            {
                if (!MythicalCafe_BackEnd_Workstation_Manage_List_Method.check_Workstation_Information(txtbx_Client_InternetProtocol.Text.Trim(), dgv_Workstation, -1))
                    return;

                MythicalCafe_BackEnd_Workstation_Manage_List_Method.insert_Workstation_Information(txtbx_Workstation_Name.Text.Trim(), txtbx_Client_InternetProtocol.Text.Trim(), lbl_Server_Host.Text.Trim());

                set_dgv_Workstation_Value();

                MythicalCafe_BackEnd_Workstation_Server.set_Socket_Client_Configuration();
                

                new MythicalCafe_BackEnd_Dialog("Message: Workstation Inserted.").ShowDialog();
            }

            else if (btn_Action.Text == "Update Workstation")
            {
                if (String.IsNullOrEmpty(Workstation_Identity_Client))
                {
                    new MythicalCafe_BackEnd_Dialog("Message: Please Select Workstation.").ShowDialog();
                    return;
                }

                if (!MythicalCafe_BackEnd_Workstation_Manage_List_Method.check_Workstation_Information(txtbx_Client_InternetProtocol.Text.Trim(), dgv_Workstation, dgv_Workstation_List_Row_Index))
                    return;

                MythicalCafe_BackEnd_Workstation_Manage_List_Method.update_Workstation_Information(Workstation_Identity_Client, txtbx_Workstation_Name.Text.Trim(), txtbx_Client_InternetProtocol.Text.Trim(), lbl_Server_Host.Text.Trim());

                set_dgv_Workstation_Value();

                del_Workstation_Client_Thread(Workstation_Identity_Client);

                MythicalCafe_BackEnd_Workstation_Server.set_Socket_Client_Configuration();

                new MythicalCafe_BackEnd_Dialog("Message: Workstation Updated.").ShowDialog();
            }

            else if (btn_Action.Text == "Delete Workstation")
            {
                if (String.IsNullOrEmpty(Workstation_Identity_Client))
                {
                    new MythicalCafe_BackEnd_Dialog("Message: Please Select Workstation.").ShowDialog();
                    return;
                }

                MythicalCafe_BackEnd_Workstation_Manage_List_Method.delete_Workstation_Information(Workstation_Identity_Client);

                set_dgv_Workstation_Value();

                del_Workstation_Client_Thread(Workstation_Identity_Client);

                new MythicalCafe_BackEnd_Dialog("Message: Workstation Deleted.").ShowDialog();

                MythicalCafe_BackEnd_Workstation_Server.set_Socket_Client_Configuration();
            }

            else if (btn_Action.Text == "Move Client")
            {
                if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Workstation Identity",
                    "Session_Identity",
                    UserControl_Workstation.Session_Identity,
                    Workstation_Identity_Client,
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                ))
                {
                    UserControl_Workstation.Session_Identity = null;
                    UserControl_Workstation.set_Control_Default_Value();
                    UserControl_Workstation.set_Session_Information();
                    UserControl_Workstation.Time_Remaining_Thread.Abort();                    

                    MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Workstation_Identity_Client, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

                    get_UserControl_Workstation.set_Control_Default_Value();
                    get_UserControl_Workstation.set_Session_Information();

                    MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[UserControl_Workstation.Workstation_Identity].Session_Identity = null;
                }
            }

            else return;

            Close();            
        }

        String Workstation_Identity_Client = null;
        Int32 dgv_Workstation_List_Row_Index = 0;

        private void dgv_Workstation_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_Workstation_List_Row_Index = e.RowIndex;
            if (dgv_Workstation_List_Row_Index < 0)
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Workstation.Rows[e.RowIndex];

            Workstation_Identity_Client = get_DataGridViewRow.Cells["Workstation_Identity"].Value.ToString();
            txtbx_Workstation_Name.Text = get_DataGridViewRow.Cells["Workstation_Name"].Value.ToString();
            txtbx_Client_InternetProtocol.Text = get_DataGridViewRow.Cells["Workstation_Client_InternetProtocol"].Value.ToString();
            lbl_Server_Host.Text = get_DataGridViewRow.Cells["Workstation_Server_Host"].Value.ToString();
        }

        private void txtbx_Client_InternetProtocol_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Workstation_InternetProtocol_List().ShowDialog();
        }
    }
}
