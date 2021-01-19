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
    public partial class AdminSession_Employee_List_ : Form
    {
        public AdminSession_Employee_List_()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection();

        private void AddWorker_Click(object sender, EventArgs e)
        {
            Form check = Application.OpenForms["AdminSession_Employee_List_Add"];
            Form checkx = Application.OpenForms["AdminSession_Employee_List_Update"];
            if (check != null || checkx != null)
            {
                MessageBox.Show(" AnotherForm already Opened");
            }

            else
            {
                AdminSession_Employee_List_Add xB = new AdminSession_Employee_List_Add();
                xB.Show();
                

            }
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            Form check = Application.OpenForms["AdminSession_Employee_List_Update"];
            Form checkx = Application.OpenForms["AdminSession_Employee_List_Add"];
            if (check != null || checkx != null)
            {
                MessageBox.Show("Another Form already Opened");
            }

            else
            {
                AdminSession_Employee_List_Update xB = new AdminSession_Employee_List_Update();
                xB.Show();


            }

          

        }

        DataTable dt = new DataTable();

        public void empShowxD()
        {


            connection.Close();
            connection.Open();

            OleDbCommand cmd = connection.CreateCommand();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PersonelsMain";
            cmd.ExecuteNonQuery();

            da.Fill(dt);

            empDatagrid.AutoGenerateColumns = false;

            empDatagrid.Columns[0].DataPropertyName = "EmployeeID";
            empDatagrid.Columns[1].DataPropertyName = "CompleteName";
            empDatagrid.Columns[2].DataPropertyName = "CompleteAddress";
            empDatagrid.Columns[3].DataPropertyName = "Birthdate";
            empDatagrid.Columns[4].DataPropertyName = "Age";
            empDatagrid.Columns[5].DataPropertyName = "Gender";
            empDatagrid.Columns[6].DataPropertyName = "Contact_No";
            empDatagrid.Columns[7].DataPropertyName = "Designation";
            empDatagrid.Columns[8].DataPropertyName = "Date_Hired";
            empDatagrid.DataSource = dt;



            connection.Close();

        }

        private void timestart_Tick(object sender, EventArgs e)
        {
            timeToday.Text = DateTime.Now.ToLongTimeString();
            datetoday.Text = DateTime.Now.ToShortDateString();
        }

        private void AdminSession_Employee_List__Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(LoginPayroll.qwe);

            pictureBox1.ImageLocation = LoginPayroll.profilePIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = LoginPayroll.profileName;
            timestart.Start();

            empShowxD();
        }

        private void returnBack_Click(object sender, EventArgs e)
        {

            Form check = Application.OpenForms["AdminSession_Employee_List_Add"];

            if (check != null)
            {
                check.Close();
            }

            AdminSession xD = new AdminSession();

            xD.Show();
           
            this.Hide();
        }

        int selectedidxD;
        public static string selectaWalangLasaPotek = "";
        private void empDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedidxD = e.RowIndex;

            DataGridViewRow selectz = empDatagrid.Rows[selectedidxD];

            selectaWalangLasaPotek = selectz.Cells[0].Value.ToString();
            selectedID.Text = selectaWalangLasaPotek;

        }

       
    }
}
