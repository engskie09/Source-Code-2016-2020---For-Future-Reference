namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MythicalCafe_BackEnd_Product));
            this.pnl_Main_Container = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl_Product_Main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Product_Order_Queue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Category_Manage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Product_Manage = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Product_Log = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Product_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Main_Container.SuspendLayout();
            this.pnl_Product_Main.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main_Container
            // 
            this.pnl_Main_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Main_Container.BackgroundImage")));
            this.pnl_Main_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Main_Container.Controls.Add(this.pnl_Product_Main);
            this.pnl_Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main_Container.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Main_Container.GradientBottomRight = System.Drawing.Color.White;
            this.pnl_Main_Container.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Main_Container.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Main_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main_Container.Name = "pnl_Main_Container";
            this.pnl_Main_Container.Quality = 10;
            this.pnl_Main_Container.Size = new System.Drawing.Size(1140, 600);
            this.pnl_Main_Container.TabIndex = 3;
            // 
            // pnl_Product_Main
            // 
            this.pnl_Product_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_Product_Main.ColumnCount = 1;
            this.pnl_Product_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_Product_Main.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.pnl_Product_Main.Controls.Add(this.pnl_Product_Container, 0, 1);
            this.pnl_Product_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Product_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Product_Main.Name = "pnl_Product_Main";
            this.pnl_Product_Main.RowCount = 2;
            this.pnl_Product_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.983895F));
            this.pnl_Product_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.01611F));
            this.pnl_Product_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_Product_Main.Size = new System.Drawing.Size(1140, 600);
            this.pnl_Product_Main.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Product_Order_Queue, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Category_Manage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Product_Manage, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Product_Log, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1134, 53);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btn_Product_Order_Queue
            // 
            this.btn_Product_Order_Queue.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Order_Queue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Product_Order_Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Order_Queue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Product_Order_Queue.BorderRadius = 0;
            this.btn_Product_Order_Queue.ButtonText = "Order Queue";
            this.btn_Product_Order_Queue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product_Order_Queue.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Product_Order_Queue.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Product_Order_Queue.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Product_Order_Queue.Iconimage = null;
            this.btn_Product_Order_Queue.Iconimage_right = null;
            this.btn_Product_Order_Queue.Iconimage_right_Selected = null;
            this.btn_Product_Order_Queue.Iconimage_Selected = null;
            this.btn_Product_Order_Queue.IconMarginLeft = 0;
            this.btn_Product_Order_Queue.IconMarginRight = 0;
            this.btn_Product_Order_Queue.IconRightVisible = true;
            this.btn_Product_Order_Queue.IconRightZoom = 0D;
            this.btn_Product_Order_Queue.IconVisible = true;
            this.btn_Product_Order_Queue.IconZoom = 90D;
            this.btn_Product_Order_Queue.IsTab = false;
            this.btn_Product_Order_Queue.Location = new System.Drawing.Point(328, 4);
            this.btn_Product_Order_Queue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Product_Order_Queue.Name = "btn_Product_Order_Queue";
            this.btn_Product_Order_Queue.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Order_Queue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Order_Queue.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Product_Order_Queue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Product_Order_Queue.selected = false;
            this.btn_Product_Order_Queue.Size = new System.Drawing.Size(149, 45);
            this.btn_Product_Order_Queue.TabIndex = 16;
            this.btn_Product_Order_Queue.Text = "Order Queue";
            this.btn_Product_Order_Queue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Product_Order_Queue.Textcolor = System.Drawing.Color.White;
            this.btn_Product_Order_Queue.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Product_Order_Queue.Click += new System.EventHandler(this.btn_Product_Order_Queue_Click);
            // 
            // btn_Category_Manage
            // 
            this.btn_Category_Manage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Category_Manage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Category_Manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Category_Manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Category_Manage.BorderRadius = 0;
            this.btn_Category_Manage.ButtonText = "Manage Category";
            this.btn_Category_Manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Category_Manage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Category_Manage.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Category_Manage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Category_Manage.Iconimage = null;
            this.btn_Category_Manage.Iconimage_right = null;
            this.btn_Category_Manage.Iconimage_right_Selected = null;
            this.btn_Category_Manage.Iconimage_Selected = null;
            this.btn_Category_Manage.IconMarginLeft = 0;
            this.btn_Category_Manage.IconMarginRight = 0;
            this.btn_Category_Manage.IconRightVisible = true;
            this.btn_Category_Manage.IconRightZoom = 0D;
            this.btn_Category_Manage.IconVisible = true;
            this.btn_Category_Manage.IconZoom = 90D;
            this.btn_Category_Manage.IsTab = false;
            this.btn_Category_Manage.Location = new System.Drawing.Point(167, 4);
            this.btn_Category_Manage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Category_Manage.Name = "btn_Category_Manage";
            this.btn_Category_Manage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Category_Manage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Category_Manage.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Category_Manage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Category_Manage.selected = false;
            this.btn_Category_Manage.Size = new System.Drawing.Size(149, 45);
            this.btn_Category_Manage.TabIndex = 13;
            this.btn_Category_Manage.Text = "Manage Category";
            this.btn_Category_Manage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Category_Manage.Textcolor = System.Drawing.Color.White;
            this.btn_Category_Manage.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Category_Manage.Click += new System.EventHandler(this.btn_Category_Manage_Click);
            // 
            // btn_Product_Manage
            // 
            this.btn_Product_Manage.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Manage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Product_Manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Manage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Product_Manage.BorderRadius = 0;
            this.btn_Product_Manage.ButtonText = "Manage Product";
            this.btn_Product_Manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product_Manage.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Product_Manage.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Product_Manage.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Product_Manage.Iconimage = null;
            this.btn_Product_Manage.Iconimage_right = null;
            this.btn_Product_Manage.Iconimage_right_Selected = null;
            this.btn_Product_Manage.Iconimage_Selected = null;
            this.btn_Product_Manage.IconMarginLeft = 0;
            this.btn_Product_Manage.IconMarginRight = 0;
            this.btn_Product_Manage.IconRightVisible = true;
            this.btn_Product_Manage.IconRightZoom = 0D;
            this.btn_Product_Manage.IconVisible = true;
            this.btn_Product_Manage.IconZoom = 90D;
            this.btn_Product_Manage.IsTab = false;
            this.btn_Product_Manage.Location = new System.Drawing.Point(6, 4);
            this.btn_Product_Manage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Product_Manage.Name = "btn_Product_Manage";
            this.btn_Product_Manage.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Manage.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Manage.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Product_Manage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Product_Manage.selected = false;
            this.btn_Product_Manage.Size = new System.Drawing.Size(149, 45);
            this.btn_Product_Manage.TabIndex = 12;
            this.btn_Product_Manage.Text = "Manage Product";
            this.btn_Product_Manage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Product_Manage.Textcolor = System.Drawing.Color.White;
            this.btn_Product_Manage.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Product_Manage.Click += new System.EventHandler(this.btn_Product_Manage_Click);
            // 
            // btn_Product_Log
            // 
            this.btn_Product_Log.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Product_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Log.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Product_Log.BorderRadius = 0;
            this.btn_Product_Log.ButtonText = "Product Log";
            this.btn_Product_Log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product_Log.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Product_Log.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Product_Log.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Product_Log.Iconimage = null;
            this.btn_Product_Log.Iconimage_right = null;
            this.btn_Product_Log.Iconimage_right_Selected = null;
            this.btn_Product_Log.Iconimage_Selected = null;
            this.btn_Product_Log.IconMarginLeft = 0;
            this.btn_Product_Log.IconMarginRight = 0;
            this.btn_Product_Log.IconRightVisible = true;
            this.btn_Product_Log.IconRightZoom = 0D;
            this.btn_Product_Log.IconVisible = true;
            this.btn_Product_Log.IconZoom = 90D;
            this.btn_Product_Log.IsTab = false;
            this.btn_Product_Log.Location = new System.Drawing.Point(489, 4);
            this.btn_Product_Log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Product_Log.Name = "btn_Product_Log";
            this.btn_Product_Log.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Log.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product_Log.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Product_Log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Product_Log.selected = false;
            this.btn_Product_Log.Size = new System.Drawing.Size(149, 45);
            this.btn_Product_Log.TabIndex = 15;
            this.btn_Product_Log.Text = "Product Log";
            this.btn_Product_Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Product_Log.Textcolor = System.Drawing.Color.White;
            this.btn_Product_Log.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Product_Log.Click += new System.EventHandler(this.btn_Product_Log_Click);
            // 
            // pnl_Product_Container
            // 
            this.pnl_Product_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnl_Product_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Product_Container.Location = new System.Drawing.Point(0, 59);
            this.pnl_Product_Container.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Product_Container.Name = "pnl_Product_Container";
            this.pnl_Product_Container.Size = new System.Drawing.Size(1140, 541);
            this.pnl_Product_Container.TabIndex = 1;
            // 
            // MythicalCafe_BackEnd_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 600);
            this.Controls.Add(this.pnl_Main_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MythicalCafe_BackEnd_Product";
            this.Text = "MythicalCafe_BackEnd_Product";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Product_Load);
            this.SizeChanged += new System.EventHandler(this.MythicalCafe_BackEnd_Product_SizeChanged);
            this.pnl_Main_Container.ResumeLayout(false);
            this.pnl_Product_Main.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Main_Container;
        private System.Windows.Forms.TableLayoutPanel pnl_Product_Main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Category_Manage;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Product_Manage;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Product_Log;
        private System.Windows.Forms.FlowLayoutPanel pnl_Product_Container;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Product_Order_Queue;
    }
}