using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Product_Manage_List : Form
    {
        public MythicalCafe_BackEnd_Product_Manage_List(String set_Action)
        {
            InitializeComponent();


            get_Action(set_Action);
            set_Control_Property();
        }

        private void MythicalCafe_BackEnd_Product_Manage_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };
                        
        }

        void set_Control_Property()
        {
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Product_Name, txtbx_Product_Name.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Product_Quantity, txtbx_Product_Quantity.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Product_Price_Cash, txtbx_Product_Price_Cash.Text);
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Product_Price_Point, txtbx_Product_Price_Point.Text);            
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Product_Description, txtbx_Product_Description.Text);

            pnl_Product_Identity.BorderColoreFocused = Color.White;
            pnl_Product_Identity.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            pnl_Product_Category.BorderColoreFocused = Color.White;
            pnl_Product_Category.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            pnl_Product_Image.BorderColoreFocused = Color.White;
            pnl_Product_Image.BorderColoreIdle = Color.FromArgb(17, 202, 168);
        }

        public JObject Product_Information = null;

        public void get_Action(String set_Action)
        {
            if (set_Action == "Insert Product")
            {
                btn_Action.Text = "Insert Product";

                lbl_Product_Identity.Text = MythicalCafe_BackEnd_Main_Method.Product_Identity_Code + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Product_Identity_Code) + 1000).ToString();
            }

            else if (set_Action == "Update Product")
            {                
                btn_Action.Text = "Update Product";

                lbl_Product_Identity.Text = Product_Information["Product_Identity"].ToString();
                txtbx_Product_Name.Text = Product_Information["Product_Name"].ToString();
                txtbx_Product_Quantity.Text = Product_Information["Product_Quantity"].ToString();
                txtbx_Product_Price_Cash.Text = Product_Information["Product_Price_Cash"].ToString();
                txtbx_Product_Price_Point.Text = Product_Information["Product_Price_Point"].ToString();
                Product_Category_Identity = Product_Information["Category_Identity"].ToString();
                lbl_Product_Category.Text = Product_Information["Product_Category"].ToString();
                txtbx_Product_Description.Text = Product_Information["Product_Description"].ToString();

                if (Product_Information["Product_Status"].ToString() == "Active")
                    chkbx_Product_Status.Checked = true;
                else
                    chkbx_Product_Status.Checked = false;

                if (File.Exists(Product_Information["Product_Image_Path"].ToString()))
                {
                    get_ImagePath = Product_Information["Product_Image_Path"].ToString();

                    using (FileStream set_FileStream = new FileStream(Product_Information["Product_Image_Path"].ToString(), FileMode.Open, FileAccess.Read))
                    {
                        MemoryStream = new MemoryStream();

                        btn_Product_Image.Image = Image.FromStream(set_FileStream);
                        btn_Product_Image.Image.Save(MemoryStream, btn_Product_Image.Image.RawFormat);

                        get_ImagePath = "Images/" + lbl_Product_Identity.Text + ".png";
                    }
                }
            }

            else if (set_Action == "Delete Product")
                btn_Action.Text = "Delete Product";

            else
                return;
        }

        String[] Product_Information_Array = new String[0];

        void get_Product_Information_Value()
        {
            if (btn_Action.Text == "Insert Product")
            {
                Product_Information_Array = new String[10];

                Product_Information_Array[1] = lbl_Product_Identity.Text.Trim();
                Product_Information_Array[2] = txtbx_Product_Name.Text.Trim();
                Product_Information_Array[3] = txtbx_Product_Quantity.Text.Trim();
                Product_Information_Array[4] = txtbx_Product_Price_Cash.Text.Trim();
                Product_Information_Array[5] = txtbx_Product_Price_Point.Text.Trim();
                Product_Information_Array[6] = Product_Category_Identity;
                Product_Information_Array[7] = txtbx_Product_Description.Text.Trim();

                if (chkbx_Product_Status.Checked)
                    Product_Information_Array[8] = "Active";

                else
                    Product_Information_Array[8] = "Inactive";

                Product_Information_Array[9] = get_ImagePath;
            }

            else if (btn_Action.Text == "Update Product")
            {
                Product_Information_Array = new String[11];

                Product_Information_Array[1] = "Update : Specific";
                Product_Information_Array[2] = lbl_Product_Identity.Text.Trim();
                Product_Information_Array[3] = txtbx_Product_Name.Text.Trim();
                Product_Information_Array[4] = txtbx_Product_Quantity.Text.Trim();
                Product_Information_Array[5] = txtbx_Product_Price_Cash.Text.Trim();
                Product_Information_Array[6] = txtbx_Product_Price_Point.Text.Trim();
                Product_Information_Array[7] = Product_Category_Identity;
                Product_Information_Array[8] = txtbx_Product_Description.Text.Trim();

                if (chkbx_Product_Status.Checked)
                    Product_Information_Array[9] = "Active";

                else
                    Product_Information_Array[9] = "Inactive";

                Product_Information_Array[10] = get_ImagePath;
            }

            else if (btn_Action.Text == "Delete Product")
            {
                Product_Information_Array = new String[2];
                Product_Information_Array[1] = lbl_Product_Identity.Text.Trim();
            }

            else
                return;

            
        }

        MemoryStream MemoryStream = null;

        String get_ImagePath = null;

        void get_Image()
        {
            OpenFileDialog get_OpenFileDialog = new OpenFileDialog();

            get_OpenFileDialog.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *.png; *.gif";

            if (get_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream set_FileStream = new FileStream(get_OpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    MemoryStream = new MemoryStream();

                    btn_Product_Image.Image = Image.FromStream(set_FileStream);
                    btn_Product_Image.Image.Save(MemoryStream, btn_Product_Image.Image.RawFormat);

                    get_ImagePath = "Images/" + lbl_Product_Identity.Text + ".png";
                }
            }
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            get_Product_Information_Value();

            MythicalCafe_BackEnd_Main_Method.check_Directory_Availability(MythicalCafe_BackEnd_Main_Method.Image_Directory_Path);

            if (btn_Action.Text == "Insert Product")
            {
                
                MythicalCafe_BackEnd_Product_Manage_List_Method.insert_Product_Information
                (
                    Product_Information_Array[1],
                    Product_Information_Array[2],
                    Product_Information_Array[3],
                    Product_Information_Array[4],
                    Product_Information_Array[5],
                    Product_Information_Array[6],
                    Product_Information_Array[7],
                    Product_Information_Array[8],
                    Product_Information_Array[9]

                );

                if (!Object.ReferenceEquals(MemoryStream, null) && !String.IsNullOrEmpty(get_ImagePath))
                {
                    File.WriteAllBytes(get_ImagePath, MemoryStream.ToArray());

                    MemoryStream.Close();
                }
                
                MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Product_Identity_Code);


                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Inserted Product *" + Product_Information_Array[1] + "*"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Product_Information_Array[1],
                    "Product has inserted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                );
            }

            else if (btn_Action.Text == "Update Product")
            {
                MythicalCafe_BackEnd_Product_Manage_List_Method.update_Product_Information
                (
                    Product_Information_Array[1],
                    Product_Information_Array[2],
                    Product_Information_Array[3],
                    Product_Information_Array[4],
                    Product_Information_Array[5],
                    Product_Information_Array[6],
                    Product_Information_Array[7],
                    Product_Information_Array[8],
                    Product_Information_Array[9],
                    Product_Information_Array[10]

                );

                if (!Object.ReferenceEquals(MemoryStream, null) && !String.IsNullOrEmpty(get_ImagePath))
                {
                    File.WriteAllBytes(get_ImagePath, MemoryStream.ToArray());

                    MemoryStream.Close();
                }

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Updated Product *" + Product_Information_Array[2] + "*"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Product_Information_Array[2],
                    "Product has updated by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                );
            }

            else if (btn_Action.Text == "Delete Product")
            {
                MythicalCafe_BackEnd_Product_Manage_List_Method.delete_Product_Information(Product_Information_Array[1]);
                
                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Deleted Product *" + Product_Information_Array[1] + "*"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Product_Information_Array[1],
                    "Product has deleted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                );
            }

            DialogResult = DialogResult.OK;

            Close();
        }

        private void get_Product_Image_Click(object sender, EventArgs e)
        {
            get_Image();
        }

        String Product_Category_Identity = null;

        private void Product_Category_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Product_Category_Manage_List get_Product_Category_Manage_List = new MythicalCafe_BackEnd_Product_Category_Manage_List("Select Category");

            if (get_Product_Category_Manage_List.ShowDialog() == DialogResult.OK)
            {
                Product_Category_Identity = get_Product_Category_Manage_List.Category_Identity_String;
                lbl_Product_Category.Text = get_Product_Category_Manage_List.Category_Name_String;                
            }
        }
    }
}
