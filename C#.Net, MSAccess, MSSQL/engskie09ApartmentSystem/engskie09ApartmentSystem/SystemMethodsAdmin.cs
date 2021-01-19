
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engskie09ApartmentSystem
{
    class SystemMethodsAdmin
    {   
        
        public static String MySqlConnectionString = Program.MySqlConnectionString;
        public static MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();

        public static String tblname1 = "adminsession_myaccount";
        public static String tblname2 = "adminsession_reports";
        public static String tblname3 = "adminsession_myaccount";

        //set staff Information.
        public static string setAdminFirstname = "";
        public static string setAdminMiddlename = "";
        public static string setAdminLastname = "";
        public static string setAdminBirthday = "";
        public static string setAdminGender = "";
        public static string setAdminAge = "";
        public static string setAdminID = "";
        public static string setAdminUsername = "";
        public static string setAdminPassword = "";

        public static void LoginSessionAdmin(String getUsername, String getPassword)
        {

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname1 + " WHERE AdminUsername ='" + getUsername + "' AND AdminPassword= '" + getPassword + "' ";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    setAdminFirstname = dr["AdminFirstname"].ToString();
                    setAdminMiddlename = dr["AdminMiddlename"].ToString();
                    setAdminLastname = dr["AdminLastname"].ToString();
                    setAdminBirthday = dr["AdminBirthday"].ToString();
                    setAdminGender = dr["AdminGender"].ToString();
                    setAdminID = dr["AdminID"].ToString();
                    setAdminUsername = dr["AdminUsername"].ToString();
                    setAdminPassword = dr["AdminPassword"].ToString();
                }
                getAdminAge(setAdminBirthday);
            }
            connection.Close();
        }

        public static void getAdminAge(String getAdminBirthday)
        {
            DateTime getStaffBirthdate = Convert.ToDateTime(getAdminBirthday);
            DateTime getCurrentDate = DateTime.Now;
            int getAdminAgebyYear = 0;

            if (DateTime.IsLeapYear(getCurrentDate.Year))
            {
                getAdminAgebyYear = (getCurrentDate - getStaffBirthdate).Days / 365;
                setAdminAge = getAdminAgebyYear.ToString();
            }
            else if (!DateTime.IsLeapYear(getCurrentDate.Year))
            {
                getAdminAgebyYear = (getCurrentDate - getStaffBirthdate).Days / 366;
                setAdminAge = getAdminAgebyYear.ToString();
            }
        }

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

        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------

        public static void addStaff(String getStaffFirstname, String getStaffMiddlename, String getStaffLastname,
                                       String getStaffBirthday, String getStaffGender, String getStaffID,
                                       String getStaffUsername, String getStaffPassword)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumns = "(StaffFirstname, StaffMiddlename, StaffLastname, StaffBirthday, StaffGender, StaffID, StaffUsername, StaffPassword)";
            String MySqlQueryValues = "(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + SystemMethodsStaff.tblname1 + " " + MySqlQueryColumns + " VALUES" + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", getStaffFirstname);
            cmd.Parameters.AddWithValue("@a2", getStaffMiddlename);
            cmd.Parameters.AddWithValue("@a3", getStaffLastname);
            cmd.Parameters.AddWithValue("@a4", getStaffBirthday);
            cmd.Parameters.AddWithValue("@a5", getStaffGender);
            cmd.Parameters.AddWithValue("@a6", getStaffID);
            cmd.Parameters.AddWithValue("@a7", getStaffUsername);
            cmd.Parameters.AddWithValue("@a8", getStaffPassword);
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        public static void updateStaff(String getstaffFirstname, String getstaffMiddlename, String getstaffLastname,
                                       String getstaffBirthday, String getstaffGender, String getstaffID,
                                       String getstaffUsername, String getstaffPassword)
        {
            connection.Close();
            connection.Open();
            String MySqlQueryColumnsVal = "staffFirstname = @a1, staffMiddlename = @a2, staffLastname = @a3, staffBirthday = @a4, staffGender = @a5, staffID = @a6, staffUsername = @a7, staffPassword = @a8";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + SystemMethodsStaff.tblname1 + " SET " + MySqlQueryColumnsVal + " WHERE staffID = '" + getstaffID + "' ";
            cmd.Parameters.AddWithValue("@a1", getstaffFirstname);
            cmd.Parameters.AddWithValue("@a2", getstaffMiddlename);
            cmd.Parameters.AddWithValue("@a3", getstaffLastname);
            cmd.Parameters.AddWithValue("@a4", getstaffBirthday);
            cmd.Parameters.AddWithValue("@a5", getstaffGender);
            cmd.Parameters.AddWithValue("@a6", getstaffID);
            cmd.Parameters.AddWithValue("@a7", getstaffUsername);
            cmd.Parameters.AddWithValue("@a8", getstaffPassword);
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        public static void getAllStaffInformation()
        {

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + SystemMethodsStaff.tblname1 + "";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            connection.Close();
        }

        public static void deleteStaff(String getStaffID)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + SystemMethodsStaff.tblname1 + " WHERE StaffID = '" + getStaffID + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------
        //-----------------------------------------------------------Staff-------------------------------------------------------

        //----------------------------------------------------------Reports------------------------------------------------------
        //----------------------------------------------------------Reports------------------------------------------------------
        //----------------------------------------------------------Reports------------------------------------------------------
        //----------------------------------------------------------Reports------------------------------------------------------
        //----------------------------------------------------------Reports------------------------------------------------------

        public static void getReportCheckInOut()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname2 + "";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            connection.Close();
        }

        //set Customer Check In Information    
        public static void insert_CustomerCheckInOutReport(String getCustomerFirstname, String getCustomerMiddlename, String getCustomerLastname,
                                                  String getCustomerID, String getGender, String getCheckinDate, String getCheckOutDate,
                                                  Int32 getLengthofstay, Int32 getRoomno, String getRoomtype,
                                                  String getFloorno, Int32 getRoomAmount, Int32 getCustomerTotalAmount, String getCustomerAction)
        {
            MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            String cmdQuerysetColumns = "INSERT INTO " + tblname2 + " (CustomerFirstname, CustomerMiddlename ,CustomerLastname, CustomerID, CustomerGender, CustomerCheckinDate, CustomerCheckoutDate, CustomerLengthofstay, CustomerRoomNo, CustomerRoomType, CustomerFloorNo, CustomerRoomAmount, CustomerTotalAmount, CustomerAction)";
            String cmdQuerysetValues = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13, @a14)";
            String cmdQueryInsert = cmdQuerysetColumns + "" + cmdQuerysetValues;
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = cmdQueryInsert;

            cmd.Parameters.AddWithValue("@a1", getCustomerFirstname);
            cmd.Parameters.AddWithValue("@a2", getCustomerMiddlename);
            cmd.Parameters.AddWithValue("@a3", getCustomerLastname);
            cmd.Parameters.AddWithValue("@a4", getCustomerID);
            cmd.Parameters.AddWithValue("@a5", getGender);
            cmd.Parameters.AddWithValue("@a6", getCheckinDate);
            cmd.Parameters.AddWithValue("@a7", getCheckOutDate);
            cmd.Parameters.AddWithValue("@a8", getLengthofstay);
            cmd.Parameters.AddWithValue("@a9", getRoomno);
            cmd.Parameters.AddWithValue("@a10", getRoomtype);
            cmd.Parameters.AddWithValue("@a11", getFloorno);
            cmd.Parameters.AddWithValue("@a12", getRoomAmount);
            cmd.Parameters.AddWithValue("@a13", getCustomerTotalAmount);
            cmd.Parameters.AddWithValue("@a14", getCustomerAction);
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        public static void updateAdminPassword(String getAdminID, String getAdminPassword)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + tblname3 + " SET AdminPassword = @a1 WHERE AdminID = @a2";
            cmd.Parameters.AddWithValue("@a1", getAdminPassword);
            cmd.Parameters.AddWithValue("@a2", getAdminID);
            cmd.ExecuteNonQuery();

            cmd.CommandText = "UPDATE " + SystemMethodsGeneral.tblname2 + " SET User_Password = @a3 WHERE User_ID = @a4";
            cmd.Parameters.AddWithValue("@a3", getAdminPassword);
            cmd.Parameters.AddWithValue("@a4", getAdminID);
           
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        


    }
}
