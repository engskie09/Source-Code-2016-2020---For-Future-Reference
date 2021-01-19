using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System_TheobdsFinals
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            set_Connection();
            
        }

        public static String connectionString = "server=localhost;user id=root;password=;database=db_informationsystem;";
        public static MySqlConnection con = new MySqlConnection(connectionString);

        private static void set_Connection()
        {
             
            try
            {
                con.Close();
                con.Open();
                con.Close();
                Application.Run(new GeneralSession_Main());
                                              
            }

            catch (Exception e)
            {
                GeneralSession_MessageBox.Show("Runtime Error!!!", e.ToString());
            }
            
        }
    }
}
