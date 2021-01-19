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
    public partial class MythicalCafe_BackEnd_Product_Order_Manage_List : Form
    {
        public MythicalCafe_BackEnd_Product_Order_Manage_List()
        {
            InitializeComponent();

            set_DataTable_Main_Property();
        }

        private void MythicalCafe_BackEnd_Product_Order_Manage_List_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);
                

            Product_Order_Information = JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Product_Order_Manage_List_Method.select_Product_Order_Information("Select : Specific", "Customer_Identity", Customer_Identity))["Table"].ToString().TrimStart('[').TrimEnd(']'));
            JArray get_JArray = JArray.Parse(Product_Order_Information["Order_List"].ToString());

            foreach (JObject set_JObject in get_JArray)
            {
                JObject get_JObject = JObject.Parse(JObject.Parse(MythicalCafe_BackEnd_Product_Manage_List_Method.select_Product_Information("Select : Specific", set_JObject["Product_Identity"].ToString()))["Table"].ToString().TrimStart('[').TrimEnd(']'));

                String get_Product_Image_Path = "\\\\" + MythicalCafe_BackEnd_Main_Method.Server_InternetProtocol_Address + "\\\\" + get_JObject["Product_Image_Path"].ToString().Replace('/', '\\');

                Image get_Image = null;

                if (File.Exists(get_Product_Image_Path))
                    using (FileStream set_FileStream = new FileStream(get_Product_Image_Path, FileMode.Open, FileAccess.Read))
                        get_Image = Image.FromStream(set_FileStream);

                //MessageBox.Show(get_JObject.ToString());
             
                insert_DataTable_Main
                (
                    get_Image, 
                    set_JObject["Product_Identity"].ToString(),
                    get_JObject["Product_Name"].ToString(),
                    get_JObject["Product_Price_Cash"].ToString(),
                    set_JObject["Product_Order_Quantity_Cash"].ToString(),
                    get_JObject["Product_Price_Point"].ToString(),
                    set_JObject["Product_Order_Quantity_Point"].ToString(),
                    get_JObject["Product_Quantity"].ToString()
                );
            }           

            get_Customer_Property();

            set_dgv_Product_Order_Property();

            set_Customer_Property(Cash_Remaining.ToString(), Point_Remaining.ToString());
        }

        Double Product_Price_Point_Total
        {
            get { return Convert.ToDouble(lbl_Price_Point_Total.Text); }
            set { lbl_Price_Point_Total.Text = value.ToString(); }
        }

        Double Product_Price_Cash_Total
        {
            get { return Convert.ToDouble(lbl_Price_Cash_Total.Text); }
            set { lbl_Price_Cash_Total.Text = value.ToString(); }
        }

        Double Point_Remaining
        {
            get { return Convert.ToDouble(lbl_Remaining_Point.Text.Remove(0, 8)); }
            set { lbl_Remaining_Point.Text = "Points: " + value.ToString(); }
        }

        Double Cash_Remaining
        {
            get { return Convert.ToDouble(lbl_Remaining_Cash.Text.Remove(0, 8)); }
            set { lbl_Remaining_Cash.Text = "M-Cash: " + value.ToString(); }
        }

        public DataTable Product_Order_Manage_List_DataTable = null;

        public void set_DataTable_Main_Property()
        {
            Product_Order_Manage_List_DataTable = new DataTable();
            Product_Order_Manage_List_DataTable.Columns.Add("Product_Image", typeof(Image));
            Product_Order_Manage_List_DataTable.Columns.Add("Product_Identity", typeof(String));
            Product_Order_Manage_List_DataTable.Columns.Add("Product_Name", typeof(String));

            Product_Order_Manage_List_DataTable.Columns.Add("Product_Price_Cash", typeof(String));
            Product_Order_Manage_List_DataTable.Columns.Add("Product_Order_Quantity_Cash", typeof(String));

            Product_Order_Manage_List_DataTable.Columns.Add("Product_Price_Point", typeof(String));
            Product_Order_Manage_List_DataTable.Columns.Add("Product_Order_Quantity_Point", typeof(String));

            Product_Order_Manage_List_DataTable.Columns.Add("Product_Available_Quantity", typeof(String));
        }

        public void insert_DataTable_Main
        (
            Image set_Product_Image,
            String set_Product_Identity,
            String set_Product_Name,
            String set_Product_Price_Cash,
            String set_Product_Order_Quantity_Cash,
            String set_Product_Price_Point,
            String set_Product_Order_Quantity_Point,
            String set_Product_Available_Quantity
        )
        {
            Boolean get_Boolean = false;

            foreach (DataRow set_DataRow in Product_Order_Manage_List_DataTable.Rows)
            {
                if (set_Product_Identity == set_DataRow["Product_Identity"].ToString())
                {
                    set_DataRow["Product_Order_Quantity_Cash"] = Convert.ToInt32(set_DataRow["Product_Order_Quantity_Cash"]) + Convert.ToInt32(set_Product_Order_Quantity_Cash);
                    set_DataRow["Product_Order_Quantity_Point"] = Convert.ToInt32(set_DataRow["Product_Order_Quantity_Point"]) + Convert.ToInt32(set_Product_Order_Quantity_Point);
                    get_Boolean = true;
                }
            }

            if (!get_Boolean)
                Product_Order_Manage_List_DataTable.Rows.Add(set_Product_Image, set_Product_Identity, set_Product_Name, set_Product_Price_Cash, set_Product_Order_Quantity_Cash, set_Product_Price_Point, set_Product_Order_Quantity_Point, set_Product_Available_Quantity);
        }

        public void update_DataTable_Main_Quantity(Int32 set_DataRow_Index, String set_Cash_Quantity, String set_Point_Quantity)
        {
            DataRow get_DataRow = Product_Order_Manage_List_DataTable.Rows[set_DataRow_Index];

            if (!String.IsNullOrEmpty(set_Cash_Quantity))
                get_DataRow["Product_Order_Quantity_Cash"] = set_Cash_Quantity;

            if (!String.IsNullOrEmpty(set_Point_Quantity))
                get_DataRow["Product_Order_Quantity_Point"] = set_Point_Quantity;

        }

        void set_dgv_Product_Order_Property()
        {
            dgv_Product_Order.DataSource = null;

            dgv_Product_Order.AutoGenerateColumns = false;

            dgv_Product_Order.Columns["Product_Image"].DataPropertyName = "Product_Image";
            dgv_Product_Order.Columns["Product_Identity"].DataPropertyName = "Product_Identity";
            dgv_Product_Order.Columns["Product_Name"].DataPropertyName = "Product_Name";

            dgv_Product_Order.Columns["Product_Price_Cash"].DataPropertyName = "Product_Price_Cash";
            dgv_Product_Order.Columns["Product_Order_Quantity_Cash"].DataPropertyName = "Product_Order_Quantity_Cash";

            dgv_Product_Order.Columns["Product_Price_Point"].DataPropertyName = "Product_Price_Point";
            dgv_Product_Order.Columns["Product_Order_Quantity_Point"].DataPropertyName = "Product_Order_Quantity_Point";

            dgv_Product_Order.Columns["Product_Available_Quantity"].DataPropertyName = "Product_Available_Quantity";

            dgv_Product_Order.DataSource = Product_Order_Manage_List_DataTable;

            get_dgv_Product_Order_Quantity_Value();

            foreach (DataGridViewRow set_DataGridViewRow in dgv_Product_Order.Rows)
            {
                if (Convert.ToInt32(set_DataGridViewRow.Cells["Product_Available_Quantity"].Value) < Convert.ToInt32(set_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value) + Convert.ToInt32(set_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value))
                    set_DataGridViewRow.DefaultCellStyle.BackColor = Color.Red;
            }

        }

        void get_dgv_Product_Order_Quantity_Value()
        {
            Double get_Product_Price_Point_Total = 0;
            Double get_Product_Price_Cash_Total = 0;

            foreach (DataGridViewRow set_DataGridViewRow in dgv_Product_Order.Rows)
            {
                //MessageBox.Show(set_DataGridViewRow.Cells["Product_Price_Point"].Value.ToString() + " : " + set_DataGridViewRow.Cells["Product_Price_Cash"].Value.ToString());

                get_Product_Price_Cash_Total += Convert.ToDouble(set_DataGridViewRow.Cells["Product_Price_Cash"].Value) * Convert.ToDouble(set_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value);
                get_Product_Price_Point_Total += Convert.ToDouble(set_DataGridViewRow.Cells["Product_Price_Point"].Value) * Convert.ToDouble(set_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value);

            }

            Product_Price_Point_Total = get_Product_Price_Point_Total;
            Product_Price_Cash_Total = get_Product_Price_Cash_Total;
        }

        void set_Customer_Property(String set_Cash_Remaining, String set_Point_Remaining)
        {
            if (Double.TryParse(set_Cash_Remaining, out _))
                Cash_Remaining = Convert.ToDouble(set_Cash_Remaining);
            else
                Cash_Remaining = 0;

            if (Double.TryParse(set_Point_Remaining, out _))
                Point_Remaining = Convert.ToDouble(set_Point_Remaining);
            else
                Point_Remaining = 0;

            lbl_Cash_Change.Text = Convert.ToDouble(Cash_Remaining - Product_Price_Cash_Total).ToString();
            lbl_Point_Change.Text = Convert.ToDouble(Point_Remaining - Product_Price_Point_Total).ToString();
        }

        public Int32 DataTable_Index_Current = 0;
        public String Customer_Identity = null;
        public JObject Product_Order_Information = null;

        void get_Customer_Property()
        {
            String get_Customer_Balance = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information("Select : Specific", Customer_Identity);

            //MessageBox.Show(get_Customer_Balance);
            if (String.IsNullOrEmpty(get_Customer_Balance))
                return;

            JObject get_JObject = JObject.Parse(JObject.Parse(get_Customer_Balance)["Table"].ToString().TrimStart('[').TrimEnd(']'));

            Cash_Remaining = Convert.ToDouble(get_JObject["Cash_Remaining"].ToString());
            Point_Remaining = Convert.ToDouble(get_JObject["Point_Remaining"].ToString());

        }

        private void btn_Order_Accept_Click(object sender, EventArgs e)
        {
            get_dgv_Product_Order_Quantity_Value();

            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Are you sure? ^_^ ");

            get_Dialog.BackColor = Color.FromArgb(118, 106, 255);
            get_Dialog.btn_Ok.Text = "Yes";

            if (get_Dialog.ShowDialog() == DialogResult.No)
                return;     


            if (Double.TryParse(lbl_Cash_Change.Text, out _) && Double.TryParse(lbl_Point_Change.Text, out _))
            {
                if (Convert.ToDouble(lbl_Cash_Change.Text) < 0 || Convert.ToDouble(lbl_Point_Change.Text) < 0)
                {
                    new MythicalCafe_BackEnd_Dialog("Message: Insufficient Balance.") { BackColor = Color.FromArgb(118, 106, 255) }.ShowDialog();

                    return;
                }

                else
                {
                    set_Order_Accept();
                }
            }

            else
            {
                new MythicalCafe_BackEnd_Dialog("Message: Try again.").ShowDialog();

                return;
            }
            
        }

        void set_Order_Accept()
        {
            foreach (DataGridViewRow set_DataGridViewRow in dgv_Product_Order.Rows)
            {
                if (Convert.ToInt32(set_DataGridViewRow.Cells["Product_Available_Quantity"].Value) < Convert.ToInt32(set_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value) + Convert.ToInt32(set_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value))
                {
                    MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Message: Insufficient stock in some Products");

                    get_Dialog.BackColor = Color.FromArgb(118, 106, 255);

                    get_Dialog.ShowDialog();

                    return;
                }
            }

            String get_Product_Name_Sold_List = null;
            String get_Product_Quantity_Sold_List = null;
            Int32 get_Order_Quantity_Total = 0;
            foreach (DataGridViewRow set_DataGridViewRow in dgv_Product_Order.Rows)
            {
                get_Order_Quantity_Total = Convert.ToInt32(set_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value) + Convert.ToInt32(set_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value);
                get_Product_Quantity_Sold_List += get_Order_Quantity_Total.ToString() + ", ";

                //MessageBox.Show(set_DataGridViewRow.Cells["Product_Identity"].Value.ToString() + "," + get_Order_Quantity_Total.ToString());
                get_Product_Name_Sold_List += set_DataGridViewRow.Cells["Product_Name"].Value.ToString() + ", ";
                MythicalCafe_BackEnd_Product_Manage_List_Method.update_Product_Information
                (
                    "Update : Specific { Product_Quantity }",
                    set_DataGridViewRow.Cells["Product_Identity"].Value.ToString(),
                    "",
                    get_Order_Quantity_Total.ToString(),
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                );

                get_Product_Name_Sold_List = get_Product_Name_Sold_List.Trim();

                get_Product_Name_Sold_List = get_Product_Name_Sold_List.TrimEnd(',');

                get_Product_Quantity_Sold_List = get_Product_Quantity_Sold_List.Trim();

                get_Product_Quantity_Sold_List = get_Product_Quantity_Sold_List.TrimEnd(',');

                if (MythicalCafe_BackEnd_Product_Order_Manage_List_Method.update_Product_Order_Information("Update : Specific : Order_Status", Product_Order_Information["Order_Identity"].ToString(), "", "", "Accepted"))
                {
                    MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Property_Information
                    (
                        "Update : Specific : { Cash_Remaining, Cash_Spent, Point_Remaining, Point_Spent}",
                        Customer_Identity,
                        "",
                        "",
                        "",
                        "",
                        Product_Price_Cash_Total.ToString(),
                        "",
                        Product_Price_Point_Total.ToString(),
                        "",
                        ""
                    );

                    MythicalCafe_BackEnd_Product_Manage_List_Method.insert_Product_Report_Information(get_Product_Name_Sold_List, get_Product_Quantity_Sold_List, Product_Price_Cash_Total.ToString(), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));


                    String get_Customer_ContactNumber = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Personal_Information("Select : Specific { Contact Number }", Customer_Identity);

                    String get_Message = DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\nThank You for buying " + get_Product_Name_Sold_List + "\nBranch: " + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "";

                    MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_ShortMessageService_Message(get_Customer_ContactNumber, get_Message);

                    MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows.RemoveAt(DataTable_Index_Current);
                    
                    MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                    (
                        "Account",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                        "Accepted Order *" + Product_Order_Information["Order_Identity"].ToString() + "*"
                    );

                    MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                    (
                        "Product",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        Product_Order_Information["Order_Identity"].ToString(),
                        "Order has accepted by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                    );

                    MythicalCafe_BackEnd_Product_List get_Product_List = Application.OpenForms[new MythicalCafe_BackEnd_Product_List().Name] as MythicalCafe_BackEnd_Product_List;
                    
                    get_Product_List.set_dgv_Product_Value();

                    new MythicalCafe_BackEnd_Dialog("Message: Success") { BackColor = Color.FromArgb(118, 106, 255) }.ShowDialog();

                    Close();
                }          
            }
        }
        
        void update_Product_Order_Information()
        {
            String get_Order_List = null;

            get_Order_List = "[";
            foreach (DataGridViewRow set_DataGridViewRow in dgv_Product_Order.Rows)
            {
                get_Order_List += "{ 'Product_Identity' : '" + set_DataGridViewRow.Cells["Product_Identity"].Value.ToString() + "', 'Product_Order_Quantity_Cash' : '" + set_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value.ToString() + "', 'Product_Order_Quantity_Point' : '" + set_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value.ToString() + "' },";
            }

            get_Order_List = get_Order_List.TrimEnd(',');
            get_Order_List += "]";

            MythicalCafe_BackEnd_Product_Order_Manage_List_Method.update_Product_Order_Information("Update : Specific : Order_List", Product_Order_Information["Order_Identity"].ToString(), "", get_Order_List, "");
        }

        private void dgv_Product_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Product_Order.Rows[e.RowIndex];            

            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: What do you want to do?");

            get_Dialog.BackColor = Color.FromArgb(118, 106, 255);
            get_Dialog.btn_Ok.Text = "Update Quantity.";
            get_Dialog.btn_No.Text = "Delete Order.";

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: What Quantity do you want to Update?");

                get_Dialog.btn_Ok.Text = "M-Cash";
                get_Dialog.btn_No.Text = "Points";

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Quantity");
                    get_Dialog.BackColor = Color.FromArgb(118, 106, 255);

                    MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(get_Dialog.txt_Action);

                    MythicalCafe_Control_Propety.set_TextBox_KeyDown_Length_Maximum(get_Dialog.txt_Action, 2);

                    if (get_Dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (get_Dialog.Action_Value == "Quantity")
                            get_Dialog.Action_Value = "0";

                        update_DataTable_Main_Quantity(e.RowIndex, get_Dialog.txt_Action.Text, "");

                        if (get_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value.ToString() == "0" && get_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value.ToString() == "0")
                            Product_Order_Manage_List_DataTable.Rows.RemoveAt(e.RowIndex);

                        update_Product_Order_Information();

                        if (Product_Order_Manage_List_DataTable.Rows.Count == 0)
                            set_Decline_Product_Order();

                        set_dgv_Product_Order_Property();
                        set_Customer_Property(Cash_Remaining.ToString(), Point_Remaining.ToString());
                    }
                }

                else if (get_Dialog.DialogResult == DialogResult.No)
                {
                    get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Quantity");
                    get_Dialog.BackColor = Color.FromArgb(118, 106, 255);

                    MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(get_Dialog.txt_Action);

                    MythicalCafe_Control_Propety.set_TextBox_KeyDown_Length_Maximum(get_Dialog.txt_Action, 2);

                    if (get_Dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (get_Dialog.Action_Value == "Quantity")
                            get_Dialog.Action_Value = "0";

                        update_DataTable_Main_Quantity(e.RowIndex, "", get_Dialog.txt_Action.Text);

                        if (get_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value.ToString() == "0" && get_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value.ToString() == "0")
                            Product_Order_Manage_List_DataTable.Rows.RemoveAt(e.RowIndex);

                        update_Product_Order_Information();

                        if (Product_Order_Manage_List_DataTable.Rows.Count == 0)
                            set_Decline_Product_Order();
                        

                        set_dgv_Product_Order_Property();
                        set_Customer_Property(Cash_Remaining.ToString(), Point_Remaining.ToString());
                    }
                }
            }

            else if (get_Dialog.DialogResult == DialogResult.No)
            {
                Product_Order_Manage_List_DataTable.Rows.RemoveAt(e.RowIndex);

                update_Product_Order_Information();

                if (Product_Order_Manage_List_DataTable.Rows.Count == 0)
                    set_Decline_Product_Order();
                

                set_dgv_Product_Order_Property();

                set_Customer_Property(Cash_Remaining.ToString(), Point_Remaining.ToString());
            }

        }

        void set_Decline_Product_Order()
        {
            if (MythicalCafe_BackEnd_Product_Order_Manage_List_Method.update_Product_Order_Information("Update : Specific : Order_Status", Product_Order_Information["Order_Identity"].ToString(), "", "", "Declined"))
            {
                String get_Customer_ContactNumber = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Personal_Information("Select : Specific { Contact Number }", Customer_Identity);

                String get_Message = DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\nUnfortunately your order has been deleted and declined by the Assigned staff\nBranch: " + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "";

                MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_ShortMessageService_Message(get_Customer_ContactNumber, get_Message);

                MythicalCafe_BackEnd_Product_Order_Manage_List_Method.Product_Order_DataTable_1.Rows.RemoveAt(DataTable_Index_Current);

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                    "Declined Order *" + Product_Order_Information["Order_Identity"].ToString() + "*"
                );

                MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    Product_Order_Information["Order_Identity"].ToString(),
                    "Order has declined by *" + MythicalCafe_BackEnd_Main_Method.Staff_Identity + "*"
                );
            }

            Close();
        }
    }
}
