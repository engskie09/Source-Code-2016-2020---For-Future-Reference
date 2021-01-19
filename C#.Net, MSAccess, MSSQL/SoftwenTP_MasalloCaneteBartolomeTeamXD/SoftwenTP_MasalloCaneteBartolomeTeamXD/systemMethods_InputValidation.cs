using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    class systemMethods_InputValidation
    {
        //Acccept Letter, Uppercase as First Character and no White Space as First Character.
        public static void txtBoxLetter(String gettxtString, object sender, KeyPressEventArgs e)
        {
            if (gettxtString == String.Empty)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);                
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {                
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));                
            }
        
        }

        //Accept only Letter and Number, but no White Space as FIrst Character.
        public static void txtBoxLetterNumber(String gettxtString, object sender, KeyPressEventArgs e)
        {
            if (gettxtString == String.Empty)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar));
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
            else
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar));
            }

        }
        
        //Accept any Characters, but no White Space as First Character.
        public static void txtBoxUpperCasefirstCharacter(String gettxtString, object sender, KeyPressEventArgs e)
        {
            if (gettxtString == String.Empty)
            {
                e.Handled = (char.IsWhiteSpace(e.KeyChar));
                e.KeyChar = char.ToUpper(e.KeyChar);                 
            }              
        }

        //Accept only Numbers.
        public static void txtBoxNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }           
        }

        //Accept only Number and Decimal points.
        public static void txtBoxNumberOneDecimalpoint(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Accept only Number and One Decimal Point
        public static void txtBoxDecimalPoints(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
