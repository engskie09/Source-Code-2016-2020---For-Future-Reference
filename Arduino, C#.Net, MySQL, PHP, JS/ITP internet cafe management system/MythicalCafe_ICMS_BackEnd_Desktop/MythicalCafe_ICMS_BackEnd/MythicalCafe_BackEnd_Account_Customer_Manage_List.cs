using Bunifu.Framework.UI;
using Mocean;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public partial class MythicalCafe_BackEnd_Account_Customer_Manage_List : Form
    {
        public MythicalCafe_BackEnd_Account_Customer_Manage_List()
        {
            InitializeComponent();            
        }

        void MythicalCafe_BackEnd_Account_Customer_Manage_List_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (btn_Action.Text == "Account Use")
            {
                KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
                {
                    MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
                };                
            }

            else
                Size = new Size(Parent.Size.Width, Parent.Size.Height);



            //get_Panel_Border_Color(pnl_Personal_Information);
            //get_Panel_Border_Color(pnl_Credential_Information);
            //get_Panel_Border_Color(pnl_Property_Information);

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Search_Account, txtbx_Search_Account.Text);

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_FirstName, txt_User_FirstName.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_MiddleName, txt_User_MiddleName.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_LastName, txt_User_LastName.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_EmailAddress, txt_User_EmailAddress.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_ContactNumber, txt_User_ContactNumber.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_HomeAddress, txt_User_HomeAddress.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_Description, txt_User_Description.Text.Trim());

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_Name, txt_User_Name.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txt_User_Password, txt_User_Password.Text.Trim());

            MythicalCafe_Control_Propety.set_TextBox_Character_Password(txt_User_Password);

            pnl_User_Gender.BorderColoreFocused = Color.White;
            pnl_User_Gender.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            pnl_User_Identity.BorderColoreFocused = Color.White;
            pnl_User_Identity.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            pnl_User_BirthDate.BorderColoreFocused = Color.White;
            pnl_User_BirthDate.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            pnl_User_Image.BorderColoreFocused = Color.White;
            pnl_User_Image.BorderColoreIdle = Color.FromArgb(17, 202, 168);
            
            pnl_User_RadioFrequency_Identification.BorderColoreFocused = Color.White;
            pnl_User_RadioFrequency_Identification.BorderColoreIdle = Color.FromArgb(17, 202, 168);

            cmbx_Search_Filter.BackColor = Color.FromArgb(118, 106, 255);

            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);
            img_Arrow.Images.Add(Properties.Resources.icon_ArrowUp_FFFFFF);

            cmbx_Search_Filter.SelectedIndex = 0;


            dt_User_BirthDate.MaxValue = DateTime.Now.AddYears(-5);
            dt_User_BirthDate.MinValue = new DateTime(1950, 1, 1);
            dt_User_BirthDate.CustomFormat = "dd-MM-yyyy";
            dt_User_BirthDate.Value = new DateTime(1998, 1, 30);

            pnl_Account_Manage_List.SetRow(pnl_Account_Information, 3);
            pnl_Account_Manage_List.SetRow(dgv_Account, 1);
            
            pnl_Account_Information_BackgroundWorker.DoWork += pnl_Account_Information_BackgroundWorker_DoWork;

            pnl_Account_Information_BackgroundWorker.RunWorkerCompleted += pnl_Account_Information_BackgroundWorker_RunWorkerCompleted;

            pnl_Account_Information_BackgroundWorker.RunWorkerAsync(10);

            pnl_Account_Manage_List.BackColor = Color.FromArgb(0,0,0,0);

            /*var get_Credentials = new Credentials()
            {
                mocean_api_key = "615424c8",
                mocean_api_secret = "6c425b5a"
            };

            var get_Message_Information = new Mocean.Message.Message()
            {
                mocean_to = "123123",
                mocean_from = "Your Rafael ^_^",
                mocean_text = "XDD"
            };
            
            Mocean.Message.Client.Send(get_Message_Information, get_Credentials);*/

            Thread_Customer_Manage_List = new Thread(delegate ()
            {
                while (true)
                {
                    if (MythicalCafe_BackEnd_SerialPort_RadioFrequency.check_SerialPort_Connection())
                    {
                        if (!MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Packet(" "))
                            MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();
                    }

                    else
                        MythicalCafe_BackEnd_SerialPort_RadioFrequency.set_SerialPort_Configuration();

                    String get_Packet = MythicalCafe_BackEnd_SerialPort_RadioFrequency.get_SerialPort_Packet().Trim();
                    
                    if (String.IsNullOrEmpty(get_Packet) || get_Packet.Length != 10) return;
                    
                    lbl_User_RadioFrequency_Identification.Text = get_Packet;

                    Thread.Sleep(100);
                }
            });

            if(MythicalCafe_BackEnd_Main_Method.RadioFrequency_Status == "Enable")
                Thread_Customer_Manage_List.Start();


            Disposed += set_Dispose;
        }

        /* Customized Method */
        Thread Thread_Customer_Manage_List = null;

        private void set_Dispose(Object set_Object, EventArgs set_EventArgs)
        {
            if (!ReferenceEquals(Thread_Customer_Manage_List, null))
                Thread_Customer_Manage_List.Abort();

            if (MythicalCafe_BackEnd_SerialPort_RadioFrequency.SerialPortStream.IsOpen)
                MythicalCafe_BackEnd_SerialPort_RadioFrequency.SerialPortStream.Close();
        }

        Int32 Counter = 0;

        List<String> get_ImagePath_List = new List<String>();

        void set_dgv_Account_Value()
        {
            get_ImagePath_List.Clear();

            MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Personal_Information("Select : All", "");
            
            get_ImagePath_List = (from row in MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.Account_DataTable_1.AsEnumerable() select row["Customer_Image_Path"].ToString()).ToList();

            DataColumn get_DataColumn = new DataColumn();
            get_DataColumn.ColumnName = "Customer_Image_Path";
            get_DataColumn.DataType = typeof(Byte[]);
            get_DataColumn.AllowDBNull = true;

            MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.Account_DataTable_1.Columns.Remove("Customer_Image_Path");

            MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.Account_DataTable_1.Columns.Add(get_DataColumn);

            Counter = 0;
            
            foreach (DataRow set_DataRow in MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.Account_DataTable_1.Rows)
            {

                if (Counter + 1 > get_ImagePath_List.Count)
                    break;
                
                if (File.Exists(get_ImagePath_List[Counter]))
                {                    

                    using (Bitmap set_Bitmap = new Bitmap(get_ImagePath_List[Counter]))
                    {
                        MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.Account_DataTable_1.Rows[Counter]["Customer_Image_Path"] = new ImageConverter().ConvertTo(set_Bitmap, typeof(Byte[]));
                        Counter ++;
                    }                    
                }
                else
                    Counter++;
            }

            dgv_Account.DataSource = null;

            dgv_Account.AutoGenerateColumns = false;

            dgv_Account.Columns["Customer_Image"].DataPropertyName = "Customer_Image_Path";
            dgv_Account.Columns["Customer_Identity"].DataPropertyName = "Customer_Identity";
            dgv_Account.Columns["Customer_FullName"].DataPropertyName = "Customer_FullName";
            dgv_Account.Columns["Customer_Gender"].DataPropertyName = "Customer_Gender";
            dgv_Account.Columns["Customer_BirthDate"].DataPropertyName = "Customer_BirthDate";
            dgv_Account.Columns["Customer_Description"].DataPropertyName = "Customer_Description";
            dgv_Account.Columns["Customer_Registration_DateTime"].DataPropertyName = "Customer_Registration_DateTime";
            dgv_Account.Columns["Customer_LastUsed_DateTime"].DataPropertyName = "Customer_LastUsed_DateTime";
            
            dgv_Account.DataSource = MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.Account_DataTable_1;
        }

        MemoryStream MemoryStream = null;

        void get_Image()
        {
            OpenFileDialog get_OpenFileDialog = new OpenFileDialog();           

            get_OpenFileDialog.Filter = "Choose Image(*.jpg; *.png; *gif|*.jpg; *.png; *.gif";

            if (get_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream set_FileStream = new FileStream(get_OpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    MemoryStream = new MemoryStream();

                    btn_User_Image.Image = Image.FromStream(set_FileStream);
                    btn_User_Image.Image.Save(MemoryStream, btn_User_Image.Image.RawFormat);

                    get_ImagePath = "Images/" + lbl_User_Identity.Text + ".png";
                }
            }
        }

        String[] get_Personal_Information_Array = new String[0];
        String[] get_Credential_Information_Array = new String[0];
        String[] get_Property_Information_Array = new String[0];

        String get_ImagePath = null;

        void get_Account_Information_Value()
        {
            get_Personal_Information_Array = new String[14];

            get_Personal_Information_Array[1] = lbl_User_Identity.Text.Trim();
            get_Personal_Information_Array[2] = txt_User_FirstName.Text.Trim();
            get_Personal_Information_Array[3] = txt_User_MiddleName.Text.Trim();
            get_Personal_Information_Array[4] = txt_User_LastName.Text.Trim();

            get_Personal_Information_Array[5] = txt_User_EmailAddress.Text.Trim();
            get_Personal_Information_Array[6] = txt_User_ContactNumber.Text.Trim();
            get_Personal_Information_Array[7] = txt_User_HomeAddress.Text.Trim();

            if (btn_Female.Checked)
                get_Personal_Information_Array[8] = "Female";
            else
                get_Personal_Information_Array[8] = "Male";

            get_Personal_Information_Array[9] = Convert.ToDateTime(dt_User_BirthDate.Value).ToString("yyyy-MM-dd");
            get_Personal_Information_Array[10] = txt_User_Description.Text.Trim();
            get_Personal_Information_Array[11] = get_ImagePath;
            get_Personal_Information_Array[12] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            get_Personal_Information_Array[13] = "0";           

            if (btn_Action.Text == "Insert Account")
            {
                get_Property_Information_Array = new String[11];

                get_Property_Information_Array[1] = lbl_User_Identity.Text.Trim();
                get_Property_Information_Array[2] = TimeSpan_Time_Remaining.TotalSeconds.ToString();
                get_Property_Information_Array[3] = TimeSpan_Time_Bonus.TotalSeconds.ToString();
                get_Property_Information_Array[4] = "0";
                get_Property_Information_Array[5] = Cash_Remaining;
                get_Property_Information_Array[6] = "0";
                get_Property_Information_Array[7] = Point_Remaining;
                get_Property_Information_Array[8] = "0";
                get_Property_Information_Array[9] = Debt_Remaining;
                get_Property_Information_Array[10] = Debt_Maximum;

                get_Credential_Information_Array = new String[7];

                get_Credential_Information_Array[1] = lbl_User_Identity.Text.Trim();
                get_Credential_Information_Array[2] = txt_User_Name.Text.Trim();
                get_Credential_Information_Array[3] = txt_User_Password.Text.Trim();
                get_Credential_Information_Array[4] = lbl_User_RadioFrequency_Identification.Text.Trim();
                get_Credential_Information_Array[5] = "Active";
                get_Credential_Information_Array[6] = "Active : Offline";
            }

            else if (btn_Action.Text == "Update Account")
            {
                get_Property_Information_Array = new String[12];

                get_Property_Information_Array[1] = "Update : Specific : Except { Cash Spent, Point Spent, Time Spent }";
                get_Property_Information_Array[2] = lbl_User_Identity.Text.Trim();
                get_Property_Information_Array[3] = TimeSpan_Time_Remaining.TotalSeconds.ToString();
                get_Property_Information_Array[4] = TimeSpan_Time_Bonus.TotalSeconds.ToString();
                get_Property_Information_Array[5] = "";
                get_Property_Information_Array[6] = Cash_Remaining;
                get_Property_Information_Array[7] = "";
                get_Property_Information_Array[8] = Point_Remaining;
                get_Property_Information_Array[9] = "";
                get_Property_Information_Array[10] = Debt_Remaining;
                get_Property_Information_Array[11] = Debt_Maximum;

                get_Credential_Information_Array = new String[8];

                get_Credential_Information_Array[1] = "Update : Specific";
                get_Credential_Information_Array[2] = lbl_User_Identity.Text.Trim();
                get_Credential_Information_Array[3] = txt_User_Name.Text.Trim();
                get_Credential_Information_Array[4] = txt_User_Password.Text.Trim();
                get_Credential_Information_Array[5] = lbl_User_RadioFrequency_Identification.Text.Trim();
                get_Credential_Information_Array[6] = User_RadioFrequency_Identification_Status;
                get_Credential_Information_Array[7] = User_Status;

            }

            else
            {
                get_Property_Information_Array = new String[2];
                get_Property_Information_Array[1] = lbl_User_Identity.Text.Trim();
            }

        }

        void get_Panel_Border_Color(Panel set_Panel)
        {
            set_Panel.Paint += set_Panel_Border_Color;
        }

        void set_Panel_Border_Color(Object set_Object, PaintEventArgs e)
        {
            Rectangle rectangle = e.ClipRectangle;
            rectangle.Width--;
            rectangle.Height--;

            using (Pen pen = new Pen(Color.FromArgb(17, 202, 168), 1))
            {
                e.Graphics.DrawRectangle(pen, rectangle);
            }
        }

        BackgroundWorker pnl_Account_Information_BackgroundWorker = new BackgroundWorker();

        void pnl_Account_Information_BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            pnl_Account_Information.CellPaint += delegate (Object set_Object, TableLayoutCellPaintEventArgs set_TableLayoutCellPaintEventArgs)
            {
                TableLayoutPanel get_Panel = (TableLayoutPanel)set_Object;

                if (Object.ReferenceEquals(get_Panel.GetControlFromPosition(set_TableLayoutCellPaintEventArgs.Column, set_TableLayoutCellPaintEventArgs.Row), null))
                    return;
                
                set_TableLayoutCellPaintEventArgs.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                Rectangle rectangle = set_TableLayoutCellPaintEventArgs.CellBounds;

                using (Pen pen = new Pen(Color.FromArgb(17, 202, 168), 1))
                {
                    pen.Alignment = PenAlignment.Inset;
                    pen.DashStyle = DashStyle.Solid;

                    if (set_TableLayoutCellPaintEventArgs.Row != 0)
                    {
                        if (set_TableLayoutCellPaintEventArgs.Row == (get_Panel.RowCount - 1))
                        {
                            rectangle.Height -= 1;
                        }

                        if (set_TableLayoutCellPaintEventArgs.Column == (get_Panel.ColumnCount - 1))
                        {
                            rectangle.Width -= 1;
                        }

                        set_TableLayoutCellPaintEventArgs.Graphics.DrawRectangle(pen, rectangle);
                    }
                }
            };
        }

        void pnl_Account_Information_BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnl_Account_Information_BackgroundWorker.Dispose();
        }

        public void get_Action(String set_Action)
        {
            set_Control_Property();

            if (set_Action == "Display Account")
            {
                btn_Action.Text = "Action Account";

                pnl_Account_Manage_List.SetRow(pnl_Account_Information, 3);

                pnl_Account_Manage_List.SetRow(dgv_Account, 1);
            }

            else if (set_Action == "Insert Account")
            {
                btn_Action.Text = "Insert Account";

                pnl_Account_Manage_List.SetRow(dgv_Account, 2);

                pnl_Account_Manage_List.SetRow(pnl_Account_Information, 1);
            }

            else if (set_Action == "Update Account")
            {
                btn_Action.Text = "Update Account";

                pnl_Account_Manage_List.SetRow(pnl_Account_Information, 3);

                pnl_Account_Manage_List.SetRow(dgv_Account, 1);
            }

            else if (set_Action == "Delete Account")
            {
                pnl_Account_Manage_List.SetRow(pnl_Account_Information, 3);

                pnl_Account_Manage_List.SetRow(dgv_Account, 1);

                btn_Action.Text = "Delete Account";
            }

            else if (set_Action == "Account Use")
            {
                btn_Action.Text = "Account Use";

                pnl_Account_Manage_List.SetRow(pnl_Account_Information, 3);

                pnl_Account_Manage_List.SetRow(dgv_Account, 1);
            }

            else
                return;

            set_dgv_Account_Value();
        }
        
        void set_Control_Property()
        {
            Action_Value = null;

            lbl_User_Identity.Text = MythicalCafe_BackEnd_Main_Method.Customer_Identity_Code  + "-" + MythicalCafe_BackEnd_Main_Method.Branch_Identity + "-" + (MythicalCafe_BackEnd_Main_Method.get_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Customer_Identity_Code) + 1000).ToString();

            txt_User_FirstName.Text = "First Name";
            txt_User_MiddleName.Text = "Middle Name";
            txt_User_LastName.Text = "Last Name";
            txt_User_EmailAddress.Text = "Email Address";
            txt_User_ContactNumber.Text = "Contact Number";
            txt_User_HomeAddress.Text = "Home Address";

            btn_Female.Checked = true;

            dt_User_BirthDate.Value = new DateTime(1998, 1, 30);

            txt_User_Description.Text = "Description";

            btn_User_Image.Image = Properties.Resources.icon_ArrowUp_FFFFFF;

            get_ImagePath = null;

            txt_User_Name.Text = "Username";
            txt_User_Password.Text = "Password";

            lbl_User_RadioFrequency_Identification.Text = "---------";

            Cash_Remaining = "0";
            Point_Remaining = "0";
            Debt_Remaining = "0";
            Debt_Maximum = "0";

            TimeSpan_Time_Total = new TimeSpan();
            TimeSpan_Time_Bonus = new TimeSpan();
            TimeSpan_Time_Remaining = new TimeSpan();
        }
        
        /* Auto Generated Method */
        void btn_User_Image_Click(object sender, EventArgs e)
        {
            get_Image();
        }

        void lbl_User_Image_Click(object sender, EventArgs e)
        {
            get_Image();
        }

        void pnl_User_Image_Click(object sender, EventArgs e)
        {
            get_Image();
        }

        void btn_Action_Click(object sender, EventArgs e)
        {
            get_Account_Information_Value();

            MythicalCafe_BackEnd_Main_Method.check_Directory_Availability(MythicalCafe_BackEnd_Main_Method.Image_Directory_Path);

            if (btn_Action.Text == "Insert Account")
            {
                if (MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Credential_Information
                (
                    "Select : Specific : Customer_UserName",
                    null,
                    null,
                    get_Credential_Information_Array[2]
                ))
                {
                    new MythicalCafe_BackEnd_Dialog("Message: Username already exist.").ShowDialog();
                    return;
                }

                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.insert_Customer_Personal_Information
                (
                    get_Personal_Information_Array[1],
                    get_Personal_Information_Array[2],
                    get_Personal_Information_Array[3],
                    get_Personal_Information_Array[4],
                    get_Personal_Information_Array[5],
                    get_Personal_Information_Array[6],
                    get_Personal_Information_Array[7],
                    get_Personal_Information_Array[8],
                    get_Personal_Information_Array[9],
                    get_Personal_Information_Array[10],
                    get_Personal_Information_Array[11],
                    get_Personal_Information_Array[12],
                    get_Personal_Information_Array[13]

                );

                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.insert_Customer_Credential_Information
                (
                    get_Credential_Information_Array[1],
                    get_Credential_Information_Array[2],
                    get_Credential_Information_Array[3],
                    get_Credential_Information_Array[4],
                    get_Credential_Information_Array[5],
                    get_Credential_Information_Array[6]
                );

                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.insert_Customer_Property_Information
                (
                    get_Property_Information_Array[1],
                    get_Property_Information_Array[2],
                    get_Property_Information_Array[3],
                    get_Property_Information_Array[4],
                    get_Property_Information_Array[5],
                    get_Property_Information_Array[6],
                    get_Property_Information_Array[7],
                    get_Property_Information_Array[8],
                    get_Property_Information_Array[9],
                    get_Property_Information_Array[10]
                );

                if (!Object.ReferenceEquals(MemoryStream, null) && !String.IsNullOrEmpty(get_ImagePath))
                {
                    File.WriteAllBytes(get_ImagePath, MemoryStream.ToArray());

                    MemoryStream.Close();
                }

                MythicalCafe_BackEnd_Main_Method.set_Current_Identity_Count(MythicalCafe_BackEnd_Main_Method.Customer_Identity_Code);
            }

            else if (btn_Action.Text == "Update Account")
            {
                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Personal_Information
                (
                    get_Personal_Information_Array[1],
                    get_Personal_Information_Array[2],
                    get_Personal_Information_Array[3],
                    get_Personal_Information_Array[4],
                    get_Personal_Information_Array[5],
                    get_Personal_Information_Array[6],
                    get_Personal_Information_Array[7],
                    get_Personal_Information_Array[8],
                    get_Personal_Information_Array[9],
                    get_Personal_Information_Array[10],
                    get_Personal_Information_Array[11],
                    get_Personal_Information_Array[12],
                    get_Personal_Information_Array[13]

                );

                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Credential_Information
                (
                    get_Credential_Information_Array[1],
                    get_Credential_Information_Array[2],
                    get_Credential_Information_Array[3],
                    get_Credential_Information_Array[4],
                    get_Credential_Information_Array[5],
                    get_Credential_Information_Array[6],
                    get_Credential_Information_Array[7]
                );

                MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.update_Customer_Property_Information
                (
                    get_Property_Information_Array[1],
                    get_Property_Information_Array[2],
                    get_Property_Information_Array[3],
                    get_Property_Information_Array[4],
                    get_Property_Information_Array[5],
                    get_Property_Information_Array[6],
                    get_Property_Information_Array[7],
                    get_Property_Information_Array[8],
                    get_Property_Information_Array[9],
                    get_Property_Information_Array[10],
                    get_Property_Information_Array[11]
                );

                if (!Object.ReferenceEquals(MemoryStream, null))
                {
                    File.WriteAllBytes(get_ImagePath, MemoryStream.ToArray());

                    MemoryStream.Close();
                }

                if (Cash_Remaining_Changed)                
                    MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.insert_Customer_Report_Information(get_Property_Information_Array[2], Cash_Remaining_Added, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                

                dynamic get_Customer_Session_Information = MythicalCafe_BackEnd_Workstation_Method.select_Session_Information
                (
                    "Select : Specific : Active", 
                    "User_Identity", 
                    lbl_User_Identity.Text.Trim()
                );

                if (!(get_Customer_Session_Information is Boolean))                
                    get_Customer_Session_Information = JObject.Parse(JObject.Parse(get_Customer_Session_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                    
                
            }

            else if (btn_Action.Text == "Delete Account")
            {
                set_Account_Delete();
            }

            else
                return;           

            get_Action("Display Account");
        }

        void set_Account_Delete()
        {
            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Are you sure you want to Delete this Account?");

            if (get_Dialog.ShowDialog() != DialogResult.OK)
                return;

            MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.delete_Customer_Personal_Information
            (
                get_Personal_Information_Array[1]
            );

            MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.delete_Customer_Credential_Information
            (
                get_Credential_Information_Array[1]
            );

            MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.delete_Customer_Property_Information
            (
                get_Property_Information_Array[1]
            );
        }

        void dt_User_BirthDate_TextChanged(Object set_Object, EventArgs set_EventArgs)
        {
            DateTime get_DateTime;

            if (!DateTime.TryParse(dt_User_BirthDate.Value.ToString(), out get_DateTime))
            {
                dt_User_BirthDate.Value = new DateTime(1998, 1, 30);
            }
        }

        void dt_User_BirthDate_MouseCaptureChanged(object sender, EventArgs e)
        {
            DateTime get_DateTime;

            if (!DateTime.TryParse(dt_User_BirthDate.Value.ToString(), out get_DateTime))
            {
                dt_User_BirthDate.Value = new DateTime(1998, 1, 30);
            }
        }

        public String Action_Value = null;

        String User_RadioFrequency_Identification_Status = null;
        String User_Status = null;

        JObject Customer_Information = null;
        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex >= 0))
                return;

            DataGridViewRow get_DataGridViewRow = dgv_Account.Rows[e.RowIndex];

            if (btn_Action.Text == "Update Account" || btn_Action.Text == "Account Use")
            {
                txt_User_Name.Enabled = false;

                //Call select_Customer_Personal_Information();
                Customer_Information = JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Personal_Information("Select : Specific", get_DataGridViewRow.Cells[1].Value.ToString()));
                Customer_Information = JObject.Parse(Customer_Information["Table"].ToString().TrimStart('[').TrimEnd(']'));

                lbl_User_Identity.Text = Customer_Information["Customer_Identity"].ToString();
                txt_User_FirstName.Text = Customer_Information["Customer_FirstName"].ToString();
                txt_User_MiddleName.Text = Customer_Information["Customer_MiddleName"].ToString();
                txt_User_LastName.Text = Customer_Information["Customer_LastName"].ToString();
                txt_User_EmailAddress.Text = Customer_Information["Customer_EmailAddress"].ToString();
                txt_User_ContactNumber.Text = Customer_Information["Customer_ContactNumber"].ToString();
                txt_User_HomeAddress.Text = Customer_Information["Customer_HomeAddress"].ToString();

                if (Customer_Information["Customer_Gender"].ToString() == "Female")
                    btn_Female.Checked = true;
                else
                    btn_Male.Checked = true;

                txt_User_Description.Text = Customer_Information["Customer_Description"].ToString();

                dt_User_BirthDate.Value = Convert.ToDateTime(Customer_Information["Customer_BirthDate"].ToString());

                if (File.Exists(Customer_Information["Customer_Image_Path"].ToString()))
                {
                    using (FileStream set_FileStream = new FileStream(Customer_Information["Customer_Image_Path"].ToString(), FileMode.Open, FileAccess.Read))
                    {
                        MemoryStream = new MemoryStream();

                        btn_User_Image.Image = Image.FromStream(set_FileStream);
                        btn_User_Image.Image.Save(MemoryStream, btn_User_Image.Image.RawFormat);

                        get_ImagePath = "Images/" + lbl_User_Identity.Text + ".png";                        
                    }                    
                }

                //Call select_Customer_Credential_Information();
                Customer_Information = JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Credential_Information("Select : Specific", null, get_DataGridViewRow.Cells[1].Value.ToString(), ""));
                Customer_Information = JObject.Parse(Customer_Information["Table"].ToString().TrimStart('[').TrimEnd(']'));

                txt_User_Name.Text = Customer_Information["Customer_UserName"].ToString();
                txt_User_Password.Text = Customer_Information["Customer_Password"].ToString();
                lbl_User_RadioFrequency_Identification.Text = Customer_Information["Customer_RadioFrequency_Identification"].ToString();
                User_RadioFrequency_Identification_Status = Customer_Information["Customer_RadioFrequency_Identification_Status"].ToString();
                User_Status = Customer_Information["Customer_Status"].ToString();

                //Call select_Customer_Property_Information();
                Customer_Information = JObject.Parse(MythicalCafe_BackEnd_Account_Customer_Manage_List_Method.select_Customer_Property_Information("Select : Specific", get_DataGridViewRow.Cells[1].Value.ToString()));
                Customer_Information = JObject.Parse(Customer_Information["Table"].ToString().TrimStart('[').TrimEnd(']'));

                TimeSpan_Time_Remaining = TimeSpan.FromSeconds(Convert.ToDouble(Customer_Information["Time_Remaining"]));
                TimeSpan_Time_Bonus = TimeSpan.FromSeconds(Convert.ToDouble(Customer_Information["Time_Bonus"]));

                TimeSpan_Time_Total = TimeSpan_Time_Total.Add(TimeSpan_Time_Remaining);
                TimeSpan_Time_Total = TimeSpan_Time_Total.Add(TimeSpan_Time_Bonus);

                Cash_Remaining = Customer_Information["Cash_Remaining"].ToString();
                Point_Remaining = Customer_Information["Point_Remaining"].ToString();
                Debt_Remaining = Customer_Information["Debt_Remaining"].ToString();
                Debt_Maximum = Customer_Information["Debt_Maximum"].ToString();

                lbl_Time_Remaining.Text = "Remaining Time: " + TimeSpan_Time_Remaining.ToString();

                Customer_Information = null;

                if (btn_Action.Text == "Account Use")
                {
                    if (TimeSpan_Time_Total.TotalSeconds <= 0)
                    {
                        Opacity = 0.5;

                        new MythicalCafe_BackEnd_Dialog("Message: Sorry insufficient Time.").ShowDialog();

                        Close();

                        return;
                    }

                    Action_Value = "{ 'Username' : '" + txt_User_Name.Text + "', 'Password' : '" + txt_User_Password.Text + "'  }";

                    Close();

                    return;
                }


                pnl_Account_Manage_List.SetRow(dgv_Account, 2);

                pnl_Account_Manage_List.SetRow(pnl_Account_Information, 1);
            }

            else if (btn_Action.Text == "Delete Account")
            {
                set_Account_Delete();

                set_dgv_Account_Value();
                /*lbl_User_Identity.Text = get_DataGridViewRow.Cells[1].Value.ToString();

                MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Are you sure you want to Delete this Account?");

                if (get_Dialog.ShowDialog() == DialogResult.OK)
                {
                    
                }*/
            }

            else
                return;


        }

        void txt_User_Password_Enter(object sender, EventArgs e)
        {
            txt_User_Password.isPassword = true;
        }

        void txt_User_Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_User_Password.Text.Trim()))
            {
                txt_User_Password.isPassword = false;
            }
        }
        TimeSpan TimeSpan_Time_Bonus { get { return TimeSpan.Parse(lbl_Time_Bonus.Text.Remove(0, 12)); } set { lbl_Time_Bonus.Text = "Bonus Time: " + value.ToString(); } }
        TimeSpan TimeSpan_Time_Remaining { get { return TimeSpan.Parse(lbl_Time_Remaining.Text.Remove(0, 16)); } set { lbl_Time_Remaining.Text = "Remaining Time: " + value.ToString(); } }
        TimeSpan TimeSpan_Time_Total { get { return TimeSpan.Parse(lbl_Time_Total.Text.Remove(0, 12)); } set { lbl_Time_Total.Text = "Total Time: " + value.ToString(); } }

        String Cash_Remaining { get { return lbl_Cash_Remaining.Text.Remove(0, 18); } set { lbl_Cash_Remaining.Text = "Remaining M-Cash: " + value; } }
        String Point_Remaining { get { return lbl_Point_Total.Text.Remove(0, 18); } set { lbl_Point_Total.Text = "Remaining Points: " + value; } }
        String Debt_Remaining { get { return lbl_Debt_Remaining.Text.Remove(0, 16); } set { lbl_Debt_Remaining.Text = "Remaining Debt: " + value; } }
        String Debt_Maximum { get { return lbl_Debt_Maximum.Text.Remove(0, 14); } set { lbl_Debt_Maximum.Text = "Maximum Debt: " +  value; } }
        
        private void lbl_Time_Remaining_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Delete Account")
                return;

            MythicalCafe_BackEnd_Account_Manage_List_Property_Information_Time get_Account_Manage_List_Property_Information_Time = new MythicalCafe_BackEnd_Account_Manage_List_Property_Information_Time();

            if (get_Account_Manage_List_Property_Information_Time.ShowDialog() == DialogResult.OK)
            {                
                if (Convert.ToDouble(get_Account_Manage_List_Property_Information_Time.Charge) > Convert.ToDouble(Cash_Remaining))
                {
                    MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Choice: Insufficient M-Cash if you proceed, it will be added as Debt.");

                    if (get_Dialog.ShowDialog() == DialogResult.OK)
                    {
                        Double get_Debt_Remaining = Convert.ToDouble(Debt_Remaining) + Convert.ToDouble(get_Account_Manage_List_Property_Information_Time.Charge);

                        if (get_Debt_Remaining > Convert.ToDouble(Debt_Maximum))
                        {                            
                            get_Dialog.get_Action("Message: Sorry but this user can only Debt up to " + Debt_Maximum + " only.");
                            get_Dialog.ShowDialog();

                            return;
                        }

                        else
                        {
                            Debt_Remaining = (Convert.ToDouble(Debt_Remaining) + ( -1 * (Convert.ToDouble(Cash_Remaining) - Convert.ToDouble(get_Account_Manage_List_Property_Information_Time.Charge)))).ToString();
                            Cash_Remaining = "0";
                        }
                    }

                    else
                        return;
                }
                
                else
                    Cash_Remaining = (Convert.ToDouble(Cash_Remaining) - Convert.ToDouble(get_Account_Manage_List_Property_Information_Time.Charge)).ToString();

                Point_Remaining = (Convert.ToDouble(Point_Remaining) + Convert.ToDouble(get_Account_Manage_List_Property_Information_Time.Points)).ToString();                

                TimeSpan_Time_Remaining = TimeSpan_Time_Remaining.Add(get_Account_Manage_List_Property_Information_Time.TimeSpan);

                TimeSpan_Time_Total = new TimeSpan();
                TimeSpan_Time_Total = TimeSpan_Time_Total.Add(TimeSpan_Time_Remaining);
                TimeSpan_Time_Total = TimeSpan_Time_Total.Add(TimeSpan_Time_Bonus);                                             
            }
        }

        void lbl_Time_Bonus_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Delete Account")
                return;

            MythicalCafe_BackEnd_Account_Manage_List_Property_Information_Time get_Account_Manage_List_Property_Information_Time = new MythicalCafe_BackEnd_Account_Manage_List_Property_Information_Time();

            get_Account_Manage_List_Property_Information_Time.get_Action("Time Bonus");

            if (get_Account_Manage_List_Property_Information_Time.ShowDialog() == DialogResult.OK)
            {
                TimeSpan_Time_Bonus = TimeSpan_Time_Bonus.Add(get_Account_Manage_List_Property_Information_Time.TimeSpan);

                TimeSpan_Time_Total = new TimeSpan();
                TimeSpan_Time_Total = TimeSpan_Time_Total.Add(TimeSpan_Time_Remaining);
                TimeSpan_Time_Total = TimeSpan_Time_Total.Add(TimeSpan_Time_Bonus);               
            }
        }

        //Detect if Cash Remaining has changed
        Boolean Cash_Remaining_Changed = false;
        String Cash_Remaining_Added = "";

        private void lbl_Cash_Remaining_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Delete Account")
                return;

            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: M-Cash Remaining");

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                if (Double.TryParse(get_Dialog.Action_Value, out _))
                {
                    Cash_Remaining = (Convert.ToDouble(Cash_Remaining) + Convert.ToDouble(get_Dialog.Action_Value)).ToString();
                    Cash_Remaining_Added = get_Dialog.Action_Value;
                    Cash_Remaining_Changed = true;
                }
            }
        }

        private void lbl_Debt_Maximum_Click(object sender, EventArgs e)
        {
            if (btn_Action.Text == "Delete Account")
                return;

            MythicalCafe_BackEnd_Dialog get_Dialog = new MythicalCafe_BackEnd_Dialog("Input: Debt Maximum");

            if (get_Dialog.ShowDialog() == DialogResult.OK)
            {
                if (Double.TryParse(get_Dialog.Action_Value, out _))
                Debt_Maximum = get_Dialog.Action_Value;
            }
        }

        private void txtbx_Search_Account_OnValueChanged(object sender, EventArgs e)
        {
            BunifuMetroTextbox get_TextBox = (BunifuMetroTextbox)sender;

            String get_TextBox_Value = get_TextBox.Text.Trim();

            String get_RowFilter = null;

            if (get_TextBox_Value == "Search Account")
            {
                get_RowFilter = "Customer_Identity LIKE '%{0}%' OR Customer_FullName LIKE '%{0}%' OR Customer_Gender LIKE '%{0}%' OR Customer_Description LIKE '%{0}%'";
                get_TextBox_Value = "";
            }

            else if (cmbx_Search_Filter.Text == "All")
                get_RowFilter = "Customer_Identity LIKE '%{0}%' OR Customer_FullName LIKE '%{0}%' OR Customer_Gender LIKE '%{0}%' OR Customer_Description LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "ID")
                get_RowFilter = "Customer_Identity LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Full Name")
                get_RowFilter = "Customer_FullName LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Gender")
                get_RowFilter = "Customer_Gender LIKE '%{0}%'";

            else if (cmbx_Search_Filter.Text == "Description")
                get_RowFilter = "Customer_Description LIKE '%{0}%'";


            (dgv_Account.DataSource as DataTable).DefaultView.RowFilter = string.Format(get_RowFilter, get_TextBox_Value);
        }

        private void cmbx_Search_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbx_Search_Account.Text = txtbx_Search_Account.Text + " ";
        }
    }
}
