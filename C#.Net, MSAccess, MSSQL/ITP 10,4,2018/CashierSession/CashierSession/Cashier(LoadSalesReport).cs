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
    public partial class Cashier_LoadSalesReport_ : Form
    {
        MySqlConnection connection = new MySqlConnection(methods.con);

        public Cashier_LoadSalesReport_()
        {
            InitializeComponent();
        }

        private void Cashier_LoadSalesReport__Load(object sender, EventArgs e)
        {
           
            MySqlCommand cmd = new MySqlCommand("select StudentID, StudentName, AmountLoad, LoadDate from loadtransactionreporttbl;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;
            dataGridView1.DataSource = dt;

            dataGridView1.RowTemplate.Height = 60;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.DataSource = b;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


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

            getTotal();
        }
        public void date()
        {
            getTotal();

            DataTable dt = new DataTable();

            connection.Close();
            connection.Open();
            datehandler.Value = DateTime.Parse(DateFrom.Text).AddDays(-1);

            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select StudentID, StudentName, AmountLoad, LoadDate from loadtransactionreporttbl where LoadDate between @a1 and @a2 ";
            // datefrom.Value = DateTime.Parse(datefrom.Text).AddDays(-1);
            cmd.Parameters.AddWithValue("@a1", datehandler.Value.ToString());
            cmd.Parameters.AddWithValue("@a2", DateTo.Value.ToString());
            cmd.ExecuteNonQuery();
            da.Fill(dt);
            //dateTimePickerDOB.Text = DateTime.Parse(dateTimePickerAdmission.Text).AddDays(-1).ToString();
            dataGridView1.AutoGenerateColumns = false;

            try
            {

                dataGridView1.Columns[0].DataPropertyName = "StudentID";
                dataGridView1.Columns[1].DataPropertyName = "StudentName";
                dataGridView1.Columns[2].DataPropertyName = "AmountLoad";
                dataGridView1.Columns[3].DataPropertyName = "LoadDate";
               

                dataGridView1.DataSource = dt;
            }
            catch { }

            connection.Close();
        }

        private void DateFrom_ValueChanged(object sender, EventArgs e)
        {
            date();
        }

        private void DateTo_ValueChanged(object sender, EventArgs e)
        {
            date();
        }



        public void getTotal()
        {

            int a = dataGridView1.Rows.Count - 1;
            int takeTotal = 0;


            for (int x = 0; x <= a; x++)
            {
                int take = Convert.ToInt16(dataGridView1.Rows[x].Cells[2].FormattedValue.ToString());

                takeTotal = takeTotal + take;
                SalesReportTotalAmount.Text = takeTotal.ToString();

            }

            if (dataGridView1.Rows.Count == 0)
            {
                // SalesReportTotalAmount.Text = "-----";
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
         
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reload Sales Report for Sto. Rosario Montessori School";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Amount = " + SalesReportTotalAmount.Text;
            
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_Main_ a = new Cashier_Main_();
            a.Show();
            this.Hide();
        }
    }
    }
