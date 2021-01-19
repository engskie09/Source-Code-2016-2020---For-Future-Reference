namespace Student_Information_System_TheobdsFinals
{
    partial class GeneralSession_Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_getUserpassword = new System.Windows.Forms.TextBox();
            this.txt_getUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_Login.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(190, 210);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(130, 72);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.txt_getUserpassword);
            this.panel1.Controls.Add(this.txt_getUsername);
            this.panel1.Location = new System.Drawing.Point(84, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 161);
            this.panel1.TabIndex = 1;
            // 
            // txt_getUserpassword
            // 
            this.txt_getUserpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txt_getUserpassword.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_getUserpassword.Location = new System.Drawing.Point(37, 95);
            this.txt_getUserpassword.Name = "txt_getUserpassword";
            this.txt_getUserpassword.Size = new System.Drawing.Size(287, 31);
            this.txt_getUserpassword.TabIndex = 2;
            this.txt_getUserpassword.Text = "Enter your Password";
            this.txt_getUserpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_getUserpassword.Enter += new System.EventHandler(this.txt_getUserpassword_Enter);
            this.txt_getUserpassword.Leave += new System.EventHandler(this.txt_getUserpassword_Leave);
            // 
            // txt_getUsername
            // 
            this.txt_getUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txt_getUsername.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_getUsername.Location = new System.Drawing.Point(37, 32);
            this.txt_getUsername.Name = "txt_getUsername";
            this.txt_getUsername.Size = new System.Drawing.Size(287, 31);
            this.txt_getUsername.TabIndex = 1;
            this.txt_getUsername.Text = "Enter your Username";
            this.txt_getUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_getUsername.Enter += new System.EventHandler(this.txt_getUsername_Enter);
            this.txt_getUsername.Leave += new System.EventHandler(this.txt_getUsername_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Location = new System.Drawing.Point(28, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25F);
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Information System\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.label2.Location = new System.Drawing.Point(125, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Theory of Database Final Task Performance";
            // 
            // GeneralSession_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSession_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralSession_Login";
            this.Load += new System.EventHandler(this.GeneralSession_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_getUserpassword;
        private System.Windows.Forms.TextBox txt_getUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}