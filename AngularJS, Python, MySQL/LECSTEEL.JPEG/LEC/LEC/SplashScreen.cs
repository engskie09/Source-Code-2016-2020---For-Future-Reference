using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEC
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public SplashScreen()
        {
            InitializeComponent();
        }

        static string serverAddress = "127.0.0.1";
        static string databaseName = "lec";
        static string databaseUsername = "root";
        static string databasePassword = "";
        static string connectionString = "Server='" + serverAddress + "';Database='" + databaseName + "';Uid='" + databaseUsername + "';Pwd='" + databasePassword + "';";

        Main main = new Main();
        
        void loadSupplierDirectory()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM dbSupplier", connection);
            

            adapter.Fill(main.tableSupplierDirectory);
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            loadSupplierDirectory();

            for (int i = 0; i < 100; i++)
            {

                
                backgroundWorker1.ReportProgress(i);

                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }

            backgroundWorker1.ReportProgress(100);
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            customizedProgressBar1.Value = e.ProgressPercentage;
            label1.Text = "Initializing database... "+ customizedProgressBar1.Value.ToString() + "%";
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
               
            }

            else if (e.Error == null)
            {
                this.Hide();
                main.Show();
            }
        }
    }
}
