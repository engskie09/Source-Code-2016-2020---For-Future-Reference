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

namespace soundsensornotif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort myport = new SerialPort();

        private void Form1_Load(object sender, EventArgs e)
        {

            ewan();
            
            
        }

        private void ewan()
        {

            myport.BaudRate = 9600;
            myport.PortName = "COM3";
            myport.Open(); 

            String getSerialString = myport.ReadLine();
            label1.Text = getSerialString;

            
        }
    }
}
