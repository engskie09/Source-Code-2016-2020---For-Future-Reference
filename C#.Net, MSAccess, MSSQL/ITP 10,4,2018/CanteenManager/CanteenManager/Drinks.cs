using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManager
{
    public partial class Drinks : Form
    {
        public Drinks()
        {

            InitializeComponent();

            
            
            getDrinksInfoToList();
            getDrinksInfoToControl();    
        

        }

        private void Drinks_Load(object sender, EventArgs e)
        { 

        }
        
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataTable dt = new DataTable();        
         
        //get Drinks ID
        private String getdrink1_ID = "";
        private String getdrink2_ID = "";
        private String getdrink3_ID = "";
        private String getdrink4_ID = "";        
        //get Drinks Name
        private String getdrink1_Name = "";
        private String getdrink2_Name = "";
        private String getdrink3_Name = "";
        private String getdrink4_Name = "";
        
        //get Drinks Quantity
        private Int32 getdrink1_Quantity = 0;
        private Int32 getdrink2_Quantity = 0;
        private Int32 getdrink3_Quantity = 0;
        private Int32 getdrink4_Quantity = 0;

        //get Drinks Critical
        private Int32 getdrink1_Critical = 0;
        private Int32 getdrink2_Critical = 0;
        private Int32 getdrink3_Critical = 0;
        private Int32 getdrink4_Critical = 0;

        //get Drinks Price
        private Int32 getdrink1_Price = 0;
        private Int32 getdrink2_Price = 0;
        private Int32 getdrink3_Price = 0;
        private Int32 getdrink4_Price = 0;
            
        //get Drinks Photo MS
        /*private MemoryStream getdrink1_PhotoMS = new MemoryStream();
        private MemoryStream getdrink2_PhotoMS = new MemoryStream();
        private MemoryStream getdrink3_PhotoMS = new MemoryStream();
        private MemoryStream getdrink4_PhotoMS = new MemoryStream();*/

        //get Drinks Photo Byte
        private Byte[] getdrink1_PhotoByte = null;
        private Byte[] getdrink2_PhotoByte = null;
        private Byte[] getdrink3_PhotoByte = null;
        private Byte[] getdrink4_PhotoByte = null;




        //get Drinks Lists Value
        private List<String> getdrink_ID = new List<String>();
        private List<String> getdrink_Name = new List<String>();
        private List<Int32> getdrink_Quantity = new List<Int32>();
        private List<Int32> getdrink_Critical = new List<Int32>();
        private List<Int32> getdrink_Price = new List<Int32>();
        private List<MemoryStream> getdrink_Photo = new List<MemoryStream>();

        private void getDrinksInfoToList()
        {
           

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM drink_tbl";
            cmd.ExecuteNonQuery();

            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
       
            foreach (DataRow dr in dt.Rows)
            {
                getdrink_ID.Add(dr["drinkID"].ToString());
                getdrink_Name.Add(dr["DrinkName"].ToString());
                getdrink_Quantity.Add((Int32)dr["DrinkQuantity"]);
                getdrink_Critical.Add((Int32)dr["DrinkCriticalValue"]);
                getdrink_Price.Add((Int32)dr["DrinkPrice"]); 


                if (DBNull.Value != (dr["DrinkImage"]))
                {                    
                    
                    Byte[] xD = (Byte[])dr["DrinkImage"];

                    MemoryStream ms = new MemoryStream(xD);
                    getdrink_Photo.Add(ms);
                }

                else
                {                 
                    MemoryStream ms = new MemoryStream();
                    Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                    getdrink_Photo.Add(ms);
                }             
                
            }

            connection.Close();
        }

        private void getDrinksInfoToControl()
        {
            Int32 currentControlCount = 1;

            for (Int32 x = 0; x <= 3; x++)
            {
                Control[] getdrinkName = this.Controls.Find("txtDrinkName" + currentControlCount, true);
                getdrinkName[0].Text = getdrink_Name[x].ToString();

                Control[] getdrinkQuantity = this.Controls.Find("txtDrinkQuantity" + currentControlCount, true);
                getdrinkQuantity[0].Text = getdrink_Quantity[x].ToString();

                Control[] getdrinCritical = this.Controls.Find("txtDrinkCritical" + currentControlCount, true);
                getdrinCritical[0].Text = getdrink_Critical[x].ToString();

                Control[] getdrinkPrice = this.Controls.Find("txtDrinkPrice" + currentControlCount, true);
                getdrinkPrice[0].Text = getdrink_Price[x].ToString();

                /*Control[] getdrinkPhoto = this.Controls.Find("pctBoxPhoto" + currentControlCount, true);
                getdrinkPhoto[0].BackgroundImage = Image.FromStream(getdrink_Photo[x]);
                getdrinkPhoto[0].BackgroundImageLayout = ImageLayout.Stretch;*/

                currentControlCount++;
            }
           
                pctBoxPhoto1.Image = Image.FromStream(getdrink_Photo[0]);
                pctBoxPhoto2.Image = Image.FromStream(getdrink_Photo[1]);
                pctBoxPhoto3.Image = Image.FromStream(getdrink_Photo[2]);
                pctBoxPhoto4.Image = Image.FromStream(getdrink_Photo[3]);
            

           
            

        }

        /*
         private String getdrink1_ID = "";
        private String getdrink1_Name = "";
        private Int32 getdrink1_Quantity = 0;
        private Int32 getdrink1_Price = 0;
        private Byte[] getdrink1_Photo = n0ull;*/


        private void setVariableValueToInsert()
        {


        

            getdrink1_Name = txtDrinkName1.Text.Trim() ;
            getdrink2_Name = txtDrinkName2.Text.Trim();
            getdrink3_Name = txtDrinkName3.Text.Trim();
            getdrink4_Name = txtDrinkName4.Text.Trim();

            getdrink1_Quantity = Convert.ToInt32(txtDrinkQuantity1.Text.Trim());
            getdrink2_Quantity = Convert.ToInt32(txtDrinkQuantity2.Text.Trim());
            getdrink3_Quantity = Convert.ToInt32(txtDrinkQuantity3.Text.Trim());
            getdrink4_Quantity = Convert.ToInt32(txtDrinkQuantity4.Text.Trim());

            getdrink1_Critical = Convert.ToInt32(txtDrinkCritical1.Text.Trim());
            getdrink2_Critical = Convert.ToInt32(txtDrinkCritical2.Text.Trim());
            getdrink3_Critical = Convert.ToInt32(txtDrinkCritical3.Text.Trim());
            getdrink4_Critical = Convert.ToInt32(txtDrinkCritical4.Text.Trim());

            getdrink1_Price = Convert.ToInt32(txtDrinkPrice1.Text.Trim());
            getdrink2_Price = Convert.ToInt32(txtDrinkPrice2.Text.Trim());
            getdrink3_Price = Convert.ToInt32(txtDrinkPrice3.Text.Trim());
            getdrink4_Price = Convert.ToInt32(txtDrinkPrice4.Text.Trim());
        

            MemoryStream ms = new MemoryStream();

            /*pctBoxPhoto1.Image.Save(ms, pctBoxPhoto1.Image.RawFormat);
            getdrink1_PhotoByte = ms.ToArray();
            ms.Close();

            pctBoxPhoto2.Image.Save(ms, pctBoxPhoto2.Image.RawFormat);
            getdrink2_PhotoByte = ms.ToArray();
            ms.Close();

            pctBoxPhoto3.Image.Save(ms, pctBoxPhoto3.Image.RawFormat);
            getdrink3_PhotoByte = ms.ToArray();
            ms.Close();

            pctBoxPhoto4.Image.Save(ms, pctBoxPhoto4.Image.RawFormat);
            getdrink4_PhotoByte = ms.ToArray();
            ms.Close();*/

            /*if (txtDrinkQuantity1.Text != "")
            getdrink1_Quantity = Convert.ToInt32(txtDrinkQuantity1.Text);

            if (txtDrinkQuantity2.Text != "")
            getdrink2_Quantity = Convert.ToInt32(txtDrinkQuantity2.Text);

            if (txtDrinkQuantity3.Text != "")
            getdrink3_Quantity = Convert.ToInt32(txtDrinkQuantity3.Text);

            if (txtDrinkQuantity4.Text != "")
            getdrink4_Quantity = Convert.ToInt32(txtDrinkQuantity4.Text);

            if (txtDrinkPrice1.Text != "")
            getdrink1_Price = Convert.ToInt32(txtDrinkPrice1.Text);

            if (txtDrinkPrice2.Text != "")
            getdrink2_Price = Convert.ToInt32(txtDrinkPrice2.Text);

            if (txtDrinkPrice3.Text != "")
            getdrink3_Price = Convert.ToInt32(txtDrinkPrice3.Text);

            if (txtDrinkPrice4.Text != "")
            getdrink4_Price = Convert.ToInt32(txtDrinkPrice4.Text);*/
            


           

                
            
        }        

        private void btnGetCurrentButtonDrinks(object sender, EventArgs e)
        {
            Control ctrlCurrentButton = (Control)sender;

            if (ctrlCurrentButton.Name == "btnDrink1")
            {                
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pctBoxPhoto1.Image = Image.FromFile(opf.FileName);

                    MemoryStream ms = new MemoryStream();
                    pctBoxPhoto1.Image.Save(ms, pctBoxPhoto1.Image.RawFormat);
                    getdrink1_PhotoByte = ms.ToArray();
                }
            }

            else if (ctrlCurrentButton.Name == "btnDrink2")
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pctBoxPhoto2.Image = Image.FromFile(opf.FileName);

                    MemoryStream ms = new MemoryStream();
                    pctBoxPhoto2.Image.Save(ms, pctBoxPhoto2.Image.RawFormat);
                    getdrink2_PhotoByte = ms.ToArray();
                }

            }

            else if (ctrlCurrentButton.Name == "btnDrink3")
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pctBoxPhoto3.Image = Image.FromFile(opf.FileName);

                    MemoryStream ms = new MemoryStream();
                    pctBoxPhoto3.Image.Save(ms, pctBoxPhoto3.Image.RawFormat);
                    getdrink3_PhotoByte = ms.ToArray();
                }
            }

            else if (ctrlCurrentButton.Name == "btnDrink4")
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pctBoxPhoto4.Image = Image.FromFile(opf.FileName);

                    MemoryStream ms = new MemoryStream();
                    pctBoxPhoto4.Image.Save(ms, pctBoxPhoto4.Image.RawFormat);
                    getdrink4_PhotoByte = ms.ToArray();
                }
            }



            setVariableValueToInsert();


        }

        private void btnRemoveDrinkPhoto_Click(object sender, EventArgs e)
        {
            Control ctrlCurrentButton = (Control)sender;            

            if (ctrlCurrentButton.Name == "btnRemove1")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto1.Image = Image.FromStream(ms);
                getdrink1_PhotoByte = ms.ToArray();
            }

            if (ctrlCurrentButton.Name == "btnRemove2")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto2.Image = Image.FromStream(ms);
                getdrink2_PhotoByte = ms.ToArray();
            }

            if (ctrlCurrentButton.Name == "btnRemove3")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto3.Image = Image.FromStream(ms);
                getdrink3_PhotoByte = ms.ToArray();
            }

            if (ctrlCurrentButton.Name == "btnRemove4")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto4.Image = Image.FromStream(ms);
                getdrink4_PhotoByte = ms.ToArray();
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Main a = new Main();
            a.Show();
            this.Hide();

        }    
    
        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            Control ctrlCurrentButton = (Control)sender;

            if (ctrlCurrentButton.Name == "btnDeleteDrink1")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto1.Image = Image.FromStream(ms);
                getdrink1_PhotoByte = ms.ToArray();

                txtDrinkName1.Text = "None";
                txtDrinkQuantity1.Text = "0";
                txtDrinkCritical1.Text = "0";
                txtDrinkPrice1.Text = "0";
                
            }

            if (ctrlCurrentButton.Name == "btnDeleteDrink2")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto2.Image = Image.FromStream(ms);
                getdrink2_PhotoByte = ms.ToArray();

                txtDrinkName2.Text = "None";
                txtDrinkQuantity2.Text = "0";
                txtDrinkCritical2.Text = "0";
                txtDrinkPrice2.Text = "0";

            }

            if (ctrlCurrentButton.Name == "btnDeleteDrink3")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto3.Image = Image.FromStream(ms);
                getdrink3_PhotoByte = ms.ToArray();

                txtDrinkName3.Text = "None";
                txtDrinkQuantity3.Text = "0";
                txtDrinkCritical3.Text = "0";
                txtDrinkPrice3.Text = "0";

            }

            if (ctrlCurrentButton.Name == "btnDeleteDrink4")
            {
                MemoryStream ms = new MemoryStream();
                Properties.Resources.nosymbol.Save(ms, Properties.Resources.nosymbol.RawFormat);
                pctBoxPhoto4.Image = Image.FromStream(ms);
                getdrink4_PhotoByte = ms.ToArray();

                txtDrinkName4.Text = "None";
                txtDrinkQuantity4.Text = "0";
                txtDrinkCritical4.Text = "0";
                txtDrinkPrice4.Text = "0";

            }
        }

        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {

            Control ctrlCurrentButton = (Control)sender;

            setVariableValueToInsert();

            if (ctrlCurrentButton.Name == "btnUpdateDrink1")
            {
                updateDrinks("Drink-01", getdrink1_Name, getdrink1_Quantity, getdrink1_Critical, getdrink1_Price, getdrink1_PhotoByte);
            }

            if (ctrlCurrentButton.Name == "btnUpdateDrink2")
            {
                updateDrinks("Drink-02", getdrink2_Name, getdrink2_Quantity, getdrink2_Critical, getdrink2_Price, getdrink2_PhotoByte);
            }

            if (ctrlCurrentButton.Name == "btnUpdateDrink3")
            {
                updateDrinks("Drink-03", getdrink3_Name, getdrink3_Quantity, getdrink3_Critical, getdrink3_Price, getdrink3_PhotoByte);
            }

            if (ctrlCurrentButton.Name == "btnUpdateDrink4")
            {
                updateDrinks("Drink-04", getdrink4_Name, getdrink4_Quantity, getdrink4_Critical, getdrink4_Price, getdrink4_PhotoByte);
            }
        }

        //update Drinks
        private void updateDrinks(String getDrinkID, String getDrinkName, Int32 getDrinkQuantity, Int32 getDrinkCriticalValue, Int32 getDrinkPrice, Byte[] getDrinkPhoto)
        {
            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE drink_tbl SET DrinkName=@a1, DrinkQuantity=@a2, DrinkCriticalValue=@a3, DrinkPrice=@a4, DrinkImage=@a5 WHERE drinkID=@a6";
            
            
            cmd.Parameters.AddWithValue("@a1", getDrinkName);
            cmd.Parameters.AddWithValue("@a2", getDrinkQuantity);
            cmd.Parameters.AddWithValue("@a3", getDrinkCriticalValue);
            cmd.Parameters.AddWithValue("@a4", getDrinkPrice);
            cmd.Parameters.AddWithValue("@a5", getDrinkPhoto);
            cmd.Parameters.AddWithValue("@a6", getDrinkID);

            cmd.ExecuteNonQuery();

            
        }

        
    }
}
