using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MythicalCafe_ICMS_FrontEnd
{
    public static class MythicalCafe_FrontEnd_Main_Method
    {
        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_FrontEnd.MySqlConnection_String);
        static MySqlCommand MySqlCommand = new MySqlCommand();
        static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static DataTable Main_DataTable_1 = new DataTable();
        public static DataTable Main_DataTable_2 = new DataTable();

        public static String Table_Name_1 = "tbl_customer_personal_information";
        public static String Table_Name_2 = "tbl_customer_credential_information";  
        public static String Table_Name_3 = "tbl_customer_property_information";
        public static String Table_Name_4 = "tbl_counter_information";
        public static String Table_Name_5 = "tbl_product_information";
        public static String Table_Name_6 = "tbl_product_category_information";
        public static String Table_Name_7 = "tbl_product_order_information";
        public static String Table_Name_8 = "tbl_user_log_information";


        public static String Branch_Identity = null;

        public static String Product_Order_Identity_Code = "RDR";
        public static String Log_Identity_Code = "LG";

        public static String Configuration_information_File_Path = "configuration_information.xml";

        public static String RadioFrequency_Port_Name = null;
        public static String RadioFrequency_Status = null;

        public static String ShortMessageService_Port_Name = null;
        public static String ShortMessageService_Status = null;

        public static String Server_InternetProtocol_Address = null;

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

                get_XElement.Add(new XElement("Server_InternetProtocol_Address", "192.168.1.106"));

                get_XDocument.Add(get_XElement);
                get_XDocument.Save(Configuration_information_File_Path);
            }

            get_XDocument = XDocument.Load(Configuration_information_File_Path);

            Branch_Identity = get_XDocument.Descendants("Branch_Identity").FirstOrDefault().Value.ToString();
            RadioFrequency_Port_Name = get_XDocument.Descendants("RadioFrequency_Port_Name").FirstOrDefault().Value.ToString();
            RadioFrequency_Status = get_XDocument.Descendants("RadioFrequency_Status").FirstOrDefault().Value.ToString();

            ShortMessageService_Port_Name = get_XDocument.Descendants("ShortMessageService_Port_Name").FirstOrDefault().Value.ToString();
            ShortMessageService_Status = get_XDocument.Descendants("ShortMessageService_Status").FirstOrDefault().Value.ToString();                   

            Server_InternetProtocol_Address = get_XDocument.Descendants("Server_InternetProtocol_Address").FirstOrDefault().Value.ToString();
        }

        public static Int32 get_Current_Identity_Count(String get_Counter_Code)
        {
            Int32 get_Return_Value = 0;

            Main_DataTable_1.Rows.Clear();
            Main_DataTable_1.Columns.Clear();

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();
            MySqlCommand.CommandText = "SELECT Counter_Count FROM " + Table_Name_4 + " WHERE Counter_Code = '" + get_Counter_Code + "' AND Branch_ID = '" + Branch_Identity + "';";
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
            MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Counter_Count = Counter_Count + 1 WHERE Counter_Code = '" + get_Counter_Code + "' AND Branch_ID = '" + Branch_Identity + "';";
            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void insert_User_Log_Information(String set_Log_Type, String set_Log_DateTime, String set_User_Identity, String set_Log_Description)
        {
            String get_Log_Identity = Log_Identity_Code + "-" + Branch_Identity + "-" + (get_Current_Identity_Count(Log_Identity_Code) + 1000).ToString(); ;

            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Log_Identity, Log_Type, Log_DateTime, User_Identity, Log_Description)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_8 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", get_Log_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Log_Type);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Log_DateTime);
            MySqlCommand.Parameters.AddWithValue("@a4", set_User_Identity);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Log_Description);

            if (MySqlCommand.ExecuteNonQuery() == 1)
                set_Current_Identity_Count(Log_Identity_Code);

            MySqlConnection.Close();
        }

        public static dynamic select_Product_Information(String set_Action, String set_Product_Identity)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All : Except { Product Status = Inactive }")
            {
                if (ReferenceEquals(Main_DataTable_1.Container, null))
                    Main_DataTable_1 = new DataTable();

                Main_DataTable_1.Rows.Clear();
                Main_DataTable_1.Columns.Clear();
                
                MySqlCommand.CommandText = "SELECT *, Category_Name AS Product_Category FROM " + Table_Name_5 + " INNER JOIN " + Table_Name_6 + " ON " + Table_Name_5 + ".Category_Identity = " + Table_Name_6 + ".Category_Identity WHERE Product_Status != 'Inactive';";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Main_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Main_DataTable_2.Rows.Clear();
                Main_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, Category_Name AS Product_Category FROM " + Table_Name_5 + " INNER JOIN " + Table_Name_6 + " ON " + Table_Name_5 + ".Category_Identity = " + Table_Name_6 + ".Category_Identity WHERE Product_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Product_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Main_DataTable_2);

                get_Return_Value = JsonConvert.SerializeObject(Main_DataTable_2.Rows[0], Formatting.Indented);
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }


        public static dynamic select_Customer_Credential_Information(String set_Action, JObject set_Action_Information)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : Specific : Username and Password")
            {
                Main_DataTable_2.Rows.Clear();
                Main_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Customer_UserName = @a1 AND Customer_Password = @a2;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Action_Information["Username"].ToString());
                MySqlCommand.Parameters.AddWithValue("@a2", set_Action_Information["Password"].ToString());
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Main_DataTable_2);

                if (Main_DataTable_2.Rows.Count == 1)
                    get_Return_Value = JsonConvert.SerializeObject(Main_DataTable_2.Rows[0], Formatting.Indented);

                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific : Radio Frequency Identification")
            {

                Main_DataTable_2.Rows.Clear();
                Main_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Customer_RadioFrequency_Identification = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Action_Information["Radio Frequency Identification"].ToString());
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Main_DataTable_2);

                if (Main_DataTable_2.Rows.Count == 1)
                    get_Return_Value = JsonConvert.SerializeObject(Main_DataTable_2.Rows[0], Formatting.Indented);

                else
                    get_Return_Value = false;
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }


        public static dynamic select_Customer_Property_Information(String set_Action, String set_Customer_Identity)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : Specific")
            {
                Main_DataTable_2.Rows.Clear();
                Main_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_3 + " WHERE Customer_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Main_DataTable_2);

                get_Return_Value = JsonConvert.SerializeObject(Main_DataTable_2.Rows[0], Formatting.Indented);
            }

            else
                get_Return_Value = false;



            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static String check_Customer_Balance()
        {
            String get_Return_Value = null;

            MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Choice: Login Options.");

            get_Dialog.btn_Ok.Text = "Using User/Pass.";
            get_Dialog.btn_No.Text = "Using I.D.";

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                MythicalCafe_FrontEnd_Login get_Login = new MythicalCafe_FrontEnd_Login();

                if (get_Login.ShowDialog() == DialogResult.OK)
                {
                    JObject get_JObject = JObject.Parse(get_Login.Action_Value);

                    new MythicalCafe_FrontEnd_Dialog("Message: " + "M-Cash: " + get_JObject["Cash_Remaining"].ToString() + "\n" + "Points: " + get_JObject["Point_Remaining"].ToString()).ShowDialog();

                    get_Return_Value = get_Login.Action_Value;
                }
            }

            else if (get_Dialog.DialogResult == DialogResult.No)
            {
                get_Dialog = new MythicalCafe_FrontEnd_Dialog("Message: Tap your I.D.");

                get_Dialog.txt_Action.Select();

                get_Dialog.txt_Action.OnValueChanged += delegate (Object set_Object, EventArgs set_EventHandler)
                {
                    BunifuMetroTextbox get_BunifuMetroTextbox = (BunifuMetroTextbox)set_Object;

                    if (get_BunifuMetroTextbox.Text.Length == 10)
                    {
                        MessageBox.Show("");

                        dynamic Customer_Credential_Information = MythicalCafe_FrontEnd_Main_Method.select_Customer_Credential_Information("Select : Specific : Radio Frequency Identification", JObject.Parse("{ 'Radio Frequency Identification' : '" + get_BunifuMetroTextbox.Text + "' }"));

                        if (Customer_Credential_Information is Boolean)
                        {
                            if (!Customer_Credential_Information)
                                get_Dialog.lbl_Action.Text = "Try Again. Tap Your I.D.";

                            get_Dialog.txt_Action.Select();
                        }

                        else
                        {
                            Customer_Credential_Information = JObject.Parse(JObject.Parse(Customer_Credential_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                            if (Customer_Credential_Information["Customer_RadioFrequency_Identification_Status"] == "Inactive")
                            {
                                get_Dialog.lbl_Action.Text = "Your card is Lock.";
                            }

                            else
                            {
                                JObject Customer_Property_Information = JObject.Parse(MythicalCafe_FrontEnd_Main_Method.select_Customer_Property_Information("Select : Specific", Customer_Credential_Information["Customer_Identity"].ToString()));

                                Customer_Property_Information = JObject.Parse(Customer_Property_Information["Table"].ToString().TrimStart('[').TrimEnd(']'));

                                get_Dialog.lbl_Action.Text = "M-Cash: " + Customer_Property_Information["Cash_Remaining"].ToString() + "\n" + "Points: " + Customer_Property_Information["Point_Remaining"].ToString();

                                get_Return_Value = "{ 'Cash_Remaining' : '" + Customer_Property_Information["Cash_Remaining"] + "' , 'Point_Remaining' : '" + Customer_Property_Information["Point_Remaining"] + "', 'Customer_Identity' : '" + Customer_Property_Information["Customer_Identity"] + "'}";

                            }

                            get_Dialog.txt_Action.Select();
                        }
                    }
                };

                get_Dialog.ShowDialog();
            }

            return get_Return_Value;
        }

        public static Int32 select_Product_Order_Information(String set_Customer_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            Main_DataTable_2.Rows.Clear();
            Main_DataTable_2.Columns.Clear();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_7 + " WHERE Customer_Identity = @a1 AND Order_Status = @a2 ;";
            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", "Pending");

            MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
            MySqlDataAdapter.Fill(Main_DataTable_2);

            return Main_DataTable_2.Rows.Count;
        }

        public static Boolean insert_Product_Order_Information(String set_Order_Identity, String set_Customer_ID, String set_Order_List, String set_Order_Status)
        {

            Boolean get_Return_Value = false;

            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Order_Identity, Customer_Identity, Order_List, Order_Status)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_7 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Order_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Customer_ID);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Order_List);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Order_Status);

            if (MySqlCommand.ExecuteNonQuery() == 1)
                get_Return_Value =  true;

            MySqlConnection.Close();

            return get_Return_Value;
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
