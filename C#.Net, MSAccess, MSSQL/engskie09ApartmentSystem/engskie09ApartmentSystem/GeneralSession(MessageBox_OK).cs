using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engskie09ApartmentSystem
{
    public partial class GeneralSession_MessageBox_OK_ : Form
    {
        public GeneralSession_MessageBox_OK_()
        {
            InitializeComponent();
        }

        public static String getValidationMessage = "";

        private void GeneralSession_MessageBox_OK__Load(object sender, EventArgs e)
        {
            lblgetValidationMessage.Text = getValidationMessage;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
