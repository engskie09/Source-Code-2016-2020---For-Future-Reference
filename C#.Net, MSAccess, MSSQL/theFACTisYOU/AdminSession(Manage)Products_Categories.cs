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
    public partial class AdminSession_Manage_Products_Categories : Form
    {
        public AdminSession_Manage_Products_Categories()
        {
            InitializeComponent();
            hahahaNuisanceXD();
        }

        OleDbConnection HelloSayoXD = new OleDbConnection(LoginSession.x);
        

        public void hahahaNuisanceXD()
        {
            HelloSayoXD.Open();
            DataTable heyHello = new DataTable();
            OleDbCommand sorryForBeingAnnoying = HelloSayoXD.CreateCommand();
            OleDbDataAdapter ByeexD = new OleDbDataAdapter(sorryForBeingAnnoying);
            sorryForBeingAnnoying.CommandType = CommandType.Text;
            sorryForBeingAnnoying.CommandText = "select * from ProductCategories";
            sorryForBeingAnnoying.ExecuteNonQuery();
            ByeexD.Fill(heyHello);

            hohohoho.AutoGenerateColumns = false;
           

            hohohoho.Columns[0].DataPropertyName = "ID";
            hohohoho.Columns[1].DataPropertyName = "Product_Category";
            hohohoho.Columns[2].DataPropertyName = "Product_Category_Description";
            
            hohohoho.DataSource = heyHello;

            HelloSayoXD.Close();

        }

        int Hellooooo = 0;

        public void paengtuts()
        {
            int puyatersXD = 0;


            HelloSayoXD.Open();
            OleDbCommand wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha = HelloSayoXD.CreateCommand();
            wahahahaha.CommandType = CommandType.Text;
            wahahahaha.CommandText = "SELECT * from CountINC WHERE CountID= '1'";
            wahahahaha.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(wahahahaha);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                puyatersXD = Convert.ToInt32(xdr["ProductCategories"].ToString()) + 1;

            }

            Hellooooo = puyatersXD;

            wahahahaha.CommandText = "UPDATE CountINC SET ProductCategories= '" + puyatersXD + "' Where CountID= '1' ";

            wahahahaha.ExecuteNonQuery();

            HelloSayoXD.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminSession_Manage_Products_Load(object sender, EventArgs e)
        {
            AddingSession.Visible = false;
            UpdatingSession.Visible = false;// TODO: This line of code loads data into the 'factisYouFellaDataSet.ProductInventory' table. You can move, or remove it, as needed.
            hohohoho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoryNAME.Visible = false;
            Category_Description2.Visible = false;

            panel2.BackColor = Color.FromArgb(50, 0, 121, 147);
            panel3.BackColor = Color.FromArgb(50, 0, 121, 147);

            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;
        }

        

        
    

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Products XB = new AdminSession_Manage_Products();
            XB.Show();
            this.Close(); 
        }

        public void checkxD()
        {

            HelloSayoXD.Open();

            OleDbCommand kurikongxD = HelloSayoXD.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Product_Category from ProductCategories";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if (x.ToUpper() == Name_Input.Text.Trim().ToUpper())
                {
                    itsTRUE = false;
                    break;
                }
            }

            HelloSayoXD.Close();

        }


        bool itsTRUE = true;



        private void addXB_Click(object sender, EventArgs e)
        {
            if (Name_Input.Text.Trim() != "")
            {
                checkxD();
                paengtuts();
                HelloSayoXD.Close();
                HelloSayoXD.Open();
                OleDbCommand hixD = HelloSayoXD.CreateCommand();
                hixD.CommandType = CommandType.Text;

                if (itsTRUE)
                {
                    hixD.CommandText = "insert into ProductCategories values ('" + Hellooooo.ToString() + "','" + Name_Input.Text.Trim() + "','" + Category_Description1.Text.Trim() + "')";
                    hixD.ExecuteNonQuery();

                    MessageBox.Show("Category Added");
                }
                else
                {
                    MessageBox.Show("Category Name Already EXIST!");

                }

                HelloSayoXD.Close();

                hahahaNuisanceXD();

            }
            else
            {
                MessageBox.Show("Try Again");

            }

            AdminSession_Manage_Products_Categories xD = new AdminSession_Manage_Products_Categories();
            xD.Show();
            this.Hide();

            

           
        }

        public void checkxDD()
        {

            HelloSayoXD.Open();

            OleDbCommand kurikongxD = HelloSayoXD.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Product_Category from ProductCategories";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if (x.ToUpper() == categoryNAME.Text.Trim().ToUpper())
                {
                    itsTRUEE = false;
                    break;
                }
            }

            HelloSayoXD.Close();

        }

        int EKSBIhaha = 0;
        bool itsTRUEE = true;
        private void updateXB_Click(object sender, EventArgs e)
        {

            if (categoryNAME.Text.Trim() != "")
            {
                if (categoryNAME.Text.Trim() != label9.Text.Trim())
                {
                checkxDD();
                }

                HelloSayoXD.Close();
                HelloSayoXD.Open();
                OleDbCommand cmd = HelloSayoXD.CreateCommand();
                cmd = HelloSayoXD.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (itsTRUEE)
                {
                    cmd.CommandText = "update ProductCategories set Product_Category = @x1, Product_Category_Description = @x2 where ID = @x5 ";
                    cmd.Parameters.AddWithValue("@x1", categoryNAME.Text.Trim());
                    cmd.Parameters.AddWithValue("@x2", Category_Description2.Text.Trim());
                    cmd.Parameters.AddWithValue("@x5", EKSBIhaha);
                    cmd.ExecuteNonQuery();

                    {
                        MessageBox.Show("Update Successful");
                    }
                }
                else
                {

                    MessageBox.Show("Category Name Already EXIST!");

                }

                
                HelloSayoXD.Close();
                    
                hahahaNuisanceXD();
            }
            else
            {

                MessageBox.Show("Invalid");

            }

            categoryNAME.Text = "";
            Category_Description2.Text = "";
            label9.Text = "-----------";
        }

        public void SELECTA()
        {


            HelloSayoXD.Close();
            HelloSayoXD.Open();
            OleDbCommand cmd = HelloSayoXD.CreateCommand();
            cmd = HelloSayoXD.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from ProductCategories WHERE Product_Category= '" + label9.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {




                categoryNAME.Text = xdr["Product_Category"].ToString();
                Category_Description2.Text = xdr["Product_Category_Description"].ToString();
                EKSBIhaha = Convert.ToInt32(xdr["ID"].ToString());
            }
            HelloSayoXD.Close();


        }
        

        int eksbihahaxD = 0;
        string palit = "";
        string tanggal = "";

        private void hohohoho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                eksbihahaxD = e.RowIndex;

                DataGridViewRow XB = hohohoho.Rows[eksbihahaxD];

                palit = XB.Cells[1].Value.ToString();
                tanggal = XB.Cells[0].Value.ToString();

                label9.Text = palit.ToString();
                label10.Text = tanggal.ToString();

                SELECTA();
            }

            catch { }

          
        }

        private void Show_Update_Click(object sender, EventArgs e)
        {
            AddingSession.Visible = false;
            UpdatingSession.Visible = true;
        }

        private void Show_Add_Click(object sender, EventArgs e)
        {
            AddingSession.Visible = true;
            UpdatingSession.Visible = false;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddingSession.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatingSession.Visible = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            HelloSayoXD.Open();
            OleDbCommand asd = new OleDbCommand("DELETE from ProductCategories WHERE (Product_Category= '" + palit + "')", HelloSayoXD);
            //SqlCommand cmd = new SqlCommand("DELETE from mcucaloocan WHERE (Employee_ID= '" + temp + "')", con);
            asd.ExecuteNonQuery();
            HelloSayoXD.Close();
            hohohoho.DataSource = null;
            hahahaNuisanceXD();
            categoryNAME.Text = "";
            label10.Text = "----";
            label9.Text = "-----------";
            Category_Description2.Text = "";

            
        }

        private void Name_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
            if (Name_Input.Text.Trim() == String.Empty)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void categoryNAME_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                base.OnKeyPress(e);
            }
            if (Name_Input.Text.Trim() == String.Empty)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            categoryNAME.Visible = true;
            Category_Description2.Visible = true;
        }

      

       
    }
}
