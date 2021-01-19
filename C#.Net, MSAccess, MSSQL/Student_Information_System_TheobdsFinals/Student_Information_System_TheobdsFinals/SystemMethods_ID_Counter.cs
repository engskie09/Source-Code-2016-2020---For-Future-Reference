using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Information_System_TheobdsFinals
{
    class SystemMethods_ID_Counter
    {
        private static MySqlConnection connection = new MySqlConnection(Program.connectionString);
        private static MySqlCommand cmd = new MySqlCommand();
        private static MySqlDataAdapter da = new MySqlDataAdapter();

        public static DataTable dt = new DataTable();

        private static String tblName = "tbl_counter_id";

        public static String get_CurrentID_Count(String get_CounterName)
        {           
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT counter_Count FROM " + tblName + " WHERE counter_Name = '" + get_CounterName + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            String set_ReturnValue = "";

            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                set_ReturnValue = dr["counter_Count"].ToString();
            }


            connection.Close();

            return set_ReturnValue;
        }

        public static void set_CurrentID_Count(String get_CounterName)
        {

            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT counter_Count FROM " + tblName + " WHERE counter_Name = '" + get_CounterName + "'";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                Int32 currentCount = Convert.ToInt32(dr["counter_Count"].ToString()) + 1;

                cmd.CommandText = "UPDATE " + tblName + " SET counter_Count = '" + currentCount + "'WHERE counter_Name = '" + get_CounterName + "'";
                cmd.ExecuteNonQuery();
            }



            connection.Close();
        }
    }
}
