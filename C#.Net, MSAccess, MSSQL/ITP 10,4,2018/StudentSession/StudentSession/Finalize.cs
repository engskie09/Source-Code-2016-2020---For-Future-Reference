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
    public partial class Finalizee : Form
    {
        
        public Finalizee()
        {
            InitializeComponent();

        }
        
        string MyConnectionString = stringpotek.koneksyon;
   
        private void order_Load(object sender, EventArgs e)
        {

        }
        public static string getStudentID = "";
        public static string getStudentFullname = "";

        private void button1_Click(object sender, EventArgs e)
        {



        }
         void AddNewButton()
        {
           

        }
      
           
    private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


      

        private void Login_TextChanged(object sender, EventArgs e)
        {
            if (Login.Text.Length == 10)
            {


                MySqlConnection connection = new MySqlConnection(MyConnectionString);
                connection.Close();
                connection.Open();


                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from carduser where CardNo ='" + Login.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    foreach (DataRow dr in dt.Rows)
                    {

                        getStudentID = dr["StudentID"].ToString();
                        getStudentFullname = dr["FirstName"].ToString() + " " + dr["MiddleName"].ToString() + " " + dr["LastName"].ToString();

                    }
                    this.Hide();
                    Login.Clear();
                    Keyboard XD = new Keyboard();
                    XD.ShowDialog();




                }
                Login.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

       

    }
}
