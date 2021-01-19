using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MythicalCafe_ICMS_BackEnd
{
    public class MythicalCafe_BackEnd_Account_Method
    {
        public static MySqlConnection MySqlConnection = new MySqlConnection(MythicalCafe_BackEnd.MySqlConnection_String);
        public static MySqlCommand MySqlCommand = new MySqlCommand();
        public static MySqlDataAdapter MySqlDataAdapter = new MySqlDataAdapter();

        public static Thread get_Account_Thread_1;

        static String Table_Name_1 = MythicalCafe_BackEnd_Main_Method.Table_Name_1; /* tbl_Customer_personal_information */
        static String Table_Name_2 = MythicalCafe_BackEnd_Main_Method.Table_Name_2; /* tbl_Customer_credential_information */
        static String Table_Name_3 = MythicalCafe_BackEnd_Main_Method.Table_Name_3; /* tbl_Customer_property_information */
    }
}
