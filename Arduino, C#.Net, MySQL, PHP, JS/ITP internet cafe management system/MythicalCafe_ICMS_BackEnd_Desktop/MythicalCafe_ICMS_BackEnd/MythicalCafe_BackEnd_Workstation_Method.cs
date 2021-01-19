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
using MySql.Data.MySqlClient;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_Workstation_Method
    {
        static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        static MySqlCommand MySqlCommand = new MySqlCommand();
        static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        static DataTable get_Workstation_DataTable_1 = new DataTable();
        static DataTable get_Workstation_DataTable_2 = new DataTable();
        public static DataTable get_Workstation_DataTable_3 = new DataTable();

        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_1; //tbl_customer_personal_information
        static String Table_Name_2 = MythicalCafe_BackEnd_Main_Method.Table_Name_2; //tbl_customer_credential_information
        static String Table_Name_3 = MythicalCafe_BackEnd_Main_Method.Table_Name_3; //tbl_customer_property_information
        static String Table_Name_4 = MythicalCafe_BackEnd_Main_Method.Table_Name_4; //tbl_workstation_session_information
        static String Table_Name_5 = MythicalCafe_BackEnd_Main_Method.Table_Name_13; //tbl_workstation_session_report_information


        public static dynamic select_Session_Information(String set_Action, String set_Identity_Name, String set_Identity)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All")
            {
                get_Workstation_DataTable_1.Rows.Clear();
                get_Workstation_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_4 + ";";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(get_Workstation_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : All : Active")
            {
                get_Workstation_DataTable_3.Rows.Clear();
                get_Workstation_DataTable_3.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_4 + " WHERE Session_Status = 'Active';";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(get_Workstation_DataTable_3);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific : Active")
            {
                get_Workstation_DataTable_2.Rows.Clear();
                get_Workstation_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_4 + " WHERE " + set_Identity_Name + " = '" + set_Identity + "' AND Session_Status = 'Active';";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(get_Workstation_DataTable_2);

                if (get_Workstation_DataTable_2.Rows.Count != 0)
                    get_Return_Value = JsonConvert.SerializeObject(get_Workstation_DataTable_2.Rows[0], Formatting.Indented);
                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific")
            {
                get_Workstation_DataTable_2.Rows.Clear();
                get_Workstation_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_4 + " WHERE " + set_Identity_Name + " = '" + set_Identity + "';";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(get_Workstation_DataTable_2);

                if (get_Workstation_DataTable_2.Rows.Count != 0)
                    get_Return_Value = JsonConvert.SerializeObject(get_Workstation_DataTable_2.Rows[0], Formatting.Indented);
                else
                    get_Return_Value = false;
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void insert_Session_Information
        (
            String set_Session_Identity, 
            String set_Workstation_Identity, 
            String set_User_Identity, 
            String set_Session_DateTime_Started,
            String set_Session_DateTime_LastPaused,
            String set_Session_DateTime_Ended,
            String set_Time_Spent, 
            String set_Cash_Spent, 
            String set_Session_Status,
            String set_Session_Action_Last
        )
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Session_Identity, Workstation_Identity, User_Identity, Session_Started_DateTime, Session_LastPaused_DateTime, Session_Ended_DateTime, Time_Spent, Cash_Spent, Session_Status, Session_Action_Last)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_4 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Session_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Workstation_Identity);
            MySqlCommand.Parameters.AddWithValue("@a3", set_User_Identity);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Session_DateTime_Started);            
            MySqlCommand.Parameters.AddWithValue("@a5", set_Session_DateTime_LastPaused);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Session_DateTime_Ended);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Time_Spent);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Cash_Spent);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Session_Status);
            MySqlCommand.Parameters.AddWithValue("@a10", set_Session_Action_Last);

            MySqlCommand.ExecuteNonQuery();
            
            MySqlConnection.Close();
        }

        public static Boolean update_Session_Information
        (
            String set_Action,
            String set_Identity_Name,
            String set_Identity,
            String set_Workstation_Identity,
            String set_Session_DateTime_LastPaused,
            String set_Session_DateTime_Ended,
            String set_Time_Spent,
            String set_Cash_Spent,
            String set_Session_Status,
            String set_Session_Action_Last
        )
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Update : Specific : Cash Spent")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Cash_Spent = @a6 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Time Spent")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Time_Spent = @a5 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Date Time Ended")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Session_Ended_DateTime = @a3 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : LastPaused DateTime")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Session_LastPaused_DateTime = @a4 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Session Action")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Session_Action_Last = @a8 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Time Spent and Session Action and LastPaused DateTime")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Time_Spent = @a5, Session_Action_Last = @a8, Session_LastPaused_DateTime = @a4 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Time Spent and Session Status")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Time_Spent = @a5, Session_Status = @a7 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Date Time Ended and Session Action")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Session_Ended_DateTime = @a3, Session_Action_Last = @a8 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Cash Spent and Date Time Ended")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Session_Ended_DateTime = @a3, Cash_Spent = Cash_Spent + @a6 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else if (set_Action == "Update : Specific : Workstation Identity")
            {
                MySqlCommand.CommandText = "UPDATE " + Table_Name_4 + " SET Workstation_Identity = @a2 WHERE " + set_Identity_Name + " = @a1;";
                get_Return_Value = true;
            }

            else
                get_Return_Value = false;

            MySqlCommand.Parameters.AddWithValue("@a1", set_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Workstation_Identity);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Session_DateTime_Ended);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Session_DateTime_LastPaused);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Time_Spent);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Cash_Spent);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Session_Status);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Session_Action_Last);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void delete_Session_Information(String set_Session_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "DELETE FROM " + Table_Name_4 + " WHERE Session_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Session_Identity);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void insert_Session_Report_Information
        (
            String set_Session_Identity,
            String set_Customer_Identity,
            String set_Cash_Spent,
            String Report_DateTime
        )
        {
            String get_Report_ID = MythicalCafe_BackEnd_Main_Method.Report_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Report_Identity_Code) + 1000).ToString();

            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Report_Identity, Session_Identity, Customer_Identity, Cash_Spent, Report_DateTime)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_5 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", get_Report_ID);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Session_Identity);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Cash_Spent);
            MySqlCommand.Parameters.AddWithValue("@a5", Report_DateTime);

            MySqlCommand.ExecuteNonQuery();

            MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Report_Identity_Code);

            MySqlConnection.Close();
        }
    }
}
