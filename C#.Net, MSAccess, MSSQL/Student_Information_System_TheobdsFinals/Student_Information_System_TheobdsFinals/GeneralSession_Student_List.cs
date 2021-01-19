using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System_TheobdsFinals
{
    public partial class GeneralSession_Student_List : Form
    {
        public GeneralSession_Student_List()
        {
            InitializeComponent();
        }

        private void GeneralSession_Student_List_Load(object sender, EventArgs e)
        {
            set_studentList();
        }

        private void set_studentList()
        {
            if (!SystemMethods_GeneralSession.select_student_information())
            {
                GeneralSession_MessageBox.Show("Student List", "Please try Again!!!!");
                return;
            }

            dgv_studentList.AutoGenerateColumns = false;

            dgv_studentList.Columns[0].DataPropertyName = "student_ID";
            dgv_studentList.Columns[1].DataPropertyName = "student_FirstName";
            dgv_studentList.Columns[2].DataPropertyName = "student_LastName";
            dgv_studentList.Columns[3].DataPropertyName = "student_BirthDate";
            dgv_studentList.Columns[4].DataPropertyName = "student_Gender";
            dgv_studentList.Columns[5].DataPropertyName = "student_PhoneNo";
            dgv_studentList.Columns[6].DataPropertyName = "student_YearLevel";

            dgv_studentList.DataSource = SystemMethods_GeneralSession.dt;
        }

        private void txt_getCurrentSearch_Enter(object sender, EventArgs e)
        {
            if (txt_getCurrentSearch.Text.Contains("Search Here"))
            {
                txt_getCurrentSearch.Clear();
            }
        }

        private void txt_getCurrentSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getCurrentSearch.Text.Trim()))
            {
                txt_getCurrentSearch.Text = "Search Here";
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Student List";
            print.SubTitle = "Date Printed: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Student List";
            print.FooterSpacing = 15;
            print.PageSettings.Landscape = true;
            print.PrintDataGridView(dgv_studentList);
        }

        private void txt_getCurrentSearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_getCurrentSearch.Text.Contains("Search Here"))
                return;

            (dgv_studentList.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("student_ID LIKE '{0}%' OR student_FirstName LIKE '{0}%' OR student_LastName LIKE '{0}%' OR student_BirthDate LIKE '{0}%' OR student_Gender LIKE '{0}%' OR student_PhoneNo LIKE '{0}%' OR student_YearLevel LIKE '{0}%'", txt_getCurrentSearch.Text);
        }

     
    }
}
