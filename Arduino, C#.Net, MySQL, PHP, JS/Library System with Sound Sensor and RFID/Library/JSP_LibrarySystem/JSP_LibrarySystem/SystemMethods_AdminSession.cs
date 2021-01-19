//Rafael Nobleza Masallo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace JSP_LibrarySystem
{
    class SystemMethods_AdminSession
    {
        static MySqlConnection connection = new MySqlConnection(Program.connectionString);
        static MySqlCommand cmd = new MySqlCommand();
        static MySqlDataAdapter da = new MySqlDataAdapter();

        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();
        public static DataTable dt2 = new DataTable();

        static String tblName1 = "tbl_report_borrow";
        static String tblName2 = "tbl_report_return";
        static String tblName3 = "tbl_user_information";
        static String tblName4 = "tbl_user_logincredentials";

        //get the List of Borrowed Books Reports and set to DatagridView
        public static void get_BorrowedReport()
        {
            dt1.Clear();
            connection.Close();
            connection.Open();           

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName1 + "";            

            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt1);

            connection.Close();
        }

        //get the List of Returned Books Reports and set to DatagridView
        public static void get_ReturnedReport()
        {
            dt2.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName2 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt2);

            connection.Close();
        }

        //insert new User Informaion e.g: Staff.
        public static void insert_UserInformation(String set_userID, String set_userName, String set_userPassword,
                                                  String set_userFirstName, String set_userMiddleName, String set_userLastName,
                                                  String set_userRole)
        {
            connection.Close();
            connection.Open();

            String columnsName = "(user_id, user_name, user_password, user_Firstname, user_Middlename, user_Lastname,"
                                + "user_role)";
            String columnsValue = "VALUES(@a1, @a2, @a3, @a4, @a5, @a6, @a7)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName3 + " " + columnsName + " " + columnsValue + "";

            cmd.Parameters.AddWithValue("@a1", set_userID);
            cmd.Parameters.AddWithValue("@a2", set_userName);
            cmd.Parameters.AddWithValue("@a3", set_userPassword);
            cmd.Parameters.AddWithValue("@a4", set_userFirstName);
            cmd.Parameters.AddWithValue("@a5", set_userMiddleName);
            cmd.Parameters.AddWithValue("@a6", set_userLastName);
            cmd.Parameters.AddWithValue("@a7", set_userRole);          

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //update User Informaion e.g: Staff.
        public static void update_UserInformation(String set_userID, String set_userName, String set_userPassword,
                                                  String set_userFirstName, String set_userMiddleName, String set_userLastName,
                                                  String set_userRole)
        {
            connection.Close();
            connection.Open();


            String columnsNameValue = "SET user_id = @a1, user_name = @a2, user_password = @a3, user_Firstname = @a4, user_Middlename = @a5, user_Lastname = @a6,"
                                + "user_role = @a7";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + tblName3 + " " + columnsNameValue + " WHERE user_id = @a1 ";

            cmd.Parameters.AddWithValue("@a1", set_userID);
            cmd.Parameters.AddWithValue("@a2", set_userName);
            cmd.Parameters.AddWithValue("@a3", set_userPassword);
            cmd.Parameters.AddWithValue("@a4", set_userFirstName);
            cmd.Parameters.AddWithValue("@a5", set_userMiddleName);
            cmd.Parameters.AddWithValue("@a6", set_userLastName);
            cmd.Parameters.AddWithValue("@a7", set_userRole);           

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //delete User Information e.g: Staff.
        public static void delete_UserInformation(String set_userID)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + tblName3 + " WHERE user_id = '" + set_userID + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }

    }
}
