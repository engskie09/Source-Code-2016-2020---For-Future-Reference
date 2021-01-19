using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_UserControl_Product : UserControl
    {
        public MythicalCafe_FrontEnd_UserControl_Product()
        {
            InitializeComponent();
        }

        private void MythicalCafe_FrontEnd_UserControl_Product_Load(object sender, EventArgs e)
        {
            Margin = new Padding(40, 30, 15, 15);
        }

        public Image Product_Image
        {
            get { return pctbx_Image.Image; }
            set { pctbx_Image.Image = value; }
        }

        public String Product_Name
        {
            get { return btn_Name.Text.Remove(0, 5); }
            set { btn_Name.Text = value; }
        }

        public JObject Product_Information = null;

        private void btn_Name_Click(object sender, EventArgs e)
        {
            MythicalCafe_FrontEnd_UserControl_Product_View get_UserControl_Product_View = new MythicalCafe_FrontEnd_UserControl_Product_View();

            get_UserControl_Product_View.Product_Image = Product_Image;
            get_UserControl_Product_View.Product_Information = Product_Information;
            get_UserControl_Product_View.ShowDialog();
        }
    }
}
