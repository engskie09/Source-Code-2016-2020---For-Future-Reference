using RJCP.IO.Ports;
using System;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_SerialPort_RadioFrequency
    {
        public static SerialPortStream SerialPortStream = null;

        public static void set_SerialPort_Configuration()
        {

            SerialPortStream = new SerialPortStream();
            SerialPortStream.PortName = MythicalCafe_BackEnd_Main_Method.RadioFrequency_Port_Name;
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

            catch (Exception set_Exception) { Console.WriteLine(set_Exception.ToString()); SerialPortStream.Close(); set_SerialPort_Configuration(); return false; }
        }

        public static String get_SerialPort_Packet()
        {
            try { return SerialPortStream.ReadLine().Trim(); }
            catch (Exception set_Exception) { Console.WriteLine(set_Exception.ToString()); return ""; }
        }

        public static Boolean set_SerialPort_Packet(String set_Packet)
        {
            try { SerialPortStream.Write(set_Packet); return true; }
            catch (Exception set_Exception) { Console.WriteLine(set_Exception.ToString());  return false; }
        }
    }
}