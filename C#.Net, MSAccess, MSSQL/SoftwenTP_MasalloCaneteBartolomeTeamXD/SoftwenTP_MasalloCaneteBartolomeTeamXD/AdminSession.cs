using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//  this.Load += new System.EventHandler(this.GeneralSession2_Membership_Type__Load);
namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class AdminSession : Form
    {
        public AdminSession()
        {
            InitializeComponent();
        }                

        private void AdminSession_Load(object sender, EventArgs e)
        {
            tmrsetAnimationLapse.Interval = 500;

            tmrsetCurrentDateTime.Start();
            tmrsetAnimationLapse.Start();

            getSessionname = systemMethods_GeneralSession.setSessionName;
            getMemberID = systemMethods_GeneralSession.setMemberID;

            lblsetSessionName.Text = getSessionname;
            lblsetMemberID.Text = getSessionname;
            
        }

        private Int32 increment = 1;
        public static String getSessionname = "";
        public static String getMemberID = "";
        

        private void getsetForm(String getFormName)
        {

            panelShow.Controls.Clear();
            String getNamespace = "SoftwenTP_MasalloCaneteBartolomeTeamXD.";
            var xD = (Form)Activator.CreateInstance(Type.GetType(getNamespace + getFormName));
            xD.TopLevel = false;
            xD.AutoScroll = true;
            panelShow.Controls.Add(xD);
            xD.FormBorderStyle = FormBorderStyle.None;
            xD.Show();
        }
        
        private void setImageAnimation()
        {
            
            if (increment == 1)
            {
                pctBoxBackground1.Image = imgListgetImage.Images[0];
                increment = 2;
            }

            else if (increment == 2)
            {                
                pctBoxBackground1.Image = imgListgetImage.Images[1];
                increment = 3;
            }

            else if (increment == 3)
            {
                pctBoxBackground1.Image = imgListgetImage.Images[2];
                increment = 4;
            }

            else if (increment == 4)
            {
                pctBoxBackground1.Image = imgListgetImage.Images[3];
                increment = 5;
            }

            //Loop

            else if (increment == 5)
            {
                pctBoxBackground1.Image = imgListgetImage.Images[2];
                increment = 6;
            }

            else if (increment == 6)
            {
                pctBoxBackground1.Image = imgListgetImage.Images[1];
                increment = 1;
            }



        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                getsetForm("GeneralSession1_DashBoard_");
            }
            catch
            {

            }
            
        }

        private void btnMembershiptype_Click(object sender, EventArgs e)
        {
            try
            {
                getsetForm("GeneralSession2_Membership_Type_");
            }
            catch
            {
            }
           
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            try
            {
                getsetForm("GeneralSession3_Group_");
            }
            catch
            {
            }
            
        }

        private void btnClassandnutrition_Click(object sender, EventArgs e)
        {
            try
            {
                getsetForm("GeneralSession4_Class_And_Nutrition_Schedule_");
            }
            catch
            {
            }
            
        }

        private void btnMembermanagement_Click(object sender, EventArgs e)
        {
            try
            {
                getsetForm("Admin_and_Staff_Session2_Member_Management_");
            }
            catch
            {
            }
           
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            try
            {
                getsetForm("AdminSession6_Activity_");
            }
            catch
            {
            }
            
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                getsetForm("AdminSession7_Workout_");
            }
            catch
            {
            }
            
        }

        private void btnStoreandproducts_Click(object sender, EventArgs e)
        {
            getsetForm("Admin_and_Staff_Session1_Store_And_Products_");           
        }

        private void btnLogoutSession_Click(object sender, EventArgs e)
        {
            LoginSession navigate = new LoginSession();
            navigate.Show();
            this.Close();
        }

        private void setCurrentDateTime_Tick(object sender, EventArgs e)
        {
            DateTime getCurrentDate = DateTime.Now;
            lblsetCurrentDate.Text = getCurrentDate.ToString("MM/dd/yyyy");
            lblsetCurrentTime.Text = getCurrentDate.ToString("h:mm tt");                     

        }

        private void tmrsetAnimationLapse_Tick(object sender, EventArgs e)
        {
            setImageAnimation();
        }
    }
}
