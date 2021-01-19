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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MythicalCafe_FrontEnd_Main_Method.set_System_Configuration();
            MythicalCafe_FrontEnd_Main_Method.set_Dispose_Object();

            Application.Run(new MythicalCafe_FrontEnd_Main());
            
        }
    }
}