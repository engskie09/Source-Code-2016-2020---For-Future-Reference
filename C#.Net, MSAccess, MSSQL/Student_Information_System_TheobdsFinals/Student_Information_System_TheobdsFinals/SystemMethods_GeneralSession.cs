using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Student_Information_System_TheobdsFinals
{
    class SystemMethods_GeneralSession
    {
        private static MySqlConnection con = new MySqlConnection(Program.connectionString);
        private static MySqlCommand cmd = new MySqlCommand();
        private static MySqlDataAdapter da = new MySqlDataAdapter();

        public static DataTable dt = new DataTable();

        private static String tbl_Name1 = "tbl_user_information";
        private static String tbl_Name2 = "tbl_student_information";
        private static String tbl_Name3 = "tbl_course_information";
        private static String tbl_Name4 = "tbl_teacher_information";


        public static Boolean select_userInformation(String set_userName, String set_userPassword)
        {
            dt.Clear();

            con.Close();
            con.Open();
            da = new MySqlDataAdapter("SELECT * FROM " + tbl_Name1 + " WHERE user_Name = '" + set_userName + "' AND user_Password = '" + set_userPassword + "'", con);
            da.Fill(dt);            
            con.Close();

            if (dt.Rows.Count == 1) 
                return true;
            else
                return false;
        }

        /*
            ╔═══╗╔╗░░░░░╔╗░░░░░╔╗░
            ║╔═╗╠╝╚╗░░░░║║░░░░╔╝╚╗
            ║╚══╬╗╔╬╗╔╦═╝╠══╦═╬╗╔╝
            ╚══╗║║║║║║║╔╗║║═╣╔╗╣║░
            ║╚═╝║║╚╣╚╝║╚╝║║═╣║║║╚╗
            ╚═══╝╚═╩══╩══╩══╩╝╚╩═╝
        */

        public static Boolean select_student_information()
        {
            try
            {
                dt.Clear();
                con.Close();
                con.Open();

                da = new MySqlDataAdapter("SELECT * FROM " + tbl_Name2 + "", con);
                da.Fill(dt);
                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public static Boolean insert_student_information(String set_studentID, String set_studentFirstName, String set_studentLastName, String set_studentBirthDate, String set_studentGender, String set_studentPhoneNo, String set_studentYearLevel)
        {
            try
            {
                con.Close();
                con.Open();

                String columnName = "(student_ID, student_FirstName, student_LastName, student_BirthDate, student_Gender, student_PhoneNo, student_YearLevel)";
                String columnValue = "(@set_studentID, @set_studentFirstName, @set_studentLastName, @set_studentBirthDate, @set_studentGender, @set_studentPhoneNo, @set_studentYearLevel)";

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + tbl_Name2 + " " + columnName + "VALUES " + columnValue + ";";

                cmd.Parameters.AddWithValue("set_studentID", set_studentID);
                cmd.Parameters.AddWithValue("set_studentFirstName", set_studentFirstName);
                cmd.Parameters.AddWithValue("set_studentLastName", set_studentLastName);
                cmd.Parameters.AddWithValue("set_studentBirthDate", set_studentBirthDate);
                cmd.Parameters.AddWithValue("set_studentGender", set_studentGender);
                cmd.Parameters.AddWithValue("set_studentPhoneNo", set_studentPhoneNo);
                cmd.Parameters.AddWithValue("set_studentYearLevel", set_studentYearLevel);

                cmd.ExecuteNonQuery();

                return true;               
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());                
                return false;              
            }            

        }

        public static Boolean update_student_information(String set_studentID, String set_studentFirstName, String set_studentLastName, String set_studentBirthDate, String set_studentGender, String set_studentPhoneNo, String set_studentYearLevel, String set_Action)
        {
            try
            {
                con.Close();
                con.Open();


                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (set_Action == "All")
                cmd.CommandText = "UPDATE " + tbl_Name2 + " SET student_FirstName = @set_studentFirstName, student_LastName = @set_studentLastName, student_BirthDate = @set_studentBirthDate, student_Gender = @set_studentGender, student_PhoneNo = @set_studentPhoneNo, student_YearLevel = @set_studentYearLevel WHERE student_ID = @set_studentID;";

                cmd.Parameters.AddWithValue("set_studentID", set_studentID);
                cmd.Parameters.AddWithValue("set_studentFirstName", set_studentFirstName);
                cmd.Parameters.AddWithValue("set_studentLastName", set_studentLastName);
                cmd.Parameters.AddWithValue("set_studentBirthDate", set_studentBirthDate);
                cmd.Parameters.AddWithValue("set_studentGender", set_studentGender);
                cmd.Parameters.AddWithValue("set_studentPhoneNo", set_studentPhoneNo);
                cmd.Parameters.AddWithValue("set_studentYearLevel", set_studentYearLevel);

                cmd.ExecuteNonQuery();


                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            
        }

        public static Boolean delete_student_information(String set_studentID)
        {
            try
            {
                con.Close();
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + tbl_Name2 + " WHERE student_ID = '" + set_studentID + "'";
                cmd.ExecuteNonQuery();
                
                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());

                return false;
            }
        }

        /*
            ╔═══╗╔╗░░░░░╔╗░░░░░╔╗░
            ║╔═╗╠╝╚╗░░░░║║░░░░╔╝╚╗
            ║╚══╬╗╔╬╗╔╦═╝╠══╦═╬╗╔╝
            ╚══╗║║║║║║║╔╗║║═╣╔╗╣║░
            ║╚═╝║║╚╣╚╝║╚╝║║═╣║║║╚╗
            ╚═══╝╚═╩══╩══╩══╩╝╚╩═╝
        */

        /*

			╔═══╗░░░░░░░░░░░░░░
			║╔═╗║░░░░░░░░░░░░░░
			║║░╚╬══╦╗╔╦═╦══╦══╗
			║║░╔╣╔╗║║║║╔╣══╣║═╣
			║╚═╝║╚╝║╚╝║║╠══║║═╣
			╚═══╩══╩══╩╝╚══╩══╝

        */

        public static Boolean select_course_information()
        {
            try
            {
                dt.Clear();
                con.Close();
                con.Open();

                da = new MySqlDataAdapter("SELECT * FROM " + tbl_Name3 + "", con);
                da.Fill(dt);
                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public static Boolean insert_course_information(String set_courseID, String set_courseName, String set_courseDescription, String set_courseYearLevel)
        {
            try
            {
                con.Close();
                con.Open();

                String columnName = "(course_ID, course_Name, course_Description, course_YearLevel)";
                String columnValue = "(@set_courseID, @set_courseName, @set_courseDescription, @set_courseYearLevel)";

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + tbl_Name3 + " " + columnName + "VALUES " + columnValue + ";";

                cmd.Parameters.AddWithValue("set_courseID", set_courseID);
                cmd.Parameters.AddWithValue("set_courseName", set_courseName);
                cmd.Parameters.AddWithValue("set_courseDescription", set_courseDescription);
                cmd.Parameters.AddWithValue("set_courseYearLevel", set_courseYearLevel);

                cmd.ExecuteNonQuery();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public static Boolean update_course_information(String set_courseID, String set_courseName, String set_courseDescription, String set_courseYearLevel, String set_Action)
        {
            try
            {
                con.Close();
                con.Open();


                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (set_Action == "All")
                    cmd.CommandText = "UPDATE " + tbl_Name3 + " SET course_Name = @set_courseName, course_Description = @set_courseDescription, course_YearLevel = @set_courseYearLevel WHERE course_ID = @set_courseID;";

                cmd.Parameters.AddWithValue("set_courseID", set_courseID);
                cmd.Parameters.AddWithValue("set_courseName", set_courseName);
                cmd.Parameters.AddWithValue("set_courseDescription", set_courseDescription);
                cmd.Parameters.AddWithValue("set_courseYearLevel", set_courseYearLevel);

                cmd.ExecuteNonQuery();


                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public static Boolean delete_course_information(String set_courseID)
        {
            try
            {
                con.Close();
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + tbl_Name3 + " WHERE course_ID = '" + set_courseID + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());

                return false;
            }
        }

        /*

			╔═══╗░░░░░░░░░░░░░░
			║╔═╗║░░░░░░░░░░░░░░
			║║░╚╬══╦╗╔╦═╦══╦══╗
			║║░╔╣╔╗║║║║╔╣══╣║═╣
			║╚═╝║╚╝║╚╝║║╠══║║═╣
			╚═══╩══╩══╩╝╚══╩══╝

        */

        /*

			╔════╗░░░░░░░╔╗░░░░░░░
			║╔╗╔╗║░░░░░░░║║░░░░░░░
			╚╝║║╠╩═╦══╦══╣╚═╦══╦═╗
			░░║║║║═╣╔╗║╔═╣╔╗║║═╣╔╝
			░░║║║║═╣╔╗║╚═╣║║║║═╣║░
			░░╚╝╚══╩╝╚╩══╩╝╚╩══╩╝░

        */

        public static Boolean select_teacher_information()
        {
            try
            {
                dt.Clear();
                con.Close();
                con.Open();

                da = new MySqlDataAdapter("SELECT * FROM " + tbl_Name4 + "", con);
                da.Fill(dt);
                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public static Boolean insert_teacher_information(String set_teacherID, String set_teacherFirstName, String set_teacherLastName, String set_teacherBirthDate, String set_teacherGender, String set_teacherPhoneNo)
        {
            try
            {
                con.Close();
                con.Open();

                String columnName = "(teacher_ID, teacher_FirstName, teacher_LastName, teacher_BirthDate, teacher_Gender, teacher_PhoneNo)";
                String columnValue = "(@set_teacherID, @set_teacherFirstName, @set_teacherLastName, @set_teacherBirthDate, @set_teacherGender, @set_teacherPhoneNo)";

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO " + tbl_Name4 + " " + columnName + "VALUES " + columnValue + ";";

                cmd.Parameters.AddWithValue("set_teacherID", set_teacherID);
                cmd.Parameters.AddWithValue("set_teacherFirstName", set_teacherFirstName);
                cmd.Parameters.AddWithValue("set_teacherLastName", set_teacherLastName);
                cmd.Parameters.AddWithValue("set_teacherBirthDate", set_teacherBirthDate);
                cmd.Parameters.AddWithValue("set_teacherGender", set_teacherGender);
                cmd.Parameters.AddWithValue("set_teacherPhoneNo", set_teacherPhoneNo);

                cmd.ExecuteNonQuery();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public static Boolean update_teacher_information(String set_teacherID, String set_teacherFirstName, String set_teacherLastName, String set_teacherBirthDate, String set_teacherGender, String set_teacherPhoneNo, String set_Action)
        {
            try
            {
                con.Close();
                con.Open();


                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (set_Action == "All")
                    cmd.CommandText = "UPDATE " + tbl_Name4 + " SET teacher_FirstName = @set_teacherFirstName, teacher_LastName = @set_teacherLastName, teacher_BirthDate = @set_teacherBirthDate, teacher_Gender = @set_teacherGender, teacher_PhoneNo = @set_teacherPhoneNo WHERE teacher_ID = @set_teacherID;";

                cmd.Parameters.AddWithValue("set_teacherID", set_teacherID);
                cmd.Parameters.AddWithValue("set_teacherFirstName", set_teacherFirstName);
                cmd.Parameters.AddWithValue("set_teacherLastName", set_teacherLastName);
                cmd.Parameters.AddWithValue("set_teacherBirthDate", set_teacherBirthDate);
                cmd.Parameters.AddWithValue("set_teacherGender", set_teacherGender);
                cmd.Parameters.AddWithValue("set_teacherPhoneNo", set_teacherPhoneNo);

                cmd.ExecuteNonQuery();


                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

        public static Boolean delete_teacher_information(String set_teacherID)
        {
            try
            {
                con.Close();
                con.Open();

                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + tbl_Name4 + " WHERE teacher_ID = '" + set_teacherID + "'";
                cmd.ExecuteNonQuery();

                con.Close();

                return true;
            }

            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());

                return false;
            }
        }
        


        /*

			╔════╗░░░░░░░╔╗░░░░░░░
			║╔╗╔╗║░░░░░░░║║░░░░░░░
			╚╝║║╠╩═╦══╦══╣╚═╦══╦═╗
			░░║║║║═╣╔╗║╔═╣╔╗║║═╣╔╝
			░░║║║║═╣╔╗║╚═╣║║║║═╣║░
			░░╚╝╚══╩╝╚╩══╩╝╚╩══╩╝░

        */



    }
}
