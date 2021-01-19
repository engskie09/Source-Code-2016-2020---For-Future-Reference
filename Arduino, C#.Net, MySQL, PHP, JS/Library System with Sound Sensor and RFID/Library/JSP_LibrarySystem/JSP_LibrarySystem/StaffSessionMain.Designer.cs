namespace JSP_LibrarySystem
{
    partial class StaffSessionMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSessionMain));
            this.btn_BorrowReturn = new System.Windows.Forms.Button();
            this.btn_BookManagement = new System.Windows.Forms.Button();
            this.btn_StudentManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_BorrowReturn
            // 
            this.btn_BorrowReturn.BackColor = System.Drawing.Color.White;
            this.btn_BorrowReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BorrowReturn.BackgroundImage")));
            this.btn_BorrowReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_BorrowReturn.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrowReturn.ForeColor = System.Drawing.Color.White;
            this.btn_BorrowReturn.Location = new System.Drawing.Point(897, 189);
            this.btn_BorrowReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BorrowReturn.Name = "btn_BorrowReturn";
            this.btn_BorrowReturn.Size = new System.Drawing.Size(175, 50);
            this.btn_BorrowReturn.TabIndex = 12;
            this.btn_BorrowReturn.Text = "Transactions";
            this.btn_BorrowReturn.UseVisualStyleBackColor = false;
            // 
            // btn_BookManagement
            // 
            this.btn_BookManagement.BackColor = System.Drawing.Color.White;
            this.btn_BookManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BookManagement.BackgroundImage")));
            this.btn_BookManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_BookManagement.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BookManagement.ForeColor = System.Drawing.Color.White;
            this.btn_BookManagement.Location = new System.Drawing.Point(717, 189);
            this.btn_BookManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BookManagement.Name = "btn_BookManagement";
            this.btn_BookManagement.Size = new System.Drawing.Size(175, 50);
            this.btn_BookManagement.TabIndex = 11;
            this.btn_BookManagement.Text = "Inventory";
            this.btn_BookManagement.UseVisualStyleBackColor = false;
            // 
            // btn_StudentManagement
            // 
            this.btn_StudentManagement.BackColor = System.Drawing.Color.White;
            this.btn_StudentManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_StudentManagement.BackgroundImage")));
            this.btn_StudentManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_StudentManagement.Font = new System.Drawing.Font("Myriad Pro", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StudentManagement.ForeColor = System.Drawing.Color.White;
            this.btn_StudentManagement.Location = new System.Drawing.Point(459, 189);
            this.btn_StudentManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_StudentManagement.Name = "btn_StudentManagement";
            this.btn_StudentManagement.Size = new System.Drawing.Size(250, 50);
            this.btn_StudentManagement.TabIndex = 10;
            this.btn_StudentManagement.Text = "Student Management";
            this.btn_StudentManagement.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(296, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 528);
            this.panel1.TabIndex = 7;
            // 
            // StaffSessionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.btn_BorrowReturn);
            this.Controls.Add(this.btn_BookManagement);
            this.Controls.Add(this.btn_StudentManagement);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffSessionMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffSessionMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BorrowReturn;
        private System.Windows.Forms.Button btn_BookManagement;
        private System.Windows.Forms.Button btn_StudentManagement;
        private System.Windows.Forms.Panel panel1;
    }
}