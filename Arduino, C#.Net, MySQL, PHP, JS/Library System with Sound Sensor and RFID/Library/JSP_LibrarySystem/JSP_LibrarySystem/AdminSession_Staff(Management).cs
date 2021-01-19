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


namespace JSP_LibrarySystem
{
    public partial class AdminSession_Staff_Management_ : Form
    {
        String get_StaffID = "";
        String get_StaffUserName = "";
        String get_StaffUserPassword = "";
        String get_StaffFirstName = "";
        String get_StaffMiddleName = "";
        String get_StaffLastName = "";
DataSet ds = new DataSet();

        public AdminSession_Staff_Management_()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            
        }

        public static String connectionString = "server=localhost;userid=root;database=db_jplhs_librarysystem";

        private static MySqlConnection connection = new MySqlConnection(connectionString); 

        private void AdminSession_Staff_Management__Load(object sender, EventArgs e)
        {

            disp_data();
        }

        public void SameValue()
        {

            
        }

        private void btn_AddStaff_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

            
            btn_getAction.Text = "Add";

            txt_getStaffUserName.Enabled = true;
            txt_getStaffUserPassword.Enabled = true;
            txt_getStaffFirstName.Enabled = true;
            txt_getStaffMiddleName.Enabled = true;
            txt_getStaffLastName.Enabled = true;
            btn_getAction.Visible = true;
;

            
        }

        private void btn_UpdateStaff_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            btn_getAction.Text = "Update";

            txt_getStaffUserName.Enabled = true;
            txt_getStaffUserPassword.Enabled = true;
            txt_getStaffFirstName.Enabled = true;
            txt_getStaffMiddleName.Enabled = true;
            txt_getStaffLastName.Enabled = true;
            btn_getAction.Visible = true;

        }

        private void btn_DeleteStaff_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            btn_getAction.Text = "Delete";

            txt_getStaffUserName.Enabled = true;
            txt_getStaffUserPassword.Enabled = true;
            txt_getStaffFirstName.Enabled = true;
            txt_getStaffMiddleName.Enabled = true;
            txt_getStaffLastName.Enabled = true;
            

            btn_getAction.Visible = true;
        }

        private void btn_getAction_Click(object sender, EventArgs e)
        {
                
            get_StaffUserName = txt_getStaffUserName.Text.Trim();
            get_StaffUserPassword = txt_getStaffUserPassword.Text.Trim();
            get_StaffFirstName = txt_getStaffFirstName.Text.Trim();
            get_StaffMiddleName = txt_getStaffMiddleName.Text.Trim();
            get_StaffLastName = txt_getStaffLastName.Text.Trim();

            String validationContainer = "Please fill up: ";
            if (txt_getStaffUserName.Text == "" || txt_getStaffUserPassword.Text == "" || txt_getStaffFirstName.Text == "" || txt_getStaffMiddleName.Text == "" || txt_getStaffLastName.Text == "")
            {
                if (txt_getStaffUserName.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Staff User Name, ");

                }
                if (txt_getStaffUserPassword.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Staff Password, ");

                }
                if (txt_getStaffFirstName.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Staff First Name, ");
                }
                if (txt_getStaffMiddleName.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Staff Middle Name, ");
                }
                if (txt_getStaffLastName.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Staff Last Name, ");
                }


            }

            else if (btn_getAction.Text == "Add")
            {
                if (txt_getStaffUserPassword.Text.Length < 6)
                {
                    MessageBox.Show("Passwords must be at least 6 characters long");
                    return;


                }
                  
                else 
                {
                    MySqlCommand cmd1 = connection.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select * from tbl_user_information where user_id='" + lbl_getStaffID.Text + "'";
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                    da.Fill(ds);
                    int i = ds.Tables[0].Rows.Count;
                    if (i > 0)
                    {
                        MessageBox.Show("Staff Existed!");
                    }

                    else
                    {
                        try
                        {
                            
                            Random r = new Random();
                            int nums = r.Next(1000, 9999);
                            get_StaffID = lbl_getStaffID.Text = "Staff-" + nums.ToString();
                            connection.Open();
                            MySqlCommand cmd2 = connection.CreateCommand();
                            cmd2.CommandType = CommandType.Text;
                            cmd2.CommandText = "insert into tbl_user_information values('" + lbl_getStaffID.Text + "','" + txt_getStaffUserName.Text + "','" + txt_getStaffUserPassword.Text + "','" + txt_getStaffFirstName.Text + "','" + txt_getStaffMiddleName.Text + "','" + txt_getStaffLastName.Text + "')";
                           
                            cmd2.ExecuteNonQuery();

                            MySqlCommand cmd = connection.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into tbl_user_logincredentials values('" + lbl_getStaffID.Text + "','" + txt_getStaffUserName.Text + "','" + txt_getStaffUserPassword.Text + "')";
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            disp_data();
                            MessageBox.Show("Staff Added!");

                            txt_getStaffUserName.Text = "";
                            txt_getStaffUserPassword.Text = "";
                            txt_getStaffFirstName.Text = "";
                            txt_getStaffMiddleName.Text = "";
                            txt_getStaffLastName.Text = "";
                            lbl_getStaffID.Text = "*****";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                }
            }

            else if (btn_getAction.Text == "Update")
            {
                /*SystemMethods_AdminSession.update_UserInformation(get_StaffID, get_StaffUserName, get_StaffUserPassword,
                                                                    get_StaffFirstName, get_StaffMiddleName, get_StaffLastName,
                  "Staff");*/
                if (txt_getStaffUserPassword.Text.Length < 6)
                {
                    MessageBox.Show("Passwords must be at least 6 characters long");
                    return;
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update tbl_user_information set user_name='" + txt_getStaffUserName.Text + "',user_password='" + txt_getStaffUserPassword.Text + "',user_Firstname='" + txt_getStaffFirstName.Text + "',user_Middlename='" + txt_getStaffMiddleName.Text + "',user_Lastname='" + txt_getStaffLastName.Text + "'where user_id ='" + lbl_getStaffID.Text + "'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update tbl_user_logincredentials set user_name='" + txt_getStaffUserName.Text + "',user_password='" + txt_getStaffUserPassword.Text + "' where user_id ='" + lbl_getStaffID.Text + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    disp_data();
                    MessageBox.Show("Staff Updated!");
 
                }
            }

            else if (btn_getAction.Text == "Delete")
            {
                if (txt_getStaffUserPassword.Text.Length < 6)
                {
                    MessageBox.Show("Passwords must be at least 6 characters long");
                    return;
                }
                else
                {
                    connection.Close();
                    string message = "Do you want to delete this?";
                    string title = "Delete";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from tbl_user_information where user_id ='" + lbl_getStaffID.Text + "'";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "delete from tbl_user_logincredentials where user_id ='" + lbl_getStaffID.Text + "'";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        disp_data();
                        MessageBox.Show("Staff Deleted!");


                    }

                }

            }




            btn_getAction.Text = "";

            txt_getStaffUserName.Enabled = false;
            txt_getStaffUserPassword.Enabled = false;
            txt_getStaffFirstName.Enabled = false;
            txt_getStaffMiddleName.Enabled = false;
            txt_getStaffLastName.Enabled = false;
            

            txt_getStaffUserName.Clear();
            txt_getStaffUserPassword.Clear();
            txt_getStaffFirstName.Clear();
            txt_getStaffMiddleName.Clear();
            txt_getStaffLastName.Clear();
            

            get_StaffID = "";
            get_StaffUserName = "";
            get_StaffUserPassword = "";
            get_StaffFirstName = "";
            get_StaffMiddleName = "";
            get_StaffLastName = "";
           
            
            btn_getAction.Visible = false;


            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }
        int click = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            click = e.RowIndex;

            DataGridViewRow clicked = new DataGridViewRow();
            clicked = dataGridView1.Rows[click];

            lbl_getStaffID.Text = clicked.Cells[0].Value.ToString();
            txt_getStaffUserName.Text = clicked.Cells[1].Value.ToString();
            txt_getStaffUserPassword.Text = clicked.Cells[2].Value.ToString();
            txt_getStaffFirstName.Text = clicked.Cells[3].Value.ToString();
            txt_getStaffMiddleName.Text = clicked.Cells[4].Value.ToString();
            txt_getStaffLastName.Text = clicked.Cells[5].Value.ToString();


        }
        public void disp_data()
        {

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_user_information where user_role = 'Staff'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

