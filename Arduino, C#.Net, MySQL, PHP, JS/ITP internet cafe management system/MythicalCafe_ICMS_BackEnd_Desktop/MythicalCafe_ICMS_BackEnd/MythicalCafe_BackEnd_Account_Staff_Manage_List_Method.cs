using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_Account_Staff_Manage_List_Method
    {
        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static DataTable Account_DataTable_1 = new DataTable();
        public static DataTable Account_DataTable_2 = new DataTable();
        public static DataTable Account_DataTable_3 = new DataTable();
        
        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_10; /* tbl_staff_information */
        static String Table_Name_2 = MythicalCafe_BackEnd_Main_Method.Table_Name_12; /* tbl_staff_attendance_information */

        public static dynamic select_Staff_Information(String set_Action, String set_Staff_Identity, String set_UserName, String set_Password, String set_Staff_Position)
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

                MySqlCommand.CommandText = "SELECT *, CONCAT(Staff_FirstName, ' ', Staff_MiddleName, ' ', Staff_LastName) AS Staff_FullName  FROM " + Table_Name_1 + ";";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : All : Specific { Staff_Position }")
            {
                if (ReferenceEquals(Account_DataTable_1.Container, null))
                    Account_DataTable_1 = new DataTable();

                Account_DataTable_1.Rows.Clear();
                Account_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, CONCAT(Staff_FirstName, ' ', Staff_MiddleName, ' ', Staff_LastName) AS Staff_FullName  FROM " + Table_Name_1 + " WHERE Staff_Position = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Position);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Account_DataTable_3.Rows.Clear();
                Account_DataTable_3.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, CONCAT(Staff_FirstName, ' ', Staff_MiddleName, ' ', Staff_LastName) AS Staff_FullName  FROM " + Table_Name_1 + " WHERE Staff_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_3);

                if (Account_DataTable_3.Rows.Count == 1)
                    get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_3.Rows[0], Formatting.Indented);
                
                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific : Username and Password")
            {
                Account_DataTable_2.Rows.Clear();
                Account_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, CONCAT(Staff_FirstName, ' ', Staff_MiddleName, ' ', Staff_LastName) AS Staff_FullName  FROM " + Table_Name_1 + " WHERE Staff_UserName = @a1 AND Staff_Password = @a2;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_UserName);
                MySqlCommand.Parameters.AddWithValue("@a2", set_Password);
                MySqlCommand.ExecuteNonQuery();
                

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_2);

                if (Account_DataTable_2.Rows.Count == 0)
                    return false;

                get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_2.Rows[0], Formatting.Indented);
            }

            else if (set_Action == "Select : Specific : Staff_UserName")
            {
                Account_DataTable_2.Rows.Clear();
                Account_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_1 + " WHERE Staff_UserName = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_UserName);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_2);

                if (Account_DataTable_2.Rows.Count != 0)
                    return true;

                else
                    return false;
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void insert_Staff_Information
        (
            String set_Staff_Identity,
            String set_Staff_UserName,
            String set_Staff_Password,
            String set_Staff_FirstName,
            String set_Staff_MiddleName,
            String set_Staff_LastName,
            String set_Staff_Position,
            String set_Staff_Privilege_Extra,
            String set_Staff_Status
        )
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Staff_Identity, Staff_UserName, Staff_Password, Staff_FirstName, Staff_MiddleName, Staff_LastName, Staff_Position, Staff_Privilege_Extra, Staff_Status)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_1 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Staff_UserName);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Staff_Password);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Staff_FirstName);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Staff_MiddleName);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Staff_LastName);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Staff_Position);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Staff_Privilege_Extra);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Staff_Status);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void update_Staff_Information
        (
            String set_Action,
            String set_Staff_Identity, 
            String set_Staff_UserName, 
            String set_Staff_Password, 
            String set_Staff_FirstName, 
            String set_Staff_MiddleName, 
            String set_Staff_LastName, 
            String set_Staff_Position, 
            String set_Staff_Privilege_Extra,
            String set_Staff_Status
        )
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Update : Specific")
                MySqlCommand.CommandText = "UPDATE " + Table_Name_1 + " SET Staff_UserName = @a2, Staff_Password = @a3, Staff_FirstName = @a4, Staff_MiddleName = @a5, Staff_LastName = @a6, Staff_Position = @a7, Staff_Privilege_Extra = @a8, Staff_Status = @a9 WHERE Staff_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Staff_UserName);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Staff_Password);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Staff_FirstName);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Staff_MiddleName);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Staff_LastName);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Staff_Position);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Staff_Privilege_Extra);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Staff_Status);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();

        }

        public static void delete_Staff_Information(String set_Staff_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "DELETE FROM " + Table_Name_1 + " WHERE Staff_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Identity);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static dynamic select_Staff_Attendance_Information(String set_Action, String set_Attendance_Identity, String set_Staff_Identity, String set_Attendance_Status)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All : Specific : Time Out")
            {
                if (ReferenceEquals(Account_DataTable_1.Container, null))
                    Account_DataTable_1 = new DataTable();

                Account_DataTable_1.Rows.Clear();
                Account_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Staff_Identity = @a1 AND Attendance_Status != @a2;";

                MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Identity);
                MySqlCommand.Parameters.AddWithValue("@a2", "Time In");

                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                if (Account_DataTable_1.Rows.Count > 0)
                    get_Return_Value = true;

                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific : [ Staff_Identity, Attendance_Status ]")
            {
                Account_DataTable_1.Rows.Clear();
                Account_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_2 + " WHERE Staff_Identity = @a1 AND Attendance_Status = @a2;";

                MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Identity);
                MySqlCommand.Parameters.AddWithValue("@a2", set_Attendance_Status);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                if (Account_DataTable_1.Rows.Count == 1)
                    get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_1.Rows[0], Formatting.Indented);

                else
                    get_Return_Value = false;
            }

            else if (set_Action == "Select : Specific { Attendance_Status }")
            {
                Account_DataTable_1.Rows.Clear();
                Account_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT Attendance_Status FROM " + Table_Name_2 + " WHERE Staff_Identity = @a1 AND Date(Attendance_DateTime_In) = @a2;";

                MySqlCommand.Parameters.AddWithValue("@a1", set_Staff_Identity);
                MySqlCommand.Parameters.AddWithValue("@a2", DateTime.Now.ToString("yyyy-MM-dd"));

                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Account_DataTable_1);

                if (Account_DataTable_1.Rows.Count == 1)
                    get_Return_Value = JsonConvert.SerializeObject(Account_DataTable_1.Rows[0], Formatting.Indented);

                else
                    get_Return_Value = false;                
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static Boolean insert_Staff_Attendance_Information(String set_Staff_Identity)
        {
            Boolean get_Return_Value = false;

            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Attendance_Identity = MythicalCafe_BackEnd_Main_Method.Attendance_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Attendance_Identity_Code) + 1000).ToString();

            String get_Query_Column = "(Attendance_Identity, Staff_Identity, Attendance_DateTime_In, Attendance_DateTime_Out, Attendance_Status)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_2 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", get_Attendance_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Staff_Identity);
            MySqlCommand.Parameters.AddWithValue("@a3", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            MySqlCommand.Parameters.AddWithValue("@a4", "");
            MySqlCommand.Parameters.AddWithValue("@a5", "Time In");

            if (MySqlCommand.ExecuteNonQuery() == 1)
            {
                MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Attendance_Identity_Code);

                get_Return_Value = true;
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static Boolean update_Staff_Attendance_Information
        (
            String set_Action, 
            String set_Attendance_Identity, 
            String set_Staff_Identity, 
            String set_Attendance_DateTime_In, 
            String set_Attendance_DateTime_Out,
            String set_Attendance_Status,
            String set_Staff_Salary_Amount
        )
        {
            Boolean get_Return_Value = false;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Update : Specific { Attendance_Status : Time In, Staff_Salary_Amount}")
                MySqlCommand.CommandText = "UPDATE " + Table_Name_2 + " SET Attendance_Status = @a5, Attendance_DateTime_Out = @a4, Staff_Salary_Amount = @a6 WHERE Staff_Identity = @a2 AND Attendance_Status = 'Time In';";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Attendance_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Staff_Identity);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Attendance_DateTime_In);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Attendance_DateTime_Out);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Attendance_Status);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Staff_Salary_Amount);

            if (MySqlCommand.ExecuteNonQuery() == 1)
                get_Return_Value = true;

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }
    }
}
