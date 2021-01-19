using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
    public static class MythicalCafe_BackEnd_Workstation_Server
    {

        /*
                                                        _____    ____     _____   _  __  ______   _______                                              
                                                       / ____|  / __ \   / ____| | |/ / |  ____| |__   __|                                             
          ______   ______   ______   ______   ______  | (___   | |  | | | |      | ' /  | |__       | |     ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______|  \___ \  | |  | | | |      |  <   |  __|      | |    |______| |______| |______| |______| |______|
                                                       ____) | | |__| | | |____  | . \  | |____     | |                                                
                                                      |_____/   \____/   \_____| |_|\_\ |______|    |_|                                                


        */

        public static IPEndPoint IPEndPoint;

        static Socket Socket_Server;

        public static void set_Socket_Server_Configuration()
        {
            IPEndPoint = new IPEndPoint(IPAddress.Parse(MythicalCafe_BackEnd_Main_Method.Server_InternetProtocol_Address), 666);
            
            Socket_Server = new Socket(IPAddress.Parse(MythicalCafe_BackEnd_Main_Method.Server_InternetProtocol_Address).AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            Socket_Server.Bind(IPEndPoint);

            Socket_Server.Listen(10);         

        }

        public static Socket set_Socket_Client_Configuration(String set_Workstation_Client_InternetProtocol)
        {
            try
            {
                Socket Socket_Client = new Socket(IPAddress.Parse(set_Workstation_Client_InternetProtocol).AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                Socket_Client = Socket_Server.Accept();

                if (set_Workstation_Client_InternetProtocol != (IPAddress.Parse(((IPEndPoint)Socket_Client.RemoteEndPoint).Address.ToString()).ToString()))
                    return null;

                else
                {
                    //MessageBox.Show("I am connected to " + IPAddress.Parse(((IPEndPoint)Socket_Client.RemoteEndPoint).Address.ToString()) + "on port number " + ((IPEndPoint)Socket_Client.RemoteEndPoint).Port.ToString());
                    return Socket_Client;
                }
            }
            catch
            {               
                return null;
            }

        }
            
        public static List<String> get_IPAddress_List()
        {
            IPHostEntry get_IPHostEntry = Dns.GetHostEntry(Dns.GetHostName());

            List<String> get_IPAddress = new List<String>();

            foreach (IPAddress set_IPAddress in get_IPHostEntry.AddressList)
            {
                if (set_IPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    get_IPAddress.Add(set_IPAddress.ToString());
                }                
            }

            return get_IPAddress;
        }

        public static dynamic get_IPAddress()
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
            return set_Socket_Packet(set_Socket, " ");
        }   

        public static dynamic get_Socket_Packet(Socket set_Socket)
        {
            Byte[] get_Packet_Byte = new Byte[2048];

            try
            {
                return Encoding.ASCII.GetString(get_Packet_Byte, 0, set_Socket.Receive(get_Packet_Byte));
            }

            catch { return ""; }

        }

        public static Boolean set_Socket_Packet(Socket set_Socket, String set_Socket_Packet)
        {
            Byte[] get_Socket_Packet = Encoding.ASCII.GetBytes(set_Socket_Packet);

            if (!ReferenceEquals(set_Socket, null))
            {
                try
                {
                    set_Socket.Send(get_Socket_Packet);

                    if (set_Socket.Poll(-1, SelectMode.SelectWrite))
                        return true;

                    else if (set_Socket.Poll(-1, SelectMode.SelectRead))
                        return true;

                    else if (set_Socket.Poll(-1, SelectMode.SelectError))
                        return true;

                    else
                        return false;
                }

                catch { return false; }
                                
            }

            else
                return false;
        }

        static JObject Action_Information = null;

        public static void get_Socket_Interaction(String set_Action, MythicalCafe_BackEnd_Workstation_Client set_Workstation_Client)
        {            
            try { Action_Information = JObject.Parse(set_Action); }

            catch { return; }

            set_Workstation_Client.get_Client_Action(Action_Information);

            Action_Information = null;
        }

        public static Dictionary<String, MythicalCafe_BackEnd_Workstation_Client> Workstation_Client_Dictionary = new Dictionary<String, MythicalCafe_BackEnd_Workstation_Client>();
        public static Dictionary<String, Thread> Workstation_Client_Thread_Dictionary = new Dictionary<String, Thread>();

        public static void set_Socket_Client_Configuration()
        {
            Workstation_Client_Dictionary.Clear();
            //Workstation_Client_Thread_Dictionary.Clear();    

            Thread get_Thread = new Thread(delegate () 
            {
                MythicalCafe_BackEnd_Workstation_Manage_List_Method.get_Workstation_Dictionary = MythicalCafe_BackEnd_Workstation_Manage_List_Method.select_Workstation_Information("Select : All", "");

                foreach (KeyValuePair<String, String> set_KeyValuePair in MythicalCafe_BackEnd_Workstation_Manage_List_Method.get_Workstation_Dictionary)
                {
                    JObject get_KeyValuePair_Value = JObject.Parse(set_KeyValuePair.Value);

                    Workstation_Client_Dictionary.Add(set_KeyValuePair.Key, new MythicalCafe_BackEnd_Workstation_Client(set_KeyValuePair.Key, get_KeyValuePair_Value["Workstation_Client_InternetProtocol"].ToString()));

                }

                Thread.CurrentThread.Abort();
            });

            get_Thread.Start();
            
        }        
    }
}
