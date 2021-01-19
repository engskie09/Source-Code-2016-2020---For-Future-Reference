using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Main : Form
    {
        public MythicalCafe_BackEnd_Main()
        {
            InitializeComponent();

            //set_Control_Color();
            set_pnl_NavigationBar_Property();            
        }

        void MythicalCafe_BackEnd_Main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);

            MythicalCafe_Control_Propety.set_Panel_Container(pnl_Main_Container, get_Form_Name, "");

            Thread get_Main_Thread_1 = new Thread(delegate()
            {
                while (true)
                {
                    lbl_Top_Header.Text = "Branch: " + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "     Server Date-Time(This PC): " + DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss") + "\n" 
                    + MythicalCafe_BackEnd_Main_Method.Staff_Username + "   (" + MythicalCafe_BackEnd_Main_Method.Staff_Position + ")";

                    Thread.Sleep(1000);
                }                
            });

            get_Main_Thread_1.Start();

            if (String.IsNullOrEmpty(MythicalCafe_BackEnd_Main_Method.Staff_Identity))
            {
                Hide();

                MythicalCafe_BackEnd_Login get_Login = new MythicalCafe_BackEnd_Login();

                if (get_Login.ShowDialog() == DialogResult.OK)
                {
                    Show();
                }
                else
                    Close();
            }

            else
                MythicalCafe_BackEnd_Main_Method.get_Staff_Position_Information(MythicalCafe_BackEnd_Main_Method.Staff_Identity, "", "");
            
        }

        void MythicalCafe_BackEnd_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        void MythicalCafe_BackEnd_Main_SizeChanged(object sender, EventArgs e)
        {
            CenterToScreen();

            MythicalCafe_Control_Propety.set_Panel_Container_Size(get_Form_Name, pnl_Main_Container);
        }

        String get_Form_Name = new MythicalCafe_BackEnd_Workstation().Name;

        /* Customized Method */

        Color get_Color1 = MythicalCafe_Control_Propety.get_ThemeCurrentColor1;  /* 213, 11, 83 */
        Color get_Color2 = MythicalCafe_Control_Propety.get_ThemeCurrentColor3;  /* 168, 130, 193 */
        Color get_Color3 = MythicalCafe_Control_Propety.get_ThemeCurrentColor6;  /* 193, 130, 155 */
        Color get_Color4 = MythicalCafe_Control_Propety.get_ThemeCurrentColor4;  /* 130, 76, 167 */     

        void set_Control_Color( )
        {
            /*get_Color1 = Color.White;
            get_Color2 = Color.White;
            get_Color3 = Color.White;
            get_Color4 = Color.White;*/

            pnl_Border_Top.GradientBottomLeft = get_Color1;
            pnl_Border_Top.GradientBottomRight = get_Color2;
            pnl_Border_Top.GradientTopLeft = get_Color4;
            pnl_Border_Top.GradientTopRight = get_Color2;

            pnl_NavigationBar.BackColor = get_Color2;


            /*vsb_NavigationBar.ScrollBarRenderingConfigurator.BorderColor = get_Color2;
            vsb_NavigationBar.ScrollBarRenderingConfigurator.ControlVisualStateHoverColor = get_Color3;
            vsb_NavigationBar.ScrollBarRenderingConfigurator.ControlVisualStatePressedColor = get_Color1;

            vsb_NavigationBar.ScrollBarRenderingConfigurator.GradientStartNavigationButtonBackgroundColor = get_Color1;
            vsb_NavigationBar.ScrollBarRenderingConfigurator.GradientEndNavigationButtonBackgroundColor = get_Color2;

            vsb_NavigationBar.ScrollBarRenderingConfigurator.GradientStartThumbFillColor = get_Color1;
            vsb_NavigationBar.ScrollBarRenderingConfigurator.GradientEndThumbFillColor = get_Color2;

            vsb_NavigationBar.ScrollBarRenderingConfigurator.TrackFillColor = get_Color3;*/


            sc_Container.BackColor = get_Color2;

            btn_Workstation.color = get_Color3;
            btn_Workstation.colorActive = get_Color4;

            btn_Account.color = get_Color3;
            btn_Account.colorActive = get_Color4;

        }        

        void set_pnl_NavigationBar_Property()
        {
            pnl_NavigationBar.AutoScroll = false;

            pnl_NavigationBar.VerticalScroll.Enabled = false;
            pnl_NavigationBar.VerticalScroll.Visible = false;
            pnl_NavigationBar.VerticalScroll.Maximum = 0;

            pnl_NavigationBar.HorizontalScroll.Enabled = false;
            pnl_NavigationBar.HorizontalScroll.Visible = false;
            pnl_NavigationBar.HorizontalScroll.Maximum = 0;

            pnl_NavigationBar.AutoScroll = true;            
        }
        

        /* Auto Generated Method */

        void vsb_NavigationBar_Scroll(object sender, ScrollEventArgs e)
        {
            pnl_NavigationBar.AutoScrollPosition = new Point(pnl_NavigationBar.AutoScrollPosition.X, e.NewValue + 50);
        }

        void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Settings().ShowDialog();
        }

        private void btn_Application_Exit_Click(object sender, EventArgs e)
        {
            MythicalCafe_Control_Propety.get_Timer.Stop();

            MythicalCafe_Control_Propety.get_Form_Effect_Fade("Exit", this);
        }

        void btn_Workstation_Click(object sender, EventArgs e)
        {
            get_Form_Name = new MythicalCafe_BackEnd_Workstation().Name;

            MythicalCafe_Control_Propety.set_Panel_Container(pnl_Main_Container, get_Form_Name, "");
        }        

        void btn_Account_Click(object sender, EventArgs e)
        {
            get_Form_Name = new MythicalCafe_BackEnd_Account().Name;

            MythicalCafe_Control_Propety.set_Panel_Container(pnl_Main_Container, get_Form_Name, "");

            //new MythicalCafe_BackEnd_Account().Show();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {            
            get_Form_Name = new MythicalCafe_BackEnd_Product().Name;

            MythicalCafe_Control_Propety.set_Panel_Container(pnl_Main_Container, get_Form_Name, "");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: What do You want to do?");

            get_Dialog.btn_Ok.Text = "Change Account";
            get_Dialog.btn_No.Text = "Check Out";

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Logout"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Change Account"
                );

                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Staff_Identity", "");
            }
            else if (get_Dialog.DialogResult == DialogResult.No)
            {

                dynamic get_Staff_Attendance_Information = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Attendance_Information
                (
                    "Select : Specific : [ Staff_Identity, Attendance_Status ]",
                    null,
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Time In"
                );

                if (get_Staff_Attendance_Information is Boolean)
                {
                    if (get_Staff_Attendance_Information)
                        return;
                }

                else
                {
                    get_Staff_Attendance_Information = JObject.Parse(JObject.Parse(get_Staff_Attendance_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                    //MessageBox.Show(get_Staff_Attendance_Information.ToString());

                    DateTime get_Time_In = DateTime.Parse(get_Staff_Attendance_Information["Attendance_DateTime_In"].ToString());
                    DateTime get_Time_Out = DateTime.Now;

                    TimeSpan get_Time_In_And_Out = get_Time_Out.Subtract(get_Time_In);

                    Double get_Staff_Salary_Amount = (get_Time_In_And_Out.TotalSeconds / 3600) * Convert.ToDouble(MythicalCafe_BackEnd_Main_Method.Staff_Rate);


                    if (MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.update_Staff_Attendance_Information
                    (
                        "Update : Specific { Attendance_Status : Time In, Staff_Salary_Amount}",
                        null,
                        MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                        get_Time_In.ToString("yyyy-MM-dd HH:mm:ss"),
                        get_Time_Out.ToString("yyyy-MM-dd HH:mm:ss"),
                        "Time Out",
                        get_Staff_Salary_Amount.ToString()
                    ))
                    {
                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Account",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                            "Time Out"
                        );

                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Account",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                            "Logout"
                        );

                        MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Staff_Identity", "");

                        new MythicalCafe_BackEnd_Dialog("Message: Time Out: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).ShowDialog();
                        
                    }

                    else
                        return;
                }
            }

            else
                return;

            Hide();

            MythicalCafe_BackEnd_Login get_Login = new MythicalCafe_BackEnd_Login();

            if (get_Login.ShowDialog() == DialogResult.OK)
            {
                Show();
            }

            else
                Close();


        }

        private void btn_Account_My_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Confirm Password");

            MythicalCafe_Control_Propety.set_TextBox_Character_Password(get_Dialog.txt_Action);

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                dynamic get_Staff_Information = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information
                (
                    "Select : Specific : Username and Password",
                    null,
                    MythicalCafe_BackEnd_Main_Method.Staff_Username,
                    get_Dialog.txt_Action.Text,
                    ""
                );

                if (get_Staff_Information is Boolean)
                {
                    if (!get_Staff_Information)
                        new MythicalCafe_BackEnd_Dialog("Message: Try Again.").ShowDialog();
                }

                else
                {
                    get_Staff_Information = JObject.Parse(JObject.Parse(get_Staff_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                    MythicalCafe_BackEnd_Account_Staff_Manage_List get_Account_Staff_Manage_List = new MythicalCafe_BackEnd_Account_Staff_Manage_List() { Staff_Information = get_Staff_Information };
                    get_Account_Staff_Manage_List.get_Action("Update Account");
                    get_Account_Staff_Manage_List.chkbx_Staff_Status.Enabled = false;

                    if (get_Account_Staff_Manage_List.ShowDialog() == DialogResult.OK)
                    {
                        get_Staff_Information = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information
                        (
                            "Select : Specific : Username and Password",
                            null,
                            MythicalCafe_BackEnd_Main_Method.Staff_Username,
                            get_Dialog.txt_Action.Text,
                            ""
                        );

                        get_Staff_Information = JObject.Parse(JObject.Parse(get_Staff_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                        MythicalCafe_BackEnd_Main_Method.Staff_FullName = get_Staff_Information["Staff_FullName"].ToString();

                        new MythicalCafe_BackEnd_Dialog("Message: Success").ShowDialog();
                    }
                }
            }
        }
    }
}