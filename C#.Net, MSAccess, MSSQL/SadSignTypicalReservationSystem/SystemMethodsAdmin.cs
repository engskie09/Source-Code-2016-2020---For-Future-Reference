
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadSignTypicalReservationSystem
{
    class SystemMethodsAdmin
    {
        public static String MySqlConnectionString = "server=localhost;user id=root;database=sadsigntypicalreservationsystem";
        public static MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();

        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------

        public static void addRoom(Int32 RoomNo, String RoomFloorNo, String RoomType, Int32 RoomAmount, String RoomAvailablity)
        {          

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + SystemMethodsGeneral.tblname1 + " VALUES(@a1, @a2, @a3, @a4, @a5)";
            cmd.Parameters.AddWithValue("@a1", RoomNo);
            cmd.Parameters.AddWithValue("@a2", RoomFloorNo);
            cmd.Parameters.AddWithValue("@a3", RoomType);
            cmd.Parameters.AddWithValue("@a4", RoomAmount);
            cmd.Parameters.AddWithValue("@a5", RoomAvailablity);
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------
        //----------------------------------------------------------Add Room-----------------------------------------------------

        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------

        public static void updateRoom(Int32 RoomNo, String RoomFloorNo, String RoomType, Int32 RoomAmount, String RoomAvailablity, Int32 RoomNoAsKey)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + SystemMethodsGeneral.tblname1 + " SET RoomNo = @a1, FloorNo = @a2, RoomType = @a3, RoomAmount = @a4, RoomAvailability = @a5 WHERE RoomNo = @a6";
            cmd.Parameters.AddWithValue("@a1", RoomNo);
            cmd.Parameters.AddWithValue("@a2", RoomFloorNo);
            cmd.Parameters.AddWithValue("@a3", RoomType);
            cmd.Parameters.AddWithValue("@a4", RoomAmount);
            cmd.Parameters.AddWithValue("@a5", RoomAvailablity);
            cmd.Parameters.AddWithValue("@a6", RoomNoAsKey);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------
        //--------------------------------------------------------Update Room----------------------------------------------------

        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------

        public static void deleteRoom(Int32 RoomNo)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + SystemMethodsGeneral.tblname1 + " WHERE RoomNo = '" + RoomNo + "' ";
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------
        //--------------------------------------------------------Delete Room----------------------------------------------------

        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------

        public static void updateCustomer(String getCustomerFirstname, String getCustomerMiddlename, String getCustomerLastname,
                                       String getCustomerBirthday, String getCustomerGender, String getCustomerID,
                                       String getCustomerUsername, String getCustomerPassword)
        {
            connection.Close();
            connection.Open();
            String MySqlQueryColumnsVal = "CustomerFirstname = @a1, CustomerMiddlename = @a2, CustomerLastname = @a3, CustomerBirthday = @a4, CustomerGender = @a5, CustomerID = @a6, CustomerUsername = @a7, CustomerPassword = @a8";
           
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + SystemMethodsCustomer.tblname2 + " SET " + MySqlQueryColumnsVal + " WHERE CustomerID = '" + getCustomerID + "' ";
            cmd.Parameters.AddWithValue("@a1", getCustomerFirstname);
            cmd.Parameters.AddWithValue("@a2", getCustomerMiddlename);
            cmd.Parameters.AddWithValue("@a3", getCustomerLastname);
            cmd.Parameters.AddWithValue("@a4", getCustomerBirthday);
            cmd.Parameters.AddWithValue("@a5", getCustomerGender);
            cmd.Parameters.AddWithValue("@a6", getCustomerID);
            cmd.Parameters.AddWithValue("@a7", getCustomerUsername);
            cmd.Parameters.AddWithValue("@a8", getCustomerPassword);
            cmd.ExecuteNonQuery();

            connection.Close();
          
        }
        

        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------
        //------------------------------------------------------Update Customer--------------------------------------------------
        
        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
        public static void deleteCustomer(String getCustomerID)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + SystemMethodsCustomer.tblname2 + " WHERE CustomerID = '" + getCustomerID + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }


        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
        //------------------------------------------------------Delete Customer--------------------------------------------------
    }
}
