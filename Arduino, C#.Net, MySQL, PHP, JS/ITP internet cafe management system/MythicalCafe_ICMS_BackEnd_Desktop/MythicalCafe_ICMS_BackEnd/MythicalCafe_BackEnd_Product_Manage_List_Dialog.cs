using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Product_Manage_List_Dialog : Form
    {
        public MythicalCafe_BackEnd_Product_Manage_List_Dialog()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Product_Manage_List_Dialog_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };
        }

        MythicalCafe_BackEnd_Product Product = (Application.OpenForms[new MythicalCafe_BackEnd_Product().Name] as MythicalCafe_BackEnd_Product);
        MythicalCafe_BackEnd_Product_List Product_List = (Application.OpenForms[new MythicalCafe_BackEnd_Product_List().Name] as MythicalCafe_BackEnd_Product_List);

        private void btn_Display_Click(object sender, EventArgs e)
        {
            Product.Form_Name = new MythicalCafe_BackEnd_Product_List().Name;
            Product.Load += new EventHandler(Product.MythicalCafe_BackEnd_Product_Load);
            Product.SizeChanged += new EventHandler(Product.MythicalCafe_BackEnd_Product_SizeChanged);

            Close();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Product_Manage_List("Insert Product").ShowDialog();

            Product_List.set_dgv_Product_Value();

            Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Product_List.Action = "Update Product";

            Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Product_List.Action = "Delete Product";

            Close();
        }        
    }
}
