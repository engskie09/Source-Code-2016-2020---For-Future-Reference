using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    public partial class GeneralSession4_Class_And_Nutrition_Schedule_ : Form
    {
        public GeneralSession4_Class_And_Nutrition_Schedule_()
        {
            InitializeComponent();
        }

        private void GeneralSession4_Class_And_Nutrition_Schedule__Load(object sender, EventArgs e)
        {
            panelGrouplist.Location = new Point(34, 97);
            panelNutritionschedule.Location = new Point(34, 97);
            panelGrouplist.Visible = true;
            panelNutritionschedule.Visible = false;
            setDGV_Classschedule();
           
        }

        //set Datagridview Value Class Schedule.
        private void setDGV_Classschedule()
        {
            systemMethods_GeneralSession.setDGV_Classschedule();

            dgvClassList.AutoGenerateColumns = false;

            dgvClassList.Columns[0].DataPropertyName = "Class_Name";
            dgvClassList.Columns[1].DataPropertyName = "Class_Staffname";
            dgvClassList.Columns[2].DataPropertyName = "Class_StartTime";
            dgvClassList.Columns[3].DataPropertyName = "Class_EndTime";
            dgvClassList.Columns[4].DataPropertyName = "Class_Location";

            dgvClassList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvClassList.DataSource = systemMethods_GeneralSession.dt;
            
        }

        private void btnShowClassOrNutrition_Click(object sender, EventArgs e)
        {
            if (panelGrouplist.Visible)
            {   
                panelGrouplist.Visible = false;
                panelNutritionschedule.Visible = true;

            }

            else if(panelNutritionschedule.Visible)
            {
                panelNutritionschedule.Visible = false;
                panelGrouplist.Visible = true;

            }
        }

        private void btnAddClassschedule_Click(object sender, EventArgs e)
        {
            GeneralSession4_Class_And_Nutrition_Schedule_Add_Class_Schedule__ navigate = new GeneralSession4_Class_And_Nutrition_Schedule_Add_Class_Schedule__();
            navigate.ShowDialog();
            setDGV_Classschedule();
        }

        private void btnShowClassschedule_Click(object sender, EventArgs e)
        {
            GeneralSession4_Class_And_Nutrition_Schedule_Show_Class_Schedule__ navigate = new GeneralSession4_Class_And_Nutrition_Schedule_Show_Class_Schedule__();
            navigate.ShowDialog();
            setDGV_Classschedule();
        }
    }
}
