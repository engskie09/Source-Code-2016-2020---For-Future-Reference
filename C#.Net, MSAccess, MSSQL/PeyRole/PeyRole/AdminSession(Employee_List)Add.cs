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

namespace PeyRole
{
    public partial class AdminSession_Employee_List_Add : Form
    {
        public AdminSession_Employee_List_Add()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection();


        int puyatersXD = 0;
        public void paengtuts()
        {

            puyatersXD = 0;

            connection.Close();
            connection.Open();
            OleDbCommand wahahahaha = connection.CreateCommand();
            wahahahaha = connection.CreateCommand();
            wahahahaha.CommandType = CommandType.Text;
            wahahahaha.CommandText = "SELECT * from EmpIDcounter WHERE Emp= '1'";
            wahahahaha.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(wahahahaha);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                puyatersXD = Convert.ToInt32(xdr["EmpIDCounts"].ToString());

            }

            puyatersXD += 1;
            MessageBox.Show(puyatersXD.ToString());


            wahahahaha.CommandText = "UPDATE EmpIDcounter SET EmpIDCounts= '" + puyatersXD + "' Where Emp= '1' ";

            wahahahaha.ExecuteNonQuery();

            connection.Close();
        }

        private void bdayPICK_ValueChanged(object sender, EventArgs e)
        {
            
            int years = DateTime.Now.Year - bdayPICK.Value.Year;


            if (bdayPICK.Value.AddYears(years) > DateTime.Now)
            {
                years--;
            }
            if (years == 118) return;
            if (years <= 18)
            {
                bdayage.Text = years.ToString();
                MessageBox.Show("Age " + years.ToString() + " is not suitable to work!");
                bdayPICK.Value = new DateTime(1900,1,1);
                bdayage.Text = "---------------";
                return;
            }

            else if (years >= 65)
            {

                bdayage.Text = years.ToString();
                MessageBox.Show("Age " + years.ToString() + " is not suitable to work!");
                bdayPICK.Value = new DateTime(1900, 1, 1);
                bdayage.Text = "---------------";
                return;

            }


            bdayage.Text = years.ToString();

           

        }

        private void edificeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.numberOnly(sender, e);
        }

        private void roadname_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e, roadname.Text.Trim());
        }

        private void brgyname_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e, brgyname.Text.Trim());
        }

        private void cityname_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e, cityname.Text.Trim());
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e, fname.Text.Trim());
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e, lname.Text.Trim());
        }

        private void mi_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e, mi.Text.Trim());
        }

        private void contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.numberOnly(sender, e);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void xB()
        {
            puyatersXD = 0;

            connection.Close();
            connection.Open();
            OleDbCommand wahahahaha = connection.CreateCommand();
            wahahahaha = connection.CreateCommand();
            wahahahaha.CommandType = CommandType.Text;
            wahahahaha.CommandText = "SELECT * from EmpIDcounter WHERE Emp= '1'";
            wahahahaha.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(wahahahaha);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                puyatersXD = Convert.ToInt32(xdr["EmpIDCounts"].ToString());

            }

            puyatersXD += 1;
            MessageBox.Show(puyatersXD.ToString());

            wahahahaha.ExecuteNonQuery();

            connection.Close();


        }


        private void AdminSession_Employee_List_Add_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(LoginPayroll.qwe);
            xB();
            autoEmp.Text = "Emp000" + puyatersXD.ToString();
            filldesignation();            
     
        }
        
        public void filldesignation()
        {

            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Designation from DesignationRateCode";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();
                comboBoxDesignation.Items.Add(x);
            }

            connection.Close();

        }

        string selectedratecode = "";
        public void selectRateCode()
        {
            connection.Close();

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from DesignationRateCode WHERE Designation= '" + comboBoxDesignation.Text.Trim() + "'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

                selectedratecode = xdr["Rate_Code"].ToString();
                

            }
            connection.Close();


        }

        private void ApplyWorker_Click(object sender, EventArgs e)
        {
            string gender = "";
            string datehired = DateTime.Now.ToShortDateString();
            string rateCode = selectedratecode;
            string picture = defaultimage;

            string completeAddress = edificeno.Text.Trim() + " " + roadname.Text.Trim() + " St, " + brgyname.Text.Trim() + ", " + cityname.Text.Trim() + " City.";
            string completeName = fname.Text.Trim() + " " + lname.Text.Trim() + " " + mi.Text.Trim() +".";
            

            if(radioMale.Checked)
            gender = "Male";         
            else if(radioFemale.Checked)
            gender = "Female";
            else if(gender == "") 
            {
                MessageBox.Show("Select a Gender.");
                return;
            }
            
                
            paengtuts();

            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into PersonelsMain (EmployeeID, First_Name, Last_Name, Middle_Initial, Edifice_Number, Road_Name, Baranggay_Name, City_Name, Birthdate, Gender, Contact_No, Designation, Date_Hired, Rate_Code, Picture, CompleteAddress, CompleteName, age) Values (a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13,a14,a15,a16,a17,a18)";
            command.Parameters.AddWithValue("@a1",  autoEmp.Text.Trim());
            command.Parameters.AddWithValue("@a2",  fname.Text.Trim());
            command.Parameters.AddWithValue("@a3",  lname.Text.Trim());
            command.Parameters.AddWithValue("@a4",  mi.Text.Trim());
            command.Parameters.AddWithValue("@a5",  edificeno.Text.Trim());
            command.Parameters.AddWithValue("@a6",  roadname.Text.Trim());
            command.Parameters.AddWithValue("@a7",  brgyname.Text.Trim());
            command.Parameters.AddWithValue("@a8",  cityname.Text.Trim());
            command.Parameters.AddWithValue("@a9",  bdayPICK.Text.Trim());
            command.Parameters.AddWithValue("@a10", gender );
            command.Parameters.AddWithValue("@a11", contactno.Text.Trim());
            command.Parameters.AddWithValue("@a12", comboBoxDesignation.Text.Trim());
            command.Parameters.AddWithValue("@a13", datehired);
            command.Parameters.AddWithValue("@a14", rateCode);
            command.Parameters.AddWithValue("@a15", picture);
            command.Parameters.AddWithValue("@a16", completeAddress);
            command.Parameters.AddWithValue("@a17", completeName);
            command.Parameters.AddWithValue("@a18", bdayage.Text.Trim());

            command.ExecuteNonQuery();
            connection.Close();         
            Close();

            Form xD = Application.OpenForms["AdminSession_Employee_List_"];
            xD.Close();
            AdminSession_Employee_List_ xB = new AdminSession_Employee_List_();
            xB.Show();
            

           
            
        }

        string defaultimage = LoginPayroll.defaultimage;
        bool meron = true;
        private void buttonUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog XB = new OpenFileDialog();

            String LOLS = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            XB.Filter = LOLS;

            if (XB.ShowDialog() == DialogResult.OK)
            {
                defaultimage = XB.FileName.ToString();

                pictureBoxEmployee.ImageLocation = defaultimage;
                pictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
                meron = false;
            }
        }

        private void comboBoxDesignation_TextChanged(object sender, EventArgs e)
        {
            selectRateCode();
        }

        private void r(object sender, EventArgs e)
        {

        }

        private void undopicture_Click(object sender, EventArgs e)
        {

            if (meron == false)
            {
                defaultimage = (@"T:\PeyRole\PeyRole\picturesXD\walaXD.png");

                pictureBoxEmployee.ImageLocation = defaultimage;
                pictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {

                MessageBox.Show("No Picture to Undo");

            }
            
        }


        

     
        

      



       

        

     
    }
}
