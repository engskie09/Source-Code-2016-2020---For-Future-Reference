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
    public partial class AdminSession_Manage_Products : Form
    {
        public AdminSession_Manage_Products()
        {

            InitializeComponent();
            
            
             
        }

        DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
        OleDbConnection HelloSayoXD = new OleDbConnection(LoginSession.x);
        DataTable heyHello = new DataTable();
       
        public void IkotModeXB()
        {
        

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
                string XB = "";
                
          
              
                    for(int lels = 0; lels <= HuehueXD.Rows.Count - 1; lels++)
                    {
                        
                        XB = puyatersXD[lels];
                        
                        
                           
                            img = Image.FromFile(XB);
                            row = img;
                        



                        HuehueXD.Rows[lels].Cells[6].Value = row;
                        HuehueXD.Rows[lels].Height = 50;
                        row = null;

                    }
         

                
        }

        List<int> haynako = new List<int>();

        public void taena()
        {

            haynako.Clear();
            foreach( DataGridViewRow item in HuehueXD.Rows )
            {
                haynako.Add(Convert.ToInt32(item.Cells[0].Value));
                
            }

          
        }

        //pic XB!
        List<string>  puyatersXD = new List<string>();
        
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


        public void hahahaNuisanceXD()
        {
            
           
           
            HelloSayoXD.Open();
           
            OleDbCommand sorryForBeingAnnoying = HelloSayoXD.CreateCommand();
            OleDbDataAdapter ByeexD = new OleDbDataAdapter(sorryForBeingAnnoying);
            sorryForBeingAnnoying.CommandType = CommandType.Text;
            sorryForBeingAnnoying.CommandText = "select * from ProductInventory";
            sorryForBeingAnnoying.ExecuteNonQuery();

            ByeexD.Fill(heyHello);

           HuehueXD.AutoGenerateColumns = false;


            HuehueXD.Columns[0].DataPropertyName = "Product_ID";
            HuehueXD.Columns[1].DataPropertyName = "Product_Name";
            HuehueXD.Columns[2].DataPropertyName = "Product_Category";
            HuehueXD.Columns[3].DataPropertyName = "Product_Description";
            HuehueXD.Columns[4].DataPropertyName = "Product_Cost";
            HuehueXD.Columns[5].DataPropertyName = "Quantity_On_Hand";
            
            
            HuehueXD.DataSource = heyHello;



            HelloSayoXD.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminSession_Manage_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Print' table. You can move, or remove it, as needed.
           
            hahahaNuisanceXD();
             
            IkotModeXB();
            searchXD.Enabled = false;
            panel1.BackColor = Color.FromArgb(50, 0, 121, 147);
            panel2.BackColor = Color.FromArgb(50, 0, 121, 147);
            panel3.BackColor = Color.FromArgb(50, 0, 121, 147);
            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;

            timexD.Start();

        }
        string tanggal = "";
        private void button5_Click(object sender, EventArgs e)
        {

            if (tanggal != "")
            {
                HelloSayoXD.Open();
                OleDbCommand asd = new OleDbCommand("DELETE from ProductInventory WHERE (Product_Name= '" + tanggal + "')", HelloSayoXD);


                asd.ExecuteNonQuery();
                HelloSayoXD.Close();

                heyHello.Clear();
                hahahaNuisanceXD();
                IkotModeXB();
               
                
                MessageBox.Show("Delete Successful");
            }
            tanggal = "";
            label3.Text = "-----------";

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Products_add XB = new AdminSession_Manage_Products_add();
            XB.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Products_update XB = new AdminSession_Manage_Products_update();
            XB.Show();
            this.Hide();
        }
    
        int eksbihahaxD = 0;
        
        
        private void HuehueXD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                eksbihahaxD = e.RowIndex;

                DataGridViewRow XB = HuehueXD.Rows[eksbihahaxD];

                tanggal = XB.Cells[1].Value.ToString();

                label3.Text = tanggal.ToString();
               
            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Products_Categories XB = new AdminSession_Manage_Products_Categories();
            XB.Show();
            this.Hide();
          
        }

        

        

       

        private void Admin_Name_TextChanged(object sender, EventArgs e)
        {
            

            if (SearchBy.Text == "Name")
            {

                DataView DV = new DataView(heyHello);
                DV.RowFilter = string.Format("Product_Name LIKE '%{0}%'", searchXD.Text);
                HuehueXD.DataSource = DV;

                IkotModeXB();
            }

            else if (SearchBy.Text == "Category")
            {

                DataView DV = new DataView(heyHello);
                DV.RowFilter = string.Format("Product_Category LIKE '%{0}%'", searchXD.Text);
                HuehueXD.DataSource = DV;

                IkotModeXB();
            }

            else if (SearchBy.Text == "Description")
            {

                DataView DV = new DataView(heyHello);
                DV.RowFilter = string.Format("Product_Description LIKE '%{0}%'", searchXD.Text);
                HuehueXD.DataSource = DV;

                IkotModeXB();
            }

            else if (SearchBy.Text == "Cost")
            {

                DataView DV = new DataView(heyHello);
                DV.RowFilter = string.Format("Product_Cost LIKE '%{0}%'", searchXD.Text);
                HuehueXD.DataSource = DV;

                IkotModeXB();
            }

            else if (SearchBy.Text == "Quantity")   
            {

                DataView DV = new DataView(heyHello);
                DV.RowFilter = string.Format("Quantity_On_Hand LIKE '%{0}%'", searchXD.Text);
                HuehueXD.DataSource = DV;

                IkotModeXB();
            }

            else if (SearchBy.Text == "ID")
            {

                DataView DV = new DataView(heyHello);
                DV.RowFilter = string.Format("Product_ID LIKE '%{0}%'", searchXD.Text);
                HuehueXD.DataSource = DV;

                IkotModeXB();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession xD = new AdminSession();
            xD.Show();
            this.Hide();
        }

        private void SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchXD.Enabled = true;
        }

        private void timexD_Tick(object sender, EventArgs e)
        {
            string taym = DateTime.Now.ToLongTimeString();
            string deyt = DateTime.Now.ToShortDateString();
            string deytaym = taym + " " + deyt;
            orasanXD.Text = deytaym;
        }

  
       
       

       
    }
}
