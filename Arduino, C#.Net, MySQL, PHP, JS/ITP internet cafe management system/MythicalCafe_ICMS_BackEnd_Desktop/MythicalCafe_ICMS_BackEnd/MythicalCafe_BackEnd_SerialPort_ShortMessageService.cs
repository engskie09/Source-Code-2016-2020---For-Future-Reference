using RJCP.IO.Ports;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_SerialPort_ShortMessageService
    {
        public static SerialPortStream SerialPortStream = null;

        public static void set_SerialPort_Configuration()
        {
            SerialPortStream = new SerialPortStream();
            SerialPortStream.PortName = MythicalCafe_BackEnd_Main_Method.ShortMessageService_Port_Name;
            SerialPortStream.BaudRate = 9600;
            SerialPortStream.Parity = Parity.None;
            SerialPortStream.DataBits = 8;
            SerialPortStream.StopBits = StopBits.One;
            SerialPortStream.Handshake = Handshake.Rts;
            SerialPortStream.DtrEnable = true;
            SerialPortStream.RtsEnable = true;
            SerialPortStream.NewLine = Environment.NewLine;
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
            catch (Exception set_Exception) { Console.WriteLine(set_Exception.ToString()); return false; }
        }

        public static void set_ShortMessageService_Message(String set_SubscriberIdentificationModule_Number, String set_Message)
        {
            if (MythicalCafe_BackEnd_Main_Method.ShortMessageService_Status == "Disable")
                return;

            if (!set_SerialPort_Packet(" "))
            {
                set_SerialPort_Configuration();
                check_SerialPort_Connection();
            }


            Thread get_Thread = new Thread(delegate()
            {
                set_SerialPort_Packet("AT+CMGF=1\r");

                Thread.Sleep(1000);

                set_SerialPort_Packet("AT+CMGS=\"" + set_SubscriberIdentificationModule_Number + "\"\r\n");

                Thread.Sleep(1000);

                set_SerialPort_Packet(set_Message + "\x1A");

                Thread.Sleep(1000);

                //if (SerialPortStream.IsOpen)
                    //MessageBox.Show("Success" + set_Message);
            });

            get_Thread.Start();
        }
    }
}
