using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace theFACTisYOU
{
    public partial class testinganXB : Form
    {
        public testinganXB()
        {
            InitializeComponent();
        }
        OleDbConnection HelloSayoXD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\server\Documents\Visual Studio 2012\Projects\theFACTisYOU\theFACTisYOU\FactisYouFella.accdb");
        private void testinganXB_Load(object sender, EventArgs e)
        {
            /**
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Photo";


            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            HuehueXD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            HuehueXD.Columns.Add(imgCol);
            Image img = Image.FromFile(@"C:\Users\server\Desktop\22489779_2091509004492770_4555707243125836664_n.jpg");           
            Object row = new Object();
            row = img;

            HuehueXD.Rows[0].Cells[4].Value = row;
            HuehueXD.Rows[0].Height = 50;
        
            */
            /*
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            try
            {
                HuehueXD.Columns.Remove(imgCol);

            }
            catch { }

            pakGanern();


            imgCol.HeaderText = "Product Picture";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            HuehueXD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            HuehueXD.Columns.Add(imgCol);
            Image img;
            Object row = new Object();
            

            int z = 0;
            for (int lels = 0; lels <= HuehueXD.ColumnCount - 1; lels++)
            {

                String XB = puyatersXD[z];
                
                if (XB == "")
                {
                    row = null;
                }

                else if (XB != "")
                {
                    img = Image.FromFile(@"eca250e5dc11354d25bfe49cb111429e.");
                    row = img;
                }

               
                HuehueXD.Rows[lels].Cells[5].Value = row;
                HuehueXD.Rows[lels].Height = 50;
                row = null;

            }
         */
        }
        List<int> haynako = new List<int>();

        public void taena()
        {

            haynako.Clear();
            foreach (DataGridViewRow item in HuehueXD.Rows)
            {
                haynako.Add(Convert.ToInt32(item.Cells[0].Value));

            }


        }

        List<string> puyatersXD = new List<string>();

        public void pakGanern()
        {

            taena();

            puyatersXD.Clear();

            HelloSayoXD.Open();


            OleDbCommand wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha.CommandType = CommandType.Text;
            DataTable xdt = new DataTable();

            foreach (int value in haynako)
            {


                wahahahaha.CommandText = "SELECT * from ProductInventory WHERE ID= " + value;
                wahahahaha.ExecuteNonQuery();
                OleDbDataAdapter xda = new OleDbDataAdapter(wahahahaha);
                xda.Fill(xdt);

                foreach (DataRow xdr in xdt.Rows)
                {



                    puyatersXD.Add(xdr["Product_Picture"].ToString());

                }
                xdt.Clear();

            }


            HelloSayoXD.Close();
        }

        int x = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "tae")
            {

            }

            if (x == 3)
            {
                Application.Exit(); 
            }
            x++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string notepad = @"C:\Users\user01\Desktop\bulbul.txt";
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(notepad))
            {

                while (sr.Peek() >= 0)
                {

                    sb.Append(sr.ReadLine());


                }

            }

            string s = sb.ToString();

          //  MessageBox.Show(s);
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            List<String> checkOrderID = new List<string>();
            bool bool2x = true;
            checkOrderID.Add("2018-99999"); //get value from databeys
            Random random = new Random();

            int number = random.Next(10000, 99999);
            string order = DateTime.Today.ToLongDateString();
            string[] ordeer = order.Split(',');
            int year;
            int.TryParse(ordeer[2], out year);
             string orderIDFinal = year.ToString()+ "--"+ number.ToString();


            do{
            int x = 0;
           
            if (orderIDFinal == checkOrderID[x])
            {
              //  MessageBox.Show("same" + orderIDFinal);

            }
            if (orderIDFinal != checkOrderID[x])
            {
              //  MessageBox.Show("no same" + orderIDFinal);
                break;
                
            }
            x++;
            }while(bool2x);

            

            
        }
    }
}
