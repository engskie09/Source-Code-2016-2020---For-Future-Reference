using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_Product_Manage_List_Method
    {
        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static DataTable Product_DataTable_1 = new DataTable();
        public static DataTable Product_DataTable_2 = new DataTable();
        public static DataTable Product_DataTable_3 = new DataTable();

        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_6; /* tbl_product_information */
        static String Table_Name_2 = MythicalCafe_BackEnd_Main_Method.Table_Name_7; /* tbl_product_category_information */
        static String Table_Name_3 = MythicalCafe_BackEnd_Main_Method.Table_Name_11;

        public static dynamic select_Product_Information(String set_Action, String set_Product_Identity)
        {
            dynamic get_Return_Value;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All")
            {
                if (ReferenceEquals(Product_DataTable_1.Container, null))
                    Product_DataTable_1 = new DataTable();

                Product_DataTable_1.Rows.Clear();
                Product_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, Category_Name AS Product_Category FROM " + Table_Name_1 + " INNER JOIN " + Table_Name_2 + " ON " + Table_Name_1 + ".Category_Identity = " + Table_Name_2 + ".Category_Identity;";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Product_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Product_DataTable_2.Rows.Clear();
                Product_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, Category_Name AS Product_Category FROM " + Table_Name_1 + " INNER JOIN " + Table_Name_2 + " ON " + Table_Name_1 + ".Category_Identity = " + Table_Name_2 + ".Category_Identity WHERE Product_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Product_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Product_DataTable_2);

                get_Return_Value = JsonConvert.SerializeObject(Product_DataTable_2.Rows[0], Formatting.Indented);
            }

            else if (set_Action == "Select : Specific { Product_Name }")
            {
                Product_DataTable_3.Rows.Clear();
                Product_DataTable_3.Columns.Clear();

                MySqlCommand.CommandText = "SELECT Product_Name FROM " + Table_Name_1 + " WHERE Product_Identity = @a1;";
                MySqlCommand.Parameters.AddWithValue("@a1", set_Product_Identity);
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Product_DataTable_3);

                get_Return_Value = Product_DataTable_3.Rows[0]["Product_Name"].ToString();
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;
        }

        public static void insert_Product_Information
        (
            String set_Product_Identity,
            String set_Product_Name,
            String set_Product_Quantity,
            String set_Product_Price_Cash,
            String set_Product_Price_Point,
            String set_Category_Identity,
            String set_Product_Description,
            String set_Product_Status,
            String set_Product_Image_Path

        )
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Product_Identity, Product_Name, Product_Quantity, Product_Price_Cash, Product_Price_Point, Category_Identity, Product_Description, Product_Status, Product_Image_Path)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_1 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Product_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Product_Name);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Product_Quantity);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Product_Price_Cash);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Product_Price_Point);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Category_Identity);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Product_Description);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Product_Status);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Product_Image_Path);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();

        }

        public static void update_Product_Information
        (
            String set_Action,
            String set_Product_Identity,
            String set_Product_Name,
            String set_Product_Quantity,
            String set_Product_Price_Cash,
            String set_Product_Price_Point,
            String set_Category_Identity,
            String set_Product_Description,
            String set_Product_Status,
            String set_Product_Image_Path

        )
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Update : Specific")            
                MySqlCommand.CommandText = "UPDATE " + Table_Name_1 + " SET Product_Name = @a2, Product_Quantity = @a3, Product_Price_Cash = @a4, Product_Price_Point = @a5, Category_Identity = @a6, Product_Description = @a7, Product_Status = @a8, Product_Image_Path = @a9 WHERE Product_Identity = @a1;";

            else if (set_Action == "Update : Specific { Product_Quantity }")            
                MySqlCommand.CommandText = "UPDATE " + Table_Name_1 + " SET Product_Quantity = Product_Quantity - @a3 WHERE Product_Identity = @a1;";
            

            MySqlCommand.Parameters.AddWithValue("@a1", set_Product_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Product_Name);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Product_Quantity);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Product_Price_Cash);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Product_Price_Point);
            MySqlCommand.Parameters.AddWithValue("@a6", set_Category_Identity);
            MySqlCommand.Parameters.AddWithValue("@a7", set_Product_Description);
            MySqlCommand.Parameters.AddWithValue("@a8", set_Product_Status);
            MySqlCommand.Parameters.AddWithValue("@a9", set_Product_Image_Path);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();

        }

        public static void delete_Product_Information(String set_Product_Identity)
        {
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "DELETE FROM " + Table_Name_1 + " WHERE Product_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Product_Identity);

            MySqlCommand.ExecuteNonQuery();

            MySqlConnection.Close();
        }

        public static void insert_Product_Report_Information
        (            
            String set_Product_Sold_Name, 
            String set_Product_Sold_Quantity, 
            String set_Product_Sold_Total,
            String set_Report_DateTime
        )
        {

            String get_Report_ID = MythicalCafe_BackEnd_Main_Method.Report_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Report_Identity_Code) + 1000).ToString();

            MySqlConnection.Close();
            MySqlConnection.Open();

            String get_Query_Column = "(Report_ID, Product_Sold_Name, Product_Sold_Quantity, Product_Sold_Total, Report_DateTime)";
            String get_Query_Value = "VALUES (@a1, @a2, @a3, @a4, @a5)";

            MySqlCommand = MySqlConnection.CreateCommand();

            MySqlCommand.CommandText = "INSERT INTO " + Table_Name_3 + " " + get_Query_Column + " " + get_Query_Value + ";";

            MySqlCommand.Parameters.AddWithValue("@a1", get_Report_ID);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Product_Sold_Name);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Product_Sold_Quantity);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Product_Sold_Total);
            MySqlCommand.Parameters.AddWithValue("@a5", set_Report_DateTime);

            MySqlCommand.ExecuteNonQuery();

            MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Report_Identity_Code);
            
            MySqlConnection.Close();
        }
    }
}
