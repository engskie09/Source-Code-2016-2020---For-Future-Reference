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
    public partial class MythicalCafe_BackEnd_Product : Form
    {
        public MythicalCafe_BackEnd_Product()
        {
            InitializeComponent();
        }

        public void MythicalCafe_BackEnd_Product_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Size = new Size(Parent.Size.Width, Parent.Size.Height);

            MythicalCafe_Control_Propety.set_Panel_Container(pnl_Product_Container, Form_Name, "");
        }

        public void MythicalCafe_BackEnd_Product_SizeChanged(object sender, EventArgs e)
        {
            MythicalCafe_Control_Propety.set_Panel_Container_Size(Form_Name, pnl_Product_Container);
        }

        public String Form_Name = new MythicalCafe_BackEnd_Product_List().Name;

        private void btn_Product_Manage_Click(object sender, EventArgs e)
        {            

            new MythicalCafe_BackEnd_Product_Manage_List_Dialog().ShowDialog();
        }

        private void btn_Category_Manage_Click(object sender, EventArgs e)
        {            
            new MythicalCafe_BackEnd_Product_Category_Manage_List_Dialog().ShowDialog();
        }

        private void btn_Product_Order_Queue_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Product_Order_List().ShowDialog();
        }

        private void btn_Product_Log_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Log_List() { Log_Type_String = "Product" }.ShowDialog();

            /*if (!MythicalCafe_BackEnd_Main_Method.Staff_Position_Privilege.Contains("View Product Log"))
            {
                new MythicalCafe_BackEnd_Dialog("Message: Sorry you don`t have privilege to access this.").ShowDialog();
                return;
            }    */
        }
    }
}
