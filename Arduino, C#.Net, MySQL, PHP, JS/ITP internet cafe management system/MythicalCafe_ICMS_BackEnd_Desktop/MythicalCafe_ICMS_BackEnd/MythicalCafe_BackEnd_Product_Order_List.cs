using Newtonsoft.Json;
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
    public partial class MythicalCafe_BackEnd_Product_Order_List : Form
    {
        public MythicalCafe_BackEnd_Product_Order_List()
        {
            InitializeComponent();            
        }

        private void MythicalCafe_BackEnd_Product_Order_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);

            set_dgv_Product_Order_Property();
        }

        List<String> ImagePath_List = new List<String>();

        Int32 Counter = 0;

        void set_dgv_Product_Order_Property()
        {
            ImagePath_List.Clear();

            MythicalCafe_BackEnd_Product_Order_Manage_List_Method.select_Product_Order_Information("Select : All : Pending", "", "");

            if (MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows.Count == 0)
            {
                new MythicalCafe_BackEnd_Dialog("Message: There is no Current Order.").ShowDialog();

                Close();
            }


            if (MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows.Count > 0)
            {
                JArray get_JArray_1 = JArray.Parse(JsonConvert.SerializeObject(MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows[0].Table, Formatting.Indented));


                foreach (JObject get_JObject in get_JArray_1)
                {
                    JArray get_JArray_2 = JArray.Parse(get_JObject["Order_List"].ToString());

                    String get_String = null;

                    foreach (JObject set_JObject in get_JArray_2)
                    {
                        get_String += MythicalCafe_BackEnd_Product_Manage_List_Method.select_Product_Information("Select : Specific { Product_Name }", set_JObject["Product_Identity"].ToString()) + ", ";
                    }

                    get_String = get_String.Trim().TrimEnd(',');

                    DataRow get_DataRow = MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows[Counter];

                    get_DataRow["Order_List"] = get_String;

                    Counter++;
                }

            }
            //MessageBox.Show(JsonConvert.SerializeObject(MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows[0], Formatting.Indented));

            ImagePath_List = (from row in MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.AsEnumerable() select row["Customer_Image_Path"].ToString()).ToList();

            DataColumn get_DataColumn_Customer_Image_Path = new DataColumn();
            get_DataColumn_Customer_Image_Path.ColumnName = "Customer_Image_Path";
            get_DataColumn_Customer_Image_Path.DataType = typeof(Byte[]);
            get_DataColumn_Customer_Image_Path.AllowDBNull = true;

            MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Columns.Remove("Customer_Image_Path");

            MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Columns.Add(get_DataColumn_Customer_Image_Path);

            Counter = 0;

            foreach (DataRow set_DataRow in MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows)
            {
                if (Counter + 1 > ImagePath_List.Count)
                    break;

                if (File.Exists(ImagePath_List[Counter]))
                {
                    using (Bitmap set_Bitmap = new Bitmap(ImagePath_List[Counter]))
                    {
                        MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows[Counter]["Customer_Image_Path"] = new ImageConverter().ConvertTo(set_Bitmap, typeof(Byte[]));
                        Counter++;
                    }
                }
                else
                    Counter++;
            }            

            dgv_Product_Order.DataSource = null;

            dgv_Product_Order.AutoGenerateColumns = false;

            dgv_Product_Order.Columns["Customer_Image"].DataPropertyName = "Customer_Image_Path";
            dgv_Product_Order.Columns["Order_Identity"].DataPropertyName = "Order_Identity";
            dgv_Product_Order.Columns["Customer_Identity"].DataPropertyName = "Customer_Identity";
            dgv_Product_Order.Columns["Customer_FullName"].DataPropertyName = "Customer_FullName";
            dgv_Product_Order.Columns["Order_List"].DataPropertyName = "Order_List";

            dgv_Product_Order.DataSource = MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1;

        }

        private void dgv_Product_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Product_Order.Rows[e.RowIndex];

            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: What do You want to do?");

            get_Dialog.btn_Ok.Text = "View Order";
            get_Dialog.btn_No.Text = "Decline Order";

            Opacity = 0;

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                MythicalCafe_BackEnd_Product_Order_Manage_List get_Product_Order_Manage_List = new MythicalCafe_BackEnd_Product_Order_Manage_List();
                get_Product_Order_Manage_List.Customer_Identity = get_DataGridViewRow.Cells["Customer_Identity"].Value.ToString();
                get_Product_Order_Manage_List.DataTable_Index_Current = e.RowIndex;

                if (get_Product_Order_Manage_List.ShowDialog() == DialogResult.OK)
                {
                    Close();
                }         
            }

            else if (get_Dialog.DialogResult == DialogResult.No)
            {
                get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Are You sure? ^_^ ?");
                get_Dialog.btn_Ok.Text = "Yes";

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    if (MythicalCafe_BackEnd_Product_Order_Manage_List_Method.update_Product_Order_Information("Update : Specific : Order_Status", get_DataGridViewRow.Cells["Order_Identity"].Value.ToString(), "", "", "Declined"))
                    {
                        String get_Customer_ContactNumber = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Personal_Information("Select : Specific { Contact Number }", get_DataGridViewRow.Cells["Customer_Identity"].Value.ToString());

                        String get_Message = DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\nUnfortunately your order " + get_DataGridViewRow.Cells["Order_List"].Value.ToString() + " has been declined by the Assigned staff\nBranch: " + MythicalCafe_BackEnd_Main_Method.Branch_Identity;

                        MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_ShortMessageService_Message(get_Customer_ContactNumber, get_Message);

                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Account",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                            "Declined Order *" + get_DataGridViewRow.Cells["Order_Identity"].Value.ToString() + "*"
                        );

                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Product",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            get_DataGridViewRow.Cells["Order_Identity"].Value.ToString(),
                            "Order has declined by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                        );

                        MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows.RemoveAt(e.RowIndex);
                                                
                    }
                }

            }

            Opacity = 1;


        }
    }
}
