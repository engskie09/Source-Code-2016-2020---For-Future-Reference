namespace PeyRole
{
    partial class LoginPayroll
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
            this.login = new System.Windows.Forms.Button();
            this.inputname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginAs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.PowderBlue;
            this.login.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.login.Location = new System.Drawing.Point(187, 218);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(113, 46);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            // 
            // inputname
            // 
            this.inputname.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.inputname.Location = new System.Drawing.Point(202, 128);
            this.inputname.MaxLength = 8;
            this.inputname.Multiline = true;
            this.inputname.Name = "inputname";
            this.inputname.Size = new System.Drawing.Size(95, 29);
            this.inputname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label1.Location = new System.Drawing.Point(94, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // inputpassword
            // 
            this.inputpassword.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.inputpassword.Location = new System.Drawing.Point(202, 168);
            this.inputpassword.MaxLength = 15;
            this.inputpassword.Multiline = true;
            this.inputpassword.Name = "inputpassword";
            this.inputpassword.PasswordChar = '*';
            this.inputpassword.Size = new System.Drawing.Size(95, 29);
            this.inputpassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label2.Location = new System.Drawing.Point(94, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // LoginAs
            // 
            this.LoginAs.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginAs.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.LoginAs.Location = new System.Drawing.Point(162, 222);
            this.LoginAs.Name = "LoginAs";
            this.LoginAs.Size = new System.Drawing.Size(164, 46);
            this.LoginAs.TabIndex = 6;
            this.LoginAs.Text = "Login";
            this.LoginAs.UseVisualStyleBackColor = false;
            this.LoginAs.Click += new System.EventHandler(this.LoginAs_Click);
            // 
            // LoginPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 377);
            this.Controls.Add(this.LoginAs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputname);
            this.Name = "LoginPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll System";
            this.Load += new System.EventHandler(this.LoginPayroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox inputname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginAs;
    }
}

