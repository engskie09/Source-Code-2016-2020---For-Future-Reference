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
    public partial class Cashier_ForgotPassword_ : Form
    {
        MySqlConnection connection = new MySqlConnection(methods.con);

        public Cashier_ForgotPassword_()
        {
            InitializeComponent();
        }
        string question;
        string username;
        string answer;
        private void Username_TextChanged(object sender, EventArgs e)
        {

            try
            {

                MySqlDataReader rdr = null;

                MySqlCommand cmd = new MySqlCommand("select * from cashieradmin;", connection);
                connection.Open();



                cmd = connection.CreateCommand();
                cmd.CommandText = "select Username from cashieradmin where Username LIKE '" + textBox4.Text + "'";


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    label5.Text = "Username Valid";

                    button1.Enabled = true;
                    load();
                    return;
                }
                if (!rdr.Read())
                {
                    label5.Text = "Username Invalid";

                    button1.Enabled = false;
                    textBox4.Focus();

                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cashier_ForgotPassword__Load(object sender, EventArgs e)
        {

        }




        public void load()
        {
            try
            {

                MySqlConnection connection = new MySqlConnection(methods.con);
                connection.Open();


                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "Select * from cashieradmin where Username LIKE '" + textBox4.Text + "'";

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        username = reader.GetString(4);
                        question = reader.GetString(7);
                        answer = reader.GetString(8);
                    }
                }

                //      MySqlDataAdapter adap = new MySqlDataAdapter(cmd);



                /* DataSet ds = new DataSet();
                 adap.Fill(ds);
                 dataGridView3.DataSource = ds.Tables[0].DefaultView;
                 dataGridView3.Columns[0].HeaderText = "Username";
                 dataGridView3.Columns[].HeaderText = "SecretQuestion";
                 dataGridView3.Columns[2].HeaderText = "Answer";

     */
                Question.Text = question;

                // answer = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                throw;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {

                MessageBox.Show("Required: Username");


            }
            else
            {
                load();
                panel1.Visible = false;
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            if ("" == MyAnswer.Text)
            {
                MessageBox.Show("Required: Security Answer");
                return;

            }

            if (answer == MyAnswer.Text)
            {

                panel1.Visible = false;
                panel3.Visible = true;

                panel2.Visible = false;

            }

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength < 8)
            {

                MessageBox.Show("Note: Password should be more than 7 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                MySqlConnection connection = new MySqlConnection(methods.con);
                MySqlCommand cmd;
                connection.Open();

                try
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE cashieradmin SET Password=@Password WHERE Username=@username ";


                    cmd.Parameters.AddWithValue("@username", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);


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

                        MessageBox.Show("Account succesfully updated!");
                        MessageBox.Show("Now, sign in with your new password!");

                        this.Hide();




                    }
                }
            }
        }
    }
}
