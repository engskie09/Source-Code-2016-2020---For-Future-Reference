using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    static class MythicalCafe_FrontEnd
    {        

        [STAThread]
        static void Main()
        {            
            MythicalCafe_FrontEnd_Main_Method.set_System_Configuration();
            
            MySqlConnection_String = "server=" + MythicalCafe_FrontEnd_Main_Method.Server_InternetProtocol_Address + ";userid=engskie09;password=engskie09;database=db_mythicalcafe_icms;Convert Zero Datetime=True;";

            MySqlConnection = new MySqlConnection(MySqlConnection_String);

            MythicalCafe_FrontEnd_Main_Method.MySqlConnection = new MySqlConnection(MySqlConnection_String);

            if (!check_SQL_Connection())
                return;

            MythicalCafe_FrontEnd_Main_Method.set_Dispose_Object();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MythicalCafe_FrontEnd_Main());
        }

        public static String MySqlConnection_String = null;
        static MySqlConnection MySqlConnection = null;

        static Boolean check_SQL_Connection()
        {
            MySqlConnection.Close();

            try
            {
                MySqlConnection.Open();
                return true;
            }

            catch (Exception set_Exception)
            {
                MessageBox.Show(set_Exception.ToString());
                return false;
            }
        }
    }
}
