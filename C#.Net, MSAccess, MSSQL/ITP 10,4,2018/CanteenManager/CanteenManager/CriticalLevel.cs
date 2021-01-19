using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManager
{
    public partial class CriticalLevel : Form
    {
        string item;
        
        public CriticalLevel(string item1)
        {
            InitializeComponent();
            label2.Text = "The Items:" + "\n" + item1+"\n" + "is on the critical level. Please Re-Stock";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestockUp a = new RestockUp();
            Main b = new Main();
            b.Visible = false;
            a.Show();
            this.Hide();
        }

        private void CriticalLevel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
