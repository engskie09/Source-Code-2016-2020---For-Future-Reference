namespace MythicalCafe_InternetCafeManagementSystem
{
    partial class PCControlPC_Client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCControlPC_Client));
            this.btn_ShareMyScreen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Connect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtbx_getPort = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtbx_getIP = new Bunifu.Framework.UI.BunifuTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_ShowServer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // btn_ShareMyScreen
            // 
            this.btn_ShareMyScreen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ShareMyScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ShareMyScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShareMyScreen.BorderRadius = 0;
            this.btn_ShareMyScreen.ButtonText = "Share My Screen";
            this.btn_ShareMyScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShareMyScreen.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ShareMyScreen.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ShareMyScreen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ShareMyScreen.Iconimage")));
            this.btn_ShareMyScreen.Iconimage_right = null;
            this.btn_ShareMyScreen.Iconimage_right_Selected = null;
            this.btn_ShareMyScreen.Iconimage_Selected = null;
            this.btn_ShareMyScreen.IconMarginLeft = 0;
            this.btn_ShareMyScreen.IconMarginRight = 0;
            this.btn_ShareMyScreen.IconRightVisible = true;
            this.btn_ShareMyScreen.IconRightZoom = 0D;
            this.btn_ShareMyScreen.IconVisible = true;
            this.btn_ShareMyScreen.IconZoom = 90D;
            this.btn_ShareMyScreen.IsTab = false;
            this.btn_ShareMyScreen.Location = new System.Drawing.Point(210, 202);
            this.btn_ShareMyScreen.Name = "btn_ShareMyScreen";
            this.btn_ShareMyScreen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ShareMyScreen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_ShareMyScreen.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ShareMyScreen.selected = false;
            this.btn_ShareMyScreen.Size = new System.Drawing.Size(119, 48);
            this.btn_ShareMyScreen.TabIndex = 8;
            this.btn_ShareMyScreen.Text = "Share My Screen";
            this.btn_ShareMyScreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShareMyScreen.Textcolor = System.Drawing.Color.White;
            this.btn_ShareMyScreen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShareMyScreen.Click += new System.EventHandler(this.btn_ShareMyScreen_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Connect.BorderRadius = 0;
            this.btn_Connect.ButtonText = "Connect";
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Connect.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Connect.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Connect.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Connect.Iconimage")));
            this.btn_Connect.Iconimage_right = null;
            this.btn_Connect.Iconimage_right_Selected = null;
            this.btn_Connect.Iconimage_Selected = null;
            this.btn_Connect.IconMarginLeft = 0;
            this.btn_Connect.IconMarginRight = 0;
            this.btn_Connect.IconRightVisible = true;
            this.btn_Connect.IconRightZoom = 0D;
            this.btn_Connect.IconVisible = true;
            this.btn_Connect.IconZoom = 90D;
            this.btn_Connect.IsTab = false;
            this.btn_Connect.Location = new System.Drawing.Point(85, 202);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Connect.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Connect.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Connect.selected = false;
            this.btn_Connect.Size = new System.Drawing.Size(119, 48);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Connect.Textcolor = System.Drawing.Color.White;
            this.btn_Connect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txtbx_getPort
            // 
            this.txtbx_getPort.BackColor = System.Drawing.Color.Silver;
            this.txtbx_getPort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbx_getPort.BackgroundImage")));
            this.txtbx_getPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbx_getPort.ForeColor = System.Drawing.Color.Teal;
            this.txtbx_getPort.Icon = ((System.Drawing.Image)(resources.GetObject("txtbx_getPort.Icon")));
            this.txtbx_getPort.Location = new System.Drawing.Point(85, 144);
            this.txtbx_getPort.Name = "txtbx_getPort";
            this.txtbx_getPort.Size = new System.Drawing.Size(244, 42);
            this.txtbx_getPort.TabIndex = 6;
            this.txtbx_getPort.text = "";
            // 
            // txtbx_getIP
            // 
            this.txtbx_getIP.BackColor = System.Drawing.Color.Silver;
            this.txtbx_getIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbx_getIP.BackgroundImage")));
            this.txtbx_getIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbx_getIP.ForeColor = System.Drawing.Color.Teal;
            this.txtbx_getIP.Icon = ((System.Drawing.Image)(resources.GetObject("txtbx_getIP.Icon")));
            this.txtbx_getIP.Location = new System.Drawing.Point(85, 76);
            this.txtbx_getIP.Name = "txtbx_getIP";
            this.txtbx_getIP.Size = new System.Drawing.Size(244, 42);
            this.txtbx_getIP.TabIndex = 5;
            this.txtbx_getIP.text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(414, 38);
            this.bunifuGradientPanel1.TabIndex = 9;
            // 
            // btn_ShowServer
            // 
            this.btn_ShowServer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ShowServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ShowServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ShowServer.BorderRadius = 0;
            this.btn_ShowServer.ButtonText = "Show Server";
            this.btn_ShowServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ShowServer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ShowServer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ShowServer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ShowServer.Iconimage")));
            this.btn_ShowServer.Iconimage_right = null;
            this.btn_ShowServer.Iconimage_right_Selected = null;
            this.btn_ShowServer.Iconimage_Selected = null;
            this.btn_ShowServer.IconMarginLeft = 0;
            this.btn_ShowServer.IconMarginRight = 0;
            this.btn_ShowServer.IconRightVisible = true;
            this.btn_ShowServer.IconRightZoom = 0D;
            this.btn_ShowServer.IconVisible = true;
            this.btn_ShowServer.IconZoom = 90D;
            this.btn_ShowServer.IsTab = false;
            this.btn_ShowServer.Location = new System.Drawing.Point(210, 266);
            this.btn_ShowServer.Name = "btn_ShowServer";
            this.btn_ShowServer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ShowServer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_ShowServer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ShowServer.selected = false;
            this.btn_ShowServer.Size = new System.Drawing.Size(119, 48);
            this.btn_ShowServer.TabIndex = 10;
            this.btn_ShowServer.Text = "Show Server";
            this.btn_ShowServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ShowServer.Textcolor = System.Drawing.Color.White;
            this.btn_ShowServer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowServer.Click += new System.EventHandler(this.btn_ShowServer_Click);
            // 
            // PCControlPC_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 326);
            this.Controls.Add(this.btn_ShowServer);
            this.Controls.Add(this.btn_ShareMyScreen);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txtbx_getPort);
            this.Controls.Add(this.txtbx_getIP);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCControlPC_Client";
            this.Text = "PCControlPC_Client";
            this.Load += new System.EventHandler(this.PCControlPC_Client_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_ShareMyScreen;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Connect;
        private Bunifu.Framework.UI.BunifuTextbox txtbx_getPort;
        private Bunifu.Framework.UI.BunifuTextbox txtbx_getIP;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ShowServer;
    }
}