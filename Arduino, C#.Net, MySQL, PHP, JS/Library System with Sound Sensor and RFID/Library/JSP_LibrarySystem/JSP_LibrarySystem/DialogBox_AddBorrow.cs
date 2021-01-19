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
    public partial class DialogBox_AddBorrow : Form
    {
        public DialogBox_AddBorrow()
        {
            InitializeComponent();
        }

        private void DialogBox_AddBorrow_Load(object sender, EventArgs e)
        {
            set_BookInformation();
        }

        public static String set_BookID = "";
        private String set_BookTitle = "";
        private String set_BookAuthor = "";
        private String set_BookCategory = "";
        private String set_BookPlaceOfPublishing = "";
        private String set_BookLevel = "";
        private Int16 set_BookBorrowQuantity;

        private void set_BookInformation()
        {
            SystemMethods_GeneralSession.get_BookInformation(set_BookID);

            set_BookTitle = SystemMethods_GeneralSession.get_BookTitle;
            set_BookAuthor = SystemMethods_GeneralSession.get_BookAuthor;
            set_BookCategory = SystemMethods_GeneralSession.get_BookCategory;
            set_BookPlaceOfPublishing = SystemMethods_GeneralSession.get_BookPlaceOfPublishing;
            set_BookLevel = SystemMethods_GeneralSession.get_BookLevel;

            lbl_setBookTitle.Text = set_BookTitle;
            lbl_setBookAuthor.Text = set_BookAuthor;
            lbl_setBookCategory.Text = set_BookCategory;
            lbl_setBookPlaceOfPublishing.Text = set_BookPlaceOfPublishing;
            lbl_setBookLevel.Text = set_BookLevel;            
        }

        private void btn_AddBorrow_Click(object sender, EventArgs e)
        {
            set_BookBorrowQuantity = Convert.ToInt16(txt_setBookBorrowQuantity.Text);
            SystemMethods_GeneralSession.insert_CurrentBorrowingBook(set_BookID, set_BookTitle, set_BookBorrowQuantity);
            SystemMethods_GeneralSession.update_BookListBorrowingAdd(set_BookID, set_BookBorrowQuantity);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
                
    }
}
