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
using System.IO;

namespace Library_Attendance
{
    public partial class Student_Attendance : Form
    {
        public Student_Attendance()
        {
            InitializeComponent();
        }

        private void Student_Attendance_Load(object sender, EventArgs e)
        {
            setTimer.Interval = 1000;
        }

        private MySqlConnection connection = new MySqlConnection(Program.connectionString);
        private MySqlCommand cmd = new MySqlCommand();
        private DataTable dt = new DataTable();
        private MySqlDataAdapter da;

        private MemoryStream ms;

        private String get_StudentID;
        private String get_StudentFirstname;
        private String get_StudentMiddlename;
        private String get_StudentLastname;
        private String get_StudentGender;
        private String get_StudentYearlevel;
        private String get_StudentSection;

        private Byte[] get_studentPicture;
        

      
        //Get Student Info by Card ID.
        //Combine With check_studentPresence();
        private void get_Studentinfo(String set_Student_CardID)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbl_student WHERE student_cardid = '" + set_Student_CardID + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            //If RFID doesn`t exist!. Return.
            if (dt.Rows.Count != 1)                         
                return;            

            DataRow dr = dt.Rows[0];           

            connection.Close();
            
            get_StudentID           = dr["student_id"].ToString();
            get_StudentFirstname    = dr["student_firstname"].ToString();
            get_StudentMiddlename   = dr["student_middlename"].ToString();
            get_StudentLastname     = dr["student_lastname"].ToString();
            get_StudentGender       = dr["student_gender"].ToString();
            get_StudentYearlevel    = dr["student_yearlevel"].ToString();
            get_StudentSection      = dr["student_section"].ToString();

            get_studentPicture      = (Byte[])dr["student_picture"];

            ms = new MemoryStream(get_studentPicture);
            
            check_studentPresence(get_StudentID);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("");
                MessageBox.Show("You`ve been Logout!");
                pctboxGetStudentPicture.BackgroundImage = Image.FromStream(ms);
                pctboxGetStudentPicture.Visible = true;
                delete_studentAttendance(get_StudentID);
                setTimer.Start();

                return;
            }

            MessageBox.Show("");
            MessageBox.Show("You`ve been login!");
            pctboxGetStudentPicture.BackgroundImage = Image.FromStream(ms);
            pctboxGetStudentPicture.Visible = true;
            setTimer.Start();
            insert_studentAttendance(get_StudentID, get_StudentFirstname, get_StudentMiddlename, get_StudentLastname, get_StudentGender, get_StudentYearlevel, get_StudentSection);

        }

        //Combine With get_Studentinfo();
        private void check_studentPresence(String set_student_id)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbl_student_library_attendance WHERE student_id = '" + set_student_id + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);    

            connection.Close();
        }

        private void insert_studentAttendance(String set_student_id, String set_student_firstname, String set_student_middlename, String set_student_lastname,
                                              String set_student_gender, String set_student_yearlevel, String set_student_section)
        {

            connection.Close();
            connection.Open();

            String setColumnsName = "(student_id, student_firstname, student_middlename, student_lastname, student_gender, student_yearlevel, student_section)";
            String setColumnsValue = "(@a1, @a2, @a3, @a4, @a5, @a6, @a7)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tbl_student_library_attendance " + setColumnsName + " VALUE " + setColumnsValue + " ";

            cmd.Parameters.AddWithValue("@a1", set_student_id);
            cmd.Parameters.AddWithValue("@a2", set_student_firstname);
            cmd.Parameters.AddWithValue("@a3", set_student_middlename);
            cmd.Parameters.AddWithValue("@a4", set_student_lastname);
            cmd.Parameters.AddWithValue("@a5", set_student_gender);
            cmd.Parameters.AddWithValue("@a6", set_student_yearlevel);
            cmd.Parameters.AddWithValue("@a7", set_student_section);

            cmd.ExecuteNonQuery();

            connection.Close();


        }

        private void delete_studentAttendance(String set_student_id)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tbl_student_library_attendance WHERE student_id = '" + set_student_id + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //Auto-generated Methods
        private void txtGetstudentcardID_TextChanged(object sender, EventArgs e)
        {            
            if (txtGetstudentcardID.Text.Count() == 10)
            {
                get_Studentinfo(txtGetstudentcardID.Text);

                txtGetstudentcardID.Clear();
            }
        }


        private Int16 setCountdown = 0;

        private void setTimer_Tick(object sender, EventArgs e)
        {
            setCountdown++;

            if (setCountdown == 2)
            {
                pctboxGetStudentPicture.BackgroundImage.Dispose();
                pctboxGetStudentPicture.Visible = false;
                setCountdown = 0;
                setTimer.Stop();                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OTHERFORM navs = new OTHERFORM();
            navs.ShowDialog();
        }

        

        
    }
}
