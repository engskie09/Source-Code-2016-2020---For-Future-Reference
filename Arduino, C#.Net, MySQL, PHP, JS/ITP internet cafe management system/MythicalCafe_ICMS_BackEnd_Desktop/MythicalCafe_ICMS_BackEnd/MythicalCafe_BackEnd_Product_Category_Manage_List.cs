using Bunifu.Framework.UI;
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
    public partial class MythicalCafe_BackEnd_Product_Category_Manage_List : Form
    {
        public MythicalCafe_BackEnd_Product_Category_Manage_List(String set_Action)
        {
            InitializeComponent();

            get_Action(set_Action);
        }

        private void MythicalCafe_BackEnd_Product_Category_Manage_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Product_Search, txtbx_Product_Search.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Category_Name, txtbx_Category_Name.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Category_Description, txtbx_Category_Description.Text);

            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);

            cmbx_Search_Filter.SelectedIndex = 0;

            pnl_Category_Identity.BorderColoreFocused = Color.White;
            pnl_Category_Identity.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            set_dgv_Category();
        }

        void set_dgv_Category()
        {
            MythicalCafe_BackEnd_Product_Category_Manage_List_Method.select_Category_Information("Select : All", "");

            dgv_Category.DataSource = null;

            dgv_Category.AutoGenerateColumns = false;

            dgv_Category.Columns["Category_Identity"].DataPropertyName = "Category_Identity";
            dgv_Category.Columns["Category_Name"].DataPropertyName = "Category_Name";
            dgv_Category.Columns["Category_Description"].DataPropertyName = "Category_Description";

            dgv_Category.DataSource = MythicalCafe_BackEnd_Product_Category_Manage_List_Method.Category_DataTable_1;
        }        

        public void get_Action(String set_Action)
        {
            if (set_Action == "Display Category" || set_Action == "Delete Category" || set_Action == "Update Category" || set_Action == "Select Category")
            {
                pnl_Category_Main.SetCellPosition(dgv_Category, new TableLayoutPanelCellPosition(0, 1));
                pnl_Category_Main.SetCellPosition(pnl_Category_Information, new TableLayoutPanelCellPosition(0, 2));

                btn_Action.Text = set_Action;

                btn_Action.Text = set_Action;

                Size = new Size(870, 470);
            }

            else if (set_Action == "Insert Category")
            {
                pnl_Category_Main.SetCellPosition(pnl_Category_Search, new TableLayoutPanelCellPosition(0, 3));
                pnl_Category_Main.SetCellPosition(pnl_Category_Information, new TableLayoutPanelCellPosition(0, 0));
                pnl_Category_Main.SetCellPosition(dgv_Category, new TableLayoutPanelCellPosition(0, 2));                

                pnl_Category_Main.SetRowSpan(pnl_Category_Information, 2);

                btn_Action.Text = set_Action;

                lbl_Category_Identity.Text = MythicalCafe_BackEnd_Main_Method.Product_Category_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Product_Category_Identity_Code) + 1000).ToString();

                Size = new Size(380, 300);
                
            }

            else
                return;
        }

        String[] Category_Information_Array = new string[0];
        void get_Category_Information_Value()
        {
            if (btn_Action.Text == "Insert Category")
            {
                Category_Information_Array = new String[4];

                Category_Information_Array[1] = lbl_Category_Identity.Text.Trim();
                Category_Information_Array[2] = txtbx_Category_Name.Text.Trim();
                Category_Information_Array[3] = txtbx_Category_Description.Text.Trim();
            }

            else if (btn_Action.Text == "Update Category")
            {
                Category_Information_Array = new String[5];

                Category_Information_Array[1] = "Update : Specific";
                Category_Information_Array[2] = lbl_Category_Identity.Text.Trim();
                Category_Information_Array[3] = txtbx_Category_Name.Text.Trim();
                Category_Information_Array[4] = txtbx_Category_Description.Text.Trim();


            }

            else if (btn_Action.Text == "Delete Category")
            {
                Category_Information_Array = new String[2];
                Category_Information_Array[1] = lbl_Category_Identity.Text.Trim();
            }

            else
                return;
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            get_Category_Information_Value();

            if (btn_Action.Text == "Insert Category")
            {
                MythicalCafe_BackEnd_Product_Category_Manage_List_Method.insert_Product_Category_Information
                (
                    Category_Information_Array[1],
                    Category_Information_Array[2],
                    Category_Information_Array[3]
                );

                MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Product_Category_Identity_Code);

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Inserted Category *" + Category_Information_Array[1] + "*"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Category_Information_Array[1],
                    "Category has inserted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                );
            }

            else if (btn_Action.Text == "Update Category")
            {
                MythicalCafe_BackEnd_Product_Category_Manage_List_Method.update_Product_Category_Information
                (
                    Category_Information_Array[1],
                    Category_Information_Array[2],
                    Category_Information_Array[3],
                    Category_Information_Array[4]
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Updated Category *" + Category_Information_Array[2] + "*"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Category_Information_Array[2],
                    "Category has updated by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                );
            }

            else if (btn_Action.Text == "Delete Category")
            {
                MythicalCafe_BackEnd_Product_Category_Manage_List_Method.delete_Product_Category_Information
                (
                    Category_Information_Array[1]
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Deleted Category *" + Category_Information_Array[1] + "*"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Category_Information_Array[1],
                    "Category has deleted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                );

            }

            else
                return;

            set_dgv_Category();

            DialogResult = DialogResult.OK;

            Close();
        }

        private void txtbx_Product_Search_OnValueChanged(object sender, EventArgs e)
        {
            BunifuMetroTextbox get_TextBox = (BunifuMetroTextbox)sender;

            String get_TextBox_Value = get_TextBox.Text.Trim();

            get_TextBox.Text = get_TextBox_Value;

            String get_RowFilter = null;

            if (get_TextBox_Value == "Search Category")
            {
                get_RowFilter = "Category_Identity LIKE '%{0}%' OR Category_Name LIKE '%{0}%' OR Category_Description LIKE '%{0}%'";
                get_TextBox_Value = "";
            }
            else if (cmbx_Search_Filter.Text == "All")
                get_RowFilter = "Category_Identity LIKE '%{0}%' OR Category_Name LIKE '%{0}%' OR Category_Description LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "ID")
                get_RowFilter = "Category_Identity LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Name")
                get_RowFilter = "Category_Name LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Description")
                get_RowFilter = "Category_Description LIKE '%{0}%'";


            (dgv_Category.DataSource as DataTable).DefaultView.RowFilter = string.Format(get_RowFilter, get_TextBox_Value);
        }

        JObject Category_Information = null;

        public String Category_Identity_String = null;
        public String Category_Name_String = null;
        private void dgv_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0))
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Category.Rows[e.RowIndex];

            if (btn_Action.Text == "Update Category" || btn_Action.Text == "Delete Category")
            {
                Category_Information = JObject.Parse(MythicalCafe_BackEnd_Product_Category_Manage_List_Method.select_Category_Information("Select : Specific", get_DataGridViewRow.Cells[0].Value.ToString()));
                Category_Information = JObject.Parse(Category_Information["Table"].ToString().TrimStart('[').TrimEnd(']'));

                pnl_Category_Main.SetCellPosition(pnl_Category_Search, new TableLayoutPanelCellPosition(0, 3));
                pnl_Category_Main.SetCellPosition(pnl_Category_Information, new TableLayoutPanelCellPosition(0, 0));
                pnl_Category_Main.SetCellPosition(dgv_Category, new TableLayoutPanelCellPosition(0, 2));

                lbl_Category_Identity.Text = Category_Information["Category_Identity"].ToString();
                txtbx_Category_Name.Text = Category_Information["Category_Name"].ToString();
                txtbx_Category_Description.Text = Category_Information["Category_Description"].ToString();

                pnl_Category_Main.SetRowSpan(pnl_Category_Information, 2);

                Size = new Size(380, 300);

                CenterToScreen();
            }

            else if (btn_Action.Text == "Select Category")
            {
                Category_Identity_String = get_DataGridViewRow.Cells[0].Value.ToString();
                Category_Name_String = get_DataGridViewRow.Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;

                Close();
            }

            else
                return;
        }
    }
}
