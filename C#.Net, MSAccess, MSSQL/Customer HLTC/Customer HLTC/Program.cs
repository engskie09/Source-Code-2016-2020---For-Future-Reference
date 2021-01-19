using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer_HLTC
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

            //check if the Database connection is valid.
            set_db_Connection(connectionString);

        }

        //Declare a static String variable for connection.
        public static String connectionString = "Data Source=(LocalDB)\\HTLC;Initial Catalog=db_hltc;Integrated Security=True";

        //Set method for checking the database connection.
        private static void set_db_Connection(String set_connectionString)
        {
            SqlConnection con = new SqlConnection(set_connectionString);

            try
            {
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    //MessageBox.Show("Connection Available!");
                }

                Application.Run(new frmLogin());
            }

            catch (Exception e)
            {
                MessageBox.Show("Please Check your Connection!!!" + e.ToString());
                Application.Exit();
            }
        }

    }
}
