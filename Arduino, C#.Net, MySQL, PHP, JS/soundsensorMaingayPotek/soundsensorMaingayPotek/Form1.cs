using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace soundsensorMaingayPotek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort myport;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            myport = new SerialPort();
            
            
            myport.BaudRate = 9600;
            myport.PortName = "COM3";
            myport.Parity = Parity.None;
            myport.DataBits = 8;
            myport.StopBits = StopBits.One;
            setTimer.Interval = 200;
            
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            myport.Open();
            setTimer.Start();

        }


        private void testing()
        {

            if (myport.ReadLine() != "0")
            {
                //setTimer.Interval = Convert.ToInt32(myport.ReadLine());
                getSerialValue.Text = "db: " + myport.ReadLine();
                Console.WriteLine("db: " + myport.ReadLine());
                //setMaingayOrHinde(Convert.ToInt32(myport.ReadLine()));
                //MessageBox.Show(myport.ReadLine());
                //Thread.Sleep(200);
            }

            else
            {
                //setTimer.Interval = Convert.ToInt32(myport.ReadLine());
                getSerialValue.Text = "db: " + "0";
                Console.WriteLine("db: " + myport.ReadLine());
                setMaingayOrHinde(Convert.ToInt32(myport.ReadLine()));
                //Thread.Sleep(200);
            }
            //MessageBox.Show("db: " + myport.ReadLine());
            //Debug.WriteLine("db: " + myport.ReadLine());
            
        }

        private void setMaingayOrHinde(float getval)
        {
            if (getval < 50)
                setValue.Text = "INGAAY";
            else if (getval < 100)
            {
                setValue.Text = "SUMUSOBRA NA AH!";               
            }
            else if (getval > 100)
                setValue.Text = "POTEK!";
        }

    

        private void setTimer_Tick(object sender, EventArgs e)
        {
            
            testing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myport.Close();
            setTimer.Stop();
            getSerialValue.Text = "*****";  
        }  


    }
}
