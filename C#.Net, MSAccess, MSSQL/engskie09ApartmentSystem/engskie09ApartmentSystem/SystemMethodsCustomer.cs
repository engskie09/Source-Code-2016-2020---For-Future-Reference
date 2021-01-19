using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace engskie09ApartmentSystem
{
    class SystemMethodsCustomer
    {
        public static String MySqlConnectionString = Program.MySqlConnectionString;
        public static MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();

                 
        

       
        
        //setTableName
        public static String tblname1 = "customersession_checkin";
        public static String tblname2 = "customersession_myaccount";



        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------

        //set Customer Information.
        public static string setCustomerFirstname = "";
        public static string setCustomerMiddlename = "";
        public static string setCustomerLastname = "";
        public static string setCustomerBirthday = "";
        public static string setCustomerGender = "";
        public static string setCustomerAge = "";
        public static string setCustomerID = "";
        public static string setCustomerUsername = "";
        public static string setCustomerPassword = "";
        public static string setCustomerLengthofStay = "";
        public static string setCustomerTotalAmount = "";

        public static void LoginSessionCustomer(String getUsername, String getPassword)
        {

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname2 + " WHERE CustomerUsername ='" + getUsername + "' AND CustomerPassword= '" + getPassword + "' ";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    setCustomerFirstname = dr["CustomerFirstname"].ToString();
                    setCustomerMiddlename = dr["CustomerMiddlename"].ToString();
                    setCustomerLastname = dr["CustomerLastname"].ToString();
                    setCustomerBirthday = dr["CustomerBirthday"].ToString();
                    setCustomerGender = dr["CustomerGender"].ToString();
                    setCustomerID = dr["CustomerID"].ToString();
                    setCustomerUsername = dr["CustomerUsername"].ToString();
                    setCustomerPassword = dr["CustomerPassword"].ToString();
                }
                getCustomerAge(setCustomerBirthday);                
            }
            connection.Close();
        }
        

        //ConnectedWith LoginSessionCustomer(String getUsername, String getPassword)
        public static void getCustomerAge(String getCustomerBirthday)
        {
            DateTime getCustomerBirthdate = Convert.ToDateTime(getCustomerBirthday);
            DateTime getCurrentDate = DateTime.Now;
            int getCustomerAgebyYear = 0;

            if (DateTime.IsLeapYear(getCurrentDate.Year))
            {
                getCustomerAgebyYear = (getCurrentDate - getCustomerBirthdate).Days / 365;
                setCustomerAge = getCustomerAgebyYear.ToString();
            }
            else if (!DateTime.IsLeapYear(getCurrentDate.Year))
            {
                getCustomerAgebyYear = (getCurrentDate - getCustomerBirthdate).Days / 366;
                setCustomerAge = getCustomerAgebyYear.ToString();
            }
        }

        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------
        //----------------------------------------------------Customer Information-----------------------------------------------
        

   
        

        

        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out-----------------------------------------------      
        
        //set Customer Check In Information    
        public static void insert_CustomerCheckinInformation(String getCustomerFirstname, String getCustomerMiddlename, String getCustomerLastname,
                                                  String getCustomerID, String getGender, String getCheckinDate, String getCheckOutDate,
                                                  Int32 getLengthofstay, Int32 getRoomno, String getRoomtype,
                                                  String getFloorno, Int32 getRoomAmount, Int32 getCustomerTotalAmount)
        {
            MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
            MySqlCommand cmd = new MySqlCommand();
            String cmdQuerysetColumns = "INSERT INTO " + tblname1 + " (CustomerFirstname, CustomerMiddlename ,CustomerLastname, CustomerID, CustomerGender, CustomerCheckinDate, CustomerCheckoutDate, CustomerLengthofstay, CustomerRoomNo, CustomerRoomType, CustomerFloorNo, CustomerRoomAmount, CustomerTotalAmount)";
            String cmdQuerysetValues = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13)";
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

            cmd.ExecuteNonQuery();

            connection.Close();

        }
        public static Boolean checkIfDateisBetween;

        //set CustomerID to get two Dates to validate if can Checkin Again.
        public static void setCheckinValidation(String getCustomerID)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            String getCheckInDate = "";
            String getCheckOutDate = "";

            DateTime DTCurrentDate = DateTime.Today;
            DateTime DTCheckInDate;
            DateTime DTCheckOutDate;

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CustomerCheckinDate, CustomerCheckoutDate FROM " + tblname1 +" where CustomerID = '" + getCustomerID + "'  ";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);                   

            foreach (DataRow dr in dt.Rows)
            {                
                getCheckInDate  =   dr["CustomerCheckinDate"].ToString();
                getCheckOutDate =   dr["CustomerCheckoutDate"].ToString();

                DTCheckInDate = Convert.ToDateTime(getCheckInDate);
                DTCheckOutDate = Convert.ToDateTime(getCheckOutDate);

                String a = DTCheckInDate.ToString("MM/dd/yyyy");
                String b = DTCheckOutDate.ToString("MM/dd/yyyy");
                String c = DTCurrentDate.ToString("MM/dd/yyyy");

                if (DTCheckInDate <= DTCurrentDate && DTCurrentDate <= DTCheckOutDate)
                {
                    //MessageBox.Show(a + " " + b + " Is between " + c);
                    checkIfDateisBetween = true;
                }

                else
                  
                {
                    //MessageBox.Show(a + " " + b + " Not between "+c);
                    checkIfDateisBetween = false;
                }

                break;
            }

            connection.Close();
        }       

        //set Check Out Customer
        public static void delete_customerCheckinInformation(String getCustomerID)
        {
            

            connection.Close();
            connection.Open();
            
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + tblname1 + " WHERE CustomerID = '" + getCustomerID + "'";
            cmd.ExecuteNonQuery();

            connection.Close();

            checkIfDateisBetween = false;
        }

        //set Room Availability When Check in.
        public static void setRoomAvailabilityWhenCheckin(Int32 getRoomNo)
        {           

            
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + SystemMethodsGeneral.tblname1 + " SET RoomAvailability = @a1 WHERE RoomNo = '" + getRoomNo + "'";
            cmd.Parameters.AddWithValue("@a1", 1);
            cmd.ExecuteNonQuery();

            connection.Close();


        }
 
        //set Room Availability When Check Out.
        public static void setRoomAvailabilityWhenCheckout(Int32 getRoomNo)
        {           


            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + SystemMethodsGeneral.tblname1 + " SET RoomAvailability = @a1 WHERE RoomNo = '" + getRoomNo + "'";
            cmd.Parameters.AddWithValue("@a1", 0);
            cmd.ExecuteNonQuery();

            connection.Close();
        }


        public static Boolean checkCustomerRoomNoIfcheckin;
        public static Int32 getCustomerRoomNo = 0;

        //get Room No. If Customer already Checked in and set Boolean to Check Out.
        public static void getsetRoomNobyCustomerIDsetBooleanToCheckOut(String getCustomerID)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CustomerRoomNo FROM " + tblname1 + " WHERE CustomerID = '" + getCustomerID + "'";            
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    getCustomerRoomNo = Convert.ToInt32(dr["CustomerRoomNo"]);
                }

                checkCustomerRoomNoIfcheckin = true;
            }

            else
            {
                checkCustomerRoomNoIfcheckin = false;
            }            

            connection.Close();

        }

        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out----------------------------------------------- 
        //----------------------------------------------------Check In - Check Out----------------------------------------------- 

        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 


        public static string setCustomerRoomInformation_FirstName = "";
        public static string setCustomerRoomInformation_MiddleName = "";
        public static string setCustomerRoomInformation_LastName = "";

        public static string setCustomerRoomInformation_CheckInDate = "";
        public static string setCustomerRoomInformation_CheckOutDate = "";

        public static string setCustomerRoomInformation_RoomNo = "";
        public static string setCustomerRoomInformation_FloorNo = "";
        public static string setCustomerRoomInformation_RoomType = "";
        public static string setCustomerRoomInformation_RoomAmount = "";

        public static void select_customerCurrentReserve(String getCustomerID)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname1 + " WHERE CustomerID = '" + getCustomerID + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            setCustomerRoomInformation_FirstName    = dr["CustomerFirstname"].ToString();
            setCustomerRoomInformation_MiddleName   = dr["CustomerMiddlename"].ToString();
            setCustomerRoomInformation_LastName     = dr["CustomerLastname"].ToString();

            setCustomerRoomInformation_CheckInDate  = dr["CustomerCheckinDate"].ToString();
            setCustomerRoomInformation_CheckOutDate = dr["CustomerCheckoutDate"].ToString();

            setCustomerLengthofStay                 = dr["CustomerLengthofstay"].ToString();

            setCustomerRoomInformation_RoomNo       = dr["CustomerRoomNo"].ToString();
            setCustomerRoomInformation_FloorNo      = dr["CustomerFloorNo"].ToString();
            setCustomerRoomInformation_RoomType     = dr["CustomerRoomType"].ToString();
            setCustomerRoomInformation_RoomAmount   = dr["CustomerRoomAmount"].ToString();

            setCustomerTotalAmount = dr["CustomerTotalAmount"].ToString();
            connection.Close();
        }


        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 
        //-------------------------------------------------Customer Room Information--------------------------------------------- 


    }
}

