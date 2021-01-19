using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using Bunifu.Framework.UI;
using System.ComponentModel;

namespace MythicalCafe_ICMS_FrontEnd
{
    public static class MythicalCafe_Control_Propety
    {
        /*Color Theme*/

        /* Color Theme 1 : Summer Blueberries */

        public static readonly Color get_Theme1Color1 = Color.FromArgb(213, 11, 83);     /* #D50B53 */
        public static readonly Color get_Theme1Color2 = Color.FromArgb(244, 243, 244);   /* #F4F3F4 */
        public static readonly Color get_Theme1Color3 = Color.FromArgb(168, 130, 193);   /* #A882C1 */
        public static readonly Color get_Theme1Color4 = Color.FromArgb(130, 76, 167);    /* #824CA7 */
        public static readonly Color get_Theme1Color5 = Color.FromArgb(185, 196, 6);     /* #B9C406 */

        /* #A882C1 Tetradic Colors */

        public static readonly Color get_Theme1Color3Tetradic1 = Color.FromArgb(193, 180, 130);   /* #C1B482 */
        public static readonly Color get_Theme1Color3Tetradic2 = Color.FromArgb(155, 193, 130);   /* #9BC182 */
        public static readonly Color get_Theme1Color3Tetradic3 = Color.FromArgb(193, 130, 155);   /* #C1829B */

        /* Color Theme Current*/
        public static Color get_ThemeCurrentColor1 = get_Theme1Color1;
        public static Color get_ThemeCurrentColor2 = get_Theme1Color2;
        public static Color get_ThemeCurrentColor3 = get_Theme1Color3;
        public static Color get_ThemeCurrentColor4 = get_Theme1Color4;
        public static Color get_ThemeCurrentColor5 = get_Theme1Color5;
        public static Color get_ThemeCurrentColor6 = get_Theme1Color3Tetradic3;

        /*
                                                        _____   ______   _______                                              
                                                       / ____| |  ____| |__   __|                                             
          ______   ______   ______   ______   ______  | |  __  | |__       | |     ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______| | | |_ | |  __|      | |    |______| |______| |______| |______| |______|
                                                      | |__| | | |____     | |                                                
                                                       \_____| |______|    |_|                                                
                                                                                                                      
                                                                                                                      
        */

        //Acccept Letter, Uppercase as First Character and no White Space as First Character.
        public static void get_TextBox_KeyPress_Letter(String gettxtString, object sender, KeyPressEventArgs e)
        {
            if (gettxtString == String.Empty)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
            }

        }

        //Accept only Numbers.
        public static void get_TextBox_KeyPress_Number(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Accept only Letter and Number, but no White Space as FIrst Character.
        public static void get_TextBox_KeyPress_Number_And_Letter(String get_String, object sender, KeyPressEventArgs e)
        {
            if (get_String == String.Empty)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar));
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar));
            }

        }

        public static void get_TextBox_KeyDown_Length_Maximum(String get_String, Int32 set_Length_Maximum, Object set_Object, KeyEventArgs set_KeyEventArgs)
        {
            if (set_KeyEventArgs.KeyCode == Keys.Back)            
                set_KeyEventArgs.SuppressKeyPress = false;            

            else if (get_String.Length >= set_Length_Maximum)
                set_KeyEventArgs.SuppressKeyPress = true;
        }

        public static void set_TextBox_KeyPress_Number(BunifuMetroTextbox set_BunifuMetroTextbox)
        {
            set_BunifuMetroTextbox.KeyPress += new KeyPressEventHandler(get_TextBox_KeyPress_Number);
        }

        public static void set_TextBox_KeyDown_Length_Maximum(BunifuMetroTextbox set_BunifuMetroTextbox, Int32 set_Length_Maximum)
        {
            set_BunifuMetroTextbox.KeyDown += delegate(Object set_Object, KeyEventArgs set_KeyEventArgs)
            {
                get_TextBox_KeyDown_Length_Maximum(set_BunifuMetroTextbox.Text, set_Length_Maximum,set_Object, set_KeyEventArgs);
            };
        }

        /* Move Form by Dragging Control */

        static Int32 get_move = new Int32();
        static Int32 get_moveX = new Int32();
        static Int32 get_moveY = new Int32();

        static void get_DragMouseDown(Object set_Object, MouseEventArgs set_Event)
        {
            get_move = 1;
            get_moveX = set_Event.X;
            get_moveY = set_Event.Y;
        }

        static void get_DragMouseMove(Object set_Object, MouseEventArgs set_Event, Form set_Form)
        {
            if (get_move == 1)
                set_Form.SetDesktopLocation(Control.MousePosition.X - get_moveX, Control.MousePosition.Y - get_moveY);
        }

        static void get_DragMouseUp(Object set_Object, MouseEventArgs set_Event)
        {
            get_move = 0;
        }

        /* Add Placeholder Effect to TextBox */

        static void get_TextBox_Enter_Placeholder(Object set_Object, EventArgs set_Event, String set_Placeholder)
        {
            BunifuMetroTextbox get_TextBox = (BunifuMetroTextbox)set_Object;

            if (get_TextBox.Text.Contains(set_Placeholder))
            {
                get_TextBox.ResetText();
            }
        }

        static void get_TextBox_Leave_Placeholder(Object set_Object, EventArgs set_Event, String set_Placeholder)
        {
            BunifuMetroTextbox get_TextBox = (BunifuMetroTextbox)set_Object;

            if (String.IsNullOrEmpty(get_TextBox.Text.Trim()))
            {
                get_TextBox.Text = set_Placeholder;
            }
        }

        /* Add Fade Effect to Form */

        public static System.Windows.Forms.Timer get_Timer = new System.Windows.Forms.Timer();

        public static void get_Form_Effect_Fade(String set_Action, Form set_Form)
        {
            Form get_Form = (Form)set_Form;

            get_Timer.Tick += delegate (Object set_Object, EventArgs set_EventArgs)
            {
                set_Form_Effect_Fade(set_Action, set_Form, set_Object, set_EventArgs);
            };

            get_Timer.Start();
        }

        /*
                                                        _____   ______   _______                                              
                                                       / ____| |  ____| |__   __|                                             
          ______   ______   ______   ______   ______  | (___   | |__       | |     ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______|  \___ \  |  __|      | |    |______| |______| |______| |______| |______|
                                                       ____) | | |____     | |                                                
                                                      |_____/  |______|    |_|                                                
                                                                                                                      
                                                                                                                      
        */

        /* Call the Method */

        /* get_DragMouseDown(), get_DragMouseMove(), get_DragMouseUp() */

        public static void set_Panel_Draggable(BunifuGradientPanel set_BunifuGradientPanel, Form set_Form)
        {
            set_BunifuGradientPanel.MouseDown += new MouseEventHandler(get_DragMouseDown);

            set_BunifuGradientPanel.MouseMove += delegate (Object set_Object, MouseEventArgs set_Event)
            {
                get_DragMouseMove(set_Object, set_Event, set_Form);
            };

            set_BunifuGradientPanel.MouseUp += new MouseEventHandler(get_DragMouseUp);
        }

        /* get_TextBox_Enter_Placeholder(), get_TextBox_Leave_Placeholder() */

        public static void set_TextBox_Placeholder(BunifuMetroTextbox set_TextBox, String set_Placeholder)
        {
            set_TextBox.Text = set_Placeholder;

            set_TextBox.Enter += delegate (Object set_Object, EventArgs set_Event)
            {
                get_TextBox_Enter_Placeholder(set_TextBox, set_Event, set_Placeholder);
            };

            set_TextBox.Leave += delegate (Object set_Object, EventArgs set_Event)
            {
                get_TextBox_Leave_Placeholder(set_TextBox, set_Event, set_Placeholder);
            };
        }

        /* Close Form by "Escape" */

        public static void set_Form_Close(Object set_Object, KeyEventArgs set_Event, Form set_Form)
        {
            if (set_Event.KeyCode == Keys.Escape)
                set_Form.Close();
        }

        /* get_Form_Effect_Fade() */

        public static void set_Form_Effect_Fade(String set_Action, Form set_Form, Object set_Object, EventArgs set_EventArgs)
        {
            Form get_Form = (Form)set_Form;

            if (set_Action == "Exit")
            {
                if (get_Form.Opacity > 0.5)
                    get_Form.Opacity -= 0.1;

                else
                {
                    Environment.Exit(Environment.ExitCode);
                }
            }

            else if (set_Action == "Emphasize")
            {
                if (get_Form.Opacity > 0.5)
                    get_Form.Opacity -= 0.025;

                else
                    get_Timer.Stop();

            }

        }

        static BackgroundWorker pnl_BackgroundWorker = new BackgroundWorker();

        static void pnl_Account_Information_BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        static Form get_Form = new Form();

        public static void set_Panel_Container(Panel set_Panel, String set_Form_Name, String set_Action)
        {

            foreach (Control set_Control in set_Panel.Controls)
            {
                set_Control.Dispose();
            }

            set_Panel.Controls.Clear();

            if (!Object.ReferenceEquals(Application.OpenForms[set_Form_Name] as Form, null))
                Application.OpenForms[set_Form_Name].Dispose();

            if (!String.IsNullOrEmpty(set_Action))
                get_Form = (Form)Activator.CreateInstance(Type.GetType("MythicalCafe_ICMS_BackEnd." + set_Form_Name), set_Action);

            else
                get_Form = (Form)Activator.CreateInstance(Type.GetType("MythicalCafe_ICMS_BackEnd." + set_Form_Name));

            get_Form.TopLevel = false;
            get_Form.AutoScroll = true;

            set_Panel.Controls.Add(get_Form);

            get_Form.FormBorderStyle = FormBorderStyle.None;
            get_Form.Show();

            /*pnl_BackgroundWorker.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                if (!pnl_BackgroundWorker.IsBusy)
                if (set_Panel.InvokeRequired)
                {
                    set_Panel.Invoke(new MethodInvoker(delegate ()
                    {
                        set_Panel.Controls.Add(get_Form);
                    }));
                }

                else               
                    set_Panel.Controls.Add(get_Form);

                get_Form.FormBorderStyle = FormBorderStyle.None;
                get_Form.Show();

            };
            
            pnl_BackgroundWorker.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs e) 
            {               
                pnl_BackgroundWorker.Dispose();
            };
            
            pnl_BackgroundWorker.RunWorkerAsync(10);*/

            /*Func<Task> wew = new Func<Task>[]
            {
                () => get_TextBox_Effect_Blink(new BunifuMetroTextbox)
            };*/


        }

        public static void set_Panel_Container_Size(String set_Form_Name, Panel set_Panel)
        {
            get_Form = set_Panel.Controls.Find(set_Form_Name, true).FirstOrDefault() as Form;

            if (Object.ReferenceEquals(get_Form, null))
                return;

            get_Form.Size = new Size(set_Panel.Width, set_Panel.Height);
        }

        /* Add Blink Effect To TextBox */

        public static List<System.Windows.Forms.Timer> get_Timer_List = new List<System.Windows.Forms.Timer>();
        public static List<BunifuMetroTextbox> get_BunifuMetroTextbox_List = new List<BunifuMetroTextbox>();

        public static void get_TextBox_Effect_Blink(BunifuMetroTextbox set_TextBox)
        {
            System.Windows.Forms.Timer get_Timer = new System.Windows.Forms.Timer();

            get_Timer_List.Add(get_Timer);
            get_BunifuMetroTextbox_List.Add(set_TextBox);

            get_Timer.Interval = 250;
            get_Timer.Tick += delegate (Object set_Object, EventArgs set_EventArgs)
            {
                set_TextBox_Effect_Blink(set_Object, set_EventArgs, set_TextBox);
            };
            get_Timer.Start();
        }

        static void set_TextBox_Effect_Blink(Object set_Object, EventArgs set_EventArgs, BunifuMetroTextbox set_Textbox)
        {
            if (set_Textbox.BorderColorIdle == Color.FromArgb(130, 76, 167))
                set_Textbox.BorderColorIdle = Color.FromArgb(168, 130, 193);
            else
                set_Textbox.BorderColorIdle = Color.FromArgb(130, 76, 167);
        }

        public static void del_TextBox_Effect_Blink(String set_Action, BunifuMetroTextbox set_TextBox_1)
        {
            if (set_Action == "Stop : All")
            {
                foreach (System.Windows.Forms.Timer set_Timer in get_Timer_List)
                {
                    set_Timer.Stop();
                }

                foreach (BunifuMetroTextbox set_TextBox_2 in get_BunifuMetroTextbox_List)
                {
                    set_TextBox_2.BorderColorIdle = Color.FromArgb(130, 76, 167);
                }

                get_Timer_List.Clear();
                get_BunifuMetroTextbox_List.Clear();
            }
            else
            {
                Int32 get_TextBox_Index = get_BunifuMetroTextbox_List.IndexOf(set_TextBox_1);
                get_Timer_List[get_TextBox_Index].Stop();
                set_TextBox_1.BorderColorIdle = Color.FromArgb(130, 76, 167);
            }
        }

    }
}
