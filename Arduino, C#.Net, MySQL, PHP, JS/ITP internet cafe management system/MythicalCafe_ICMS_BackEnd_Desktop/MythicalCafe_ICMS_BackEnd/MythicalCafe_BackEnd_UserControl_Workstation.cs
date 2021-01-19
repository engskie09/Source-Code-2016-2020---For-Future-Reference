using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Bunifu.Framework.UI;
using System.IO;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_UserControl_Workstation : UserControl
    {
        public MythicalCafe_BackEnd_UserControl_Workstation(String set_Workstation_Identity)
        {
            InitializeComponent();

            Workstation_Identity = set_Workstation_Identity;
        }

        private void MythicalCafe_BackEnd_UserControl_Workstation_Load(object sender, EventArgs e)
        {            
            CheckForIllegalCrossThreadCalls = false;

            set_Panel_Draggable(panel1, this);      

            set_Control_Default_Value();

            set_Session_Information();

            Int32 get_Width = Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Width;
            Int32 get_Height = Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Height;

            /*if ((get_Width == 1280 && get_Height == 768) || (get_Width == 1280 && get_Height == 950))
            {
                Margin = new Padding(10, 15, 0, 15);
            }

            else if (get_Width == 1400 && get_Height == 1050)
            {
                Size = new Size(343, 308);
                Margin = new Padding(40, 15, 15, 15);
            }*/

            Margin = new Padding(50, 30, 15, 15);
            Connection_Thread = new Thread(delegate()
            {                
                while (true)
                {                    
                    if (MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary.TryGetValue(Workstation_Identity, out _))                        
                    if (MythicalCafe_BackEnd_Workstation_Server.check_Socket_Connection(MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[Workstation_Identity].Socket))
                        pnl_Workstation_Connection.BackColor = Color.FromArgb(17, 202, 168);

                    else
                        pnl_Workstation_Connection.BackColor = Color.FromArgb(100, 17, 202, 168);



                    Thread.Sleep(500);
                }                
            });

            Connection_Thread.Start();

            Disposed += set_Dispose;
        }

        public Thread Connection_Thread = null;
        public Thread Time_Remaining_Thread = null;

        public String Workstation_Identity = null;
        public String Session_Identity = null;
        public String Customer_Identity = null;

        public String Session_Action = null;

        public Boolean Session_Open_Time = false;

        public String Time_Started
        {
            get { return lbl_Time_Started.Text; }
            set { lbl_Time_Started.Text = value; }
        }

        public String Time_Ended
        {
            get { return lbl_Time_Ended.Text; }
            set { lbl_Time_Ended.Text = value; }
        }

        public String Time_Duration
        {
            get { return lbl_Time_Duration.Text; }
            set { lbl_Time_Duration.Text = value; }
        }

        public String Time_Remaining
        {
            get { return lbl_Time_Remaining.Text; }
            set { lbl_Time_Remaining.Text = value; }
        }

        public String Workstation_Charge
        {
            get { return lbl_Workstation_Charge.Text; }
            set { lbl_Workstation_Charge.Text = value; }
        }

        public String Username
        {
            get { return lbl_Username.Text; }
            set { lbl_Username.Text = value; }
        }

        public String Workstation_Name
        {
            get { return lbl_WorkStation_Name.Text; }
            set { lbl_WorkStation_Name.Text = value; }
        }

        public DateTime Started_DateTime = new DateTime();
        public DateTime LastPaused_DateTime = new DateTime();
        public DateTime Ended_DateTime = new DateTime();

        private void set_Dispose(Object set_Object, EventArgs set_EventArgs)
        {
            Connection_Thread.Abort();

            if(!ReferenceEquals(Time_Remaining_Thread, null))
                Time_Remaining_Thread.Abort();
        }
        public void set_Control_Default_Value()
        {            
            if (String.IsNullOrEmpty(Session_Identity))
            {
                Int32 asd = new Random().Next(0, 2);

                if (asd == 1)
                    pctbx_WorkstationIcon.Image = Properties.Resources.icon_Female;
                else
                    pctbx_WorkstationIcon.Image = Properties.Resources.icon_Male;
            }

            Time_Started = "00:00:00";
            Time_Ended = "00:00:00";
            Time_Duration = "00:00:00";
            Time_Remaining = "00:00:00";
            Workstation_Charge = "";
            Username = "";

            Started_DateTime = new DateTime();
            LastPaused_DateTime = new DateTime();
            Ended_DateTime = new DateTime();

            Session_Open_Time = false;

            lbl_Time_Remaining.ForeColor = Color.White;
        }

        public void set_Session_Information()
        {
            dynamic get_Session_Information = MythicalCafe_BackEnd_Workstation_Method.select_Session_Information
            (
                "Select : Specific : Active",
                "Workstation_Identity",
                Workstation_Identity
            );

            if (get_Session_Information is Boolean) { if (!get_Session_Information) return; }
            
            else
            {                
                get_Session_Information = JObject.Parse(JObject.Parse(get_Session_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                Session_Identity = get_Session_Information["Session_Identity"].ToString();

                if (MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary.TryGetValue(Workstation_Identity, out _))
                    MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[Workstation_Identity].Session_Identity = Session_Identity;

                Session_Action = get_Session_Information["Session_Action_Last"].ToString();
                
                Started_DateTime = Convert.ToDateTime(get_Session_Information["Session_Started_DateTime"]);
                LastPaused_DateTime = Convert.ToDateTime(get_Session_Information["Session_LastPaused_DateTime"]);
                Ended_DateTime = Convert.ToDateTime(get_Session_Information["Session_Ended_DateTime"]);

                Time_Started = Started_DateTime.ToString("hh:mm:ss");

                ///Open Time.
                if (Ended_DateTime == DateTime.MinValue)
                {
                    Session_Open_Time = true;
                    MythicalCafe_BackEnd_UserControl_Workstation_Method.set_Session_Start(this, TimeSpan.FromSeconds(Convert.ToDouble(get_Session_Information["Time_Spent"])));
                }

                //Time Remaining.
                else
                {
                    //if (get_Session_Information["User_Identity"].ToString().Contains("CSTMR"))
                    Time_Ended = Ended_DateTime.ToString("hh:mm:ss");

                    Time_Duration = Ended_DateTime.Subtract(Started_DateTime).ToString();

                    Workstation_Charge = get_Session_Information["Cash_Spent"].ToString() + " Pesos";

                    MythicalCafe_BackEnd_UserControl_Workstation_Method.set_Time_Remaining(this);
                }   

                get_Session_Information = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Credential_Information
                (
                    "Select : Specific",
                    null, 
                    get_Session_Information["User_Identity"].ToString(),
                    null
                );

                if (get_Session_Information is Boolean) { if (!get_Session_Information) { Username = "Guest"; return; } }

                else
                {
                    get_Session_Information = JObject.Parse(JObject.Parse(get_Session_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));
                    
                    Username = get_Session_Information["Customer_UserName"].ToString();

                    Customer_Identity = get_Session_Information["Customer_Identity"].ToString();

                    //get_Session_Information.Merge(JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Credential_Information("Select : Specific", null, get_Session_Information["Customer_Identity"].ToString()))["Table"].ToString().TrimStart('[').TrimEnd(']')));

                    get_Session_Information.Merge(JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Personal_Information("Select : Specific", get_Session_Information["Customer_Identity"].ToString()))["Table"].ToString().TrimStart('[').TrimEnd(']')));

                    //get_Session_Information.Merge(JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information("Select : Specific", get_Session_Information["Customer_Identity"].ToString()))["Table"].ToString().TrimStart('[').TrimEnd(']')));

                    //MessageBox.Show(get_Session_Information.ToString());
                    if (File.Exists(get_Session_Information["Customer_Image_Path"].ToString()))
                    {
                        using (FileStream set_FileStream = new FileStream(get_Session_Information["Customer_Image_Path"].ToString(), FileMode.Open, FileAccess.Read))
                        {
                            pctbx_WorkstationIcon.Image = Image.FromStream(set_FileStream);
                        }
                    }
                }
            }
        }

        private void btn_More_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_UserControl_Workstation_More_Dialog(this, MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[Name]).ShowDialog();
        }

        static Int32 get_move = new Int32();
        static Int32 get_moveX = new Int32();
        static Int32 get_moveY = new Int32();

        static void get_DragMouseDown(Object set_Object, MouseEventArgs set_Event)
        {
            get_move = 1;
            get_moveX = set_Event.X;
            get_moveY = set_Event.Y;
        }

        static void get_DragMouseMove(Object set_Object, MouseEventArgs set_Event, MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            if (get_move == 1)
                set_UserControl_Workstation.set_Control_Location(MousePosition.X - get_moveX, MousePosition.Y - get_moveY);
        }

        static void get_DragMouseUp(Object set_Object, MouseEventArgs set_Event)
        {
            get_move = 0;
        }

        void set_Panel_Draggable(Panel set_Panel, MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            
            set_Panel.MouseDown += new MouseEventHandler(get_DragMouseDown);

            set_Panel.MouseMove += delegate (Object set_Object, MouseEventArgs set_Event)
            {
                get_DragMouseMove(set_Object, set_Event, set_UserControl_Workstation);
            };

            set_Panel.MouseUp += new MouseEventHandler(get_DragMouseUp);
        }

        void set_Control_Location(Int32 X, Int32 Y)
        {
            Location = new Point(-500, -500);
        }

        private void btn_Time_Add_Click(object sender, EventArgs e)
        {
            if (Session_Open_Time || String.IsNullOrEmpty(Session_Identity))
            {
                new MythicalCafe_BackEnd_Dialog("Message: Cannot Add Time because It`s Open Time or No Active Session.").ShowDialog();
                return;
            }

            MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom get_UserControl_Workstation_Time_Bonus_And_Custom = new MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom(this, MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[Name]);
            get_UserControl_Workstation_Time_Bonus_And_Custom.get_Action("Time Add");
            get_UserControl_Workstation_Time_Bonus_And_Custom.ShowDialog();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Dialog("Message: No Connection or Invalid CMD Operating System Command").ShowDialog();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            new potaenaaa().ShowDialog();
        }
    }
}
