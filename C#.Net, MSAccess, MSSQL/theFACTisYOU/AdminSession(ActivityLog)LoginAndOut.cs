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
using System.IO;
namespace theFACTisYOU
{
    public partial class AdminSession_ActivityLog_LoginAndOut : Form
    {
        public AdminSession_ActivityLog_LoginAndOut()
        {
            InitializeComponent();
            hahahaNuisanceXD();
        }

        
        OleDbConnection HelloSayoXD = new OleDbConnection(LoginSession.x);


        public void hahahaNuisanceXD()
        {
            HelloSayoXD.Open();
            DataTable heyHello = new DataTable();
            OleDbCommand sorryForBeingAnnoying = HelloSayoXD.CreateCommand();
            OleDbDataAdapter ByeexD = new OleDbDataAdapter(sorryForBeingAnnoying);
            sorryForBeingAnnoying.CommandType = CommandType.Text;
            sorryForBeingAnnoying.CommandText = "select * from AdminLogFile";
            sorryForBeingAnnoying.ExecuteNonQuery();
            ByeexD.Fill(heyHello);

            logDatagrid.AutoGenerateColumns = false;


            logDatagrid.Columns[0].DataPropertyName = "Admin_Name_Session";
            logDatagrid.Columns[1].DataPropertyName = "Time_Log_InOut";
            logDatagrid.Columns[2].DataPropertyName = "Date_Log_InOut";
            logDatagrid.Columns[3].DataPropertyName = "Note";

            logDatagrid.DataSource = heyHello;

            HelloSayoXD.Close();

        }

        private void AdminSession_ActivityLog_LoginAndOut_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 100, 96);
            pictureBox1.ImageLocation = LoginSession.propaylPIC;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Hi " + LoginSession.propaylNEYM;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminSession xD = new AdminSession();
            xD.Show();
            this.Hide();
        }

        private void timexD_Tick(object sender, EventArgs e)
        {
            string taym = DateTime.Now.ToLongTimeString();
            string deyt = DateTime.Now.ToShortDateString();
            string deytaym = taym + " " + deyt;
            orasanXD.Text = deytaym;
        }

        public void ByeSTIxDDDDDDDDDD()
        {
          /**
                DataTable dt = new DataTable();

                HelloSayoXD.Close();
                HelloSayoXD.Open();
                //invisibleDatexD.Value = DateTime.Parse(halanahulog.Text).AddDays(-1);

                OleDbCommand cmd = HelloSayoXD.CreateCommand();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from AdminLogFile where Date_Log_InOut between @a1 and @a2 ";
                // datefrom.Value = DateTime.Parse(datefrom.Text).AddDays(-1);
               // cmd.Parameters.AddWithValue("@a1", invisibleDatexD.Value.ToShortDateString());
              //  cmd.Parameters.AddWithValue("@a2", loglogloglog.Value.ToShortDateString());
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                //dateTimePickerDOB.Text = DateTime.Parse(dateTimePickerAdmission.Text).AddDays(-1).ToString();

                logDatagrid.Columns[0].DataPropertyName = "ID";
                logDatagrid.Columns[1].DataPropertyName = "Admin_Name_Session";
                logDatagrid.Columns[2].DataPropertyName = "Time_Log_InOut";
                logDatagrid.Columns[3].DataPropertyName = "Date_Log_InOut";
                logDatagrid.Columns[4].DataPropertyName = "Note";

                logDatagrid.DataSource = dt;



                HelloSayoXD.Close();
          **/



        }

        private void halanahulog_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ByeSTIxDDDDDDDDDD();
            }
            catch
            {
            }
        }

        private void loglogloglog_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                ByeSTIxDDDDDDDDDD();
            }
            catch
            {
            }
        }
    }
}
