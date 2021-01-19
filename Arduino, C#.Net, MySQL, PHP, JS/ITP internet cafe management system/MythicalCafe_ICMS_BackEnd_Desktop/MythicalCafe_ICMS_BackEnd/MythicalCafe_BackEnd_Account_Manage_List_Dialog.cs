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
    public partial class MythicalCafe_BackEnd_Account_Manage_List_Dialog : Form
    {
        public MythicalCafe_BackEnd_Account_Manage_List_Dialog(String set_Form_Name)
        {
            InitializeComponent();            
        }

        private void MythicalCafe_BackEnd_Account_Manage_List_Dialog_Load(object sender, EventArgs e)
        {            
            KeyDown += delegate(Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 1;

            //MythicalCafe_Control_Propety.get_Form_Effect_Fade("Emphasize", Application.OpenForms[new MythicalCafe_BackEnd_Main().Name]);
        }

        private void MythicalCafe_BackEnd_Account_Manage_List_Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            MythicalCafe_Control_Propety.get_Timer.Stop();

            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 1;
        }

        /* Custom Method */

        MythicalCafe_BackEnd_Account Account = (Application.OpenForms[new MythicalCafe_BackEnd_Account().Name] as MythicalCafe_BackEnd_Account);

        MythicalCafe_BackEnd_Account_Customer_Manage_List Account_Customer_Manage_List = (Application.OpenForms[new MythicalCafe_BackEnd_Account_Customer_Manage_List().Name] as MythicalCafe_BackEnd_Account_Customer_Manage_List);

        MythicalCafe_BackEnd_Account_Staff_List get_Account_Staff_List = new MythicalCafe_BackEnd_Account_Staff_List();
        MythicalCafe_BackEnd_Account_Staff_Manage_List get_Account_Staff_Manage_List = new MythicalCafe_BackEnd_Account_Staff_Manage_List();

        private void set_Form_Action(String set_Action)
        {
            if (set_Action == "Display Account")
            {
                if (Form_Name == Account_Customer_Manage_List.Name)                
                    Account_Customer_Manage_List.get_Action(set_Action);            

                else
                {
                    get_Account_Staff_List.Position = Form_Name;
                    get_Account_Staff_List.Action = set_Action;
                    get_Account_Staff_List.ShowDialog();
                }
            }

            else if (set_Action == "Insert Account")
            {
                if (Form_Name == Account_Customer_Manage_List.Name)                
                    Account_Customer_Manage_List.get_Action(set_Action);

                else
                {
                    get_Account_Staff_Manage_List.Position = Form_Name;
                    get_Account_Staff_Manage_List.get_Action(set_Action);
                    get_Account_Staff_Manage_List.ShowDialog();
                }
                
            }

            else if (set_Action == "Update Account")
            {
                if (Form_Name == Account_Customer_Manage_List.Name)                
                    Account_Customer_Manage_List.get_Action(set_Action);

                else
                {
                    get_Account_Staff_List.Position = Form_Name;
                    get_Account_Staff_List.Action = set_Action;
                    get_Account_Staff_List.ShowDialog();
                }
                
            }

            else if (set_Action == "Delete Account")
            {
                if (Form_Name == Account_Customer_Manage_List.Name)
                    Account_Customer_Manage_List.get_Action(set_Action);

                else 
                {
                    get_Account_Staff_List.Position = Form_Name;
                    get_Account_Staff_List.Action = set_Action;
                    get_Account_Staff_List.ShowDialog();
                }
                
            }

            else
                return;

            Close();
        }

        String Current_Action = "Select : Account Type";
        String Form_Name = "";

        private void btn_Action_Click(object sender, EventArgs e)
        {
            BunifuFlatButton get_BunifuFlatButton = (BunifuFlatButton)sender;

            if (Current_Action == "Select : Account Type")
            {
                if (get_BunifuFlatButton.Text == "Super Admin")                
                    Form_Name = "Super Admin";
                
                else if (get_BunifuFlatButton.Text == "Admin")                
                    Form_Name = "Admin";
                

                else if (get_BunifuFlatButton.Text == "Staff")                
                    Form_Name = "Staff";               

                else
                {
                    Form_Name = new MythicalCafe_BackEnd_Account_Customer_Manage_List().Name;
                    Account.Form_Name = Form_Name;
                    Account.Load += new EventHandler(Account.MythicalCafe_BackEnd_Account_Load);
                    Account.SizeChanged += new EventHandler(Account.MythicalCafe_BackEnd_Account_SizeChanged);
                }

                Current_Action = "Select : Account Action";

                btn_Action_1.Text = "Display Account";
                btn_Action_2.Text = "Insert Account";
                btn_Action_3.Text = "Update Account";
                btn_Action_4.Text = "Delete Account";
            }

            else if (Current_Action == "Select : Account Action")
            {
                set_Form_Action(get_BunifuFlatButton.Text);
            }

            else
                return;
        }
    }
}