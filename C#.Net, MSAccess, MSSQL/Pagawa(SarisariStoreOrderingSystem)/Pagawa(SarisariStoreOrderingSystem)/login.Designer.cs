namespace Pagawa_SarisariStoreOrderingSystem_
{
    partial class login
    {
        // by: Rafael Nobleza Masallo 
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordtxtbox = new System.Windows.Forms.TextBox();
            this.usernametxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginxD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.passwordtxtbox);
            this.panel1.Controls.Add(this.usernametxtbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(161, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 265);
            this.panel1.TabIndex = 0;
            // 
            // passwordtxtbox
            // 
            this.passwordtxtbox.Font = new System.Drawing.Font("Curlz MT", 20F);
            this.passwordtxtbox.ForeColor = System.Drawing.Color.BurlyWood;
            this.passwordtxtbox.Location = new System.Drawing.Point(229, 156);
            this.passwordtxtbox.Multiline = true;
            this.passwordtxtbox.Name = "passwordtxtbox";
            this.passwordtxtbox.PasswordChar = '*';
            this.passwordtxtbox.Size = new System.Drawing.Size(109, 33);
            this.passwordtxtbox.TabIndex = 3;
            // 
            // usernametxtbox
            // 
            this.usernametxtbox.Font = new System.Drawing.Font("Curlz MT", 20F);
            this.usernametxtbox.ForeColor = System.Drawing.Color.BurlyWood;
            this.usernametxtbox.Location = new System.Drawing.Point(229, 72);
            this.usernametxtbox.Multiline = true;
            this.usernametxtbox.Name = "usernametxtbox";
            this.usernametxtbox.Size = new System.Drawing.Size(109, 33);
            this.usernametxtbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Curlz MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Curlz MT", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // loginxD
            // 
            this.loginxD.Font = new System.Drawing.Font("Curlz MT", 30F);
            this.loginxD.Location = new System.Drawing.Point(31, 17);
            this.loginxD.Name = "loginxD";
            this.loginxD.Size = new System.Drawing.Size(148, 70);
            this.loginxD.TabIndex = 2;
            this.loginxD.Text = "Log-iN";
            this.loginxD.UseVisualStyleBackColor = true;
            this.loginxD.Click += new System.EventHandler(this.loginxD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.loginxD);
            this.panel2.Location = new System.Drawing.Point(267, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 101);
            this.panel2.TabIndex = 3;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(715, 523);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sari-Sari Store";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordtxtbox;
        private System.Windows.Forms.TextBox usernametxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginxD;
        private System.Windows.Forms.Panel panel2;
    }
}

