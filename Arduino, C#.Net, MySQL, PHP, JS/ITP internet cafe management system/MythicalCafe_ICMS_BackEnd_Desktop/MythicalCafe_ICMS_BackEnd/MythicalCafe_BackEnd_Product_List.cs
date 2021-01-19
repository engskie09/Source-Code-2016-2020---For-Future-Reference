using Bunifu.Framework.UI;
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
    public partial class MythicalCafe_BackEnd_Product_List : Form
    {
        public MythicalCafe_BackEnd_Product_List()
        {
            InitializeComponent();
        }

        private void MythicalCafe_BackEnd_Product_List_Load(object sender, EventArgs e)
        {
            Size = new Size(Parent.Size.Width, Parent.Size.Height);

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Product_Search, txtbx_Product_Search.Text);

            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);

            cmbx_Search_Filter.SelectedIndex = 0;

            set_dgv_Product_Value();
        }

        public String Action = null;

        List<String> get_ImagePath_List = new List<String>();

        Int32 Counter =  0;       

        public void set_dgv_Product_Value()
        {
            get_ImagePath_List.Clear();

            MythicalCafe_BackEnd_Product_Manage_List_Method.select_Product_Information("Select : All", "");

            get_ImagePath_List = (from row in MythicalCafe_BackEnd_Product_Manage_List_Method.Product_DataTable_1.AsEnumerable() select row["Product_Image_Path"].ToString()).ToList();

            DataColumn get_DataColumn = new DataColumn();
            get_DataColumn.ColumnName = "Product_Image_Path";
            get_DataColumn.DataType = typeof(Byte[]);
            get_DataColumn.AllowDBNull = true;

            MythicalCafe_BackEnd_Product_Manage_List_Method.Product_DataTable_1.Columns.Remove("Product_Image_Path");

            MythicalCafe_BackEnd_Product_Manage_List_Method.Product_DataTable_1.Columns.Add(get_DataColumn);

            Counter = 0;

            foreach (DataRow set_DataRow in MythicalCafe_BackEnd_Product_Manage_List_Method.Product_DataTable_1.Rows)
            {

                if (Counter + 1 > get_ImagePath_List.Count)
                    break;

                if (File.Exists(get_ImagePath_List[Counter]))
                {
                    using (Bitmap set_Bitmap = new Bitmap(get_ImagePath_List[Counter]))
                    {
                        MythicalCafe_BackEnd_Product_Manage_List_Method.Product_DataTable_1.Rows[Counter]["Product_Image_Path"] = new ImageConverter().ConvertTo(set_Bitmap, typeof(Byte[]));
                        Counter++;
                    }
                }
                else
                    Counter++;
            }

            dgv_Product.DataSource = null;

            dgv_Product.AutoGenerateColumns = false;

            dgv_Product.Columns["Product_Image"].DataPropertyName = "Product_Image_Path";
            dgv_Product.Columns["Product_Identity"].DataPropertyName = "Product_Identity";
            dgv_Product.Columns["Product_Name"].DataPropertyName = "Product_Name";
            dgv_Product.Columns["Product_Quantity"].DataPropertyName = "Product_Quantity";
            dgv_Product.Columns["Product_Price_Cash"].DataPropertyName = "Product_Price_Cash";
            dgv_Product.Columns["Product_Price_Point"].DataPropertyName = "Product_Price_Point";
            dgv_Product.Columns["Product_Category"].DataPropertyName = "Product_Category";
            dgv_Product.Columns["Product_Description"].DataPropertyName = "Product_Description";
            dgv_Product.Columns["Product_Status"].DataPropertyName = "Product_Status";

            dgv_Product.DataSource = MythicalCafe_BackEnd_Product_Manage_List_Method.Product_DataTable_1;
        }

        JObject Product_Information = null;

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (!(e.RowIndex >= 0))
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Product.Rows[e.RowIndex];

            if (Action == "Update Product")
            {                
                //Call select_Customer_Personal_Information();
                Product_Information = JObject.Parse(MythicalCafe_BackEnd_Product_Manage_List_Method.select_Product_Information("Select : Specific", get_DataGridViewRow.Cells[1].Value.ToString()));
                Product_Information = JObject.Parse(Product_Information["Table"].ToString().TrimStart('[').TrimEnd(']'));

                MythicalCafe_BackEnd_Product_Manage_List get_Product_Manage_List = new MythicalCafe_BackEnd_Product_Manage_List("") { Product_Information = Product_Information };

                get_Product_Manage_List.get_Action("Update Product");

                if (get_Product_Manage_List.ShowDialog() == DialogResult.OK)
                {
                    set_dgv_Product_Value();

                    Action = null;
                }
            }

            if (Action == "Delete Product")
            {
                MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Are You sure to Delete this Product?");

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    MythicalCafe_BackEnd_Product_Manage_List_Method.delete_Product_Information(get_DataGridViewRow.Cells[1].Value.ToString());

                    MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                    (
                        "Account",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                        "Deleted Product *" + get_DataGridViewRow.Cells[1].Value.ToString() + "*"
                    );

                    MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                    (
                        "Product",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        get_DataGridViewRow.Cells[1].Value.ToString(),
                        "Product has deleted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                    );

                    set_dgv_Product_Value();

                    Action = null;
                }
            }
        }

        private void txtbx_Product_Search_OnValueChanged(object sender, EventArgs e)
        {
            BunifuMetroTextbox get_TextBox = (BunifuMetroTextbox)sender;

            String get_TextBox_Value = get_TextBox.Text.Trim();

            get_TextBox.Text = get_TextBox_Value;

            String get_RowFilter = null;

            if (get_TextBox_Value == "Search Product")
            {
                get_RowFilter = "Product_Identity LIKE '%{0}%' OR Product_Name LIKE '%{0}%' OR Convert(Product_Quantity, System.String) LIKE '%{0}%' OR Convert(Product_Price_Cash, System.String) LIKE '%{0}%' OR Convert(Product_Price_Point, System.String) LIKE '%{0}%' OR Product_Category LIKE '%{0}%' OR Product_Description LIKE '%{0}%' OR Product_Status LIKE '%{0}%'";
                get_TextBox_Value = "";
            }
            else if (cmbx_Search_Filter.Text == "All")
                get_RowFilter = "Product_Identity LIKE '%{0}%' OR Product_Name LIKE '%{0}%' OR Convert(Product_Quantity, System.String) LIKE '%{0}%' OR Convert(Product_Price_Cash, System.String) LIKE '%{0}%' OR Convert(Product_Price_Point, System.String) LIKE '%{0}%' OR Product_Category LIKE '%{0}%' OR Product_Description LIKE '%{0}%' OR Product_Status LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "ID")
                get_RowFilter = "Product_Identity LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Name")
                get_RowFilter = "Product_Name LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Quantity")
                get_RowFilter = "Convert(Product_Quantity, System.String) LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "M-Cash")
                get_RowFilter = "Convert(Product_Price_Cash, System.String) LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Points")
                get_RowFilter = "Convert(Product_Price_Point, System.String) LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Category")
                get_RowFilter = "Product_Category LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Description")
                get_RowFilter = "Product_Description LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Status")
                get_RowFilter = "Product_Status LIKE '%{0}%'";


            (dgv_Product.DataSource as DataTable).DefaultView.RowFilter = string.Format(get_RowFilter, get_TextBox_Value);

        }
    }
}
    