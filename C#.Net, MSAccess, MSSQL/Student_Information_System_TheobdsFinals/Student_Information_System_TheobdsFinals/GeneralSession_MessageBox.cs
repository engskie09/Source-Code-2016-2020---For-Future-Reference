using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System_TheobdsFinals
{
    public partial class GeneralSession_MessageBox : Form
    {
        public GeneralSession_MessageBox(String get_msgbxTitle, String get_msgbxContent)
        {
            InitializeComponent();

            this.txt_setTitle.Text = get_msgbxTitle;
            this.txt_setDescription.Text = get_msgbxContent;
        }

        private void GeneralSession_MessageBox_Load(object sender, EventArgs e)
        {
            pnl_titleContainer.Left = (this.ClientSize.Width - pnl_titleContainer.Width) / 2;
            btn_Ok.Left = (this.ClientSize.Width - pnl_titleContainer.Width) / 2;

            MessageBox.Show(ClientSize.Width.ToString());

            btn_Ok.Top = pnl_contentContainer.Height + 70;
        }

        public static void Show(String get_msgbxTitle, String get_msgbxContent)
        {
            using (Form messageBox = new GeneralSession_MessageBox(get_msgbxTitle, get_msgbxContent))
            {
                messageBox.ShowDialog();
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
