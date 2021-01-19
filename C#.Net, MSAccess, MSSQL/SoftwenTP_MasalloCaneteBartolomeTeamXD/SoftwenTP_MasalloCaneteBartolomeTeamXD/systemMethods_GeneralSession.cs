using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    class systemMethods_GeneralSession
    {
        //set 
        public static String MySqlconnection = "datasource=localhost;port=3306;username=root;password=;database=softwentp_masallocanetebartolometeamxd;sslmode=none;";

        public static MySqlConnection connection = new MySqlConnection(MySqlconnection);
        public static MySqlCommand cmd = new MySqlCommand();
        public static MySqlDataAdapter da = new MySqlDataAdapter();
        public static DataTable dt = new DataTable();
        public static Boolean AccountExist = false;
        public static String setSessionName = "";
        public static String setMemberID = "";

        public static String tblName1 = "generalsession_membershiptype";
        public static String tblName2 = "generalsession_group";
        public static String tblName3 = "generalsession_classschedule";
        public static String tblName4 = "generalsession_ClassSchedule_daily";
        public static String tblName5 = "generalsession_member_logininformation";
        public static String tblName6 = "generalsession_counter";


        //get Day Classes Value to insert to generalsession_ClassSchedule_daily.
        //-----Methods-----
        //setListValue_ClassscheduleByNameofDay()
        //setDayValue()
        //setDGV_ClassscheduleByNameofDay()
        public static List<String> getMondayClasses = new List<String>();
        public static List<String> getTuesdayClasses = new List<String>();
        public static List<String> getWednesdayClasses = new List<String>();
        public static List<String> getThursdayClasses = new List<String>();
        public static List<String> getFridayClasses = new List<String>();
        public static List<String> getSaturdayClasses = new List<String>();
        public static List<String> getSundayClasses = new List<String>();

        //set Day Value for Days to insert to generalsession_ClassSchedule_daily.
        //-----Methods-----
        //setListValue_ClassscheduleByNameofDay()
        //setDayValue()
        //setDGV_ClassscheduleByNameofDay()
        private static String setMonday = "";
        private static String setTuesday = "";
        private static String setWednesday = "";
        private static String setThursday = "";
        private static String setFriday = "";
        private static String setSaturday = "";
        private static String setSunday = "";

        private static Int32 AutoIncrement = 0;

        private static Boolean isEmptyMondayClasses = getMondayClasses.Any();
        private static Boolean isEmptyTuesdayClasses = getTuesdayClasses.Any();
        private static Boolean isEmptyWednesdayClasses = getWednesdayClasses.Any();
        private static Boolean isEmptThursdayClasses = getThursdayClasses.Any();
        private static Boolean isEmptFridayClasses = getFridayClasses.Any();
        private static Boolean isEmptSaturdayClasses = getSaturdayClasses.Any();
        private static Boolean isEmptSundayClasses = getSundayClasses.Any();

        private static Int32 getTotalDaysInsertedtoList = 0;

        //getCustomerCurrentCount and set Customer-ID to Register.
        //-----Methods-----
        //getCountNameNumber()
        public static Int32 getCustomerCurrentCount = 0;
        public static String setCustomerID = "CSTM-";
        

        //check if Member Exist to Login
        public static void checkIfMemberExist(String setMember_Username, String setMember_Password)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT * FROM generalsession_member_logininformation WHERE Member_Username=@a1 and Member_Password=@a2";
           
            cmd.Parameters.AddWithValue("@a1", setMember_Username);
            cmd.Parameters.AddWithValue("@a2", setMember_Password);
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                AccountExist = true;
                foreach (DataRow dr in dt.Rows)
                {
                    setSessionName = dr["Member_Role"].ToString();
                    setMemberID = dr["Member_ID"].ToString();
                    AccountExist = true;
                }                               
            }

            else
            {
                GeneralSessionDialogBox_check_ValidateUserInput_.getErrorMessage = "Error!! Try Again!";
                AccountExist = false;
                GeneralSessionDialogBox_check_ValidateUserInput_ navigate = new GeneralSessionDialogBox_check_ValidateUserInput_();
                navigate.ShowDialog();
            }

            connection.Close();
        }

        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type----------------------------------------------------------- 

        //set dgvMembershiptypeList value.
        public static void setDGV_membershiptype()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName1 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            connection.Close();
        }

        //set dgvMembershiptypeList Value by Search.
        public static void search_membershiptype(String getSearchString)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

            connection.Close();
            connection.Open();
            //, Membership_Period, Installment_Plan, Signup_Fee
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName1 + " WHERE concat(Membership_Name, Membership_Period, Installment_Plan, Signup_Fee) like '%" + getSearchString + "%'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            connection.Close();
        }

        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type-----------------------------------------------------------
        //-----------------------------------------------------------Membership Type----------------------------------------------------------- 

        //set Datagridview value Membership Type.
        public static void setDGV_group()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();

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
   
        //set Datagridview value Class Schedule.
        public static void setDGV_Classschedule()
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
         
            connection.Close();
            connection.Open();
            String MySqlQueryColumns = "Class_Name,Class_Staffname,Class_Location, CONCAT(Class_StartTime,' ', Class_StartTimemeridiem ) AS Class_StartTime,  CONCAT(Class_EndTime,' ', Class_EndTimemeridiem ) AS Class_EndTime";
            
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;            
            cmd.CommandText = "SELECT " + MySqlQueryColumns + " FROM " + tblName3 + "";       
            cmd.ExecuteNonQuery();
            
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            connection.Close();
        }

        //set List value "Class Schedule" by Name of Day.        
        public static void setListValue_ClassscheduleByNameofDay(String setDayName, String setMySqlColumnName)
        {   
            connection.Close();
            connection.Open();

            

            DataTable getCol = new DataTable();         
            String MySqlQueryColumns1 = "CONCAT(Class_Name,' (',Class_StartTime,' ',Class_StartTimemeridiem,'-', Class_EndTime,' ',Class_EndTimemeridiem,')') as '" + setMySqlColumnName + "'";
                   
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT " +  MySqlQueryColumns1 + " FROM " + tblName3 + " WHERE Class_Days Like '%" + setDayName + "%'"; 
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(getCol);

            if (setDayName == "Monday")
            {
                foreach (DataRow dr in getCol.Rows)
                {
                    getMondayClasses.Add(dr["clmMonday"].ToString());
                    getTotalDaysInsertedtoList += 1;
                }
            }

            else if (setDayName == "Tuesday")
            {
                foreach (DataRow dr in getCol.Rows)
                {
                    getTuesdayClasses.Add(dr["clmTuesday"].ToString());
                    getTotalDaysInsertedtoList += 1;
                }                
            }

            else if (setDayName == "Wednesday")
            {
                foreach (DataRow dr in getCol.Rows)
                {
                    getWednesdayClasses.Add(dr["clmWednesday"].ToString());
                    getTotalDaysInsertedtoList += 1;
                }                
            }
            else if (setDayName == "Thursday")
            {
                foreach (DataRow dr in getCol.Rows)
                {
                    getThursdayClasses.Add(dr["clmThursday"].ToString());
                    getTotalDaysInsertedtoList += 1;
                }                                
            }

            else if (setDayName == "Friday")
            {
                foreach (DataRow dr in getCol.Rows)
                {
                    getFridayClasses.Add(dr["clmFriday"].ToString());
                    getTotalDaysInsertedtoList += 1;
                }               
            }

            else if (setDayName == "Saturday")
            {
                foreach (DataRow dr in getCol.Rows)
                {
                    getSaturdayClasses.Add(dr["clmSaturday"].ToString());
                    getTotalDaysInsertedtoList += 1;
                }               
            }

            else if (setDayName == "Sunday")
            {
                foreach (DataRow dr in getCol.Rows)
                {
                    getSundayClasses.Add(dr["clmSunday"].ToString());
                    getTotalDaysInsertedtoList += 1;
                }                
            }

            connection.Close();
        }
        
        //set Datagridview value Class Schedule by Name of Day.
        public static void getListValue_ClassscheduleByNameofDay()
        {
            getTotalDaysInsertedtoList = 0;
            List<String> Dayname = new List<String>();
            List<String> ColumnDayname = new List<String>();

            //set List of Dayname for MySql Query "Like".
            Dayname.Add("Monday");
            Dayname.Add("Tuesday");
            Dayname.Add("Wednesday");
            Dayname.Add("Thursday");
            Dayname.Add("Friday");
            Dayname.Add("Saturday");
            Dayname.Add("Sunday");
           
            //set List of ColumnDayname for MySql Query "ColumnName".
            ColumnDayname.Add("clmMonday");
            ColumnDayname.Add("clmTuesday");
            ColumnDayname.Add("clmWednesday");
            ColumnDayname.Add("clmThursday");
            ColumnDayname.Add("clmFriday");
            ColumnDayname.Add("clmSaturday");
            ColumnDayname.Add("clmSunday");
          
            dt.Columns.Add("clmMonday", typeof(String));
            dt.Columns.Add("clmTuesday", typeof(String));
            dt.Columns.Add("clmWednesday", typeof(String));
            dt.Columns.Add("clmThursday", typeof(String));
            dt.Columns.Add("clmFriday", typeof(String));
            dt.Columns.Add("clmSaturday", typeof(String));
            dt.Columns.Add("clmSunday", typeof(String));
           
            for (int x = 0; x <= 6; x++)
            {
                setListValue_ClassscheduleByNameofDay(Dayname[x], ColumnDayname[x]);               
            }  
        }

        //set Day Value to insert to table generalsession_classschedule_daily
        private static void setDayValue()
        {
            
            
            //check if MondayClasses List are Empty then Set Value.
            if (getMondayClasses.Any())
            {

                if (getMondayClasses.ElementAtOrDefault(AutoIncrement) == null)
                {                    
                    isEmptyMondayClasses = true;
                    setMonday = "";                    
                }

                else
                {
                    setMonday = "";
                    setMonday = getMondayClasses[AutoIncrement];                    
                }
            }

            //check if TuesdayClasses List are Empty then Set Value.
            if (getTuesdayClasses.Any())
            {

                if (getTuesdayClasses.ElementAtOrDefault(AutoIncrement) == null)
                {
                    isEmptyTuesdayClasses = true;
                    setTuesday = "";
                }

                else
                {
                    setTuesday = "";
                    setTuesday = getTuesdayClasses[AutoIncrement];
                }
            }

            //check if WednesdayClasses List are Empty then Set Value.
            if (getWednesdayClasses.Any())
            {

                if (getWednesdayClasses.ElementAtOrDefault(AutoIncrement) == null)
                {                   
                    isEmptyWednesdayClasses = true;
                    setWednesday = "";

                }

                else
                {
                    setWednesday = "";
                    setWednesday = getWednesdayClasses[AutoIncrement];                    
                }
                
            }

            //check if ThursdayClasses List are Empty then Set Value.
            if (getThursdayClasses.Any())
            {
                if (getThursdayClasses.ElementAtOrDefault(AutoIncrement) == null)
                {                    
                    isEmptThursdayClasses = true;
                    setThursday = "";
                }

                else
                {
                    setThursday = "";     
                    setThursday = getThursdayClasses[AutoIncrement];
                }
            }

            //check if FridayClasses List are Empty then Set Value.
            if (getFridayClasses.Any())
            {
                if (getFridayClasses.ElementAtOrDefault(AutoIncrement) == null)
                {
                    isEmptFridayClasses = true;
                    setFriday = "";
                }

                else
                {
                    setFriday = "";
                    setFriday = getFridayClasses[AutoIncrement];
                }
            }

            //check if SaturdayClasses List are Empty then Set Value.
            if (getSaturdayClasses.Any())
            {
                if (getSaturdayClasses.ElementAtOrDefault(AutoIncrement) == null)
                {
                    isEmptSaturdayClasses = true;
                    setSaturday = "";
                }

                else
                {
                    setSaturday = "";
                    setSaturday = getSaturdayClasses[AutoIncrement];
                }
            }

            //check if SundayClasses List are Empty then Set Value.
            if (getSundayClasses.Any())
            {
                if (getSundayClasses.ElementAtOrDefault(AutoIncrement) == null)
                {
                    isEmptSundayClasses = true;
                    setSunday = "";
                }

                else
                {
                    setSunday = "";
                    setSunday = getSundayClasses[AutoIncrement];
                }
            }          
            
        

        }
          
        //set Datagridview Value by Schedule Name of Daya.
        public static void setDGV_ClassscheduleByNameofDay()
        {            
            dt.Rows.Clear();
            dt.Columns.Clear();            
            //Call Method getListValue_ClassscheduleByNameofDay()
            getListValue_ClassscheduleByNameofDay();
            
            connection.Close();
            connection.Open();
            
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + tblName4 + "";
            cmd.ExecuteNonQuery();

            String MySqlQueryColumns = "(ClassSchedule_Monday, ClassSchedule_Tuesday, ClassSchedule_Wednesday, ClassSchedule_Thursday, ClassSchedule_Friday, ClassSchedule_Saturday, ClassSchedule_Sunday)";
            String MySqlQueryValues = "VALUES(@a1, @a2, @a3, @a4, @a5, @a6, @a7)";
             
            AutoIncrement = 0;
             
  
            //start of loop.

            for (int x = 0; x <= getTotalDaysInsertedtoList - 1; x++)
            {
                    MessageBox.Show(getTotalDaysInsertedtoList.ToString());           
               
                    setDayValue();

                    if (isEmptyMondayClasses && isEmptyTuesdayClasses && isEmptyWednesdayClasses && isEmptThursdayClasses && isEmptFridayClasses && isEmptSaturdayClasses && isEmptSundayClasses)
                    {
                        break;
                    }

                    cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO " + tblName4 + " " + MySqlQueryColumns + " " + MySqlQueryValues + "";
                    cmd.Parameters.AddWithValue("@a1", setMonday);

                    cmd.Parameters.AddWithValue("@a2", setTuesday);
                    cmd.Parameters.AddWithValue("@a3", setWednesday);
                    cmd.Parameters.AddWithValue("@a4", setThursday);
                    cmd.Parameters.AddWithValue("@a5", setFriday);
                    cmd.Parameters.AddWithValue("@a6", setSaturday);
                    cmd.Parameters.AddWithValue("@a7", setSunday);
                    cmd.ExecuteNonQuery();

                    AutoIncrement++;
                }
            //end of loop.
            
            cmd.CommandText = "SELECT * FROM " + tblName4 + "";

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            connection.Close();
           
            isEmptyMondayClasses    = false;
            isEmptyTuesdayClasses   = false;
            isEmptyWednesdayClasses = false;
            isEmptThursdayClasses   = false;
            isEmptFridayClasses     = false;
            isEmptSaturdayClasses   = false;
            isEmptSundayClasses     = false;

            getMondayClasses.Clear();
            getTuesdayClasses.Clear();
            getWednesdayClasses.Clear();
            getThursdayClasses.Clear();
            getFridayClasses.Clear();
            getSaturdayClasses.Clear();
            getSundayClasses.Clear();            
        }      

        //get Count Name and Count Increment for Member ID
        public static void getCountNameNumber(String getCounter_Name)
        {
            dt.Rows.Clear();
            dt.Columns.Clear(); 
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count_increment FROM "  + tblName6 + " WHERE counter_name = '" + getCounter_Name + "'";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                getCustomerCurrentCount = Convert.ToInt32(dr["count_increment"]);
                            
            }

            setCustomerID = "CSTM-" + Convert.ToInt32(getCustomerCurrentCount+1000).ToString();           

            connection.Close();
        }

        public static void updateCountIncrement(String getCounter_Name)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count_increment FROM " + tblName6 + " WHERE counter_name = '" + getCounter_Name + "'";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                getCustomerCurrentCount = Convert.ToInt32(dr["count_increment"]);

            }

            getCustomerCurrentCount = getCustomerCurrentCount + 1;

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE " + tblName6 + " SET count_increment = '" + getCustomerCurrentCount.ToString() + "' WHERE counter_name = '" + getCounter_Name + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
