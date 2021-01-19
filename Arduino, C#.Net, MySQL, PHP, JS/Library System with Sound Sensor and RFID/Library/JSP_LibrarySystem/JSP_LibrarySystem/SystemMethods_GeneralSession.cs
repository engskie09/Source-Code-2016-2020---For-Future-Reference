//Rafael Nobleza Masallo.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace JSP_LibrarySystem
{
    class SystemMethods_GeneralSession
    {

        static MySqlConnection connection = new MySqlConnection(Program.connectionString);
        static MySqlCommand cmd = new MySqlCommand();
        static MySqlDataAdapter da = new MySqlDataAdapter();

        public static DataTable dt = new DataTable();
        public static DataTable dt1 = new DataTable();
        public static DataTable dt2 = new DataTable();
        public static DataTable dt3 = new DataTable();
        public static DataTable dt4 = new DataTable();

        static String tblName1 = "tbl_book";
        static String tblName2 = "tbl_student";
        static String tblName3 = "tbl_book_borrowing_current";
        static String tblName4 = "tbl_book_borrow_current";
        static String tblName5 = "tbl_user_logincredentials";
        static String tblName6 = "tbl_user_information";
        static String tblName7 = "tbl_report_borrow";
        static String tblName8 = "tbl_report_return";
        static String tblName9 = "tbl_student_library_attendance";

        public static String get_BookID = "";
        public static String get_BookTitle = "";
        public static String get_BookAuthor = "";
        public static String get_BookCategory = "";
        public static String get_BookPublisher = "";
        public static String get_BookPlaceOfPublishing = "";
        public static String get_BookLevel = "";
        public static String get_BookTotalCopies = "";

        public static List<String> get_BorrowBookID = new List<String>();
        public static List<String> get_BorrowBookTitle = new List<String>();
        public static List<Int32> get_BorrowBookQuantity = new List<Int32>();       


        //get the List of Books and set to DatagridView
        public static void get_BookList()
        {
            dt1.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName1 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt1);

            connection.Close();
        }


        //get the List of Student and set to DatagridView
        public static void get_StudentList()
        {
            dt2.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName2 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt2);

            connection.Close();
        }

        //get the List of Current Borrowing and set to DatagridView
        public static void get_CurrentBorrowingBookList()
        {
            dt3.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName3 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt3);

            connection.Close();
        }
        
        //get the Book Information.
        public static void get_BookInformation(String get_BookID)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName1 + " WHERE book_id = '" + get_BookID + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                DataRow dr = dt.Rows[0];

                get_BookID                  = dr["book_id"].ToString();
                get_BookTitle               = dr["book_title"].ToString();
                get_BookAuthor              = dr["book_author"].ToString();
                get_BookCategory            = dr["book_category"].ToString();
                get_BookPublisher           = dr["book_publisher"].ToString();
                get_BookPlaceOfPublishing   = dr["book_placeofpublishing"].ToString();
                get_BookLevel               = dr["book_level"].ToString();
                get_BookTotalCopies         = dr["book_totalcopies"].ToString();
                
                
            }

            else
            {
                MessageBox.Show("Cannot Find Book!");
                return;
            }

            connection.Close();
        }

        //insert Current Borrowing Book
        public static void insert_CurrentBorrowingBook(String set_BookID, String set_BookTitle, Int32 set_BookQuantity)
        {
            connection.Close();
            connection.Open();

            String columnsName = "(book_id, book_title, book_quantity)";
            String columnsValue = "VALUES (@a1, @a2, @a3)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName3 + " " + columnsName + " " + columnsValue +"";
            
            cmd.Parameters.AddWithValue("@a1", set_BookID);
            cmd.Parameters.AddWithValue("@a2", set_BookTitle);
            cmd.Parameters.AddWithValue("@a3", set_BookQuantity);

            cmd.ExecuteNonQuery();

            connection.Close(); 
        }

        //update Current Borrowing Book if already exist.
        public static void update_CurrentBorrowingBook(String set_BookID, Int32 set_BookQuantity)
        {

        }

        //delete Current Borrowing Book
        public static void delete_CurrentBorrowingBook(String set_BookID)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + tblName3 + " WHERE book_id = '" + set_BookID + "'";
            cmd.ExecuteNonQuery();

            connection.Close();

        }

        //update Book Copies When Add Current Borrowing Book.
        public static void update_BookListBorrowingAdd(String set_BookID, Int32 set_BookQuantityBorrow)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT book_totalcopies FROM " + tblName1 + " WHERE book_id = '" + set_BookID + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];

                Int32 get_BookQuantityToBorrow = Convert.ToInt32(dr["book_totalcopies"].ToString());

                set_BookQuantityBorrow = get_BookQuantityToBorrow - set_BookQuantityBorrow;
                cmd.CommandText = "UPDATE " + tblName1 + " SET book_totalcopies = '" + set_BookQuantityBorrow + "' WHERE book_id = '" + set_BookID + "' ";
                cmd.ExecuteNonQuery();

            }

            connection.Close();
        }

        //update Book Copies When Remove Current Borrowing Book.
        //Conjoint with set_ReturnedBooks();
        public static void update_BookListBorrowingRemoveOrReturn(String set_BookID, Int32 set_BookQuantityBorrow)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT book_totalcopies FROM " + tblName1 + " WHERE book_id = '" + set_BookID + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {               
                DataRow dr = dt.Rows[0];

                Int32 get_BookQuantityToRemove = Convert.ToInt32(dr["book_totalcopies"].ToString());

                set_BookQuantityBorrow = get_BookQuantityToRemove + set_BookQuantityBorrow;
                cmd.CommandText = "UPDATE " + tblName1 + " SET book_totalcopies = '" + set_BookQuantityBorrow + "' WHERE book_id = '" + set_BookID + "' ";
                cmd.ExecuteNonQuery();

            }

            connection.Close();
        }

        //insert CurrentBorrowedeBook.
        public static void insert_CurrentBorrowedBook(String set_BorrowID, String set_BookCondition, String set_BookBorrowerID, 
                                                      String set_BookBorrowerFirstName, String set_BookBorrowerMiddleName, String set_BookBorrowerLastName,
                                                      String set_BookBorrowDate, String set_BookReturnDate, String set_BookReturnCondition, String set_BookAssignedStaff)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            String columnsName = "(book_borrowID, book_id, book_quantity, book_condition, book_borrowerID, book_borrowerFirstname, book_borrowerMiddlename, book_borrowerLastname, "
                               + " book_borrowDate, book_returnDate, book_returnCondition, book_AssignedStaff)";
            String columnsValue = "VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12)";

            for (Int32 x = 0; x < get_BorrowBookID.Count; x++)
            {                
                
                cmd.CommandText = "INSERT INTO " + tblName4 + " " +columnsName  + " " + columnsValue + "";

                cmd.Parameters.AddWithValue("@a1", set_BorrowID);
                cmd.Parameters.AddWithValue("@a2", get_BorrowBookID[x].ToString());
                cmd.Parameters.AddWithValue("@a3", get_BorrowBookQuantity[x].ToString());
                cmd.Parameters.AddWithValue("@a4", set_BookCondition);
                cmd.Parameters.AddWithValue("@a5", set_BookBorrowerID);
                cmd.Parameters.AddWithValue("@a6", set_BookBorrowerFirstName);
                cmd.Parameters.AddWithValue("@a7", set_BookBorrowerMiddleName);
                cmd.Parameters.AddWithValue("@a8", set_BookBorrowerLastName);
                cmd.Parameters.AddWithValue("@a9", set_BookBorrowDate);
                cmd.Parameters.AddWithValue("@a10", set_BookReturnDate);
                cmd.Parameters.AddWithValue("@a11", set_BookReturnCondition);
                cmd.Parameters.AddWithValue("@a12", set_BookAssignedStaff);
                

                cmd.ExecuteNonQuery();
            }

            cmd.CommandText = "DELETE FROM " + tblName3 + "";
            cmd.ExecuteNonQuery();            

            connection.Close();
        }

        //get the List of Borrowed Books and set to DatagridView
        public static void get_BorrowedBookList()
        {
            dt4.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName4 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt4);

            connection.Close();
        }

        //set the borrowed Book/Books.
        //Conjoint with delete_BorrowedBooks();
        public static void set_ReturnedBooks(String set_BorrowID)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName4 + " WHERE book_borrowID = '" + set_BorrowID + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];
                

                //Call the update_BookListBorrowingRemoveOrReturn() method.
                update_BookListBorrowingRemoveOrReturn(dr["book_id"].ToString(), Convert.ToInt32(dr["book_quantity"].ToString()));

                //Call the delete_BorrowedBooks() method.
                delete_BorrowedBooks(set_BorrowID);
            }

            connection.Close();

            

        }
        
        //delete the Borrowed Book/Books after Returning.
        //Conjoint with set_ReturnedBooks();
        public static void delete_BorrowedBooks(String set_BorrowID)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM " + tblName4 + " WHERE book_borrowID = '" + set_BorrowID + "'";
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //get User Login Credentials.
        //Conjoint with get_UserInformation();
        public static String get_UserLoginCredentials(String set_UserName, String set_UserPassword)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName5 + " WHERE user_name = '" + set_UserName + "' AND user_password = '" + set_UserPassword + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            String set_UserRole = "";

            if (dt.Rows.Count == 1)
            {
                set_UserRole = get_UserInformation(set_UserName, set_UserPassword);
            }

            else
                MessageBox.Show("Failed");
            

            connection.Close();

            return set_UserRole;
        }

        //get User information (Role)
        //Conjoint with get_UserLoginCredentials();
        public static String get_UserInformation(String set_UserName, String set_UserPassword)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT user_role FROM " + tblName6 + " WHERE user_name = '" + set_UserName +"' AND user_password = '" + set_UserPassword + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            String set_UserRole = "";

            if (dt.Rows.Count == 1)
            {
                DataRow dr = dt.Rows[0];                
                set_UserRole = dr["user_role"].ToString();                
            }
            
            connection.Close();

            return set_UserRole;
        }

        //Insert Borrowed Report after borrowing.
        public static void insert_BorrowedReport(String set_ReportID, String set_BorrowID, String set_BorrowerID, String set_BorrowerFirstname, 
                                                 String set_BorrowerMiddlename, String set_BorrowerLastname, String set_BookBorrowDate, 
                                                 String set_BookReturnDate, String set_BookReturnCondition, String set_ReportStaffAssigned)
        {
            connection.Close();
            connection.Open();

            String columnsName = "(report_id, borrow_id, borrower_id, borrower_Firstname, borrower_Middlename, borrower_Lastname,"
                               + " borrowed_book_id, borrowed_book_title, borrowed_book_quantity, book_borrowDate, book_returnDate, book_returnCondition, report_staffAssigned)";
            String columnsValue = "VALUES(@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName7 + " " + columnsName + " " + columnsValue + "";

            
            for (Int32 x = 0; x < get_BorrowBookID.Count; x++)
            {

                cmd.Parameters.AddWithValue("@a1", set_ReportID);
                cmd.Parameters.AddWithValue("@a2", set_BorrowID);
                cmd.Parameters.AddWithValue("@a3", set_BorrowerID);
                cmd.Parameters.AddWithValue("@a4", set_BorrowerFirstname);
                cmd.Parameters.AddWithValue("@a5", set_BorrowerMiddlename);
                cmd.Parameters.AddWithValue("@a6", set_BorrowerLastname);
                cmd.Parameters.AddWithValue("@a7", get_BorrowBookID[0].ToString());
                cmd.Parameters.AddWithValue("@a8", get_BorrowBookTitle[0].ToString());
                cmd.Parameters.AddWithValue("@a9", get_BorrowBookQuantity[0].ToString());
                cmd.Parameters.AddWithValue("@a10", set_BookBorrowDate);
                cmd.Parameters.AddWithValue("@a11", set_BookReturnDate);
                cmd.Parameters.AddWithValue("@a12", set_BookReturnCondition);
                cmd.Parameters.AddWithValue("@a13", set_ReportStaffAssigned);

                cmd.ExecuteNonQuery();
            }

            

            connection.Close();
        }

        //Insert Returned Report after borrowing.
        //Conjoint with get_BorrowInformationReport();
        public static void insert_ReturnedReport(String set_ReportID, String set_ReturnID, String set_ReturnerID, String set_ReturnerFirstname,
                                                 String set_ReturnerMiddlename, String set_ReturnerLastname, String set_ReturnBookID, 
                                                 String set_ReturnBookTitle, String set_BorrowBookQuantity, String set_BookBorrowDate,
                                                 String set_BookReturnDate, String set_BookReturnCondition, String set_ReportStaffAssigned)
        {
            connection.Close();
            connection.Open();

            String columnsName = "(report_id, return_id, returner_id, returner_Firstname, returner_Middlename, returner_Lastname,"
                               + " returned_book_id, returned_book_title, returned_book_quantity, book_borrowDate, book_returnDate, book_returnCondition, report_staffAssigned)";
            String columnsValue = "VALUES(@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12, @a13)";

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO " + tblName8 + " " + columnsName + " " + columnsValue + "";
                    

            cmd.Parameters.AddWithValue("@a1", set_ReportID);
            cmd.Parameters.AddWithValue("@a2", set_ReturnID);
            cmd.Parameters.AddWithValue("@a3", set_ReturnerID);
            cmd.Parameters.AddWithValue("@a4", set_ReturnerFirstname);
            cmd.Parameters.AddWithValue("@a5", set_ReturnerMiddlename);
            cmd.Parameters.AddWithValue("@a6", set_ReturnerLastname);
            cmd.Parameters.AddWithValue("@a7", set_ReturnBookID);
            cmd.Parameters.AddWithValue("@a8", set_ReturnBookTitle);
            cmd.Parameters.AddWithValue("@a9", set_BorrowBookQuantity);
            cmd.Parameters.AddWithValue("@a10", set_BookBorrowDate);
            cmd.Parameters.AddWithValue("@a11", set_BookReturnDate);
            cmd.Parameters.AddWithValue("@a12", set_BookReturnCondition);
            cmd.Parameters.AddWithValue("@a13", set_ReportStaffAssigned);

                cmd.ExecuteNonQuery();
            



            connection.Close();
        }
       
        //get Borrow Information.
        //Conjoint with insert_ReturnedReport();
        public static void get_BorrowInformationReport(String set_BorrowID)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "SELECT * FROM " + tblName7 + " WHERE borrow_id = '" + set_BorrowID + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            
            if (dt.Rows.Count == 0)
                return;            

            DataRow dr1 = dt.Rows[0];

            String set_ReportID = dr1["report_id"].ToString();
            
            //check if ReportID already exist in table.
            cmd.CommandText = "SELECT * FROM " + tblName8 +" WHERE report_id = '" + dr1["report_id"].ToString() + "'";
            cmd.ExecuteNonQuery();

            dt.Clear();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);
            
            //if ReportID already exist the code will not continue.
            if (dt.Rows.Count != 0)
                return;

            
            //get all information by reportID  from BorrowedBook Table then Insert to ReturnedBook Table
            cmd.CommandText = "SELECT * FROM " + tblName7 + " WHERE report_id = '" + set_ReportID + "'";
            cmd.ExecuteNonQuery();

            dt.Clear();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                
                foreach (DataRow dr2 in dt.Rows)
                {
                    insert_ReturnedReport(dr2["report_id"].ToString(), dr2["borrow_id"].ToString(), dr2["borrower_id"].ToString(),
                                          dr2["borrower_Firstname"].ToString(), dr2["borrower_Middlename"].ToString(), dr2["borrower_Lastname"].ToString(),
                                          dr2["borrowed_book_id"].ToString(), dr2["borrowed_book_title"].ToString(), dr2["borrowed_book_quantity"].ToString(),
                                          dr2["book_borrowDate"].ToString(), dr2["book_returnDate"].ToString(), dr2["book_returnCondition"].ToString(),
                                          dr2["report_staffAssigned"].ToString());
                }
            }


            
            connection.Close();
        }

        //get the List of Student Attendance and set to DatagridView
        public static void get_AttendanceList()
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName9 + "";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);           

            connection.Close();
        }


        
    }

    
}
