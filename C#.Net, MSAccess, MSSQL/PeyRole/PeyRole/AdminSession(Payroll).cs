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
    public partial class AdminSession_Payroll_ : Form
    {
        public AdminSession_Payroll_()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection();

        /*
        public void hahahaNuisanceXD()
        {



            HelloSayoXD.Open();

            OleDbCommand sorryForBeingAnnoying = HelloSayoXD.CreateCommand();
            OleDbDataAdapter ByeexD = new OleDbDataAdapter(sorryForBeingAnnoying);
            sorryForBeingAnnoying.CommandType = CommandType.Text;
            sorryForBeingAnnoying.CommandText = "select * from ProductInventory";
            sorryForBeingAnnoying.ExecuteNonQuery();

            ByeexD.Fill(heyHello);

            HuehueXD.AutoGenerateColumns = false;


            HuehueXD.Columns[0].DataPropertyName = "ID";
          


            HuehueXD.DataSource = heyHello;



            HelloSayoXD.Close();

        }*/

        public void xD()
        {
            connection.Close();
            connection.Open();

            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from DesignationRateCode";
            command.ExecuteNonQuery();

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dvDesignation.AutoGenerateColumns = false;

            dvDesignation.Columns[0].DataPropertyName = "ID";
            dvDesignation.Columns[1].DataPropertyName = "Designation";
            dvDesignation.Columns[2].DataPropertyName = "Rate_Code";

            dvDesignation.DataSource = dt;

            connection.Close();



        }
        public void fillRateCode()
        {
            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Rate_Code from RateCodeMain";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();
                comboBoxRateCode.Items.Add(x);
            }

            connection.Close();

        }
       

        private void AdminSession_Payroll__Load(object sender, EventArgs e)
        {

            connection = new OleDbConnection(LoginPayroll.qwe);
            xD();
            fillRateCode();
            pictureBox1.ImageLocation = LoginPayroll.profilePIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label3.Text = LoginPayroll.profileName;
            timestart.Start();
            panelRateMaintenance.Visible = false;
         

        }

        private void timestart_Tick(object sender, EventArgs e)
        {
            timeToday.Text = DateTime.Now.ToLongTimeString();
            datetoday.Text = DateTime.Now.ToShortDateString();
        }

        private void returnBack_Click(object sender, EventArgs e)
        {
            AdminSession xD = new AdminSession();
            xD.Show();
            this.Hide();
        }

        private void buttonRateMaintenance_Click(object sender, EventArgs e)
        {

            if (panelRateMaintenance.Visible)
            {
                panelRateMaintenance.Visible = false;
            }

            else
            {
                panelRateMaintenance.Visible = true;
                panelDesignationMaintenance.Visible = false;
            }
            panelRateMaintenance.Location = new Point(405, 22);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelRateMaintenance.Visible = false;
        }

        private void buttonAddDesignation_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into DesignationRateCode (Designation, Rate_Code) Values (a1,a2)";
            command.Parameters.AddWithValue("@a1", Designation_A.Text.Trim());
            command.Parameters.AddWithValue("@a2", RateCode_A.Text.Trim());
            command.ExecuteNonQuery();             
            connection.Close();

            xD();

            Designation_A.Text = "";
            RateCode_A.Text = "";
        

        }

      


        
        int selected;
        string xselected = "";
        private void dvDesignation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            DataGridViewRow xD = dvDesignation.Rows[selected];
            xselected = xD.Cells[0].Value.ToString();
            Designation_B.Text = xD.Cells[1].Value.ToString();
            RateCode_B.Text = xD.Cells[2].Value.ToString();
        }

        private void buttonDesignationMaintenance_Click(object sender, EventArgs e)
        {
            if (panelDesignationMaintenance.Visible)
            {
                panelDesignationMaintenance.Visible = false;
            }

            else
            {
                panelDesignationMaintenance.Visible = true;
                panelRateMaintenance.Visible = false;
               
            }
            panelDesignationMaintenance.Location = new Point(405, 22);
        }

        private void buttonUpdateDesignation_Click(object sender, EventArgs e)
        {


            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "update DesignationRateCode set Designation = @x1, Rate_Code = @x2 where ID = @x3 ";
            command.Parameters.AddWithValue("@a1", Designation_B.Text.Trim());
            command.Parameters.AddWithValue("@a2", RateCode_B.Text.Trim());
            command.Parameters.AddWithValue("@a3", xselected);
            command.ExecuteNonQuery();
            connection.Close();

            xD();

            Designation_B.Text = "";
            RateCode_B.Text = "";
            xselected = "";
        }

        private void buttonDeleteDesignation_Click(object sender, EventArgs e)
        {

            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "Delete from DesignationRateCode where ID = a1 ";
            command.Parameters.AddWithValue("@a1", xselected);

            command.ExecuteNonQuery();
            connection.Close();
            xselected = "";
            xD();
        }

        private void Designation_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e, Designation_A.Text.Trim());
        }

        private void Designation_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.letterOnly(sender, e);
            validations.uppercaseFirstLetter(sender, e,Designation_B.Text.Trim());
        }

        public void selectRateCode()
        {

            connection.Close();

            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from RateCodeMain WHERE Rate_Code= '" + comboBoxRateCode.Text.Trim() +"'";
            cmd.ExecuteNonQuery();
            DataTable xdt = new DataTable();
            OleDbDataAdapter xda = new OleDbDataAdapter(cmd);
            xda.Fill(xdt);

            foreach (DataRow xdr in xdt.Rows)
            {

              txtnoWorkingHoursRate.Text = xdr["No_Working_Hours"].ToString();
              txtBasicPayRate.Text = xdr["Basic_Pay"].ToString();
              txtOvertimeRate.Text = xdr["Overtime_Pay"].ToString();
              txtSundayRate.Text = xdr["Sunday_Rate"].ToString();
              txtHolidayRate.Text = xdr["Holiday_Rate"].ToString();
              txtAllowance.Text = xdr["Allowance"].ToString();             
               getsss  = xdr["SSS"].ToString();
               getpagibig  = xdr["Pagibig"].ToString();                
               getphilhealth  = xdr["Philhealth"].ToString();
                




            }
            connection.Close();


        }


        string getsss = "";
        string getpagibig = "";
        string getphilhealth = "";

        private void comboBoxRateCode_TextChanged(object sender, EventArgs e)
        {

            selectRateCode();

            if (getsss == "1")
                includeSSS.Checked = true;
            else
                includeSSS.Checked = false;

            if (getpagibig == "1")
                includePagibig.Checked = true;
            else
                includePagibig.Checked = false;

            if (getphilhealth == "1")
                includePhilhealth.Checked = true;
            else
                includePhilhealth.Checked = false;

        }

        private void txtaddRateCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            validations.numberOnly(sender, e);
        }

        public void tukmol()
        {

            connection.Close();
            connection.Open();

            OleDbCommand kurikongxD = connection.CreateCommand();
            DataTable deadsxD = new DataTable();
            kurikongxD.CommandType = CommandType.Text;
            kurikongxD.CommandText = "select Rate_Code from RateCodeMain";
            kurikongxD.ExecuteNonQuery();


            OleDbDataAdapter popo = new OleDbDataAdapter(kurikongxD);
            popo.Fill(deadsxD);

            foreach (DataRow dragon in deadsxD.Rows)
            {
                string x = dragon[0].ToString();

                if (x == telebong)
                {
                    itsTRUE = false;
                    break;
                }
            }

            connection.Close();

        }


        bool itsTRUE = true;
        string telebong = "";

        private void buttonRateCode_Click(object sender, EventArgs e)
        {
            telebong = "000" + txtaddRateCode.Text.Trim();
            tukmol();

            if (txtaddRateCode.Text != "")
            {
                if (itsTRUE)
                {


                    connection.Close();
                    connection.Open();
                    OleDbCommand command = connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into RateCodeMain (Rate_Code) Values (a1)";
                    command.Parameters.AddWithValue("@a1", telebong);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {

                    MessageBox.Show("Rate Code Already Exist");

                }

                
                comboBoxRateCode.Items.Clear();
                fillRateCode();
            }
            else
            {

                MessageBox.Show("Invalid");

            }


            txtaddRateCode.Clear();
            itsTRUE = true;



        }

        private void buttonUpdateRateCode_Click(object sender, EventArgs e)
        {
          

            if (includeSSS.Checked)
                getsss = "1";
            else
                getsss = "0";

            if (includePagibig.Checked)
                getpagibig = "1";
            else
                getpagibig = "0";

            if (includePhilhealth.Checked)
                getphilhealth = "1";
            else
                getphilhealth = "0";

            connection.Close();
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "update RateCodeMain set No_Working_Hours = @a1, Basic_Pay = @a2 , Overtime_Pay = @a3, Sunday_Rate = @a4, Holiday_Rate = @a5, Allowance = @a6, SSS = @a7, Pagibig = @a8, Philhealth = @a9   where Rate_Code = @a10 ";
            command.Parameters.AddWithValue("@a1", txtnoWorkingHoursRate.Text.Trim());
            command.Parameters.AddWithValue("@a2", txtBasicPayRate.Text.Trim());
            command.Parameters.AddWithValue("@a3", txtOvertimeRate.Text.Trim());
            command.Parameters.AddWithValue("@a4", txtSundayRate.Text.Trim());
            command.Parameters.AddWithValue("@a5", txtHolidayRate.Text.Trim());
            command.Parameters.AddWithValue("@a6", txtAllowance.Text.Trim());
            command.Parameters.AddWithValue("@a7", getsss);
            command.Parameters.AddWithValue("@a8", getpagibig);
            command.Parameters.AddWithValue("@a9", getphilhealth);
            command.Parameters.AddWithValue("@a10", comboBoxRateCode.Text.Trim());

            command.ExecuteNonQuery();
       


            connection.Close();
          
      
     
       
           

            /**
        string getsss;
        string getpagibig ;
        string getphilhealth;
             * 
             * 
             * 
             * 
             * 
           */




        }
    }
}
