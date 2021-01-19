/*                                                                                                                          
8 888888888o.            .8.          8 8888888888       .8.          8 8888888888   8 8888                                           
8 8888    `88.          .888.         8 8888            .888.         8 8888         8 8888                                           
8 8888     `88         :88888.        8 8888           :88888.        8 8888         8 8888                                           
8 8888     ,88        . `88888.       8 8888          . `88888.       8 8888         8 8888                                           
8 8888.   ,88'       .8. `88888.      8 888888888888 .8. `88888.      8 888888888888 8 8888                                           
8 888888888P'       .8`8. `88888.     8 8888        .8`8. `88888.     8 8888         8 8888                                           
8 8888`8b          .8' `8. `88888.    8 8888       .8' `8. `88888.    8 8888         8 8888                                           
8 8888 `8b.       .8'   `8. `88888.   8 8888      .8'   `8. `88888.   8 8888         8 8888                                           
8 8888   `8b.    .888888888. `88888.  8 8888     .888888888. `88888.  8 8888         8 8888                                           
8 8888     `88. .8'       `8. `88888. 8 8888    .8'       `8. `88888. 8 888888888888 8 888888888888                                   
                                                                                                                                      
b.             8     ,o888888o.     8 888888888o   8 8888         8 8888888888    8888888888',8888'        .8.                        
888o.          8  . 8888     `88.   8 8888    `88. 8 8888         8 8888                 ,8',8888'        .888.                       
Y88888o.       8 ,8 8888       `8b  8 8888     `88 8 8888         8 8888                ,8',8888'        :88888.                      
.`Y888888o.    8 88 8888        `8b 8 8888     ,88 8 8888         8 8888               ,8',8888'        . `88888.                     
8o. `Y888888o. 8 88 8888         88 8 8888.   ,88' 8 8888         8 888888888888      ,8',8888'        .8. `88888.                    
8`Y8o. `Y88888o8 88 8888         88 8 8888888888   8 8888         8 8888             ,8',8888'        .8`8. `88888.                   
8   `Y8o. `Y8888 88 8888        ,8P 8 8888    `88. 8 8888         8 8888            ,8',8888'        .8' `8. `88888.                  
8      `Y8o. `Y8 `8 8888       ,8P  8 8888      88 8 8888         8 8888           ,8',8888'        .8'   `8. `88888.                 
8         `Y8o.`  ` 8888     ,88'   8 8888    ,88' 8 8888         8 8888          ,8',8888'        .888888888. `88888.                
8            `Yo     `8888888P'     8 888888888P   8 888888888888 8 888888888888 ,8',8888888888888.8'       `8. `88888.               
          .         .                                                                                                                 
         ,8.       ,8.                   .8.            d888888o.           .8.          8 8888         8 8888         ,o888888o.     
        ,888.     ,888.                 .888.         .`8888:' `88.        .888.         8 8888         8 8888      . 8888     `88.   
       .`8888.   .`8888.               :88888.        8.`8888.   Y8       :88888.        8 8888         8 8888     ,8 8888       `8b  
      ,8.`8888. ,8.`8888.             . `88888.       `8.`8888.          . `88888.       8 8888         8 8888     88 8888        `8b 
     ,8'8.`8888,8^8.`8888.           .8. `88888.       `8.`8888.        .8. `88888.      8 8888         8 8888     88 8888         88 
    ,8' `8.`8888' `8.`8888.         .8`8. `88888.       `8.`8888.      .8`8. `88888.     8 8888         8 8888     88 8888         88 
   ,8'   `8.`88'   `8.`8888.       .8' `8. `88888.       `8.`8888.    .8' `8. `88888.    8 8888         8 8888     88 8888        ,8P 
  ,8'     `8.`'     `8.`8888.     .8'   `8. `88888.  8b   `8.`8888.  .8'   `8. `88888.   8 8888         8 8888     `8 8888       ,8P  
 ,8'       `8        `8.`8888.   .888888888. `88888. `8b.  ;8.`8888 .888888888. `88888.  8 8888         8 8888      ` 8888     ,88'   
,8'         `         `8.`8888. .8'       `8. `88888. `Y8888P ,88P'.8'       `8. `88888. 8 888888888888 8 888888888888 `8888888P'     
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace engskie09ApartmentSystem
{
    class SystemMethodsStaff
    {
        public static String MySqlConnectionString = Program.MySqlConnectionString;
        public static MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();

        public static string tblname1 = "staffsession_myaccount";

        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------

        //set staff Information.
        public static string setStaffFirstname = "";
        public static string setStaffMiddlename = "";
        public static string setStaffLastname = "";
        public static string setStaffBirthday = "";
        public static string setStaffGender = "";
        public static string setStaffAge = "";
        public static string setStaffID = "";
        public static string setStaffUsername = "";
        public static string setStaffPassword = "";

        public static void LoginSessionStaff(String getUsername, String getPassword)
        {

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblname1 + " WHERE StaffUsername ='" + getUsername + "' AND StaffPassword= '" + getPassword + "' ";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    setStaffFirstname = dr["StaffFirstname"].ToString();
                    setStaffMiddlename = dr["StaffMiddlename"].ToString();
                    setStaffLastname = dr["StaffLastname"].ToString();
                    setStaffBirthday = dr["StaffBirthday"].ToString();
                    setStaffGender = dr["StaffGender"].ToString();
                    setStaffID = dr["StaffID"].ToString();
                    setStaffUsername = dr["StaffUsername"].ToString();
                    setStaffPassword = dr["StaffPassword"].ToString();
                }
                getStaffAge(setStaffBirthday);
            }
            connection.Close();
        }

        public static void getStaffAge(String getStaffBirthday)
        {
            DateTime getStaffBirthdate = Convert.ToDateTime(getStaffBirthday);
            DateTime getCurrentDate = DateTime.Now;
            int getStaffAgebyYear = 0;

            if (DateTime.IsLeapYear(getCurrentDate.Year))
            {
                getStaffAgebyYear = (getCurrentDate - getStaffBirthdate).Days / 365;
                setStaffAge = getStaffAgebyYear.ToString();
            }
            else if (!DateTime.IsLeapYear(getCurrentDate.Year))
            {
                getStaffAgebyYear = (getCurrentDate - getStaffBirthdate).Days / 366;
                setStaffAge = getStaffAgebyYear.ToString();
            }
        }

        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------
        //------------------------------------------------------Staff Information------------------------------------------------
    }
}
