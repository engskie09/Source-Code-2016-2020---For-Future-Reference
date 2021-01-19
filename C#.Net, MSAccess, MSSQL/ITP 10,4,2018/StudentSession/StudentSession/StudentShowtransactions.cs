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
    public partial class StudentShowtransactions : Form
    {
        MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);

        public StudentShowtransactions()
        {
            InitializeComponent();


       
        }

        public static string getStudID = "";

        private void StudentShowtransactions_Load(object sender, EventArgs e)
        {

            try
            {


                getStudCurrentBalanceFullName();
                getStudentTransaction();

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

                dataGridView1.RowTemplate.Height = 60;

            }
            catch (Exception)
            {
                throw;
            }
         
          
           

        }
        public void date()
        {

            DataTable dt = new DataTable();

            connection.Close();
            connection.Open();
           datehandler.Value = DateTime.Parse(DateFrom.Text).AddDays(-1);

            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from transaction_report_tbl where OrderDate between @a1 and @a2 ";
            // datefrom.Value = DateTime.Parse(datefrom.Text).AddDays(-1);
            cmd.Parameters.AddWithValue("@a1", datehandler.Value.ToString());
            cmd.Parameters.AddWithValue("@a2", DateTo.Value.ToString());
            cmd.ExecuteNonQuery();
            da.Fill(dt);
            //dateTimePickerDOB.Text = DateTime.Parse(dateTimePickerAdmission.Text).AddDays(-1).ToString();
            dataGridView1.AutoGenerateColumns = false;

           
            dataGridView1.Columns[0].DataPropertyName = "OrderProducts";
            dataGridView1.Columns[1].DataPropertyName = "OrderQuantity";
            dataGridView1.Columns[2].DataPropertyName = "OrderPrice";
            dataGridView1.Columns[3].DataPropertyName = "OrderTotalPrice";
            dataGridView1.Columns[4].DataPropertyName = "OrderDate";
            

            dataGridView1.DataSource = dt;



            connection.Close();
        }
        public void getStudentTransaction()
        {
            //dataGridView1.DataSource = AccountShowTransactionDialog.dts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;
                if (dataGridView1.CurrentRow.Index + 1 >= 0)
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[0];
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;



                }
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                {


                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index - 1].Cells[0];
                    dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;



                }
            }
            catch (Exception)
            {
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Transaction Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "STO MONTESORRI SCHOOL";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
           
           
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            date();
        }
     
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getStudCurrentBalanceFullName()
        {

            connection.Close();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from carduser where StudentID = '" + getStudID + "'";

          
            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                MessageBox.Show("qweqwe");
                String balance = dr["Balance"].ToString();
                String fname = dr["FirstName"].ToString();
                String mname = dr["MiddleName"].ToString();
                String lname = dr["LastName"].ToString();
                String fullname = fname + " " + mname + " " + lname;
               
            }

          /*  DataRow dr = dt.Rows[0];

            String balance = dr["Balance"].ToString();
            String fname = dr["FirstName"].ToString();
            String mname = dr["MiddleName"].ToString();
            String lname = dr["LastName"].ToString();

            String fullname = fname + " " + mname + " " + lname;


            lblgetCurrentBalance.Text = balance;
            lblgetFullName.Text = fullname;*/

            connection.Close();

        }

        private void lblgetCurrentBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
