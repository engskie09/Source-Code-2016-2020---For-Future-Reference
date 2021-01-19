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
    public partial class MythicalCafe_BackEnd_Dialog : Form
    {
        public MythicalCafe_BackEnd_Dialog(String set_Action)
        {
            InitializeComponent();

            if (!String.IsNullOrEmpty(set_Action))
                get_Action(set_Action);
        }

        private void MythicalCafe_BackEnd_Dialog_Load(object sender, EventArgs e)
        {
            KeyDown += delegate(Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 0.5;

            //MythicalCafe_Control_Propety.get_Form_Effect_Fade("Emphasize", Application.OpenForms[new MythicalCafe_BackEnd_Main().Name]);           
        }

        private void MythicalCafe_BackEnd_Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MythicalCafe_Control_Propety.get_Timer.Stop();

            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 1;
        }

        /* Custom Method */

        Color get_Color1 = MythicalCafe_Control_Propety.get_ThemeCurrentColor3;  /* 168, 130, 193 */
        Color get_Color2 = MythicalCafe_Control_Propety.get_ThemeCurrentColor6;  /* 193, 130, 155 */

        private void set_Control_Color()
        {
            /*get_Color1 = Color.White;
            get_Color2 = Color.White;*/

            BackColor = get_Color2;

            btn_Ok.BackColor = get_Color1;
            btn_No.BackColor = get_Color1;    
            
        }

        public String Action_Value = null;

        public void get_Action(String set_Action)
        {
            if (set_Action.Contains("Input"))
            {
                set_Action = set_Action.Remove(0, 7);

                pnl_Dialog.SetRow(txt_Action, 0);
                pnl_Dialog.SetRow(lbl_Action, 2);

                if (set_Action.Contains("Cash Remaining"))
                    txt_Action.Text = "Input " + set_Action;

                else if (set_Action.Contains("Debt Maximum"))
                    txt_Action.Text = "Input " + set_Action;

                else
                    txt_Action.Text = set_Action;

                MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_Action, txt_Action.Text.Trim());

            }

            else if (set_Action.Contains("Choice"))
            {
                set_Action = set_Action.Remove(0, 8);

                pnl_Dialog.SetRow(lbl_Action, 0);
                pnl_Dialog.SetRow(txt_Action, 2);

                lbl_Action.Text = set_Action;
            }

            else if (set_Action.Contains("Message"))
            {
                set_Action = set_Action.Remove(0, 9);

                pnl_Dialog.SetRow(lbl_Action, 0);
                pnl_Dialog.SetRow(txt_Action, 2);

                lbl_Action.Text = set_Action;

                Controls.Remove(btn_No);

                pnl_Dialog.SetColumnSpan(btn_Ok, 2);
            }

            else
                lbl_Action.Text = set_Action;

        }

        /* Auto Generated Method */

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Action_Value = txt_Action.Text;

            Close();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;

            Close();
        }

        
    }
}
