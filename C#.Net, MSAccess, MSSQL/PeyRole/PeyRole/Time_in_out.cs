using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeyRole
{
    public partial class Time_in_out : Form
    {
        public Time_in_out()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection();
        TimeSpan taym1 = new TimeSpan();
        TimeSpan taym2 = new TimeSpan();
        DateTime time = DateTime.Now;
        string fullname = "";

        public void getpulneym()
        {


            connection.Close();

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from PersonelsMain WHERE EmployeeID= '" + txtEmployeeID.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                fullname = xdr["CompleteName"].ToString();

            }
            connection.Close();
        }


        private void buttonTimeIn_Click(object sender, EventArgs e)
        {

           

            string a = time.ToLongTimeString();            
            string[] firsttime = a.Split(':');
            int hr, minute, second;             
            int.TryParse(firsttime[0], out hr);
            int.TryParse(firsttime[1], out minute);
            int.TryParse(firsttime[2], out second); 
            taym1 = new TimeSpan(hr,minute,second);

            MessageBox.Show(taym1.ToString());



            getpulneym();

            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into AttendanceInOut (EmployeeID, Full_Name, Time_in, Date_today) Values (@a1,@a2,@a3,@a4)";
            command.Parameters.AddWithValue("@a1", txtEmployeeID.Text.Trim());
            command.Parameters.AddWithValue("@a2", fullname );
            command.Parameters.AddWithValue("@a3", taym1.ToString());
            command.Parameters.AddWithValue("@a4", DateTime.Today.ToShortDateString());


            command.ExecuteNonQuery();
            connection.Close();  







        }

        private void Time_in_out_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(LoginPayroll.qwe);
        }

        private void buttonTimeOut_Click(object sender, EventArgs e)
        {
            string a = time.ToLongTimeString();
            string[] firsttime = a.Split(':');
            int hr, minute, second;
            int.TryParse(firsttime[0], out hr);
            int.TryParse(firsttime[1], out minute);
            int.TryParse(firsttime[2], out second);

            taym2 = new TimeSpan(6, 0, 0);

            var difference = taym2.Subtract(taym1);
            MessageBox.Show(taym2.ToString());
            MessageBox.Show(difference.ToString());           

           

            //---get hour

            string diff = difference.ToString();

            string[] gethour = diff.Split(':');
            int totalhour;
            int.TryParse(gethour[0], out totalhour);

            MessageBox.Show(totalhour.ToString());
            //---get hour
            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "update AttendanceInOut Set First_Name = @a2, Last_Name = @a3 where EmployeeID = @19";

            command.Parameters.AddWithValue("@a2", fname.Text.Trim());
            command.Parameters.AddWithValue("@a3", lname.Text.Trim());
           

            command.ExecuteNonQuery();

        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.uppercaseFirstLetter(sender, e, txtEmployeeID.Text.Trim());
        }
    }
}
