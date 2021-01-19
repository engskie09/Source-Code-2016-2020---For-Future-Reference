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
    public partial class GeneralSession_Student_Manage : Form
    {
        public GeneralSession_Student_Manage()
        {
            InitializeComponent();
        }

        private void GeneralSession_Student_Manage_Load(object sender, EventArgs e)
        {
            cmbx_getYearLevel.SelectedIndex = 0;
            set_controlProperty("Reset");
            set_studentList();
        }

        String get_studentID;
        String get_studentFirstName;
        String get_studentLastName;
        String get_studentBirthDate;
        String get_studentGender;
        String get_studentPhoneNo;
        String get_studentYearLevel;

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
      

        private void set_controlANDdataDefaultValue()
        {
            txt_getFirstname.Text = "Enter Firstname";
            txt_getLastname.Text = "Enter Lastname";
            txt_getPhoneNo.Text = "Enter Phone No.";

            get_studentID = "";
            get_studentFirstName = "";
            get_studentLastName = "";
            get_studentBirthDate = "";
            get_studentGender = "";
            get_studentPhoneNo = "";
            get_studentYearLevel = "";
        }

        //set data value.
        private void set_dataValue(String set_Action)
        {
            if (set_Action == "Insert")
                get_studentID = SystemMethods_ID_Counter.get_CurrentID_Count("student_ID");

            get_studentFirstName = txt_getFirstname.Text.Trim();
            get_studentLastName = txt_getLastname.Text.Trim();
            get_studentBirthDate = dtp_getBirthdate.Value.ToString("MM/dd/yyyy");

            if (rdbtn_getGenderMale.Checked)
                get_studentGender = "Male";
            else if (rdbtn_getGenderFemale.AutoCheck)
                get_studentGender = "Female";

            
            get_studentPhoneNo = txt_getPhoneNo.Text.Trim();
            get_studentYearLevel = cmbx_getYearLevel.Text.Trim().ToString();
            
        }

        //check control value if valid.
        private Boolean check_controlvalue()
        {
            if (txt_getFirstname.Text.Contains("Enter Firstname") || txt_getFirstname.Text.Contains("Enter Lastnam") || txt_getPhoneNo.Text.Contains("Enter Phone No.") || get_studentID == "")
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

                txt_getFirstname.Enabled = false;
                txt_getLastname.Enabled = false;
                dtp_getBirthdate.Enabled = false;
                rdbtn_getGenderMale.Enabled = false;
                rdbtn_getGenderFemale.Enabled = false;           
                txt_getPhoneNo.Enabled = false;
                cmbx_getYearLevel.Enabled = false;
                
            }

            else
            {
                btn_Action.Enabled = true;

                txt_getFirstname.Enabled = true;
                txt_getLastname.Enabled = true;
                dtp_getBirthdate.Enabled = true;
                rdbtn_getGenderMale.Enabled = true;
                rdbtn_getGenderFemale.Enabled = true;           
                txt_getPhoneNo.Enabled = true;
                cmbx_getYearLevel.Enabled = true;

                
            }
        
        }

        private void txt_getFirstname_Enter(object sender, EventArgs e)
        {
            if (txt_getFirstname.Text.Contains("Enter Firstname"))
            {
                txt_getFirstname.Clear();
            }
        }

        private void txt_getLastname_Enter(object sender, EventArgs e)
        {
            if (txt_getLastname.Text.Contains("Enter Lastname"))
            {
                txt_getLastname.Clear();
            }
        }

        private void txt_getPhoneNo_Enter(object sender, EventArgs e)
        {
            if (txt_getPhoneNo.Text.Contains("Enter Phone No."))
            {
                txt_getPhoneNo.Clear();
            }
        }

        private void txt_getFirstname_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getFirstname.Text.Trim()))
            {
                txt_getFirstname.Text = "Enter Firstname";
            }
        }        

        private void txt_getLastname_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getLastname.Text.Trim()))
            {
                txt_getLastname.Text = "Enter Lastname";
            }
        }        

        private void txt_getPhoneNo_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_getPhoneNo.Text.Trim()))
            {
                txt_getPhoneNo.Text = "Enter Phone No.";
            }
        }       
  
        private void btn_Action_Click(object sender, EventArgs e)
        {        

            if (btn_Action.Text == "Add Student")
            {
                //set data value.
                set_dataValue("Insert");

                //check validation input
                if (check_controlvalue())
                    return;      
     
                           

                //insert data and check if succesfully inserted.
                if (SystemMethods_GeneralSession.insert_student_information(get_studentID, get_studentFirstName, get_studentLastName, get_studentBirthDate, get_studentGender, get_studentPhoneNo, get_studentYearLevel))
                {
                    GeneralSession_MessageBox.Show("Add Student", "Student has been added succesfully....");
                    SystemMethods_ID_Counter.set_CurrentID_Count("student_ID");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Add Student", "Please try Again....");             
            }

            else if (btn_Action.Text == "Update Student")
            {

                //set data value.
                set_dataValue("Update");

                //check validation input
                if (check_controlvalue())
                    return;

                //update data and check if succesfully updated.
                if (SystemMethods_GeneralSession.update_student_information(get_studentID, get_studentFirstName, get_studentLastName, get_studentBirthDate, get_studentGender, get_studentPhoneNo, get_studentYearLevel, "All"))
                {
                    GeneralSession_MessageBox.Show("Update Student", "Student has been updated succesfully....");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Update Student", "Please try Again....");    
                
            }

            else if (btn_Action.Text == "Delete Student")
            {
                //set data value.
                set_dataValue("Delete");

                //check validation input
                if (check_controlvalue())
                    return;

                if (SystemMethods_GeneralSession.delete_student_information(get_studentID))
                {
                    GeneralSession_MessageBox.Show("Delete Student", "Student has been deleted succesfully....");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Delete Student", "Please try Again....");    
            }

            else
                MessageBox.Show("Please select an Action.");

            set_studentList();
            btn_Action.Text = "Select Action";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Add Student";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Update Student";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Delete Student";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void dgv_studentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 get_CurrentRowIndex = e.RowIndex;

            try
            {
                if (get_CurrentRowIndex >= 0)
                {
                    DataGridViewRow dgvRow = dgv_studentList.Rows[get_CurrentRowIndex];

                    get_studentID = dgvRow.Cells[0].Value.ToString();
                    txt_getFirstname.Text = dgvRow.Cells[1].Value.ToString();
                    txt_getLastname.Text = dgvRow.Cells[2].Value.ToString();
                    dtp_getBirthdate.Value = Convert.ToDateTime(dgvRow.Cells[3].Value.ToString());

                    if (dgvRow.Cells[4].Value.ToString() == "Male")
                        rdbtn_getGenderMale.Checked = true;
                    else if (dgvRow.Cells[4].Value.ToString() == "Male")
                        rdbtn_getGenderFemale.Checked = true;

                    txt_getPhoneNo.Text = dgvRow.Cells[5].Value.ToString();
                    cmbx_getYearLevel.Text = dgvRow.Cells[6].Value.ToString();

                }
            }

            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }

            
        }

        
    }
}
