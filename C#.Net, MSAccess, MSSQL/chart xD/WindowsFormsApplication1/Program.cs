using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
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
            set_db_Connection(connectionString);
            Application.Run(new Form1());
        }
        public static String connectionString = "Data Source=PC06\\SQLEXPRESS;Initial Catalog=db_hltc;Integrated Security=True";

        private static void set_db_Connection(String set_connectionString)
        {
            SqlConnection con = new SqlConnection(set_connectionString);

            try
            {
                con.Open();

                if (con.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Connection Available!");                    

                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Please Check your Connection!!!" + e.ToString());
                Application.Exit();
            }
        }
    }
}
