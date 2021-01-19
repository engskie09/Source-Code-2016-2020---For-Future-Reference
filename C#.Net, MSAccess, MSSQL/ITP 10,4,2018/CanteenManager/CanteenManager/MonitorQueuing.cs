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
namespace CanteenManager
{
    public partial class MonitorQueuing : Form
    {
        string connetionString = stringpotek.koneksyon;
        public MonitorQueuing()
        {
            InitializeComponent();
        }
        public void loadL()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connetionString);

            try
            {




                cnn.Open();


                MySqlCommand cmd = cnn.CreateCommand();


                cmd.CommandText = "SELECT  * from tbl_queuing   ";
                MySqlDataReader myReader;
                cmd.ExecuteNonQuery();
                myReader = cmd.ExecuteReader();
                NPOrder1.Text = "";
                while (myReader.Read())
                {




                    for (int i1 = 0; i1 < 1; i1++)
                    {

                        for (int i2 = 1; i2 < 2; i2++)
                        {




 
                                string a1 = myReader[i1].ToString();
                                string a2 = myReader[i2].ToString();
                           

                                NPOrder1.Text += myReader[i1].ToString() + " " + myReader[i2].ToString()   + Environment.NewLine;

                            


                        }

                    }

                }


                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Clone();


                }



            }
            catch (Exception)
            {

                throw;
            }


        }


        public void loadL2()
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(connetionString);

            try
            {




                cnn.Open();


                MySqlCommand cmd = cnn.CreateCommand();


                cmd.CommandText = "SELECT  * from recipecurrent   ";
                MySqlDataReader myReader;
                cmd.ExecuteNonQuery();
                myReader = cmd.ExecuteReader();
                NWOrder1.Text = "";
                while (myReader.Read())
                {




                    for (int i1 = 4; i1 < 5; i1++)
                    {

                         
                                string a1 = myReader[i1].ToString();
                               

                                NWOrder1.Text += myReader[i1].ToString()   + Environment.NewLine;

                             

                    }

                }


                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Clone();


                }



            }
            catch (Exception)
            {

                throw;
            }


        }
        private void MonitorQueuing_Load(object sender, EventArgs e)
        {
            loadL();
            loadL2();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NWOrder1_Click(object sender, EventArgs e)
        {

        }

        private void NWOrder3_Click(object sender, EventArgs e)
        {

        }

        private void NWOrder5_Click(object sender, EventArgs e)
        {

        }

        private void NWOrder6_Click(object sender, EventArgs e)
        {

        }

        private void NWOrder10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
