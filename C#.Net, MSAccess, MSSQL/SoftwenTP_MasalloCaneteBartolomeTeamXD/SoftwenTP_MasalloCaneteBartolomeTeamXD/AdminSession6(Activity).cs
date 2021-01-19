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
    public partial class AdminSession6_Activity_ : Form
    {
        public AdminSession6_Activity_()
        {
            InitializeComponent();
        }

        private void AdminSession6_Activity__Load(object sender, EventArgs e)
        {
            PanelActivitylist.Location = new Point(3, 47);
        }
    }
}
