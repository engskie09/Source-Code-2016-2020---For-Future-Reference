using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicalCafe_ICMS_FrontEnd
{
    public partial class MythicalCafe_FrontEnd_Login : Form
    {
        public MythicalCafe_FrontEnd_Login()
        {
            InitializeComponent();
        }

        private void MythicalCafe_FrontEnd_Login_Load(object sender, EventArgs e)
        {
            KeyDown += delegate (Object set_Object, KeyEventArgs set_Event)
            {
                MythicalCafe_Control_Propety.set_Form_Close(set_Object, set_Event, this);
            };

            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Username, txtbx_Username.Text.Trim());
            MythicalCafe_Control_Propety.set_TextBox_Placeholder(txtbx_Password, txtbx_Password.Text.Trim());
        }

        public String Action_Value = null;

        private void btn_Login_Click(object sender, EventArgs e)
        {           

            dynamic Customer_Credential_Information = MythicalCafe_FrontEnd_Main_Method.select_Customer_Credential_Information("Select : Specific : Username and Password", JObject.Parse("{ 'Username' : '" + txtbx_Username.Text + "', 'Password' : '" + txtbx_Password.Text + "'}"));

            if (Customer_Credential_Information is Boolean)            
                new MythicalCafe_FrontEnd_Dialog("Message: Try Again.").ShowDialog();            

            else
            {
                Customer_Credential_Information = JObject.Parse(JObject.Parse(Customer_Credential_Information)["Table"].ToString().TrimStart('[').TrimEnd(']'));

                JObject Customer_Property_Information = JObject.Parse(MythicalCafe_FrontEnd_Main_Method.select_Customer_Property_Information("Select : Specific", Customer_Credential_Information["Customer_Identity"].ToString()));

                Customer_Property_Information = JObject.Parse(Customer_Property_Information["Table"].ToString().TrimStart('[').TrimEnd(']'));
                
                Action_Value = " { 'Cash_Remaining' : '" + Customer_Property_Information["Cash_Remaining"].ToString() +  "' ,'Point_Remaining' : '" + Customer_Property_Information["Point_Remaining"].ToString() + "', 'Customer_Identity' : '" + Customer_Property_Information["Customer_Identity"].ToString() + "' } ";

                DialogResult = DialogResult.OK;
            }
        }

        private void txtbx_Password_Enter(object sender, EventArgs e)
        {
            txtbx_Password.isPassword = true;
        }

        void txtbx_Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbx_Password.Text.Trim()))
            {
                txtbx_Password.isPassword = false;
            }
        }
    }
}
