using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Workstation_InternetProtocol_List : Form
    {
        public MythicalCafe_BackEnd_Workstation_InternetProtocol_List()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Workstation_InternetProtocol_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };
        }
    }
}
