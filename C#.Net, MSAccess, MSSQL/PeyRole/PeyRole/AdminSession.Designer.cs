namespace PeyRole
{
    partial class AdminSession
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Accounts = new System.Windows.Forms.Button();
            this.Payroll = new System.Windows.Forms.Button();
            this.Personel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datetoday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeToday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timestart = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.Accounts);
            this.panel1.Controls.Add(this.Payroll);
            this.panel1.Controls.Add(this.Personel);
            this.panel1.Location = new System.Drawing.Point(402, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 256);
            this.panel1.TabIndex = 0;
            // 
            // Accounts
            // 
            this.Accounts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Accounts.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.Accounts.Location = new System.Drawing.Point(12, 116);
            this.Accounts.Name = "Accounts";
            this.Accounts.Size = new System.Drawing.Size(164, 46);
            this.Accounts.TabIndex = 3;
            this.Accounts.Text = "Accounts";
            this.Accounts.UseVisualStyleBackColor = false;
            // 
            // Payroll
            // 
            this.Payroll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Payroll.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.Payroll.Location = new System.Drawing.Point(12, 64);
            this.Payroll.Name = "Payroll";
            this.Payroll.Size = new System.Drawing.Size(164, 46);
            this.Payroll.TabIndex = 2;
            this.Payroll.Text = "Payroll";
            this.Payroll.UseVisualStyleBackColor = false;
            this.Payroll.Click += new System.EventHandler(this.Payroll_Click);
            // 
            // Personel
            // 
            this.Personel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Personel.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.Personel.Location = new System.Drawing.Point(12, 12);
            this.Personel.Name = "Personel";
            this.Personel.Size = new System.Drawing.Size(164, 46);
            this.Personel.TabIndex = 1;
            this.Personel.Text = "Personel";
            this.Personel.UseVisualStyleBackColor = false;
            this.Personel.Click += new System.EventHandler(this.Personel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.datetoday);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.timeToday);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 340);
            this.panel2.TabIndex = 3;
            // 
            // datetoday
            // 
            this.datetoday.AutoSize = true;
            this.datetoday.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.datetoday.Location = new System.Drawing.Point(75, 70);
            this.datetoday.Name = "datetoday";
            this.datetoday.Size = new System.Drawing.Size(92, 22);
            this.datetoday.TabIndex = 11;
            this.datetoday.Text = "dateToday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label5.Location = new System.Drawing.Point(25, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            // 
            // timeToday
            // 
            this.timeToday.AutoSize = true;
            this.timeToday.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.timeToday.Location = new System.Drawing.Point(75, 43);
            this.timeToday.Name = "timeToday";
            this.timeToday.Size = new System.Drawing.Size(94, 22);
            this.timeToday.TabIndex = 9;
            this.timeToday.Text = "timeToday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label1.Location = new System.Drawing.Point(139, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label3.Location = new System.Drawing.Point(22, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time:";
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logout.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.logout.Location = new System.Drawing.Point(26, 10);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(125, 32);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Name: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timestart
            // 
            this.timestart.Tick += new System.EventHandler(this.timestart_Tick);
            // 
            // AdminSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(775, 607);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSession";
            this.Load += new System.EventHandler(this.AdminSession_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Personel;
        private System.Windows.Forms.Button Payroll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeToday;
        private System.Windows.Forms.Timer timestart;
        private System.Windows.Forms.Label datetoday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Accounts;
    }
}