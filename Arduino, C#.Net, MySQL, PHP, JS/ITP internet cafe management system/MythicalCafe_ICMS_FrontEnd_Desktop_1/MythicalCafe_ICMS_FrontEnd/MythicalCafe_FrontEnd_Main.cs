using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_Main : Form
    {
        public MythicalCafe_FrontEnd_Main()
        {
            InitializeComponent();
        }
        
        private void MythicalCafe_FrontEnd_Main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);

            Hide();

            MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Server_Configuration();           

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary.Add("Server Reconnection", new Thread(delegate()
            {
                PingReply get_PingReply = new Ping().Send(MythicalCafe_FrontEnd_Main_Method.Server_InternetProtocol_Address);

                while (true)
                {
                    get_PingReply = new Ping().Send(MythicalCafe_FrontEnd_Main_Method.Server_InternetProtocol_Address);

                    if (get_PingReply.Status.ToString() != "Success")
                    {
                        if (!String.IsNullOrEmpty(MythicalCafe_FrontEnd_Main_Method.Session_Identity))
                        {
                            MythicalCafe_FrontEnd_Main_Method.set_Session_End();
                        }

                        MythicalCafe_FrontEnd_Workstation_Server.Socket = null;
                        MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Server_Configuration();
                        MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{'Action' : 'System Configuration'}");
                    }

                    else if (MythicalCafe_FrontEnd_Workstation_Server.check_Socket_Connection(MythicalCafe_FrontEnd_Workstation_Server.Socket))
                    {
                        pnl_Border_Top.BackColor = Color.FromArgb(17, 202, 168);

                        if (String.IsNullOrEmpty(MythicalCafe_FrontEnd_Main_Method.Session_Identity))
                        {
                            MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{'Action' : 'Workstation Reconnection'}");

                            Thread.Sleep(1000);
                        }

                    }

                    else
                    {
                        pnl_Border_Top.BackColor = Color.FromArgb(0, 0, 0, 0);

                        MythicalCafe_FrontEnd_Workstation_Server.Socket = null;
                        MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Server_Configuration();
                        MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{'Action' : 'System Configuration'}");
                    }

                    Thread.Sleep(1000);
                }

            }));

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary["Server Reconnection"].Start();

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary.Add("Radio Frequency", new Thread(delegate ()
            {
                while (true)
                {
                    String get_Socket_Packet = MythicalCafe_FrontEnd_Workstation_Server.get_Socket_Packet(MythicalCafe_FrontEnd_Workstation_Server.Socket).ToString();

                    if (!String.IsNullOrEmpty(get_Socket_Packet.Trim()))
                    {
                        MythicalCafe_FrontEnd_Workstation_Server.get_Socket_Interaction(get_Socket_Packet);
                    }

                    Thread.Sleep(100);
                }
            }));

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary["Radio Frequency"].Start();

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary.Add("Lock Screen", new Thread(delegate ()
            {                
                new MythicalCafe_FrontEnd_LockScreen("").ShowDialog();

                MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary["Lock Screen"].Abort();
            }));

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary["Lock Screen"].Start();

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary.Add("Radio Frequency Reader Interaction", new Thread(delegate ()
            {

                MythicalCafe_FrontEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();

                while (true)
                {
                    if (MythicalCafe_FrontEnd_SerialPort_RadioFrequency.check_SerialPort_Connection())
                    {                        
                        if (!MythicalCafe_FrontEnd_SerialPort_RadioFrequency.set_SerialPort_Packet(" "))
                            MythicalCafe_FrontEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();
                    }

                    else
                        MythicalCafe_FrontEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();

                    String get_Packet = MythicalCafe_FrontEnd_SerialPort_RadioFrequency.get_SerialPort_Packet().Trim();
                    
                    if (String.IsNullOrEmpty(get_Packet) || get_Packet.Length != 10) return;                    

                    if (ReferenceEquals(MythicalCafe_FrontEnd_Workstation_Server.Socket.LocalEndPoint, null) || ReferenceEquals(MythicalCafe_FrontEnd_Workstation_Server.Socket.RemoteEndPoint, null))
                    { new MythicalCafe_FrontEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

                    if (MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current == "Identification Lock")
                    {
                        MythicalCafe_FrontEnd_Dialog get_Dialog = (Application.OpenForms[new MythicalCafe_FrontEnd_Dialog("").Name]) as MythicalCafe_FrontEnd_Dialog;

                        if (MythicalCafe_FrontEnd_Main_Method.Customer_Information["Customer_RadioFrequency_Identification"].ToString() == get_Packet)
                        {
                            get_Dialog.btn_Ok.Text = "Ok";

                            get_Dialog.get_Action("Choice: Confirmation Done. Do You want to proceed?");

                            get_Dialog.Action_Value = true.ToString();
                        }

                        else
                        {
                            get_Dialog.get_Action("Message: Invalid I.D");
                            get_Dialog.Action_Value = false.ToString();
                        }
                    }
                                        

                    else if (MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current == "Computer Lock")
                    {
                        if (MythicalCafe_FrontEnd_Main_Method.Customer_Information["Customer_RadioFrequency_Identification_Status"].ToString() == "Inactive")                        
                            new MythicalCafe_FrontEnd_Dialog("Message: Your Card is inactive and cannot be use.").ShowDialog();
                        
                        else
                        {
                            if (!MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Computer Unlock'}"))
                                new MythicalCafe_FrontEnd_Dialog("Message: No Connection. But Computer Can Unlock until restart.").ShowDialog();

                            MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current = "";
                            MythicalCafe_FrontEnd_Main_Method.set_Computer_Unlock(this);
                        }
                    }

                    else if (String.IsNullOrEmpty(MythicalCafe_FrontEnd_Main_Method.Session_Identity))
                    {

                        Dictionary<String, String> get_Account_Information_Dictionary = new Dictionary<String, String>();

                        get_Account_Information_Dictionary.Add("From", MythicalCafe_FrontEnd_Workstation_Server.Socket.LocalEndPoint.ToString());
                        get_Account_Information_Dictionary.Add("To", MythicalCafe_FrontEnd_Workstation_Server.Socket.RemoteEndPoint.ToString());
                        get_Account_Information_Dictionary.Add("Radio Frequency Identification", get_Packet);

                        MythicalCafe_FrontEnd_Main_Method.get_Account_Use("Radio Frequency Identification", JsonConvert.SerializeObject(get_Account_Information_Dictionary, Formatting.Indented).ToString(), MythicalCafe_FrontEnd_Workstation_Server.Socket);

                        Thread.Sleep(1000);
                    }

                    else
                    {
                        if (!lbl_Username.Text.Contains("Guest"))
                            if (MythicalCafe_FrontEnd_Main_Method.Customer_Information["Customer_RadioFrequency_Identification_Status"].ToString() == "Inactive")
                                new MythicalCafe_FrontEnd_Dialog("Message: Your Card is inactive and cannot be use.").ShowDialog();
                            else
                            {
                                if (MythicalCafe_FrontEnd_Main_Method.Customer_Information["Customer_RadioFrequency_Identification"].ToString() == get_Packet)
                                    if (!MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Session End'}"))
                                        new MythicalCafe_FrontEnd_Dialog("Message: Cannot End the Session because there is no Connection, ask the Staff.").ShowDialog();
                            }



                        Thread.Sleep(1000);
                    }

                    Thread.Sleep(100);
                }
            }));

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary["Radio Frequency Reader Interaction"].Start();

            MythicalCafe_FrontEnd_Main_Method.Main_Thread_Dictionary.Add("Time Remaining", new Thread(delegate () { }));

            
        }

        private void MythicalCafe_FrontEnd_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void MythicalCafe_FrontEnd_Main_Shown(object sender, EventArgs e)
        {
            Hide();
        }        

        public void set_Client_Action(String set_Action_Information)
        {

            set_Control_Property();

            JObject get_JObject = JObject.Parse(set_Action_Information);

            if (get_JObject["Action"].ToString() == "Time Custom")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Session_Clear();

                MythicalCafe_FrontEnd_Main_Method.Session_Identity = get_JObject["Session Identity"].ToString();
                
                MythicalCafe_FrontEnd_Main_Method.set_Time_Remaining
                (       
                    this,
                    TimeSpan.Parse(get_JObject["Time Span"].ToString()),
                    "Guest"
                );

                if (!ReferenceEquals(get_JObject["Session Action"], null))
                    if (get_JObject["Session Action"].ToString() == "Time Pause")
                        MythicalCafe_FrontEnd_Main_Method.set_Time_Pause(this);

                lbl_Action_1_Placeholder.Text = "Charge";
                lbl_Action_1.Text = get_JObject["Charge"].ToString();

                btn_Time_Extend.Enabled = false;
                btn_Computer_Lock.Enabled = false;
                btn_Message_Send.Enabled = false;
                btn_RadioFrequency_Identification_Status.Enabled = false;
                btn_Account_User.Enabled = false;
            }

            else if (get_JObject["Action"].ToString() == "Time Bonus")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Time_Bonus
                (
                    TimeSpan.Parse(get_JObject["Time Span"].ToString()),
                    lbl_Ended_DateTime
                );
            }

            else if (get_JObject["Action"].ToString() == "Time Add")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Time_Add
                (                   
                    TimeSpan.Parse(get_JObject["Time Span"].ToString()),
                    get_JObject["Charge"].ToString(),
                    this
                );
            }

            else if (get_JObject["Action"].ToString() == "Time Pause")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Time_Pause(this);
            }

            else if (get_JObject["Action"].ToString() == "Time Unpause")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Time_Unpause
                (
                    this,
                    lbl_Started_DateTime.Text,
                    lbl_Ended_DateTime,
                    set_Action_Information,
                    MythicalCafe_FrontEnd_Workstation_Server.Socket
                );
            }

            else if (get_JObject["Action"].ToString() == "Session Start")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Session_Clear();

                MythicalCafe_FrontEnd_Main_Method.Session_Identity = get_JObject["Session Identity"].ToString();

                MythicalCafe_FrontEnd_Main_Method.set_Session_Start(TimeSpan.Parse(get_JObject["Time Span"].ToString()), lbl_Time_Remaining, lbl_Started_DateTime);                

                if (!ReferenceEquals(get_JObject["Time Span"], null))
                    if (TimeSpan.TryParse(get_JObject["Time Span"].ToString(), out _))
                        lbl_Started_DateTime.Text = DateTime.Now.Subtract(TimeSpan.Parse(get_JObject["Time Span"].ToString())).ToString("hh:mm:ss");
                else
                    lbl_Started_DateTime.Text = DateTime.Now.ToString("hh:mm:ss");

                lbl_Ended_DateTime.Text = "00:00:00";
                lbl_Username.Text = "Hello Guest.";

                lbl_Action_1.Visible = false;
                btn_Time_Extend.Enabled = false;
                btn_Computer_Lock.Enabled = false;
                btn_Message_Send.Enabled = false;
                btn_RadioFrequency_Identification_Status.Enabled = false;
                btn_Account_User.Enabled = false;

            }

            else if (get_JObject["Action"].ToString() == "Account Use")
            {
                //MythicalCafe_FrontEnd_Main_Method.set_Session_Clear();
                MythicalCafe_FrontEnd_Main_Method.Session_Identity = get_JObject["Session Identity"].ToString();

                MythicalCafe_FrontEnd_Main_Method.set_Account_Use(this, get_JObject);
                if (get_JObject["Customer_RadioFrequency_Identification_Status"].ToString() == "Active")
                    btn_RadioFrequency_Identification_Status.Text = "Lock ID";
                else
                    btn_RadioFrequency_Identification_Status.Text = "Unlock ID";

                if (File.Exists(get_JObject["Customer_Image_Path"].ToString().Replace('/', '\\')))
                {
                    using (FileStream set_FileStream = new FileStream(get_JObject["Customer_Image_Path"].ToString(), FileMode.Open, FileAccess.Read))
                    {
                        pctbx_Customer_Image.Image = Image.FromStream(set_FileStream);
                    }
                }

                lbl_Action_1.Text = get_JObject["Point_Remaining"].ToString();
            }

            else if (get_JObject["Action"].ToString() == "Computer Lock")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Computer_Lock(this);
            }

            else if (get_JObject["Action"].ToString() == "Computer Unlock")
            {
                MythicalCafe_FrontEnd_Main_Method.set_Computer_Unlock(this);
            }
            
        }

        private void set_Control_Property()
        {
            lbl_Action_1_Placeholder.Visible = true;
            lbl_Action_1.Visible = true;
            btn_Time_Extend.Enabled = true;
            btn_Computer_Lock.Enabled = true;
            btn_Message_Send.Enabled = true;
            btn_RadioFrequency_Identification_Status.Enabled = true;
            btn_Account_User.Enabled = true;
        }

        private void btn_Time_Extend_Click(object sender, EventArgs e)
        {
            new MythicalCafe_FrontEnd_Time_Extend().ShowDialog();
        }

        private void btn_Session_End_Click(object sender, EventArgs e)
        {
            if(!MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Session End'}"))
                new MythicalCafe_FrontEnd_Dialog("Message: Cannot End the Session because there is no Connection, ask the Staff.").ShowDialog();
        }
        
        private void btn_RadioFrequency_Identification_Status_Click(object sender, EventArgs e)
        {
            if (btn_RadioFrequency_Identification_Status.Text == "Lock ID")
            {
                MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current = "Identification Lock";

                MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Message: Tap Your I.D for confirmation.");

                get_Dialog.Action_Value = false.ToString();

                get_Dialog.btn_Ok.Text = "Close";


                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    if (get_Dialog.btn_Ok.Text != "Close")
                        if (Convert.ToBoolean(get_Dialog.Action_Value))                        
                            if (MythicalCafe_FrontEnd_Main_Method.set_RadioFrequency_Identification_Status(btn_RadioFrequency_Identification_Status.Text))                            
                                btn_RadioFrequency_Identification_Status.Text = "Unlock ID";
                            
                        
                }

                MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current = "";
            }

            else
            {
                MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current = "Identification Lock";

                MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Message: Tap Your I.D for confirmation.");

                get_Dialog.Action_Value = false.ToString();

                get_Dialog.btn_Ok.Text = "Close";


                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    if (get_Dialog.btn_Ok.Text != "Close")
                        if (Convert.ToBoolean(get_Dialog.Action_Value))                        
                            if (MythicalCafe_FrontEnd_Main_Method.set_RadioFrequency_Identification_Status(btn_RadioFrequency_Identification_Status.Text))                            
                                btn_RadioFrequency_Identification_Status.Text = "Lock ID";
                }

                MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current = "";
            }
        }
        

        private void btn_Computer_Lock_Click(object sender, EventArgs e)
        {
            if (!MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Computer Lock'}"))            
                new MythicalCafe_FrontEnd_Dialog("Message: No Connection. But Computer Can Lock until restart.").ShowDialog();

            MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current = "Computer Lock";
            MythicalCafe_FrontEnd_Main_Method.set_Computer_Lock(this);


        }

        private void btn_Message_Send_Click(object sender, EventArgs e)
        {
            MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Input: Type Your message.");

            if (get_Dialog.ShowDialog() == DialogResult.OK)            
                if (!MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Message' ,'Message' : '" + get_Dialog.Action_Value + "', 'Sender' : '" + lbl_Username.Text.Remove(0, 6).TrimEnd('.') + "'}"))
                    new MythicalCafe_FrontEnd_Dialog("Message: Cannot send Message because there is no Connection, ask the Staff.").ShowDialog();
        }

        private void btn_Account_User_Click(object sender, EventArgs e)
        {
            new MythicalCafe_FrontEnd_Account_User().ShowDialog();
        }

        
    }
}
