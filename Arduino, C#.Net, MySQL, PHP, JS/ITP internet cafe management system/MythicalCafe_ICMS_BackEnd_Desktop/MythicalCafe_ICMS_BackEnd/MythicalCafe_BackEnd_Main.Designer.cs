namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MythicalCafe_BackEnd_Main));
            this.sc_Container = new System.Windows.Forms.SplitContainer();
            this.pnl_Main_Container = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl_NavigationBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Workstation = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Account = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Product = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Settings = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Account_My = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Border_Top = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_Top_Header = new System.Windows.Forms.Label();
            this.btn_Application_Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.sc_Container)).BeginInit();
            this.sc_Container.Panel1.SuspendLayout();
            this.sc_Container.SuspendLayout();
            this.pnl_NavigationBar.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.pnl_Border_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_Container
            // 
            this.sc_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.sc_Container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sc_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_Container.Location = new System.Drawing.Point(128, 56);
            this.sc_Container.Margin = new System.Windows.Forms.Padding(0);
            this.sc_Container.Name = "sc_Container";
            this.sc_Container.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_Container.Panel1
            // 
            this.sc_Container.Panel1.BackColor = System.Drawing.Color.White;
            this.sc_Container.Panel1.Controls.Add(this.pnl_Main_Container);
            // 
            // sc_Container.Panel2
            // 
            this.sc_Container.Panel2.BackColor = System.Drawing.Color.White;
            this.pnl_Main.SetRowSpan(this.sc_Container, 2);
            this.sc_Container.Size = new System.Drawing.Size(1052, 724);
            this.sc_Container.SplitterDistance = 649;
            this.sc_Container.TabIndex = 1;
            // 
            // pnl_Main_Container
            // 
            this.pnl_Main_Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Main_Container.BackgroundImage")));
            this.pnl_Main_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main_Container.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Main_Container.GradientBottomRight = System.Drawing.Color.White;
            this.pnl_Main_Container.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Main_Container.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Main_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main_Container.Name = "pnl_Main_Container";
            this.pnl_Main_Container.Quality = 10;
            this.pnl_Main_Container.Size = new System.Drawing.Size(1048, 645);
            this.pnl_Main_Container.TabIndex = 1;
            // 
            // pnl_NavigationBar
            // 
            this.pnl_NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_NavigationBar.Controls.Add(this.btn_Workstation);
            this.pnl_NavigationBar.Controls.Add(this.btn_Account);
            this.pnl_NavigationBar.Controls.Add(this.btn_Product);
            this.pnl_NavigationBar.Controls.Add(this.btn_Settings);
            this.pnl_NavigationBar.Controls.Add(this.btn_Account_My);
            this.pnl_NavigationBar.Controls.Add(this.btn_Logout);
            this.pnl_NavigationBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_NavigationBar.Location = new System.Drawing.Point(0, 56);
            this.pnl_NavigationBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_NavigationBar.Name = "pnl_NavigationBar";
            this.pnl_Main.SetRowSpan(this.pnl_NavigationBar, 2);
            this.pnl_NavigationBar.Size = new System.Drawing.Size(128, 724);
            this.pnl_NavigationBar.TabIndex = 0;
            // 
            // btn_Workstation
            // 
            this.btn_Workstation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Workstation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Workstation.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Workstation.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Workstation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Workstation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Workstation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Workstation.ForeColor = System.Drawing.Color.White;
            this.btn_Workstation.Image = global::MythicalCafe_ICMS_BackEnd.Properties.Resources.png_Workstation_FFFFFF;
            this.btn_Workstation.ImagePosition = 9;
            this.btn_Workstation.ImageZoom = 50;
            this.btn_Workstation.LabelPosition = 30;
            this.btn_Workstation.LabelText = "Workstation";
            this.btn_Workstation.Location = new System.Drawing.Point(10, 10);
            this.btn_Workstation.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Workstation.Name = "btn_Workstation";
            this.btn_Workstation.Size = new System.Drawing.Size(106, 100);
            this.btn_Workstation.TabIndex = 0;
            this.btn_Workstation.Click += new System.EventHandler(this.btn_Workstation_Click);
            // 
            // btn_Account
            // 
            this.btn_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Account.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Account.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Account.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Account.ForeColor = System.Drawing.Color.White;
            this.btn_Account.Image = global::MythicalCafe_ICMS_BackEnd.Properties.Resources.png_Account_FFFFFF;
            this.btn_Account.ImagePosition = 9;
            this.btn_Account.ImageZoom = 50;
            this.btn_Account.LabelPosition = 30;
            this.btn_Account.LabelText = "Account";
            this.btn_Account.Location = new System.Drawing.Point(10, 130);
            this.btn_Account.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Account.Name = "btn_Account";
            this.btn_Account.Size = new System.Drawing.Size(106, 100);
            this.btn_Account.TabIndex = 0;
            this.btn_Account.Click += new System.EventHandler(this.btn_Account_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Product.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Product.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Product.Image = global::MythicalCafe_ICMS_BackEnd.Properties.Resources.png_Product_FFFFFF;
            this.btn_Product.ImagePosition = 9;
            this.btn_Product.ImageZoom = 50;
            this.btn_Product.LabelPosition = 30;
            this.btn_Product.LabelText = "Product";
            this.btn_Product.Location = new System.Drawing.Point(10, 250);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(106, 100);
            this.btn_Product.TabIndex = 3;
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Settings.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Settings.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Settings.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.Image = global::MythicalCafe_ICMS_BackEnd.Properties.Resources.png_Setting_FFFFFF;
            this.btn_Settings.ImagePosition = 9;
            this.btn_Settings.ImageZoom = 50;
            this.btn_Settings.LabelPosition = 30;
            this.btn_Settings.LabelText = "Settings";
            this.btn_Settings.Location = new System.Drawing.Point(10, 370);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(106, 100);
            this.btn_Settings.TabIndex = 2;
            this.btn_Settings.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // btn_Account_My
            // 
            this.btn_Account_My.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Account_My.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Account_My.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Account_My.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Account_My.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Account_My.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Account_My.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Account_My.ForeColor = System.Drawing.Color.White;
            this.btn_Account_My.Image = global::MythicalCafe_ICMS_BackEnd.Properties.Resources.png_Account_FFFFFF;
            this.btn_Account_My.ImagePosition = 9;
            this.btn_Account_My.ImageZoom = 50;
            this.btn_Account_My.LabelPosition = 30;
            this.btn_Account_My.LabelText = "My Account";
            this.btn_Account_My.Location = new System.Drawing.Point(10, 490);
            this.btn_Account_My.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Account_My.Name = "btn_Account_My";
            this.btn_Account_My.Size = new System.Drawing.Size(106, 100);
            this.btn_Account_My.TabIndex = 5;
            this.btn_Account_My.Click += new System.EventHandler(this.btn_Account_My_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Logout.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Image = global::MythicalCafe_ICMS_BackEnd.Properties.Resources.png_Logout_FFFFFF;
            this.btn_Logout.ImagePosition = 9;
            this.btn_Logout.ImageZoom = 50;
            this.btn_Logout.LabelPosition = 30;
            this.btn_Logout.LabelText = "Logout";
            this.btn_Logout.Location = new System.Drawing.Point(10, 610);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(10);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(106, 100);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.ColumnCount = 2;
            this.pnl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.84746F));
            this.pnl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.15254F));
            this.pnl_Main.Controls.Add(this.pnl_NavigationBar, 0, 1);
            this.pnl_Main.Controls.Add(this.pnl_Border_Top, 0, 0);
            this.pnl_Main.Controls.Add(this.sc_Container, 1, 1);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.RowCount = 3;
            this.pnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.273979F));
            this.pnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.67173F));
            this.pnl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.05429F));
            this.pnl_Main.Size = new System.Drawing.Size(1180, 780);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_Border_Top
            // 
            this.pnl_Border_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Border_Top.BackgroundImage")));
            this.pnl_Border_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Main.SetColumnSpan(this.pnl_Border_Top, 2);
            this.pnl_Border_Top.Controls.Add(this.lbl_Top_Header);
            this.pnl_Border_Top.Controls.Add(this.btn_Application_Exit);
            this.pnl_Border_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Border_Top.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Border_Top.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Border_Top.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Border_Top.GradientTopRight = System.Drawing.Color.White;
            this.pnl_Border_Top.Location = new System.Drawing.Point(5, 5);
            this.pnl_Border_Top.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_Border_Top.Name = "pnl_Border_Top";
            this.pnl_Border_Top.Quality = 10;
            this.pnl_Border_Top.Size = new System.Drawing.Size(1170, 46);
            this.pnl_Border_Top.TabIndex = 0;
            // 
            // lbl_Top_Header
            // 
            this.lbl_Top_Header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_Top_Header.AutoSize = true;
            this.lbl_Top_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Top_Header.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_Top_Header.ForeColor = System.Drawing.Color.White;
            this.lbl_Top_Header.Location = new System.Drawing.Point(7, 4);
            this.lbl_Top_Header.Name = "lbl_Top_Header";
            this.lbl_Top_Header.Size = new System.Drawing.Size(287, 18);
            this.lbl_Top_Header.TabIndex = 10;
            this.lbl_Top_Header.Text = "get Branch Code and Current DateTime";
            // 
            // btn_Application_Exit
            // 
            this.btn_Application_Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Application_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Application_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Application_Exit.BorderRadius = 0;
            this.btn_Application_Exit.ButtonText = "Exit Application";
            this.btn_Application_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Application_Exit.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Application_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Application_Exit.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Application_Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Application_Exit.Iconimage = null;
            this.btn_Application_Exit.Iconimage_right = null;
            this.btn_Application_Exit.Iconimage_right_Selected = null;
            this.btn_Application_Exit.Iconimage_Selected = null;
            this.btn_Application_Exit.IconMarginLeft = 0;
            this.btn_Application_Exit.IconMarginRight = 0;
            this.btn_Application_Exit.IconRightVisible = true;
            this.btn_Application_Exit.IconRightZoom = 0D;
            this.btn_Application_Exit.IconVisible = true;
            this.btn_Application_Exit.IconZoom = 90D;
            this.btn_Application_Exit.IsTab = false;
            this.btn_Application_Exit.Location = new System.Drawing.Point(1045, 0);
            this.btn_Application_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Application_Exit.Name = "btn_Application_Exit";
            this.btn_Application_Exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Application_Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Application_Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Application_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Application_Exit.selected = false;
            this.btn_Application_Exit.Size = new System.Drawing.Size(125, 46);
            this.btn_Application_Exit.TabIndex = 9;
            this.btn_Application_Exit.Text = "Exit Application";
            this.btn_Application_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Application_Exit.Textcolor = System.Drawing.Color.White;
            this.btn_Application_Exit.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Application_Exit.Click += new System.EventHandler(this.btn_Application_Exit_Click);
            // 
            // MythicalCafe_BackEnd_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1180, 780);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MythicalCafe_BackEnd_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MythicalCafe_BackEnd_Main_FormClosed);
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Main_Load);
            this.SizeChanged += new System.EventHandler(this.MythicalCafe_BackEnd_Main_SizeChanged);
            this.sc_Container.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_Container)).EndInit();
            this.sc_Container.ResumeLayout(false);
            this.pnl_NavigationBar.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Border_Top.ResumeLayout(false);
            this.pnl_Border_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_Container;
        private System.Windows.Forms.TableLayoutPanel pnl_Main;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Border_Top;
        private System.Windows.Forms.FlowLayoutPanel pnl_NavigationBar;
        private Bunifu.Framework.UI.BunifuTileButton btn_Workstation;
        private Bunifu.Framework.UI.BunifuTileButton btn_Account;
        private Bunifu.Framework.UI.BunifuTileButton btn_Settings;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Main_Container;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Application_Exit;
        private System.Windows.Forms.Label lbl_Top_Header;
        private Bunifu.Framework.UI.BunifuTileButton btn_Product;
        private Bunifu.Framework.UI.BunifuTileButton btn_Account_My;
        private Bunifu.Framework.UI.BunifuTileButton btn_Logout;
    }
}