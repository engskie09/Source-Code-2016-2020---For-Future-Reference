//Rafael Nobleza Masallo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JSP_LibrarySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            checkConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new AdminSession_Main());
            Application.Run(new GeneralSession_Login());
        }

        public static String connectionString = "server=localhost;userid=root;database=db_jplhs_librarysystem";

        private static MySqlConnection connection = new MySqlConnection(connectionString);  

        private static void checkConnection()
        {
            connection.Close();
            try
            {
                connection.Open();
            }

            catch (Exception e)
            {
                MessageBox.Show("Connection error bobo");
                MessageBox.Show(e.ToString());
                return;
            }

            connection.Close();
        }
    }
}
