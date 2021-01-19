using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace MythicalCafe_InternetCafeManagementSystem
{
    public partial class PCControlPC_Client : Form
    {
        public PCControlPC_Client()
        {
            InitializeComponent();          

            this.bunifuGradientPanel1.MouseDown += new MouseEventHandler(justMethods.bunifuGradientPanel1_MouseDown);

            this.bunifuGradientPanel1.MouseMove += delegate(object sender, MouseEventArgs e)
            {
                justMethods.bunifuGradientPanel1_MouseMove(sender, e, this); 
            };

            this.bunifuGradientPanel1.MouseUp += new MouseEventHandler(justMethods.bunifuGradientPanel1_MouseUp);
        }

        private void PCControlPC_Client_Load(object sender, EventArgs e)
        {
            
        }

        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainstream;
        private int portNumber;

        private static Image GrabDestop()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;

            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);

            Graphics graphic = Graphics.FromImage(screenshot);

            graphic.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);

            return screenshot;
        }

        private void SendDestopImage()       
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            mainstream = client.GetStream();
            binFormatter.Serialize(mainstream, GrabDestop());
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            portNumber = int.Parse(txtbx_getPort.text.Trim());

            try
            {
                client.Connect(txtbx_getIP.text.Trim(), portNumber);

                MessageBox.Show("Connected!");
            }

            catch (Exception set_Exception)
            {
                MessageBox.Show("Failed to Connect: " + set_Exception.ToString());
            }
        }

        private void btn_ShareMyScreen_Click(object sender, EventArgs e)
        {
            if (btn_ShareMyScreen.Text.StartsWith("Share"))
            {
                timer1.Start();
                btn_ShareMyScreen.Text = "Stop Sharing";
            }

            else
            {
                timer1.Stop();
                btn_ShareMyScreen.Text = "Share My Screen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDestopImage();
        }  

        private void btn_ShowServer_Click(object sender, EventArgs e)
        {
            new PCControlPC_Server().Show();
        }
    }
}
