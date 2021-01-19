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
    public partial class AdminSession7_Workout_ : Form
    {
        public AdminSession7_Workout_()
        {
            InitializeComponent();
        }

        private void AdminSession7_Workout__Load(object sender, EventArgs e)
        {
            panelWorkoutlog.Location = new Point(3, 47);
            panelWorkoutlist.Location = new Point(3, 47);

            panelWorkoutlog.Visible = true;
            panelWorkoutlist.Visible = false;
            
        }

        private void btnShowWorkoutlogOrWorkoutlist_Click(object sender, EventArgs e)
        {
            if (panelWorkoutlog.Visible)
            {
                panelWorkoutlog.Visible = false;
                panelWorkoutlist.Visible = true;
            }

            else if (panelWorkoutlist.Visible)
            {
                panelWorkoutlist.Visible = false;
                panelWorkoutlog.Visible = true;
            }
        }
    }
}
