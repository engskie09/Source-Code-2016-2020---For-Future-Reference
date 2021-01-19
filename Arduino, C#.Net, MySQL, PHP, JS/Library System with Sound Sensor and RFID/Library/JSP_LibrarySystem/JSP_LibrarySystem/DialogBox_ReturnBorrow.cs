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
    public partial class DialogBox_ReturnBorrow : Form
    {
        public DialogBox_ReturnBorrow()
        {
            InitializeComponent();
        }

        private void DialogBox_ReturnBorrow_Load(object sender, EventArgs e)
        {

        }

        public static String get_BorrowID = "";

        /*public static String set_ReportID = "";
        public static String set_ReturnID = "";
        public static String set_ReturnerID = "";
        public static String set_ReturnerFirstname = "";
        public static String set_ReturnerMiddlename = "";
        public static String set_ReturnerLastname = "";

        public static String set_ReturnBookID = "";
        public static String set_ReturnBookTitle = "";
        public static String set_BorrowBookQuantity = "";
        public static String set_BookBorrowDate = "";
        public static String set_BookReturnDate = "";
        public static String set_BookReturnCondition = "";
        public static String set_ReportStaffAssigned = "";*/


        private void btn_Remove_Click(object sender, EventArgs e)
        {                        
            SystemMethods_GeneralSession.set_ReturnedBooks(get_BorrowID);
            SystemMethods_GeneralSession.get_BorrowInformationReport(get_BorrowID);
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
