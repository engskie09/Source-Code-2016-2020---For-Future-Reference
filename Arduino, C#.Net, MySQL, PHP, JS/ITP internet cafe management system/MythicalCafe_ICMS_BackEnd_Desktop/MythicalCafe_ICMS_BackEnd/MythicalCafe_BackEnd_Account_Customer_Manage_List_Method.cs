using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_Account_Customer_Manage_List_Method
    {

        /*
                                                                                                        _       _        _         _                                                
                                                          /\                                           | |     | |      (_)       | |                                               
          ______   ______   ______   ______   ______     /  \      ___    ___    ___    _   _   _ __   | |_    | |       _   ___  | |_   ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______|   / /\ \    / __|  / __|  / _ \  | | | | | '_ \  | __|   | |      | | / __| | __| |______| |______| |______| |______| |______|
                                                       / ____ \  | (__  | (__  | (_) | | |_| | | | | | | |_    | |____  | | \__ \ | |_                                              
                                                      /_/    \_\  \___|  \___|  \___/   \__,_| |_| |_|  \__|   |______| |_| |___/  \__|                                             
                                                                                                                                                                            
                                                                                                                                                                           
        */

        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static DataTable Account_DataTable_1 = new DataTable();
        public static DataTable Account_DataTable_2 = new DataTable();
        public static DataTable Account_DataTable_3 = new DataTable();

        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_1; /* tbl_Customer_personal_information */
        static String Table_Name_2 = MythicalCafe_BackEnd_Main_Method.Table_Name_2; /* tbl_Customer_credential_information */
        static String Table_Name_3 = MythicalCafe_BackEnd_Main_Method.Table_Name_3; /* tbl_Customer_property_information */
        static String Table_Name_4 = MythicalCafe_BackEnd_Main_Method.Table_Name_14; /* tbl_customer_report_information */



        /*
                                                       _____                                                _                                              
                                                      |  __ \                                              | |                                             
          ______   ______   ______   ______   ______  | |__) |   ___   _ __   ___    ___    _ __     __ _  | |  ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______| |  ___/   / _ \ | '__| / __|  / _ \  | '_ \   / _` | | | |______| |______| |______| |______| |______|
                                                      | |      |  __/ | |    \__ \ | (_) | | | | | | (_| | | |                                             
                                                      |_|       \___| |_|    |___/  \___/  |_| |_|  \__,_| |_|                                             
                                                                                                                                                   
                                                                                                                                                   
        */

        public static dynamic select_Customer_Personal_Information(String set_Action, String set_Customer_Identity)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All")
            {
                if (ReferenceEquals(Account_DataTable_1.Container, null))
                    Account_DataTable_1 = new DataTable();

                Account_DataTable_1.Rows.Clear();
                Account_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, CONCAT(Customer_FirstName, ' ', Customer_MiddleName, ' ', Customer_LastName) AS Customer_FullName FROM " + Table_Name_1 + ";";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Account_DataTable_2.Rows.Clear();
                Account_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_1 + " WHERE Customer_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_2);

                get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_2.Rows[0], Formatting.Indented);
            }

            else if (set_Action == "Select : Specific { Contact Number }")
            {
                Account_DataTable_2.Rows.Clear();
                Account_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT Customer_ContactNumber FROM " + Table_Name_1 + " WHERE Customer_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_2);

                get_Return_Value = Account_DataTable_2.Rows[0]["Customer_ContactNumber"].ToString();
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void insert_Customer_Personal_Information(String set_Customer_Identity, String set_Customer_FirstName, String set_Customer_MiddleName, String set_Customer_LastName, String set_Customer_EmailAddress, String set_Customer_ContactNumber, String set_Customer_HomeAddress, String set_Customer_Gender, String set_Customer_BirthDate, String set_Customer_Description, String set_Customer_Image_Path, String set_Customer_Registration_DateTime, String set_Customer_LastUsed_DateTime)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Customer_Identity, Customer_FirstName, Customer_MiddleName, Customer_LastName, Customer_EmailAddress, Customer_ContactNumber, Customer_HomeAddress, Customer_Gender, Customer_BirthDate, Customer_Description, Customer_Image_Path, Customer_Registration_DateTime, Customer_LastUsed_DateTime)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_1 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Customer_FirstName);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Customer_MiddleName);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Customer_LastName);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Customer_EmailAddress);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Customer_ContactNumber);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Customer_HomeAddress);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Customer_Gender);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Customer_BirthDate);
            MySqlCommand.Parameters.AddWithValue("@a10", set_Customer_Description);
            MySqlCommand.Parameters.AddWithValue("@a11", set_Customer_Image_Path);
            MySqlCommand.Parameters.AddWithValue("@a12", set_Customer_Registration_DateTime);
            MySqlCommand.Parameters.AddWithValue("@a13", set_Customer_LastUsed_DateTime);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void update_Customer_Personal_Information(String set_Customer_Identity, String set_Customer_FirstName, String set_Customer_MiddleName, String set_Customer_LastName, String set_Customer_EmailAddress, String set_Customer_ContactNumber, String set_Customer_HomeAddress, String set_Customer_Gender, String set_Customer_BirthDate, String set_Customer_Description, String set_Customer_Image_Path, String set_Customer_Registration_DateTime, String set_Customer_LastUsed_DateTime)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "UPDATE " + Table_Name_1 + " SET Customer_FirstName = @a2, Customer_MiddleName = @a3, Customer_LastName = @a4, Customer_EmailAddress = @a5, Customer_ContactNumber  = @a6, Customer_HomeAddress = @a7, Customer_Gender = @a8, Customer_BirthDate = @a9, Customer_Description = @a10, Customer_Image_Path = @a11, Customer_Registration_DateTime = @a12, Customer_LastUsed_DateTime = @a13 WHERE Customer_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Customer_FirstName);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Customer_MiddleName);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Customer_LastName);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Customer_EmailAddress);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Customer_ContactNumber);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Customer_HomeAddress);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Customer_Gender);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Customer_BirthDate);
            MySqlCommand.Parameters.AddWithValue("@a10", set_Customer_Description);
            MySqlCommand.Parameters.AddWithValue("@a11", set_Customer_Image_Path);
            MySqlCommand.Parameters.AddWithValue("@a12", set_Customer_Registration_DateTime);
            MySqlCommand.Parameters.AddWithValue("@a13", set_Customer_LastUsed_DateTime);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void delete_Customer_Personal_Information(String set_Customer_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "DELETE FROM " + Table_Name_1 + " WHERE Customer_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        /*
                                                        _____                     _                  _     _           _                                              
                                                       / ____|                   | |                | |   (_)         | |                                             
          ______   ______   ______   ______   ______  | |       _ __    ___    __| |   ___   _ __   | |_   _    __ _  | |  ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______| | |      | '__|  / _ \  / _` |  / _ \ | '_ \  | __| | |  / _` | | | |______| |______| |______| |______| |______|
                                                      | |____  | |    |  __/ | (_| | |  __/ | | | | | |_  | | | (_| | | |                                             
                                                       \_____| |_|     \___|  \__,_|  \___| |_| |_|  \__| |_|  \__,_| |_|                                             
                                                                                                                                                              
                                                                                                                                                              
        */

        public static dynamic select_Customer_Credential_Information(String set_Action, JObject set_Action_Information, String set_Customer_Identity, String set_Customer_UserName)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All")
            {
                if (ReferenceEquals(Account_DataTable_1.Container, null))
                    Account_DataTable_1 = new DataTable();

                Account_DataTable_1.Rows.Clear();
                Account_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + ";";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Account_DataTable_2.Rows.Clear();
                Account_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Customer_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_2);

                if (Account_DataTable_2.Rows.Count != 0)
                    get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_2.Rows[0], Formatting.Indented);

                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific : Username and Password")
            {

                Account_DataTable_3.Rows.Clear();
                Account_DataTable_3.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Customer_UserName = @a1 AND Customer_Password = @a2;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Action_Information["Username"].ToString());
                MySqlCommand.Parameters.AddWithValue("@a2", set_Action_Information["Password"].ToString());
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_3);

                if (Account_DataTable_3.Rows.Count == 1)
                    get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_3.Rows[0], Formatting.Indented);

                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific : Radio Frequency Identification")
            {

                Account_DataTable_3.Rows.Clear();
                Account_DataTable_3.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Customer_RadioFrequency_Identification = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Action_Information["Radio Frequency Identification"].ToString());
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_3);

                if (Account_DataTable_3.Rows.Count == 1)
                    get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_3.Rows[0], Formatting.Indented);

                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific : Customer_UserName")
            {
                Account_DataTable_2.Rows.Clear();
                Account_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Customer_UserName = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_UserName);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_2);

                if (Account_DataTable_2.Rows.Count != 0)
                    get_Return_Value = true;

                else
                    get_Return_Value = false;
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void insert_Customer_Credential_Information(String set_Customer_Identity, String set_Customer_UserName, String set_Customer_Password, String set_Customer_RadioFrequency_Identification, String set_Customer_RadioFrequency_Identification_Status, String set_Customer_Status)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Customer_Identity, Customer_UserName, Customer_Password, Customer_RadioFrequency_Identification, Customer_RadioFrequency_Identification_Status, Customer_Status)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_2 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Customer_UserName);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Customer_Password);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Customer_RadioFrequency_Identification);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Customer_RadioFrequency_Identification_Status);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Customer_Status);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void update_Customer_Credential_Information
        (
            String set_Action,
            String set_Customer_Identity,
            String set_Customer_UserName,
            String set_Customer_Password,
            String set_Customer_RadioFrequency_Identification,
            String set_Customer_RadioFrequency_Identification_Status,
            String set_Customer_Status)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();
            if (set_Action == "Update : Specific")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_2 + " SET Customer_UserName = @a2, Customer_Password = @a3, Customer_RadioFrequency_Identification = @a4, Customer_RadioFrequency_Identification_Status = @a5, Customer_Status = @a6 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Customer_RadioFrequency_Identification_Status")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_2 + " SET Customer_RadioFrequency_Identification_Status = @a5 WHERE Customer_Identity = @a1;";
            }

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Customer_UserName);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Customer_Password);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Customer_RadioFrequency_Identification);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Customer_RadioFrequency_Identification_Status);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Customer_Status);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void delete_Customer_Credential_Information(String set_Customer_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "DELETE FROM " + Table_Name_2 + " WHERE Customer_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        /*
                                                       _____                                         _                                                        
                                                      |  __ \                                       | |                                                       
          ______   ______   ______   ______   ______  | |__) |  _ __    ___    _ __     ___   _ __  | |_   _   _   ______   ______   ______   ______   ______ 
         |______| |______| |______| |______| |______| |  ___/  | '__|  / _ \  | '_ \   / _ \ | '__| | __| | | | | |______| |______| |______| |______| |______|
                                                      | |      | |    | (_) | | |_) | |  __/ | |    | |_  | |_| |                                             
                                                      |_|      |_|     \___/  | .__/   \___| |_|     \__|  \__, |                                             
                                                                              | |                           __/ |                                             
                                                                              |_|                          |___/                                              
        */

        public static dynamic select_Customer_Property_Information(String set_Action, String set_Customer_Identity)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All")
            {
                if (ReferenceEquals(Account_DataTable_1.Container, null))
                    Account_DataTable_1 = new DataTable();

                Account_DataTable_1.Rows.Clear();
                Account_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_3 + ";";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Account_DataTable_2.Rows.Clear();
                Account_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_3 + " WHERE Customer_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_2);

                get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_2.Rows[0], Formatting.Indented);
            }

            else
                get_Return_Value = false;



            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void insert_Customer_Property_Information(String set_Customer_Identity, String set_Time_Remaining, String set_Time_Bonus, String set_Time_Spent, String set_Cash_Remaining, String set_Cash_Spent, String set_Point_Remaining, String set_Point_Spent, String set_Debt_Remaining, String set_Debt_Maximum)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Customer_Identity, Time_Remaining, Time_Bonus, Time_Spent, Cash_Remaining, Cash_Spent, Point_Remaining, Point_Spent, Debt_Remaining, Debt_Maximum)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_3 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Time_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Time_Bonus);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Time_Spent);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Cash_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Cash_Spent);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Point_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Point_Spent);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Debt_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a10", set_Debt_Maximum);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static dynamic update_Customer_Property_Information(String set_Action, String set_Customer_Identity, String set_Time_Remaining, String set_Time_Bonus, String set_Time_Spent, String set_Cash_Remaining, String set_Cash_Spent, String set_Point_Remaining, String set_Point_Spent, String set_Debt_Remaining, String set_Debt_Maximum)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Update : Specific : Except { Cash Spent, Point Spent, Time Spent }")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Time_Remaining = @a2, Time_Bonus = @a3, Cash_Remaining = @a5, Point_Remaining = @a7, Debt_Remaining = @a9, Debt_Maximum = @a10 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Cash Spent")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Cash_Spent = @a6 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Point Spent")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Point_Spent = @a8 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Time Spent")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Time_Spent = @a4 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Time Bonus")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Time_Bonus = @a3 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Time Remaining and Cash Remaining and Cash Spent")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Time_Remaining = Time_Remaining + @a2, Cash_Remaining = Cash_Remaining - @a6, Cash_Spent = Cash_Spent + @a6 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Time Remaining and Cash Remaining and Cash Spent and Debt Remaining")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Time_Remaining = Time_Remaining + @a2, Cash_Remaining = @a5, Cash_Spent = Cash_Spent + @a6, Debt_Remaining = Debt_Remaining +  @a9 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : Time Remaining and Time Bonus and Time Spent")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Time_Spent = IF (@a2 <= 0, (Time_Remaining + Time_Spent + Time_Bonus), (Time_Spent + @a4)), Time_Remaining = IF (@a2 <= 0, 0, @a2), Time_Bonus = @a3 WHERE Customer_Identity = @a1;";
            }

            else if (set_Action == "Update : Specific : { Cash_Remaining, Cash_Spent, Point_Remaining, Point_Spent}")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_3 + " SET Cash_Remaining = Cash_Remaining - @a6, Cash_Spent = Cash_Spent + @a6, Point_Remaining = Point_Remaining - @a8, Point_Spent = Point_Spent + @a8  WHERE Customer_Identity = @a1;";
            }

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Time_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Time_Bonus);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Time_Spent);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Cash_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Cash_Spent);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Point_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Point_Spent);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Debt_Remaining);
            MySqlCommand.Parameters.AddWithValue("@a10", set_Debt_Maximum);

            if (MySqlCommand.ExecuteNonQuery() > 0)
            {
                MySqlConnection.Close();
                return true;
            }

            else
            {
                MySqlConnection.Close();
                return false;
            }
        }

        public static void delete_Customer_Property_Information(String set_Customer_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "DELETE FROM " + Table_Name_3 + " WHERE Customer_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Customer_Identity);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void insert_Customer_Report_Information
        (
            String set_Customer_Identity,
            String set_Cash_Spent,
            String Report_DateTime
        )
        {
            String get_Report_ID = MythicalCafe_BackEnd_Main_Method.Report_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Report_Identity_Code) + 1000).ToString();

            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Report_Identity, Customer_Identity, Cash_Spent, Report_DateTime)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_4 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", get_Report_ID);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Cash_Spent);
            MySqlCommand.Parameters.AddWithValue("@a4", Report_DateTime);

            MySqlCommand.ExecuteNonQuery();

            MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Report_Identity_Code);

            MySqlConnection.Close();
        }
    }
}
