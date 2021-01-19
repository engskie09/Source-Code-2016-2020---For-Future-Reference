using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_HLTC
{
    class SystemMethods_ID_Counter
    {
        private static SqlConnection connection = new SqlConnection(Program.connectionString);
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter da = new SqlDataAdapter();

        public static DataTable dt = new DataTable();

        private static String tblName = "tbl_ID_Counter";

        public static String get_CurrentID_Count(String get_CounterName)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT counter_current FROM " + tblName + " WHERE counter_name = '" + get_CounterName + "'";
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            String set_ReturnValue = "";

            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                set_ReturnValue = dr["counter_current"].ToString();
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
            cmd.CommandText = "SELECT counter_current FROM " + tblName + " WHERE counter_name = '" + get_CounterName + "'";
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                Int32 currentCount = Convert.ToInt32(dr["counter_current"].ToString()) + 1;

                cmd.CommandText = "UPDATE " + tblName + " SET counter_current = '" + currentCount + "'WHERE counter_name = '" + get_CounterName + "'";
                cmd.ExecuteNonQuery();
            }



            connection.Close();
        }
    }
}
