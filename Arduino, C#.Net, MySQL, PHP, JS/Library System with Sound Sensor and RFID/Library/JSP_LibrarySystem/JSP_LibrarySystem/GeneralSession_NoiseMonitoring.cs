using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSP_LibrarySystem
{
    public partial class GeneralSession_NoiseMonitoring : Form
    {
        public GeneralSession_NoiseMonitoring()
        {
            InitializeComponent();
        }

        private void GeneralSession_NoiseMonitoring_Load(object sender, EventArgs e)
        {
            set_SoundSensor();
            tm_setTimber.Interval = 300;
            tm_setTimber.Start();       
    
        }

        SerialPort sp;

        private void set_SoundSensor()
        {
            sp = new SerialPort();
            sp.BaudRate = 9600;
            sp.PortName = "COM3";
            sp.Parity = Parity.None;    
            sp.DataBits = 8;
            sp.StopBits = StopBits.One;
            sp.Open();
            sp.Write("#tae\n");
        }

        private void tm_setTimber_Tick(object sender, EventArgs e)
        {
            textBox1.Text = sp.ReadLine();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            if (Convert.ToDouble(textBox1.Text) > 60.0)
            {
                pctbox_bulb1.Image = Properties.Resources.lighton;
            }

            else
            {
                pctbox_bulb1.Image = Properties.Resources.lightoff;              
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                return;

            if (Convert.ToDouble(textBox1.Text) > 60.0)
            {
                pctbox_bulb2.Image = Properties.Resources.lighton;
            }

            else
            {
                pctbox_bulb2.Image = Properties.Resources.lightoff;
            }
        }

        private void btn_switch1_Click(object sender, EventArgs e)
        {
            sp.Write("#tae\n");
            textBox1.Text = sp.ReadLine();  
            pctbox_bulb1.Image = Properties.Resources.lightoff;          
               
        }

        private void btn_switch2_Click(object sender, EventArgs e)
        {
           //pctbox_bulb2.Image = Properties.Resources.lightoff;
           ///textBox2.Text = "0";
           //sp.Write("#STAR\n");
        }

        

        
    }
}
