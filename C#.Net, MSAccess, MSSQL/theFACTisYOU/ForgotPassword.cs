using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theFACTisYOU
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(LoginSession.x);

        private void Login_Click(object sender, EventArgs e)
        {
            LoginSession xD = new LoginSession();
            xD.Show();
            this.Hide();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SELECTADMIN();
        }

        public void SELECTADMIN()
        {
            string passwordpotek = "";
            connection.Close();

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AdminAccount where Admin_Name= '" + Admin_Name.Text.Trim() + "' and Password_Retrieve= '" + textBox1.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                passwordpotek = xdr["Admin_Password"].ToString();

            }
            connection.Close();

            if (passwordpotek == "")
            {
                return;
            }
            MessageBox.Show("Your password: " + passwordpotek);

        }

        
    }
}
