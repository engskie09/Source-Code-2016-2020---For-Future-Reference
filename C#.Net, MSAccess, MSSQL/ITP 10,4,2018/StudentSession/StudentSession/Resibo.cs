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
using Microsoft.Reporting.WinForms;

namespace CanteenKiosk
{
    public partial class bilhin : Form
    {
        
        public string lb;
       
        public bilhin()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void setParameterBalyuXD()
        {


            Double pilaypilay = 0;

            if (Keyboard.getSpecialTreatment == "PWD")
                pilaypilay = .20;
            else if (Keyboard.getSpecialTreatment == "Senior")
                pilaypilay = .20;

            Double chichay = Convert.ToDouble(OrderingCart.getTotalForResibo) * pilaypilay;

            Double Chichay2nd = Convert.ToDouble(OrderingCart.getTotalForResibo) - chichay;

            string asd = "PHP " + Chichay2nd;

            MessageBox.Show(asd);
            ReportParameterCollection reportParam = new ReportParameterCollection();
            reportParam.Add(new ReportParameter("studName", Finalizee.getStudentFullname));
            reportParam.Add(new ReportParameter("studID", Finalizee.getStudentID));
            reportParam.Add(new ReportParameter("studTotal", asd));
            reportParam.Add(new ReportParameter("OrderNo", Keyboard.orderNo));
            reportParam.Add(new ReportParameter("MaySaket", Keyboard.getSpecialTreatment));
            reportParam.Add(new ReportParameter("discount", chichay.ToString()));
            this.reportVresibo.LocalReport.SetParameters(reportParam);

        }

        private void Resibo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'canteen_dbDataSet.recipecurrent' table. You can move, or remove it, as needed.
            setParameterBalyuXD();
            this.recipecurrentTableAdapter.Fill(this.canteen_dbDataSet.recipecurrent);
            this.reportVresibo.RefreshReport();
            

            //connetionString = "server=" + server + ";database=" + database + ";Username=" + username + ";Password=" + password + ";";
            //cnn = new MySqlConnection(connetionString);
            //int startposition =10;
           // int endposition = 10;
            for (int i = 0; i <= 9; i++)
            {
                Button b = addbutton(i);
           //     flowLayoutPanel1.Controls.Add(b);
                //endposition += 100;
                b.Click += new System.EventHandler(this.ButtonClick);

            }

          
            
        }
        void ButtonClick(object sender, EventArgs e)
        {
            Button currentbutton = (Button)sender;
            MessageBox.Show(currentbutton.Text);
        }
        
        Button addbutton(int i)
        {
            Button b = new Button ();
            b.Name = "Button" + i.ToString();
            b.Text = "Button" + i.ToString();
            b.ForeColor = Color.White;
            b.BackColor = Color.Gray;
            b.Font = new Font("Serif", 24, FontStyle.Bold);
            b.Width = 170;
            b.Height = 80;
            //b.Location = new Point(start, end);
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Margin = new Padding(5);

            return b;


        }
        private void update_Click(object sender, EventArgs e)
        {
           
        }

        public void panotskie()
        {
            //---------------------------------------------------------
            MySqlConnection cnn = new MySqlConnection(stringpotek.koneksyon);
            cnn.Close();
            cnn.Open();        
            MySqlCommand cmdx = cnn.CreateCommand();
            cmdx.CommandType = CommandType.Text;
          //  cmdx.CommandText = "Select quantity from product where name='" + malupet + "' ";
            cmdx.ExecuteNonQuery();
            DataTable dts = new DataTable();
            MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);
            xda.Fill(dts);

            foreach (DataRow xdr in dts.Rows)


            {
                //fnamee = xdr["FirstName"].ToString() + " ";



            }

            //---------------------------------------------------------
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnFinishnaXD_Click(object sender, EventArgs e)
        {
           
        }

        public void closeActiveFormsXD()
        {
            Form check = Application.OpenForms["Ordering"];

            MainForm XD = new MainForm();
            XD.Show();
            check.Close();
            this.Close();

        }

        private void reportVresibo_Load(object sender, EventArgs e)
        {

        }

        private void btnFinishnaXD_Click_1(object sender, EventArgs e)
        {
            closeActiveFormsXD();
        }
    }
}
