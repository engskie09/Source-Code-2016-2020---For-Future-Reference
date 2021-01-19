namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MythicalCafe_BackEnd_Login));
            this.pnl_Login_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Border_Top = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnl_Credential_Information = new System.Windows.Forms.TableLayoutPanel();
            this.txtbx_Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbx_Username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Login_Main.SuspendLayout();
            this.pnl_Credential_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Login_Main
            // 
            this.pnl_Login_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.pnl_Login_Main.ColumnCount = 1;
            this.pnl_Login_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_Login_Main.Controls.Add(this.pnl_Border_Top, 0, 0);
            this.pnl_Login_Main.Controls.Add(this.pnl_Credential_Information, 0, 1);
            this.pnl_Login_Main.Controls.Add(this.btn_Login, 0, 2);
            this.pnl_Login_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Login_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Login_Main.Name = "pnl_Login_Main";
            this.pnl_Login_Main.RowCount = 3;
            this.pnl_Login_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.31058F));
            this.pnl_Login_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.70874F));
            this.pnl_Login_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.18447F));
            this.pnl_Login_Main.Size = new System.Drawing.Size(300, 200);
            this.pnl_Login_Main.TabIndex = 2;
            // 
            // pnl_Border_Top
            // 
            this.pnl_Border_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Border_Top.BackgroundImage")));
            this.pnl_Border_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Border_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Border_Top.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Border_Top.GradientBottomRight = System.Drawing.Color.White;
            this.pnl_Border_Top.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Border_Top.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.pnl_Border_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Border_Top.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Border_Top.Name = "pnl_Border_Top";
            this.pnl_Border_Top.Quality = 10;
            this.pnl_Border_Top.Size = new System.Drawing.Size(300, 26);
            this.pnl_Border_Top.TabIndex = 5;
            // 
            // pnl_Credential_Information
            // 
            this.pnl_Credential_Information.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Credential_Information.ColumnCount = 1;
            this.pnl_Credential_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Credential_Information.Controls.Add(this.txtbx_Password, 0, 1);
            this.pnl_Credential_Information.Controls.Add(this.txtbx_Username, 0, 0);
            this.pnl_Credential_Information.Location = new System.Drawing.Point(20, 41);
            this.pnl_Credential_Information.Margin = new System.Windows.Forms.Padding(15);
            this.pnl_Credential_Information.Name = "pnl_Credential_Information";
            this.pnl_Credential_Information.RowCount = 2;
            this.pnl_Credential_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Credential_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Credential_Information.Size = new System.Drawing.Size(259, 89);
            this.pnl_Credential_Information.TabIndex = 4;
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Password.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Password.BorderThickness = 3;
            this.txtbx_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Password.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Password.ForeColor = System.Drawing.Color.White;
            this.txtbx_Password.isPassword = false;
            this.txtbx_Password.Location = new System.Drawing.Point(4, 48);
            this.txtbx_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(251, 37);
            this.txtbx_Password.TabIndex = 4;
            this.txtbx_Password.Text = "Password";
            this.txtbx_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Username.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Username.BorderThickness = 3;
            this.txtbx_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Username.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Username.ForeColor = System.Drawing.Color.White;
            this.txtbx_Username.isPassword = false;
            this.txtbx_Username.Location = new System.Drawing.Point(4, 4);
            this.txtbx_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(251, 36);
            this.txtbx_Username.TabIndex = 3;
            this.txtbx_Username.Text = "Username";
            this.txtbx_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Login
            // 
            this.btn_Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.BorderRadius = 0;
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Login.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Login.Iconimage = null;
            this.btn_Login.Iconimage_right = null;
            this.btn_Login.Iconimage_right_Selected = null;
            this.btn_Login.Iconimage_Selected = null;
            this.btn_Login.IconMarginLeft = 0;
            this.btn_Login.IconMarginRight = 0;
            this.btn_Login.IconRightVisible = true;
            this.btn_Login.IconRightZoom = 0D;
            this.btn_Login.IconVisible = true;
            this.btn_Login.IconZoom = 90D;
            this.btn_Login.IsTab = false;
            this.btn_Login.Location = new System.Drawing.Point(62, 151);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Login.selected = false;
            this.btn_Login.Size = new System.Drawing.Size(175, 42);
            this.btn_Login.TabIndex = 35;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.White;
            this.btn_Login.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // MythicalCafe_BackEnd_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.pnl_Login_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Login";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Login_Load);
            this.pnl_Login_Main.ResumeLayout(false);
            this.pnl_Credential_Information.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnl_Login_Main;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Border_Top;
        private System.Windows.Forms.TableLayoutPanel pnl_Credential_Information;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Username;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
    }
}