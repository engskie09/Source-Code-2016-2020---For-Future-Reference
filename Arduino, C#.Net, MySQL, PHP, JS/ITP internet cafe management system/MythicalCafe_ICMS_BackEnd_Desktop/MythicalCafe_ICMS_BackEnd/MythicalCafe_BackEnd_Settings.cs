using RJCP.IO.Ports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Settings : Form
    {
        public MythicalCafe_BackEnd_Settings()
        {
            InitializeComponent();            
        }

        private void MythicalCafe_BackEnd_Settings_Load(object sender, EventArgs e)
        {
            set_Control_Property();

            KeyDown += delegate(Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };                     
            

            //MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_ShortMessageService_Message("639156759556", "Gaaa!!!");


            lbl_ShortMessageService_Port_Name.Text = MythicalCafe_BackEnd_Main_Method.ShortMessageService_Port_Name;
            lbl_RadioFrequency_Port_Name.Text = MythicalCafe_BackEnd_Main_Method.RadioFrequency_Port_Name;

            Main_Thread = new Thread(delegate()
            {
                
                while (true)
                {                    
                    //RF-Reader
                    if (MythicalCafe_BackEnd_SerialPort_RadioFrequency.check_SerialPort_Connection())
                    {
                        if (MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Packet(" "))                        
                            pnl_RadioFrequency_Status.BackColor = Color.FromArgb(17, 202, 168);
                        

                        else
                        {
                            pnl_RadioFrequency_Status.BackColor = Color.FromArgb(100, 17, 202, 168);
                            MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();
                        }
                    }

                    else
                    {
                        pnl_RadioFrequency_Status.BackColor = Color.FromArgb(100, 17, 202, 168);
                        MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();

                    }

                    //SMS

                    if (MythicalCafe_BackEnd_SerialPort_ShortMessageService.check_SerialPort_Connection())
                    {
                        if (MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_SerialPort_Packet(" "))                        
                            pnl_ShortMessageService_Status.BackColor = Color.FromArgb(17, 202, 168);
                        

                        else
                        {
                            pnl_ShortMessageService_Status.BackColor = Color.FromArgb(100, 17, 202, 168);
                            MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_SerialPort_Configuration();
                        }
                    }

                    else
                    {
                        pnl_ShortMessageService_Status.BackColor = Color.FromArgb(100, 17, 202, 168);
                        MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_SerialPort_Configuration();                        

                    }


                    Thread.Sleep(500);
                }
            });

            Main_Thread.Start();

            lbl_Rate_Rent.Text = "Current Rent Rate: " + MythicalCafe_BackEnd_Main_Method.Time_Rate + " per Hour. Click to Change.";

            lbl_Rate_Staff.Text = "Current Staff Rate: " + MythicalCafe_BackEnd_Main_Method.Staff_Rate + " per Hour. Click to Change.";

            RadioFrequency_Status = MythicalCafe_BackEnd_Main_Method.RadioFrequency_Status;
            ShortMessageService_Status = MythicalCafe_BackEnd_Main_Method.ShortMessageService_Status;

            if (RadioFrequency_Status == "Enable")
                chkbx_RadioFrequency_Status.Checked = true;
            
            if (ShortMessageService_Status == "Enable")
                chkbx_ShortMessageService_Status.Checked = true;
        }

        Thread Main_Thread = null;

        private void MythicalCafe_BackEnd_Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!ReferenceEquals(Main_Thread, null))
                Main_Thread.Abort();
        }

        /* Custom Method */

        private void set_Control_Property()
        {
            cmbx_ScreenResolution.BackColor = Color.FromArgb(17, 202, 168);
            cmbx_RadioFrequency_Port_Name.BackColor = Color.FromArgb(17, 202, 168);
            cmbx_ShortMessageService_Port_Name.BackColor = Color.FromArgb(17, 202, 168);

            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);

            foreach (String set_Port_Name in SerialPortStream.GetPortNames())
            {
                img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);

                cmbx_RadioFrequency_Port_Name.Items.Add(set_Port_Name);

                cmbx_ShortMessageService_Port_Name.Items.Add(set_Port_Name);
            }            

            cmbx_ScreenResolution.SelectedIndexChanged += new System.EventHandler(this.cmbx_ScreenResolution_SelectedIndexChanged);
        }

        Color get_Color1 = MythicalCafe_Control_Propety.get_ThemeCurrentColor3;  /* 168, 130, 193 */

        private void set_Control_Color()
        {
            /*get_Color1 = Color.White;*/

            BackColor = get_Color1;
            cmbx_ScreenResolution.BackColor = Color.White;
            cmbx_ScreenResolution.ColorForDrawingRectangleAroundImage = get_Color1;
            cmbx_ScreenResolution.ControlArrowColor = get_Color1;
            cmbx_ScreenResolution.CustomControlBorderColor = get_Color1;
            cmbx_ScreenResolution.CustomPaintingColor = get_Color1;
            cmbx_ScreenResolution.DropDownWindowBackgroundColor = get_Color1;
        }

        private void set_Application_ScreenResolution(Int32 set_sizeX, Int32 set_sizeY)
        {
            Application.OpenForms[new MythicalCafe_BackEnd_Main().Name].Size = new Size(set_sizeX, set_sizeY);
        }

        /* Auto Generated Method */

        private void cmbx_ScreenResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            String [] get_sizeXY = cmbx_ScreenResolution.SelectedItem.ToString().Split(',');

            set_Application_ScreenResolution(Convert.ToInt32(get_sizeXY[0].Trim()), Convert.ToInt32(get_sizeXY[1].Trim()));
        }

        String RadioFrequency_Status = null;
        String ShortMessageService_Status = null;

        String Time_Rate = null;
        String Time_Warning = null;

        String Staff_Rate = null;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbx_RadioFrequency_Port_Name.Text))
                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Radio Frequency Port Name", cmbx_RadioFrequency_Port_Name.Text);

            if (!String.IsNullOrEmpty(cmbx_ShortMessageService_Port_Name.Text))
                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Short Message Service Port Name", cmbx_ShortMessageService_Port_Name.Text);

            if (!String.IsNullOrEmpty(Time_Rate))
                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Time Rate", Time_Rate);

            if (!String.IsNullOrEmpty(Staff_Rate))
                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Staff_Rate", Staff_Rate);



            if (RadioFrequency_Status != MythicalCafe_BackEnd_Main_Method.RadioFrequency_Status)
                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Radio Frequency Status", RadioFrequency_Status);

            if (ShortMessageService_Status != MythicalCafe_BackEnd_Main_Method.ShortMessageService_Status)
                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Short Message Service Status", ShortMessageService_Status);

            if (!String.IsNullOrEmpty(Time_Warning) && Time_Warning != MythicalCafe_BackEnd_Main_Method.Time_Warning)
                MythicalCafe_BackEnd_Main_Method.update_System_Configuration("Update : Specific : Time Warning", Time_Warning);

            Main_Thread.Abort();

            Close();
        }        


        private void lbl_Device_Manager_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void chkbx_RadioFrequency_Status_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_RadioFrequency_Status.Checked)
                RadioFrequency_Status = "Enable";
            else
                RadioFrequency_Status = "Disable";
        }
        private void chkbx_ShortMessageService_Status_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_ShortMessageService_Status.Checked)
                ShortMessageService_Status = "Enable";
            else
                ShortMessageService_Status = "Disable";
        }

        private void btn_Time_Warning_List_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Settings_Time_Warning get_Settings_Time_Warning = new MythicalCafe_BackEnd_Settings_Time_Warning();
            
            if (get_Settings_Time_Warning.ShowDialog() == DialogResult.OK)
            {

            }

            Time_Warning = get_Settings_Time_Warning.Time_Warning_List;
        }

        private void lbl_ShortMessageService_Port_Name_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Contact Number");            

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            { 
                String get_ContactNumber = get_Dialog.Action_Value;                

                get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Message");

                if (get_Dialog.ShowDialog() == DialogResult.OK)                
                    MythicalCafe_BackEnd_SerialPort_ShortMessageService.set_ShortMessageService_Message(get_ContactNumber, get_Dialog.Action_Value);
                
            }
        }

        private void lbl_Rate_Rent_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Rate");

            get_Dialog.btn_No.Text = "Close";

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                Time_Rate = get_Dialog.Action_Value;
                lbl_Rate_Rent.Text = "Current Time Rate: " + Time_Rate + " per Hour. Click to Change.";
            }
        }

        private void lbl_Rate_Staff_Click(object sender, EventArgs e)
        {
            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Rate");

            get_Dialog.btn_No.Text = "Close";

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                Staff_Rate = get_Dialog.Action_Value;
                lbl_Rate_Staff.Text = "Current Staff Rate: " + Staff_Rate + " per Hour. Click to Change.";
            }
        }
    }
}
