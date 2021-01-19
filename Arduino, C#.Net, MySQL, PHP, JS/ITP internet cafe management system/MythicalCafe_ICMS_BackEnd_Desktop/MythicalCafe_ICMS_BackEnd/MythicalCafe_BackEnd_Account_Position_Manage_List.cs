using Binarymission.WinForms.Controls.BinaryButtonSuite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Account_Position_Manage_List : Form
    {
        public MythicalCafe_BackEnd_Account_Position_Manage_List()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Account_Position_Manage_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            set_TableLayoutPanel_CellPaint(pnl_Workstation);

            set_TableLayoutPanel_CellPaint(pnl_Product);

            set_TableLayoutPanel_CellPaint(pnl_Account);
            set_TableLayoutPanel_CellPaint(pnl_Account_Manage);

            set_TableLayoutPanel_CellPaint(pnl_Setting);
            set_TableLayoutPanel_CellPaint(pnl_Setting_Manage);

            //dgv_Position.Rows.Add("Super Admin");
            dgv_Position.Rows.Add("Admin");
            dgv_Position.Rows.Add("Staff");

            pnl_Main.SetCellPosition(pnl_Setting, new TableLayoutPanelCellPosition(2, 0));

            pnl_Main.SetCellPosition(pnl_Workstation, new TableLayoutPanelCellPosition(0, 0));
            pnl_Main.SetCellPosition(pnl_Product, new TableLayoutPanelCellPosition(0, 1));
            pnl_Main.SetCellPosition(pnl_Account, new TableLayoutPanelCellPosition(1, 0));
        }

        void set_TableLayoutPanel_CellPaint(TableLayoutPanel set_TableLayoutPanel)
        {
            set_TableLayoutPanel.CellPaint += delegate (Object set_Object, TableLayoutCellPaintEventArgs set_TableLayoutCellPaintEventArgs)
            {
                TableLayoutPanel get_Panel = (TableLayoutPanel)set_Object;

                if (Object.ReferenceEquals(get_Panel.GetControlFromPosition(set_TableLayoutCellPaintEventArgs.Column, set_TableLayoutCellPaintEventArgs.Row), null))
                    return;

                set_TableLayoutCellPaintEventArgs.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                Rectangle rectangle = set_TableLayoutCellPaintEventArgs.CellBounds;

                using (Pen pen = new Pen(Color.FromArgb(17, 202, 168), 3))
                {
                    pen.Alignment = PenAlignment.Inset;
                    pen.DashStyle = DashStyle.Solid;

                    if (set_TableLayoutCellPaintEventArgs.Row == (get_Panel.RowCount - 1))
                    {
                        rectangle.Height -= 1;
                    }

                    if (set_TableLayoutCellPaintEventArgs.Column == (get_Panel.ColumnCount - 1))
                    {
                        rectangle.Width -= 1;
                    }

                    set_TableLayoutCellPaintEventArgs.Graphics.DrawRectangle(pen, rectangle);
                    
                }
            };
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            Staff_Privilege.Clear();

            //Workstation
            get_Panel_CheckBox_Value(pnl_Workstation);
            get_Panel_CheckBox_Value(pnl_Workstation_Manage);
            get_Panel_CheckBox_Value(pnl_Workstation_Log);

            //Product
            get_Panel_CheckBox_Value(pnl_Product_Manage);
            get_Panel_CheckBox_Value(pnl_Product_Order_Queue);
            get_Panel_CheckBox_Value(pnl_Product_Category);
            get_Panel_CheckBox_Value(pnl_Product_Log);

            //Account
            get_Panel_CheckBox_Value(pnl_Account);
            get_Panel_CheckBox_Value(pnl_Account_Manage_Super_Admin);
            get_Panel_CheckBox_Value(pnl_Account_Manage_Admin);
            get_Panel_CheckBox_Value(pnl_Account_Manage_Staff);
            get_Panel_CheckBox_Value(pnl_Account_Log);

            //Setting

            get_Panel_CheckBox_Value(pnl_Setting_Manage);
            get_Panel_CheckBox_Value(pnl_Serial_Connection_Manage);
            get_Panel_CheckBox_Value(pnl_Setting_Manage_Time_Warning);

            if (Staff_Privilege.Count == 0)
                return;

            String get_String = null;

            foreach (String set_String in Staff_Privilege)
                get_String += set_String + ", ";

            get_String = get_String.Trim();
            get_String = get_String.TrimEnd(',');

            MessageBox.Show(get_String);

            String get_Super_Admin_Privilege_String = null;
            String get_Admin_Privilege_String = null;
            String get_Staff_Privilege_String = null;

            foreach (String set_String in MythicalCafe_BackEnd_Main_Method.Staff_Position_Dictionary["Super Admin"])
                get_Super_Admin_Privilege_String += set_String + ", ";

            get_Super_Admin_Privilege_String = get_Super_Admin_Privilege_String.Trim();
            get_Super_Admin_Privilege_String = get_Super_Admin_Privilege_String.TrimEnd(',');

            foreach (String set_String in MythicalCafe_BackEnd_Main_Method.Staff_Position_Dictionary["Admin"])
                get_Admin_Privilege_String += set_String + ", ";

            get_Admin_Privilege_String = get_Admin_Privilege_String.Trim();
            get_Admin_Privilege_String = get_Admin_Privilege_String.TrimEnd(',');

            foreach (String set_String in MythicalCafe_BackEnd_Main_Method.Staff_Position_Dictionary["Staff"])
                get_Staff_Privilege_String += set_String + ", ";

            get_Staff_Privilege_String = get_Staff_Privilege_String.Trim();
            get_Staff_Privilege_String = get_Staff_Privilege_String.TrimEnd(',');            

            if (Position == "Super Admin")
                get_Super_Admin_Privilege_String = get_String;

            else if (Position == "Admin")
                get_Admin_Privilege_String = get_String;

            else if (Position == "Staff")
                get_Staff_Privilege_String = get_String;

            MythicalCafe_BackEnd_Main_Method.update_System_Configuration
            (
                "Update : Specific : Staff_Privilege", 
                get_Super_Admin_Privilege_String + "*" + get_Admin_Privilege_String + "*" + get_Staff_Privilege_String
            );
        }

        Boolean Boolean = false;

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (!Boolean)
            {
                pnl_Main.SetCellPosition(pnl_Workstation, new TableLayoutPanelCellPosition(3, 0));
                pnl_Main.SetCellPosition(pnl_Product, new TableLayoutPanelCellPosition(3, 1));

                pnl_Main.SetCellPosition(pnl_Account, new TableLayoutPanelCellPosition(4, 0));

                pnl_Main.SetCellPosition(pnl_Setting, new TableLayoutPanelCellPosition(0, 0));

                Boolean = true;
            }

            else
            {
                pnl_Main.SetCellPosition(pnl_Setting, new TableLayoutPanelCellPosition(2, 0));

                pnl_Main.SetCellPosition(pnl_Workstation, new TableLayoutPanelCellPosition(0, 0));
                pnl_Main.SetCellPosition(pnl_Product, new TableLayoutPanelCellPosition(0, 1));
                pnl_Main.SetCellPosition(pnl_Account, new TableLayoutPanelCellPosition(1, 0));

                Boolean = false;
            }
        }

        String Position = null;

        private void dgv_Position_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Position.Rows[e.RowIndex];

            //Staff_Privilege.Clear();

            if (get_DataGridViewRow.Cells["Staff_Position"].Value.ToString() == "Super Admin")
            {
                Position = "Super Admin";                

                Staff_Privilege = MythicalCafe_BackEnd_Main_Method.Super_Admin_Privilege_List;
                
                set_CheckBox_Value();
            }

            else if (get_DataGridViewRow.Cells["Staff_Position"].Value.ToString() == "Admin")
            {
                Position = "Admin";               

                Staff_Privilege = MythicalCafe_BackEnd_Main_Method.Admin_Privilege_List;
                
                set_CheckBox_Value();
            }

            else if (get_DataGridViewRow.Cells["Staff_Position"].Value.ToString() == "Staff")
            {
                Position = "Staff";                

                Staff_Privilege = MythicalCafe_BackEnd_Main_Method.Staff_Privilege_List;
                
                set_CheckBox_Value();
            }

            else
                return;
        }

        List<String> Staff_Privilege = new List<String>();

        void set_CheckBox_Value()
        {            
            //Workstation
            chkbx_Workstation_Manage.Checked = true;
            chkbx_Workstation_Maintenance.Checked = true;
            chkbx_Workstation_Log.Checked = true;

            chkbx_Workstation_Manage.Checked = false;
            chkbx_Workstation_Maintenance.Checked = false;
            chkbx_Workstation_Log.Checked = false;

            //Product
            chkbx_Product_Manage.Checked = true;
            chkbx_Product_Order_Queue.Checked = true;
            chkbx_Product_Category.Checked = true;
            chkbx_Product_Log.Checked = true;

            chkbx_Product_Manage.Checked = false;
            chkbx_Product_Order_Queue.Checked = false;
            chkbx_Product_Category.Checked = false; 
            chkbx_Product_Log.Checked = false;

            //Account
            chkbx_Account_Manage_Super_Admin.Checked = true;
            chkbx_Account_Manage_Admin.Checked = true;
            chkbx_Account_Manage_Staff.Checked = true;
            chkbx_Account_Position.Checked = true;
            chkbx_Account_Log.Checked = true;
            chkbx_Account_Statistics.Checked = true;

            chkbx_Account_Manage_Super_Admin.Checked = false;
            chkbx_Account_Manage_Admin.Checked = false;
            chkbx_Account_Manage_Staff.Checked = false;
            chkbx_Account_Position.Checked = false;
            chkbx_Account_Log.Checked = false;
            chkbx_Account_Statistics.Checked = false;

            //Setting
            chkbx_Setting_Manage.Checked = true;
            chkbx_Setting_Screen_Resolution.Checked = true;
            chkbx_Serial_Connection_Manage.Checked = true;
            chkbx_Setting_Computer_Rate.Checked = true;
            chkbx_Setting_Manage_Time_Warning.Checked = true;

            chkbx_Setting_Manage.Checked = false;
            chkbx_Setting_Screen_Resolution.Checked = false;
            chkbx_Serial_Connection_Manage.Checked = false;
            chkbx_Setting_Computer_Rate.Checked = false;
            chkbx_Setting_Manage_Time_Warning.Checked = false;

            foreach (String set_String in Staff_Privilege)
            {                
                ExtendedCheckBox get_ExtendedCheckBox = Controls.Find("chkbx_" + set_String, true).FirstOrDefault() as ExtendedCheckBox;

                if (!ReferenceEquals(get_ExtendedCheckBox, null))
                    get_ExtendedCheckBox.Checked = true;
            }

            //Workstation
            set_Panel_CheckBox_Value(pnl_Workstation_Manage, chkbx_Workstation_Manage);
            set_Panel_CheckBox_Value(pnl_Workstation_Log, chkbx_Workstation_Log);

            //Product
            set_Panel_CheckBox_Value(pnl_Product_Manage, chkbx_Product_Manage);
            set_Panel_CheckBox_Value(pnl_Product_Order_Queue, chkbx_Product_Order_Queue);
            set_Panel_CheckBox_Value(pnl_Product_Category, chkbx_Product_Category);
            set_Panel_CheckBox_Value(pnl_Product_Log, chkbx_Product_Log);

            //Account
            set_Panel_CheckBox_Value(pnl_Account_Manage_Super_Admin, chkbx_Account_Manage_Super_Admin);
            set_Panel_CheckBox_Value(pnl_Account_Manage_Admin, chkbx_Account_Manage_Admin);
            set_Panel_CheckBox_Value(pnl_Account_Manage_Staff, chkbx_Account_Manage_Staff);
            set_Panel_CheckBox_Value(pnl_Account_Log, chkbx_Account_Log);

            if (chkbx_Account_Manage_Super_Admin.Checked == true && chkbx_Account_Manage_Admin.Checked == true && chkbx_Account_Manage_Staff.Checked == true)
                chkbx_Account_Manage.Checked = true;

            else
                chkbx_Account_Manage.Checked = false;

            //Setting
            set_Panel_CheckBox_Value(pnl_Serial_Connection_Manage, chkbx_Serial_Connection_Manage);
            set_Panel_CheckBox_Value(pnl_Setting_Manage_Time_Warning, chkbx_Setting_Manage_Time_Warning);

            if (chkbx_Setting_Screen_Resolution.Checked == true && chkbx_Serial_Connection_Manage.Checked == true && chkbx_Setting_Computer_Rate.Checked == true && chkbx_Setting_Manage_Time_Warning.Checked == true)
                chkbx_Setting_Manage.Checked = true;

            else
                chkbx_Setting_Manage.Checked = false;
        }

        void set_Panel_CheckBox_Value(TableLayoutPanel set_TableLayoutPanel, Boolean set_Boolean)
        {
            foreach (ExtendedCheckBox set_ExtendedCheckBox in set_TableLayoutPanel.Controls)
                set_ExtendedCheckBox.Checked = set_Boolean;            
        }

        void set_Panel_CheckBox_Value(TableLayoutPanel set_TableLayoutPanel, ExtendedCheckBox set_ExtendedCheckBox_1)
        {
            Boolean get_Boolean = true;

            foreach (ExtendedCheckBox set_ExtendedCheckBox_2 in set_TableLayoutPanel.Controls)            
                if (!set_ExtendedCheckBox_2.Checked)
                    get_Boolean = false;            

            if (get_Boolean)
                set_ExtendedCheckBox_1.Checked = true;
        }

        void get_Panel_CheckBox_Value(TableLayoutPanel set_TableLayoutPanel)
        {
            foreach (Control set_Control in set_TableLayoutPanel.Controls)
            {
                if (set_Control is ExtendedCheckBox)
                {
                    ExtendedCheckBox get_ExtendedCheckBox = (ExtendedCheckBox)set_Control;

                    if (get_ExtendedCheckBox.Checked)
                        Staff_Privilege.Add(get_ExtendedCheckBox.Name.Remove(0, 6));                    
                }                
            }                
        }

        private void CheckBox_CheckedChanged(Object set_Object, EventArgs set_EventArgs)
        {
            ExtendedCheckBox get_ExtendedCheckBox = (ExtendedCheckBox)set_Object;

            //Workstation
            if (get_ExtendedCheckBox.Name == chkbx_Workstation_Manage.Name)
                set_Panel_CheckBox_Value(pnl_Workstation_Manage, get_ExtendedCheckBox.Checked);

            else if (get_ExtendedCheckBox.Name == chkbx_Workstation_Log.Name)
                set_Panel_CheckBox_Value(pnl_Workstation_Log, get_ExtendedCheckBox.Checked);

            //Product
            else if (get_ExtendedCheckBox.Name == chkbx_Product_Manage.Name)
                set_Panel_CheckBox_Value(pnl_Product_Manage, get_ExtendedCheckBox.Checked);
            
            else if (get_ExtendedCheckBox.Name == chkbx_Product_Order_Queue.Name)
                set_Panel_CheckBox_Value(pnl_Product_Order_Queue, get_ExtendedCheckBox.Checked);

            else if (get_ExtendedCheckBox.Name == chkbx_Product_Category.Name)
                set_Panel_CheckBox_Value(pnl_Product_Category, get_ExtendedCheckBox.Checked);

            else if (get_ExtendedCheckBox.Name == chkbx_Product_Log.Name)
                set_Panel_CheckBox_Value(pnl_Product_Log, get_ExtendedCheckBox.Checked);

            //Account

            else if (get_ExtendedCheckBox.Name == chkbx_Account_Manage.Name)
            {
                chkbx_Account_Manage_Super_Admin.Checked = get_ExtendedCheckBox.Checked;
                chkbx_Account_Manage_Admin.Checked = get_ExtendedCheckBox.Checked;
                chkbx_Account_Manage_Staff.Checked = get_ExtendedCheckBox.Checked;
            }

            else if (get_ExtendedCheckBox.Name == chkbx_Account_Manage_Super_Admin.Name)
                set_Panel_CheckBox_Value(pnl_Account_Manage_Super_Admin, get_ExtendedCheckBox.Checked);

            else if (get_ExtendedCheckBox.Name == chkbx_Account_Manage_Admin.Name)
                set_Panel_CheckBox_Value(pnl_Account_Manage_Admin, get_ExtendedCheckBox.Checked);

            else if (get_ExtendedCheckBox.Name == chkbx_Account_Manage_Staff.Name)
                set_Panel_CheckBox_Value(pnl_Account_Manage_Staff, get_ExtendedCheckBox.Checked);

            else if (get_ExtendedCheckBox.Name == chkbx_Account_Log.Name)
                set_Panel_CheckBox_Value(pnl_Account_Log, get_ExtendedCheckBox.Checked);

            //Setting

            else if (get_ExtendedCheckBox.Name == chkbx_Setting_Manage.Name)
            {
                chkbx_Setting_Screen_Resolution.Checked = get_ExtendedCheckBox.Checked;
                chkbx_Serial_Connection_Manage.Checked = get_ExtendedCheckBox.Checked;
                chkbx_Setting_Computer_Rate.Checked = get_ExtendedCheckBox.Checked;
                chkbx_Setting_Manage_Time_Warning.Checked = get_ExtendedCheckBox.Checked;
            }
            
            else if (get_ExtendedCheckBox.Name == chkbx_Serial_Connection_Manage.Name)
                set_Panel_CheckBox_Value(pnl_Serial_Connection_Manage, get_ExtendedCheckBox.Checked);

            else if (get_ExtendedCheckBox.Name == chkbx_Setting_Manage_Time_Warning.Name)
                set_Panel_CheckBox_Value(pnl_Setting_Manage_Time_Warning, get_ExtendedCheckBox.Checked);
        }

        /*
            Workstation_View
            Workstation_Insert
            Workstation_Update
            Workstation_Delete

            Workstation_Maintenance
            Workstation_Log_View
            Workstation_Log_Print

            Product_View
            Product_Insert
            Product_Update
            Product_Delete

            Product_Order_Queue_View
            Product_Order_Queue_Accept
            Product_Order_Queue_Decline

            Product_Category_View
            Product_Category_Insert
            Product_Category_Update
            Product_Category_Delete

            Product_Log_View
            Product_Log_Print

            Account_Super_Admin_View
            Account_Super_Admin_Insert
            Account_Super_Admin_Update
            Account_Super_Admin_Delete

            Account_Admin_View
            Account_Admin_Insert
            Account_Admin_Update
            Account_Admin_Delete

            Account_Staff_View
            Account_Staff_Insert
            Account_Staff_Update
            Account_Staff_Delete

            Account_Position

            Account_Log_View
            Account_Log_Print

            Account_Statistics

            Setting_Screen_Resolution

            Setting_RadioFrequency_Port
            Setting_RadioFrequency_Status

            Setting_ShortMessageService_Port
            Setting_ShortMessageService_Status

            Setting_Computer_Rate

            Setting_Time_Warning_View
            Setting_Time_Warning_Insert
            Setting_Time_Warning_Update
            Setting_Time_Warning_Delete 
        */
    }
}
