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
    public partial class MythicalCafe_BackEnd_Account : Form
    {
        public MythicalCafe_BackEnd_Account()
        {
            InitializeComponent();
        }

        public void MythicalCafe_BackEnd_Account_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Size = new Size(Parent.Size.Width, Parent.Size.Height);   
            MythicalCafe_Control_Propety.set_Panel_Container(pnl_Account_Container, Form_Name, "");

            MythicalCafe_BackEnd_Account_Customer_Manage_List Account_Customer_Manage_List = (Application.OpenForms[new MythicalCafe_BackEnd_Account_Customer_Manage_List().Name] as MythicalCafe_BackEnd_Account_Customer_Manage_List);
            Account_Customer_Manage_List.get_Action("Display Account");

        }

        public void MythicalCafe_BackEnd_Account_SizeChanged(object sender, EventArgs e)
        {
            MythicalCafe_Control_Propety.set_Panel_Container_Size(Form_Name, pnl_Account_Container);
        }

        public String Form_Name = new MythicalCafe_BackEnd_Account_Customer_Manage_List().Name;

        private void btn_Manage_Account_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Account_Manage_List_Dialog(Form_Name).ShowDialog();
        }

        private void btn_Manage_Position_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Account_Position_Manage_List().ShowDialog();
        }

        private void btn_Account_Statistic_Click(object sender, EventArgs e)
        {

        }

        private void btn_Account_Log_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Log_List(){ Log_Type_String = "Account" }.ShowDialog();
        }

        private void btn_Payroll_Generate_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Account_Staff_List get_Account_Staff_List = new MythicalCafe_BackEnd_Account_Staff_List();

            get_Account_Staff_List.Action = "Generate Payroll";

            get_Account_Staff_List.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            new MythicalCafe_BackEnd_Report().ShowDialog();
        }
    }
}
