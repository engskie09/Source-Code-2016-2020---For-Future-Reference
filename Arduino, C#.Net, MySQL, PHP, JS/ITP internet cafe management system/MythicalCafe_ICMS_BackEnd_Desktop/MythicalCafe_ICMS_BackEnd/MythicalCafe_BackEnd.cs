using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MythicalCafe_ICMS_BackEnd
{
    static class MythicalCafe_BackEnd
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);          

            MythicalCafe_BackEnd_Main_Method.check_Directory_Availability(MythicalCafe_BackEnd_Main_Method.Image_Directory_Path);
            
            MythicalCafe_BackEnd_Main_Method.set_System_Configuration();

            MySqlConnection_String = "server=" + MythicalCafe_BackEnd_Main_Method.SQL_InternetProtocol_Address + ";userid=engskie09;password=engskie09;database=db_mythicalcafe_icms;Convert Zero Datetime=True;";

            if (!check_SQL_Connection())
                return;

            MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_SerialPort_Configuration();
            MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();

            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Server_Configuration();
            MythicalCafe_BackEnd_Workstation_Server.set_Socket_Client_Configuration();
            MythicalCafe_BackEnd_Main_Method.set_Dispose_Object();

            Application.Run(new MythicalCafe_BackEnd_Main());
        }

        public static String MySqlConnection_String = null;
        static MySqlConnection MySqlConnection = null;

        static Boolean check_SQL_Connection()
        {
            MySqlConnection = new MySqlConnection(MySqlConnection_String);

            MySqlConnection.Close();

            try
            {
                MySqlConnection.Open();
                set_MySqlConnection_String();
                return true;
            }

            catch (Exception set_Exception)
            {
                MessageBox.Show(set_Exception.ToString());
                return false;
            }
        }

        static void set_MySqlConnection_String()
        {            
            MythicalCafe_BackEnd_Main_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);
            
            MythicalCafe_BackEnd_Account_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);
            MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);
            MythicalCafe_BackEnd_Account_Staff_Manage_List_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);

            MythicalCafe_BackEnd_Log_Manage_List_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);

            MythicalCafe_BackEnd_Product_Manage_List_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);
            MythicalCafe_BackEnd_Product_Category_Manage_List_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);
            MythicalCafe_BackEnd_Product_Order_Manage_List_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);
        }
    }
}
