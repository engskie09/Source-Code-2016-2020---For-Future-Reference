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

namespace Pagawa_SarisariStoreOrderingSystem_
{
    public partial class BentaXD : Form
    {
        public BentaXD()
        {
            InitializeComponent();
        }


        OleDbConnection connectionXD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user01\Desktop\asd\Pagawa(SarisariStoreOrderingSystem)\Pagawa(SarisariStoreOrderingSystem)database.accdb");


        public void ProductsShow()
        {



            connectionXD.Close();
            connectionXD.Open();
            OleDbCommand command = connectionXD.CreateCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable table = new DataTable();
            command.CommandText = "SELECT * FROM ProductsInfo";
            command.ExecuteNonQuery();
            adapter.Fill(table);

            SalesDatagrid.AutoGenerateColumns = false;

            SalesDatagrid.Columns[0].DataPropertyName = "ID";
            SalesDatagrid.Columns[1].DataPropertyName = "Product_Name";
            SalesDatagrid.Columns[2].DataPropertyName = "Product_Cost";
            SalesDatagrid.Columns[3].DataPropertyName = "Product_Sold";


            SalesDatagrid.DataSource = table;

            connectionXD.Close();


        }

        public void benta()
        {
            int z = 0;
            for (int x = 0; x <= SalesDatagrid.Rows.Count - 1; x++)
            {
                DataGridViewRow XB = SalesDatagrid.Rows[x];
                int a= Convert.ToInt32(XB.Cells[2].Value.ToString());
                int b = Convert.ToInt32(XB.Cells[3].Value.ToString());
                int c = a * b;
                SalesDatagrid.Rows[x].Cells[4].Value = c;
                z = z + c;
            }
            label4.Text = z.ToString();
        }

        private void BentaXD_Load(object sender, EventArgs e)
        {
            SalesDatagrid.ColumnCount = 5;
            ProductsShow();
            benta();
            
            
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            ProductsXB poopskie = new ProductsXB();
            poopskie.Show();
            this.Hide();
        }
    }
}
