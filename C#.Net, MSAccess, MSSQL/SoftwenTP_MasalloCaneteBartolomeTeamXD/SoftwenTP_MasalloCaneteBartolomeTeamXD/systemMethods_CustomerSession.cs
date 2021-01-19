/*                            
        --------------------------------------------------------------------------------------------------------------
        8 888888888o      .8.    8888888 8888888888 8 888888888o.    8 8888     ,o888888o.     8 8888          .8.          
        8 8888    `88.   .888.         8 8888       8 8888    `88.   8 8888    8888     `88.   8 8888         .888.         
        8 8888     `88  :88888.        8 8888       8 8888     `88   8 8888 ,8 8888       `8.  8 8888        :88888.        
        8 8888     ,88 . `88888.       8 8888       8 8888     ,88   8 8888 88 8888            8 8888       . `88888.       
        8 8888.   ,88'.8. `88888.      8 8888       8 8888.   ,88'   8 8888 88 8888            8 8888      .8. `88888.      
        8 888888888P'.8`8. `88888.     8 8888       8 888888888P'    8 8888 88 8888            8 8888     .8`8. `88888.     
        8 8888      .8' `8. `88888.    8 8888       8 8888`8b        8 8888 88 8888            8 8888    .8' `8. `88888.    
        8 8888     .8'   `8. `88888.   8 8888       8 8888 `8b.      8 8888 `8 8888       .8'  8 8888   .8'   `8. `88888.   
        8 8888    .888888888. `88888.  8 8888       8 8888   `8b.    8 8888    8888     ,88'   8 8888  .888888888. `88888.  
        8 8888   .8'       `8. `88888. 8 8888       8 8888     `88.  8 8888     `8888888P'     8 8888 .8'       `8. `88888.
        --------------------------------------------------------------------------------------------------------------
        */



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
using System.Windows.Forms;
using System.Data;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    class systemMethods_CustomerSession
    {
        public static String MySqlconnection = "datasource=localhost;port=3306;username=root;password=;database=softwentp_masallocanetebartolometeamxd;sslmode=none;";

        public static MySqlConnection connection = new MySqlConnection(MySqlconnection);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();

        public static DataTable dt = new DataTable();

        public static String tblName1 = "customersession_member_personalinformation";
        public static String tblName2 = "customersession_member_contactinformation";
        

        //get List of Group_Name and Class_Name for Registration.
        public static List<String> getGroupName= new List<String>();
        public static List<String> getClassName = new List<String>();

        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------

        //set Member Personal Information
        public static void setcustomer_personalinformation(String setcustomer_MemberID, String setcustomer_FirstName, String setcustomer_MiddleName,
                                                         String setcustomer_Lastname, String setcustomer_Gender, String setcustomer_DateofBirth,
                                                         String setcustomer_Class, String setcustomer_Group)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumnName = "(customer_MemberID, customer_FirstName, customer_MiddleName, customer_Lastname, customer_Gender, customer_DateofBirth, customer_Class, customer_Group)";
            String MySqlQueryValues = "Values(@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName1 + " " + MySqlQueryColumnName + " " + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", setcustomer_MemberID);
            cmd.Parameters.AddWithValue("@a2", setcustomer_FirstName);
            cmd.Parameters.AddWithValue("@a3", setcustomer_MiddleName);
            cmd.Parameters.AddWithValue("@a4", setcustomer_Lastname);
            cmd.Parameters.AddWithValue("@a5", setcustomer_Gender);
            cmd.Parameters.AddWithValue("@a6", setcustomer_DateofBirth);
            cmd.Parameters.AddWithValue("@a7", setcustomer_Class);
            cmd.Parameters.AddWithValue("@a8", setcustomer_Group);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------
        //---------------------------------------------------------Personal Informaiton--------------------------------------------------------

        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------

        //set Member Contact Information
        public static void setcustomer_contactinformation(String setcustomer_MemberID, String setcustomer_Address, String setcustomer_City,
                                                         String setcustomer_State, String setcustomer_Zipcode, String setcustomer_Mobilenumber,
                                                         String setcustomer_Phone, String setcustomer_Email)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumnName = "(customer_MemberID, customer_Address, customer_City, customer_State, customer_Zipcode, customer_Mobilenumber, customer_Phone, customer_Email)";
            String MySqlQueryValues = "Values(@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName2 + " " + MySqlQueryColumnName + " " + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", setcustomer_MemberID);
            cmd.Parameters.AddWithValue("@a2", setcustomer_Address);
            cmd.Parameters.AddWithValue("@a3", setcustomer_City);
            cmd.Parameters.AddWithValue("@a4", setcustomer_State);
            cmd.Parameters.AddWithValue("@a5", setcustomer_Zipcode);
            cmd.Parameters.AddWithValue("@a6", setcustomer_Mobilenumber);
            cmd.Parameters.AddWithValue("@a7", setcustomer_Phone);
            cmd.Parameters.AddWithValue("@a8", setcustomer_Email);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------
        //---------------------------------------------------------Contact Informaiton---------------------------------------------------------

        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------

        //set Member Login Information
        public static void setcustomer_Logininformation(String setMember_ID, String setMember_Username, String setMember_Password,
                                                      String setMember_Role, Byte[] setMember_Image)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumnName = "(Member_ID, Member_Username, Member_Password, Member_Role, Member_Image)";
            String MySqlQueryValues = "Values(@a1, @a2, @a3, @a4, @a5)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + systemMethods_GeneralSession.tblName5 + " " + MySqlQueryColumnName + " " + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", setMember_ID);
            cmd.Parameters.AddWithValue("@a2", setMember_Username);
            cmd.Parameters.AddWithValue("@a3", setMember_Password);
            cmd.Parameters.AddWithValue("@a4", setMember_Role);
            cmd.Parameters.AddWithValue("@a5", setMember_Image);

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------
        //----------------------------------------------------------Login Informaiton----------------------------------------------------------

        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------

        //get Group_Name and set to List
        public static void getset_groupName()
        {            
            dt.Rows.Clear();
            dt.Columns.Clear();
            getGroupName.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Group_Name FROM " + systemMethods_GeneralSession.tblName2  + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                getGroupName.Add(dr["Group_Name"].ToString());
            }

            connection.Close();
        }
        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------
        //-------------------------------------------------------------Group Name--------------------------------------------------------------

        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------

        //get Class_Name and set to List
        public static void getset_className()
        {            
            dt.Rows.Clear();
            dt.Columns.Clear();
            getClassName.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Class_Name FROM " + systemMethods_GeneralSession.tblName3 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                getClassName.Add(dr["Class_Name"].ToString());
            }

            connection.Close();
        }
        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------
        //-------------------------------------------------------------Class Name--------------------------------------------------------------

    }
}
