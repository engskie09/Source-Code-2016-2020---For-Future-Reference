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
    public partial class MythicalCafe_FrontEnd_Product_Cart : Form
    {
        public MythicalCafe_FrontEnd_Product_Cart()
        {
            InitializeComponent();
        }

        private void MythicalCafe_FrontEnd_Product_Cart_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);

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


        void set_dgv_Product_Order_Property()
        {
            MythicalCafe_FrontEnd_Main get_Main = (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main);  

            dgv_Product_Order.DataSource = null;

            dgv_Product_Order.AutoGenerateColumns = false;

            dgv_Product_Order.Columns["Product_Image"].DataPropertyName = "Product_Image";
            dgv_Product_Order.Columns["Product_Identity"].DataPropertyName = "Product_Identity";
            dgv_Product_Order.Columns["Product_Name"].DataPropertyName = "Product_Name";

            dgv_Product_Order.Columns["Product_Price_Cash"].DataPropertyName = "Product_Price_Cash";
            dgv_Product_Order.Columns["Product_Order_Quantity_Cash"].DataPropertyName = "Product_Order_Quantity_Cash";

            dgv_Product_Order.Columns["Product_Price_Point"].DataPropertyName = "Product_Price_Point";
            dgv_Product_Order.Columns["Product_Order_Quantity_Point"].DataPropertyName = "Product_Order_Quantity_Point";

            dgv_Product_Order.DataSource = get_Main.DataTable_Main;

            get_dgv_Product_Order_Quantity_Value();
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

        private void btn_Order_Clear_Click(object sender, EventArgs e)
        {
            MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Choice: Are You sure?");

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).DataTable_Main.Rows.Clear();
                Close();
            }            
        }

        private void btn_Order_Process_Click(object sender, EventArgs e)
        {
            get_dgv_Product_Order_Quantity_Value();

            MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Choice: Are you sure? ^_^ ");

            get_Dialog.btn_Ok.Text = "Yes";
            String get_Customer_Balance = null;
            JObject get_JObject = null;
            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                get_Customer_Balance = MythicalCafe_FrontEnd_Main_Method.check_Customer_Balance();

                if (String.IsNullOrEmpty(get_Customer_Balance))
                    return;

                get_JObject = JObject.Parse(get_Customer_Balance);

                set_Customer_Property(get_JObject["Cash_Remaining"].ToString(), get_JObject["Point_Remaining"].ToString());

                if (MythicalCafe_FrontEnd_Main_Method.select_Product_Order_Information(get_JObject["Customer_Identity"].ToString()) == 1)
                {
                    new MythicalCafe_FrontEnd_Dialog("Message: Please settle Your pending Order first.").ShowDialog();

                    return;
                }
            }            

            if (String.IsNullOrEmpty(get_Customer_Balance) || get_JObject == null)
                return;

            if (Double.TryParse(lbl_Cash_Change.Text, out _) && Double.TryParse(lbl_Point_Change.Text, out _))
            {                
                if (Convert.ToDouble(lbl_Cash_Change.Text) < 0 || Convert.ToDouble(lbl_Point_Change.Text) < 0)
                {
                    new MythicalCafe_FrontEnd_Dialog("Message: Insufficient Balance.").ShowDialog();

                    return;
                }
            }

            else
            {
                new MythicalCafe_FrontEnd_Dialog("Message: Try again.").ShowDialog();

                return;
            }


            String get_Order_List = null;

            get_Order_List = "[";
            foreach (DataGridViewRow set_DataGridViewRow in dgv_Product_Order.Rows)
            {
                get_Order_List += "{ 'Product_Identity' : '" + set_DataGridViewRow.Cells["Product_Identity"].Value.ToString() + "', 'Product_Order_Quantity_Cash' : '" + set_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value.ToString() + "', 'Product_Order_Quantity_Point' : '" + set_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value.ToString() + "' },";
            }

            get_Order_List = get_Order_List.TrimEnd(',');
            get_Order_List += "]";

            String get_Order_Identity = MythicalCafe_FrontEnd_Main_Method.Product_Order_Identity_Code + "-" + MythicalCafe_FrontEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_FrontEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_FrontEnd_Main_Method.Product_Order_Identity_Code) + 1000).ToString();
            
            if (MythicalCafe_FrontEnd_Main_Method.insert_Product_Order_Information
            (
                get_Order_Identity,
                get_JObject["Customer_Identity"].ToString(),
                get_Order_List,
                "Pending"
            ))
            {
                MythicalCafe_FrontEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_FrontEnd_Main_Method.Product_Order_Identity_Code);

                new MythicalCafe_FrontEnd_Dialog("Message: Success. Go to the Staff for confirmation.").ShowDialog();

                (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main).DataTable_Main.Rows.Clear();
                Close();

                MythicalCafe_FrontEnd_Main_Method.insert_User_Log_Information
                (
                    "Account",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    get_JObject["Customer_Identity"].ToString(),
                    "Make an Order *" + get_Order_Identity + "*"
                );

                MythicalCafe_FrontEnd_Main_Method.insert_User_Log_Information
                (
                    "Product",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    get_Order_Identity,
                    "Order has made by *" + get_JObject["Customer_Identity"].ToString() + "*"
                );

            }
        }

        private void lbl_Balance_Check_Click(object sender, EventArgs e)
        {
            get_dgv_Product_Order_Quantity_Value();

            String get_Customer_Balance = MythicalCafe_FrontEnd_Main_Method.check_Customer_Balance();

            if (String.IsNullOrEmpty(get_Customer_Balance))
                return;

            JObject get_JObject = JObject.Parse(get_Customer_Balance);

            set_Customer_Property(get_JObject["Cash_Remaining"].ToString(), get_JObject["Point_Remaining"].ToString());
        }

        private void dgv_Product_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Product_Order.Rows[e.RowIndex];

            MythicalCafe_FrontEnd_Main get_Main = (Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name] as MythicalCafe_FrontEnd_Main);

            MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Choice: What do you want to do?");

            get_Dialog.btn_Ok.Text = "Update Quantity.";
            get_Dialog.btn_No.Text = "Delete Order.";

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                get_Dialog = new MythicalCafe_FrontEnd_Dialog("Choice: What Quantity do you want to Update?");

                get_Dialog.btn_Ok.Text = "M-Cash";
                get_Dialog.btn_No.Text = "Points";

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    get_Dialog = new MythicalCafe_FrontEnd_Dialog("Input: Quantity");

                    MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(get_Dialog.txt_Action);

                    MythicalCafe_Control_Propety.set_TextBox_KeyDown_Length_Maximum(get_Dialog.txt_Action, 2);

                    if (get_Dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (get_Dialog.Action_Value == "Quantity")
                            get_Dialog.Action_Value = "0";

                        get_Main.update_DataTable_Main_Quantity(e.RowIndex, get_Dialog.txt_Action.Text, "");

                        if (get_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value.ToString() == "0" && get_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value.ToString() == "0")
                            get_Main.DataTable_Main.Rows.RemoveAt(e.RowIndex);

                        if (get_Main.DataTable_Main.Rows.Count == 0)
                            Close();

                        set_dgv_Product_Order_Property();
                        set_Customer_Property(Cash_Remaining.ToString(), Point_Remaining.ToString());
                    }
                }

                else if (get_Dialog.DialogResult == DialogResult.No)
                {
                    get_Dialog = new MythicalCafe_FrontEnd_Dialog("Input: Quantity");

                    MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(get_Dialog.txt_Action);

                    MythicalCafe_Control_Propety.set_TextBox_KeyDown_Length_Maximum(get_Dialog.txt_Action, 2);

                    if (get_Dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (get_Dialog.Action_Value == "Quantity")
                            get_Dialog.Action_Value = "0";

                        get_Main.update_DataTable_Main_Quantity(e.RowIndex, "", get_Dialog.txt_Action.Text);

                        if (get_DataGridViewRow.Cells["Product_Order_Quantity_Cash"].Value.ToString() == "0" && get_DataGridViewRow.Cells["Product_Order_Quantity_Point"].Value.ToString() == "0")
                            get_Main.DataTable_Main.Rows.RemoveAt(e.RowIndex);

                        if (get_Main.DataTable_Main.Rows.Count == 0)
                            Close();

                        set_dgv_Product_Order_Property();
                        set_Customer_Property(Cash_Remaining.ToString(), Point_Remaining.ToString());
                    }
                }
            }

            else if (get_Dialog.DialogResult == DialogResult.No)
            {
                get_Main.DataTable_Main.Rows.RemoveAt(e.RowIndex);


                if (get_Main.DataTable_Main.Rows.Count == 0)
                    Close();

                set_dgv_Product_Order_Property();

                set_Customer_Property(Cash_Remaining.ToString(), Point_Remaining.ToString());
            }
            
        }
    }
}
