using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_Main_Method
    {
        /*
                                                        _____    ____    _                                                   
                                                       / ____|  / __ \  | |                                                  
          ______   ______   ______   ______   ______  | (___   | |  | | | |       ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______|  \___ \  | |  | | | |      |______| |______| |______| |______| |______|
                                                       ____) | | |__| | | |____                                              
                                                      |_____/   \___\_\ |______|                                             


        */

        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        static MySqlCommand MySqlCommand = new MySqlCommand();
        static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        static DataTable Main_DataTable_1 = new DataTable();

        public static String Table_Name_1 = "tbl_customer_personal_information";
        public static String Table_Name_2 = "tbl_customer_credential_information";
        public static String Table_Name_3 = "tbl_customer_property_information";
        public static String Table_Name_4 = "tbl_workstation_session_information";
        public static String Table_Name_5 = "tbl_counter_information";
        public static String Table_Name_6 = "tbl_product_information";
        public static String Table_Name_7 = "tbl_product_category_information";
        public static String Table_Name_8 = "tbl_product_order_information";
        public static String Table_Name_9 = "tbl_user_log_information";
        public static String Table_Name_10 = "tbl_staff_information";
        public static String Table_Name_11 = "tbl_product_report_information";
        public static String Table_Name_12 = "tbl_staff_attendance_information";
        public static String Table_Name_13 = "tbl_workstation_session_report_information";
        public static String Table_Name_14 = "tbl_customer_report_information";
        
        public static String Branch_Identity = null;

        public static String Customer_Identity_Code = "CSTMR";
        public static String Session_Identity_Code = "SSSN";
        public static String Guest_Identity_Code = "GST";
        public static String Product_Identity_Code = "PRDCT";
        public static String Product_Category_Identity_Code = "CTGRY";
        public static String Product_Order_Identity_Code = "RDR";
        public static String Log_Identity_Code = "LG";
        public static String Staff_Identity_Code = "STFF";
        public static String Report_Identity_Code = "RPRT";
        public static String Attendance_Identity_Code = "TTNDNC";

        public static String Image_Directory_Path = "Images";

        public static void check_Directory_Availability(String set_Directory_Path)
        {
            if (!Directory.Exists(set_Directory_Path))
            {
                Directory.CreateDirectory(Image_Directory_Path);
            }
        }

        public static Int32 get_Current_Identity_Count(String get_Counter_Code)
        {
            Int32 get_Return_Value = 0;

            Main_DataTable_1.Rows.Clear();
            Main_DataTable_1.Columns.Clear();

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();
            MySqlCommand.CommandText = "SELECT Counter_Count FROM " + Table_Name_5 + " WHERE Counter_Code = '" + get_Counter_Code + "' AND Branch_ID = '" + Branch_Identity + "';";
            MySqlCommand.ExecuteNonQuery();

            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);

            MySqlDataAdapter.Fill(Main_DataTable_1);

            if (Main_DataTable_1.Rows.Count != 0)
            {
                DataRow get_DataRow = Main_DataTable_1.Rows[0];

                get_Return_Value = Convert.ToInt32(get_DataRow["Counter_Count"]);
            }

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void set_Current_Identity_Count(String get_Counter_Code)
        {

            Main_DataTable_1.Rows.Clear();
            Main_DataTable_1.Columns.Clear();

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();
            MySqlCommand.CommandText = "UPDATE " + Table_Name_5 + " SET Counter_Count = Counter_Count + 1 WHERE Counter_Code = '" + get_Counter_Code + "' AND Branch_ID = '" + Branch_Identity + "';";
            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        /*
                                                        ____    _______   _    _   ______   _____                                               
                                                       / __ \  |__   __| | |  | | |  ____| |  __ \                                              
          ______   ______   ______   ______   ______  | |  | |    | |    | |__| | | |__    | |__) |  ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______| | |  | |    | |    |  __  | |  __|   |  _  /  |______| |______| |______| |______| |______|
                                                      | |__| |    | |    | |  | | | |____  | | \ \                                              
                                                       \____/     |_|    |_|  |_| |______| |_|  \_\                                             


        */

        public enum EventType
        {
            Inserted = 2,
            Removed = 3
        }

        public static void qweXD()
        {
            ManagementEventWatcher watcher = new ManagementEventWatcher();
            WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2 or EventType = 3");

            watcher.EventArrived += (s, e) =>
            {
                string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
                EventType eventType = (EventType)(Convert.ToInt16(e.NewEvent.Properties["EventType"].Value));

                string eventName = Enum.GetName(typeof(EventType), eventType);


                new MythicalCafe_BackEnd_Dialog("Message: " + DateTime.Now.ToShortDateString() + " " + driveName + " " + eventName).ShowDialog();
            };

            watcher.Query = query;
            watcher.Start();
        }

        public static String Configuration_information_File_Path = "configuration_information.xml";

        public static String RadioFrequency_Port_Name = null;
        public static String RadioFrequency_Status = null;

        public static String ShortMessageService_Port_Name = null;
        public static String ShortMessageService_Status = null;

        public static String Time_Rate = null;

        public static String Time_Warning = null;

        public static String Server_InternetProtocol_Address = null;
        public static String SQL_InternetProtocol_Address = null;

        public static String Staff_Rate = null;

        public static String Staff_Identity = null;
        public static String Staff_Username = null;
        public static String Staff_FullName = null;
        public static String Staff_Position = null;

        static String Workstation_Action_Privilege = "Workstation_View, Workstation_Insert, Workstation_Update, Workstation_Delete, Workstation_Maintenance, Workstation_Log_View, Workstation_Log_Print";
        static String Product_Action_Privilege = "Product_View, Product_Insert, Product_Update, Product_Delete, Product_Order_Queue_View, Product_Order_Queue_Accept, Product_Order_Queue_Decline, Product_Category_View, Product_Category_Insert, Product_Category_Update, Product_Category_Delete, Product_Log_View, Product_Log_Print";
        static String Account_Action_Privilege = "Account_Super_Admin_View, Account_Super_Admin_Insert, Account_Super_Admin_Update, Account_Super_Admin_Delete, Account_Admin_View, Account_Admin_Insert, Account_Admin_Update, Account_Admin_Delete, Account_Staff_View, Account_Staff_Insert, Account_Staff_Update, Account_Staff_Delete, Account_Position, Account_Log_View, Account_Log_Print, Account_Statistics";
        static String Setting_Action_Privilege = "Setting_Screen_Resolution, Setting_RadioFrequency_Port, Setting_RadioFrequency_Status, Setting_ShortMessageService_Port, Setting_ShortMessageService_Status, Setting_Computer_Rate, Setting_Time_Warning_View, Setting_Time_Warning_Insert, Setting_Time_Warning_Update, Setting_Time_Warning_Delete";

        public static List<String> Super_Admin_Privilege_List = new List<String>();
        public static List<String> Admin_Privilege_List = new List<String>();
        public static List<String> Staff_Privilege_List = new List<String>();

        public static List<String> Staff_Position_Privilege = new List<String>();

        public static Dictionary<String, List<String>> Staff_Position_Dictionary = new Dictionary<String, List<String>>();

        public static Boolean get_Staff_Position_Information(String set_Staff_Identity, String set_Username, String set_Password)
        {
            dynamic get_Staff_Information = null;

            if (String.IsNullOrEmpty(set_Staff_Identity))
                get_Staff_Information = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information("Select : Specific : Username and Password", "", set_Username, set_Password, "");

            else
                get_Staff_Information = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Information("Select : Specific", set_Staff_Identity, "", "", "");


            if (get_Staff_Information is Boolean)
            {
                if (!get_Staff_Information)
                    return false;

                else
                    return true;
            }

            else
            {
                JObject get_JObject = JObject.Parse(JObject.Parse(get_Staff_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                Staff_Username = get_JObject["Staff_UserName"].ToString();
                Staff_Position = get_JObject["Staff_Position"].ToString();
                Staff_FullName = get_JObject["Staff_FullName"].ToString();

                if (!get_JObject["Staff_Identity"].ToString().Contains("-" + Branch_Identity + "-"))
                {
                    new MythicalCafe_BackEnd_Dialog("Message: This Staff is belong to another Branch.").ShowDialog();

                    return false;
                }

                if (String.IsNullOrEmpty(set_Staff_Identity))
                {
                    dynamic get_Staff_Attendance_Information = MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.select_Staff_Attendance_Information
                    (
                        "Select : Specific { Attendance_Status }",
                        "",
                        get_JObject["Staff_Identity"].ToString(),
                        null
                    );

                    if (get_Staff_Attendance_Information is Boolean)
                    {
                        if (!get_Staff_Attendance_Information)
                            if (MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.insert_Staff_Attendance_Information(get_JObject["Staff_Identity"].ToString()))
                            {
                                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                                (
                                    "Account",
                                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                    get_JObject["Staff_Identity"].ToString(),
                                    "Time In"
                                );

                                new MythicalCafe_BackEnd_Dialog("Message: Time In: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).ShowDialog();

                            }
                    }

                    else
                    {
                        get_Staff_Attendance_Information = JObject.Parse(JObject.Parse(get_Staff_Attendance_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));
                        
                        if (get_Staff_Attendance_Information["Attendance_Status"].ToString() == "Time Out")
                        {
                            new MythicalCafe_BackEnd_Dialog("Message: You already check out for this day.").ShowDialog();

                            return false;
                        }
                    }
                    
                }

                foreach (String set_String in Staff_Position_Dictionary[get_JObject["Staff_Position"].ToString()])
                    Staff_Position_Privilege.Add(set_String.Trim());

                update_System_Configuration("Update : Specific : Staff_Identity", get_JObject["Staff_Identity"].ToString());

                foreach (String set_String in Staff_Position_Dictionary["Super Admin"])
                    Super_Admin_Privilege_List.Add(set_String.Trim());

                foreach (String set_String in Staff_Position_Dictionary["Admin"])
                    Admin_Privilege_List.Add(set_String.Trim());

                foreach (String set_String in Staff_Position_Dictionary["Staff"])
                    Staff_Privilege_List.Add(set_String.Trim());

                return true;
            }
        }

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

                get_XElement.Add(new XElement("RadioFrequency_Port_Name", "COM3"));
                get_XElement.Add(new XElement("RadioFrequency_Status", "Disable"));

                get_XElement.Add(new XElement("ShortMessageService_Port_Name", "COM8"));
                get_XElement.Add(new XElement("ShortMessageService_Status", "Disable"));

                get_XElement.Add(new XElement("Time_Rate", "20"));
                get_XElement.Add(new XElement("Time_Warning", "300=TimeKana Extend Kapa?*,*600=Mag ta-time kana hehe.*,*900=Extend Kapa Boi?*,*"));

                get_XElement.Add(new XElement("Server_InternetProtocol_Address", "192.168.1.106"));
                get_XElement.Add(new XElement("SQL_InternetProtocol_Address", "192.168.1.106"));

                get_XElement.Add(new XElement("Staff_Identity", ""));

                get_XElement.Add(new XElement("Staff_Rate", "40"));                

                String get_SuperAdmin_Position__Privilege = Workstation_Action_Privilege + ", " + Product_Action_Privilege + ", " + Account_Action_Privilege + ", " + Setting_Action_Privilege;
                String get_Admin_Position__Privilege = get_SuperAdmin_Position__Privilege;
                String get_Staff_Position__Privilege = "";

                get_XElement.Add(new XElement("Staff_Position", "Super Admin*Admin*Staff"));
                get_XElement.Add(new XElement("Staff_Privilege", get_SuperAdmin_Position__Privilege + "*" + get_Admin_Position__Privilege + "*" + get_Staff_Position__Privilege + "*"));

                get_XDocument.Add(get_XElement);
                get_XDocument.Save(Configuration_information_File_Path);
            }

            get_XDocument = XDocument.Load(Configuration_information_File_Path);

            Branch_Identity = get_XDocument.Descendants("Branch_Identity").FirstOrDefault().Value.ToString();
            RadioFrequency_Port_Name = get_XDocument.Descendants("RadioFrequency_Port_Name").FirstOrDefault().Value.ToString();
            RadioFrequency_Status = get_XDocument.Descendants("RadioFrequency_Status").FirstOrDefault().Value.ToString();

            ShortMessageService_Port_Name = get_XDocument.Descendants("ShortMessageService_Port_Name").FirstOrDefault().Value.ToString();
            ShortMessageService_Status = get_XDocument.Descendants("ShortMessageService_Status").FirstOrDefault().Value.ToString();

            Time_Rate = get_XDocument.Descendants("Time_Rate").FirstOrDefault().Value.ToString();

            Time_Warning = get_XDocument.Descendants("Time_Warning").FirstOrDefault().Value.ToString();

            Server_InternetProtocol_Address = get_XDocument.Descendants("Server_InternetProtocol_Address").FirstOrDefault().Value.ToString();
            SQL_InternetProtocol_Address = get_XDocument.Descendants("SQL_InternetProtocol_Address").FirstOrDefault().Value.ToString();

            Staff_Identity = get_XDocument.Descendants("Staff_Identity").FirstOrDefault().Value.ToString();

            Staff_Rate = get_XDocument.Descendants("Staff_Rate").FirstOrDefault().Value.ToString();

            get_Staff_Position_Privilege_Information(get_XDocument);
        }

        static void get_Staff_Position_Privilege_Information(XDocument set_XDocument)
        {
            List<String> get_Staff_Position = set_XDocument.Descendants("Staff_Position").FirstOrDefault().Value.ToString().Split('*').ToList();
            List<String> get_Staff_Privilege = set_XDocument.Descendants("Staff_Privilege").FirstOrDefault().Value.ToString().Split('*').ToList();

            Int32 Counter = 0;

            Staff_Position_Dictionary.Clear();

            foreach (String set_String in get_Staff_Position)
            {
                Staff_Position_Dictionary.Add(get_Staff_Position[Counter], get_Staff_Privilege[Counter].Split(',').ToList());

                Counter++;
            }
        }

        public static void update_System_Configuration(String set_Action, String set_Action_Value)
        {
            XDocument get_XDocument = XDocument.Load(Configuration_information_File_Path);

            if (set_Action == "Update : Specific : Radio Frequency Port Name")
            {
                get_XDocument.Descendants("RadioFrequency_Port_Name").FirstOrDefault().Value = set_Action_Value;

                RadioFrequency_Port_Name = set_Action_Value;

                MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();
            }

            else if (set_Action == "Update : Specific : Short Message Service Port Name")
            {
                get_XDocument.Descendants("ShortMessageService_Port_Name").FirstOrDefault().Value = set_Action_Value;

                ShortMessageService_Port_Name = set_Action_Value;

                MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_SerialPort_Configuration();
            }

            else if (set_Action == "Update : Specific : Time Rate")
            {
                get_XDocument.Descendants("Time_Rate").FirstOrDefault().Value = set_Action_Value;

                Time_Rate = set_Action_Value;

                foreach (KeyValuePair<String, MythicalCafe_BackEnd_Workstation_Client> set_KeyValuePair in MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary)
                {
                    set_KeyValuePair.Value.set_Configuration(Time_Rate, Time_Warning);
                }
            }

            else if (set_Action == "Update : Specific : Staff_Rate")
            {
                get_XDocument.Descendants("Staff_Rate").FirstOrDefault().Value = set_Action_Value;

                Staff_Rate = set_Action_Value;
            }

            else if (set_Action == "Update : Specific : Radio Frequency Status")
            {
                get_XDocument.Descendants("RadioFrequency_Status").FirstOrDefault().Value = set_Action_Value;

                RadioFrequency_Status = set_Action_Value;
            }

            else if (set_Action == "Update : Specific : Short Message Service Status")
            {
                get_XDocument.Descendants("ShortMessageService_Status").FirstOrDefault().Value = set_Action_Value;

                ShortMessageService_Status = set_Action_Value;
            }

            else if (set_Action == "Update : Specific : Time Warning")
            {
                get_XDocument.Descendants("Time_Warning").FirstOrDefault().Value = set_Action_Value;

                Time_Warning = set_Action_Value;

                foreach (KeyValuePair<String, MythicalCafe_BackEnd_Workstation_Client> set_KeyValuePair in MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary)
                {
                    set_KeyValuePair.Value.set_Configuration(Time_Rate, Time_Warning);
                }
            }

            else if (set_Action == "Update : Specific : Staff_Identity")
            {
                get_XDocument.Descendants("Staff_Identity").FirstOrDefault().Value = set_Action_Value;

                Staff_Identity = set_Action_Value;
            }

            else if (set_Action == "Update : Specific : Staff_Privilege")
            {
                get_XDocument.Descendants("Staff_Privilege").FirstOrDefault().Value = set_Action_Value;

                get_Staff_Position_Privilege_Information(get_XDocument);
            }

            else
                return;

            get_XDocument.Save(Configuration_information_File_Path);
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
        
        public static void check_Customer_Credential_Information(JObject set_Action_Information, MythicalCafe_BackEnd_Workstation_Client set_Workstation_Client)
        {
            dynamic get_Customer_Credential_Information = false;

            String get_Action = null;

            if (ReferenceEquals(set_Action_Information["Radio Frequency Identification"], null))
            {
                get_Customer_Credential_Information = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Credential_Information
                (

                    "Select : Specific : Username and Password",
                    set_Action_Information,
                    null,
                    null
                );


                get_Action = "Select : Specific : Username and Password";
            }

            else
            {
                get_Customer_Credential_Information = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Credential_Information
                (

                    "Select : Specific : Radio Frequency Identification",
                    set_Action_Information,
                    null,
                    null
                );

                get_Action = "Select : Specific : Radio Frequency Identification";
            }


            if (get_Customer_Credential_Information is Boolean)
            {
                if (!get_Customer_Credential_Information)
                {
                    set_Workstation_Client.set_Client_Message("Please Try Again.");
                }
            }

            else
            {
                get_Customer_Credential_Information = JObject.Parse(JObject.Parse(get_Customer_Credential_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                
                if (get_Action == "Select : Specific : Radio Frequency Identification" && get_Customer_Credential_Information["Customer_RadioFrequency_Identification_Status"] == "Inactive")
                {
                    set_Workstation_Client.set_Client_Message("Your Card is inactive and cannot be use.");
                    return;
                }

                check_Customer_Property_Information(get_Customer_Credential_Information, set_Workstation_Client, get_Action);

                //set_Workstation_Client.set_Client_Message("Success");
            }
        }

        public static void check_Customer_Property_Information(JObject set_Action_Information, MythicalCafe_BackEnd_Workstation_Client set_Workstation_Client, String set_Action)
        {
            JObject get_Customer_Property_Information = JObject.Parse((JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information("Select : Specific", set_Action_Information["Customer_Identity"].ToString())))["Table"].ToString().TrimStart('[').TrimEnd(']'));

            if (get_Customer_Property_Information["Time_Bonus"].ToString() != "0" || get_Customer_Property_Information["Time_Remaining"].ToString() != "0")
            {
                //new MythicalCafe_BackEnd_Dialog("Message: Remaining Time: " + TimeSpan.FromSeconds(Convert.ToDouble(get_Customer_Property_Information["Time_Bonus"]) + Convert.ToDouble(get_Customer_Property_Information["Time_Remaining"])).ToString()).ShowDialog();
                set_Session_Account_Use(get_Customer_Property_Information["Customer_Identity"].ToString(), set_Workstation_Client.Identity, set_Action);
            }

            else
                set_Workstation_Client.set_Client_Message("Sorry insufficient Time.");
        }

        /*
                                                        _____   ______    _____    _____   _____    ____    _   _                                              
                                                       / ____| |  ____|  / ____|  / ____| |_   _|  / __ \  | \ | |                                             
          ______   ______   ______   ______   ______  | (___   | |__    | (___   | (___     | |   | |  | | |  \| |  ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______|  \___ \  |  __|    \___ \   \___ \    | |   | |  | | | . ` | |______| |______| |______| |______| |______|
                                                       ____) | | |____   ____) |  ____) |  _| |_  | |__| | | |\  |                                             
                                                      |_____/  |______| |_____/  |_____/  |_____|  \____/  |_| \_|                                             
                                                                                                                                                       
        */

        public static void set_Session_Start(String set_Workstation_Identity)
        {
            MythicalCafe_BackEnd_Workstation_Method.insert_Session_Information
            (
                Session_Identity_Code + "-" + Branch_Identity + "-" + (get_Current_Identity_Count(Session_Identity_Code) + 1000).ToString(),
                set_Workstation_Identity,
                Guest_Identity_Code + "-" + Branch_Identity + "-" + (get_Current_Identity_Count(Guest_Identity_Code) + 1000).ToString(),
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                "",
                "",
                "0",
                "0",
                "Active",
                "Session Start"
            );

            set_Current_Identity_Count(Session_Identity_Code);
            set_Current_Identity_Count(Guest_Identity_Code);

                       


            MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(set_Workstation_Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

            get_UserControl_Workstation.set_Session_Information();
        }

        public static Boolean set_Session_End(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, DateTime Started_DateTime, DateTime Ended_DateTime)
        {
            Boolean get_Return_Value = false;

            String get_Time_Spent = "";

            //Session End
            if (Ended_DateTime == DateTime.MinValue)
                get_Time_Spent = TimeSpan.FromSeconds(Math.Round(DateTime.Now.Subtract(Started_DateTime).TotalSeconds, 0)).TotalSeconds.ToString();

            //Time Out
            else if (TimeSpan.Parse(set_UserControl_Workstation.Time_Remaining).TotalSeconds == 0)
                get_Time_Spent = TimeSpan.FromSeconds(Math.Round(Ended_DateTime.Subtract(Started_DateTime).TotalSeconds, 0)).TotalSeconds.ToString();

            //Custom Time End
            else
                get_Time_Spent = TimeSpan.FromSeconds(Math.Round(DateTime.Now.Subtract(Started_DateTime).TotalSeconds, 0)).TotalSeconds.ToString();

            if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
            (
                "Update : Specific : Time Spent and Session Status",
                "Session_Identity",
                set_UserControl_Workstation.Session_Identity,
                "",
                "",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                get_Time_Spent,
                set_UserControl_Workstation.Workstation_Charge,
                "Inactive",
                ""
            ))
            {
                if (set_UserControl_Workstation.Username != "Guest")
                {
                    dynamic get_Session_Information = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information
                    (
                        "Select : Specific",
                        set_UserControl_Workstation.Customer_Identity
                    );

                    if (get_Session_Information is Boolean) { if (!get_Session_Information) get_Return_Value = false; }

                    else
                    {
                        get_Session_Information = JObject.Parse(JObject.Parse(get_Session_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                        Double get_Time_Bonus = Convert.ToDouble(get_Session_Information["Time_Bonus"]);
                        Double get_Time_Remaining = Convert.ToDouble(get_Session_Information["Time_Remaining"]);

                        if (Convert.ToDouble(get_Time_Spent) > get_Time_Bonus)
                        {
                            get_Time_Remaining -= Convert.ToDouble(get_Time_Spent) - get_Time_Bonus;

                            get_Time_Bonus = 0;
                        }

                        else
                            get_Time_Bonus -= Convert.ToDouble(get_Time_Spent);


                        MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Property_Information
                        (
                            "Update : Specific : Time Remaining and Time Bonus and Time Spent",
                            set_UserControl_Workstation.Customer_Identity,
                            get_Time_Remaining.ToString(),
                            get_Time_Bonus.ToString(),
                            get_Time_Spent,
                            "",
                            "",
                            "",
                            "",
                            "",
                            ""
                        );


                        get_Return_Value = true;
                    }
                }                   
                 
                JObject get_JObject = JObject.Parse(MythicalCafe_BackEnd_Workstation_Method.select_Session_Information("Select : Specific", "Session_Identity", set_UserControl_Workstation.Session_Identity));

                get_JObject = JObject.Parse(get_JObject["Table"].ToString().TrimStart('[').TrimEnd(']'));

                MythicalCafe_BackEnd_Workstation_Method.insert_Session_Report_Information
                (
                    get_JObject["Session_Identity"].ToString(),
                    get_JObject["User_Identity"].ToString(),
                    get_JObject["Cash_Spent"].ToString(),
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                );


                set_UserControl_Workstation.Session_Identity = null;
                set_UserControl_Workstation.set_Control_Default_Value();
                set_UserControl_Workstation.set_Session_Information();
                get_Return_Value = true;
            }


            return get_Return_Value;
        }

        public static void set_Session_Time_Custom(String set_Worstation_Identity, TimeSpan set_TimeSpan, Double set_Cash_Spent)
        {
            MythicalCafe_BackEnd_Workstation_Method.insert_Session_Information
            (
                Session_Identity_Code + "-" + Branch_Identity + "-" + (get_Current_Identity_Count(Session_Identity_Code) + 1000).ToString(),
                set_Worstation_Identity,
                Guest_Identity_Code + "-" + Branch_Identity + "-" + (get_Current_Identity_Count(Guest_Identity_Code) + 1000).ToString(),
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                "",
                DateTime.Now.Add(set_TimeSpan).ToString("yyyy-MM-dd HH:mm:ss"),
                "0",
                set_Cash_Spent.ToString(),
                "Active",
                "Time Custom"
            );

            set_Current_Identity_Count(Session_Identity_Code);
            set_Current_Identity_Count(Guest_Identity_Code);

            MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(set_Worstation_Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

            get_UserControl_Workstation.set_Session_Information();
        }

        public static Boolean set_Session_Time_Pause(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, DateTime Started_DateTime, DateTime Ended_DateTime)
        {
            Boolean get_Return_Value = false;

            String get_Time_Spent = "";

            //Pause Open Time
            if (Ended_DateTime == DateTime.MinValue)
            {
                get_Time_Spent = TimeSpan.Parse(set_UserControl_Workstation.Time_Duration).TotalSeconds.ToString();

                if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Time Spent and Session Action and LastPaused DateTime",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    "",
                    get_Time_Spent,
                    set_UserControl_Workstation.Workstation_Charge,
                    "",
                    "Time Pause"
                ))
                {
                    set_UserControl_Workstation.set_Control_Default_Value();
                    set_UserControl_Workstation.set_Session_Information();

                    get_Return_Value = true;
                }

                else
                    get_Return_Value = false;
            }

            //Pause Custom Time
            else
            {
                if (TimeSpan.Parse(set_UserControl_Workstation.Time_Remaining).TotalSeconds <= 0)
                {
                    new MythicalCafe_BackEnd_Dialog("Message: Can`t Pause the Time. :( ").ShowDialog();
                    get_Return_Value = false;
                }
                //get_Time_Spent = TimeSpan.FromSeconds(Math.Round(DateTime.Now.Subtract(Started_DateTime).TotalSeconds, 0)).TotalSeconds.ToString();


                else if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Time Spent and Session Action and LastPaused DateTime",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    "",
                    "",
                    set_UserControl_Workstation.Workstation_Charge,
                    "",
                    "Time Pause"
                ))
                {
                    set_UserControl_Workstation.set_Control_Default_Value();
                    set_UserControl_Workstation.set_Session_Information();

                    get_Return_Value = true;
                }
            }

            return get_Return_Value;
        }

        public static Boolean set_Session_Time_Unpause
        (
            MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation,
            DateTime set_Started_DateTime,
            DateTime set_LastPaused_DateTime,
            DateTime set_Ended_DateTime)
        {
            Boolean get_Return_Value = false;

            //DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            String get_Time_Spent = TimeSpan.FromSeconds(Math.Round(DateTime.Now.Subtract(set_Started_DateTime).TotalSeconds, 0)).TotalSeconds.ToString();

            DateTime get_Ended_DateTime = DateTime.Now.Add(set_Ended_DateTime.Subtract(set_Started_DateTime).Subtract(set_LastPaused_DateTime.Subtract(set_Started_DateTime)));

            if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Date Time Ended and Session Action",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    "",
                    get_Ended_DateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    "",
                    set_UserControl_Workstation.Workstation_Charge,
                    "",
                    "Time Unpause"
                ))
            {
                set_UserControl_Workstation.set_Control_Default_Value();
                set_UserControl_Workstation.set_Session_Information();

                get_Return_Value = true;
            }

            else
                get_Return_Value = false;

            return get_Return_Value;
        }

        public static Boolean set_Session_Time_Bonus(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan, DateTime set_Ended_DateTime)
        {
            Boolean get_Return_Value = false;

            DateTime get_Ended_DateTime;

            if (DateTime.Now >= set_Ended_DateTime)
                get_Ended_DateTime = DateTime.Now.Add(set_TimeSpan);

            else
                get_Ended_DateTime = set_Ended_DateTime.Add(set_TimeSpan);

            if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Date Time Ended",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    "",
                    get_Ended_DateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    "",
                    "",
                    "",
                    ""
                ))
            {
                set_UserControl_Workstation.set_Control_Default_Value();
                set_UserControl_Workstation.set_Session_Information();
                get_Return_Value = true;
            }

            else
                get_Return_Value = false;

            return get_Return_Value;
        }

        public static void check_Workstation_Session(MythicalCafe_BackEnd_Workstation_Client set_Workstation_Client, String set_Workstation_Identity)
        {
            dynamic get_Session_Information = MythicalCafe_BackEnd_Workstation_Method.select_Session_Information("Select : Specific : Active", "Workstation_Identity", set_Workstation_Identity);

            if (get_Session_Information is Boolean)
            {
                if (!get_Session_Information)
                {
                    return;
                }
            }

            else
            {
                get_Session_Information = JObject.Parse(JObject.Parse(get_Session_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                set_Workstation_Client.Session_Identity = get_Session_Information["Session_Identity"].ToString();

                if (get_Session_Information["User_Identity"].ToString().Contains("CSTMR"))
                {
                    set_Workstation_Client.set_Account_Use(get_Customer_Information(get_Session_Information["User_Identity"].ToString(), "Include : Session Information").ToString());
                }

                //Open Time Reconnection
                else if (Convert.ToDateTime(get_Session_Information["Session_Ended_DateTime"]) == DateTime.MinValue)
                {
                    DateTime Started_DateTime = Convert.ToDateTime(get_Session_Information["Session_Started_DateTime"].ToString());

                    String get_Time_Spent = TimeSpan.FromSeconds(Math.Round(DateTime.Now.Subtract(Started_DateTime).TotalSeconds, 0)).TotalSeconds.ToString();

                    if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                    (
                        "Update : Specific : Time Spent",
                        "Workstation_Identity",
                        set_Workstation_Client.Identity,
                        "",
                        "",
                        "",
                        get_Time_Spent,
                        "",
                        "",
                        ""
                    ))
                    {
                        get_Session_Information = JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Workstation_Method.select_Session_Information("Select : Specific : Active", "Workstation_Identity", set_Workstation_Client.Identity))["Table"].ToString().TrimStart('[').TrimEnd(']'));

                        set_Workstation_Client.set_Session_Start(TimeSpan.FromSeconds(Convert.ToDouble(get_Session_Information["Time_Spent"])));
                    }
                }

                //Custom Time and Account Reconnection
                else
                {
                    TimeSpan get_TimeSpan;
                    if (get_Session_Information["Session_Action_Last"].ToString() == "Time Pause")
                    {
                        DateTime LastPaused_DateTime = Convert.ToDateTime(get_Session_Information["Session_LastPaused_DateTime"]);
                        DateTime Ended_DateTime = Convert.ToDateTime(get_Session_Information["Session_Ended_DateTime"]);

                        get_TimeSpan = TimeSpan.FromSeconds(Math.Round(Ended_DateTime.Subtract(LastPaused_DateTime).TotalSeconds, 0));

                        set_Workstation_Client.set_Time_Custom(get_TimeSpan, Convert.ToDouble(get_Session_Information["Cash_Spent"]), get_Session_Information["Session_Action_Last"].ToString());

                    }

                    else
                    {
                        get_TimeSpan = TimeSpan.FromSeconds(Math.Round(DateTime.Parse(get_Session_Information["Session_Ended_DateTime"].ToString()).Subtract(DateTime.Now).TotalSeconds, 0));

                        if (get_TimeSpan.TotalSeconds <= 0)
                            get_TimeSpan = new TimeSpan();

                        set_Workstation_Client.set_Time_Custom(get_TimeSpan, Convert.ToDouble(get_Session_Information["Cash_Spent"]), get_Session_Information["Session_Action_Last"].ToString());

                    }
                }
            }

            get_Session_Information = null;

        }

        public static Boolean set_Session_Time_Add(String set_Action, MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan, DateTime set_Ended_DateTime, String set_Cash_Spent)
        {
            Boolean get_Return_Value = false;

            DateTime get_Ended_DateTime;

            if (DateTime.Now >= set_Ended_DateTime)
                get_Ended_DateTime = DateTime.Now.Add(set_TimeSpan);

            else
                get_Ended_DateTime = set_Ended_DateTime.Add(set_TimeSpan);

            if (set_UserControl_Workstation.Username != "Guest")
            {
                dynamic get_Session_Information = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information
                (
                    "Select : Specific",
                    set_UserControl_Workstation.Customer_Identity
                );

                if (get_Session_Information is Boolean) { if (!get_Session_Information) return false; }

                else
                {
                    get_Session_Information = JObject.Parse(JObject.Parse(get_Session_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                    if (Convert.ToDouble(get_Session_Information["Cash_Remaining"]) < Convert.ToDouble(set_Cash_Spent))
                    {
                        new MythicalCafe_BackEnd_Dialog("Message: Insufficient M-Cash").ShowDialog();

                        return false;
                        /*MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Insufficient M-Cash if you proceed, it will be added as Debt.");

                        if (get_Dialog.ShowDialog() == DialogResult.OK)
                        {
                            Double get_Expected_Debt_Remaining = Convert.ToDouble(get_Session_Information["Cash_Remaining"]) + Convert.ToDouble(get_Session_Information["Debt_Maximum"]) - Convert.ToDouble(get_Session_Information["Debt_Remaining"]) - Convert.ToDouble(set_Cash_Spent);

                            //MessageBox.Show(get_Session_Information["Cash_Remaining"].ToString() + "+ \n" +get_Session_Information["Debt_Maximum"].ToString() + "- \n" + get_Session_Information["Debt_Remaining"].ToString() + "- \n" + set_Cash_Spent + " \n =" + get_Expected_Debt_Remaining);

                            if (get_Expected_Debt_Remaining > Convert.ToDouble(get_Session_Information["Debt_Maximum"]) || get_Expected_Debt_Remaining < 0)
                            {
                                get_Dialog.get_Action("Message: Sorry but this user can only Debt up to " + get_Session_Information["Debt_Maximum"].ToString() + " only.");

                                if (get_Dialog.ShowDialog() == DialogResult.OK)
                                    return false;
                            }

                            else
                            {

                                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Property_Information
                                (
                                    "Update : Specific : Time Remaining and Cash Remaining and Cash Spent and Debt Remaining",
                                    set_UserControl_Workstation.Customer_Identity,
                                    set_TimeSpan.TotalSeconds.ToString(),
                                    "",
                                    "",
                                    "0",
                                    set_Cash_Spent,
                                    "",
                                    "",
                                    set_Cash_Spent,
                                    ""
                                );
                            }
                        }

                        else
                            return false;*/
                    }

                    else
                    {
                        MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Property_Information
                        (
                            "Update : Specific : Time Remaining and Cash Remaining and Cash Spent",
                            set_UserControl_Workstation.Customer_Identity,
                            set_TimeSpan.TotalSeconds.ToString(),
                            "",
                            "",
                            "",
                            set_Cash_Spent,
                            "",
                            "",
                            "",
                            ""
                        );

                        MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.insert_Customer_Report_Information(set_UserControl_Workstation.Customer_Identity, set_Cash_Spent, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    }
                }
            }

            if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Cash Spent and Date Time Ended",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    "",
                    get_Ended_DateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    "",
                    set_Cash_Spent,
                    "",
                    ""
                ))
            {


                set_UserControl_Workstation.set_Control_Default_Value();
                set_UserControl_Workstation.set_Session_Information();
                get_Return_Value = true;
            }

            else
                get_Return_Value = false;

            return get_Return_Value;
        }

        public static void set_Session_Account_Use(String set_Customer_Identity, String set_Workstation_Identity, String set_Action)
        {
            JObject get_Customer_Account_Information = get_Customer_Information(set_Customer_Identity, "");

            MythicalCafe_BackEnd_Workstation_Method.insert_Session_Information
            (
                Session_Identity_Code + "-" + Branch_Identity + "-" + (get_Current_Identity_Count(Session_Identity_Code) + 1000).ToString(),
                set_Workstation_Identity,
                get_Customer_Account_Information["Customer_Identity"].ToString(),
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                "",
                DateTime.Now.Add(TimeSpan.FromSeconds(Convert.ToDouble(get_Customer_Account_Information["Time_Bonus"]) + Convert.ToDouble(get_Customer_Account_Information["Time_Remaining"]))).ToString("yyyy-MM-dd HH:mm:ss"),
                "0",
                "",
                "Active",
                "Account Use"
            );

            if (set_Action == "Select : Specific : Radio Frequency Identification")
                MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_ShortMessageService_Message(get_Customer_Account_Information["Customer_ContactNumber"].ToString(), "Your Account has been Login using your Card at Branch: " + Branch_Identity + " Tracking ID: " + Session_Identity_Code + "-" + Branch_Identity + "-" + (get_Current_Identity_Count(Session_Identity_Code) + 1000).ToString());

            else if (set_Action == "Select : Specific : Radio Frequency Identification")
                MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_ShortMessageService_Message(get_Customer_Account_Information["Customer_ContactNumber"].ToString(), "Your Account has been Login at Branch: " + Branch_Identity);

            set_Current_Identity_Count(Session_Identity_Code);

            MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = Application.OpenForms[new MythicalCafe_BackEnd_Workstation().Name].Controls.Find(set_Workstation_Identity, true).FirstOrDefault() as MythicalCafe_BackEnd_UserControl_Workstation;

            get_UserControl_Workstation.set_Session_Information();
        }

        public static JObject get_Customer_Information(String set_Customer_Identity, String set_Action)
        {

            JObject get_Customer_Information = JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Credential_Information("Select : Specific", null, set_Customer_Identity, null))["Table"].ToString().TrimStart('[').TrimEnd(']'));

            get_Customer_Information.Merge(JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Personal_Information("Select : Specific", set_Customer_Identity))["Table"].ToString().TrimStart('[').TrimEnd(']')));

            get_Customer_Information["Customer_Image_Path"] = "{ 'Customer_Image_Path' : '//" + MythicalCafe_BackEnd_Workstation_Server.get_IPAddress().ToString() + "/" + get_Customer_Information["Customer_Image_Path"].ToString() + "' }";

            get_Customer_Information.Merge(JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information("Select : Specific", set_Customer_Identity))["Table"].ToString().TrimStart('[').TrimEnd(']')));

            if (set_Action == "Include : Session Information")
                get_Customer_Information.Merge(JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Workstation_Method.select_Session_Information("Select : Specific : Active", "User_Identity", set_Customer_Identity))["Table"].ToString().TrimStart('[').TrimEnd(']')));

            return get_Customer_Information;
        }

        public static Boolean set_Session_Computer_Lock(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            Boolean get_Return_Value = false;

            if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Session Action",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "Computer Lock"
                ))
            {
                set_UserControl_Workstation.Session_Action = "Computer Lock";

                get_Return_Value = true;
            }

            else
                get_Return_Value = false;

            return get_Return_Value;
        }

        public static Boolean set_Session_Computer_Unlock(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            Boolean get_Return_Value = false;

            if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Session Action",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "Computer Unlock"
                ))
            {
                set_UserControl_Workstation.Session_Action = "Computer Unlock";

                get_Return_Value = true;
            }

            else
                get_Return_Value = false;

            return get_Return_Value;
        }

        public static Boolean set_Session_Time_Extend(MythicalCafe_BackEnd_Workstation_Client set_Workstation_Client, MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan, DateTime set_Ended_DateTime)
        {
            Boolean get_Return_Value = false;

            DateTime get_Ended_DateTime;

            String Cash_Spent = Math.Round(set_TimeSpan.TotalSeconds / (3600 / Convert.ToDouble(MythicalCafe_BackEnd_Main_Method.Time_Rate)), 2).ToString();

            if (DateTime.Now >= set_Ended_DateTime)
                get_Ended_DateTime = DateTime.Now.Add(set_TimeSpan);

            else
                get_Ended_DateTime = set_Ended_DateTime.Add(set_TimeSpan);


            dynamic get_Session_Information = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information
            (
                "Select : Specific",
                set_UserControl_Workstation.Customer_Identity
            );

            if (get_Session_Information is Boolean) { if (!get_Session_Information) return false; }

            else
            {
                get_Session_Information = JObject.Parse(JObject.Parse(get_Session_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                if (Convert.ToDouble(get_Session_Information["Cash_Remaining"]) < Convert.ToDouble(Cash_Spent))
                {
                    set_Workstation_Client.set_Client_Message("Insufficient M-Cash");

                    return false;
                }

                else
                {
                    MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Property_Information
                    (
                        "Update : Specific : Time Remaining and Cash Remaining and Cash Spent",
                        set_UserControl_Workstation.Customer_Identity,
                        set_TimeSpan.TotalSeconds.ToString(),
                        "",
                        "",
                        "",
                        Cash_Spent,
                        "",
                        "",
                        "",
                        ""
                    );
                }
            }


            if (MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                (
                    "Update : Specific : Cash Spent and Date Time Ended",
                    "Session_Identity",
                    set_UserControl_Workstation.Session_Identity,
                    "",
                    "",
                    get_Ended_DateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    "",
                    Cash_Spent,
                    "",
                    ""
                ))
            {


                set_UserControl_Workstation.set_Control_Default_Value();
                set_UserControl_Workstation.set_Session_Information();

                set_Workstation_Client.set_Time_Extend(set_UserControl_Workstation, set_TimeSpan, Convert.ToDouble(Cash_Spent));

                get_Return_Value = true;

            }

            else
                get_Return_Value = false;

            return get_Return_Value;
        }

    }
}
