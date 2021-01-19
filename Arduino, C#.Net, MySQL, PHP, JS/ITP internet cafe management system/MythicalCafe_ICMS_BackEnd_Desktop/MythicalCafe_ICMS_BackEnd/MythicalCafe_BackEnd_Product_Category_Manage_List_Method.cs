using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_Product_Category_Manage_List_Method
    {
        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static DataTable Category_DataTable_1 = new DataTable();
        public static DataTable Category_DataTable_2 = new DataTable();
        public static DataTable Category_DataTable_3 = new DataTable();

        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_7; /* tbl_product_category_information */

        public static dynamic select_Category_Information(String set_Action, String set_Product_Identity)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All")
            {
                if (ReferenceEquals(Category_DataTable_1.Container, null))
                    Category_DataTable_1 = new DataTable();

                Category_DataTable_1.Rows.Clear();
                Category_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_1 + " WHERE Category_Identity LIKE '%-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-%';";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Category_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Category_DataTable_2.Rows.Clear();
                Category_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_1 + " WHERE Category_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Product_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Category_DataTable_2);

                get_Return_Value = JsonConvert.SerializeObject(Category_DataTable_2.Rows[0], Formatting.Indented);
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void insert_Product_Category_Information(String set_Category_Identity, String set_Category_Name, String set_Category_Description)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Category_Identity, Category_Name, Category_Description)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_1 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Category_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Category_Name);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Category_Description);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();

        }

        public static void update_Product_Category_Information(String set_Action, String set_Category_Identity, String set_Category_Name, String set_Category_Description)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Update : Specific")
                MySqlCommand.CommandText = "UPDATE " + Table_Name_1 + " SET Category_Name = @a2, Category_Description = @a3 WHERE Category_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Category_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Category_Name);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Category_Description);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();

        }

        public static void delete_Product_Category_Information(String set_Category_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "DELETE FROM " + Table_Name_1 + " WHERE Category_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Category_Identity);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }
    }
}
