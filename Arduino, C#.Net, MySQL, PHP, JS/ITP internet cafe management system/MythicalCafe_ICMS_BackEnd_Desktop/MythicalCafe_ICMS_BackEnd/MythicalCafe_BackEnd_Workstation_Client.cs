using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public class MythicalCafe_BackEnd_Workstation_Client
    {
        public MythicalCafe_BackEnd_Workstation_Client(String set_Identity, String set_InternetProtocol)
        {
            Identity = set_Identity;
            InternetProtocol  = set_InternetProtocol;

            //MessageBox.Show(Identity + "," + InternetProtocol);

            Connection_Thread = new Thread(delegate ()
            {
                Socket = MythicalCafe_BackEnd_Workstation_Server.set_Socket_Client_Configuration(InternetProtocol);

                //PingReply get_PingReply = new Ping().Send(InternetProtocol);

                while (true)
                {
                    /*get_PingReply = new Ping().Send(InternetProtocol);

                    if (get_PingReply.Status.ToString() != "Success")
                    {
                        Socket = null;
                        Socket = MythicalCafe_BackEnd_Workstation_Server.set_Socket_Client_Configuration(InternetProtocol);

                        set_Configuration(MythicalCafe_BackEnd_Main_Method.Time_Rate, MythicalCafe_BackEnd_Main_Method.Time_Warning);
                    }*/

                    if (!MythicalCafe_BackEnd_Workstation_Server.check_Socket_Connection(Socket))
                    {
                        Socket = null;
                        Socket = MythicalCafe_BackEnd_Workstation_Server.set_Socket_Client_Configuration(InternetProtocol);

                        set_Configuration(MythicalCafe_BackEnd_Main_Method.Time_Rate, MythicalCafe_BackEnd_Main_Method.Time_Warning);
                    }

                    Thread.Sleep(500);
                }

            });

            Connection_Thread.Start();

            Interaction_Thread = new Thread(delegate ()
            {
                while (true)
                {
                    if (MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary.ContainsKey(Identity))
                    {
                        if (MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary[Identity].InternetProtocol != InternetProtocol)
                        {
                            Connection_Thread.Abort();

                            Socket = null;

                            Thread.CurrentThread.Abort();
                        }
                    }

                    String get_Socket_Packet = MythicalCafe_BackEnd_Workstation_Server.get_Socket_Packet(Socket).ToString();
                    
                    if (!String.IsNullOrEmpty(get_Socket_Packet.Trim()))
                    {                       
                        MythicalCafe_BackEnd_Workstation_Server.get_Socket_Interaction(get_Socket_Packet, this);
                    }

                    if (String.IsNullOrEmpty(Session_Identity))                    
                        MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, "{ 'Action' : 'No Session'}");                   

                    Thread.Sleep(500);
                }
            });

            Interaction_Thread.Start();
        }

        public Thread Connection_Thread = null;

        public Thread Interaction_Thread = null;

        public Socket Socket = null;

        public String Server_Host = null;

        public String Identity = null;

        public String Session_Identity = null;

        public String InternetProtocol = null;

        public void get_Client_Action(JObject set_Action_Information)
        {
            if (set_Action_Information["Action"].ToString() == "Time Bonus")
            {
                //MessageBox.Show("Bonus XDD");
                //MessageBox.Show(set_Action_Information.ToString());
            }

            else if (set_Action_Information["Action"].ToString() == "Time Pause")
            {
                //MythicalCafe_BackEnd_Main_Method.set_Session_Time_Pause();
            }

            else if (set_Action_Information["Action"].ToString() == "Time Unpause")
            {
                //MessageBox.Show("Unpauseeeee XD");
            }

            else if (set_Action_Information["Action"].ToString() == "Account Use")
            {
                //MessageBox.Show(set_Action_Information.ToString());
                MythicalCafe_BackEnd_Main_Method.check_Customer_Credential_Information(set_Action_Information, this);
            }

            else if (set_Action_Information["Action"].ToString() == "Workstation Reconnection")
            {
                MythicalCafe_BackEnd_Main_Method.check_Workstation_Session(this, Identity);
            }

            else if (set_Action_Information["Action"].ToString() == "Message")
            {
                try
                {
                    MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

                    new MythicalCafe_BackEnd_Dialog
                    (
                        "Message: \"" + set_Action_Information["Message"].ToString() +
                        "\"\n From " + set_Action_Information["Sender"].ToString() + " - " + get_UserControl_Workstation.Workstation_Name
                    ).ShowDialog();
                }

                catch { }

            }

            else if (set_Action_Information["Action"].ToString() == "Session End")
            {

                try
                {
                    MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;
                    
                    set_Session_End(get_UserControl_Workstation);
                }

                catch { }
            }

            else if (set_Action_Information["Action"].ToString() == "Lock I.D")
            {

                try
                {
                    MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

                    MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Credential_Information
                    (
                        "Update : Specific : Customer_RadioFrequency_Identification_Status",
                        get_UserControl_Workstation.Customer_Identity,
                        "",
                        "",
                        "",
                        "Inactive",
                        ""
                    );
                }

                catch { }
            }

            else if (set_Action_Information["Action"].ToString() == "Unlock I.D")
            {

                try
                {
                    MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

                    MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Credential_Information
                    (
                        "Update : Specific : Customer_RadioFrequency_Identification_Status",
                        get_UserControl_Workstation.Customer_Identity,
                        "",
                        "",
                        "",
                        "Active",
                        ""
                    );
                }

                catch { }
            }

            else if (set_Action_Information["Action"].ToString() == "Computer Lock")
            {

                try
                {
                    MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

                    MythicalCafe_BackEnd_Main_Method.set_Session_Computer_Lock(get_UserControl_Workstation);
                }

                catch { }
            }

            else if (set_Action_Information["Action"].ToString() == "Computer Unlock")
            {
                try
                {
                    MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

                    MythicalCafe_BackEnd_Main_Method.set_Session_Computer_Unlock(get_UserControl_Workstation);
                }

                catch { }
            }

            else if (set_Action_Information["Action"].ToString() == "Time Extend")
            {
                try 
                
                { 
                MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;
               
                
                MythicalCafe_BackEnd_Main_Method.set_Session_Time_Extend
                (
                    this,
                    get_UserControl_Workstation,
                    TimeSpan.Parse(set_Action_Information["Time Span"].ToString()),
                    get_UserControl_Workstation.Ended_DateTime
                );
                }

                catch { }
            }

            else if (set_Action_Information["Action"].ToString() == "System Configuration")            
                set_Configuration(MythicalCafe_BackEnd_Main_Method.Time_Rate, MythicalCafe_BackEnd_Main_Method.Time_Warning);            

        }

        Dictionary<String, String> get_Workstation_Action_Information = new Dictionary<String, String>();

        public void set_Session_Start(TimeSpan set_TimeSpan)
        {
            if (ReferenceEquals(Socket, null)){ new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();
            
            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());

            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Session Start");

            get_Workstation_Action_Information.Add("Time Span", set_TimeSpan.ToString());            

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }       

        public void set_Session_End(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {

            if (!MythicalCafe_BackEnd_Main_Method.set_Session_End(set_UserControl_Workstation, set_UserControl_Workstation.Started_DateTime, set_UserControl_Workstation.Ended_DateTime))
                return;

            set_UserControl_Workstation.Time_Remaining_Thread.Abort();
            set_UserControl_Workstation.Session_Identity = null;
            Session_Identity = null;

            if (ReferenceEquals(Socket, null)) { return; }

            get_Workstation_Action_Information.Clear();
            
            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());

            get_Workstation_Action_Information.Add("Action", "Session End");

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Account_Use(String set_Account_Information)
        {
            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();
            
            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Account Use");

            JObject get_Account_Information = JObject.Parse(JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));

            get_Account_Information.Merge(JObject.Parse(set_Account_Information));

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, get_Account_Information.ToString());
        }

        public void set_Time_Custom(TimeSpan set_TimeSpan, Double set_Charge, String set_Session_Action)
        {
            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());

            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Time Custom");
            get_Workstation_Action_Information.Add("Session Action", set_Session_Action);
            get_Workstation_Action_Information.Add("Time Span", set_TimeSpan.ToString());
            get_Workstation_Action_Information.Add("Charge", set_Charge.ToString());

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Does a custom time to *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Custom Time by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Add(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan, Double set_Charge)
        {
            if (!MythicalCafe_BackEnd_Main_Method.set_Session_Time_Add("", set_UserControl_Workstation, set_TimeSpan, set_UserControl_Workstation.Ended_DateTime, set_Charge.ToString()))
                return;

            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());

            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Time Add");
            get_Workstation_Action_Information.Add("Time Span", set_TimeSpan.ToString());
            get_Workstation_Action_Information.Add("Charge", set_Charge.ToString());

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Add time to *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Add Time by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Bonus(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan)
        {
            if (!MythicalCafe_BackEnd_Main_Method.set_Session_Time_Bonus(set_UserControl_Workstation, set_TimeSpan, set_UserControl_Workstation.Ended_DateTime))
                return;

            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Time Bonus");
            get_Workstation_Action_Information.Add("Time Span", set_TimeSpan.ToString());

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Added bonus time to *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Bonus Time by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );


            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Pause(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            if (!MythicalCafe_BackEnd_Main_Method.set_Session_Time_Pause(set_UserControl_Workstation, set_UserControl_Workstation.Started_DateTime, set_UserControl_Workstation.Ended_DateTime))
                return;

            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Time Pause");

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Pause the time of *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Pause Time by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Unpause(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            if (!MythicalCafe_BackEnd_Main_Method.set_Session_Time_Unpause(set_UserControl_Workstation, set_UserControl_Workstation.Started_DateTime, set_UserControl_Workstation.LastPaused_DateTime, set_UserControl_Workstation.Ended_DateTime))
                return;

            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Time Unpause");

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Unpause the time of *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Unpause Time by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Client_Move()
        {
            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Action", "Client Move");

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Client_Message(String set_Message)
        {
            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Client Message");
            get_Workstation_Action_Information.Add("Message", set_Message);

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Computer_Lock(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            if (!MythicalCafe_BackEnd_Main_Method.set_Session_Computer_Lock(set_UserControl_Workstation))
                return;

            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Computer Lock");

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Lock the computer of *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Computer has lock by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Computer_Unlock(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            if (!MythicalCafe_BackEnd_Main_Method.set_Session_Computer_Unlock(set_UserControl_Workstation))
                return;

            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Computer Unlock");

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Unlock the computer of *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Computer has unlock by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Extend(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan)
        {
            if (!MythicalCafe_BackEnd_Main_Method.set_Session_Time_Bonus(set_UserControl_Workstation, set_TimeSpan, set_UserControl_Workstation.Ended_DateTime))
                return;

            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());
            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Time Extend");
            get_Workstation_Action_Information.Add("Time Span", set_TimeSpan.ToString());

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Extend the time of *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Time extended by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Time_Extend(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan, Double set_Charge)
        {
            if (ReferenceEquals(Socket, null)) { new MythicalCafe_BackEnd_Dialog("Message: There is no Connection").ShowDialog(); return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());

            get_Workstation_Action_Information.Add("Workstation Identity", Identity);
            get_Workstation_Action_Information.Add("Session Identity", Session_Identity);
            get_Workstation_Action_Information.Add("Action", "Time Add");
            get_Workstation_Action_Information.Add("Time Span", set_TimeSpan.ToString());
            get_Workstation_Action_Information.Add("Charge", set_Charge.ToString());

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Extend the time of *" + Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Identity,
                "Time extended by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));
        }

        public void set_Configuration(String set_Time_Rate, String set_Time_Warning)
        {
            if (ReferenceEquals(Socket, null)) { return; }

            get_Workstation_Action_Information.Clear();

            get_Workstation_Action_Information.Add("From", Socket.LocalEndPoint.ToString());
            get_Workstation_Action_Information.Add("To", Socket.RemoteEndPoint.ToString());

            get_Workstation_Action_Information.Add("Workstation Identity", Identity);

            get_Workstation_Action_Information.Add("Action", "System Configuration");
            get_Workstation_Action_Information.Add("Time Rate", set_Time_Rate);
            get_Workstation_Action_Information.Add("Time Warning", set_Time_Warning);

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Packet(Socket, JsonConvert.SerializeObject(get_Workstation_Action_Information, Formatting.Indented));

        }
    }
}