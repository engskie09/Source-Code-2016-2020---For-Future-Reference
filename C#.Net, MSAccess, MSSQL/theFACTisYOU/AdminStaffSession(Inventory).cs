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


namespace theFACTisYOU
{
    public partial class AdminStaffSession_Inventory_ : Form
    {
        public AdminStaffSession_Inventory_()
        {
            InitializeComponent();
        }

       

        OleDbConnection connection = new OleDbConnection(LoginSession.x);
        private void InventoryMoto_Load(object sender, EventArgs e)
        {
            showxD();
        }

        public void showxD()
        {

            connection.Close();
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from ItemInventory";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            connection.Close();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from ItemInventory";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
               

            }

            catch 
            {
             //   MessageBox.Show("Error" + ex);
            }

            
        }

        //ADD 
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Please Fill the blanks");
                    return;
                }
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into ItemInventory(item_Name, item_Quantity) values('" + textBox1.Text + "', '" + textBox2.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Data Added");
                connection.Close();
                showxD();


                textBox1.Clear();
                textBox2.Clear();
                rowIndex = -10;
            }
            catch
            {
            }
                
            /**


            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from ItemInventory";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            */

             
        }
        int rowIndex = 0;
        //UPDATE
        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {


              
               
                if (rowIndex == 0)
                {
                    MessageBox.Show("Please select Item to Update!");
                    return;
                }

                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Please Fill the blanks");
                    return;
                }
               

                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update ItemInventory set  Item_Name=@a1, Item_Quantity =@a2 where ID=@a3 ";
              //  MessageBox.Show(query);
                command.CommandText = query; 
                command.Parameters.AddWithValue("@a1", textBox1.Text);
                command.Parameters.AddWithValue("@a2",textBox2.Text);
                command.Parameters.AddWithValue("@a3",rowIndex) ;
                command.ExecuteNonQuery();
               // MessageBox.Show("Data Updated");

                showxD();
                textBox1.Clear();
                textBox2.Clear();

                rowIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


            

        }

        //DELETE
        private void button3_Click(object sender, EventArgs e)
        {


       
            
                 if (rowIndex == 0)
                 {
                     MessageBox.Show("Please select Item to Delete!");
                     return;
                 }

                 

                 connection.Close();
                 connection.Open();
                OleDbCommand asd = new OleDbCommand("DELETE from ItemInventory WHERE (ID=@1)", connection);
                asd.Parameters.AddWithValue("@a1", rowIndex);
                asd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                showxD();

                textBox1.Clear();
                textBox2.Clear();

                connection.Close();
                rowIndex = 0;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Item_Name"].Value.ToString();
                textBox2.Text = row.Cells["Item_Quantity"].Value.ToString();
                rowIndex = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
          

            AdminSession shn = new AdminSession();
            shn.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            //DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            //textBox1.Text = selectedRow.Cells[0].Value.ToString();
            //textBox2.Text = selectedRow.Cells[0].Value.ToString(); 
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from ItemInventory ";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter("Select * from ItemInventory where Item_Name='" + txtSearch.Text + "'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

               
        }

       

       

        

       

   
    }
}
