namespace engskie09ApartmentSystem
{
    partial class LoginSession
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtsetPassword = new System.Windows.Forms.TextBox();
            this.txtsetUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitapplication = new System.Windows.Forms.Button();
            this.pctBoxShowpassword = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxShowpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.panelLogin.Controls.Add(this.pctBoxShowpassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtsetPassword);
            this.panelLogin.Controls.Add(this.txtsetUsername);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(96, 118);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(367, 278);
            this.panelLogin.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btnLogin.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btnLogin.Location = new System.Drawing.Point(196, 199);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtsetPassword
            // 
            this.txtsetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.txtsetPassword.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.txtsetPassword.Location = new System.Drawing.Point(171, 139);
            this.txtsetPassword.MaxLength = 10;
            this.txtsetPassword.Name = "txtsetPassword";
            this.txtsetPassword.PasswordChar = '☼';
            this.txtsetPassword.Size = new System.Drawing.Size(162, 39);
            this.txtsetPassword.TabIndex = 2;
            this.txtsetPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLetterNumber_KeyPress);
            // 
            // txtsetUsername
            // 
            this.txtsetUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.txtsetUsername.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.txtsetUsername.Location = new System.Drawing.Point(171, 59);
            this.txtsetUsername.MaxLength = 10;
            this.txtsetUsername.Name = "txtsetUsername";
            this.txtsetUsername.Size = new System.Drawing.Size(162, 39);
            this.txtsetUsername.TabIndex = 1;
            this.txtsetUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLetterNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(40, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(104, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maribel Apartment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.btnExitapplication);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 30);
            this.panel1.TabIndex = 4;
            // 
            // btnExitapplication
            // 
            this.btnExitapplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btnExitapplication.FlatAppearance.BorderSize = 0;
            this.btnExitapplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitapplication.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitapplication.Location = new System.Drawing.Point(522, 0);
            this.btnExitapplication.Name = "btnExitapplication";
            this.btnExitapplication.Size = new System.Drawing.Size(37, 30);
            this.btnExitapplication.TabIndex = 5;
            this.btnExitapplication.Text = "X";
            this.btnExitapplication.UseVisualStyleBackColor = false;
            this.btnExitapplication.Click += new System.EventHandler(this.btnExitapplication_Click);
            // 
            // pctBoxShowpassword
            // 
            this.pctBoxShowpassword.Image = global::engskie09ApartmentSystem.Properties.Resources.showpassword;
            this.pctBoxShowpassword.Location = new System.Drawing.Point(333, 139);
            this.pctBoxShowpassword.Name = "pctBoxShowpassword";
            this.pctBoxShowpassword.Size = new System.Drawing.Size(31, 39);
            this.pctBoxShowpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxShowpassword.TabIndex = 5;
            this.pctBoxShowpassword.TabStop = false;
            this.pctBoxShowpassword.Click += new System.EventHandler(this.pctBoxShowpassword_Click);
            // 
            // LoginSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(559, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginSession";
            this.Load += new System.EventHandler(this.LoginSession_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxShowpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtsetPassword;
        private System.Windows.Forms.TextBox txtsetUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExitapplication;
        private System.Windows.Forms.PictureBox pctBoxShowpassword;

    }
}