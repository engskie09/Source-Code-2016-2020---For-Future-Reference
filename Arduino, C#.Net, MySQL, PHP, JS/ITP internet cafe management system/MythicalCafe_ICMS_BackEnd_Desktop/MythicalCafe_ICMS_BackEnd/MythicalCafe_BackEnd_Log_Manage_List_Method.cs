using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_Log_Manage_List_Method
    {
        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static DataTable Log_DataTable_1 = new DataTable();
        public static DataTable Log_DataTable_2 = new DataTable();
        public static DataTable Log_DataTable_3 = new DataTable();

        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_9; /* tbl_user_log_information */

        public static void select_User_Log_Information(String set_Action, String set_Log_Type)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All : Specific [ Log_Type ]")
            {
                if (ReferenceEquals(Log_DataTable_1.Container, null))
                    Log_DataTable_1 = new DataTable();

                Log_DataTable_1.Rows.Clear();
                Log_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_1 + " WHERE Log_Type = @a1 AND Log_Identity LIKE '%-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-%';";

                MySqlCommand.Parameters.AddWithValue("@a1", set_Log_Type);

                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Log_DataTable_1);                
            }

            MySqlConnection.Close();
        }

        public static void insert_User_Log_Information(String set_Log_Type, String set_Log_DateTime, String set_User_Identity, String set_Log_Description)
        {
            String get_Log_Identity = MythicalCafe_BackEnd_Main_Method.Log_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Log_Identity_Code) + 1000).ToString(); ;

            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Log_Identity, Log_Type, Log_DateTime, User_Identity, Log_Description)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_1 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", get_Log_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Log_Type);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Log_DateTime);
            MySqlCommand.Parameters.AddWithValue("@a4", set_User_Identity);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Log_Description);

            if (MySqlCommand.ExecuteNonQuery() == 1)
                MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Log_Identity_Code);

            MySqlConnection.Close();
        }
    }
}
