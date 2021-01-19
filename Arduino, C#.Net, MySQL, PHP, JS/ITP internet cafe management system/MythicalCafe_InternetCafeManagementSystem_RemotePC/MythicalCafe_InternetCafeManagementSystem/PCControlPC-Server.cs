using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_InternetCafeManagementSystem
{
    public partial class PCControlPC_Server : Form
    {
        public PCControlPC_Server()
        {
           

            InitializeComponent();

            this.bunifuGradientPanel1.MouseDown += new MouseEventHandler(justMethods.bunifuGradientPanel1_MouseDown);
            this.bunifuGradientPanel1.MouseMove += delegate(object sender, MouseEventArgs e) { justMethods.bunifuGradientPanel1_MouseMove(sender, e, this); };
            this.bunifuGradientPanel1.MouseUp += new MouseEventHandler(justMethods.bunifuGradientPanel1_MouseUp);
        }       

        private void PCControlPC_Server_Load(object sender, EventArgs e)
        {
           
        }  

        private void btn_Listen_Click(object sender, EventArgs e)
        {
            new PCControlPC_Server_ViewClient(int.Parse(txtbx_getPort.text)).Show(); 
        }



        
    }
}
