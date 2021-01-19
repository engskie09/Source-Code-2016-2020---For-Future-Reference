using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using RJCP.IO.Ports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public static class MythicalCafe_FrontEnd_SerialPort_RadioFrequency
    {
        static SerialPortStream SerialPortStream = null;

        public static void set_SerialPort_Configuration()
        {
            SerialPortStream = new SerialPortStream();
            SerialPortStream.PortName = MythicalCafe_FrontEnd_Main_Method.RadioFrequency_Port;
            SerialPortStream.BaudRate = 9600;
            SerialPortStream.Parity = Parity.None;
            SerialPortStream.DataBits = 8;
            SerialPortStream.StopBits = StopBits.One;
            SerialPortStream.Handshake = Handshake.None;
        }

        public static Boolean check_SerialPort_Connection()
        {
            try
            {
                if (!SerialPortStream.IsOpen)
                    SerialPortStream.Open();

                return true;
            }

            catch (Exception set_Exception) { Console.WriteLine(set_Exception.ToString()); set_SerialPort_Configuration(); return false; }
        }

        public static String get_SerialPort_Packet()
        {
            try { return SerialPortStream.ReadLine().Trim(); }
            catch (Exception set_Exception) { Console.WriteLine(set_Exception.ToString()); return ""; }            
        }

        public static Boolean set_SerialPort_Packet(String set_Packet)
        {
            try { SerialPortStream.Write(set_Packet); return true; }
            catch (Exception set_Exception) { Console.WriteLine(set_Exception.ToString()); return false; }
        }
    }
}
