using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace PeyRole
{
    public partial class LoginPayroll : Form
    {
        public LoginPayroll()
        {
            InitializeComponent();
        }

        public static string  qwe = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=T:\PeyRole\PeyRole\PeyrolexD.accdb" ;
        public static string defaultimage = @"T:\PeyRole\PeyRole\picturesXD\walaXD.png";
        OleDbConnection connection = new OleDbConnection();
       

        

        private void LoginPayroll_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(qwe);
        }

        int count = 0; 
       
        public void tutskie()
        {
            connection.Close();
            connection.Open();
            DataSet xD = new DataSet();
            OleDbDataAdapter qwerty = new OleDbDataAdapter("select * from AdminLogFile", connection);

            qwerty.Fill(xD);

            count = xD.Tables[0].Rows.Count + 1;


            connection.Close();
        }

        public static string profilePIC = "";
        public static string profileName = "";

        public void pakgumaganern()
        {
            connection.Close();
            connection.Open();

            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from AdminSession WHERE adminname= '" + inputname.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {


                profilePIC = xdr["adminpicture"].ToString();
                profileName = xdr["adminname"].ToString();

            }
            connection.Close();
        }

        int hackerPOTEK = 0;
        private void LoginAs_Click(object sender, EventArgs e)
        {
            connection.Open();
            string name = inputname.Text.Trim();
            string time = DateTime.Now.ToString("hh;mm;ss tt");
            string date = DateTime.Now.ToShortDateString();
            string note = "Login";

            OleDbDataAdapter dp = new OleDbDataAdapter("select * from AdminSession where adminname= '" + inputname.Text.Trim() + "'and adminpassword='" + inputpassword.Text.Trim() + "'", connection);

            DataTable dt = new DataTable();

            dp.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                connection.Close();

                
                
                tutskie();

                connection.Open();
                OleDbCommand cmd = new OleDbCommand("insert into AdminLogFile values ('"+count+"','"+name+"','"+time+"','"+date+"','"+note+"')",connection);
                cmd.ExecuteNonQuery();

                connection.Close();
                pakgumaganern();
                AdminSession xD = new AdminSession();
                xD.Show();
                this.Hide();


            }

         else if(hackerPOTEK == 2)
           {

               connection.Close();



               tutskie();

               note = "3 Attempts";
               connection.Open();
               OleDbCommand cmd = new OleDbCommand("insert into AdminLogFile values ('" + count + "','" + name + "','" + time + "','" + date + "','" + note + "')", connection);
               cmd.ExecuteNonQuery();

               connection.Close();
               MessageBox.Show("System Will Close.");
               this.Close();


         }

            else
            {
                MessageBox.Show("Check your username and password");
                connection.Close();
                hackerPOTEK++;
            }

            connection.Close();



            inputname.Text = "";
            inputpassword.Text = "";


        }
    }
}
