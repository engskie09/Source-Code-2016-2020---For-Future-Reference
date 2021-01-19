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

namespace CanteenKiosk
{
    public partial class Balance : Form
    {
        

        public string Firstname;
        public string Middlename;
        public string Lastname;
        public static int haysnako;

        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            if (haysnako == 1)
            {

                fullname.Text = CheckBalance.fnamee + CheckBalance.Mnamee + CheckBalance.lnamee;
                pera.Text = CheckBalance.bal;
            }

            else if (haysnako == 0)
            {
                fullname.Text = CheckBalance1.fnamee + CheckBalance1.Mnamee + CheckBalance1.lnamee;
                pera.Text = CheckBalance1.bal;

            }

        }
        DataTable dts = new DataTable();

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountShowLoadTransaction a = new AccountShowLoadTransaction();
            a.ShowDialog();
            this.Hide();

         
            

        }

    }
}
