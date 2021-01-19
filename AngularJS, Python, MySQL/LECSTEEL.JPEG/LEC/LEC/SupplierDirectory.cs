using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEC
{
    public partial class SupplierDirectory : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public SupplierDirectory()
        {
            InitializeComponent();
        }

        Timer t1 = new Timer();
        public DataTable tableSupplierDirectory = new DataTable();
        private void SupplierDirectory_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 5, 5));
            Opacity = 0;

            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();

            ActiveControl = label1;

            for (int i = 0; i < tableSupplierDirectory.Rows.Count; i++)
            {
                DataRow dr = tableSupplierDirectory.Rows[i];
                byte[] image = (byte[])(dr["picture"]);

                MemoryStream memoryStream = new MemoryStream(image);
                GradientPanel panel = new GradientPanel();
                panel.Name = dr["supcode"].ToString();
                panel.Size = new Size(130, 190);
                panel.BackColor = Color.Gray;
                panel.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 5, 5));
                flowLayoutPanel1.Controls.Add(panel);

                Label lblSupplierName = new Label();
                lblSupplierName.Name = "lblSupplierName" + panel.Name;
                lblSupplierName.Location = new Point(2, 2);
                lblSupplierName.AutoSize = false;
                lblSupplierName.TextAlign = ContentAlignment.MiddleCenter;
                lblSupplierName.Text = dr["supname"].ToString().ToUpper();
                lblSupplierName.Size = new Size(panel.Width - 4, 16);
                lblSupplierName.Font = new Font("Verdana", 10,FontStyle.Bold);
                lblSupplierName.ForeColor = Color.FromArgb(230,230,230);
                lblSupplierName.BackColor = Color.Transparent;

                Label lblCategory = new Label();
                lblCategory.Location = new Point(2, lblSupplierName.Height + 2);
                lblCategory.AutoSize = false;
                lblCategory.TextAlign = ContentAlignment.MiddleCenter;
                lblCategory.Text = "CATEGORY";
                lblCategory.Size = new Size(panel.Width - 4, 16);
                lblCategory.Font = new Font("Verdana", 7, FontStyle.Bold);
                lblCategory.ForeColor = Color.FromArgb(32, 32, 32);
                lblCategory.BackColor = Color.Transparent;

                Label lblCategory1 = new Label();
                lblCategory1.Name = "lblCategory1" + panel.Name;
                lblCategory1.Location = new Point(13, lblCategory.Height + lblSupplierName.Height + 3);
                lblCategory1.AutoSize = false;
                lblCategory1.TextAlign = ContentAlignment.TopCenter;
                lblCategory1.Text = dr["cat01"].ToString().ToUpper();
                lblCategory1.Size = new Size(50, 14);
                lblCategory1.Font = new Font("Verdana", 7);
                lblCategory1.ForeColor = Color.White;
                lblCategory1.BackColor = Color.FromArgb(233, 34, 57);
                lblCategory1.AutoEllipsis = true;
                lblCategory1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblCategory1.Width, lblCategory1.Height, 5, 5));

                Label lblCategory2 = new Label();
                lblCategory2.Name = "lblCategory2" + panel.Name;
                lblCategory2.Location = new Point(lblCategory1.Width + 16, lblCategory.Height + lblSupplierName.Height + 3);
                lblCategory2.AutoSize = false;
                lblCategory2.TextAlign = ContentAlignment.TopCenter;
                lblCategory2.Text = dr["cat02"].ToString().ToUpper();
                lblCategory2.Size = new Size(50, 14);
                lblCategory2.Font = new Font("Verdana", 7);
                lblCategory2.ForeColor = Color.White;
                lblCategory2.BackColor = Color.FromArgb(233, 34, 57);
                lblCategory2.AutoEllipsis = true;
                lblCategory2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lblCategory2.Width, lblCategory2.Height, 5, 5));

                OvalPictureBox img = new OvalPictureBox();
                img.Size = new Size(90, 90);
                img.Location = new Point(panel.Width / 2 - img.Width / 2, lblCategory.Height + lblSupplierName.Height + lblCategory1.Height + 15);
                img.BackColor = Color.Transparent;
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                img.Image = Image.FromStream(memoryStream);

                Label lblView = new Label();
                lblView.AutoSize = false;
                lblView.TextAlign = ContentAlignment.MiddleCenter;
                lblView.Text = "VIEW";
                lblView.Size = new Size(panel.Width - 9, 15);
                lblView.Font = new Font("Verdana", 7);
                lblView.ForeColor = Color.White;
                lblView.BackColor = Color.FromArgb(41, 128, 185);
                lblView.Location = new Point(4, img.Height + lblCategory.Height + lblSupplierName.Height + lblCategory1.Height + 15);
                lblView.MouseHover += delegate { lblView.BackColor = Color.FromArgb(52, 152, 219); };
                lblView.MouseLeave += delegate { lblView.BackColor = Color.FromArgb(41, 128, 185); };
                lblView.Cursor = Cursors.Hand;
                lblView.Click += delegate
                {

                };

                Label lblEdit = new Label();
                lblEdit.AutoSize = false;
                lblEdit.TextAlign = ContentAlignment.MiddleCenter;
                lblEdit.Text = "EDIT";
                lblEdit.Size = new Size(lblView.Width / 2 - 1, 15);
                lblEdit.Font = new Font("Verdana", 7);
                lblEdit.ForeColor = Color.White;
                lblEdit.BackColor = Color.FromArgb(230, 126, 34);
                lblEdit.Location = new Point(4, lblView.Height + img.Height + lblCategory.Height + lblSupplierName.Height + lblCategory1.Height + 17);
                lblEdit.MouseHover += delegate { lblEdit.BackColor = Color.FromArgb(243, 156, 18); };
                lblEdit.MouseLeave += delegate { lblEdit.BackColor = Color.FromArgb(230, 126, 34); };
                lblEdit.Cursor = Cursors.Hand;
                lblEdit.Click += delegate
                {

                };

                Label lblDelete = new Label();
                lblDelete.AutoSize = false;
                lblDelete.TextAlign = ContentAlignment.MiddleCenter;
                lblDelete.Text = "DELETE";
                lblDelete.Size = new Size(lblView.Width / 2 - 1, 15);
                lblDelete.Font = new Font("Verdana", 7);
                lblDelete.ForeColor = Color.White;
                lblDelete.BackColor = Color.FromArgb(192, 57, 43);
                lblDelete.Location = new Point(lblEdit.Width + 7, lblView.Height + img.Height + lblCategory.Height + lblSupplierName.Height + lblCategory1.Height + 17);
                lblDelete.MouseHover += delegate { lblDelete.BackColor = Color.FromArgb(231, 76, 60); };
                lblDelete.MouseLeave += delegate { lblDelete.BackColor = Color.FromArgb(192, 57, 43); };
                lblDelete.Cursor = Cursors.Hand;
                lblDelete.Click += delegate
                {

                };
                panel.Controls.Add(lblSupplierName);
                panel.Controls.Add(lblCategory1);
                panel.Controls.Add(lblCategory2);
                panel.Controls.Add(lblCategory);
                panel.Controls.Add(img);
                panel.Controls.Add(lblView);
                panel.Controls.Add(lblEdit);
                panel.Controls.Add(lblDelete);
            }
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        private void SupplierDirectory_Click(object sender, EventArgs e)
        {


            
        }

        private void BtnBack_MouseHover(object sender, EventArgs e)
        {
            btnBack.Location = new Point(btnBack.Location.X - 2, btnBack.Location.Y - 2);
            btnBack.Size = new Size(btnBack.Width +5,btnBack.Height+5);
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Location = new Point(5, 11);
            btnBack.Size = new Size(20, 20);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.Location = new Point(btnSearch.Location.X - 2, btnSearch.Location.Y - 2);
            btnSearch.Size = new Size(btnSearch.Width + 5, btnSearch.Height + 5);
        }

        private void BtnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Location = new Point(780, 48);
            btnSearch.Size = new Size(18, 18);
        }

        private void GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
