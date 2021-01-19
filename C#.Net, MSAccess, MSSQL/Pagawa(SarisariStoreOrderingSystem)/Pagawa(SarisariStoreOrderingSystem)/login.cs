using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagawa_SarisariStoreOrderingSystem_
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        int x = 0;
        private void loginxD_Click(object sender, EventArgs e)
        {
            if (usernametxtbox.Text.Trim().Equals("admin"))
            {
                if (passwordtxtbox.Text.Trim().Equals("admin"))
                {
                    ProductsXB XB = new ProductsXB();
                    XB.Show();
                    this.Hide();
                }
            }

            else
            {
                x++;
                MessageBox.Show("BOBONG PANEL");
                
                
            }

            if (x == 3)
            {
                this.Close();
            }
            usernametxtbox.Text = "";
            passwordtxtbox.Text = "";
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
