using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.IO;

namespace MythicalCafe_ICMS_FrontEnd
{
    public static class MythicalCafe_FrontEnd_Main_Method
    {       

        public static String Branch_Identity = null;

        public static String Configuration_information_File_Path = "configuration_information.xml";

        public static String RadioFrequency_Port = null;
        public static String RadioFrequency_Status = null;

        public static String Server_InternetProtocol_Address = null;

        public static String RadioFrequency_Action_Current = null;

        public static String Time_Rate = null;

        public static String Time_Warning = null;

        public static Boolean check_File_Availability(String set_File_Path)
        {
            if (!File.Exists(set_File_Path))
            {
                File.Create(set_File_Path).Dispose();
                return false;
            }

            return true;
        }

        public static void set_System_Configuration()
        {
            XDocument get_XDocument;

            if (!check_File_Availability(Configuration_information_File_Path))
            {
                get_XDocument = new XDocument();

                XElement get_XElement = new XElement("System_Configuration");

                get_XElement.Add(new XElement("Branch_Identity", "0001"));
                get_XElement.Add(new XElement("Server_InternetProtocol_Address", "localhost"));
                get_XElement.Add(new XElement("RadioFrequency_Port", "COM3"));
                get_XElement.Add(new XElement("RadioFrequency_Status", "Disable"));
                get_XDocument.Add(get_XElement);
                get_XDocument.Save(Configuration_information_File_Path);
            }

            get_XDocument = XDocument.Load(Configuration_information_File_Path);

            Branch_Identity = get_XDocument.Descendants("Branch_Identity").FirstOrDefault().Value.ToString();

            RadioFrequency_Port = get_XDocument.Descendants("RadioFrequency_Port").FirstOrDefault().Value.ToString();
            RadioFrequency_Status = get_XDocument.Descendants("RadioFrequency_Status").FirstOrDefault().Value.ToString();

            Server_InternetProtocol_Address = get_XDocument.Descendants("Server_InternetProtocol_Address").FirstOrDefault().Value.ToString();
        }

        static Dictionary<TimeSpan, String> Time_Warning_Dictionary = new Dictionary<TimeSpan, String>();


        public static void set_Time_Warning()
        {
            List<String> get_Time_Warning_List = new List<String>();

            get_Time_Warning_List = Time_Warning.Split(new[] { "*,*" }, StringSplitOptions.None).ToList();

            get_Time_Warning_List.RemoveAt(get_Time_Warning_List.Count - 1);

            Time_Warning_Dictionary.Clear();

            foreach (String set_String in get_Time_Warning_List)
            {
                String[] get_String = set_String.Split('=');                

                Time_Warning_Dictionary.Add(TimeSpan.FromSeconds(Convert.ToDouble(get_String[0])), get_String[1]);
            }
        }

        public static void check_Time_Warning(TimeSpan set_TimeSpan)
        {
            
            if (Time_Warning_Dictionary.Count > 0)
                foreach (KeyValuePair<TimeSpan, String> set_KeyValuePair in Time_Warning_Dictionary)
                if (set_TimeSpan.TotalSeconds == set_KeyValuePair.Key.TotalSeconds)
                {
                    Thread get_Thread = new Thread(delegate()
                    {
                        new MythicalCafe_FrontEnd_Dialog("Message: " + set_KeyValuePair.Value) { TopMost = true }.ShowDialog();

                        Thread.CurrentThread.Abort();
                    });

                    get_Thread.Start();
                }
                
        }

        public static JObject Customer_Information = null;

        static JObject Action_Information = null;

        static Dictionary<String, String> Workstation_Action_Dictionary = new Dictionary<String, String>();

        public static void get_Session_Start(String set_Action_Information, Socket set_Socket)
        {
            
            Action_Information = JObject.Parse(set_Action_Information);
                    

            Workstation_Identity = Action_Information["Workstation Identity"].ToString();

            if (!ReferenceEquals(Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name], null))
            {
                Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();
            }

            Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Show();

            (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
            
        }

        public static void set_Time_Custom(String set_Action_Information, Socket set_Socket)
        {            
            Action_Information = JObject.Parse(set_Action_Information);
           
            Workstation_Identity = Action_Information["Workstation Identity"].ToString();

            if (!ReferenceEquals(Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name], null))
            {
                Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();
            }

            Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Show();

            (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
            
        }

        public static void get_Account_Use(String set_Action, String set_Action_Information, Socket set_Socket)
        {
            Action_Information = JObject.Parse(set_Action_Information);
            Workstation_Action_Dictionary.Clear();

            Workstation_Action_Dictionary.Add("From", set_Socket.LocalEndPoint.ToString());
            Workstation_Action_Dictionary.Add("To", set_Socket.RemoteEndPoint.ToString());

            Workstation_Action_Dictionary.Add("Action", "Account Use");


            if (set_Action == "Radio Frequency Identification")
            {
                Workstation_Action_Dictionary.Add("Radio Frequency Identification", Action_Information["Radio Frequency Identification"].ToString());
            }

            else
            {
                Workstation_Action_Dictionary.Add("Username", Action_Information["Username"].ToString());
                Workstation_Action_Dictionary.Add("Password", Action_Information["Password"].ToString());
            }

            MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet(JsonConvert.SerializeObject(Workstation_Action_Dictionary, Formatting.Indented));

        }

        public static ManualResetEvent Main_ManualResetEvent_1 = new ManualResetEvent(false);

        public static Dictionary<String, Thread> Main_Thread_Dictionary = new Dictionary<String, Thread>();

        public static TimeSpan Main_TimeSpan;

        public static String Workstation_Identity = null;
        public static String Session_Identity = null;

        public static void set_Session_Start(TimeSpan set_TimeSpan, Label set_lbl_Time_Remaining, Label set_lbl_Started_DateTime)
        {
            Main_TimeSpan = set_TimeSpan;           

            Main_Thread_Dictionary["Time Remaining"] = new Thread(delegate ()
            {
                set_lbl_Started_DateTime.Text = DateTime.Now.Subtract(Main_TimeSpan).ToShortTimeString();

                while (true)
                {
                    Main_ManualResetEvent_1.WaitOne(Timeout.Infinite);

                    Main_TimeSpan = TimeSpan.FromSeconds(Main_TimeSpan.TotalSeconds + 1);

                    set_lbl_Time_Remaining.Text = Main_TimeSpan.ToString();

                    Thread.Sleep(1000);
                }
            });

            Main_ManualResetEvent_1.Set();

            Main_Thread_Dictionary["Time Remaining"].Start();
        }

        public static Boolean set_Session_Clear()
        {
            if (Main_Thread_Dictionary.TryGetValue("Time Remaining", out _))
            {
                Main_Thread_Dictionary["Time Remaining"].Abort();

                Session_Identity = null;
                Customer_Information = null;
            }

            if (!ReferenceEquals(Main_Thread_Dictionary["Lock Screen"], null))
                Main_Thread_Dictionary["Lock Screen"].Abort();

            return true;
        }

        public static void set_Session_End()
        {
            if (Main_Thread_Dictionary.TryGetValue("Time Remaining", out _))
            {                
                
                if(!ReferenceEquals(Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name], null))
                {
                    Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                    Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();
                }

                Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Hide();

                if (!ReferenceEquals(Main_Thread_Dictionary["Lock Screen"], null))
                    Main_Thread_Dictionary["Lock Screen"].Abort();

                Main_Thread_Dictionary["Lock Screen"] = new Thread(delegate ()
                {
                    new MythicalCafe_FrontEnd_LockScreen("").ShowDialog();                    
                });

                Main_Thread_Dictionary["Lock Screen"].Start();
                
                Session_Identity = null;
                Customer_Information = null;

                Main_Thread_Dictionary["Time Remaining"].Abort();
            }
        }

        public static void set_Time_Remaining(MythicalCafe_FrontEnd_Main set_FrontEnd_Main, TimeSpan set_TimeSpan, String set_Username)
        {            
            Main_Thread_Dictionary["Time Remaining"] = new Thread(delegate ()
            {
                Main_TimeSpan = set_TimeSpan;

                set_FrontEnd_Main.lbl_Username.Text = "Hello " + set_Username + ".";

                set_FrontEnd_Main.lbl_Started_DateTime.Text = DateTime.Now.ToString("hh:mm:ss");
                set_FrontEnd_Main.lbl_Ended_DateTime.Text = DateTime.Now.Add(Main_TimeSpan).ToString("hh:mm:ss");

                while (true)
                {        
                    if (Main_TimeSpan.TotalSeconds <= 0)
                    {
                        set_FrontEnd_Main.lbl_Time_Remaining.Text = "00:00:00";

                        if(!MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Session End'}"))
                            set_Session_End();

                        Thread.Sleep(1000);                        
                    }

                    check_Time_Warning(Main_TimeSpan);

                    Main_ManualResetEvent_1.WaitOne(Timeout.Infinite);

                    Main_TimeSpan = TimeSpan.FromSeconds(Main_TimeSpan.TotalSeconds - 1);

                    set_FrontEnd_Main.lbl_Time_Remaining.Text = Main_TimeSpan.ToString();

                    Thread.Sleep(1000);
                }
            });

            Main_ManualResetEvent_1.Set();

            Main_Thread_Dictionary["Time Remaining"].Start();
        }

        public static void set_Time_Bonus(TimeSpan set_TimeSpan, Label set_lbl_Ended_DateTime)
        {

            if (Main_TimeSpan.TotalSeconds <= 0)
            {
                Main_TimeSpan = TimeSpan.FromSeconds(0);
                Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Show();

                Main_ManualResetEvent_1.Set();
            }

            Main_TimeSpan = Main_TimeSpan.Add(set_TimeSpan);

            //MessageBox.Show(Main_TimeSpan.ToString());
            set_lbl_Ended_DateTime.Text = DateTime.Now.Add(Main_TimeSpan).ToString("hh:mm:ss");
        }

        public static void set_Time_Add(TimeSpan set_TimeSpan, String set_Charge, MythicalCafe_FrontEnd_Main FrontEnd_Main)
        {
            if (Main_TimeSpan.TotalSeconds <= 0)
            {
                Main_TimeSpan = TimeSpan.FromSeconds(0);
                Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Show();

                Main_ManualResetEvent_1.Set();
            }

            Main_TimeSpan = Main_TimeSpan.Add(set_TimeSpan);

            FrontEnd_Main.lbl_Ended_DateTime.Text = DateTime.Now.Add(Main_TimeSpan).ToString("hh:mm:ss");

            if (FrontEnd_Main.lbl_Username.Text.Contains("Guest"))
                FrontEnd_Main.lbl_Action_1.Text = (Convert.ToDouble(FrontEnd_Main.lbl_Action_1.Text) + Convert.ToDouble(set_Charge)).ToString();

            else
            {
                Customer_Information["Cash_Remaining"] = Convert.ToDouble(Customer_Information["Cash_Remaining"]) - Convert.ToDouble(set_Charge);

                Customer_Information["Point_Remaining"] = Convert.ToDouble(Customer_Information["Point_Remaining"]) + Convert.ToDouble(Math.Round(set_TimeSpan.TotalSeconds / 3600, 2).ToString());

                FrontEnd_Main.lbl_Action_1.Text = Customer_Information["Point_Remaining"].ToString();
            }
        }

        public static void set_Time_Pause(Form set_Form)
        {
            set_Form.Hide();

            Main_ManualResetEvent_1.Reset();

            Main_Thread_Dictionary["Lock Screen"] = new Thread(delegate ()
            {
                new MythicalCafe_FrontEnd_LockScreen("Time Pause").ShowDialog();

                Main_Thread_Dictionary["Lock Screen"].Abort();
            });

            Main_Thread_Dictionary["Lock Screen"].Start();
        }

        public static void set_Time_Unpause(Form set_Form, String set_Started_DateTime, Label set_lbl_Ended_DateTime, String set_Action_Information, Socket set_Socket)
        {
            Action_Information = JObject.Parse(set_Action_Information);

            Workstation_Action_Dictionary.Clear();

            Workstation_Action_Dictionary.Add("From", set_Socket.LocalEndPoint.ToString());
            Workstation_Action_Dictionary.Add("To", set_Socket.RemoteEndPoint.ToString());

            Workstation_Action_Dictionary.Add("Workstation Identity", Action_Information["Workstation Identity"].ToString());
            Workstation_Action_Dictionary.Add("Session Identity", Action_Information["Session Identity"].ToString());
            Workstation_Action_Dictionary.Add("Action", Action_Information["Action"].ToString());
            Workstation_Action_Dictionary.Add("", "");

            String get_Ended_DateTime = DateTime.Now.Add(Main_TimeSpan).ToString("hh:mm:ss");

            DateTime get_DateTime_Started = DateTime.Parse(set_Started_DateTime);

            get_Ended_DateTime = DateTime.Parse(get_Ended_DateTime).Subtract(get_DateTime_Started).ToString();

            if (MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet(JsonConvert.SerializeObject(Workstation_Action_Dictionary, Formatting.Indented)))
            {
                Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();

                set_Form.Show();

                set_lbl_Ended_DateTime.Text = get_Ended_DateTime;

                Main_ManualResetEvent_1.Set();
            }
        }

        public static void set_Account_Use(MythicalCafe_FrontEnd_Main set_FrontEnd_Main, JObject set_Session_Information)
        {
            TimeSpan get_TimeSpan;

            if (set_Session_Information["Session_Action_Last"].ToString() == "Time Pause")
            {                
                get_TimeSpan = TimeSpan.FromSeconds(Math.Round(DateTime.Parse(set_Session_Information["Session_Ended_DateTime"].ToString()).Subtract(DateTime.Parse(set_Session_Information["Session_LastPaused_DateTime"].ToString())).TotalSeconds, 0));
            }

            else
                get_TimeSpan = TimeSpan.FromSeconds(Math.Round(DateTime.Parse(set_Session_Information["Session_Ended_DateTime"].ToString()).Subtract(DateTime.Now).TotalSeconds, 0));            
            
            if (get_TimeSpan.TotalSeconds <= 0)            
                get_TimeSpan = new TimeSpan();

            if (!ReferenceEquals(Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name], null))
            {
                Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();
            }

            Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Show();

            set_Time_Remaining(set_FrontEnd_Main, get_TimeSpan, set_Session_Information["Customer_UserName"].ToString());

            Thread.Sleep(500);

            if (set_Session_Information["Session_Action_Last"].ToString() == "Time Pause")
            {
                set_Time_Pause(set_FrontEnd_Main);
            }

            else if (set_Session_Information["Session_Action_Last"].ToString() == "Computer Lock")
            {
                set_Computer_Lock(set_FrontEnd_Main);
            }

        }

        public static void set_Computer_Lock(MythicalCafe_FrontEnd_Main set_Main)
        {
            set_Main.Hide();

            Main_Thread_Dictionary["Lock Screen"] = new Thread(delegate ()
            {
                new MythicalCafe_FrontEnd_LockScreen("Computer Lock").ShowDialog();

                Main_Thread_Dictionary["Lock Screen"].Abort();
            });

            Main_Thread_Dictionary["Lock Screen"].Start();
        }

        public static void set_Computer_Unlock(MythicalCafe_FrontEnd_Main set_Main)
        {
            set_Main.Show();

            if (!ReferenceEquals(Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name], null))
            {
                Application.OpenForms[new MythicalCafe_FrontEnd_Login("").Name].Close();
                Application.OpenForms[new MythicalCafe_FrontEnd_LockScreen("").Name].Close();
            }
        }

        public static Boolean set_RadioFrequency_Identification_Status(String set_Action)
        {            
            if (set_Action == "Lock ID")
                if (MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Lock I.D'}"))
                {
                    Customer_Information.Merge(JObject.Parse("{ 'Customer_RadioFrequency_Identification_Status' : 'Inactive' }"));
                    return true;
                }

                else
                {
                    new MythicalCafe_FrontEnd_Dialog("Message: Cannot End the Session because there is no Connection, ask the Staff.").ShowDialog();

                    return false;
                }

            else            
                if (MythicalCafe_FrontEnd_Workstation_Server.set_Socket_Packet("{ 'Action' : 'Unlock I.D'}"))
                {
                    Customer_Information.Merge(JObject.Parse("{ 'Customer_RadioFrequency_Identification_Status' : 'Active' }"));
                    return true;
                }

                else
                {
                    new MythicalCafe_FrontEnd_Dialog("Message: Cannot End the Session because there is no Connection, ask the Staff.").ShowDialog();

                    return false;
                }
            

        }


        public static void check_Session_Availability()
        {
            if (!String.IsNullOrEmpty(Session_Identity))
                set_Session_End();
        }

        public static void set_Dispose_Object()
        {
            Thread get_Thread = new Thread(delegate ()
            {
                while (true)
                {
                    GC.Collect();

                    GC.WaitForPendingFinalizers();

                    Thread.Sleep(1000);
                }
            });

            get_Thread.Start();
        }
    }
}
