using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_Login : Form
    {
        public MythicalCafe_FrontEnd_Login(String set_Action)
        {
            InitializeComponent();

            get_Action(set_Action);
        }

        Thread Login_Thread = null;
        Thread Login_Lock_Thread = null;

        private void MythicalCafe_FrontEnd_Login_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_Username, txt_Username.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_Password, txt_Password.Text.Trim());

            Login_Thread = new Thread(delegate()
            {
                while (true)
                {
                    set_Socket_Reconnection();

                    Thread.Sleep(1000);
                }
            });

            Login_Thread.Start();
            
            //pnl_Login_Main.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void MythicalCafe_FrontEnd_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login_Thread.Abort();

            if (!ReferenceEquals(Login_Lock_Thread, null))
                Login_Lock_Thread.Abort();

            Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Hide();   
        }

        /* Customized Method */

        String Login_Header = "";

        public void get_Action(String set_Action)
        {
            if (set_Action == "Time Pause")
            {
                pnl_Credential_Information.SetRow(pnl_Credential_Information, 5);
                pnl_Credential_Information.SetRow(lbl_Login_Session_Message, 2);

                if (set_Action == "Time Pause")
                    lbl_Login_Session_Message.Text = "Session Paused.";

                Login_Header = "";

                btn_Login.Visible = false;
            }

            else if (set_Action == "Computer Lock")
            {
                Login_Header = "Computer are Locked.";

                btn_Login.Visible = true;
                btn_Login.Text = "Unlock Computer";
            }

            else
            {
                Login_Header = "Login/Tap Your I.D";
                btn_Login.Visible = true;

            }
        }

        PingReply get_PingReply = new Ping().Send(MythicalCafe_FrontEnd_Main_Method.Server_InternetProtocol_Address);

        void set_Socket_Reconnection()
        {
            get_PingReply = new Ping().Send(MythicalCafe_FrontEnd_Main_Method.Server_InternetProtocol_Address);            

            if (get_PingReply.Status.ToString() != "Success")
            {
                txt_Username.Enabled = false;
                txt_Password.Enabled = false;
                btn_Login.Enabled = false;
                lbl_Login_Header.Text = "No Connection";


                txt_Username.Text = "Username";
                txt_Password.Text = "Password";
            }

            else if (MythicalCafe_FrontEnd_Workstation_Server.check_Socket_Connection(MythicalCafe_FrontEnd_Workstation_Server.Socket))
            {

                txt_Username.Enabled = true;
                txt_Password.Enabled = true;
                btn_Login.Enabled = true;
                lbl_Login_Header.Text = Login_Header;
            }

            else
            {
                txt_Username.Enabled = false;
                txt_Password.Enabled = false;
                btn_Login.Enabled = false;
                lbl_Login_Header.Text = "No Connection";


                txt_Username.Text = "Username";
                txt_Password.Text = "Password";
            }
        }

        /* Auto Generated Method */

        void btn_Login_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Username.Text.Trim()) || String.IsNullOrEmpty(txt_Password.Text.Trim()) || txt_Username.Text.Trim().Equals("Username") || txt_Password.Text.Trim().Equals("Password"))
            {
                new MythicalCafe_FrontEnd_Dialog("Message: Please input Your credentials.").ShowDialog();
                
                return;
            }

            if (btn_Login.Text == "Unlock Computer")
            {
                if (MythicalCafe_FrontEnd_Main_Method.Customer_Information["Customer_UserName"].ToString() == txt_Username.Text.Trim() && MythicalCafe_FrontEnd_Main_Method.Customer_Information["Customer_Password"].ToString() == txt_Password.Text.Trim())
                {
                    if (!MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Computer Unlock'}"))
                        new MythicalCafe_FrontEnd_Dialog("Message: No Connection. But Computer Can Unlock until restart.").ShowDialog();
                    
                    MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Action_Current = "";
                    MythicalCafe_FrontEnd_Main_Method.set_Computer_Unlock((Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main));
                }
                return;
            }

            Dictionary<String, String> get_Account_Information_Dictionary = new Dictionary<String, String>();

            get_Account_Information_Dictionary.Add("From", MythicalCafe_FrontEnd_Workstation_Server.Socket.LocalEndPoint.ToString());
            get_Account_Information_Dictionary.Add("To", MythicalCafe_FrontEnd_Workstation_Server.Socket.RemoteEndPoint.ToString());

            get_Account_Information_Dictionary.Add("Username", txt_Username.Text.Trim());
            get_Account_Information_Dictionary.Add("Password", txt_Password.Text.Trim());

            MythicalCafe_FrontEnd_Main_Method.get_Account_Use("Username and Password", JsonConvert.SerializeObject(get_Account_Information_Dictionary, Formatting.Indented).ToString(), MythicalCafe_FrontEnd_Workstation_Server.Socket);

            Int32 Counter = 0;
            Login_Lock_Thread = new Thread(delegate()
            {
                while(true)
                {
                    txt_Username.Enabled = false;
                    txt_Password.Enabled = false;
                    btn_Login.Enabled = false;

                    btn_Login.Text = "Logging in Please Wait.";

                    Counter++;

                    if (Counter == 5)
                    {

                        txt_Username.Enabled = true;
                        txt_Password.Enabled = true;
                        btn_Login.Enabled = true;

                        btn_Login.Text = "Login";

                        Thread.CurrentThread.Abort();
                    }

                    Thread.Sleep(1000);
                }
            });

            Login_Lock_Thread.Start();
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            txt_Password.isPassword = true;
        }

        private void Txt_Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_Password.Text.Trim()))
            {
                txt_Password.isPassword = false;
            }
        }
    }
}
