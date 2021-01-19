using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_BackEnd
{
    public static class MythicalCafe_BackEnd_UserControl_Workstation_Method
    {
        //public static Dictionary<String, Thread> UserControl_Workstation_Thread_Dictionary = new Dictionary<String, Thread>();

        //public static Thread UserControl_Workstation_Time_Remainig_Thread;

        public static void set_Session_Start(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation, TimeSpan set_TimeSpan)
        {
            if (!ReferenceEquals(set_UserControl_Workstation.Time_Remaining_Thread, null))
                set_UserControl_Workstation.Time_Remaining_Thread.Abort();

            set_UserControl_Workstation.Time_Remaining_Thread = new Thread(delegate () 
            {      

                set_UserControl_Workstation.Time_Remaining = "00:00:00";
                set_UserControl_Workstation.Time_Duration = set_TimeSpan.ToString();

                if (set_UserControl_Workstation.Session_Action == "Time Pause")
                    set_UserControl_Workstation.Time_Remaining_Thread.Abort();               

                while (true)
                {
                    if (MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary.TryGetValue(set_UserControl_Workstation.Workstation_Identity, out _))
                    {
                        
                        set_TimeSpan = TimeSpan.FromSeconds(Math.Round(DateTime.Now.Subtract(Convert.ToDateTime(set_UserControl_Workstation.Started_DateTime)).TotalSeconds, 0));


                        set_UserControl_Workstation.Time_Duration = set_TimeSpan.ToString(); //TimeSpan.FromSeconds(Math.Round(DateTime.Now.Subtract(set_UserControl_Workstation.Started_DateTime).TotalSeconds, 0)).ToString();
                    }

                    else
                        set_UserControl_Workstation.Time_Remaining_Thread.Abort();
                    

                    Thread.Sleep(1000);                    
                }
            });
            
            set_UserControl_Workstation.Time_Remaining_Thread.Start();

        }

        public static void set_Time_Remaining(MythicalCafe_BackEnd_UserControl_Workstation set_UserControl_Workstation)
        {
            if (!ReferenceEquals(set_UserControl_Workstation.Time_Remaining_Thread, null))
                set_UserControl_Workstation.Time_Remaining_Thread.Abort();

            DateTime LastPaused_DateTime = set_UserControl_Workstation.LastPaused_DateTime;
            DateTime Ended_DateTime = set_UserControl_Workstation.Ended_DateTime;

            set_UserControl_Workstation.Time_Remaining_Thread = new Thread(delegate ()
            {
                if (set_UserControl_Workstation.Session_Action == "Time Pause")
                {
                    set_UserControl_Workstation.Time_Remaining = TimeSpan.FromSeconds(Math.Round(Ended_DateTime.Subtract(LastPaused_DateTime).TotalSeconds, 0)).ToString();
                    set_UserControl_Workstation.Time_Remaining_Thread.Abort();
                }

                while (true)
                {
                    if (MythicalCafe_BackEnd_Workstation_Server.Workstation_Client_Dictionary.TryGetValue(set_UserControl_Workstation.Workstation_Identity, out _))
                    {
                        set_UserControl_Workstation.Time_Remaining = TimeSpan.FromSeconds(Math.Round(Ended_DateTime.Subtract(DateTime.Now).TotalSeconds, 0)).ToString();

                        if (TimeSpan.Parse(set_UserControl_Workstation.Time_Remaining).TotalSeconds <= 0)
                        {
                            set_UserControl_Workstation.Time_Remaining = "00:00:00";

                            set_UserControl_Workstation.lbl_Time_Remaining.ForeColor = Color.Red;

                            MythicalCafe_BackEnd_Workstation_Method.update_Session_Information
                            (
                            "Update : Specific : LastPaused DateTime",
                            "Session_Identity",
                            set_UserControl_Workstation.Session_Identity,
                            "",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            "",
                            "",
                            "",
                            "",
                            "Time Pause"
                            );

                            Thread.CurrentThread.Abort();
                        }
                    }

                    else
                        Thread.CurrentThread.Abort();

                    Thread.Sleep(1000);
                }
            });

            set_UserControl_Workstation.Time_Remaining_Thread.Start();
        }
    }
}
