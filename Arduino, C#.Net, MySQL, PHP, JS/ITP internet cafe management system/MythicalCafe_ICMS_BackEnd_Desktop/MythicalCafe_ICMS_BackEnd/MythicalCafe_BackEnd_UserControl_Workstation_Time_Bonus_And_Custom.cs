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
    public partial class MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom : Form
    {
        public MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom(MythicalCafe_BackEnd_UserControl_Workstation set_Control_Workstation, MythicalCafe_BackEnd_Workstation_Client set_Workstation_Client)
        {
            InitializeComponent();

            UserControl_Workstation = set_Control_Workstation;
            Workstation_Client = set_Workstation_Client;

        }

        private void MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 0.5;

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Hour, txtbx_Hour.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Minute, txtbx_Minute.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Second, txtbx_Second.Text.Trim());

            MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(txtbx_Hour);
            MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(txtbx_Minute);
            MythicalCafe_Control_Propety.set_TextBox_KeyPress_Number(txtbx_Second);
        }

        void MythicalCafe_BackEnd_UserControl_Workstation_Time_Bonus_And_Custom_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Opacity = 1;
        }

        MythicalCafe_BackEnd_UserControl_Workstation UserControl_Workstation;
        MythicalCafe_BackEnd_Workstation_Client Workstation_Client;

        void txtbx_Time_OnValueChanged(object sender, EventArgs e)
        {
            BunifuMetroTextbox get_TextBox = (BunifuMetroTextbox)sender;

            if (Int32.TryParse(get_TextBox.Text.Trim(), out Int32 _))
            {
                if (get_TextBox.Name == txtbx_Hour.Name && Int32.TryParse(get_TextBox.Text.Trim(), out Int32 _))
                    if (Convert.ToInt32(get_TextBox.Text.Trim()) > 24)
                        get_TextBox.Text = "24";

                if (get_TextBox.Name == txtbx_Minute.Name && Int32.TryParse(get_TextBox.Text.Trim(), out Int32 _))

                    if (Convert.ToInt32(get_TextBox.Text.Trim()) >= 60)
                    {
                        if (Int32.TryParse(txtbx_Hour.Text.Trim(), out Int32 _))
                        {
                            get_TextBox.Text = (Convert.ToInt32(get_TextBox.Text.Trim()) - 60).ToString();

                            txtbx_Hour.Text = (Convert.ToInt32(txtbx_Hour.Text.Trim()) + 1).ToString();
                        }

                        else
                        {
                            txtbx_Hour.Text = (Convert.ToInt32(get_TextBox.Text.Trim()) / 60).ToString();
                            get_TextBox.Text = (Convert.ToInt32(get_TextBox.Text.Trim()) % 60).ToString();
                        }                        
                    }      
                    

                if (get_TextBox.Name == txtbx_Second.Name && Int32.TryParse(get_TextBox.Text.Trim(), out Int32 _))
                    if (Convert.ToInt32(get_TextBox.Text.Trim()) > 60)
                        get_TextBox.Text = "60";

                set_Custom_Time_Total(txtbx_Hour.Text.Trim(), txtbx_Minute.Text.Trim(), txtbx_Second.Text.Trim());
            }

            else
                set_Custom_Time_Total(txtbx_Hour.Text.Trim(), txtbx_Minute.Text.Trim(), txtbx_Second.Text.Trim());
        }

        public String TimeSpan_String
        {
            get { return TimeSpan.ToString(); }
        }

        public TimeSpan TimeSpan = new TimeSpan();

        public String Charge = "";

        void set_Custom_Time_Total(String set_Hour, String set_Minute, String set_Second)
        {
            TimeSpan = new TimeSpan();

            if (TimeSpan.TryParse(set_Hour, out _))
            {
                TimeSpan = TimeSpan.Add(TimeSpan.FromHours(Convert.ToInt32(set_Hour)));
            }

            else
                TimeSpan = TimeSpan.Add(TimeSpan.FromHours(Convert.ToInt32(0)));

            if (TimeSpan.TryParse(set_Minute, out TimeSpan _))
            {
                TimeSpan = TimeSpan.Add(TimeSpan.FromMinutes(Convert.ToInt32(set_Minute)));

            }

            else
                TimeSpan = TimeSpan.Add(TimeSpan.FromMinutes(Convert.ToInt32(0)));

            if (TimeSpan.TryParse(set_Second, out TimeSpan _))
            {
                TimeSpan = TimeSpan.Add(TimeSpan.FromSeconds(Convert.ToInt32(set_Second)));
            }

            else
                TimeSpan = TimeSpan.Add(TimeSpan.FromSeconds(Convert.ToInt32(0)));

            lbl_Custom_Time_Total.Text = "Time: " + TimeSpan.ToString();

            Charge = Math.Round(TimeSpan.TotalSeconds / (3600 / Convert.ToDouble(MythicalCafe_BackEnd_Main_Method.Time_Rate)), 2).ToString();

            lbl_Charge.Text = "Charge: " + Charge;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (TimeSpan.TotalMinutes < 15 && Action != "Time Warning")
            {
                new MythicalCafe_BackEnd_Dialog("Message: Time must minimum of 15 minutes.").ShowDialog();

                return;
            }
            

            if (Action == "Time Bonus")
            {
                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Property_Information
                (
                    "Update : Specific : Time Bonus",
                    UserControl_Workstation.Customer_Identity,
                    "",
                    TimeSpan.TotalSeconds.ToString(),
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                );
                
                Workstation_Client.set_Time_Bonus(UserControl_Workstation, TimeSpan);
                
            }

            else if (Action == "Time Add")
                Workstation_Client.set_Time_Add(UserControl_Workstation, TimeSpan, Convert.ToDouble(lbl_Charge.Text.Trim().Remove(0, 8)));

            else if (Action == "Time Warning")
            {
                Close();
            }

            else          
                MythicalCafe_BackEnd_Main_Method.set_Session_Time_Custom(Workstation_Client.Identity, TimeSpan, Convert.ToDouble(lbl_Charge.Text.Trim().Remove(0, 8)));
            

            Close();
        }

        String Action = "";

        public void get_Action(String set_Action)
        {
            if (set_Action == "Time Bonus" || set_Action == "Time Warning")
            {
                lbl_Charge.Visible = false;
                lbl_Session.Visible = false;

                Action = set_Action;
            }

            else
                Action = set_Action;
        }

        private void btn_Minute_15_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtbx_Minute.Text.Trim(), out _))
                txtbx_Minute.Text = (Convert.ToInt32(txtbx_Minute.Text.Trim()) + 15).ToString();

            else
                txtbx_Minute.Text = "15";
        }

        private void btn_Minute_30_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtbx_Minute.Text.Trim(), out _))
                txtbx_Minute.Text = (Convert.ToInt32(txtbx_Minute.Text.Trim()) + 30).ToString();

            else
                txtbx_Minute.Text = "30";
        }

        private void btn_Hour_1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtbx_Hour.Text.Trim(), out _))
                txtbx_Hour.Text = (Convert.ToInt32(txtbx_Hour.Text.Trim()) + 1).ToString();

            else
                txtbx_Hour.Text = "1";
        }

        private void btn_Hour_2_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtbx_Hour.Text.Trim(), out _))
                txtbx_Hour.Text = (Convert.ToInt32(txtbx_Hour.Text.Trim()) + 2).ToString();

            else
                txtbx_Hour.Text = "2";
        }        
    }
}
