﻿using MySql.Data.MySqlClient;
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


    public partial class Cashier_SuperAdminAddStaff_ : Form
    {
        MySqlConnection connection = new MySqlConnection(methods.con);
        public Cashier_SuperAdminAddStaff_()
        {
            InitializeComponent();
            FillCombo();
        }
        void FillCombo()
        {

            string Query = "Select DISTINCT SecretQuestions From secretquestion;";
            MySqlConnection con = new MySqlConnection(methods.con);
            MySqlCommand cmd = new MySqlCommand(Query, con);
            MySqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string sQuestion = myreader.GetString("SecretQuestions");
                    SecretQuestion.Items.Add(sQuestion);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Cashier_SuperAdminAddStaff__Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (getCardNo.Text != "" && InputUsername.Text != "" && inputPassword.Text != "" && Firstname.Text != "" && Lastname.Text != "" && SecretQuestion.Text != "" && Answer.Text != "")
            {

                MessageBox.Show("");

                cmd.CommandText = "insert into cashieradmin(CardNo,Username,Password,FirstName,Middlename,LastName,SecretQuestion,Answer) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";

                cmd.Parameters.AddWithValue("@a1", getCardNo.Text.Trim());
                cmd.Parameters.AddWithValue("@a2", InputUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@a3", inputPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@a4", Firstname.Text.Trim());
                cmd.Parameters.AddWithValue("@a5", MiddleName.Text.Trim());
                cmd.Parameters.AddWithValue("@a6", Lastname.Text.Trim());
                cmd.Parameters.AddWithValue("@a7", SecretQuestion.Text.Trim());

                cmd.Parameters.AddWithValue("@a8", Answer.Text.Trim());


                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data inserted.");
                    {
                        getCardNo.Text = String.Empty;
                        InputUsername.Text = String.Empty;
                        inputPassword.Text = String.Empty;
                        Firstname.Text = String.Empty;
                        Lastname.Text = String.Empty;
                        SecretQuestion.Text = String.Empty;
                        Answer.Text = String.Empty;
                        MiddleName.Text = String.Empty;     

                    }


                    Lastname.Text = "";
                    InputUsername.Text = "";
                    getCardNo.Text = "";
                    inputPassword.Text = "";
                    Firstname.Text = "";
                    SecretQuestion.Text = "";
                    Answer.Text = "";



                }
                else
                {
                    MessageBox.Show("Please don`t leave any blank!");
                }

                connection.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_SuperAdminEditLoad_ a = new Cashier_SuperAdminEditLoad_();
            a.Show();
            this.Hide();
        }
    }
}
