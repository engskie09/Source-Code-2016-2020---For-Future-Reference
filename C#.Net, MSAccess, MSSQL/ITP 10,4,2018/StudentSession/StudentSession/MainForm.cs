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
using System.IO;


namespace CanteenKiosk
{
    public partial class MainForm : Form
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
      
        int second = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 40);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.Select();

            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            /*Loginpanel.Visible = true;
            Homepanel.Visible = false;*/

            Account xd = new Account();
            xd.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();

         //   MessageBox.Show((DateTime.Today.DayOfWeek).ToString());

            string datetoday = DateTime.Now.ToShortDateString();
            //MessageBox.Show(datetoday);
            MySqlConnection cnn;
            connetionString = "server=" + server + ";database=" + database + ";Username=" + username + ";Password=" + password + ";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();


                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No Internet Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            this.Hide();


        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
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


                }


                cnn.Close();

                Account a = new Account();
                a.Show();
                this.Hide();
            }
        }

        private void Login_TextChanged_1(object sender, EventArgs e)
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


                    }


                    cnn.Close();

                    MessageBox.Show("");
                    Account a = new Account();
                    a.Show();
                    this.Hide();



                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = button8.Height;
            sidepanel.Top = button8.Top;
           
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = button9.Height;
            sidepanel.Top = button9.Top;
          
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
           else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
           else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox10.Visible = false;
                pictureBox5.Visible = true;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            bilhin a = new bilhin();
            a.Show();
            this.Hide();
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {
            panel5.BackColor = Color.FromArgb(100, 0, 150, 230);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
          
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
          // panel9.BackColor = Color.FromArgb(10, 0,0 ,70);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            orasan.Text = DateTime.Now.ToString();
            second = second + 1;
        }

       
    }
}
  