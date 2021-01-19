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
    public static class MythicalCafe_BackEnd_Product_Order_Manage_List_Method
    {
        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static DataTable Product_Order_DataTable_1 = new DataTable();
        public static DataTable Product_Order_DataTable_2 = new DataTable();
        public static DataTable Product_Order_DataTable_3 = new DataTable();

        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_8; /* tbl_product_order_information */
        static String Table_Name_2 = MythicalCafe_BackEnd_Main_Method.Table_Name_1; /* tbl_customer_personal_information */

        public static dynamic select_Product_Order_Information(String set_Action, String set_Identity_Name, String set_Identity)
        {
            dynamic get_Return_Value = null;

            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Select : All : Pending")
            {
                Product_Order_DataTable_1.Rows.Clear();
                Product_Order_DataTable_1.Columns.Clear();

                MySqlCommand.CommandText = "SELECT *, CONCAT(Customer_FirstName, ' ', Customer_MiddleName, ' ', Customer_LastName) AS Customer_FullName FROM " + Table_Name_1 + " INNER JOIN " + Table_Name_2 + " ON " + Table_Name_1 + ".Customer_Identity = " + Table_Name_2 + ".Customer_Identity WHERE Order_Status = 'Pending' AND Order_Identity LIKE '%-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-%';";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Product_Order_DataTable_1);

                get_Return_Value = true;
            }

            else if (set_Action == "Select : Specific")
            {
                Product_Order_DataTable_2.Rows.Clear();
                Product_Order_DataTable_2.Columns.Clear();

                MySqlCommand.CommandText = "SELECT * FROM " + Table_Name_1 + " WHERE " + set_Identity_Name + " = '" + set_Identity + "' AND Order_Status = 'Pending';";
                MySqlCommand.ExecuteNonQuery();

                MySqlDataAdapter = new MySqlDataAdapter(MySqlCommand);
                MySqlDataAdapter.Fill(Product_Order_DataTable_2);

                if (Product_Order_DataTable_2.Rows.Count != 0)
                    get_Return_Value = JsonConvert.SerializeObject(Product_Order_DataTable_2.Rows[0], Formatting.Indented);
                else
                    get_Return_Value = false;
            }

            else
                get_Return_Value = false;

            MySqlConnection.Close();

            return get_Return_Value;

        }

        public static Boolean update_Product_Order_Information(String set_Action, String set_Order_Identity, String set_Customer_Identity, String set_Order_List, String set_Order_Status)
        {
            Boolean get_Return_Value = false;
            MySqlConnection.Close();
            MySqlConnection.Open();

            MySqlCommand = MySqlConnection.CreateCommand();

            if (set_Action == "Update : Specific : Order_Status")
                MySqlCommand.CommandText = "UPDATE " + Table_Name_1 + " SET Order_Status = @a4 WHERE Order_Identity = @a1;";

            else if (set_Action == "Update : Specific : Order_List")
                MySqlCommand.CommandText = "UPDATE " + Table_Name_1 + " SET Order_List = @a3 WHERE Order_Identity = @a1;";

            MySqlCommand.Parameters.AddWithValue("@a1", set_Order_Identity);
            MySqlCommand.Parameters.AddWithValue("@a2", set_Customer_Identity);
            MySqlCommand.Parameters.AddWithValue("@a3", set_Order_List);
            MySqlCommand.Parameters.AddWithValue("@a4", set_Order_Status);

            if (MySqlCommand.ExecuteNonQuery() == 1)
                get_Return_Value = true;

            MySqlConnection.Close();

            return get_Return_Value;

        }

    }
}
