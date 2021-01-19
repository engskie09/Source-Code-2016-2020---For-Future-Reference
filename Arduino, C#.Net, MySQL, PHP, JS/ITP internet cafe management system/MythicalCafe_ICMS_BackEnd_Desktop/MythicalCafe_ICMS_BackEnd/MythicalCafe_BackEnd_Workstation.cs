using Binarymission.WinForms.Controls.ScrollBars;
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

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Workstation : Form
    {
        public MythicalCafe_BackEnd_Workstation()
        {
            InitializeComponent();
        }

        void MythicalCafe_BackEnd_Workstation_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Size = new Size(Parent.Size.Width, Parent.Size.Height);

            set_Workstation_Information();

        }

        void set_UserControl_Workstation(String set_Workstation_Identity, String set_Workstation_Session_Identity, String set_Workstation_Name, String set_Username)
        {
            MythicalCafe_BackEnd_UserControl_Workstation get_UserControl_Workstation = new MythicalCafe_BackEnd_UserControl_Workstation(set_Workstation_Identity);

            get_UserControl_Workstation.Name = set_Workstation_Identity;

            get_UserControl_Workstation.Workstation_Identity = set_Workstation_Identity;

            get_UserControl_Workstation.Username = set_Username;
            get_UserControl_Workstation.Workstation_Name = set_Workstation_Name;

            pnl_Workstation_Container.Controls.Add(get_UserControl_Workstation);
        }


        public void set_Workstation_Information()
        {
            pnl_Workstation_Container.Controls.Clear();

            MythicalCafe_BackEnd_Workstation_Manage_List_Method.get_Workstation_Dictionary = MythicalCafe_BackEnd_Workstation_Manage_List_Method.select_Workstation_Information("Select : All", "");

            Int32 get_Counter = 0;

            foreach (KeyValuePair<String, String> set_KeyValuePair in MythicalCafe_BackEnd_Workstation_Manage_List_Method.get_Workstation_Dictionary)
            {
                JObject get_KeyValuePair_Value = JObject.Parse(set_KeyValuePair.Value);

                set_UserControl_Workstation
                (
                    set_KeyValuePair.Key, //Workstation_Identity
                    get_KeyValuePair_Value["Workstation_Session_Identity"].ToString(),
                    get_KeyValuePair_Value["Workstation_Name"].ToString(),
                    get_KeyValuePair_Value["Workstation_Username"].ToString()
                );

                get_Counter++;
            }

            pnl_Workstation_Container.AutoScroll = true;

            if (get_Counter > 2)
            {
                vsb_NavigationBar.Visible = true;

                pnl_Workstation_Main.SetColumnSpan(pnl_Workstation_Container, 1);

                vsb_NavigationBar.MaximumScrollRange = pnl_Workstation_Container.VerticalScroll.Maximum / 10;
                vsb_NavigationBar.Dock = DockStyle.Fill;
            }
            else
            {
                vsb_NavigationBar.Visible = false;

                pnl_Workstation_Main.SetColumnSpan(pnl_Workstation_Container, 2);
            }

            pnl_Workstation_Container.AutoScroll = false;
        }

        void btn_ADDDD_Click(object sender, EventArgs e)
        {

        }

        void btn_ManageWorkstation_Click(object sender, EventArgs e)
        {

            new MythicalCafe_BackEnd_Workstation_Manage_List_Dialog().ShowDialog();

            set_Workstation_Information();
        }

        private void vsb_NavigationBar_Scroll(object sender, ScrollEventArgs e)
        {
            pnl_Workstation_Container.AutoScrollPosition = new Point(0, Convert.ToInt32(Math.Round(vsb_NavigationBar.EarlierScrollPosition, 0) * 10));
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("a");
        }

        private void btn_Workstation_Log_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Log_List() { Log_Type_String = "Workstation" }.ShowDialog();
        }

        private void btn_Service_Printing_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Dialog get_Dialog_1 = new MythicalCafe_BackEnd_Dialog("Choice: Select kind of printing");
            get_Dialog_1.btn_Ok.Text = "Colored";
            get_Dialog_1.btn_No.Text = "Black/White";

            MythicalCafe_BackEnd_Dialog get_Dialog_2 = new MythicalCafe_BackEnd_Dialog("Input: How many quantity");
            get_Dialog_2.btn_Ok.Text = "Proceed";
            get_Dialog_2.btn_No.Text = "Cancel";

            MythicalCafe_BackEnd_Dialog get_Dialog_3 = new MythicalCafe_BackEnd_Dialog("Input: How much per quantity");
            get_Dialog_3.btn_Ok.Text = "Proceed";
            get_Dialog_3.btn_No.Text = "Cancel";

            String get_Printing_Type = null;
            Double get_Quantity = 0;
            Double get_Printing_Rate = 0;

            Double get_Total_Rate = 0;

            if (get_Dialog_1.ShowDialog() == DialogResult.OK)
            {

                get_Printing_Type = get_Dialog_1.btn_Ok.Text;

                if (get_Dialog_2.ShowDialog() == DialogResult.OK)
                {
                    get_Quantity = Convert.ToDouble(get_Dialog_2.txt_Action.Text);

                    if (get_Dialog_3.ShowDialog() == DialogResult.OK)
                    {
                        get_Printing_Rate = Convert.ToDouble(get_Dialog_3.txt_Action.Text);
                        get_Total_Rate = get_Printing_Rate * get_Quantity;

                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Account",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                            "Made a printing Service " + get_Printing_Type + " " + get_Quantity.ToString() + "x" + get_Printing_Rate.ToString() + " = " + get_Total_Rate.ToString()
                        );

                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Workstation",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                            "Made a printing Service " + get_Printing_Type + " " + get_Quantity.ToString()+ "x" + get_Printing_Rate.ToString() + " = " + get_Total_Rate.ToString()
                        );

                        new MythicalCafe_BackEnd_Dialog("Message: Total: " + get_Total_Rate.ToString() + " Pesos").ShowDialog();

                    }
                }               

            }


            else if (get_Dialog_1.DialogResult == DialogResult.No)
            {
                get_Printing_Type = get_Dialog_1.btn_No.Text;

                if (get_Dialog_2.ShowDialog() == DialogResult.OK)
                {
                    get_Quantity = Convert.ToDouble(get_Dialog_2.txt_Action.Text);
                    
                    if (get_Dialog_3.ShowDialog() == DialogResult.OK)
                    {
                        get_Printing_Rate = Convert.ToDouble(get_Dialog_3.txt_Action.Text);
                        get_Total_Rate = get_Printing_Rate * get_Quantity;                       

                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Account",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                            "Made a printing Service " + get_Printing_Type + get_Quantity.ToString() + "x" + get_Printing_Rate.ToString() + " = " + get_Total_Rate.ToString()
                        );

                        MythicalCafe_BackEnd_Log_Manage_List_Method.insert_User_Log_Information
                        (
                            "Workstation",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            MythicalCafe_BackEnd_Main_Method.Staff_Identity,
                            "Made a printing Service " + get_Printing_Type + get_Quantity.ToString() + "x" + get_Printing_Rate.ToString() + " = " + get_Total_Rate.ToString()
                        );

                        new MythicalCafe_BackEnd_Dialog("Message: Total: " + get_Total_Rate.ToString() + " Pesos").ShowDialog();
                    }
                }

            }
        }
    }
}
