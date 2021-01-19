using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_LockScreen : Form
    {
        public MythicalCafe_FrontEnd_LockScreen(String set_Action)
        {
            InitializeComponent();

            get_Action = set_Action;
        }

        String get_Action = null;

        private void MythicalCafe_FrontEnd_LockScreen_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MaximumSize = MinimumSize = Size;

            new MythicalCafe_FrontEnd_Login(get_Action).ShowDialog();
        }
    }
}