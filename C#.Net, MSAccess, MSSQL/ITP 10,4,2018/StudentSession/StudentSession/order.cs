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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();

        }
        int c = 1;



        private void order_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
         void AddNewButton()
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Top = c * 28;
            btn.Left = 150;
            btn.Text = "Button" + this.c.ToString();
            c = c + 1;
            return;

        }
      
           
    private void button1_Click_1(object sender, EventArgs e)
        {
            AddNewButton();
        }
        
    }
}
