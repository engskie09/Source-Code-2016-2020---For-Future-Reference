using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MythicalCafe_ICMS_BackEnd
{
    class MythicalCafe_BackEnd_Workstation_Manage_List_Method
    {
        public static Dictionary<String, String> get_Workstation_Dictionary;
        public static Dictionary<String, String> get_Workstation_Information_Dictionary = new Dictionary<String, String>();

        public static List<String> get_Workstation_Name = new List<String>();
        public static List<String> get_Workstation_Server_Host = new List<String>();
        public static List<String> get_Workstation_Client_InternetProtocol = new List<String>();
        public static List<String> get_Workstation_User_ID = new List<String>();

        public static DataTable get_Workstation_DatatTable = new DataTable();

        public static String Workstation_Information_List_File_Path = "Workstation_Information_List.txt";

        public static String get_Workstation_Content= null;

        public static String get_Workstation_Information_Dictionary_JSON;

        //static Int32 get_counter = 0;

        static Random get_Random;

        static String get_Workstation_Identity_Random()
        {
            get_Random = new Random();

            String get_Workstation_Identity = "Workstation_" + get_Random.Next(1000, 9999).ToString();

            while (get_Workstation_Dictionary.ContainsKey(get_Workstation_Identity))
            {
                get_Workstation_Identity = "Workstation_" + get_Random.Next(1000, 9999).ToString();
            }

            return get_Workstation_Identity;
        }

        public static void insert_Workstation_Information(String set_Workstation_Name, String set_Workstation_Client_InternetProtocol, String set_Workstation_Server_Host)
        {
            get_Workstation_Information_Dictionary.Clear();

            get_Workstation_Information_Dictionary.Add("Workstation_Name", set_Workstation_Name);
            get_Workstation_Information_Dictionary.Add("Workstation_Client_InternetProtocol", set_Workstation_Client_InternetProtocol);
            get_Workstation_Information_Dictionary.Add("Workstation_Server_Host", set_Workstation_Server_Host);
            get_Workstation_Information_Dictionary.Add("Workstation_Username", "");
            get_Workstation_Information_Dictionary.Add("Workstation_Session_Identity", "");
            get_Workstation_Information_Dictionary.Add("Workstation_Session_Action", "");

            String get_Workstation_Identity = get_Workstation_Identity_Random();

            get_Workstation_Information_Dictionary_JSON = JsonConvert.SerializeObject(get_Workstation_Information_Dictionary, Formatting.Indented);

            get_Workstation_Dictionary.Add(get_Workstation_Identity, get_Workstation_Information_Dictionary_JSON);

            get_Workstation_Information_Dictionary_JSON = JsonConvert.SerializeObject(get_Workstation_Dictionary, Formatting.Indented);

            get_Workstation_Content = get_Workstation_Information_Dictionary_JSON;

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Inserted Workstation *" + get_Workstation_Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                get_Workstation_Identity,
                "Workstation has inserted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            File.WriteAllText(Workstation_Information_List_File_Path, get_Workstation_Content);
        }

        public static Boolean check_Workstation_Information(String set_Workstation_Client_InternetProtocol, DataGridView set_dgv_Workstation, Int32 set_Row_Index)
        {
            Int32 Counter = 0;

            if (set_dgv_Workstation.Rows.Count != 0)
            {
                foreach (DataGridViewRow set_DataRow in set_dgv_Workstation.Rows)
                {
                    if (set_Workstation_Client_InternetProtocol.Equals(set_DataRow.Cells["Workstation_Client_InternetProtocol"].Value.ToString()))
                    {
                        if (set_Row_Index == Counter)
                            return true;

                        else
                        {
                            new MythicalCafe_BackEnd_Dialog("Message: Already Exist.").ShowDialog();
                            return false;
                        }                       
                    }

                    Counter ++;
                }

                return true;
            }

            else
                return true;
        }

        public static void update_Workstation_Information(String set_Workstation_Identity, String set_Workstation_Name, String set_Workstation_Client_InternetProtocol, String set_Workstation_Server_Host)
        {
            get_Workstation_Information_Dictionary.Clear();

            get_Workstation_Information_Dictionary.Add("Workstation_Name", set_Workstation_Name);
            get_Workstation_Information_Dictionary.Add("Workstation_Client_InternetProtocol", set_Workstation_Client_InternetProtocol);
            get_Workstation_Information_Dictionary.Add("Workstation_Server_Host", set_Workstation_Server_Host);
            get_Workstation_Information_Dictionary.Add("Workstation_Username", "");
            get_Workstation_Information_Dictionary.Add("Workstation_Session_Identity", "");
            get_Workstation_Information_Dictionary.Add("Workstation_Session_Action", "");

            get_Workstation_Information_Dictionary_JSON = JsonConvert.SerializeObject(get_Workstation_Information_Dictionary, Formatting.Indented);

            get_Workstation_Dictionary[set_Workstation_Identity] = get_Workstation_Information_Dictionary_JSON;

            get_Workstation_Information_Dictionary_JSON = JsonConvert.SerializeObject(get_Workstation_Dictionary, Formatting.Indented);

            get_Workstation_Content = get_Workstation_Information_Dictionary_JSON;

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Updated Workstation *" + set_Workstation_Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                set_Workstation_Identity,
                "Workstation has updated by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            File.WriteAllText(Workstation_Information_List_File_Path, get_Workstation_Content);
        }

        public static void delete_Workstation_Information(String set_Workstation_Identity)
        {
            get_Workstation_Dictionary.Remove(set_Workstation_Identity);

            get_Workstation_Information_Dictionary_JSON = JsonConvert.SerializeObject(get_Workstation_Dictionary, Formatting.Indented);

            get_Workstation_Content = get_Workstation_Information_Dictionary_JSON;

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Account",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                "Deleted Workstation *" + set_Workstation_Identity + "*"
            );

            MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
            (
                "Workstation",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                set_Workstation_Identity,
                "Workstation has deleted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
            );

            File.WriteAllText(Workstation_Information_List_File_Path, get_Workstation_Content);
        }

        public static dynamic select_Workstation_Information(String set_Action, String set_Key)
        {
            MythicalCafe_BackEnd_Main_Method.check_File_Availability(Workstation_Information_List_File_Path);

            get_Workstation_Content = File.ReadAllText(Workstation_Information_List_File_Path);

            if (set_Action == "Select : All")
            {
                get_Workstation_DatatTable = new DataTable();

                if (string.IsNullOrEmpty(get_Workstation_Content.Trim()))
                    return new Dictionary<String, String>();

                get_Workstation_Dictionary = JsonConvert.DeserializeObject<Dictionary<String, String>>(get_Workstation_Content);

                get_Workstation_Content = "";

                get_Workstation_DatatTable.Columns.Add("Workstation_Identity", typeof(String));
                get_Workstation_DatatTable.Columns.Add("Workstation_Name", typeof(String));
                get_Workstation_DatatTable.Columns.Add("Workstation_Client_InternetProtocol", typeof(String));
                get_Workstation_DatatTable.Columns.Add("Workstation_Server_Host", typeof(String));

                foreach (KeyValuePair<String, String> set_KeyValuePair in get_Workstation_Dictionary)
                {
                    get_Workstation_Content += "Key: " + set_KeyValuePair.Key + ", Values: " + set_KeyValuePair.Value + Environment.NewLine;

                    JObject get_KeyValuePair_Value = JObject.Parse(set_KeyValuePair.Value);

                    get_Workstation_DatatTable.Rows.Add(set_KeyValuePair.Key, get_KeyValuePair_Value["Workstation_Name"].ToString(), get_KeyValuePair_Value["Workstation_Client_InternetProtocol"].ToString(), get_KeyValuePair_Value["Workstation_Server_Host"].ToString());

                }

                return get_Workstation_Dictionary;
            }

            else if (set_Action == "Select : Specific")
            {
                String get_Value = "";

                get_Workstation_Dictionary.TryGetValue(set_Key, out get_Value);

                return get_Value;
            }

            else if (set_Action == "Select : Count : All")
            {
                if (string.IsNullOrEmpty(get_Workstation_Content.Trim()))
                    return new Dictionary<String, String>();

                get_Workstation_Dictionary = JsonConvert.DeserializeObject<Dictionary<String, String>>(get_Workstation_Content);
                
                return get_Workstation_Dictionary.Count;
            }

            else
                return null;
        }
    }
}
