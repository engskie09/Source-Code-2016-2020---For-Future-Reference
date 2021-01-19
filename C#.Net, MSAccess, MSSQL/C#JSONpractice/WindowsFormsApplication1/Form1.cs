using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var keyValues = new Dictionary<String, String>
               {
                   { "emailSend", "QWE" },
                   { "toEmail", "ASD" }
               };

            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = js.Serialize(keyValues);
            MessageBox.Show(json);

            MessageBox.Show(keyValues["emailSend"].ToString());

            /*Dictionary<String, String> values = js.Deserialize<Dictionary<String, String>>(json);
            string jsonn = js.Serialize(values);
            MessageBox.Show(jsonn);*/

          
        }
    }
}
