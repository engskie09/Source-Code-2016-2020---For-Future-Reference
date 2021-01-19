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
    public partial class DialogBox_RemoveBorrow : Form
    {
        public DialogBox_RemoveBorrow()
        {
            InitializeComponent();
        }

        private void DialogBox_RemoveBorrow_Load(object sender, EventArgs e)
        {
            
        }

        public static String get_BookID;
        public static Int32 get_BookQuantityBorrow;

        private void btn_Remove_Click(object sender, EventArgs e)
        {

            SystemMethods_GeneralSession.update_BookListBorrowingRemoveOrReturn(get_BookID, get_BookQuantityBorrow);
            SystemMethods_GeneralSession.delete_CurrentBorrowingBook(get_BookID);
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
