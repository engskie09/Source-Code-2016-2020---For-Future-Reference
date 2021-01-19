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
    public partial class AdminSession_Manage_Accounts : Form
    {
        public AdminSession_Manage_Accounts()
        {
            InitializeComponent();
        }

       OleDbConnection connection = new OleDbConnection(LoginSession.x);
        private void button6_Click(object sender, EventArgs e)
        {
            AdminSession_Manage_Accounts ugh = new AdminSession_Manage_Accounts();
            this.Hide();

            AdminSession shn = new AdminSession();
            shn.Show();
        }
    
        public void checkxDAdmin1()
        {
            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Admin_Name from AdminAccount";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if (x.ToUpper() == textBox2.Text.Trim().ToUpper())
                {
                    itsTRUE = false;
                    break;
                }


            }

            connection.Close();

        }

        public void checkxDStaff1()
        {
            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Staff_Name from StaffsAccounts";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if (x.ToUpper() == textBox2.Text.Trim().ToUpper())
                {
                    itsTRUE = false;
                    break;
                }
            }

            connection.Close();

        }



       

        private void AdminSession_Manage_Accounts_Load(object sender, EventArgs e)
        {


         //   groupBox1.Location = new Point(12, 302);
            //groupBox2.Location = new Point(12, 302);
           // panel1.Location = new Point(486, 51);
            //panel3.Location = new Point(486, 51);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**
            if (comboBox2.Text  == "Admin Account")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;

                panel1.Visible = true;
                panel3.Visible = false;
               


                
            }

            else if (comboBox2.Text == "Staff Account") 
            {

                groupBox1.Visible = false;
                groupBox2.Visible = true;

                panel3.Visible = true;
                panel1.Visible = false;
                
            
            }


            **/



        }

        private void Firstname_Text(object sender, EventArgs e)
        {
            if (Firstname.Text == "First Name")
            {
                Firstname.Text = "";

                Firstname.ForeColor = Color.Black;


            }
        }

        private void Firstname_Leave(object sender, EventArgs e)
        {
            if (Firstname.Text == "")
            {
                Firstname.Text = "First Name";

                Firstname.ForeColor = Color.Silver;


            }
        }

        private void Lastname_Enter(object sender, EventArgs e)
        {
            if (Lastname.Text == "Last Name")
            {
                Lastname.Text = "";
                Lastname.ForeColor = Color.Black;

            }
        }

        private void Lastname_Leave(object sender, EventArgs e)
        {
            if (Lastname.Text == "")
            {
                Lastname.Text = "Last Name";
                Lastname.ForeColor = Color.Silver;
             
            
            }
        }

        private void text_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Password_Enter(object sender, EventArgs e)
        {
            if (text_Password.Text == "Password")
            {
                text_Password.Text = "";
                text_Password.ForeColor = Color.Black;
            }
        }

        private void text_Password_Leave(object sender, EventArgs e)
        {
            if (text_Password.Text == "")
            {
                text_Password.Text = "Password";
                text_Password.ForeColor = Color.Silver;
            }
        }

        private void checkBox_Show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked)
            {
                text_Password.UseSystemPasswordChar = true;

            }
            else
            {
                text_Password.UseSystemPasswordChar = false;
            }
        }

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        //ADD STAFF
        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text.Trim() == "" || text_Password.Text.Trim() == "" || contact.Text.Trim() == "" || DesignationXD.Text.Trim() == "")
            {
                MessageBox.Show("Invalid Input");
                return;
            
            }

            if (DesignationXD.Text == "Admin")
            addAdminXP();
         
            else if(DesignationXD.Text =="Staff")
            addStaffXD();


            Username.Text = "";
            text_Password.Text = "";
            contact.Text = "";
            DesignationXD.Text = "";
            petmalu = LoginSession.blankpicture;


            AdminSession_Manage_Accounts xD = new AdminSession_Manage_Accounts();
            xD.Show();
            this.Close();


            /**
            try
            {
                connection.Close();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Admin( Admin_Name, Admin_Password) values(@a1,@a2)";
                command.Parameters.AddWithValue("@a1", Username.Text.Trim());
                command.Parameters.AddWithValue("@a1", text_Password.Text.Trim());
                MessageBox.Show("Admin Added");
                connection.Close();
              

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Admin";
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
            }**/
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       

        private void Lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";

                Username.ForeColor = Color.Black;


            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";

               Username.ForeColor = Color.Silver;


            }
        }

        private void Firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void ShowTable_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Admin";
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
        }
        /**
        private void textBox12_Enter(object sender, EventArgs e)
        {

            
            if (textBox12.Text == "Username")
            {
                textBox12.Text = "";

                textBox12.ForeColor = Color.Black;


            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {

            if (textBox12.Text == "")
            {
                textBox12.Text = "Username";

                textBox12.ForeColor = Color.Silver;


            }
        }

        private void Pssword_Enter(object sender, EventArgs e)
        {
            if (Pssword.Text == "Password")
            {
                Pssword.Text = "";
                Pssword.ForeColor = Color.Black;
            
            
            }
        }

        private void Pssword_Leave(object sender, EventArgs e)
        {
            if (Pssword.Text == "")
            {
                Pssword.Text = "Password";
                Pssword.ForeColor = Color.Silver;


            }
        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Firstname.Text = row.Cells["First Name"].Value.ToString();
                Lastname.Text = row.Cells["Last Name"].Value.ToString();
                Username.Text = row.Cells["User Name"].Value.ToString();
                text_Password.Text = row.Cells["Password"].Value.ToString();

            }
        }


        //load table staff account
        private void button2_Click(object sender, EventArgs e)
        {/**
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from StaffAccount";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //dataGridView2.DataSource = dt;

                connection.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }**/
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /**
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update StaffAdmin set  Password='" + Pssword.Text + "', Position='" + comboBox1.Text + "' where Username='" + textBox12.Text + "' ";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                connection.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            /**
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                textBox12.Text = row.Cells["Username"].Value.ToString();
                comboBox1.Text = row.Cells["Position"].Value.ToString();
                Pssword.Text = row.Cells["Password"].Value.ToString();
               

            }**/
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /**
            if (checkBox1.Checked)
            {
                Pssword.UseSystemPasswordChar = true;

            }
            else
            {
                Pssword.UseSystemPasswordChar = false;
            }**/
        }

        string petmalu = LoginSession.blankpicture;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog XB = new OpenFileDialog();

            String LOLS = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            XB.Filter = LOLS;

            if (XB.ShowDialog() == DialogResult.OK)
            {
                petmalu = XB.FileName.ToString();

                pictureBox3.ImageLocation = petmalu;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }












        public void addAdminXP()
        {
            checkxDAdmin();

            connection.Close();
            connection.Open();
            OleDbCommand hixD = connection.CreateCommand();
            hixD.CommandType = CommandType.Text;

            if (itsTRUE)
            {
                hixD.CommandText = "INSERT INTO AdminAccount (Admin_Name,Admin_Password,Password_Retrieve,Admin_Picture) VALUES (@a1,@a2,@a3,@a4)";

                hixD.Parameters.AddWithValue("@a1", Username.Text.Trim());
                hixD.Parameters.AddWithValue("@a2", text_Password.Text.Trim());
                hixD.Parameters.AddWithValue("@a3", contact.Text.Trim());
                hixD.Parameters.AddWithValue("@a4", petmalu);

                hixD.ExecuteNonQuery();

                MessageBox.Show("Admin Added");

            }



            else
            {
                MessageBox.Show("Admin Name Already EXIST!");
            }

            connection.Close();
            itsTRUE = true;
        }

        public void addStaffXD()
        {
            checkxDStaff();
            connection.Close();
            connection.Open();
            OleDbCommand hixD = connection.CreateCommand();
            hixD.CommandType = CommandType.Text;

            if (itsTRUE)
            {
                hixD.CommandText = "INSERT INTO StaffsAccounts (Staff_Name,Staff_Password,Password_Retrieve,Staff_Picture) VALUES (@a1,@a2,@a3,@a4)";

                hixD.Parameters.AddWithValue("@a1", Username.Text.Trim());
                hixD.Parameters.AddWithValue("@a2", text_Password.Text.Trim());
                hixD.Parameters.AddWithValue("@a3", contact.Text.Trim());
                hixD.Parameters.AddWithValue("@a4", petmalu);

                hixD.ExecuteNonQuery();

                MessageBox.Show("Staff Added");

            }



            else
            {
                MessageBox.Show("Staff Name Already EXIST!");
            }

            connection.Close();

            itsTRUE = true;
        }



        public void checkxDAdmin()
        {
            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Admin_Name from AdminAccount";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if (x.ToUpper() == Username.Text.Trim().ToUpper())
                {
                    itsTRUE = false;
                    break;
                }
                
                
            }

            connection.Close();

        }

        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------
        bool itsTRUE = true;
       
        public void checkxDStaff()
        {
            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Staff_Name from StaffsAccounts";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if (x.ToUpper() == Username.Text.Trim().ToUpper())
                {
                    itsTRUE = false;
                    break;
                }
            }

            connection.Close();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Admin")
            {
                asd1.Items.Clear();
                Filladmin();
                asd.Visible = true;
                asd1.Visible = true;

            }

            else if (comboBox3.Text == "Staff")
            {
                asd1.Items.Clear();
                Fillstaff();
                asd.Visible = true;
                asd1.Visible = true;
                   
        
            }
        }

        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------


        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------

        public void Filladmin()
        {
            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Admin_Name from AdminAccount";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();
                asd1.Items.Add(x);
            }

            connection.Close();
        }
     
        public void Fillstaff()
        {
            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Staff_Name from StaffsAccounts";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();
                asd1.Items.Add(x);
            }

            connection.Close();
        }

        private void asd1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Admin")
            {
                SELECTADMIN();
            }

            else if (comboBox3.Text == "Staff")
            {
                SELECTSTAFF();
            }
        }


        public void SELECTADMIN()
        {

            connection.Close();

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from AdminAccount WHERE Admin_Name= '" + asd1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {
                malelate = Convert.ToInt32(xdr["ID"].ToString());
                textBox2.Text = xdr["Admin_Name"].ToString();
                adminChangeUser = xdr["Admin_Name"].ToString();
                textBox3.Text = xdr["Admin_Password"].ToString();
                textBox1.Text = xdr["Password_Retrieve"].ToString();
                comboBox2.Text = comboBox3.Text;
                petmalu = xdr["Admin_Picture"].ToString();
                pictureBox2.ImageLocation = petmalu;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            connection.Close();


        }
        string staffChangeUser = "";
        string adminChangeUser = "";
        public void SELECTSTAFF()
        {


            connection.Close();

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from StaffsAccounts WHERE Staff_Name= '" + asd1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {
                malelate = Convert.ToInt32(xdr["ID"].ToString());
                textBox2.Text = xdr["Staff_Name"].ToString();
                staffChangeUser = xdr["Staff_Name"].ToString();
                textBox3.Text = xdr["Staff_Password"].ToString();
                textBox1.Text = xdr["Password_Retrieve"].ToString();
                comboBox2.Text = comboBox3.Text;
                petmalu = xdr["Staff_Picture"].ToString();
                pictureBox2.ImageLocation = petmalu;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


            }
            connection.Close();


        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog XB = new OpenFileDialog();

            String LOLS = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            XB.Filter = LOLS;

            if (XB.ShowDialog() == DialogResult.OK)
            {
                petmalu = XB.FileName.ToString();

                pictureBox2.ImageLocation = petmalu;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Admin")
            {
                
                updateAdmin();
                AdminSession_Manage_Accounts xD = new AdminSession_Manage_Accounts();
                xD.Show();
                this.Close();
                
            }

            else if (comboBox2.Text == "Staff")
            {
                updateStaff();
                AdminSession_Manage_Accounts xD = new AdminSession_Manage_Accounts();
                xD.Show();
                this.Close();
            }


        }
        // checkxDAdmin
         //   checkxDStaff
       // string staffChangeUser = "";
      //  string adminChangeUser = "";
        int malelate =  -1 ;
        public void updateAdmin()
        {


            connection.Close();
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (textBox2.Text != adminChangeUser)
            {
                checkxDAdmin1();
            }
          

           if (itsTRUE == true)
           {
               connection.Open();
               cmd.CommandText = "update AdminAccount set Admin_Name = @x1, Admin_Password = @x2, Password_Retrieve = @x3, Admin_Picture = @x5 where ID = @x6 ";
               cmd.Parameters.AddWithValue("@x1", textBox2.Text.Trim());
               cmd.Parameters.AddWithValue("@x2", textBox3.Text.Trim());
               cmd.Parameters.AddWithValue("@x3", textBox1.Text.Trim());
               // cmd.Parameters.AddWithValue("@x4", comboBox2.Text.Trim());
               cmd.Parameters.AddWithValue("@x5", petmalu);
               cmd.Parameters.AddWithValue("@x6", malelate.ToString());
               cmd.ExecuteNonQuery();


               MessageBox.Show("Update Successful");

           }

           else
           {
               MessageBox.Show("Admin Name Already EXIST!");
           }

        

            connection.Close();
        }

        
        public void updateStaff()
        {


            connection.Close();
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;

           
             if (textBox2.Text != staffChangeUser)
            {
                 checkxDStaff1();
            }
            
            if (itsTRUE == true)
            {
                connection.Open();
                cmd.CommandText = "update StaffsAccounts set Staff_Name = @x1, Staff_Password = @x2, Password_Retrieve = @x3, Staff_Picture = @x5 where ID = @x6 ";
                cmd.Parameters.AddWithValue("@x1", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@x2", textBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@x3", textBox1.Text.Trim());
               // cmd.Parameters.AddWithValue("@x4", comboBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@x5", petmalu);
                cmd.Parameters.AddWithValue("@x6", malelate);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Update Successful");

            }

            else
            {
                MessageBox.Show("Admin Name Already EXIST!");
            }
            connection.Close();
        }

        private void timexD_Tick(object sender, EventArgs e)
        {

            string taym = DateTime.Now.ToLongTimeString();
            string deyt = DateTime.Now.ToShortDateString();
            string deytaym = taym + " " + deyt;
            //orasanXD.Text = deytaym;
        }

        private void asd1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

    }

       
}
