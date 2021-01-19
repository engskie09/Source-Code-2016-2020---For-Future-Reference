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
    public partial class GeneralSession_Teacher_Manage : Form
    {
        public GeneralSession_Teacher_Manage()
        {
            InitializeComponent();
        }

        private void GeneralSession_Teacher_Manage_Load(object sender, EventArgs e)
        {            
            set_controlProperty("Reset");
            set_teacherList();
        }

        String get_teacherID;
        String get_teacherFirstName;
        String get_teacherLastName;
        String get_teacherBirthDate;
        String get_teacherGender;
        String get_teacherPhoneNo;

        private void set_teacherList()
        {
            if (!SystemMethods_GeneralSession.select_teacher_information())
            {
                GeneralSession_MessageBox.Show("Teacher List", "Please try Again!!!!");
                return;
            }

            dgv_teacherList.AutoGenerateColumns = false;

            dgv_teacherList.Columns[0].DataPropertyName = "teacher_ID";
            dgv_teacherList.Columns[1].DataPropertyName = "teacher_FirstName";
            dgv_teacherList.Columns[2].DataPropertyName = "teacher_LastName";
            dgv_teacherList.Columns[3].DataPropertyName = "teacher_BirthDate";
            dgv_teacherList.Columns[4].DataPropertyName = "teacher_Gender";
            dgv_teacherList.Columns[5].DataPropertyName = "teacher_PhoneNo";         

            dgv_teacherList.DataSource = SystemMethods_GeneralSession.dt;
        }
      

        private void set_controlANDdataDefaultValue()
        {
            txt_getFirstname.Text = "Enter Firstname";
            txt_getLastname.Text = "Enter Lastname";
            txt_getPhoneNo.Text = "Enter Phone No.";

            get_teacherID = "";
            get_teacherFirstName = "";
            get_teacherLastName = "";
            get_teacherBirthDate = "";
            get_teacherGender = "";
            get_teacherPhoneNo = "";
        }

        //set data value.
        private void set_dataValue(String set_Action)
        {
            if (set_Action == "Insert")
                get_teacherID = SystemMethods_ID_Counter.get_CurrentID_Count("teacher_ID");

            get_teacherFirstName = txt_getFirstname.Text.Trim();
            get_teacherLastName = txt_getLastname.Text.Trim();
            get_teacherBirthDate = dtp_getBirthdate.Value.ToString("MM/dd/yyyy");

            if (rdbtn_getGenderMale.Checked)
                get_teacherGender = "Male";
            else if (rdbtn_getGenderFemale.AutoCheck)
                get_teacherGender = "Female";


            get_teacherPhoneNo = txt_getPhoneNo.Text.Trim();
            
        }

        //check control value if valid.
        private Boolean check_controlvalue()
        {
            if (txt_getFirstname.Text.Contains("Enter Firstname") || txt_getFirstname.Text.Contains("Enter Lastnam") || txt_getPhoneNo.Text.Contains("Enter Phone No.") || get_teacherID == "")
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

            if (btn_Action.Text == "Add Teacher")
            {
                //set data value.
                set_dataValue("Insert");

                //check validation input
                if (check_controlvalue())
                    return;      
     
                           

                //insert data and check if succesfully inserted.
                if (SystemMethods_GeneralSession.insert_teacher_information(get_teacherID, get_teacherFirstName, get_teacherLastName, get_teacherBirthDate, get_teacherGender, get_teacherPhoneNo))
                {
                    GeneralSession_MessageBox.Show("Add Teacher", "Teacher has been added succesfully....");
                    SystemMethods_ID_Counter.set_CurrentID_Count("teacher_ID");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Add Teacher", "Please try Again....");             
            }

            else if (btn_Action.Text == "Update Teacher")
            {

                //set data value.
                set_dataValue("Update");

                //check validation input
                if (check_controlvalue())
                    return;

                //update data and check if succesfully updated.
                if (SystemMethods_GeneralSession.update_teacher_information(get_teacherID, get_teacherFirstName, get_teacherLastName, get_teacherBirthDate, get_teacherGender, get_teacherPhoneNo, "All"))
                {
                    GeneralSession_MessageBox.Show("Update Teacher", "Teacher has been updated succesfully....");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Update Teacher", "Please try Again...."); 
                
            }

            else if (btn_Action.Text == "Delete Teacher")
            {
                //set data value.
                set_dataValue("Delete");

                //check validation input
                if (check_controlvalue())
                    return;

                if (SystemMethods_GeneralSession.delete_teacher_information(get_teacherID))
                {
                    GeneralSession_MessageBox.Show("Delete Teacher", "Teacher has been deleted succesfully....");
                    set_controlProperty("Reset");
                    set_controlANDdataDefaultValue();
                }

                else
                    GeneralSession_MessageBox.Show("Delete Teacher", "Please try Again....");    
            }

            else
                MessageBox.Show("Please select an Action.");

            set_teacherList();
            btn_Action.Text = "Select Action";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Add Teacher";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Update Teacher";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            btn_Action.Text = "Delete Teacher";
            set_controlANDdataDefaultValue();
            set_controlProperty("");
        }      

        private void dgv_teacherList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 get_CurrentRowIndex = e.RowIndex;

            try
            {
                if (get_CurrentRowIndex >= 0)
                {
                    DataGridViewRow dgvRow = dgv_teacherList.Rows[get_CurrentRowIndex];

                    get_teacherID = dgvRow.Cells[0].Value.ToString();
                    txt_getFirstname.Text = dgvRow.Cells[1].Value.ToString();
                    txt_getLastname.Text = dgvRow.Cells[2].Value.ToString();
                    dtp_getBirthdate.Value = Convert.ToDateTime(dgvRow.Cells[3].Value.ToString());

                    if (dgvRow.Cells[4].Value.ToString() == "Male")
                        rdbtn_getGenderMale.Checked = true;
                    else if (dgvRow.Cells[4].Value.ToString() == "Male")
                        rdbtn_getGenderFemale.Checked = true;

                    txt_getPhoneNo.Text = dgvRow.Cells[5].Value.ToString();

                }
            }

            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
        }

        
    }
}
