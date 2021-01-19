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
    public partial class GeneralSession_Course_List : Form
    {
        public GeneralSession_Course_List()
        {
            InitializeComponent();
        }

        private void GeneralSession_Course_List_Load(object sender, EventArgs e)
        {
            set_courseList();
        }

        private void set_courseList()
        {
            if (!SystemMethods_GeneralSession.select_course_information())
            {
                GeneralSession_MessageBox.Show("Course List", "Please try Again!!!!");
                return;
            }

            dgv_courseList.AutoGenerateColumns = false;

            dgv_courseList.Columns[0].DataPropertyName = "course_ID";
            dgv_courseList.Columns[1].DataPropertyName = "course_Name";
            dgv_courseList.Columns[2].DataPropertyName = "course_Description";
            dgv_courseList.Columns[3].DataPropertyName = "course_YearLevel";

            dgv_courseList.DataSource = SystemMethods_GeneralSession.dt;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Course List";
            print.SubTitle = "Date Printed: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Course List";
            print.FooterSpacing = 15;
            print.PageSettings.Landscape = true;
            print.PrintDataGridView(dgv_courseList);
        }

        private void txt_getCurrentSearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_getCurrentSearch.Text.Contains("Search Here"))
                return;

            (dgv_courseList.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("course_ID LIKE '{0}%' OR course_Name LIKE '{0}%' OR course_Description LIKE '{0}%' OR course_YearLevel LIKE '{0}%'", txt_getCurrentSearch.Text);
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
        
    }
}
