using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Account_Staff_List : Form
    {
        public MythicalCafe_BackEnd_Account_Staff_List()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Account_Staff_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Staff_Search, txtbx_Staff_Search.Text);

            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);            


            set_dgv_Account_Value();
        }

        public String Action = null;
        public String Position = null;

        public void set_dgv_Account_Value()
        {
            if (Action == "Generate Payroll")
                MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information("Select : All", "", "", "", "");

            else
                MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information("Select : All : Specific { Staff_Position }", "", "", "", Position);


            dgv_Account.DataSource = null;

            dgv_Account.AutoGenerateColumns = false;

            dgv_Account.Columns["Staff_Identity"].DataPropertyName = "Staff_Identity";
            dgv_Account.Columns["Staff_FullName"].DataPropertyName = "Staff_FullName";
            dgv_Account.Columns["Staff_Position"].DataPropertyName = "Staff_Position";

            dgv_Account.DataSource = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.Account_DataTable_1;
        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Account.Rows[e.RowIndex];

            if (Action == "Display Account")
                return;

            if (Action == "Update Account")
            {
                JObject get_Staff_Information = JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information("Select : Specific", get_DataGridViewRow.Cells["Staff_Identity"].Value.ToString(), "", "", ""))["Table"].ToString().TrimStart('[').TrimEnd(']'));

                MythicalCafe_BackEnd_Account_Staff_Manage_List get_Account_Staff_Manage_List = new MythicalCafe_BackEnd_Account_Staff_Manage_List() { Staff_Information = get_Staff_Information };

                get_Account_Staff_Manage_List.Position = Position;
                get_Account_Staff_Manage_List.get_Action(Action);

                if (get_Account_Staff_Manage_List.ShowDialog() == DialogResult.OK)
                    set_dgv_Account_Value();
            }

            else if (Action == "Delete Account")
            {
                MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Are You sure ?");

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.delete_Staff_Information(get_DataGridViewRow.Cells["Staff_Identity"].Value.ToString());

                    set_dgv_Account_Value();
                }

            }

            else if (Action == "Generate Payroll")            
                new MythicalCafe_BackEnd_Account_Staff_Manage_Payroll() { Staff_Identity = get_DataGridViewRow.Cells["Staff_Identity"].Value.ToString() }.ShowDialog();
            
        }
    }
}
