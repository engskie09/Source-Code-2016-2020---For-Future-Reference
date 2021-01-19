using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Customer_HLTC
{
    class Bus_Prices
    {

        private static SqlConnection connection = new SqlConnection(Program.connectionString);
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter da = new SqlDataAdapter();

        public static DataTable dt = new DataTable();

        private static String tblName = "tbl_prices";

        public static int get_Price(String destination, string bustype)
        {
            dt.Clear();
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM " + tblName + " WHERE location_id = '" + destination + "'";
            cmd.ExecuteNonQuery();

            da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            int set_ReturnValue = 0;

            if (dt.Rows.Count != 0)
            {
             

                if (bustype == "Hyundai Super Aero City")
                {
                    DataRow dr = dt.Rows[0];
                    set_ReturnValue = Int32.Parse(dr["HSAC"].ToString());
                }
                else if (bustype == "Hyundai Super Aero Intercity")
                {
                    DataRow dr = dt.Rows[0];
                    set_ReturnValue = Int32.Parse(dr["HSAI"].ToString());

                }
                else if (bustype == "Daewoo BF106")
                {
                    DataRow dr = dt.Rows[0];
                    set_ReturnValue = Int32.Parse(dr["DBF"].ToString());

                }
                else if (bustype == "Daewoo BH090")
                {
                    DataRow dr = dt.Rows[0];
                    set_ReturnValue = Int32.Parse(dr["DBH"].ToString());

                }
                else if (bustype == "Fuso FHX-80")
                {
                    DataRow dr = dt.Rows[0];
                    set_ReturnValue = Int32.Parse(dr["FFHX"].ToString());

                }
                else if (bustype == "Isuzu FVR")
                {
                    DataRow dr = dt.Rows[0];
                    set_ReturnValue = Int32.Parse(dr["FVR"].ToString());

                }


            }


            connection.Close();

            return set_ReturnValue;
        }



    }
}
