using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MaterialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }
        public DataTable tableSupplierDirectory = new DataTable();
        private void Main_Load(object sender, EventArgs e)
        {
            lblSupplierDirectoryCount.Text = tableSupplierDirectory.Rows.Count.ToString();
        }

        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "abc123";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        public static string Encrypt(string clearText)
        {
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void Main_Click(object sender, EventArgs e)
        {
            ActiveControl = label1;
        }


        int currentGradientPanelHeight = 536;

        private void LblShowHideDasboard_Click_1(object sender, EventArgs e)
        {
            if (lblShowHideDasboard.Text == "+")
            {
                lblShowHideDasboard.Text = "-";
                timer1.Enabled = true;
            }
            else
            {
                lblShowHideDasboard.Text = "+";
                timer1.Enabled = true;
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(lblShowHideDasboard.Text == "+")
            {
                if (currentGradientPanelHeight >= 35)
                {
                    currentGradientPanelHeight -= 8;
                    gradientPanel1.Size = new Size(gradientPanel1.Width, currentGradientPanelHeight);
                }
            }
            else
            {
                if (currentGradientPanelHeight <= 536)
                {
                    currentGradientPanelHeight += 8;
                    gradientPanel1.Size = new Size(gradientPanel1.Width, currentGradientPanelHeight);
                }
            }
        }

        private void LblViewSupplierDirectory_Click(object sender, EventArgs e)
        {
            SupplierDirectory supplierDirectory = new SupplierDirectory();
            supplierDirectory.tableSupplierDirectory = tableSupplierDirectory.Copy();
            supplierDirectory.ShowDialog();
        }
    }
}
