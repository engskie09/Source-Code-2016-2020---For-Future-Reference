using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeyRole
{
    public partial class AdminSession_Employee_List_Update : Form
    {
        public AdminSession_Employee_List_Update()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection();

        string selectedratecode = "";
        private void UpdateEmployee_Click(object sender, EventArgs e)
        {

            selectRateCode();

            string gender = "";
            string datehired = DateTime.Now.ToShortDateString();
            string rateCode = selectedratecode;
            string picture = stringPicture;

            string completeAddress = edificeno.Text.Trim() + " " + roadname.Text.Trim() + " St, " + brgyname.Text.Trim() + ", " + cityname.Text.Trim() + " City.";
            string completeName = fname.Text.Trim() + " " + lname.Text.Trim() + " " + mi.Text.Trim() + ".";

            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "update PersonelsMain Set First_Name = @a2, Last_Name = @a3, Middle_Initial = @a4, Edifice_Number = @a5, Road_Name = @a6, Baranggay_Name = @a7, City_Name = @a8, Birthdate = @a9, Gender = @a10, Contact_No = @a11, Designation = @a12, Rate_Code = @a14, Picture = @a15, CompleteAddress = @a16, CompleteName = @a17, age = @a18 where EmployeeID = @19";
            
            command.Parameters.AddWithValue("@a2", fname.Text.Trim());
            command.Parameters.AddWithValue("@a3", lname.Text.Trim());
            command.Parameters.AddWithValue("@a4", mi.Text.Trim());
            command.Parameters.AddWithValue("@a5", edificeno.Text.Trim());
            command.Parameters.AddWithValue("@a6", roadname.Text.Trim());
            command.Parameters.AddWithValue("@a7", brgyname.Text.Trim());
            command.Parameters.AddWithValue("@a8", cityname.Text.Trim());
            command.Parameters.AddWithValue("@a9", bdayPICK.Text.Trim());
            command.Parameters.AddWithValue("@a10", gender);
            command.Parameters.AddWithValue("@a11", contactno.Text.Trim());
            command.Parameters.AddWithValue("@a12", comboBoxDesignation.Text.Trim());
            command.Parameters.AddWithValue("@a14", rateCode);
            command.Parameters.AddWithValue("@a15", picture);
            command.Parameters.AddWithValue("@a16", completeAddress);
            command.Parameters.AddWithValue("@a17", completeName);
            command.Parameters.AddWithValue("@a18", bdayage.Text.Trim());
            command.Parameters.AddWithValue("@a19", autoEmp.Text.Trim());

            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Update Successful");



            Form xD = Application.OpenForms["AdminSession_Employee_List_"];
            xD.Close();
            AdminSession_Employee_List_ xB = new AdminSession_Employee_List_();
            xB.Show();
            Close();
        }
        string selectedID = AdminSession_Employee_List_.selectaWalangLasaPotek;
        string stringBday = "", stringGender = "", stringPicture = "";
        public void tobeUpdateEmp()
        {
            

            connection.Close();

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from PersonelsMain WHERE EmployeeID= '" + selectedID +"'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

               autoEmp.Text = xdr["EmployeeID"].ToString();
               fname.Text = xdr["First_Name"].ToString();
               lname.Text = xdr["Last_Name"].ToString();
               mi.Text = xdr["Middle_Initial"].ToString();
               edificeno.Text = xdr["Edifice_Number"].ToString();
               roadname.Text = xdr["Road_Name"].ToString();
               brgyname.Text = xdr["Baranggay_Name"].ToString();
               cityname.Text = xdr["City_Name"].ToString();
               stringBday = xdr["Birthdate"].ToString();
               stringGender = xdr["Gender"].ToString();
               contactno.Text = xdr["Contact_No"].ToString();
               comboBoxDesignation.Text = xdr["Designation"].ToString();
               bdayage.Text = xdr["Age"].ToString();
               stringPicture = xdr["Picture"].ToString();




            }
            connection.Close();

            if (stringGender == "Male")
                radioMale.Checked = true;
            else if (stringGender == "Female")
                radioFemale.Checked = true;
        
            string[] birthday = stringBday.Split('/');
            int month, day, year;
            int.TryParse(birthday[0], out month);
            int.TryParse(birthday[1], out day);
            int.TryParse(birthday[2], out year);
            bdayPICK.Value = new DateTime(year,month,day);


            pictureBoxEmployee.ImageLocation = stringPicture;
           pictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            

        

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



        private void AdminSession_Employee_List_Update_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(LoginPayroll.qwe);
            filldesignation();
            tobeUpdateEmp();
            
            
        }
        
  

        private void buttonUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog XB = new OpenFileDialog();

            String LOLS = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            XB.Filter = LOLS;

            if (XB.ShowDialog() == DialogResult.OK)
            {
                stringPicture = XB.FileName.ToString();

                pictureBoxEmployee.ImageLocation = stringPicture;
                pictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
               
            }
        }

        private void undopicture_Click(object sender, EventArgs e)
        {
            stringPicture = LoginPayroll.defaultimage;

            pictureBoxEmployee.ImageLocation = stringPicture;
            pictureBoxEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
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
                bdayPICK.Value = new DateTime(1900, 1, 1);
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

        private void edificeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.numberOnly(sender, e);
        }

        private void contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.numberOnly(sender, e);
        }

        private void comboBoxDesignation_TextChanged(object sender, EventArgs e)
        {
            selectRateCode();
        }

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

    }
}
