namespace JSP_LibrarySystem
{
    partial class AdminSession_MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSession_MyAccount));
            this.label2 = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Oldpasswordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewPasstxt = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.showoldpasswordtxt = new System.Windows.Forms.CheckBox();
            this.ShowNewPasswordtxt = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(160, 165);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(242, 27);
            this.Usernametxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Old password:";
            // 
            // Oldpasswordtxt
            // 
            this.Oldpasswordtxt.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oldpasswordtxt.Location = new System.Drawing.Point(160, 211);
            this.Oldpasswordtxt.Name = "Oldpasswordtxt";
            this.Oldpasswordtxt.Size = new System.Drawing.Size(242, 27);
            this.Oldpasswordtxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "New password:";
            // 
            // NewPasstxt
            // 
            this.NewPasstxt.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasstxt.Location = new System.Drawing.Point(160, 282);
            this.NewPasstxt.Name = "NewPasstxt";
            this.NewPasstxt.Size = new System.Drawing.Size(242, 27);
            this.NewPasstxt.TabIndex = 7;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Confirm.BackgroundImage")));
            this.Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.Color.White;
            this.Confirm.Location = new System.Drawing.Point(217, 355);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(200, 50);
            this.Confirm.TabIndex = 8;
            this.Confirm.Text = "Change Password";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // showoldpasswordtxt
            // 
            this.showoldpasswordtxt.AutoSize = true;
            this.showoldpasswordtxt.BackColor = System.Drawing.Color.Transparent;
            this.showoldpasswordtxt.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showoldpasswordtxt.Location = new System.Drawing.Point(196, 248);
            this.showoldpasswordtxt.Name = "showoldpasswordtxt";
            this.showoldpasswordtxt.Size = new System.Drawing.Size(133, 23);
            this.showoldpasswordtxt.TabIndex = 9;
            this.showoldpasswordtxt.Text = "Show Password";
            this.showoldpasswordtxt.UseVisualStyleBackColor = false;
            this.showoldpasswordtxt.CheckedChanged += new System.EventHandler(this.showoldpasswordtxt_CheckedChanged);
            // 
            // ShowNewPasswordtxt
            // 
            this.ShowNewPasswordtxt.AutoSize = true;
            this.ShowNewPasswordtxt.BackColor = System.Drawing.Color.Transparent;
            this.ShowNewPasswordtxt.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNewPasswordtxt.Location = new System.Drawing.Point(196, 315);
            this.ShowNewPasswordtxt.Name = "ShowNewPasswordtxt";
            this.ShowNewPasswordtxt.Size = new System.Drawing.Size(133, 23);
            this.ShowNewPasswordtxt.TabIndex = 10;
            this.ShowNewPasswordtxt.Text = "Show Password";
            this.ShowNewPasswordtxt.UseVisualStyleBackColor = false;
            this.ShowNewPasswordtxt.CheckedChanged += new System.EventHandler(this.ShowNewPasswordtxt_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(388, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(429, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "             Accounts Settings     ";
            // 
            // AdminSession_MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ShowNewPasswordtxt);
            this.Controls.Add(this.showoldpasswordtxt);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.NewPasstxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Oldpasswordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSession_MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSession_MyAccount";
            this.Load += new System.EventHandler(this.AdminSession_MyAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Oldpasswordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewPasstxt;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.CheckBox showoldpasswordtxt;
        private System.Windows.Forms.CheckBox ShowNewPasswordtxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}