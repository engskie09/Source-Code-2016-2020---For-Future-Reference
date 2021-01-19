namespace MythicalCafe_InternetCafeManagementSystem
{
    partial class PCControlPC_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCControlPC_Server));
            this.btn_Listen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtbx_getPort = new Bunifu.Framework.UI.BunifuTextbox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // btn_Listen
            // 
            this.btn_Listen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Listen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Listen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Listen.BorderRadius = 0;
            this.btn_Listen.ButtonText = "Listen";
            this.btn_Listen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Listen.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Listen.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Listen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Listen.Iconimage")));
            this.btn_Listen.Iconimage_right = null;
            this.btn_Listen.Iconimage_right_Selected = null;
            this.btn_Listen.Iconimage_Selected = null;
            this.btn_Listen.IconMarginLeft = 0;
            this.btn_Listen.IconMarginRight = 0;
            this.btn_Listen.IconRightVisible = true;
            this.btn_Listen.IconRightZoom = 0D;
            this.btn_Listen.IconVisible = true;
            this.btn_Listen.IconZoom = 90D;
            this.btn_Listen.IsTab = false;
            this.btn_Listen.Location = new System.Drawing.Point(82, 146);
            this.btn_Listen.Name = "btn_Listen";
            this.btn_Listen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Listen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Listen.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Listen.selected = false;
            this.btn_Listen.Size = new System.Drawing.Size(244, 48);
            this.btn_Listen.TabIndex = 12;
            this.btn_Listen.Text = "Listen";
            this.btn_Listen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Listen.Textcolor = System.Drawing.Color.White;
            this.btn_Listen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listen.Click += new System.EventHandler(this.btn_Listen_Click);
            // 
            // txtbx_getPort
            // 
            this.txtbx_getPort.BackColor = System.Drawing.Color.Silver;
            this.txtbx_getPort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbx_getPort.BackgroundImage")));
            this.txtbx_getPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtbx_getPort.ForeColor = System.Drawing.Color.Teal;
            this.txtbx_getPort.Icon = ((System.Drawing.Image)(resources.GetObject("txtbx_getPort.Icon")));
            this.txtbx_getPort.Location = new System.Drawing.Point(82, 71);
            this.txtbx_getPort.Name = "txtbx_getPort";
            this.txtbx_getPort.Size = new System.Drawing.Size(244, 42);
            this.txtbx_getPort.TabIndex = 10;
            this.txtbx_getPort.text = "";
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
            this.bunifuGradientPanel1.TabIndex = 14;
            // 
            // PCControlPC_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 228);
            this.Controls.Add(this.btn_Listen);
            this.Controls.Add(this.txtbx_getPort);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCControlPC_Server";
            this.Text = "PCControlPC_Server";
            this.Load += new System.EventHandler(this.PCControlPC_Server_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Listen;
        private Bunifu.Framework.UI.BunifuTextbox txtbx_getPort;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}