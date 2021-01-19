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
    public partial class LoginSession : Form
    {
       
        public LoginSession()
        {
            InitializeComponent();


        }

        

        public static string propaylPIC = "";
        public static string propaylNEYM = "";
        int bilang;

        public static string x = "";

        public static string blankpicture = @"T:\bulbulito\theFACTisYOU\theFACTisYOU\engskiexD\walaXD.png";

       
        OleDbConnection koneksyon;
        
        public void engskie()
        {
            koneksyon.Close();
            koneksyon.Open();
            DataSet xD = new DataSet();
            OleDbDataAdapter qwerty = new OleDbDataAdapter("select * from AdminLogFile" ,koneksyon);

            qwerty.Fill(xD);

           bilang = xD.Tables[0].Rows.Count + 1 ;
            

            koneksyon.Close();
        }

        /**
        public void SELECTA()
        {


            HelloSayoXD.Close();
            HelloSayoXD.Open();
            OleDbCommand cmd = HelloSayoXD.CreateCommand();
            cmd = HelloSayoXD.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from ProductCategories WHERE Product_Category= '" + label9.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {




                categoryNAME.Text = xdr["Product_Category"].ToString();
                Category_Description2.Text = xdr["Product_Category_Description"].ToString();
                EKSBIhaha = Convert.ToInt32(xdr["ID"].ToString());
            }
            HelloSayoXD.Close();


        }**/

        public void SetPropaylPicture()
        {
            koneksyon.Close();
            koneksyon.Open();
            
            OleDbCommand cmd = koneksyon.CreateCommand();
            cmd = koneksyon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from AdminAccount WHERE Admin_Name= '" + Admin_Name.Text.Trim() +"'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {


                propaylPIC = xdr["Admin_Picture"].ToString();
                propaylNEYM = xdr["Admin_Name"].ToString();
            
            }
            koneksyon.Close();
        }

        public void loginAsAdminxD()
        {
            counter++;
            koneksyon.Close();
            koneksyon.Open();
            OleDbDataAdapter tigaAngkop = new OleDbDataAdapter("select * from AdminAccount where Admin_Name= '" + Admin_Name.Text.Trim() + "' and Admin_Password= '" + Admin_Password.Text.Trim() + "'", koneksyon);

            DataTable mesa = new DataTable();
            tigaAngkop.Fill(mesa);
            if (mesa.Rows.Count == 1)
            {


                koneksyon.Close();

                string admin = Admin_Name.Text.Trim();
                string time = DateTime.Now.ToString("hh;mm;ss tt");
                string date = DateTime.Now.ToShortDateString();
                string note = "Login";
                engskie();
                koneksyon.Open();
                OleDbCommand utos = new OleDbCommand("insert into AdminLogFile values ('" + bilang + "','" + admin + "','" + time + "','" + date + "','" + note + "')", koneksyon);

                utos.ExecuteNonQuery();


                koneksyon.Close();
                SetPropaylPicture();
                AdminSession XD = new AdminSession();
                XD.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Check your username and password");
                koneksyon.Close();
                return;
            }

            koneksyon.Close();



            Admin_Name.Text = "";
            Admin_Password.Text = "";


        }


        int counter = 0;
        private void Login_Click(object sender, EventArgs e)
        {
            if (counter != 2)
            {
                if (Designation.Text == "Admin")
                {
                    loginAsAdminxD();

                    Admin_Name.Text = "";
                    Admin_Password.Text = "";
                }

                else if (Designation.Text == "Staff")
                {

                    Admin_Name.Text = "";
                    Admin_Password.Text = "";
                }

                else if (Designation.Text == "")
                {

                    Admin_Name.Text = "";
                    Admin_Password.Text = "";

                    MessageBox.Show("Select Designation");
                }

                else
                {
                    MessageBox.Show("Invalid");

                    Admin_Name.Text = "";
                    Admin_Password.Text = "";
                }
            }

            else if (counter == 2)
            {

                MessageBox.Show("You are trying too often. Please try again later.");
                Application.Exit();

            }

          
           
          


            Admin_Name.Text = "";
            Admin_Password.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginSession_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);

            lalalahlah.istringkoneksyon();
            x = lalalahlah.kuneksyun;
            koneksyon = new OleDbConnection(x);
            
        }


        public void loginAsStaffxD()
        {
            counter++;
            koneksyon.Close();
            koneksyon.Open();
            OleDbDataAdapter tigaAngkop = new OleDbDataAdapter("select * from StaffsAccounts where Staff_Name= '" + Admin_Name.Text.Trim() + "' and Staff_Password= '" + Admin_Password.Text.Trim() + "'", koneksyon);

            DataTable mesa = new DataTable();
            tigaAngkop.Fill(mesa);
            if (mesa.Rows.Count == 1)
            {


                koneksyon.Close();

                string admin = Admin_Name.Text.Trim();
                string time = DateTime.Now.ToString("hh;mm;ss tt");
                string date = DateTime.Now.ToShortDateString();
                string note = "Login";
                engskie();
                koneksyon.Open();
                OleDbCommand utos = new OleDbCommand("insert into AdminLogFile values ('" + bilang + "','" + admin + "','" + time + "','" + date + "','" + note + "')", koneksyon);

                utos.ExecuteNonQuery();


                koneksyon.Close();
                SetPropaylPictureStaffs();
                AdminSession XD = new AdminSession();
                XD.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Check your username and password");
                koneksyon.Close();
                return;
            }

            koneksyon.Close();



            Admin_Name.Text = "";
            Admin_Password.Text = "";


        }

        public void SetPropaylPictureStaffs()
        {
            koneksyon.Close();
            koneksyon.Open();

            OleDbCommand cmd = koneksyon.CreateCommand();
            cmd = koneksyon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from StaffsAccounts WHERE Staff_Name= '" + Admin_Name.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {


                propaylPIC = xdr["Staff_Picture"].ToString();
                propaylNEYM = xdr["Staff_Name"].ToString();

            }
            koneksyon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForgotPassword xD = new ForgotPassword();
            xD.Show();
            this.Hide();
        }

       
    }
}
