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
    public partial class GeneralSession4_Class_And_Nutrition_Schedule_Show_Class_Schedule__ : Form
    {
        public GeneralSession4_Class_And_Nutrition_Schedule_Show_Class_Schedule__()
        {
            InitializeComponent();
        }

        private void GeneralSession4_Class_And_Nutrition_Schedule_Show_Class_Schedule___Load(object sender, EventArgs e)
        {
            setDGV_Classschedule();
        }

        //set Datagridview Value Class Schedule.
        private void setDGV_Classschedule()
        {
            systemMethods_GeneralSession.setDGV_ClassscheduleByNameofDay();
            dgvClassList.AutoGenerateColumns = false;
            dgvClassList.Columns[0].DataPropertyName = "ClassSchedule_Monday";
            dgvClassList.Columns[1].DataPropertyName = "ClassSchedule_Tuesday";
            dgvClassList.Columns[2].DataPropertyName = "ClassSchedule_Wednesday";
            dgvClassList.Columns[3].DataPropertyName = "ClassSchedule_Thursday";
            dgvClassList.Columns[4].DataPropertyName = "ClassSchedule_Friday";
            dgvClassList.Columns[5].DataPropertyName = "ClassSchedule_Saturday";
            dgvClassList.Columns[6].DataPropertyName = "ClassSchedule_Sunday";
            dgvClassList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvClassList.DataSource = systemMethods_GeneralSession.dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
