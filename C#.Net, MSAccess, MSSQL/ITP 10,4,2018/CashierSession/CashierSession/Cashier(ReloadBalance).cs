using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier_Register_Reload_
{
    public partial class Cashier_ReloadBalance_ : Form
    {

        MySqlConnection connection = new MySqlConnection(methods.con);

        int second = 0;

        public Cashier_ReloadBalance_()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable("carduser");
        private void Cashier_ReloadBalance__Load(object sender, EventArgs e)
        {

            timer1.Start();

            MySqlCommand cmd = new MySqlCommand("select * from carduser;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;
            dataGridView1.DataSource = dt;

        }
        
            private void button2_Click(object sender, EventArgs e)
        {
            StudentLoad();
            UpdateStudentBalance();
        }
        public void StudentLoad()
        {

            String InsertQuery = "INSERT INTO loadtransactionreporttbl(StudentID,StudentName,AmountLoad) VALUES(@Studid,@Studentname,@Amountload)";

            connection.Close();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM loadtransactionreporttbl;", connection);

            cmd = new MySqlCommand(InsertQuery, connection);

            cmd.Parameters.Add("@Studid", MySqlDbType.VarChar, 30);

            cmd.Parameters.Add("@Studentname", MySqlDbType.VarChar, 30);

            cmd.Parameters.Add("@Amountload", MySqlDbType.VarChar, 30);

            //cmd.Parameters.Add("@ldate",MySqlDbType.VarChar,100);

            cmd.Parameters["@Studid"].Value = StudentID.Text;

            cmd.Parameters["@Studentname"].Value = StudentName.Text;

            cmd.Parameters["@Amountload"].Value = EnterAmount.Text;

            //cmd.Parameters["@ldate"].Value = Date.Text;

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully Inserted");

                {
                    



                }


            }
        }

      

        int balance = 0;
        

        public void UpdateStudentBalance()
        {
            MySqlConnection connection = new MySqlConnection(methods.con);

            connection.Close();
            connection.Open();





            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select balance from carduser where StudentID='" + StudentID.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);






            foreach (DataRow dr in dt.Rows)
            {
                balance = Convert.ToInt32(dr["Balance"].ToString());

                EnterAmount.Text = (balance + Convert.ToInt32(EnterAmount.Text)).ToString();

                
            }
          


            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE carduser SET Balance = '" + EnterAmount.Text + "' where StudentID ='" + StudentID.Text + "'";
            cmd.ExecuteNonQuery();

            StudentID.Text = String.Empty;
            StudentName.Text = String.Empty;
            Balance.Text = String.Empty;
            EnterAmount.Text = String.Empty;


            connection.Close();

        }


        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("CardNo+StudentID like '%{0}%'", Search.Text);


                dataGridView1.DataSource = dv.ToTable();

                try
                {

                    StudentName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + dataGridView1.CurrentRow.Cells[2].Value.ToString() + dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    //StudentName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    //StudentName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Balance.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    StudentID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                }
                catch
                {
                    MessageBox.Show("mali ang cardno o student id");
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("CardNo+StudentID like '%{0}%'", Search.Text);
               
              
                dataGridView1.DataSource = dv.ToTable();

                try {

                StudentName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString()+dataGridView1.CurrentRow.Cells[2].Value.ToString()+dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //StudentName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //StudentName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                Balance.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                StudentID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                }
                catch
                {
                    MessageBox.Show("mali ang cardno o student id");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentID_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_Main_ a = new Cashier_Main_();
            a.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString();
            second = second + 1;
           
        }
    }
}
