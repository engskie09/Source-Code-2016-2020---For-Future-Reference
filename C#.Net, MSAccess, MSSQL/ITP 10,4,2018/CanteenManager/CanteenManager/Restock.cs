using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManager
{

    public partial class Restock : Form
    { 
        MySqlConnection connection = new MySqlConnection(stringpotek.koneksyon);
        public Restock()
        {
            InitializeComponent();
        }
       
        
        
        private void button9_Click(object sender, EventArgs e)
        {
            restocks();
        }
        public void restocks()
        {



            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE food_tbl SET Quantity=@quantity where name='" + ProductName.Text + "'";
                cmd.Parameters.AddWithValue(@"quantity", Quantity.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                    RestockUp a = new RestockUp();
                    a.Show();


                    MessageBox.Show("Item Has Successfully Restocked");
                    this.Hide();
                }

            }
        }
    
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RestockUp a = new RestockUp();
            a.Show();
            this.Hide();
        }
    }
}
