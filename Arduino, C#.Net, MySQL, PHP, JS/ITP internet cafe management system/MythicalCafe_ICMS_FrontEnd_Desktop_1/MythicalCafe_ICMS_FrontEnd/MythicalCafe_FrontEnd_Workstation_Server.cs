using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public static class MythicalCafe_FrontEnd_Workstation_Server
    {
        /*
                                                        _____                  _             _                                                
                                                       / ____|                | |           | |                                               
          ______   ______   ______   ______   ______  | (___     ___     ___  | | __   ___  | |_   ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______|  \___ \   / _ \   / __| | |/ /  / _ \ | __| |______| |______| |______| |______| |______|
                                                       ____) | | (_) | | (__  |   <  |  __/ | |_                                              
                                                      |_____/   \___/   \___| |_|\_\  \___|  \__|                                             
                                                                                                                                      
                                                                                                                                      
        */

        static IPEndPoint IPEndPoint = null;

        public static Socket Socket = null;

        public static void set_Socket_Server_Configuration()
        {
            IPEndPoint = new IPEndPoint(IPAddress.Parse(MythicalCafe_FrontEnd_Main_Method.Server_InternetProtocol_Address), 666);

            Socket = new Socket(get_IPAddress().AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                Socket.Connect(IPEndPoint);
            }
            catch (Exception set_Exception)
            {
                Console.WriteLine(set_Exception.ToString());
            }
        }

        static dynamic get_IPAddress()
        {
            IPHostEntry get_IPHostEntry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress set_IPAddress in get_IPHostEntry.AddressList)
            {
                if (set_IPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return set_IPAddress;
                }
            }

            return false;
        }

        public static Boolean check_Socket_Connection(Socket set_Socket)
        {
            try
            {
                if (set_Socket_Packet(" "))
                    return true;

                else                
                    return false;
                
            }

            catch (Exception set_Exception)
            {
                Console.WriteLine(set_Exception.ToString());
                return false;
            }
        }

        public static String get_Socket_Packet(Socket set_Socket)
        {
            Byte[] get_Packet_Byte = new Byte[2048];

            try
            {
                return Encoding.ASCII.GetString(get_Packet_Byte, 0, set_Socket.Receive(get_Packet_Byte));
            }
            catch { return ""; }

        }

        public static Boolean set_Socket_Packet(String set_Socket_Packet)
        {
            Byte[] get_Socket_Packet = Encoding.ASCII.GetBytes(set_Socket_Packet);

            if (!ReferenceEquals(Socket, null))
            {
                try
                {
                    Socket.Send(get_Socket_Packet);                    
                    return true;
                }

                catch { return false; }

            }

            else
                return false;
        }

        static JObject Action_Information = null;
        public static void get_Socket_Interaction(String set_Action_Information)
        {            
            try { Action_Information = JObject.Parse(set_Action_Information); }

            catch { Action_Information = null; return; }
            
            if (Action_Information["Action"].ToString() == "Time Custom")                            
                MythicalCafe_FrontEnd_Main_Method.set_Time_Custom(set_Action_Information, Socket);
            

            else if (Action_Information["Action"].ToString() == "Time Bonus")            
                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
            

            else if (Action_Information["Action"].ToString() == "Time Add")            
                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
            

            else if (Action_Information["Action"].ToString() == "Time Pause")
            {
                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
            }

            else if (Action_Information["Action"].ToString() == "Time Unpause")            
                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
            

            else if (Action_Information["Action"].ToString() == "Client Message")            
                new MythicalCafe_FrontEnd_Dialog("Message: " + Action_Information["Message"].ToString()) { TopMost = true }.ShowDialog();
            

            else if (Action_Information["Action"].ToString() == "Session Start")            
                MythicalCafe_FrontEnd_Main_Method.get_Session_Start(set_Action_Information, Socket);
            

            else if (Action_Information["Action"].ToString() == "Session End")            
                MythicalCafe_FrontEnd_Main_Method.set_Session_End();
            

            else if (Action_Information["Action"].ToString() == "Account Use")
            {
                MythicalCafe_FrontEnd_Main_Method.Customer_Information = Action_Information;               
                
                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
                
            }

            else if (Action_Information["Action"].ToString() == "Computer Lock" || Action_Information["Action"].ToString() == "Computer Unlock")            
                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).set_Client_Action(set_Action_Information);
            
            
            else if (Action_Information["Action"].ToString() == "No Session")            
                MythicalCafe_FrontEnd_Main_Method.check_Session_Availability();
            

            else if (Action_Information["Action"].ToString() == "System Configuration")
            {
                MythicalCafe_FrontEnd_Main_Method.Time_Rate = Action_Information["Time Rate"].ToString();
                MythicalCafe_FrontEnd_Main_Method.Time_Warning = Action_Information["Time Warning"].ToString();
                MythicalCafe_FrontEnd_Main_Method.set_Time_Warning();
            }
        }

    }
}
