using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MythicalCafe_InternetCafeManagementSystem
{
    public static class justMethods
    {
        static Int32 mov = new Int32();
        static Int32 movX = new Int32();
        static Int32 movY = new Int32();

        public static void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        public static void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e, Form set_Form)
        {
            if (mov == 1)
            {
                set_Form.SetDesktopLocation(Control.MousePosition.X - movX, Control.MousePosition.Y - movY);
            }
        }

        public static void bunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
