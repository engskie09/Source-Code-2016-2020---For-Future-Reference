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
using System.IO;

namespace JSP_LibrarySystem
{
    public partial class STUDENT_MANAGEMENTcs : Form
    {
        public STUDENT_MANAGEMENTcs()
        {
            InitializeComponent();
            pictureBox2.Hide();

            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }    
        Byte [] pics = null;
        MemoryStream ms;
        DataSet ds = new DataSet();

       
        public static String connectionString = "server=localhost;userid=root;database=db_jplhs_librarysystem";

        private static MySqlConnection connection = new MySqlConnection(connectionString);

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            ms = new MemoryStream();

            open.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *.png; *.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                pics = ms.GetBuffer();

               // MessageBox.Show(pics.Length.ToString());
              
            }

            ms.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            String validationContainer = "Please fill up: ";
            if (Fname.Text == "" || Mname.Text == "" || Lname.Text == "" || cbGender.Text == "" || cbYearLvl.Text == "" || Section.Text == "" || StuAdviser.Text == "" || StuAddress.Text == "" || CpNumber.Text == "")
            {
                if (Fname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "First Name, ");

                }
                if (Mname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Middle Name, ");

                }
                if (Lname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Last Name, ");

                }
                if (cbGender.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Gender, ");

                }
                if (cbYearLvl.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Year Level, ");

                }
                if (Section.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Section, ");

                }
                if (StuAdviser.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Student Adviser, ");

                }
                if (StuAdviser.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Student Adviser, ");

                }
                if (StuAddress.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Address, ");

                }
                if (CpNumber.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Cellphone number, ");

                }
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show(validationContainer += "Picture");
                }

            }

            else
            {
                MySqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "Select * from tbl_student where student_id='" + StuNumber.Text + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("Student Existed!");
                    Fname.Text = "";
                    Mname.Text = "";
                    Lname.Text = "";
                    cbGender.Text = "";
                    cbYearLvl.Text = "";
                    Section.Text = "";
                    StuAdviser.Text = "";
                    StuAddress.Text = "";
                    StuNumber.Text = "";
                    stucardID.Text = "";
                    CpNumber.Text = "";
                    pictureBox1.Image = null;
                }
                else
                {
                    try
                    {

                        /*FileStream strim = new FileStream(img, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(strim);
                        pics = brs.ReadBytes((int)strim.Length);*/


                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into tbl_student values('" + StuNumber.Text + "','" + stucardID.Text + "','" + Fname.Text + "','" + Mname.Text + "','" + Lname.Text + "','" + cbGender.Text + "','" + cbYearLvl.Text + "','" + Section.Text + "','" + StuAdviser.Text + "','" + StuAddress.Text + "','" + CpNumber.Text + "',@pics)";
                        cmd.Parameters.Add(new MySqlParameter("@pics", pics));
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        disp_data();
                        Fname.Text = "";
                        Mname.Text = "";
                        Lname.Text = "";
                        cbGender.Text = "";
                        cbYearLvl.Text = "";
                        Section.Text = "";
                        StuAdviser.Text = "";
                        StuAddress.Text = "";
                        StuNumber.Text = "";
                        stucardID.Text = "";
                        CpNumber.Text = "";
                        pictureBox1.Image = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
          


        }


        private void STUDENT_MANAGEMENTcs_Load(object sender, EventArgs e)
        {
            disp_data();
            
        }

        private void Update_Click(object sender, EventArgs e)
        {

            String validationContainer = "Please fill up: ";
            if (Fname.Text == "" || Mname.Text == "" || Lname.Text == "" || cbGender.Text == "" || cbYearLvl.Text == "" || Section.Text == "" || StuAdviser.Text == "" || StuAddress.Text == "" || CpNumber.Text == "")
            {
                if (Fname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "First Name, ");

                }
                if (Mname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Middle Name, ");

                }
                if (Lname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Last Name, ");

                }
                if (cbGender.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Gender, ");

                }
                if (cbYearLvl.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Year Level, ");

                }
                if (Section.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Section, ");

                }
                if (StuAdviser.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Student Adviser, ");

                }
                if (StuAdviser.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Student Adviser, ");

                }
                if (StuAddress.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Address, ");

                }
                if (CpNumber.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Cellphone number, ");

                }
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show(validationContainer += "Picture");
                }

            }
            else
            {

                connection.Open();

                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tbl_student set student_picture = @a1'" + "',student_firstname='" + Fname.Text + "',student_middlename='" + Mname.Text + "',student_lastname='" + Lname.Text + "',student_lastname= '" + Lname.Text + "',student_gender='" + cbGender.Text + "',student_yearlevel='" + cbYearLvl.Text + "',student_section='" + Section.Text + "',student_adviser='" + StuAdviser.Text + "',student_address='" + StuAddress.Text + "',student_CPnumber='" + CpNumber.Text + "' where student_id ='" + StuNumber.Text + "'";
                cmd.Parameters.AddWithValue("@a1", pics);
                
               cmd.CommandText = "update tbl_student set student_firstname='" + Fname.Text + "',student_middlename='" + Mname.Text + "',student_lastname='" + Lname.Text + "',student_lastname= '" + Lname.Text + "',student_gender='" + cbGender.Text + "',student_yearlevel='" + cbYearLvl.Text + "',student_section='" + Section.Text + "',student_adviser='" + StuAdviser.Text + "',student_address='" + StuAddress.Text + "',student_CPnumber='" + CpNumber.Text + "' where student_id ='" + StuNumber.Text + "'";
               cmd.ExecuteNonQuery();
                connection.Close();
                disp_data();
                MessageBox.Show("Updated successfully!");
                Fname.Text = "";
                Mname.Text = "";
                Lname.Text = "";
                cbGender.Text = "";
                cbYearLvl.Text = "";
                Section.Text = "";
                StuAdviser.Text = "";
                StuAddress.Text = "";
                StuNumber.Text = "";
                stucardID.Text = "";
                CpNumber.Text = "";
                pictureBox1.Image = null;

            }
        }
        int click =0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*DataGridViewImageColumn datagrid1 = new DataGridViewImageColumn();
            datagrid1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.Rows.Add(datagrid1);*/
          
            try
            {
            click = e.RowIndex;

            DataGridViewRow clicked = new DataGridViewRow();
            clicked = dataGridView1.Rows[click];

            StuNumber.Text = clicked.Cells[0].Value.ToString();
            stucardID.Text = clicked.Cells[1].Value.ToString();
            Fname.Text = clicked.Cells[2].Value.ToString();
            Mname.Text = clicked.Cells[3].Value.ToString();
            Lname.Text = clicked.Cells[4].Value.ToString();
            cbGender.Text = clicked.Cells[5].Value.ToString();
            cbYearLvl.Text = clicked.Cells[6].Value.ToString();
            Section.Text = clicked.Cells[7].Value.ToString();
            StuAdviser.Text = clicked.Cells[8].Value.ToString();
            StuAddress.Text = clicked.Cells[9].Value.ToString();
            CpNumber.Text = clicked.Cells[10].Value.ToString();
                

         
                var data = (Byte[])(clicked.Cells[11].Value);
                var stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
                pics = ms.ToArray();
               // MessageBox.Show(pics.Length.ToString());
            }
            catch (Exception z)
            {
               
            }
          
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            String validationContainer = "Please fill up: ";
            if (Fname.Text == "" || Mname.Text == "" || Lname.Text == "" || cbGender.Text == "" || cbYearLvl.Text == "" || Section.Text == "" || StuAdviser.Text == "" || StuAddress.Text == "" || CpNumber.Text == "")
            {
                if (Fname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "First Name, ");

                }
                if (Mname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Middle Name, ");

                }
                if (Lname.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Last Name, ");

                }
                if (cbGender.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Gender, ");

                }
                if (cbYearLvl.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Year Level, ");

                }
                if (Section.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Section, ");

                }
                if (StuAdviser.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Student Adviser, ");

                }
                if (StuAdviser.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Student Adviser, ");

                }
                if (StuAddress.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Address, ");

                }
                if (CpNumber.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Cellphone number, ");

                }
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show(validationContainer += "Picture");
                }

            }
            else
            {
                string message = "Do you want to delete this student?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from tbl_student where student_id ='" + StuNumber.Text + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Deleted successfully");
                    disp_data();
                    Fname.Text = "";
                    Mname.Text = "";
                    Lname.Text = "";
                    cbGender.Text = "";
                    cbYearLvl.Text = "";
                    Section.Text = "";
                    StuAdviser.Text = "";
                    StuAddress.Text = "";
                    StuNumber.Text = "";
                    stucardID.Text = "";
                    CpNumber.Text = "";
                    pictureBox1.Image = null;

                }
            }
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "STUDENT NUMBER")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_id like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            else if (cbSearch.Text == "STUDENT CARD ID")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_cardid like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "FIRST NAME")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_firstname like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "MIDDLE NAME")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_middlename like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "LAST NAME")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_lastname like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "GENDER")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_gender like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "YEAR LEVEL")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_yearlevel like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "SECTION")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_section like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "ADVISER")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_adviser like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "ADVISER")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_address like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "CELLPHONE NUMBER")
            {

                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_student where student_CPnumber like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSession_Main navigate = new AdminSession_Main();
            navigate.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //pictureBox1.Invalidate();
            pictureBox1.Image = null;
        }
        public void disp_data()
        {            

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_student";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);           
            connection.Close();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "student_id";
            dataGridView1.Columns[1].DataPropertyName = "student_cardid";
            dataGridView1.Columns[2].DataPropertyName = "student_firstname";
            dataGridView1.Columns[3].DataPropertyName = "student_middlename";
            dataGridView1.Columns[4].DataPropertyName = "student_lastname";
            dataGridView1.Columns[5].DataPropertyName = "student_gender";
            dataGridView1.Columns[6].DataPropertyName = "student_yearlevel";
            dataGridView1.Columns[7].DataPropertyName = "student_section";
            dataGridView1.Columns[8].DataPropertyName = "student_adviser";
            dataGridView1.Columns[9].DataPropertyName = "student_address";
            dataGridView1.Columns[10].DataPropertyName = "student_CPnumber";
            dataGridView1.Columns[11].DataPropertyName = "student_picture";
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dataGridView1.DataSource = dt;

        }

        private void Mname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void StuNumber_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fname.Text = "";
            Mname.Text = "";
            Lname.Text = "";
            cbGender.Text = "";
            cbYearLvl.Text = "";
            Section.Text = "";
            StuAdviser.Text = "";
            StuAddress.Text = "";
            StuNumber.Text = "";
            stucardID.Text = "";
            CpNumber.Text = "";
            pictureBox1.Image = null;
        }

    }
}
