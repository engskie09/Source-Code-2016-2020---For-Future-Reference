using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //MythicalCafe_BackEnd_Dashboard xD = new MythicalCafe_BackEnd_Dashboard();

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (xD.IsDisposed)
                xD = new MythicalCafe_BackEnd_Dashboard();
            xD.Show();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            /*panel1.AutoScroll = false;
            panel1.VerticalScroll.Enabled = false;
            panel1.VerticalScroll.Visible = false;
            panel1.VerticalScroll.Maximum = 0;
            panel1.AutoScroll = true;

            vScrollBar1.Maximum = panel1.Height;
            vsb_NavigationBar.MaximumScrollRange = 50;

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
            printer.printDocument.DefaultPageSettings.Landscape = true;*/
            //printer.PrintDataGridView(HohohoXD);


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.AutoScrollPosition = new Point(panel1.AutoScrollPosition.X, e.OldValue);
        }

        private void verticalScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.AutoScrollPosition = new Point(panel1.AutoScrollPosition.X, e.OldValue);
        }
    }
}
