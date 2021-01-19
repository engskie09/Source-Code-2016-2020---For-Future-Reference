using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_Account_User : Form
    {
        public MythicalCafe_FrontEnd_Account_User()
        {
            InitializeComponent();
        }

        private void MythicalCafe_FrontEnd_Account_User_Load(object sender, EventArgs e)
        {
            
            KeyDown += delegate(Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Opacity = 0.5;

            MythicalCafe_Control_Propety.get_Form_Effect_Fade("Emphasize", Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name]);


            pnl_User_Information_BackgroundWorker.DoWork += pnl_User_Information_BackgroundWorker_DoWork;

            pnl_User_Information_BackgroundWorker.RunWorkerCompleted += pnl_User_Information_BackgroundWorker_RunWorkerCompleted;

            pnl_User_Information_BackgroundWorker.RunWorkerAsync(10);

            JObject get_Customer_Information = MythicalCafe_FrontEnd_Main_Method.Customer_Information;

            lbl_Time_Remaining.Text = "Remaining Time: " + get_Customer_Information["Time_Remaining"].ToString();
            lbl_Time_Bonus.Text = "Bonus Time: " + get_Customer_Information["Time_Bonus"].ToString();
            lbl_Time_Total.Text = "Total Time: " + get_Customer_Information["Time_Spent"].ToString();

            lbl_Cash_Remaining.Text = "Remaining M-Cash: " + get_Customer_Information["Cash_Remaining"].ToString();
            lbl_Point_Remaining.Text = "Remaining Points: " + get_Customer_Information["Point_Remaining"].ToString();

            //lbl_Debt_Remaining.Text = "Remaining Debt: " + get_Customer_Information["Debt_Remaining"].ToString();
            //lbl_Debt_Maximum.Text = "Maximum Debt: " + get_Customer_Information["Debt_Maximum"].ToString();
        }

        private void MythicalCafe_FrontEnd_Account_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            MythicalCafe_Control_Propety.get_Timer.Stop();

            Application.OpenForms[new MythicalCafe_FrontEnd_Main().Name].Opacity = 1;
        }

        BackgroundWorker pnl_User_Information_BackgroundWorker = new BackgroundWorker();

        void pnl_User_Information_BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            pnl_User_Property_Information.CellPaint += delegate (Object set_Object, TableLayoutCellPaintEventArgs set_TableLayoutCellPaintEventArgs)
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

        void pnl_User_Information_BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnl_User_Information_BackgroundWorker.Dispose();
        }

        /* Custom Method */
    }
}
