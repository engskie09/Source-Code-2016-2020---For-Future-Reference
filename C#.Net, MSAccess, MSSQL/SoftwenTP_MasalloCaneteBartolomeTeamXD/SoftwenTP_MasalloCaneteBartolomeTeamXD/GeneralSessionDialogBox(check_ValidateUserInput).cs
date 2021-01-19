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
    public partial class GeneralSessionDialogBox_check_ValidateUserInput_ : Form
    {
        public GeneralSessionDialogBox_check_ValidateUserInput_()
        {
            InitializeComponent();
        }

        private void GeneralSessionDialogBox_check_ValidateUserInput__Load(object sender, EventArgs e)
        {
            
            lblgetErrorMessage.Text = getErrorMessage;       
        }

        public static String getErrorMessage = "";

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
