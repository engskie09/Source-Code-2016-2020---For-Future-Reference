using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CanteenKiosk
{
    public partial class CheckBalance1 : Form
    {

        string connetionString = null;
        string server = "localhost";
        string database = "canteen_db";
        string username = "root";
        string password = "";
        int i;


        public static string fnamee = "";
        public static string lnamee = "";
        public static string Mnamee = "";
        public static string bal = "";

        public CheckBalance1()
        {
            InitializeComponent();
        }

        private void CheckBalance_Load(object sender, EventArgs e)
        {
            Login.Select();
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            if (Login.Text.Length == 10)
            {

                MySqlConnection cnn;
                connetionString = "server=" + server + ";database=" + database + ";Username=" + username + ";Password=" + password + ";";
                cnn = new MySqlConnection(connetionString);
                // try
                //  {
                cnn.Open();

                i = 0;

                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from carduser Where cardno='" + Login.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (dt.Rows.Count == 1)
                {

                    cnn.Close();
                    cnn.Open();


                    MySqlCommand cmdx = cnn.CreateCommand();
                    cmdx.CommandType = CommandType.Text;
                    cmdx.CommandText = "Select Firstname,MiddleName,Lastname,Balance from carduser where cardno='" + Login.Text + "' ";
                    cmdx.ExecuteNonQuery();

                    DataTable dts = new DataTable();

                    MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);

                    xda.Fill(dts);


                    foreach (DataRow xdr in dts.Rows)


                    // fnamee
                    //  lnamee
                    // Mnamee
                    {
                        fnamee = xdr["FirstName"].ToString() + " ";
                        lnamee = xdr["LastName"].ToString() + " ";
                        Mnamee = xdr["MiddleName"].ToString() + " ";
                        bal = xdr["Balance"].ToString() + " ";
                        Balance.haysnako = 0;

                    }


                    cnn.Close();

                    MessageBox.Show("");
                    Balance a = new Balance();
                    a.ShowDialog();
                    this.Hide();



                }

                Login.Clear();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
