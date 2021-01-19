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
    public partial class MythicalCafe_BackEnd_Workstation_Manage_List_Dialog : Form
    {
        public MythicalCafe_BackEnd_Workstation_Manage_List_Dialog()
        {
            InitializeComponent();            
        }

        private void MythicalCafe_BackEnd_Workstation_Manage_List_Dialog_Load(object sender, EventArgs e)
        {
            KeyDown += delegate(Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            //MythicalCafe_Control_Propety.get_Form_Effect_Fade("Emphasize", Application.OpenForms[new MythicalCafe_BackEnd_Main().Name]);
        }

        private void MythicalCafe_BackEnd_Workstation_Manage_List_Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MythicalCafe_Control_Propety.get_Timer.Stop();
        }

        /* Custom Method */

        Color get_Color1 = MythicalCafe_Control_Propety.get_ThemeCurrentColor3;  /* 168, 130, 193 */
        Color get_Color2 = MythicalCafe_Control_Propety.get_ThemeCurrentColor6;  /* 193, 130, 155 */

        private void set_Control_Color()
        {
            /*get_Color1 = Color.White;
            get_Color2 = Color.White;*/

            BackColor = get_Color2;

            btn_Insert.BackColor = get_Color1;
            btn_Update.BackColor = get_Color1;
            btn_Delete.BackColor = get_Color1;            
        }
        

        /* Auto Generated Method */

        MythicalCafe_BackEnd_Workstation_Manage_List MythicalCafe_BackEnd_Workstation_Manage_List = new MythicalCafe_BackEnd_Workstation_Manage_List(null);

        private void btn_Insert_Click(object sender, EventArgs e)
        {            
            Close();

            MythicalCafe_BackEnd_Workstation_Manage_List.btn_Action.Text = "Insert Workstation";
            MythicalCafe_BackEnd_Workstation_Manage_List.ShowDialog();
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Close();

            MythicalCafe_BackEnd_Workstation_Manage_List.btn_Action.Text = "Update Workstation";
            MythicalCafe_BackEnd_Workstation_Manage_List.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Close();

            MythicalCafe_BackEnd_Workstation_Manage_List.btn_Action.Text = "Delete Workstation";
            MythicalCafe_BackEnd_Workstation_Manage_List.ShowDialog();
        }
    }
}
