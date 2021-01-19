namespace theFACTisYOU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSession));
            this.Login = new System.Windows.Forms.Button();
            this.Admin_Name = new System.Windows.Forms.TextBox();
            this.Admin_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Designation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.Login.Location = new System.Drawing.Point(336, 278);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(89, 38);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Admin_Name
            // 
            this.Admin_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Admin_Name.Location = new System.Drawing.Point(138, 84);
            this.Admin_Name.Name = "Admin_Name";
            this.Admin_Name.Size = new System.Drawing.Size(100, 30);
            this.Admin_Name.TabIndex = 1;
            // 
            // Admin_Password
            // 
            this.Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Admin_Password.Location = new System.Drawing.Point(138, 130);
            this.Admin_Password.Name = "Admin_Password";
            this.Admin_Password.PasswordChar = '*';
            this.Admin_Password.Size = new System.Drawing.Size(100, 30);
            this.Admin_Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Space Cafe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Admin_Password);
            this.panel1.Controls.Add(this.Admin_Name);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(130)))), ((int)(((byte)(185)))));
            this.panel1.Location = new System.Drawing.Point(168, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 179);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adminname";
            // 
            // Designation
            // 
            this.Designation.DropDownHeight = 127;
            this.Designation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Designation.FormattingEnabled = true;
            this.Designation.IntegralHeight = false;
            this.Designation.ItemHeight = 25;
            this.Designation.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.Designation.Location = new System.Drawing.Point(200, 278);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(130, 33);
            this.Designation.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(19)))), ((int)(((byte)(28)))));
            this.button1.Location = new System.Drawing.Point(374, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Forgot Password?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(116)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Designation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Login);
            this.Name = "LoginSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[System Name] for [Company Name]";
            this.Load += new System.EventHandler(this.LoginSession_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox Admin_Name;
        private System.Windows.Forms.TextBox Admin_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Designation;
        private System.Windows.Forms.Button button1;
    }
}

