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
    public partial class Cashier_SuperAdminAddAccount_ : Form
    {
        MySqlConnection connection = new MySqlConnection(methods.con);

        public Cashier_SuperAdminAddAccount_()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputAccessCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputRFID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_SuperAdminEditLoad_ a = new Cashier_SuperAdminEditLoad_();
            a.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
            connection.Close();
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (inputRFID.Text != "" && inputFirstName.Text != "" && inputMiddleName.Text != "" && inputLastName.Text != "" && inputAccessCode.Text != "" && inputBalance.Text != "")
            {

                MessageBox.Show("");

                cmd.CommandText = "insert into carduser(CardNo,FirstName,MiddleName,LastName,Verification,Balance,StudentID) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)";

                cmd.Parameters.AddWithValue("@a1", inputRFID.Text.Trim());
                cmd.Parameters.AddWithValue("@a2", inputFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@a3", inputMiddleName.Text.Trim());
                cmd.Parameters.AddWithValue("@a4", inputLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@a5", inputAccessCode.Text.Trim());
                cmd.Parameters.AddWithValue("@a6", inputBalance.Text.Trim());

                cmd.Parameters.AddWithValue("@a7", gettxtStudentID.Text.Trim());

                cmd.ExecuteNonQuery();

                inputRFID.Text = "";
                inputFirstName.Text = "";
                inputMiddleName.Text = "";
                inputLastName.Text = "";
                inputAccessCode.Text = "";
                gettxtStudentID.Text = "";
                inputBalance.Text = "";



            }
            else
            {
                MessageBox.Show("Please don`t leave any blank!");
            }

            connection.Close();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void inputMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gettxtStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cashier_SuperAdminAddAccount__Load(object sender, EventArgs e)
        {

        }
    }
}
