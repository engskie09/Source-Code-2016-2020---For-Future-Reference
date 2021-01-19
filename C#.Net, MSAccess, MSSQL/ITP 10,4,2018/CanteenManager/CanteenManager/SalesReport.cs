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

namespace CanteenManager
{
    public partial class SalesReport : Form
    {
        MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);

        public SalesReport()
        {
            InitializeComponent();
            
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            
            MySqlCommand cmd = new MySqlCommand("select OrderProducts, OrderQuantity, OrderPrice, OrderTotalPrice, OrderDate from transaction_report_tbl;", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource b = new BindingSource();
            b.DataSource = dt;
            dataGridView1.DataSource = dt;
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
                cmd.CommandText = "select OrderProducts, OrderQuantity, OrderPrice, OrderTotalPrice, OrderDate from transaction_report_tbl where OrderDate between @a1 and @a2 ";
                // datefrom.Value = DateTime.Parse(datefrom.Text).AddDays(-1);
                cmd.Parameters.AddWithValue("@a1", datehandler.Value.ToString());
                cmd.Parameters.AddWithValue("@a2", DateTo.Value.ToString());
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                //dateTimePickerDOB.Text = DateTime.Parse(dateTimePickerAdmission.Text).AddDays(-1).ToString();
                dataGridView1.AutoGenerateColumns = false;

            try
            {

                dataGridView1.Columns[0].DataPropertyName = "OrderProducts";
                dataGridView1.Columns[1].DataPropertyName = "OrderQuantity";
                dataGridView1.Columns[2].DataPropertyName = "OrderPrice";
                dataGridView1.Columns[3].DataPropertyName = "OrderTotalPrice";
                dataGridView1.Columns[4].DataPropertyName = "OrderDate";

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

        private void Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sales Report for Sto. Rosario Montessori School";
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
        public void getTotal()
        {

            int a = dataGridView1.Rows.Count - 1;
            int takeTotal = 0;


            for (int x = 0; x <= a; x++)
            {
                int take = Convert.ToInt16(dataGridView1.Rows[x].Cells[3].FormattedValue.ToString());

                takeTotal = takeTotal + take;
                SalesReportTotalAmount.Text = takeTotal.ToString();

            }

            if (dataGridView1.Rows.Count == 0)
            {
               // SalesReportTotalAmount.Text = "-----";
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            getTotal();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            a.Show();
            this.Hide();
        }
    }
 }

