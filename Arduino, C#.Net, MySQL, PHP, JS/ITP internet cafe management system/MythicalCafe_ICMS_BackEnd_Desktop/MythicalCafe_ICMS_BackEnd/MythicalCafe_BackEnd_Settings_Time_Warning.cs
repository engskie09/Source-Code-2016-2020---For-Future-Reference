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
    public partial class MythicalCafe_BackEnd_Settings_Time_Warning : Form
    {
        public MythicalCafe_BackEnd_Settings_Time_Warning()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Settings_Time_Warning_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Message, txtbx_Message.Text.Trim());

            List<String> get_Time_Warning_List = get_Time_Warning_List = MythicalCafe_BackEnd_Main_Method.Time_Warning.Split( new[] { "*,*" }, StringSplitOptions.None).ToList();

            get_Time_Warning_List.RemoveAt(get_Time_Warning_List.Count -1);

            Counter = 0;

            foreach (String set_String in get_Time_Warning_List)
            {
                String [] get_String = set_String.Split('=');

                dgv_Time_Warning.Rows.Add(Counter.ToString(), TimeSpan.FromSeconds(Convert.ToDouble(get_String[0])).ToString(), get_String[1]);

                Counter ++;
            }
        }

        Int32 Counter = 0;

        public String Time_Warning_List = null;

        public String Time_Warning
        {
            get{ return lbl_Time_Warning.Text.Remove(0, 6); }

            set{ lbl_Time_Warning.Text = "Time: " + value; }
        }

        Int32 dgv_Time_Warning_RowIndex = 0;

        private void dgv_Time_Warning_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0))
                return;           

            DataGridViewRow get_DataGridViewRow = dgv_Time_Warning.Rows[e.RowIndex];

            dgv_Time_Warning_RowIndex = e.RowIndex;

            Time_Warning = TimeSpan.Parse(get_DataGridViewRow.Cells[1].Value.ToString()).ToString();
            txtbx_Message.Text = get_DataGridViewRow.Cells[2].Value.ToString();
        }

        private void lbl_Time_Warning_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom get_UserControl_Workstation_Time_Bonus_And_Custom = new MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom(null, null);
            get_UserControl_Workstation_Time_Bonus_And_Custom.get_Action("Time Warning");

            get_UserControl_Workstation_Time_Bonus_And_Custom.ShowDialog();

            Time_Warning = get_UserControl_Workstation_Time_Bonus_And_Custom.TimeSpan_String;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {            
            if (TimeSpan.TryParse(Time_Warning, out _))
                if (TimeSpan.Parse(Time_Warning).TotalSeconds > 0 && !String.IsNullOrEmpty(txtbx_Message.Text.Trim()))
                    dgv_Time_Warning.Rows.Add(Counter.ToString(), TimeSpan.Parse(Time_Warning).ToString(), txtbx_Message.Text.Trim());

            set_Control_Property();

            dgv_Time_Warning.Sort(dgv_Time_Warning.Columns[1], ListSortDirection.Ascending);

            Counter++;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Time_Warning_RowIndex >= 0)
            {
                DataGridViewRow get_DataGridViewRow = dgv_Time_Warning.Rows[dgv_Time_Warning_RowIndex];

                get_DataGridViewRow.Cells[1].Value = Time_Warning;
                get_DataGridViewRow.Cells[2].Value = txtbx_Message.Text.Trim();
            }

            set_Control_Property();
                
            dgv_Time_Warning.Sort(dgv_Time_Warning.Columns[1], ListSortDirection.Ascending);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Time_Warning_RowIndex >= 0)
                dgv_Time_Warning.Rows.RemoveAt(dgv_Time_Warning_RowIndex);

            set_Control_Property();

            dgv_Time_Warning.Sort(dgv_Time_Warning.Columns[1], ListSortDirection.Ascending);
        }

        void set_Control_Property()
        {
            Time_Warning = "00:00:00";

            txtbx_Message.Text = "Message";

            ActiveControl = null;

            dgv_Time_Warning_RowIndex = -1;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {            

            foreach (DataGridViewRow set_DataGridViewRow in dgv_Time_Warning.Rows)
            {
                Time_Warning_List += TimeSpan.Parse(set_DataGridViewRow.Cells[1].Value.ToString()).TotalSeconds + "=" + set_DataGridViewRow.Cells[2].Value.ToString() + "*,*";
            }
            
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
