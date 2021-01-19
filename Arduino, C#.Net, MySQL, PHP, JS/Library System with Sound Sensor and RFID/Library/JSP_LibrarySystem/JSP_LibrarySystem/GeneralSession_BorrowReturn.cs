﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSP_LibrarySystem
{
    public partial class GeneralSession_BorrowReturn : Form
    {
        public GeneralSession_BorrowReturn()
        {
            InitializeComponent();
        }

        private void GeneralSession_BorrowReturn_Load(object sender, EventArgs e)
        {
            set_BookList();
            set_StudentList();
            set_CurrentBorrowingBookList();
            set_BorrowedBookList();
        }

        private void set_BookList()
        {
            SystemMethods_GeneralSession.get_BookList();

            dgv_BookList.AutoGenerateColumns = false;
            dgv_BookList.Columns[0].DataPropertyName = "book_id";
            dgv_BookList.Columns[1].DataPropertyName = "book_title";
            dgv_BookList.Columns[2].DataPropertyName = "book_category";
            dgv_BookList.Columns[3].DataPropertyName = "book_totalcopies";

            dgv_BookList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_BookList.DataSource = SystemMethods_GeneralSession.dt1;
        }

        private void set_StudentList()
        {
            SystemMethods_GeneralSession.get_StudentList();

            dgv_StudentList.AutoGenerateColumns = false;
            dgv_StudentList.Columns[0].DataPropertyName = "student_id";
            dgv_StudentList.Columns[1].DataPropertyName = "student_firstname";
            dgv_StudentList.Columns[2].DataPropertyName = "student_middlename";
            dgv_StudentList.Columns[3].DataPropertyName = "student_lastname";
            dgv_StudentList.Columns[4].DataPropertyName = "student_yearlevel";
            dgv_StudentList.Columns[5].DataPropertyName = "student_section";
            dgv_StudentList.Columns[6].DataPropertyName = "student_adviser";

            dgv_StudentList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_StudentList.DataSource = SystemMethods_GeneralSession.dt2;
        }

        private void set_CurrentBorrowingBookList()
        {
            SystemMethods_GeneralSession.get_CurrentBorrowingBookList();

            dgv_BorrowingList.AutoGenerateColumns = false;
            dgv_BorrowingList.Columns[0].DataPropertyName = "book_id";
            dgv_BorrowingList.Columns[1].DataPropertyName = "book_title";
            dgv_BorrowingList.Columns[2].DataPropertyName = "book_quantity";

            dgv_BorrowingList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_BorrowingList.DataSource = SystemMethods_GeneralSession.dt3;
        }

        private void set_BorrowedBookList()
        {
            SystemMethods_GeneralSession.get_BorrowedBookList();

            dgv_BorrowList.AutoGenerateColumns = false;
            dgv_BorrowList.Columns[0].DataPropertyName  = "book_borrowID";
            dgv_BorrowList.Columns[1].DataPropertyName  = "book_id";
            dgv_BorrowList.Columns[2].DataPropertyName  = "book_quantity";
            dgv_BorrowList.Columns[3].DataPropertyName  = "book_condition";
            dgv_BorrowList.Columns[4].DataPropertyName  = "book_borrowerID";
            dgv_BorrowList.Columns[5].DataPropertyName  = "book_borrowerFirstname";
            dgv_BorrowList.Columns[6].DataPropertyName  = "book_borrowerMiddlename";
            dgv_BorrowList.Columns[7].DataPropertyName  = "book_borrowerLastname";
            dgv_BorrowList.Columns[8].DataPropertyName  = "book_borrowDate";
            dgv_BorrowList.Columns[9].DataPropertyName  = "book_returnDate";            
            dgv_BorrowList.Columns[10].DataPropertyName = "book_returnCondition";
            dgv_BorrowList.Columns[11].DataPropertyName = "book_AssignedStaff";

            dgv_BorrowList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_BorrowList.DataSource = SystemMethods_GeneralSession.dt4;
        }





        //Autogenerated Methods

        private void dgv_BookList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgv_BookList.Rows[e.RowIndex];

            DialogBox_AddBorrow.set_BookID = dgvRow.Cells[0].Value.ToString();
            
            DialogBox_AddBorrow navigate = new DialogBox_AddBorrow();
            navigate.ShowDialog();           

            set_BookList();
            set_StudentList();
            set_CurrentBorrowingBookList();
            set_BorrowedBookList();

        }

        private void dgv_BorrowList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgv_BorrowingList.Rows[e.RowIndex];

            DialogBox_RemoveBorrow.get_BookID = dgvRow.Cells[0].Value.ToString();
            DialogBox_RemoveBorrow.get_BookQuantityBorrow = Convert.ToInt32(dgvRow.Cells[2].Value.ToString());

            DialogBox_RemoveBorrow navigate = new DialogBox_RemoveBorrow();
            navigate.ShowDialog();

            set_BookList();
            set_StudentList();
            set_CurrentBorrowingBookList();
            set_BorrowedBookList(); ;
        }

        private void dgv_StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgv_StudentList.Rows[e.RowIndex];

            lbl_setStudentFirstName.Text    = dgvRow.Cells[1].Value.ToString();
            lbl_setStudentMiddleName.Text   = dgvRow.Cells[2].Value.ToString();
            lbl_setStudentLastName.Text     = dgvRow.Cells[3].Value.ToString();
            lbl_setStudentID.Text           = dgvRow.Cells[0].Value.ToString();
            lbl_setStudentSection.Text      = dgvRow.Cells[5].Value.ToString();
            lbl_setStudentAdviser.Text      = dgvRow.Cells[6].Value.ToString();

        }

        private void btn_BorrowBook_Click(object sender, EventArgs e)
        {
            if (dgv_BorrowingList.Rows.Count == 0)
            {
                MessageBox.Show("Please Add Book.");
                return;
            }

            if (lbl_setStudentID.Text == "-----")
            {
                MessageBox.Show("Please Select Student.");
                return;
            }

            
            for (Int32 x = 0; x < dgv_BorrowingList.Rows.Count ; x++)
            {
                DataGridViewRow dgvRow = dgv_BorrowingList.Rows[x];
                SystemMethods_GeneralSession.get_BorrowBookID.Add(dgvRow.Cells[0].Value.ToString());
                SystemMethods_GeneralSession.get_BorrowBookTitle.Add(dgvRow.Cells[1].Value.ToString());
                SystemMethods_GeneralSession.get_BorrowBookQuantity.Add(Convert.ToInt32(dgvRow.Cells[2].Value));
            }

            Random random = new Random();

            String get_BookBorrowID = "BW-" + random.Next(1000, 9999).ToString();
            String get_BookCondition = cmb_getBookCondition.Text.Trim();
            String get_BookBorrowerID = lbl_setStudentID.Text;
            String get_BookBorrowerFirstName = lbl_setStudentFirstName.Text;
            String get_BookBorrowerMiddleName = lbl_setStudentMiddleName.Text;
            String get_BookBorrowerLastName = lbl_setStudentLastName.Text;
            String get_BookBorrowDate = DateTime.Now.ToString("MM/dd/yyyy");
            String get_BookReturnDate = DateTime.Now.AddDays(5).ToString("MM/dd/yyyy");
            String get_BookReturnCondition = txt_getReturnCondition.Text.Trim();
            String get_BookAssignedStaff = "Paeng";


            SystemMethods_GeneralSession.insert_CurrentBorrowedBook(get_BookBorrowID, get_BookCondition ,get_BookBorrowerID, get_BookBorrowerFirstName, 
                                                                    get_BookBorrowerMiddleName, get_BookBorrowerLastName, get_BookBorrowDate, 
                                                                    get_BookReturnDate, get_BookReturnCondition, get_BookAssignedStaff);

            String get_ReportID = random.Next(1000, 9999).ToString();
            
            SystemMethods_GeneralSession.insert_BorrowedReport(get_ReportID, get_BookBorrowID, get_BookBorrowerID, get_BookBorrowerFirstName,
                                                               get_BookBorrowerMiddleName, get_BookBorrowerLastName, get_BookBorrowDate,
                                                                    get_BookReturnDate, get_BookReturnCondition, get_BookAssignedStaff);



            SystemMethods_GeneralSession.get_BorrowBookID.Clear();
            SystemMethods_GeneralSession.get_BorrowBookQuantity.Clear();
            set_BookList();
            set_StudentList();
            set_CurrentBorrowingBookList();
            set_BorrowedBookList();
            

        }

        private void dgv_BorrowList_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgv_BorrowList.Rows[e.RowIndex];

            DialogBox_ReturnBorrow.get_BorrowID = dgvRow.Cells[0].Value.ToString();

            /*DialogBox_ReturnBorrow.set_ReportID             = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_ReturnID             = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_ReturnerID           = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_ReturnerFirstname    = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_ReturnerMiddlename   = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_ReturnerLastname     = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_ReturnBookID         = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_ReturnBookTitle      = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_BorrowBookQuantity   = dgvRow.Cells[0].Value.ToString();
            DialogBox_ReturnBorrow.set_BookBorrowDate       = dgvRow.Cells[0].Value.ToString();*/
            



            DialogBox_ReturnBorrow navigate = new DialogBox_ReturnBorrow();
            navigate.ShowDialog();

            set_BookList();
            set_StudentList();
            set_CurrentBorrowingBookList();
            set_BorrowedBookList();
        }

        private void cmb_getBookCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }

        private void tb_Borrow_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

