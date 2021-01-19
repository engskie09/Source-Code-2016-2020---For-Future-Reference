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
using System.Windows.Forms;

namespace SadSignTypicalReservationSystem
{
    class SystemMethodsAdminStaff
    {
        public static String MySqlConnectionString = "server=localhost;user id=root;database=sadsigntypicalreservationsystem";
        public static MySqlConnection connection = new MySqlConnection(MySqlConnectionString);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();

        public static string tblname1 = "";

        public static void getAllCustomerInformation()
        {

            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + SystemMethodsCustomer.tblname2 + "";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            
            connection.Close();
        }

        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------
        
    
        public static void addCustomer(String getCustomerFirstname, String getCustomerMiddlename, String getCustomerLastname,
                                       String getCustomerBirthday, String getCustomerGender, String getCustomerID,
                                       String getCustomerUsername, String getCustomerPassword)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumns = "(CustomerFirstname, CustomerMiddlename, CustomerLastname, CustomerBirthday, CustomerGender, CustomerID, CustomerUsername, CustomerPassword)";
            String MySqlQueryValues = "(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + SystemMethodsCustomer.tblname2 + " " + MySqlQueryColumns + " VALUES" + MySqlQueryValues + "";
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

        

        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------
        //-------------------------------------------------------Add Customer----------------------------------------------------

        
        
    }
}
