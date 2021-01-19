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
    public partial class GeneralSession1_DashBoard_ : Form
    {
        public GeneralSession1_DashBoard_()
        {
            InitializeComponent();
        }

        private void GeneralSession1_DashBoard__Load(object sender, EventArgs e)
        {
            panelDashboard.Location = new Point(34, 50);
        }     
    }
}
