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


namespace Cashier_Register_Reload_
{
    public partial class Cashier_SuperAdminLoginEditLoad_ : Form
    {
        MySqlConnection connection = new MySqlConnection(methods.con);

        public Cashier_SuperAdminLoginEditLoad_()
        {
            InitializeComponent();
        }

        private void Superadminlogin_TextChanged(object sender, EventArgs e)
        {
            if (Superadminlogin.Text.Length == 10)
            {

                MySqlConnection cnn;

                cnn = new MySqlConnection(methods.con);
                // try
                //  {
                cnn.Open();



                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from superadmin Where CardNo='" + Superadminlogin.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);


                if (dt.Rows.Count == 1)
                {

                    cnn.Close();

                


                    cnn.Open();






                    Cashier_SuperAdminEditLoad_ a = new Cashier_SuperAdminEditLoad_();

                    DataTable huehue = new DataTable();
                  

                    a.Show();
                    this.Hide();
                }




                cnn.Close();
                Superadminlogin.Clear();

            }
        }

        private void Cashier_SuperAdminLoginEditLoad__Load(object sender, EventArgs e)
        {

        }
    }
}
