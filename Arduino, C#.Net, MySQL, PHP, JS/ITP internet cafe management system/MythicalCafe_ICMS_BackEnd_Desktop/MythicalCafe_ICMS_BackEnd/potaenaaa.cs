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

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class potaenaaa : Form
    {
        public potaenaaa()
        {
            InitializeComponent();
        }

        private void Potaenaaa_Load(object sender, EventArgs e)
        {
            Thread get_Thread = new Thread(delegate()
            {
                Thread.Sleep(2000);

                panel1.BackColor = Color.Red;

                Thread.Sleep(2000);

                panel1.BackColor = Color.Blue;

                Thread.Sleep(1000);

                label2.Text = "Cannot connect to the Client....";

                Thread.Sleep(1000);

                panel1.BackColor = Color.FromArgb(118, 156, 255);

                Thread.CurrentThread.Abort();
            });

            get_Thread.Start();
        }
    }
}
