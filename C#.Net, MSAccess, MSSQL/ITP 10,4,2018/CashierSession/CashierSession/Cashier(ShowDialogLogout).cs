using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Register_Reload_
{
    public partial class Cashier_ShowDialogLogout_ : Form
    {
        public Cashier_ShowDialogLogout_()
        {
            InitializeComponent();
        }

        private void Cashier_ShowDialogLogout__Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cashier_SuperAdminEditLoad_ a = new Cashier_SuperAdminEditLoad_();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier_SuperAdminEditLoad_ b = new Cashier_SuperAdminEditLoad_();
            
            
          
            this.Hide();
            Cashier_Main_ a = new Cashier_Main_();
            a.Show();
        }
    }
}
