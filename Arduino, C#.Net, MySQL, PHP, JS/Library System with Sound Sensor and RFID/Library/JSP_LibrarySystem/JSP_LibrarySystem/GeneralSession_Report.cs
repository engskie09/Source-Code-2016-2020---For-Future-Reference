using System;
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
    public partial class GeneralSession_Report : Form
    {
        public GeneralSession_Report()
        {
            InitializeComponent();
        }

        private void GeneralSession_Report_Load(object sender, EventArgs e)
        {
            set_BorrowedList();
            set_ReturnedList();
        }

        private void set_BorrowedList()
        {
            SystemMethods_AdminSession.get_BorrowedReport();

            dgv_BorrowedList.AutoGenerateColumns = false;

            dgv_BorrowedList.Columns[0].DataPropertyName = "report_id";
            dgv_BorrowedList.Columns[1].DataPropertyName = "borrow_id";
            dgv_BorrowedList.Columns[2].DataPropertyName = "borrower_id";
            dgv_BorrowedList.Columns[3].DataPropertyName = "borrower_Firstname";
            dgv_BorrowedList.Columns[4].DataPropertyName = "borrower_Middlename";
            dgv_BorrowedList.Columns[5].DataPropertyName = "borrower_Lastname";
            dgv_BorrowedList.Columns[6].DataPropertyName = "borrowed_book_id";
            dgv_BorrowedList.Columns[7].DataPropertyName = "borrowed_book_title";
            dgv_BorrowedList.Columns[8].DataPropertyName = "borrowed_book_quantity";
            dgv_BorrowedList.Columns[9].DataPropertyName = "book_borrowDate";
            dgv_BorrowedList.Columns[10].DataPropertyName = "book_returnCondition";
            dgv_BorrowedList.Columns[11].DataPropertyName = "report_staffAssigned";

            dgv_BorrowedList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_BorrowedList.DataSource = SystemMethods_AdminSession.dt1;
        }

        private void set_ReturnedList()
        {
            SystemMethods_AdminSession.get_ReturnedReport();

            dgv_ReturnedList.AutoGenerateColumns = false;


            dgv_ReturnedList.Columns[0].DataPropertyName = "report_id";
            dgv_ReturnedList.Columns[1].DataPropertyName = "return_id";
            dgv_ReturnedList.Columns[2].DataPropertyName = "returner_id";
            dgv_ReturnedList.Columns[3].DataPropertyName = "returner_Firstname";
            dgv_ReturnedList.Columns[4].DataPropertyName = "returner_Middlename";
            dgv_ReturnedList.Columns[5].DataPropertyName = "returner_Lastname";
            dgv_ReturnedList.Columns[6].DataPropertyName = "returned_book_id";
            dgv_ReturnedList.Columns[7].DataPropertyName = "returned_book_title";
            dgv_ReturnedList.Columns[8].DataPropertyName = "returned_book_quantity";
            dgv_ReturnedList.Columns[9].DataPropertyName = "book_returnDate";
            dgv_ReturnedList.Columns[10].DataPropertyName = "book_returnCondition";
            dgv_ReturnedList.Columns[11].DataPropertyName = "report_staffAssigned";


            dgv_BorrowedList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_ReturnedList.DataSource = SystemMethods_AdminSession.dt2;
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

        private void dgv_ReturnedList_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void tb_ReturnedBooks_Click(object sender, EventArgs e)
        {

        }

        private void tb_BorrowedBooks_Click(object sender, EventArgs e)
        {

        }
    }
}
