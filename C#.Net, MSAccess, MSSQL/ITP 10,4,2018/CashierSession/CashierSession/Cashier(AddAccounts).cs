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


namespace Cashier_Register_Reload_
{
    public partial class Cashier_AddAccounts_ : Form
    {
        string val;
        public Cashier_AddAccounts_()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection(methods.con);

        private void Cashier_Main__Load(object sender, EventArgs e)
        {

        }


      string Treatment;

        public void register()
        {

            MessageBox.Show("");
            con.Close();
            con.Open();
           
           
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            if(inputRFID.Text != "" && inputFirstName.Text != "" && inputMiddleName.Text != "" && inputLastName.Text != "" && inputAccessCode.Text != "" && inputBalance.Text != "" )
            {

                MessageBox.Show("");
             
                cmd.CommandText = "insert into carduser(CardNo,FirstName,MiddleName,LastName,Verification,Balance,StudentID,SpecialTreatment) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8)";

                cmd.Parameters.AddWithValue("@a1", inputRFID.Text.Trim());
                cmd.Parameters.AddWithValue("@a2", inputFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@a3", inputMiddleName.Text.Trim());
                cmd.Parameters.AddWithValue("@a4", inputLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@a5", inputAccessCode.Text.Trim());
                cmd.Parameters.AddWithValue("@a6", inputBalance.Text.Trim());
                
                cmd.Parameters.AddWithValue("@a7", gettxtStudentID.Text.Trim());
                cmd.Parameters.AddWithValue("@a8", Treatment.Trim());

                cmd.ExecuteNonQuery();

                inputRFID.Text = "";
                inputFirstName.Text = "";
                inputMiddleName.Text = "";
                inputLastName.Text = "";
                inputAccessCode.Text = "";
                gettxtStudentID.Text = "";
                inputBalance.Text = "";
                none.Checked = false;
                pwd.Checked = false;
                Sr.Checked = false;


             
            }
            else
            {
                MessageBox.Show("Please don`t leave any blank!");
            }
                 
            con.Close();

        

  }

        private void btnRegister_Click(object sender, EventArgs e)
        {
         register();
        }

        string imageloc = "";


        private void btnUpload_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files (*.*)|*.*";
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{

            //    imageloc = dialog.FileName.ToString();
            //    picureBoxPhoto.ImageLocation = imageloc;

            //}
        }


        byte[] images = null;
        public void uploadImg()
        {

            
            FileStream stream = new FileStream(imageloc, FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(230, 0, 153, 204);


            Rectangle r = new Rectangle(0, 0, panel2.Width, panel2.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 30;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            panel2.Region = new Region(gp);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(250, 204, 255, 204);

            Rectangle b = new Rectangle(0, 0, panel3.Width, panel3.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int a = 30;
            gp.AddArc(b.X, b.Y, a, a, 180, 90);
            gp.AddArc(b.X + b.Width - a, b.Y, a, a, 270, 90);
            gp.AddArc(b.X + b.Width - a, b.Y + b.Height - a, a, a, 0, 90);
            gp.AddArc(b.X, b.Y + b.Height - a, a, a, 90, 90);
            panel3.Region = new Region(gp);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

            panel4.BackColor = Color.FromArgb(180, 102, 204, 255);

            Rectangle b = new Rectangle(0, 0, panel4.Width, panel4.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int c = 30;
            gp.AddArc(b.X, b.Y, c, c, 180, 90);
            gp.AddArc(b.X + b.Width - c, b.Y, c, c, 270, 90);
            gp.AddArc(b.X + b.Width - c, b.Y + b.Height - c, c, c, 0, 90);
            gp.AddArc(b.X, b.Y + b.Height - c, c, c, 90, 90);
            panel4.Region = new Region(gp);
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            register();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashier_Main_ a = new Cashier_Main_();
            a.Show();
            this.Hide();
        }

        private void pwd_CheckedChanged(object sender, EventArgs e)
        {
            Treatment = "PWD";
        }

        private void Sr_CheckedChanged(object sender, EventArgs e)
        {
            Treatment = "Senior";
        }

        private void none_CheckedChanged(object sender, EventArgs e)
        {
            Treatment = "None";
        }
    }
}
