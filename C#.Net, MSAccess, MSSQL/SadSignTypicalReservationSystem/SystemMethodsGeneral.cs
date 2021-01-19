using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SadSignTypicalReservationSystem
{
    class SystemMethodsGeneral
    {
        public static String MySqlConnectionString = "server=localhost;user id=root;database=sadsigntypicalreservationsystem";
        public static MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();
        public static String tblname1 = "generalsessions_viewrooms";
        public static String tblname2 = "generalsessions_userinformation";
        public static String tblname3 = "generalsessions_ID_autoincrement";


        public static Boolean checkAccountExist;

        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------

        public static String getUserType = "";

        public static void getLoginSessionName(String getUsername, String getUserPassword)
        {
            dt.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT User_Type From " + tblname2 + " WHERE User_Name = '" + getUsername + "' AND User_Password = '" + getUserPassword + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];

                getUserType = dr["User_Type"].ToString();
                checkAccountExist = true;

            }

            else
            {
                checkAccountExist = false;
            }
            
            connection.Close();
            

        }

        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------
        //-----------------------------------------------------------Login--------------------------------------------------------

        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------

        //set Customer Room Information/
        public static Int32 setRoomNo = 0;
        public static string setFloorNo = "";
        public static string setRoomType = "";
        public static Int32 setRoomAmount = 0;
        public static string setRoomAvailability = "";

        public static void getRoomInformation(Int32 getRoomNo)
        {
            setRoomNo = 0;
            setFloorNo = "";
            setRoomType = "";
            setRoomAmount = 0;
            setRoomAvailability = "";

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname1 + " WHERE RoomNo = '" + getRoomNo + "'";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                setRoomNo = Convert.ToInt32(dr["RoomNo"].ToString());
                setFloorNo = dr["FloorNo"].ToString();
                setRoomType = dr["RoomType"].ToString();
                setRoomAmount = Convert.ToInt32(dr["RoomAmount"].ToString());
                setRoomAvailability = dr["RoomAvailability"].ToString();
            }

           
            
            connection.Close();
        }

        public static void setDGVRoomlist(String getFloorNo)
        {

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname1 + " WHERE FloorNo ='" + getFloorNo + "'";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);        
      
            connection.Close();

        }

        //get RoomInformation by selected RoomNo.
        /*public static void getRoomInformationbySelectedRoomNo(Int32 getRoomNo)
        {

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname1 + " where RoomNo = '" + getRoomNo + "' ";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                setFloorNo = dr["FloorNo"].ToString();
                setRoomType = dr["RoomType"].ToString();
                setRoomAmount = Convert.ToInt32(dr["RoomAmount"].ToString());
            }

            connection.Close();

        }*/

        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------
        //------------------------------------------------------Room Information-------------------------------------------------

        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------

        public static String getCustomer_ID = "";
        public static Int32 increment = 0;

        public static void getCustomerID()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
            increment = 0;

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT increment_current from " + tblname3 + " WHERE increment_name = 'user_customer'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            increment = 1 + Convert.ToInt32(dr["increment_current"].ToString());
            getCustomer_ID = "100-" + increment;
            connection.Close();        

        }

        public static void updateCustomerID()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
            increment = 0;

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT increment_current from " + tblname3 + " WHERE increment_name = 'user_customer' ";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
                
            DataRow dr = dt.Rows[0];

            increment = 1 + Convert.ToInt32(dr["increment_current"].ToString());

            MessageBox.Show(increment.ToString());
            cmd.CommandText = "UPDATE " + tblname3 + " SET increment_current = '" + increment + "' WHERE increment_name = 'user_customer' ";
            cmd.ExecuteNonQuery();
            connection.Close();    
        }





        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------
        //--------------------------------------------------------Customer ID----------------------------------------------------

        public static void addUserLogin(String getUser_ID, String getUserName, String getPassword, String getUserType)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumns = "(User_ID, User_Name, User_Password, User_Type)";
            String MySqlQueryValues = "(@a1,@a2,@a3, @a4)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblname2 + " " + MySqlQueryColumns + " VALUES" + MySqlQueryValues + "";

            cmd.Parameters.AddWithValue("@a1", getUser_ID);
            cmd.Parameters.AddWithValue("@a2", getUserName);
            cmd.Parameters.AddWithValue("@a3", getPassword);
            cmd.Parameters.AddWithValue("@a4", getUserType);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void updateUserLogin(String getUser_ID, String getUserName, String getPassword, String getUserType)
        {
            connection.Close();
            connection.Open();
            String MySqlQueryColumnsVal = "User_ID = @a1, User_Name = @a2, User_Password = @a3, User_Type = @a4";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + tblname2 + " SET " + MySqlQueryColumnsVal + " WHERE User_ID = '" + getUser_ID + "' ";
            cmd.Parameters.AddWithValue("@a1", getUser_ID);
            cmd.Parameters.AddWithValue("@a2", getUserName);
            cmd.Parameters.AddWithValue("@a3", getPassword);
            cmd.Parameters.AddWithValue("@a4", getUserType);
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        public static void deleteUserLogin(String getUser_ID)
        {
            connection.Close();
            connection.Open();
           
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + tblname2 + " WHERE User_ID = '" + getUser_ID + "'";            
            cmd.ExecuteNonQuery();
            
            connection.Close();
        }
    }
}
