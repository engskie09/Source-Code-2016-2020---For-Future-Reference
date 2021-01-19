using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_UserControl_Product_View : Form
    {
        public MythicalCafe_FrontEnd_UserControl_Product_View()
        {
            InitializeComponent();
        }

        private void MythicalCafe_FrontEnd_UserControl_Product_View_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);            

            set_Product_Information();
        }

        public Image Product_Image
        {
            get { return pctbx_Image.Image; }
            set { pctbx_Image.Image = value; }
        }

        public JObject Product_Information = null;

        void set_Product_Information()
        {      
            lbl_Product_Name.Text = Product_Information["Product_Name"].ToString();
            lbl_Price_Cash.Text = "Price (M-Cash): " + Product_Information["Product_Price_Cash"].ToString();
            lbl_Price_Point.Text = "Price (Points): " + Product_Information["Product_Price_Point"].ToString();
            lbl_Description.Text = "Description: " + Product_Information["Product_Description"].ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Choice: Buy product using ?");
            get_Dialog.btn_Ok.Text = "M-Cash.";
            get_Dialog.btn_No.Text = "Points.";

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                get_Dialog = new MythicalCafe_FrontEnd_Dialog("Input: Quantity");
                get_Dialog.btn_Ok.Text = "Add to Cart";
                get_Dialog.btn_No.Text = "Cancel";

                MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(get_Dialog.txt_Action);

                MythicalCafe_Control_Propety.set_TextBox_KeyDown_Length_Maximum(get_Dialog.txt_Action, 2);

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    MythicalCafe_FrontEnd_Main get_Main = (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main);

                    String get_Product_Quantity = get_Dialog.Action_Value;

                    if (get_Product_Quantity == "Quantity" || get_Product_Quantity == "0")
                        return;

                    get_Main.insert_DataTable_Main
                    (
                        Product_Image,
                        Product_Information["Product_Identity"].ToString(),
                        Product_Information["Product_Name"].ToString(),
                        Product_Information["Product_Price_Cash"].ToString(),
                        get_Product_Quantity,
                        Product_Information["Product_Price_Point"].ToString(),
                        "0"
                    );
                }
            }

            else if (get_Dialog.DialogResult == DialogResult.No)
            {
                get_Dialog = new MythicalCafe_FrontEnd_Dialog("Input: Quantity");
                get_Dialog.btn_Ok.Text = "Add to Cart";
                get_Dialog.btn_No.Text = "Cancel";

                MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(get_Dialog.txt_Action);

                MythicalCafe_Control_Propety.set_TextBox_KeyDown_Length_Maximum(get_Dialog.txt_Action, 2);

                MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(get_Dialog.txt_Action);

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    MythicalCafe_FrontEnd_Main get_Main = (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main);

                    String get_Product_Quantity = get_Dialog.Action_Value;

                    if (get_Product_Quantity == "Quantity" || get_Product_Quantity == "0")
                        return;                  
                        

                    get_Main.insert_DataTable_Main
                    (
                        Product_Image,
                        Product_Information["Product_Identity"].ToString(),
                        Product_Information["Product_Name"].ToString(),
                        Product_Information["Product_Price_Cash"].ToString(),
                        "0",
                        Product_Information["Product_Price_Point"].ToString(),
                        get_Product_Quantity
                    );
                }
            }

            Close();
        }
    }
}
