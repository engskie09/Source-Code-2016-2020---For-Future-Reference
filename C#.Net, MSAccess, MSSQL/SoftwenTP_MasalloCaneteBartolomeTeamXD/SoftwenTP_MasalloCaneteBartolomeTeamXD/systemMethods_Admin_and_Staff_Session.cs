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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;



namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{

    class systemMethods_Admin_and_Staff_Session
    {

        public static String MySqlconnection = "datasource=localhost;port=3306;username=root;password=;database=softwentp_masallocanetebartolometeamxd;sslmode=none;";

        public static MySqlConnection connection = new MySqlConnection(MySqlconnection);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();

        public static DataTable dt = new DataTable();

        public static String tblName1 = "adminstaffsession1_productlist";
        public static String tblName2 = "adminstaffsession1_salesrecord";

        
        
        /*                            
        --------------------------------------------------------------------------------------------------------------
        8 888888888o      .8.    8888888 8888888888 8 888888888o.    8 8888     ,o888888o.     8 8888          .8.          
        8 8888    `88.   .888.         8 8888       8 8888    `88.   8 8888    8888     `88.   8 8888         .888.         
        8 8888     `88  :88888.        8 8888       8 8888     `88   8 8888 ,8 8888       `8.  8 8888        :88888.        
        8 8888     ,88 . `88888.       8 8888       8 8888     ,88   8 8888 88 888            8 8888       . `88888.       
        8 8888.   ,88'.8. `88888.      8 8888       8 8888.   ,88'   8 8888 88 8888            8 8888      .8. `88888.      
        8 888888888P'.8`8. `88888.     8 8888       8 888888888P'    8 8888 88 8888            8 8888     .8`8. `88888.     
        8 8888      .8' `8. `88888.    8 8888       8 8888`8b        8 8888 88 8888            8 8888    .8' `8. `88888.    
        8 8888     .8'   `8. `88888.   8 8888       8 8888 `8b.      8 8888 `8 8888       .8'  8 8888   .8'   `8. `88888.   
        8 8888    .888888888. `88888.  8 8888       8 8888   `8b.    8 8888    8888     ,88'   8 8888  .888888888. `88888.  
        8 8888   .8'       `8. `88888. 8 8888       8 8888     `88.  8 8888     `8888888P'     8 8888 .8'       `8. `88888.
        --------------------------------------------------------------------------------------------------------------
        */

        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------        

        public static String getMembership_Name = "", getInstallment_Plan = "";
        public static Int32 getMembership_Period = 0, getSignup_Fee = 0;
        public static Byte[] getMembership_Image = null;

        //set Membership Type.
        public static void set_Membershiptype(Byte[] addsetMembershipImage, String addsetMembershipName, Int32 addsetMembershipPeriod, String addsetInstallmentplan,
                                              Int32 addsetSignupfee)
        {

            connection.Close();
            connection.Open();

            String MySqlQueryColumnNames = "(Photo, Membership_Name, Membership_Period, Installment_Plan, Signup_Fee)";
            String MySqlQueryValues = "VALUES(@a1, @a2, @a3, @a4, @a5)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = "INSERT INTO " + systemMethods_GeneralSession.tblName1 + " " + MySqlQueryColumnNames + " " + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", addsetMembershipImage);
            cmd.Parameters.AddWithValue("@a2", addsetMembershipName);
            cmd.Parameters.AddWithValue("@a3", addsetMembershipPeriod);
            cmd.Parameters.AddWithValue("@a4", addsetInstallmentplan);
            cmd.Parameters.AddWithValue("@a5", addsetSignupfee);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //set update Membership Type.
        public static void setUpdate_Membershiptype(String getMembershipNameAsPrimaryKey, Byte[] updatesetMembershipImage, String updatesetMembershipName, Int32 updatesetMembershipPeriod, String updatesetInstallmentplan,
                                              Int32 updatesetSignupfee)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + systemMethods_GeneralSession.tblName1 + " SET Photo = @a1, Membership_Name = @a2, Membership_Period =@a3, Installment_Plan=@a4, Signup_Fee=@a5 Where Membership_Name = @a6";
            cmd.Parameters.AddWithValue("@a1", updatesetMembershipImage);
            cmd.Parameters.AddWithValue("@a2", updatesetMembershipName);
            cmd.Parameters.AddWithValue("@a3", updatesetMembershipPeriod);
            cmd.Parameters.AddWithValue("@a4", updatesetInstallmentplan);
            cmd.Parameters.AddWithValue("@a5", updatesetSignupfee);
            cmd.Parameters.AddWithValue("@a6", getMembershipNameAsPrimaryKey);
            
            cmd.ExecuteNonQuery();            
            connection.Close();
        }

        //delete Membership Type.
        public static void delete_Membershiptype(String getMembershipNameAsPrimaryKey)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + systemMethods_GeneralSession.tblName1 + " WHERE Membership_Name = '" + getMembershipNameAsPrimaryKey + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        
        //get_Membershiptype to Update
        public static void get_Membershiptype(String setMembership_Name)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + systemMethods_GeneralSession.tblName1 + " WHERE Membership_Name = '" + setMembership_Name + "' ";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            getMembership_Image = (Byte[])dr["Photo"];
            getMembership_Name = dr["Membership_Name"].ToString();
            getMembership_Period = Convert.ToInt32(dr["Membership_Period"].ToString());
            getInstallment_Plan = dr["Installment_Plan"].ToString();
            getSignup_Fee = Convert.ToInt32(dr["Signup_Fee"].ToString());

            connection.Close();

        }

        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------


        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------        

        public static String getGroup_Name = "";
        public static Byte[] getGroup_Image = null;

        //set Group to insert to generalsession_group.
        public static void set_Group(Byte[] addGroupImage, String addsetGroupName, Int32 addsetTotal_Group_Members)
        {

            connection.Close();
            connection.Open();

            String MySqlQueryColumnNames = "(Photo, Group_Name, Total_Group_Members)";
            String MySqlQueryValues = "VALUES(@a1, @a2, @a3)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + systemMethods_GeneralSession.tblName2 + " " + MySqlQueryColumnNames + " " + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", addGroupImage);
            cmd.Parameters.AddWithValue("@a2", addsetGroupName);
            cmd.Parameters.AddWithValue("@a3", addsetTotal_Group_Members);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //get Group
        public static void get_Group(String getGroupname)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + systemMethods_GeneralSession.tblName2 + " WHERE Group_Name = '" + getGroupname + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow dr = dt.Rows[0];
            getGroup_Name = dr["Group_Name"].ToString();
            getGroup_Image = (Byte[])dr["Photo"];

            
            connection.Close();
        }

        //get and update generalsession_group.
        public static void setupdate_Group(String getGroupnameAsPrimaryKey, String updateGroupname, Byte[] getGroupImage)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + systemMethods_GeneralSession.tblName2 + " SET Group_Name = @a1, Photo = @a2 WHERE Group_Name = @a3";
            cmd.Parameters.AddWithValue("@a1", updateGroupname);
            cmd.Parameters.AddWithValue("@a2", getGroupImage);
            cmd.Parameters.AddWithValue("@a3", getGroupnameAsPrimaryKey);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //delete Group
        public static void delete_Group(String getGroupnameAsPrimaryKey)
        {
            connection.Close();
            connection.Open();

            cmd.Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + systemMethods_GeneralSession.tblName2 + " WHERE Group_Name = '" + getGroupnameAsPrimaryKey + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------
        //----------------------------------------------------------------Group----------------------------------------------------------------

        //------------------------------------------------------------Class Schedule-----------------------------------------------------------
        //------------------------------------------------------------Class Schedule-----------------------------------------------------------
        //------------------------------------------------------------Class Schedule-----------------------------------------------------------
        //------------------------------------------------------------Class Schedule-----------------------------------------------------------

        //set Class Schedulez
        public static void set_Classschedule(String addClassName,String addClass_Staffname,String addClass_StartTime,String addClass_EndTime,
                                             String addClass_StartTimemeridiem,String addClass_EndTimemeridiem,String addClass_Days,String addClass_Location)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumnNames = "(Class_Name, Class_Staffname, Class_StartTime, Class_EndTime, Class_StartTimemeridiem, Class_EndTimemeridiem,Class_Days, Class_Location)";
            String MySqlQueryValues = "VALUES(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + systemMethods_GeneralSession.tblName3 + " " + MySqlQueryColumnNames + " " + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", addClassName);
            cmd.Parameters.AddWithValue("@a2", addClass_Staffname);
            cmd.Parameters.AddWithValue("@a3", addClass_StartTime);
            cmd.Parameters.AddWithValue("@a4", addClass_EndTime);
            cmd.Parameters.AddWithValue("@a5", addClass_StartTimemeridiem);
            cmd.Parameters.AddWithValue("@a6", addClass_EndTimemeridiem);
            cmd.Parameters.AddWithValue("@a7", addClass_Days);
            cmd.Parameters.AddWithValue("@a8", addClass_Location);
            cmd.ExecuteNonQuery();
            connection.Close();


        }
        //------------------------------------------------------------Class Schedule-----------------------------------------------------------
        //------------------------------------------------------------Class Schedule-----------------------------------------------------------
        //------------------------------------------------------------Class Schedule-----------------------------------------------------------
        //------------------------------------------------------------Class Schedule-----------------------------------------------------------

        //----------------------------------------------------------Store And Products---------------------------------------------------------
        //----------------------------------------------------------Store And Products---------------------------------------------------------
        //----------------------------------------------------------Store And Products---------------------------------------------------------
        //----------------------------------------------------------Store And Products---------------------------------------------------------

        public static List<String> getProductName = new List<String>();
        public static List<String> getCustomerFullName = new List<String>();
        public static List<String> getCustomerID = new List<String>();

        //set Product to adminstaffsession1_productlist.
        public static void set_product(String getProduct_Name, Int32 getProduct_Price, String getProduct_Quantity)
        {            
            connection.Close();
            connection.Open();

            String MySqlQueryColumnNames = "(Product_Name, Product_Price, Product_Quantity)";
            String MySqlQueryValues = "VALUES(@a1, @a2, @a3)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName1 + "" + MySqlQueryColumnNames + "" + MySqlQueryValues + "";
            cmd.Parameters.AddWithValue("@a1", getProduct_Name);
            cmd.Parameters.AddWithValue("@a2", getProduct_Price);
            cmd.Parameters.AddWithValue("@a3", getProduct_Quantity);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        
        //set dgvProductList value.
        //get and set Product_Name to ComboBox to sell Products.
        public static void get_product()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            getProductName.Clear();

            connection.Close();
            connection.Open();       

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName1 + "";            
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                getProductName.Add(dr["Product_Name"].ToString());
            }

            connection.Close();
        }
         
        //get and set Customer Full_Name and set to ComboBox to Sell Products.
        public static void getset_CustomerFullname()
        {        
            dt.Rows.Clear();
            dt.Columns.Clear();

            getCustomerFullName.Clear();
            getCustomerID.Clear();

            connection.Close();
            connection.Open();

            String MySqlQUeryCOlumns = "customer_MemberID ,CONCAT(customer_FirstName,' ',customer_Lastname) AS customer_Fullname";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT " + MySqlQUeryCOlumns + " FROM " + systemMethods_CustomerSession.tblName1 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                getCustomerID.Add(dr["customer_MemberID"].ToString());
                getCustomerFullName.Add(dr["customer_Fullname"].ToString());
            }           

            connection.Close();                
        }

        //get and set Product to sell
        public static void getset_sellProduct(String getProduct_Name, Int32 getProduct_quantityTobuy)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Product_Quantity FROM " + tblName1 + " WHERE Product_Name = '" + getProduct_Name + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow dr = dt.Rows[0];
            
            Int32 getCurrentProductquantity = Convert.ToInt32(dr["Product_Quantity"].ToString());

            Int32 getTotalProductquantity = getCurrentProductquantity - getProduct_quantityTobuy;

            cmd.CommandText = "UPDATE " + tblName1 + " SET Product_Quantity='" + getTotalProductquantity + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            
        }

        //set product_salesreport to insert to adminstaffsession1_salesrecord.
        public static void setproduct_salesreport(String getProduct_Name, String getCustomer_FullName, Int32 getTotalProductquantity)
        {
            connection.Close();
            connection.Open();

            String MySqlQueryColumnName = "(Product_Name, Member_Name, Product_Quantity)";
            String MySqlQueryValues = "VALUES(@a1, @a2, @a3)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName2 + "" + MySqlQueryColumnName + "" + MySqlQueryValues + " ";
            cmd.Parameters.AddWithValue("@a1", getProduct_Name);
            cmd.Parameters.AddWithValue("@a2", getCustomer_FullName);
            cmd.Parameters.AddWithValue("@a3", getTotalProductquantity);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //set dgvSalesrecord value.        
        public static void get_salesrecord()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            getProductName.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName2 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);        

            connection.Close();
        }

        //----------------------------------------------------------Store And Products---------------------------------------------------------
        //----------------------------------------------------------Store And Products---------------------------------------------------------
        //----------------------------------------------------------Store And Products---------------------------------------------------------
        //----------------------------------------------------------Store And Products---------------------------------------------------------

        
    }

    

}
