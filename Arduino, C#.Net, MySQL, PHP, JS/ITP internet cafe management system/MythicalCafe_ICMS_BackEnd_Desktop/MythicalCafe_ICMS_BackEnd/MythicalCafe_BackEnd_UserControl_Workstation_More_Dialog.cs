using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_UserControl_Workstation_More_Dialog : Form
    {
        public MythicalCafe_BackEnd_UserControl_Workstation_More_Dialog(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, MythicalCafe_BackEnd_Workstation_Client set_Workstation_Client)
        {
            InitializeComponent();

            UserControl_Workstation = set_UserControl_Workstation;
            Workstation_Client = set_Workstation_Client;

            Button_Dictionary.Add(btn_Session_Start.Name, btn_Session_Start);
            Button_Dictionary.Add(btn_Session_End.Name, btn_Session_End);

            Button_Dictionary.Add(btn_Account_Use.Name, btn_Account_Use);
            Button_Dictionary.Add(btn_Time_Custom.Name, btn_Time_Custom);
            Button_Dictionary.Add(btn_Time_Bonus.Name, btn_Time_Bonus);

            Button_Dictionary.Add(btn_Time_Pause.Name, btn_Time_Pause);
            Button_Dictionary.Add(btn_Time_Unpause.Name, btn_Time_Unpause);

            Button_Dictionary.Add(btn_Client_Move.Name, btn_Client_Move);

            Button_Dictionary.Add(btn_Computer_Lock.Name, btn_Computer_Lock);
            Button_Dictionary.Add(btn_Computer_Unlock.Name, btn_Computer_Unlock);
            Button_Dictionary.Add(btn_Message_Send.Name, btn_Message_Send);

            pnl_More_Main.Controls.Clear();

            if (String.IsNullOrEmpty(UserControl_Workstation.Session_Identity))
                set_Button_Availability("Remove : Session Button");

            else
            {
                if (set_UserControl_Workstation.Username != "Guest")
                {
                    if (set_UserControl_Workstation.Session_Action == "Time Pause")
                        set_Button_Availability("Remove : Non-Session Button : Include : btn_Time_Pause and btn_Computer_Lock and btn_Computer_Unlock");

                    else if (set_UserControl_Workstation.Session_Action == "Computer Lock")
                        set_Button_Availability("Remove : Non-Session Button : Include : btn_Time_Pause and btn_Time_Unpause and btn_Computer_Lock");

                    else
                        set_Button_Availability("Remove : Non-Session Button : Include : btn_Time_Unpause and btn_Computer_Unlock");
                }

                else
                {
                    if (set_UserControl_Workstation.Session_Action == "Time Pause")
                        set_Button_Availability("Remove : Non-Session Button : Include : btn_Time_Pause and btn_Computer_Lock and btn_Computer_Unlock");

                    else
                        set_Button_Availability("Remove : Non-Session Button : Include : btn_Time_Unpause and btn_Computer_Lock and btn_Computer_Unlock");
                }
            }
        }

        private void MythicalCafe_BackEnd_UserControl_Workstation_More_Dialog_Load(object sender, EventArgs e)
        {
            KeyDown += delegate(Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 0.5;     
        }

        private void MythicalCafe_BackEnd_UserControl_Workstation_More_Dialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 1;
        }

        MythicalCafe_BackEnd_UserControl_Workstation UserControl_Workstation;
        MythicalCafe_BackEnd_Workstation_Client Workstation_Client;

        Dictionary<String, BunifuFlatButton> Button_Dictionary = new Dictionary<String, BunifuFlatButton>();

        void set_Button_Availability(String set_Action)
        {
            //Formula : 83 * Number of Buttons + 4 (From Upper and Lower Margin)

            Int32 Counter = 0;

            if (set_Action == "Remove : Session Button")
            {
                Button_Dictionary.Remove(btn_Session_End.Name);
                Button_Dictionary.Remove(btn_Time_Bonus.Name);
                Button_Dictionary.Remove(btn_Time_Pause.Name);
                Button_Dictionary.Remove(btn_Time_Unpause.Name);
                Button_Dictionary.Remove(btn_Client_Move.Name);
                Button_Dictionary.Remove(btn_Computer_Lock.Name);
                Button_Dictionary.Remove(btn_Computer_Unlock.Name);
                Button_Dictionary.Remove(btn_Message_Send.Name);                

                Height = 249;
            }

            else if (set_Action == "Remove : Non-Session Button : Include : btn_Time_Unpause and btn_Computer_Lock and btn_Computer_Unlock")
            {
                Button_Dictionary.Remove(btn_Session_Start.Name);
                Button_Dictionary.Remove(btn_Account_Use.Name);
                Button_Dictionary.Remove(btn_Time_Custom.Name);
                Button_Dictionary.Remove(btn_Time_Unpause.Name);
                Button_Dictionary.Remove(btn_Computer_Lock.Name);
                Button_Dictionary.Remove(btn_Computer_Unlock.Name);

                Height = 415;
            }

            //Time Pause
            else if (set_Action == "Remove : Non-Session Button : Include : btn_Time_Pause and btn_Computer_Lock and btn_Computer_Unlock")
            {
                Button_Dictionary.Remove(btn_Session_Start.Name);
                Button_Dictionary.Remove(btn_Account_Use.Name);
                Button_Dictionary.Remove(btn_Time_Custom.Name);
                Button_Dictionary.Remove(btn_Time_Pause.Name);
                Button_Dictionary.Remove(btn_Computer_Lock.Name);
                Button_Dictionary.Remove(btn_Computer_Unlock.Name);

                Height = 415;
            }

            //Computer Lock
            else if (set_Action == "Remove : Non-Session Button : Include : btn_Time_Pause and btn_Time_Unpause and btn_Computer_Lock")
            {                
                Button_Dictionary.Remove(btn_Session_Start.Name);
                Button_Dictionary.Remove(btn_Account_Use.Name);
                Button_Dictionary.Remove(btn_Time_Custom.Name);
                Button_Dictionary.Remove(btn_Time_Pause.Name);
                Button_Dictionary.Remove(btn_Time_Unpause.Name);
                Button_Dictionary.Remove(btn_Computer_Lock.Name);

                Height = 415;
            }

            else if (set_Action == "Remove : Non-Session Button : Include : btn_Time_Unpause and btn_Computer_Unlock")
            {
                Button_Dictionary.Remove(btn_Session_Start.Name);
                Button_Dictionary.Remove(btn_Account_Use.Name);
                Button_Dictionary.Remove(btn_Time_Custom.Name);
                Button_Dictionary.Remove(btn_Time_Unpause.Name);
                Button_Dictionary.Remove(btn_Computer_Unlock.Name);

                Height = 498;
            }

            if (UserControl_Workstation.Session_Open_Time)
            {                
                Button_Dictionary.Remove(btn_Time_Bonus.Name);
                Button_Dictionary.Remove(btn_Time_Pause.Name);
                Button_Dictionary.Remove(btn_Time_Unpause.Name);

                Height = 249;
            }

            foreach (KeyValuePair<String, BunifuFlatButton> set_KeyValuePair in Button_Dictionary)
            {                
                pnl_More_Main.Controls.Add(set_KeyValuePair.Value, 0, Counter);
                Counter++;
            }
            

        }

        private void btn_Session_Start_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Main_Method.set_Session_Start(Workstation_Client.Identity);

            Close();
        }

        private void btn_Session_End_Click(object sender, EventArgs e)
        {
            Workstation_Client.set_Session_End(UserControl_Workstation);

            Close();
        }

        private void btn_Account_Use_Click(object sender, EventArgs e)
        {
            Opacity = 0;

            MythicalCafe_BackEnd_Account_Customer_Manage_List get_Account_Customer_Manage_List = new MythicalCafe_BackEnd_Account_Customer_Manage_List();
            get_Account_Customer_Manage_List.get_Action("Account Use");
            get_Account_Customer_Manage_List.ShowDialog();

            if (String.IsNullOrEmpty(get_Account_Customer_Manage_List.Action_Value)){ Close(); return; }
            
            MythicalCafe_BackEnd_Main_Method.check_Customer_Credential_Information(JObject.Parse(get_Account_Customer_Manage_List.Action_Value), Workstation_Client);

            Close();

        }

        private void btn_Time_Custom_Click(object sender, EventArgs e)
        {
            Opacity = 0;

            new MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom(UserControl_Workstation, Workstation_Client).ShowDialog();

            Close();
        }

        private void btn_Time_Bonus_Click(object sender, EventArgs e)
        {
            Opacity = 0;

            MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom get_UserControl_Workstation_Time_Bonus_And_Custom = new MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom(UserControl_Workstation, Workstation_Client);
            get_UserControl_Workstation_Time_Bonus_And_Custom.get_Action("Time Bonus");
            get_UserControl_Workstation_Time_Bonus_And_Custom.ShowDialog();

            Close();
        }

        private void btn_Time_Pause_Click(object sender, EventArgs e)
        {
            Workstation_Client.set_Time_Pause(UserControl_Workstation);

            Close();
        }

        private void btn_Time_Unpause_Click(object sender, EventArgs e)
        {
            Workstation_Client.set_Time_Unpause(UserControl_Workstation);

            Close();
        }

        private void btn_Client_Move_Click(object sender, EventArgs e)
        {
            Opacity = 0;

            MythicalCafe_BackEnd_Workstation_Manage_List get_MythicalCafe_BackEnd_Workstation_Manage_List = new MythicalCafe_BackEnd_Workstation_Manage_List(UserControl_Workstation);
            get_MythicalCafe_BackEnd_Workstation_Manage_List.btn_Action.Text = "Move Client";
            get_MythicalCafe_BackEnd_Workstation_Manage_List.ShowDialog();

            Close();
        }

        private void btn_Computer_Lock_Click(object sender, EventArgs e)
        {
            Workstation_Client.set_Time_Computer_Lock(UserControl_Workstation);

            Close();
        }

        private void btn_Computer_Unlock_Click(object sender, EventArgs e)
        {
            Workstation_Client.set_Time_Computer_Unlock(UserControl_Workstation);

            Close();
        }

        private void btn_Message_Send_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Message");

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                Workstation_Client.set_Client_Message(get_Dialog.Action_Value);
            }
        }
    }
}
