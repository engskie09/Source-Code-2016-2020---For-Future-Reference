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
using System.Threading;
using System.Net;

namespace MythicalCafe_InternetCafeManagementSystem
{
    public partial class PCControlPC_Server_ViewClient : Form
    {
        public PCControlPC_Server_ViewClient(Int32 set_Port)
        {
            port = set_Port;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);

            InitializeComponent();

            this.bunifuGradientPanel1.MouseDown += new MouseEventHandler(justMethods.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += delegate(object sender, MouseEventArgs e) { justMethods.bunifuGradientPanel1_MouseMove(sender, e, this); };
            this.bunifuGradientPanel1.MouseUp += new MouseEventHandler(justMethods.bunifuGradientPanel1_MouseUp);

        }       

        private void PCControlPC_Server_ViewClient_Load(object sender, EventArgs e)
        {           
            server = new TcpListener(IPAddress.Any, port);
            Listening.Start();


        }

        private void PCControlPC_Server_ViewClient_FormClosing(object sender, FormClosingEventArgs e)
        {      
            StopListening();
        }

        public Int32 port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainstream;

        private readonly Thread Listening;
        private readonly Thread GetImage;

        private void StartListening()
        {
            while (!client.Connected)
            {
                server.Start();
                client = server.AcceptTcpClient();
            }

            GetImage.Start();
        }

        private void StopListening()
        {
            server.Stop();

            client = null;

            if (Listening.IsAlive) 
                Listening.Abort();

            if (GetImage.IsAlive) 
                GetImage.Abort();
        }

        private void ReceiveImage()
        {
            BinaryFormatter binformatter = new BinaryFormatter();

            while (client.Connected)
            {
                mainstream = client.GetStream();
                pictureBox1.Image = (Image) binformatter.Deserialize(mainstream);
            }
        }      

      
    }
}
