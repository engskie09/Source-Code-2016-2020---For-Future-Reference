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
    public partial class AdminSession_Manage_Products_add : Form
    {
        public AdminSession_Manage_Products_add()
        {
            InitializeComponent();

       

            
        }
            
        OleDbConnection HelloSayoXD = new OleDbConnection(LoginSession.x);

      

        int Hellooooo = 0;
        
        
        public void engskie()
        {
            HelloSayoXD.Close();

            HelloSayoXD.Open();

            DataTable xD = new DataTable();
            OleDbDataAdapter qwerty = new OleDbDataAdapter("select * from ProductInventory ", HelloSayoXD);

            qwerty.Fill(xD);

            foreach (DataRow eksBI in xD.Rows)
            {
                int hiiiii = eksBI.Field<int>("ID");
                
                Hellooooo = Math.Max(Hellooooo, hiiiii) + 1;
        }
            HelloSayoXD.Close();
        }

        public void paengtuts()
        {
            int puyatersXD = 0;

            HelloSayoXD.Close();
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

                puyatersXD = Convert.ToInt32(xdr["ProductInventory"].ToString()) + 1;

            }

            Hellooooo = puyatersXD;

            wahahahaha.CommandText = "UPDATE CountINC SET ProductInventory= '" + puyatersXD + "' Where CountID= '1' ";

            wahahahaha.ExecuteNonQuery();

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
            teleburn();
            panel2.BackColor = Color.FromArgb(50, 0, 121, 147);
            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;
        }

        public void teleburn()
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
                Category_Select.Items.Add(x);
            }

            HelloSayoXD.Close();

        }

        public void checkxD()
        {

            HelloSayoXD.Open();

            OleDbCommand kurikongxD = HelloSayoXD.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Product_Name from ProductInventory";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if(x.ToUpper() == Name_Input.Text.Trim().ToUpper())
                {
                    itsTRUE = false;
                    break;
                }
            }

            HelloSayoXD.Close();

        }


        bool itsTRUE = true;

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (Name_Input.Text.Trim() != "" && Category_Select.Text.Trim() != "" && Cost_Input.Text.Trim() != "")
            {
                checkxD();

                paengtuts();
                HelloSayoXD.Close();
                HelloSayoXD.Open();
                OleDbCommand hixD = HelloSayoXD.CreateCommand();
                hixD.CommandType = CommandType.Text;

                if (itsTRUE)
                {
                    hixD.CommandText = "INSERT INTO ProductInventory (ID,Product_ID,Product_Name,Product_Category,Product_Description,Product_Cost,Product_Picture,Quantity_On_Hand) VALUES (@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";
             
                    hixD.Parameters.AddWithValue("@a1",Hellooooo.ToString());
                    hixD.Parameters.AddWithValue("@a2",Hellooooo.ToString());
                    hixD.Parameters.AddWithValue("@a3",Name_Input.Text.Trim());
                    hixD.Parameters.AddWithValue("@a4",Category_Select.Text.Trim());
                    hixD.Parameters.AddWithValue("@a5",Description_Input.Text.Trim());
                    hixD.Parameters.AddWithValue("@a6", Cost_Input.Text.Trim());
                    hixD.Parameters.AddWithValue("@a7", petmalu);
                    hixD.Parameters.AddWithValue("@a8", QuantityProduct.Text.Trim());
                    hixD.ExecuteNonQuery();

                    
                        MessageBox.Show("Product Added");
                    
                }
                
                
    
                else
                {
                    MessageBox.Show("Product Name Already EXIST!");
                }

                HelloSayoXD.Close();

            }
                

            else
            {
                MessageBox.Show("Try Again");
            }
           
          
            AdminSession_Manage_Products_add xD = new AdminSession_Manage_Products_add();
            xD.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Products XB = new AdminSession_Manage_Products();
            XB.Show();
            this.Close();
        }
        string petmalu = LoginSession.blankpicture;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog XB = new OpenFileDialog();

            String LOLS = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            XB.Filter = LOLS;

            if (XB.ShowDialog() == DialogResult.OK)
            {
                petmalu = XB.FileName.ToString();

                piktyur.ImageLocation = petmalu;
                piktyur.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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

        private void Cost_Input_KeyPress(object sender, KeyPressEventArgs e)
        {
           /** if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            **/
            double value = 0;
            if (!double.TryParse(Cost_Input.Text + e.KeyChar.ToString(), out value) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ' ')
            {
                e.KeyChar = '\0';
            }
        }

        private void QuantityProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

     
    }
}
