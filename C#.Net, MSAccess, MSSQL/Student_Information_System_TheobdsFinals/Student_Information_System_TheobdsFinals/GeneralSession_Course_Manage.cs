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
    public partial class GeneralSession_Course_Manage : Form
    {
        public GeneralSession_Course_Manage()
        {
            InitializeComponent();
            set_controlProperty("Reset");
            set_courseList();
        }

        private void GeneralSession_Course_Manage_Load(object sender, EventArgs e)
        {
            cmbx_getYearLevel.SelectedIndex = 0;
        }

        String get_courseID;
        String get_courseName;
        String get_courseDescription;
        String get_courseYearLevel;

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

        private void set_controlANDdataDefaultValue()
        {
            txt_getCourseName.Text = "Enter Course Name";
            txt_getCourseDescription.Text = Environment.NewLine + "Enter Course Description";

            get_courseID = "";
            get_courseName = "";
            get_courseDescription = "";
            get_courseYearLevel = "";
            
        }

        //set data value.
        private void set_dataValue(String set_Action)
        {
            if (set_Action == "Insert")
                get_courseID = SystemMethods_ID_Counter.get_CurrentID_Count("course_ID");

            get_courseName = txt_getCourseName.Text.Trim();
            get_courseDescription = txt_getCourseDescription.Text.Trim();
            get_courseYearLevel = cmbx_getYearLevel.Text.ToString();      


        }

        //check control value if valid.
        private Boolean check_controlvalue()
        {
            if (txt_getCourseName.Text.Contains("Enter Course Name") || txt_getCourseDescription.Text.Contains("Enter Course Description"))
            {
                GeneralSession_MessageBox.Show("Validation", "Please check your inputs....");
                return true;
            }
            else
                return false;
        }

        //set control property.
        private void set_controlProperty(String set_action)
        {
            if (set_action == "Reset")
            {
                btn_Action.Enabled = false;

                txt_getCourseName.Enabled = false;
                txt_getCourseDescription.Enabled = false;
                cmbx_getYearLevel.Enabled = false;                
            }

            else
            {
                btn_Action.Enabled = true;

                txt_getCourseName.Enabled = true;
                txt_getCourseDescription.Enabled = true;
                cmbx_getYearLevel.Enabled = true;
            }

        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Add Course")
            {
                //set data value.
                set_dataValue("Insert");

                //check validation input
                if (check_controlvalue())
                    return;

                //insert data and check if succesfully inserted.
                if (SystemMethods_GeneralSession.insert_course_information(get_courseID, get_courseName, get_courseDescription, get_courseYearLevel))
                {
                    GeneralSession_MessageBox.Show("Add Course", "Course has been added succesfully....");
                    SystemMethods_ID_Counter.set_CurrentID_Count("course_ID");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Add Course", "Please try Again....");
            }

            else if (btn_Action.Text == "Update Course")
            {
                //set data value.
                set_dataValue("Update");

                //check validation input
                if (check_controlvalue())
                    return;

                //update data and check if succesfully updated.
                if (SystemMethods_GeneralSession.update_course_information(get_courseID, get_courseName, get_courseDescription, get_courseYearLevel, "All"))
                {
                    GeneralSession_MessageBox.Show("Update Course", "Course has been updated succesfully....");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Update Course", "Please try Again....");    

            }

            else if (btn_Action.Text == "Delete Course")
            {
                //set data value.
                set_dataValue("Delete");

                //check validation input
                if (check_controlvalue())
                    return;

                if (SystemMethods_GeneralSession.delete_course_information(get_courseID))
                {
                    GeneralSession_MessageBox.Show("Delete Course", "Course has been deleted succesfully....");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Delete Course", "Please try Again....");    
              
            }

            set_courseList();
            btn_Action.Text = "Select Action";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Add Course";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Update Course";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Delete Course";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void txt_getCourseName_Enter(object sender, EventArgs e)
        {
            if (txt_getCourseName.Text.Contains("Enter Course Name"))
            {
                txt_getCourseName.Clear();
            }
        }

        private void txt_getCourseDescription_Enter(object sender, EventArgs e)
        {
            if (txt_getCourseDescription.Text.Contains("Enter Course Description"))
            {
                txt_getCourseDescription.Clear();
            }
        }

        private void txt_getCourseName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getCourseName.Text.Trim()))
            {
                txt_getCourseName.Text = "Enter Course Name";
            }
        }

        

        private void txt_getCourseDescription_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getCourseDescription.Text.Trim()))
            {
                txt_getCourseDescription.Text = Environment.NewLine + "Enter Course Description";
            }
        }

        private void dgv_courseList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 get_CurrentRowIndex = e.RowIndex;

            try
            {
                if (get_CurrentRowIndex >= 0)
                {
                    DataGridViewRow dgvRow = dgv_courseList.Rows[get_CurrentRowIndex];

                    get_courseID = dgvRow.Cells[0].Value.ToString();
                    txt_getCourseName.Text = dgvRow.Cells[1].Value.ToString();
                    txt_getCourseDescription.Text = dgvRow.Cells[2].Value.ToString();     

                    cmbx_getYearLevel.Text = dgvRow.Cells[3].Value.ToString();

                }
            }

            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
        }

      

        
    }
}
