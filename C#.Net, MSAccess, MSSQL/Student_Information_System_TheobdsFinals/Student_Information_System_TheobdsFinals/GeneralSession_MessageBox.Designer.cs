namespace Student_Information_System_TheobdsFinals
{
    partial class GeneralSession_MessageBox
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
            this.pnl_contentContainer = new System.Windows.Forms.Panel();
            this.txt_setDescription = new System.Windows.Forms.Label();
            this.pnl_titleContainer = new System.Windows.Forms.Panel();
            this.txt_setTitle = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.pnl_contentContainer.SuspendLayout();
            this.pnl_titleContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_contentContainer
            // 
            this.pnl_contentContainer.AutoSize = true;
            this.pnl_contentContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.pnl_contentContainer.Controls.Add(this.txt_setDescription);
            this.pnl_contentContainer.Location = new System.Drawing.Point(12, 52);
            this.pnl_contentContainer.Name = "pnl_contentContainer";
            this.pnl_contentContainer.Size = new System.Drawing.Size(10, 47);
            this.pnl_contentContainer.TabIndex = 0;
            // 
            // txt_setDescription
            // 
            this.txt_setDescription.AutoSize = true;
            this.txt_setDescription.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_setDescription.Location = new System.Drawing.Point(3, 10);
            this.txt_setDescription.MaximumSize = new System.Drawing.Size(1300, 1300);
            this.txt_setDescription.Name = "txt_setDescription";
            this.txt_setDescription.Size = new System.Drawing.Size(0, 26);
            this.txt_setDescription.TabIndex = 0;
            // 
            // pnl_titleContainer
            // 
            this.pnl_titleContainer.AutoSize = true;
            this.pnl_titleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.pnl_titleContainer.Controls.Add(this.txt_setTitle);
            this.pnl_titleContainer.Location = new System.Drawing.Point(12, 17);
            this.pnl_titleContainer.Name = "pnl_titleContainer";
            this.pnl_titleContainer.Size = new System.Drawing.Size(10, 29);
            this.pnl_titleContainer.TabIndex = 1;
            // 
            // txt_setTitle
            // 
            this.txt_setTitle.AutoSize = true;
            this.txt_setTitle.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_setTitle.Location = new System.Drawing.Point(3, 0);
            this.txt_setTitle.MaximumSize = new System.Drawing.Size(200, 200);
            this.txt_setTitle.Name = "txt_setTitle";
            this.txt_setTitle.Size = new System.Drawing.Size(0, 26);
            this.txt_setTitle.TabIndex = 1;
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_Ok.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.Location = new System.Drawing.Point(12, 116);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(84, 41);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // GeneralSession_MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(108, 174);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.pnl_titleContainer);
            this.Controls.Add(this.pnl_contentContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSession_MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralSession_MessageBox";
            this.Load += new System.EventHandler(this.GeneralSession_MessageBox_Load);
            this.pnl_contentContainer.ResumeLayout(false);
            this.pnl_contentContainer.PerformLayout();
            this.pnl_titleContainer.ResumeLayout(false);
            this.pnl_titleContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_contentContainer;
        private System.Windows.Forms.Label txt_setDescription;
        private System.Windows.Forms.Panel pnl_titleContainer;
        private System.Windows.Forms.Label txt_setTitle;
        private System.Windows.Forms.Button btn_Ok;
    }
}