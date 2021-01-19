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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();

        }
        public static String connectionString = "server=localhost;userid=root;database=db_jplhs_librarysystem";

        private static MySqlConnection connection = new MySqlConnection(connectionString);
        DataSet ds = new DataSet();
        private void Add_Click(object sender, EventArgs e)
        {




            String validationContainer = "Please fill up: ";
            if (BookTitletxt.Text == "" || author.Text == "" || Category.Text == "" || Publisher.Text == "" || PlaceOfPublishing.Text == "" || cbBookLvl.Text == "" || Copies.Text == "")
            {
                if (BookTitletxt.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Book Title, ");

                }
                if (author.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Author, ");

                }
                if (Category.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Category, ");

                }
                if (Publisher.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Publisher, ");

                }
                if (PlaceOfPublishing.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Place Of Publishing, ");

                }
                if (cbBookLvl.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += "Book level, ");

                }
                if (Copies.Text.Trim() == "")
                {
                    MessageBox.Show(validationContainer += " Copies, ");

                }

            }
            else
            {

                MySqlCommand cmd1 = connection.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "select * from tbl_book where book_id='" + BkIDtxt.Text + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;

                if (i > 0)
                {
                    MessageBox.Show("Book Existed!");
                    ds.Clear();
                    BkIDtxt.Text = "";
                    BookTitletxt.Text = "";
                    author.Text = "";
                    Category.Text = "";
                    Publisher.Text = "";
                    PlaceOfPublishing.Text = "";
                    cbBookLvl.Text = "";
                    Copies.Text = "";
                }
                else
                {
                    try
                    {
                        Random r = new Random();
                        int nums = r.Next(1000, 9999);
                        BkIDtxt.Text = "BK-" + nums.ToString();
                        connection.Open();
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into tbl_book values('" + BkIDtxt.Text + "','" + BookTitletxt.Text + "','" + author.Text + "','" + Category.Text + "','" + Publisher.Text + "','" + PlaceOfPublishing.Text + "','" + cbBookLvl.Text + "','" + Copies.Text + "')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        disp_data();
                        MessageBox.Show("Book Added!");
                        BkIDtxt.Text = "";
                        BookTitletxt.Text = "";
                        author.Text = "";
                        Category.Text = "";
                        Publisher.Text = "";
                        PlaceOfPublishing.Text = "";
                        cbBookLvl.Text = "";
                        Copies.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }
        public void disp_data()
        {

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tbl_book";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
        int click = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            click = e.RowIndex;

            DataGridViewRow clicked = new DataGridViewRow();
            clicked = dataGridView1.Rows[click];

            BkIDtxt.Text = clicked.Cells[0].Value.ToString();
            BookTitletxt.Text = clicked.Cells[1].Value.ToString();
            author.Text = clicked.Cells[2].Value.ToString();
            Category.Text = clicked.Cells[3].Value.ToString();
            Publisher.Text = clicked.Cells[4].Value.ToString();
            PlaceOfPublishing.Text = clicked.Cells[5].Value.ToString();
            cbBookLvl.Text = clicked.Cells[6].Value.ToString();
            Copies.Text = clicked.Cells[7].Value.ToString();

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            disp_data();
        }


        private void Update_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update tbl_book set book_title='" + BookTitletxt.Text + "',book_author='" + author.Text + "',book_category='" + Category.Text + "',book_publisher='" + Publisher.Text + "',book_placeofpublishing='" + PlaceOfPublishing.Text + "',book_level='" + cbBookLvl.Text + "',book_totalcopies='" + Copies.Text + "' where book_id ='" + BkIDtxt.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            disp_data();
            MessageBox.Show("Book Updated!");
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this book?";
            string title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from tbl_book where book_id ='" + BkIDtxt.Text + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Book Deleted!");
                disp_data();
                
            }


        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "BOOK ID")
            {
                  
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_id like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "TITLE")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_title like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }

            else if (cbSearch.Text == "AUTHOR")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_author like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "CATEGORY")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_category like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "PUBLISHER")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_publisher like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "PLACE OF PUBLISHING")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_placeofpublishing like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "LEVEL")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_level like '%" + Search.Text + "%'", connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (cbSearch.Text == "COPIES")
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("select * from tbl_book where book_totalcopies like '%" + Search.Text + "%'", connection);
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BkIDtxt.Text = "";
BookTitletxt.Text = "";
author.Text = "";
Category.Text = "";
Publisher.Text = "";
PlaceOfPublishing.Text = "";
cbBookLvl.Text = "";
Copies.Text = "";
        }
    }
}
