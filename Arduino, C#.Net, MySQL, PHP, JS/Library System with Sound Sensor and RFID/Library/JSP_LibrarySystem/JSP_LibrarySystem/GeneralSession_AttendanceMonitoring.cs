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
    public partial class GeneralSession_AttendanceMonitoring : Form
    {
        public GeneralSession_AttendanceMonitoring()
        {
            InitializeComponent();
        }

        private void GeneralSession_AttendanceMonitoring_Load(object sender, EventArgs e)
        {
            set_BorrowedList();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void set_BorrowedList()
        {
            SystemMethods_GeneralSession.get_AttendanceList();

            dgv_AttendanceList.AutoGenerateColumns = false;

            dgv_AttendanceList.Columns[0].DataPropertyName = "student_id";
            dgv_AttendanceList.Columns[1].DataPropertyName = "student_firstname";
            dgv_AttendanceList.Columns[2].DataPropertyName = "student_middlename";
            dgv_AttendanceList.Columns[3].DataPropertyName = "student_lastname";
            dgv_AttendanceList.Columns[4].DataPropertyName = "student_gender";
            dgv_AttendanceList.Columns[5].DataPropertyName = "student_yearlevel";
            dgv_AttendanceList.Columns[6].DataPropertyName = "student_section";

            dgv_AttendanceList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv_AttendanceList.DataSource = SystemMethods_GeneralSession.dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            set_BorrowedList();
        }

        

        
    }
}
