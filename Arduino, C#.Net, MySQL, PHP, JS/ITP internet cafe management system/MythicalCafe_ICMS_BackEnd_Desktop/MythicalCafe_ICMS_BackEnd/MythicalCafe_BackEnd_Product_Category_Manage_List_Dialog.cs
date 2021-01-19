using Bunifu.Framework.UI;
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
    public partial class MythicalCafe_BackEnd_Product_Category_Manage_List_Dialog : Form
    {
        public MythicalCafe_BackEnd_Product_Category_Manage_List_Dialog()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Product_Category_Manage_List_Dialog_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };
        }

        MythicalCafe_BackEnd_Product_List Product_List = (Application.OpenForms[new MythicalCafe_BackEnd_Product_List().Name] as MythicalCafe_BackEnd_Product_List);

        private void btn_Action_Click(object sender, EventArgs e)
        {
            BunifuFlatButton get_Button = (BunifuFlatButton) sender;

            MythicalCafe_BackEnd_Product_Category_Manage_List get_Product_Category_Manage_List = new MythicalCafe_BackEnd_Product_Category_Manage_List(get_Button.Text);

            if (get_Product_Category_Manage_List.ShowDialog() == DialogResult.OK)
            {
                Product_List.set_dgv_Product_Value();

                Close();
            }
        }
    }
}
