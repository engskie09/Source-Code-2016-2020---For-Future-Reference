using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.OleDb;

namespace theFACTisYOU
{
    public partial class AdminStaffSession_Receipt_ : Form
    {
        public AdminStaffSession_Receipt_()
        {
            InitializeComponent();
        }

       public static DataTable dt = new DataTable();
      
        public static string finalprice = "";
        public static string finalcash = "";
        public static string finalchange = "";

        public static List<string> finalidlist = new List<string>();
        public static List<string> finalnamelist = new List<string>();
        public static List<string> finalpricelist = new List<string>();
        public static List<string> finalquantitylist = new List<string>();
        public static List<string> finaltotalpricelist = new List<string>();
        public static int ikot = 0;

        OleDbConnection HelloSayoXD = new OleDbConnection(LoginSession.x);

        private void AdminStaffSession_Receipt__Load(object sender, EventArgs e)
        {
        
            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;
             
            timexD.Start();

           

            finalpriceLBL.Text = finalprice;
            finalcashLBL.Text = finalcash;
            finalchangeLBL.Text = finalchange;
            resiboxD();

            /*
            dt.Columns.Add("Product ID", typeof(string));
            dt.Columns.Add("Product NAME", typeof(string));
            dt.Columns.Add("Product PRICE", typeof(string));
            dt.Columns.Add("Product QUANTITY", typeof(string));
            dt.Columns.Add("Product TOTALPRICE", typeof(string));
            */
                              
            //cartfinal.DataSource = dt;

        }

        private void timexD_Tick(object sender, EventArgs e)
        {
            string taym = DateTime.Now.ToLongTimeString();
            string deyt = DateTime.Now.ToShortDateString();
            string deytaym = taym + "  " + deyt;
            orasanXD.Text = deytaym;
        }
  
       

        private void newtransactionbtn_Click(object sender, EventArgs e)
        {
            finalprice = "";
            finalcash = "";
            finalchange = "";
            ikot = 0;
           finalidlist.Clear();
         finalnamelist.Clear();
       finalpricelist .Clear();
       finalquantitylist.Clear();
       finaltotalpricelist.Clear();
            AdminStaffSession_Order_ xD = new AdminStaffSession_Order_();
            xD.Show();            
            this.Close();            
        }

        public void resiboxD()
        {
           
            
            for (int x = 0; x <=ikot; x++ )
            {
                cartfinal.Rows.Add(finalidlist[x], finalnamelist[x], finalpricelist[x], finalquantitylist[x], finaltotalpricelist[x]);
               // MessageBox.Show(finalquantitylist[x].ToString());
                //dt.Rows.Add(finalidlist[x], finalnamelist[x], finalpricelist[x], finalquantitylist[x], finaltotalpricelist[x]);
            }


         

          
           


        }

    
        /*
         * 
        public static string total = "";
        public static string cash = "";
        public static string change = "";
         * */

        public void resetxD()
        {

            HelloSayoXD.Close();
            HelloSayoXD.Open();

          
                OleDbCommand hixD = HelloSayoXD.CreateCommand();
                hixD.CommandType = CommandType.Text;
                hixD.CommandText = "Delete from print";

                hixD.ExecuteNonQuery();
            
            HelloSayoXD.Close();

        }
        private void Print_Click(object sender, EventArgs e)
        {
                //resetxD();

      

  


         //insertPrint();


          AdminStaffSession_PrintReceipt_.total = finalpriceLBL.Text.Trim();
           AdminStaffSession_PrintReceipt_.cash = finalcashLBL.Text.Trim();
        AdminStaffSession_PrintReceipt_.change = finalchangeLBL.Text.Trim();
            

         AdminStaffSession_PrintReceipt_ xD = new AdminStaffSession_PrintReceipt_();

        xD.Show();
           
           
        }
        //-----------------------------------------------------------
       
        //-----------------------------------------------------------
        /**
        public void insertPrint()
        {

            HelloSayoXD.Close();
            HelloSayoXD.Open();

            for(int wahaha = 0; wahaha<=ikot;wahaha++)
            {
            OleDbCommand hixD = HelloSayoXD.CreateCommand();
            hixD.CommandType = CommandType.Text;
            hixD.CommandText = "INSERT INTO Print (Product_ID,Product_Name,Product_Price,Product_Quantity,Product_Total_Price) VALUES (@a2,@a3,@a4,@a5,@a6)";

               
                hixD.Parameters.AddWithValue("@a2", finalidlist[wahaha]);
                hixD.Parameters.AddWithValue("@a3", finalnamelist[wahaha]);
                hixD.Parameters.AddWithValue("@a4", finalpricelist[wahaha]);
                hixD.Parameters.AddWithValue("@a5", finalquantitylist[wahaha]);
                hixD.Parameters.AddWithValue("@a6", finaltotalpricelist[wahaha]);
             //   MessageBox.Show(finalidlist[wahaha] + "," + finalnamelist[wahaha] + "," + finalpricelist[wahaha] + "," + finalquantitylist[wahaha] + "," + finaltotalpricelist[wahaha]);
                hixD.ExecuteNonQuery();
            }
             HelloSayoXD.Close();

        }*/
        
        /**
        public static List<string> finalidlist = new List<string>();
        public static List<string> finalnamelist = new List<string>();
        public static List<string> finalpricelist = new List<string>();
        public static List<string> finalquantitylist = new List<string>();
        public static List<string> finaltotalpricelist = new List<string>();
        
        **/


    }
}
