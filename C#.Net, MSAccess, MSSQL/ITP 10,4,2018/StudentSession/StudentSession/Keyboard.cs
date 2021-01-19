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

namespace CanteenKiosk
{
    public partial class Keyboard : Form
    {
        public Keyboard()
        {
            InitializeComponent();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
         
        }


        Boolean PROceeedTobuy = false;

        public  void getCurrentBalance()
        {
            MySqlConnection cnn = new MySqlConnection(stringpotek.koneksyon);

            cnn.Close();
            cnn.Open();





            MySqlCommand cmdx = cnn.CreateCommand();
            cmdx.CommandType = CommandType.Text;
            cmdx.CommandText = "Select balance from carduser where StudentID='" + lblgetStudID.Text + "' ";
            cmdx.ExecuteNonQuery();
            DataTable dts = new DataTable();
            MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);
            xda.Fill(dts);





            
            foreach (DataRow xdr in dts.Rows)
            {
                balance = Convert.ToInt32(xdr["balance"].ToString());

              

                

            }


          

            cnn.Close();
            int balanceCompare = Convert.ToInt32(getTotaltoReduceBalancePotekXD);

           // MessageBox.Show(balance.ToString() + " " + balanceCompare.ToString());
            if (balance >= balanceCompare)
            {
                PROceeedTobuy = true;
            }
            else
            {
                PROceeedTobuy = false;
            }


    }

        private void Keyboard_Load(object sender, EventArgs e)
        {
            
            lblgetStudFullname.Text = Finalizee.getStudentFullname;
            lblgetStudID.Text = Finalizee.getStudentID;

            

        }

        private void Input1_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "1";

            txtValidate.Text = getCurrentTextValue;
        }

        private void Input2_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "2";

            txtValidate.Text = getCurrentTextValue;
        }

        private void Input3_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "3";

            txtValidate.Text = getCurrentTextValue;
        }
      

        private void Input4_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "4";
         
            txtValidate.Text = getCurrentTextValue;
        }

        private void Input5_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "5";

            txtValidate.Text = getCurrentTextValue;
        }

        private void Input6_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "6";

            txtValidate.Text = getCurrentTextValue;
        }

        private void Input7_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "7";

            txtValidate.Text = getCurrentTextValue;
        }

        private void Input8_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "8";

            txtValidate.Text = getCurrentTextValue;
        }

        private void Input9_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "9";

            txtValidate.Text = getCurrentTextValue;
        }

        private void Input0_Click(object sender, EventArgs e)
        {
            string getCurrentTextValue = txtValidate.Text;

            getCurrentTextValue = getCurrentTextValue + "0";

            txtValidate.Text = getCurrentTextValue;
        }

        private void InputClear_Click(object sender, EventArgs e)
        {

            txtValidate.Text = "";
        }



        private void InputEnter_Click(object sender, EventArgs e)
        {

            pilaysiya(lblgetStudID.Text);
            orderNo = "Order-0"; 

            getCurrentBalance();

            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);
            connection.Close();
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from carduser where StudentID ='" + lblgetStudID.Text + "' and Verification ='" + txtValidate.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            // if (balance >= cashtoPay)
            // {

            if (dt.Rows.Count == 1)
            {
                if (PROceeedTobuy)
                {
                  // MessageBox.Show(balance.ToString() + PROceeedTobuy.ToString());

                    //  closeActiveFormsXD();


                    txtValidate.Text = "";
                    setValuetoUpdate();
                    UpdateQuantityOnHand();
                    UpdatePeraPotekXD();
                    getCurrentCountforOrderNo();
                    StudentOrderHesTori();

                    insertToQueuingtbl();
                    insertValueToResibo();

                    Ordering.OrderTable.Clear();
                    this.Close();
                    bilhin xD = new bilhin();
                    xD.ShowDialog();

       
                }


                else
                {
                    DialogInsufficientBalance a = new DialogInsufficientBalance();
                    a.ShowDialog();
                }

            }
            else
            {
                DialogInvalid a = new DialogInvalid();
                a.ShowDialog();

            }

            

            // }
            //  else
            // {
            //  DialogInsufficientBalance a = new DialogInsufficientBalance();
            // a.ShowDialog();
            //}


        }

        private void txtValidate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        List<String> productName = new List<String>();
        List<String> productgetQuantity = new List<String>();
        List<String> productsetQuantity = new List<String>();
        List<String> productgetPrice = new List<String>();
        List<String> productgetTotal = new List<String>();
        // Ordering.OrderTable.Rows.Add(OrderName.Text,QuantityToBuy.Text,OrderPrice.Text,Total.ToString());
        public void setValuetoUpdate()
        {

            MySqlConnection cnn = new MySqlConnection(stringpotek.koneksyon);

            cnn.Close();
            cnn.Open();
            

            for (int x = 0; x <= Ordering.OrderTable.Rows.Count - 1; x++)
            {
                DataRow dr = Ordering.OrderTable.Rows[x];
                productName.Add(dr[0].ToString());
                productgetQuantity.Add(dr[1].ToString());
                productgetPrice.Add(dr[2].ToString());
                productgetTotal.Add(dr[3].ToString());

               


                MySqlCommand cmdx = cnn.CreateCommand();
                cmdx.CommandType = CommandType.Text;
                cmdx.CommandText = "Select quantity from food_tbl where name='" + productName[x] + "' ";
                cmdx.ExecuteNonQuery();
                DataTable dts = new DataTable();
                MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);
                xda.Fill(dts);

                int selectedquantity = 0;
                int currentQuantity = Convert.ToInt32(productgetQuantity[x]);
                foreach (DataRow xdr in dts.Rows)
                {
                    selectedquantity = Convert.ToInt32(xdr["quantity"].ToString());
                    selectedquantity = selectedquantity - currentQuantity;

                    productsetQuantity.Add(selectedquantity.ToString());

                }

               // MessageBox.Show(productName[x] + " " + productgetQuantity[x] + productsetQuantity[x] + " " + productgetPrice[x] + " " + productgetTotal[x]);
            }

            cnn.Close();

            
        }

        public void insertValueToResibo()
        {
           // MessageBox.Show("RESIBO KO POTEK!");
            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);

            connection.Close();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from recipecurrent";
            cmd.ExecuteNonQuery();

            for (int x = 0; x <= Ordering.OrderTable.Rows.Count - 1; x++){
           //     MessageBox.Show("nag iinsert ba ?");
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into recipecurrent (recipeOrderName,recipeQuantityToBuy,recipeOrderPrice,recipeTotal,orderNo) values(@b1,@b2,@b3,@b4,@b5)";
            cmd.Parameters.AddWithValue("@b1", productName[x]);
            cmd.Parameters.AddWithValue("@b2", productgetQuantity[x]);
            cmd.Parameters.AddWithValue("@b3", productgetPrice[x]);
            cmd.Parameters.AddWithValue("@b4", productgetTotal[x]);
                cmd.Parameters.AddWithValue("@b5", orderNo);
                cmd.ExecuteNonQuery();
             }
            connection.Close();

        }

        private void UpdateQuantityOnHand()
        {
            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);

            connection.Close();
            connection.Open();

            for (int x = 0; x <= Ordering.OrderTable.Rows.Count - 1; x++)
            {

                MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandType = CommandType.Text;
               cmd.CommandText = "update food_tbl set quantity = '" + productsetQuantity[x] + "' where Name ='" + productName[x] + "'";

                cmd.ExecuteNonQuery();
            }


            connection.Close();


        }

        private void closeActiveFormsXD()
        {
            Form check = Application.OpenForms["Ordering"];

            MainForm XD = new MainForm();
            XD.Show();
            check.Close();
            this.Close();

        }

        public static string getTotaltoReduceBalancePotekXD = "";


        int balance = 0;
        public static int cashtoPay = 0;
        private void UpdatePeraPotekXD()
        {
             MySqlConnection cnn = new MySqlConnection(stringpotek.koneksyon);

            cnn.Close();
            cnn.Open();       


               


                MySqlCommand cmdx = cnn.CreateCommand();
                cmdx.CommandType = CommandType.Text;
                cmdx.CommandText = "Select balance from carduser where StudentID='" + lblgetStudID.Text + "' ";
                cmdx.ExecuteNonQuery();
                DataTable dts = new DataTable();
                MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);
                xda.Fill(dts);
                
                Double pilaypilay = 0;
                
                if (getSpecialTreatment == "PWD")
                pilaypilay = .20;
                else if (getSpecialTreatment == "Senior")
                pilaypilay = .20;
               
          
            
              
                foreach (DataRow xdr in dts.Rows)
                {
                    balance = Convert.ToInt32(xdr["balance"].ToString());

                    getTotaltoReduceBalancePotekXD = (balance - (Convert.ToInt32(getTotaltoReduceBalancePotekXD))*pilaypilay ).ToString();
                    MessageBox.Show(getTotaltoReduceBalancePotekXD);
              
                   
                }
        
          

                cmdx = cnn.CreateCommand();
                cmdx.CommandType = CommandType.Text;
                cmdx.CommandText = "update carduser set Balance = '" + getTotaltoReduceBalancePotekXD + "' where StudentID ='" + lblgetStudID.Text + "'";
                cmdx.ExecuteNonQuery();

                cnn.Close();
                 
        }
        public static string orderNo = "Order-0";
        string datetoday = DateTime.Now.ToShortDateString();

        private void StudentOrderHesTori()
        {
            

            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);

            connection.Close();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "delete from recipecurrent";
            cmd.ExecuteNonQuery();
            
            
            for (int x = 0; x <= Ordering.OrderTable.Rows.Count - 1; x++)
            {

                cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into transaction_report_tbl (StudentID,OrderNo,OrderProducts,OrderQuantity,OrderPrice,OrderTotalPrice,OrderDate) values(@b1,@b2,@b3,@b4,@b5,@b6,@b7)";
                cmd.Parameters.AddWithValue("@b1", lblgetStudID.Text);
                cmd.Parameters.AddWithValue("@b2", orderNo);
                cmd.Parameters.AddWithValue("@b3", productName[x]);
                cmd.Parameters.AddWithValue("@b4", productgetQuantity[x]);
                cmd.Parameters.AddWithValue("@b5", productgetPrice[x]);
                cmd.Parameters.AddWithValue("@b6", productgetTotal[x]);             
                cmd.Parameters.AddWithValue("@b7", datetoday);

                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }





        private void getCurrentCountforOrderNo()
        {

            MySqlConnection cnn = new MySqlConnection(stringpotek.koneksyon);

            cnn.Close();
            cnn.Open();

            MySqlCommand cmdx = cnn.CreateCommand();
            cmdx.CommandType = CommandType.Text;
            cmdx.CommandText = "Select CurrentCount from tbl_ordercounter where Countid='OrderCount'";
            cmdx.ExecuteNonQuery();
            DataTable dts = new DataTable();
            MySqlDataAdapter xda = new MySqlDataAdapter(cmdx);
            xda.Fill(dts);

            int updateCount = 0;

            foreach (DataRow xdr in dts.Rows)
            {
                orderNo += xdr["CurrentCount"].ToString();

                updateCount = Convert.ToInt32(xdr["CurrentCount"].ToString());

                updateCount += 1;

            }
            cmdx.CommandType = CommandType.Text;
            cmdx.CommandText = "update tbl_ordercounter set currentCount = '"+updateCount.ToString()+"' where Countid='OrderCount'";
            cmdx.ExecuteNonQuery();



            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValidate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        /*
         * 
        List<String> productName = new List<String>();
        List<String> productgetQuantity = new List<String>();
        List<String> productsetQuantity = new List<String>();
        List<String> productgetPrice = new List<String>();
        List<String> productgetTotal = new List<String>();*/
        //Queuing Session
        private void insertToQueuingtbl()
        {
            setProductListValuetoSingleStringValue();

            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);

            connection.Close();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tbl_queuing Values('" + orderNo + "', '" + QueueProductName + "', '" + QueueProductQuantity + "') ";
            cmd.ExecuteNonQuery();

           
            connection.Close();
        }
        String QueueProductName = "";
        String QueueProductQuantity = "";
        private void setProductListValuetoSingleStringValue()
        {
            for (int x = 0; x <= Ordering.OrderTable.Rows.Count - 1; x++)
            {
                QueueProductName += productName[x].ToString() + ",";
                QueueProductQuantity += productgetQuantity[x].ToString() + ",";               

            }

            QueueProductName = QueueProductName.Remove(QueueProductName.Length - 1);
            QueueProductQuantity = QueueProductQuantity.Remove(QueueProductQuantity.Length - 1);
        }

        public static string getSpecialTreatment = "";

        private void pilaysiya(String getStudentID)
        {
            MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);
            MySqlCommand cmd = new MySqlCommand();

            connection.Close();
            connection.Open();

            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM carduser WHERE StudentID = '" + getStudentID + "'";
            cmd.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter();

            da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            MessageBox.Show(getStudentID);
            foreach (DataRow dr in dt.Rows)
            {
                getSpecialTreatment = dr["SpecialTreatment"].ToString();
                MessageBox.Show(getSpecialTreatment);
            }

            connection.Close();

            


        }

        
    }
}
