using System;
using System.Collections.Generic;
using System.ComponentModel;
using DGVPrinterHelper;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace theFACTisYOU
{
    public partial class Admin_TransactionHistory_ : Form
    {
        public Admin_TransactionHistory_()
        {
            InitializeComponent();
        }
        OleDbConnection HelloSayoXD  = new OleDbConnection(LoginSession.x);

        public void hahahaNuisanceXD()
        {



            HelloSayoXD.Open();

            OleDbCommand sorryForBeingAnnoying = HelloSayoXD.CreateCommand();
            OleDbDataAdapter ByeexD = new OleDbDataAdapter(sorryForBeingAnnoying);
            DataTable xD = new DataTable();
            sorryForBeingAnnoying.CommandType = CommandType.Text;
            sorryForBeingAnnoying.CommandText = "select * from PointOfSales";
            sorryForBeingAnnoying.ExecuteNonQuery();

            ByeexD.Fill(xD);

            HohohoXD.AutoGenerateColumns = false;


            HohohoXD.Columns[0].DataPropertyName = "OrderID";
            HohohoXD.Columns[1].DataPropertyName = "Product_ID";
            HohohoXD.Columns[2].DataPropertyName = "Products_Sold";
            HohohoXD.Columns[3].DataPropertyName = "Products_Quantity";
            HohohoXD.Columns[4].DataPropertyName = "Products_Price";
            HohohoXD.Columns[5].DataPropertyName = "Products_Total_Quantity";
            HohohoXD.Columns[6].DataPropertyName = "Products_Total_Price";
            HohohoXD.Columns[7].DataPropertyName = "cash";
            HohohoXD.Columns[8].DataPropertyName = "Date_Order";
            



            HohohoXD.DataSource = xD;



            HelloSayoXD.Close();

        }

        private void AdminTransactionHistory_Load(object sender, EventArgs e)
        {
            hahahaNuisanceXD();
            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession xD = new AdminSession();
            xD.Show();
            this.Hide();
        }

        //Bitmap bmp;

       
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
            printer.Footer = "JCD Food Enterprise";
            printer.FooterSpacing = 15;      
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(HohohoXD);

            
            //MessageBox.Show(HohohoXD.RowCount.ToString());
           /* int PLDCBULOKPOTEK = 0;
            for (int x = 0; x <= HohohoXD.Rows.Count - 1; x++)
            {
                PLDCBULOKPOTEK += 10;
            }*/
        

     /**
        int rowcount = Convert.ToInt32(HohohoXD.RowCount);
      
              HohohoXD.Height = (rowcount * 10)+100 ;
              bmp = new Bitmap(1000, HohohoXD.Height);
            HohohoXD.DrawToBitmap(bmp, new Rectangle(0, 0, 1000, HohohoXD.Height));

            HohohoXD.Height = 22 * HohohoXD.Height;

         

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
         
            */
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // MessageBox.Show(bmp.Size.ToString());
          //  e.Graphics.DrawImage(bmp, 0, 0);
            // int rowtemplate = Convert.ToInt32(HohohoXD.RowTemplate);
          /*  for (int x = 0; x <= HohohoXD.Rows.Count - 1; x++)
            {
                DataGridViewRow xD = HohohoXD.Rows[x];
                int xcoor = 80;
                int ycoor = 150;
                string input = xD.Cells[0].Value.ToString();
                e.Graphics.DrawString(input, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(xcoor, ycoor));
                xcoor = xcoor + 50;
                ycoor = ycoor + 50;
            }*/

         /*   Bitmap bm = new Bitmap(this.HohohoXD.Width, this.HohohoXD.Height);
            HohohoXD.DrawToBitmap(bm, new Rectangle(0,0, this.HohohoXD.Width, this.HohohoXD.Height));
            e.Graphics.DrawImage(bm,-200,-200);*/
        }

        public void ByeSTIxDDDDDDDDDD()
        {
            try
            {
                DataTable dt = new DataTable();

                HelloSayoXD.Close();
                HelloSayoXD.Open();
                invisibleDatexD.Value = DateTime.Parse(halanahulog.Text).AddDays(-1);
                
                OleDbCommand cmd = HelloSayoXD.CreateCommand();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from PointOfSales where Date_Order between @a1 and @a2 ";
                // datefrom.Value = DateTime.Parse(datefrom.Text).AddDays(-1);
                cmd.Parameters.AddWithValue("@a1", invisibleDatexD.Value.ToString());
                cmd.Parameters.AddWithValue("@a2", loglogloglog.Value.ToString());
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                //dateTimePickerDOB.Text = DateTime.Parse(dateTimePickerAdmission.Text).AddDays(-1).ToString();
                HohohoXD.AutoGenerateColumns = false;

                HohohoXD.Columns[0].DataPropertyName = "OrderID";
                HohohoXD.Columns[1].DataPropertyName = "Product_ID";
                HohohoXD.Columns[2].DataPropertyName = "Products_Sold";
                HohohoXD.Columns[3].DataPropertyName = "Products_Quantity";
                HohohoXD.Columns[4].DataPropertyName = "Products_Price";
                HohohoXD.Columns[5].DataPropertyName = "Products_Total_Quantity";
                HohohoXD.Columns[6].DataPropertyName = "Products_Total_Price";
                HohohoXD.Columns[7].DataPropertyName = "cash";
                HohohoXD.Columns[8].DataPropertyName = "Date_Order";
                HohohoXD.DataSource = dt;



                HelloSayoXD.Close();
            }
            catch
            {
            }



        }

        private void halanahulog_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ByeSTIxDDDDDDDDDD();
            }
            catch
            {
            }
        }

        private void loglogloglog_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ByeSTIxDDDDDDDDDD();
            }
            catch
            {

            }
        }
    }
}
