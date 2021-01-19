using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeyRole
{
    class validations
    {

        public static void numberOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        //----------------------------------------------------------------------
        public static void letterOnly(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

           
        }
        //----------------------------------------------------------------------
        public static void uppercaseFirstLetter(Object sender, KeyPressEventArgs e , string x)
        {
            if (x == String.Empty)
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }
    }
}
