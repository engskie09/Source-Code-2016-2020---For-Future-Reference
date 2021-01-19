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
    public partial class AdminSession_Manage_Products_update : Form
    {
        public AdminSession_Manage_Products_update()
        {
            InitializeComponent();

            pictureXB.SizeMode = PictureBoxSizeMode.StretchImage;

            
        }
            
        OleDbConnection DubidubiDapdap = new OleDbConnection(LoginSession.x);


        string selectaWalangLasa = "";

        String NameInput = "";
        String CategorySelect = "";
        String DescriptionInput = "";
        String CostInput = "";
        int EKSBIhaha = 0;
        string haysXB = "";
        string petmalu = "";
        string quantity = "";
        public void SELECTA()
        {

            DubidubiDapdap.Close();

            DubidubiDapdap.Open();
            OleDbCommand cmd = DubidubiDapdap.CreateCommand();
            cmd = DubidubiDapdap.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from ProductInventory WHERE Product_Name= '" + selectaWalangLasa + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                NameInput = xdr["Product_Name"].ToString();
                CategorySelect = xdr["Product_Category"].ToString();
                DescriptionInput = xdr["Product_Description"].ToString();
                CostInput = xdr["Product_Cost"].ToString();
                EKSBIhaha = Convert.ToInt32(xdr["ID"].ToString());
                haysXB = xdr["Product_Picture"].ToString();
                quantity = xdr["Quantity_On_Hand"].ToString();
            }
            DubidubiDapdap.Close();

         
        }



      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminSession_Manage_Products_Load(object sender, EventArgs e)
        {
            teleburn();
            teleburns();
            Name_Input.Visible = false;
            Category_Select.Visible = false;
            Description_Input.Visible = false;
            button2.Visible = false;
            Cost_Input.Visible = false;
            QuantityProduct.Visible = false;
            panel2.BackColor = Color.FromArgb(50, 0, 121, 147);
            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;
        }

        public void teleburn()
        {

            DubidubiDapdap.Open();

            OleDbCommand kurikongxD = DubidubiDapdap.CreateCommand();
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

            DubidubiDapdap.Close();

        }

        public void stipaalam()
        {
            MessageBox.Show("asd");

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Product_Name from ProductInventory";

            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                ComboWombo.Items.Add(dr[0].ToString());            
            }


            DubidubiDapdap.Close();
        }


        public void teleburns()
        {

            DubidubiDapdap.Open();

            OleDbCommand kurikongxD = DubidubiDapdap.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Product_Name from ProductInventory";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();
                ComboWombo.Items.Add(x);
            }

            DubidubiDapdap.Close();

        }
        /**
             
         * 
         * 
        */

        public void checkxD()
        {

            DubidubiDapdap.Open();

            OleDbCommand kurikongxD = DubidubiDapdap.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Product_Name from ProductInventory";
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

            DubidubiDapdap.Close();

        }

        bool itsTRUE = true;
        private void button3_Click(object sender, EventArgs e)
        {

            
            if (Name_Input.Text.Trim() != "" && Category_Select.Text.Trim() != "" && Cost_Input.Text.Trim() != "")
            {


                if (Name_Input.Text.Trim() != ComboWombo.Text.Trim())
                {
                    checkxD();
                }

                DubidubiDapdap.Close();
                DubidubiDapdap.Open();
                OleDbCommand cmd = DubidubiDapdap.CreateCommand();
                cmd = DubidubiDapdap.CreateCommand();
                cmd.CommandType = CommandType.Text;

           
             if (itsTRUE == true)
             {
                 cmd.CommandText = "update ProductInventory set Product_Name = @x1, Product_Category = @x2, Product_Description = @x3, Product_Cost = @x4, Product_Picture = @x5, Quantity_On_Hand = @x6 where Product_ID = @x7 ";
                 cmd.Parameters.AddWithValue("@x1", Name_Input.Text.Trim());
                 cmd.Parameters.AddWithValue("@x2", Category_Select.Text.Trim());
                 cmd.Parameters.AddWithValue("@x3", Description_Input.Text.Trim());
                 cmd.Parameters.AddWithValue("@x4", Cost_Input.Text.Trim());

                 cmd.Parameters.AddWithValue("@x5", petmalu);
                 cmd.Parameters.AddWithValue("@x6", QuantityProduct.Text.Trim());
                 cmd.Parameters.AddWithValue("@x7", EKSBIhaha);
                 
                 cmd.ExecuteNonQuery();

                 
                     MessageBox.Show("Update Successful");
                 
             }

                else
                {
                    MessageBox.Show("The Product Name is Already Exist or Not Exist");
                }


               
                DubidubiDapdap.Close();

                AdminSession_Manage_Products_update xD = new AdminSession_Manage_Products_update();
                xD.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Try Again");
                
            }
            DubidubiDapdap.Close();
        }

      

      
      

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            selectaWalangLasa = ComboWombo.Text.Trim();
           
            SELECTA();

            Name_Input.Text = NameInput;
            Category_Select.Text = CategorySelect;
            Description_Input.Text = DescriptionInput;
            Cost_Input.Text = CostInput;
            pictureXB.ImageLocation = haysXB;
            petmalu = haysXB;
            /**
            try
            {
                pictureXB.ImageLocation = haysXB;

            }

            catch
            {
                pictureXB.ImageLocation = null; 
            }
           **/
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Products XB = new AdminSession_Manage_Products();
            XB.Show();
            this.Close();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog XB = new OpenFileDialog();

            String LOLS = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            XB.Filter = LOLS;

            if (XB.ShowDialog() == DialogResult.OK)
            {
                petmalu = XB.FileName.ToString();

                pictureXB.ImageLocation = petmalu;
                pictureXB.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void pictureXB_Click(object sender, EventArgs e)
        {

        }

        private void Category_Select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Description_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Name_Input_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ComboWombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectaWalangLasa = ComboWombo.Text.Trim();

            SELECTA();

            Name_Input.Text = NameInput;
            Category_Select.Text = CategorySelect;
            Description_Input.Text = DescriptionInput;
            Cost_Input.Text = CostInput;
            pictureXB.ImageLocation = haysXB;
            petmalu = haysXB;
            QuantityProduct.Text = quantity;

            Name_Input.Visible = true;
            Category_Select.Visible = true;
            Description_Input.Visible = true;
            button2.Visible = true;
            Cost_Input.Visible = true;
            QuantityProduct.Visible = true;


        }

        private void Cost_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Name_Input_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void Cost_Input_KeyPress_1(object sender, KeyPressEventArgs e)
        {
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

      
    }
}


//Rafael Masallo xD