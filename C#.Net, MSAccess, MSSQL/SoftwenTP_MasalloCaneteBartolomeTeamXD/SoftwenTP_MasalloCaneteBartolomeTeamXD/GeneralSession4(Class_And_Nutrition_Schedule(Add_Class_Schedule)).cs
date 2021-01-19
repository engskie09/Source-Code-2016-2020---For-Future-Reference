using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class GeneralSession4_Class_And_Nutrition_Schedule_Add_Class_Schedule__ : Form
    {
        public GeneralSession4_Class_And_Nutrition_Schedule_Add_Class_Schedule__()
        {
            InitializeComponent();
        }

        private void GeneralSession4_Class_And_Nutrition_Schedule_Add_Class_Schedule___Load(object sender, EventArgs e)
        {
            
        }
        //get Class Schedule Informations.
        String getClassName, getClassStaffmember, getClasslocation, getClassSelectDays;
        String getClassStartTimeHourHand, getClassStartTimeMinuteHand, getClassStartTimeMeridiem;
        String getClassEndTimeHourHand, getClassEndTimeMinuteHand, getClassEndTimeMeridiem;

        String getStartTime, getEndTime;

        private void btnAddClassschedule_Click(object sender, EventArgs e)
        {
            foreach (String selectedDays in clbsetClassSelectDays.CheckedItems)
            {
                getClassSelectDays +=selectedDays + " ";
                MessageBox.Show(getClassSelectDays);
                
            }

            //get Class Schedule Informations.
            getClassName = txtsetClassName.Text;
            getClassStaffmember = cmbsetClassStaffmember.Text;
            getClasslocation = txtsetClasslocation.Text;
            

            getClassStartTimeHourHand = cmbsetClassStartTimeHourHand.Text;
            getClassStartTimeMinuteHand = cmbsetClassStartTimeMinuteHand.Text;
            getClassStartTimeMeridiem = cmbsetClassStartTimeMeridiem.Text;

            getClassEndTimeHourHand = cmbsetClassEndTimeHourHand.Text;
            getClassEndTimeMinuteHand = cmbsetClassEndTimeMinuteHand.Text;
            getClassEndTimeMeridiem = cmbsetClassEndTimeMeridiem.Text;

            //get Class Start Time and Class End Time.
            getStartTime = getClassStartTimeHourHand + ":" + getClassStartTimeMinuteHand;
            getEndTime = getClassEndTimeHourHand + ":" + getClassEndTimeMinuteHand;

            /*MessageBox.Show(getClassName + " " + getClassStaffmember + " " + getClasslocation + " " + getClassSelectDays);
            MessageBox.Show(getStartTime + " " + getEndTime);*/

            systemMethods_Admin_and_Staff_Session.set_Classschedule(getClassName, getClassStaffmember, getStartTime, getEndTime,
                getClassStartTimeMeridiem, getClassEndTimeMeridiem, getClassSelectDays, getClasslocation);


            

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
