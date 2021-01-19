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
    public partial class GeneralSession_Main : Form
    {
        public GeneralSession_Main()
        {
            InitializeComponent();
        }

        private void GeneralSession_Main_Load(object sender, EventArgs e)
        {            
            pnl_acitivityContainer.Location = new Point(12, 77);

            pnl_studentContainer.Location = new Point(12, 77);
            pnl_courseContainer.Location = new Point(153, 77);
            pnl_teacherContainer.Location = new Point(326, 77);
            pnl_gradeContainer.Location = new Point(473, 77);
        }

        private void set_acitivityContainer(String getFormName)
        {

            pnl_acitivityContainer.Controls.Clear();
            String getNamespace = "Student_Information_System_TheobdsFinals.";
            var getForm = (Form)Activator.CreateInstance(Type.GetType(getNamespace + getFormName));
            getForm.TopLevel = false;
            getForm.AutoScroll = true;
            pnl_acitivityContainer.Controls.Add(getForm);
            getForm.FormBorderStyle = FormBorderStyle.None;
            getForm.Show();

        }

        private void set_Control()
        {
            pnl_studentContainer.Visible = false;
            chk_student = false;

            pnl_courseContainer.Visible = false;
            chk_course = false;

            pnl_teacherContainer.Visible = false;
            chk_teacher = false;

            pnl_gradeContainer.Visible = false;
            chk_grade = false;
        }
      

        /*
            ╔═══╗╔╗░░░░░╔╗░░░░░╔╗░
            ║╔═╗╠╝╚╗░░░░║║░░░░╔╝╚╗
            ║╚══╬╗╔╬╗╔╦═╝╠══╦═╬╗╔╝
            ╚══╗║║║║║║║╔╗║║═╣╔╗╣║░
            ║╚═╝║║╚╣╚╝║╚╝║║═╣║║║╚╗
            ╚═══╝╚═╩══╩══╩══╩╝╚╩═╝
        */

        Boolean chk_student = false;

        private void lnklbl_Student_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (chk_student == false)
            {
                pnl_studentContainer.Visible = true;
                pnl_studentContainer.BringToFront();
                chk_student = true;
            }

            else
            {
                pnl_studentContainer.Visible = false;
                chk_student = false;
            }
        }

        private void lnklbl_Student_MouseHover(object sender, EventArgs e)
        {
            pnl_studentContainer.Visible = true;
            pnl_studentContainer.BringToFront();   
        }

        private void lnklbl_Student_MouseLeave(object sender, EventArgs e)
        {
            if (!chk_student)
                pnl_studentContainer.Visible = false;
        }

        private void lnklbl_studentManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            set_acitivityContainer("GeneralSession_Student_Manage");
        }

        private void lnklbl_studentList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            set_acitivityContainer("GeneralSession_Student_List");
        }
        

        /*
            ╔═══╗╔╗░░░░░╔╗░░░░░╔╗░
            ║╔═╗╠╝╚╗░░░░║║░░░░╔╝╚╗
            ║╚══╬╗╔╬╗╔╦═╝╠══╦═╬╗╔╝
            ╚══╗║║║║║║║╔╗║║═╣╔╗╣║░
            ║╚═╝║║╚╣╚╝║╚╝║║═╣║║║╚╗
            ╚═══╝╚═╩══╩══╩══╩╝╚╩═╝
        */

        /*

            ╔═══╗░░░░░░░░░░░░░░
            ║╔═╗║░░░░░░░░░░░░░░
            ║║░╚╬══╦╗╔╦═╦══╦══╗
            ║║░╔╣╔╗║║║║╔╣══╣║═╣
            ║╚═╝║╚╝║╚╝║║╠══║║═╣
            ╚═══╩══╩══╩╝╚══╩══╝

        */

        Boolean chk_course = false;
        private void lnklbl_Course_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (chk_course == false)
            {
                pnl_courseContainer.Visible = true;
                pnl_courseContainer.BringToFront();
                chk_course = true;
            }

            else
            {
                pnl_courseContainer.Visible = false;
                chk_course = false;
            }
        }

        private void lnklbl_Course_MouseHover(object sender, EventArgs e)
        {
            pnl_courseContainer.Visible = true;
            pnl_courseContainer.BringToFront();
        }

        private void lnklbl_Course_MouseLeave(object sender, EventArgs e)
        {
            if (!chk_course)
                pnl_courseContainer.Visible = false;
            
        }

        private void lnklbl_courseManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            set_acitivityContainer("GeneralSession_Course_Manage");
        }

        private void lnklbl_courseList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            set_acitivityContainer("GeneralSession_Course_List");            
        }     

        /*

			╔═══╗░░░░░░░░░░░░░░
			║╔═╗║░░░░░░░░░░░░░░
			║║░╚╬══╦╗╔╦═╦══╦══╗
			║║░╔╣╔╗║║║║╔╣══╣║═╣
			║╚═╝║╚╝║╚╝║║╠══║║═╣
			╚═══╩══╩══╩╝╚══╩══╝

        */       

        
        

        /*

			╔════╗░░░░░░░╔╗░░░░░░░
			║╔╗╔╗║░░░░░░░║║░░░░░░░
			╚╝║║╠╩═╦══╦══╣╚═╦══╦═╗
			░░║║║║═╣╔╗║╔═╣╔╗║║═╣╔╝
			░░║║║║═╣╔╗║╚═╣║║║║═╣║░
			░░╚╝╚══╩╝╚╩══╩╝╚╩══╩╝░

        */
        Boolean chk_teacher = false;
        private void lnklbl_Teacher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (chk_teacher == false)
            {
                pnl_teacherContainer.Visible = true;
                pnl_teacherContainer.BringToFront();
                chk_teacher = true;
            }

            else
            {
                pnl_teacherContainer.Visible = false;
                chk_teacher = false;
            }

        }

        private void lnklbl_Teacher_MouseHover(object sender, EventArgs e)
        {
            pnl_teacherContainer.Visible = true;
            pnl_teacherContainer.BringToFront();
        }

        private void lnklbl_Teacher_MouseLeave(object sender, EventArgs e)
        {
            if (!chk_teacher)
                pnl_teacherContainer.Visible = false;
        }

        private void lnklbl_teacherManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            set_acitivityContainer("GeneralSession_Teacher_Manage");
        }

        private void lnklbl_teacherList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            set_acitivityContainer("GeneralSession_Teacher_List"); 
        }



        /*

			╔════╗░░░░░░░╔╗░░░░░░░
			║╔╗╔╗║░░░░░░░║║░░░░░░░
			╚╝║║╠╩═╦══╦══╣╚═╦══╦═╗
			░░║║║║═╣╔╗║╔═╣╔╗║║═╣╔╝
			░░║║║║═╣╔╗║╚═╣║║║║═╣║░
			░░╚╝╚══╩╝╚╩══╩╝╚╩══╩╝░

        */

        /*

			╔═══╗░░░░░░╔╗░░░
			║╔═╗║░░░░░░║║░░░
			║║░╚╬═╦══╦═╝╠══╗
			║║╔═╣╔╣╔╗║╔╗║║═╣
			║╚╩═║║║╔╗║╚╝║║═╣
			╚═══╩╝╚╝╚╩══╩══╝

        */

        Boolean chk_grade = false;
        private void lnklbl_Grade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (chk_grade == false)
            {
                pnl_gradeContainer.Visible = true;
                pnl_gradeContainer.BringToFront();
                chk_grade = true;
            }

            else
            {
                pnl_gradeContainer.Visible = false;
                chk_grade = false;
            }

        }

        private void lnklbl_Grade_MouseHover(object sender, EventArgs e)
        {
            pnl_gradeContainer.Visible = true;
            pnl_gradeContainer.BringToFront();
        }

        private void lnklbl_Grade_MouseLeave(object sender, EventArgs e)
        {
            if (!chk_grade)
                pnl_gradeContainer.Visible = false;
        }

        private void lnklbl_gradeManage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            //set_acitivityContainer("GeneralSession_Grade_Manage");
            GeneralSession_MessageBox.Show("Grade", "GeneralSession_Grade_Manage");
        }

        private void lnklbl_gradeList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            set_Control();
            //set_acitivityContainer("GeneralSession_Grade_List");
            GeneralSession_MessageBox.Show("Grade", "GeneralSession_Grade_List");
        }



        /*

			╔═══╗░░░░░░╔╗░░░
			║╔═╗║░░░░░░║║░░░
			║║░╚╬═╦══╦═╝╠══╗
			║║╔═╣╔╣╔╗║╔╗║║═╣
			║╚╩═║║║╔╗║╚╝║║═╣
			╚═══╩╝╚╝╚╩══╩══╝

        */


        Boolean chk_Logout = false;
        private void GeneralSession_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!chk_Logout)
                Application.Exit();
        }

        private void lnklbl_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            chk_Logout = true;

            GeneralSession_Login navigate = new GeneralSession_Login();
            navigate.Show();
            this.Close();
        }        

        

        
        
    }
}
