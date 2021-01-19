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

namespace CanteenManager
{
    public partial class OrderView : Form
    {
        public OrderView()
        {
            InitializeComponent();
            
        }

        private void OrderView_Load(object sender, EventArgs e)
        {
            getOrderno();
            load1();
            load2();
           
        }
        public void load2()
        {
          

            dataGridView2.AllowUserToAddRows = false;

          

         

            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView2.BackgroundColor = Color.White;

            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        public void load1()
        {
            

            dataGridView1.AllowUserToAddRows = false;

            



          


            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            a.Show();
            this.Hide();
        }

        public void getOrderno()
        {
            MySqlConnection cnn;

            cnn = new MySqlConnection(stringpotek.koneksyon);
            // try
            //  {
            cnn.Close();
            cnn.Open();



            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select DISTINCT Order_No from tbl_queuing";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();

        }
        int selectedRow = 0;

        string getOrderbyOrderNo = "";

        List<String> StudentProductName = new List<String>();
        List<String> StudentProductQuantity = new List<String>();
        DataTable currentQueue = new DataTable();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                selectedRow = e.RowIndex;
                DataGridViewRow SelectFromKart = dataGridView1.Rows[e.RowIndex];

                getOrderbyOrderNo = SelectFromKart.Cells[0].Value.ToString();

                QueuingSession();
                
            }
            catch { }
        }

        private void btnFinishQueue_Click(object sender, EventArgs e)
        {
            deleteFromQueuing();
        }

        private void QueuingSession()  
        {
            StudentProductName.Clear();
            StudentProductQuantity.Clear();
            dataGridView2.Rows.Clear();        

            MySqlConnection cnn = new MySqlConnection(stringpotek.koneksyon);

            cnn.Close();
            cnn.Open();


            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_queuing where Order_No = '" + getOrderbyOrderNo + "'";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            DataRow dr = dt.Rows[0];


            StudentProductName = dr["Order_ProductName"].ToString().Split(',').ToList<String>();
            StudentProductQuantity = dr["Order_ProductQuantity"].ToString().Split(',').ToList<String>();
            cnn.Close();

            for (int x = 0; x <= StudentProductName.Count - 1; x++)
            {

                dataGridView2.Rows.Add(StudentProductName[x], StudentProductQuantity[x]);

            }
        }

        private void deleteFromQueuing()
        {
            {

            MySqlConnection cnn = new MySqlConnection(stringpotek.koneksyon);

            cnn.Close();
            cnn.Open();

            MySqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from tbl_queuing where Order_No = '" + getOrderbyOrderNo + "'";

            cmd.ExecuteNonQuery();
            getOrderno();
            cnn.Close();

            }

        }
        

    }
}
