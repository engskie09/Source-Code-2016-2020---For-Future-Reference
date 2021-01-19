using Bunifu.Framework.UI;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_Main : Form
    {
        public MythicalCafe_FrontEnd_Main()
        {
            InitializeComponent();
        }

        private void MythicalCafe_FrontEnd_Main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            MythicalCafe_Control_Propety.set_Panel_Draggable(pnl_Border_Top, this);

            MythicalCafe_FrontEnd_Main_Method.select_Product_Information("Select : All : Except { Product Status = Inactive }", "");
            
            Main_Thread_1 = new Thread(delegate ()
            {
                while (true)
                {
                    lbl_Top_Header.Text = "Branch: " + MythicalCafe_FrontEnd_Main_Method.Branch_Identity + "     Server Date-Time(This PC): " + DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss");

                    Thread.Sleep(1000);
                }
            });

            Main_Thread_1.Start();

            set_Product_Information();
            set_DataTable_Main_Property();

            Disposed += set_Dispose;
        }

        Thread Main_Thread_1 = null;

        private void set_Dispose(Object set_Object, EventArgs set_EventArgs)
        {
            if (!ReferenceEquals(Main_Thread_1, null))
                Main_Thread_1.Abort();
        }

        private void MythicalCafe_FrontEnd_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*e.Cancel = true;

            MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Input: Password");

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                if (get_Dialog.Action_Value == "ITP")
                {
                    MythicalCafe_Control_Propety.get_Timer.Stop();

                    MythicalCafe_Control_Propety.get_Form_Effect_Fade("Exit", this);
                }
            }*/

        }

        public DataTable DataTable_Main = new DataTable();

        void set_DataTable_Main_Property()
        {
            DataTable_Main.Columns.Add("Product_Image", typeof(Image));
            DataTable_Main.Columns.Add("Product_Identity", typeof(String));
            DataTable_Main.Columns.Add("Product_Name", typeof(String));

            DataTable_Main.Columns.Add("Product_Price_Cash", typeof(String));
            DataTable_Main.Columns.Add("Product_Order_Quantity_Cash", typeof(String));

            DataTable_Main.Columns.Add("Product_Price_Point", typeof(String));            
            DataTable_Main.Columns.Add("Product_Order_Quantity_Point", typeof(String));
        }

        public void insert_DataTable_Main
        (
            Image set_Product_Image, 
            String set_Product_Identity, 
            String set_Product_Name, 
            String set_Product_Price_Cash,
            String set_Product_Order_Quantity_Cash,
            String set_Product_Price_Point,
            String set_Product_Order_Quantity_Point
        )
        {
            Boolean get_Boolean = false;

            foreach (DataRow set_DataRow in DataTable_Main.Rows)
            {
                if (set_Product_Identity == set_DataRow["Product_Identity"].ToString())
                {
                    set_DataRow["Product_Order_Quantity_Cash"] = Convert.ToInt32(set_DataRow["Product_Order_Quantity_Cash"]) + Convert.ToInt32(set_Product_Order_Quantity_Cash);
                    set_DataRow["Product_Order_Quantity_Point"] = Convert.ToInt32(set_DataRow["Product_Order_Quantity_Point"]) + Convert.ToInt32(set_Product_Order_Quantity_Point);
                    get_Boolean = true;
                }
            }

            if (!get_Boolean)
                DataTable_Main.Rows.Add(set_Product_Image, set_Product_Identity, set_Product_Name, set_Product_Price_Cash, set_Product_Order_Quantity_Cash, set_Product_Price_Point, set_Product_Order_Quantity_Point);
        }
        
        public void update_DataTable_Main_Quantity(Int32 set_DataRow_Index, String set_Cash_Quantity, String set_Point_Quantity)
        {
            DataRow get_DataRow = DataTable_Main.Rows[set_DataRow_Index];
            
            if (!String.IsNullOrEmpty(set_Cash_Quantity))
                get_DataRow["Product_Order_Quantity_Cash"] = set_Cash_Quantity;

            if (!String.IsNullOrEmpty(set_Point_Quantity))
                get_DataRow["Product_Order_Quantity_Point"] = set_Point_Quantity;
            
        }

        void set_UserControl_Product(String set_Product_Identity, String set_Product_Name, Image set_Product_Image, JObject set_Product_Information)
        {
            MythicalCafe_FrontEnd_UserControl_Product get_UserControl_Product = new MythicalCafe_FrontEnd_UserControl_Product();

            get_UserControl_Product.Name = set_Product_Identity;
            get_UserControl_Product.Product_Name = set_Product_Name;
            get_UserControl_Product.Product_Image = set_Product_Image;
            get_UserControl_Product.Product_Information = set_Product_Information;

            pnl_Product_Container.Controls.Add(get_UserControl_Product);
        }

        void set_Product_Information()
        {
            pnl_Product_Container.Controls.Clear();

            Int32 get_Counter = 0;

            foreach (DataRow set_DataRow in MythicalCafe_FrontEnd_Main_Method.Main_DataTable_1.Rows)
            {
                JObject get_JObject = null;
                Image get_Image = null;
             
                String get_Product_Image_Path = "\\\\" + MythicalCafe_FrontEnd_Main_Method.Server_InternetProtocol_Address + "\\\\"+ set_DataRow["Product_Image_Path"].ToString().Replace('/', '\\');

                if (File.Exists(get_Product_Image_Path))
                    using (FileStream set_FileStream = new FileStream(get_Product_Image_Path, FileMode.Open, FileAccess.Read))
                        get_Image = Image.FromStream(set_FileStream);

                get_JObject = JObject.Parse("{ 'Product_Identity' : " + " '" + set_DataRow["Product_Identity"].ToString() + "'}");
                get_JObject.Merge(JObject.Parse("{ 'Product_Name' : " + " '" + set_DataRow["Product_Name"].ToString() + "'}"));
                get_JObject.Merge(JObject.Parse("{ 'Product_Price_Cash' : " + " '" + set_DataRow["Product_Price_Cash"].ToString() + "'}"));
                get_JObject.Merge(JObject.Parse("{ 'Product_Price_Point' : " + " '" + set_DataRow["Product_Price_Point"].ToString() + "'}"));
                get_JObject.Merge(JObject.Parse("{ 'Product_Description' : " + " '" + set_DataRow["Product_Description"].ToString() + "'}"));

                set_UserControl_Product(set_DataRow["Product_Identity"].ToString(), set_DataRow["Product_Name"].ToString(), get_Image, get_JObject);

                get_Counter++;
            }

            pnl_Product_Container.AutoScroll = true;

            if (get_Counter > 10)
            {
                pnl_Main.SetColumn(vsb_NavigationBar, 2);

                vsb_NavigationBar.MaximumScrollRange = pnl_Main.VerticalScroll.Maximum / 10;
                vsb_NavigationBar.Dock = DockStyle.Fill;
            }

            else
            {
                pnl_Main.SetColumnSpan(pnl_Main_Container, 2);
                pnl_Main.SetColumn(vsb_NavigationBar, 3);
            }

            pnl_Product_Container.AutoScroll = false;
        }

        private void btn_Application_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            /*MythicalCafe_FrontEnd_Dialog get_Dialog = new MythicalCafe_FrontEnd_Dialog("Input: Password");

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                if (get_Dialog.Action_Value == "ITP")
                {
                    MythicalCafe_Control_Propety.get_Timer.Stop();

                    MythicalCafe_Control_Propety.get_Form_Effect_Fade("Exit", this);
                }
            }*/
        }

        private void btn_Ranking_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Balance_Check_Click(object sender, EventArgs e)
        {
            MythicalCafe_FrontEnd_Main_Method.check_Customer_Balance();
        }

        private void btn_Cart_View_Click(object sender, EventArgs e)
        {
            if (DataTable_Main.Rows.Count != 0)
                new MythicalCafe_FrontEnd_Product_Cart().ShowDialog();

            else
                new MythicalCafe_FrontEnd_Dialog("Message: No Product has been added.").ShowDialog();
        }

        private void vsb_NavigationBar_Scroll(object sender, ScrollEventArgs e)
        {
            pnl_Product_Container.AutoScrollPosition = new Point(0, Convert.ToInt32(Math.Round(vsb_NavigationBar.EarlierScrollPosition, 0) * 10));
        }
    }
}
