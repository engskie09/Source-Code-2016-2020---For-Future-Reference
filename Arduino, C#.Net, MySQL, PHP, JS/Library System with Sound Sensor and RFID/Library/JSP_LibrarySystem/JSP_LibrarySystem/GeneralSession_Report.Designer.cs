namespace JSP_LibrarySystem
{
    partial class GeneralSession_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralSession_Report));
            this.tb_BorrowedBooks = new System.Windows.Forms.TabPage();
            this.dgv_BorrowedList = new System.Windows.Forms.DataGridView();
            this.clm_reportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowerFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowerMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowerLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowedBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowedBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowedBookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_returnCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ReportAssignedStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_BorrowAndReturn = new System.Windows.Forms.TabControl();
            this.tb_ReturnedBooks = new System.Windows.Forms.TabPage();
            this.dgv_ReturnedList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_BorrowedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowedList)).BeginInit();
            this.tb_BorrowAndReturn.SuspendLayout();
            this.tb_ReturnedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReturnedList)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_BorrowedBooks
            // 
            this.tb_BorrowedBooks.BackColor = System.Drawing.Color.Black;
            this.tb_BorrowedBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_BorrowedBooks.BackgroundImage")));
            this.tb_BorrowedBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_BorrowedBooks.Controls.Add(this.dgv_BorrowedList);
            this.tb_BorrowedBooks.Location = new System.Drawing.Point(4, 28);
            this.tb_BorrowedBooks.Name = "tb_BorrowedBooks";
            this.tb_BorrowedBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tb_BorrowedBooks.Size = new System.Drawing.Size(942, 518);
            this.tb_BorrowedBooks.TabIndex = 0;
            this.tb_BorrowedBooks.Text = "Borrowed Book";
            this.tb_BorrowedBooks.Click += new System.EventHandler(this.tb_BorrowedBooks_Click);
            // 
            // dgv_BorrowedList
            // 
            this.dgv_BorrowedList.AllowUserToResizeColumns = false;
            this.dgv_BorrowedList.AllowUserToResizeRows = false;
            this.dgv_BorrowedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BorrowedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BorrowedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_reportID,
            this.clm_BorrowID,
            this.clm_BorrowerID,
            this.clm_BorrowerFirstName,
            this.clm_BorrowerMiddleName,
            this.clm_BorrowerLastName,
            this.clm_BorrowedBookID,
            this.clm_BorrowedBookTitle,
            this.clm_BorrowedBookQuantity,
            this.clm_BorrowedDate,
            this.clm_returnCondition,
            this.clm_ReportAssignedStaff});
            this.dgv_BorrowedList.Location = new System.Drawing.Point(21, 65);
            this.dgv_BorrowedList.Name = "dgv_BorrowedList";
            this.dgv_BorrowedList.Size = new System.Drawing.Size(900, 400);
            this.dgv_BorrowedList.TabIndex = 0;
            // 
            // clm_reportID
            // 
            this.clm_reportID.HeaderText = "Report ID";
            this.clm_reportID.Name = "clm_reportID";
            this.clm_reportID.ReadOnly = true;
            // 
            // clm_BorrowID
            // 
            this.clm_BorrowID.HeaderText = "Borrow ID";
            this.clm_BorrowID.Name = "clm_BorrowID";
            this.clm_BorrowID.ReadOnly = true;
            // 
            // clm_BorrowerID
            // 
            this.clm_BorrowerID.HeaderText = "Borrower ID";
            this.clm_BorrowerID.Name = "clm_BorrowerID";
            this.clm_BorrowerID.ReadOnly = true;
            // 
            // clm_BorrowerFirstName
            // 
            this.clm_BorrowerFirstName.HeaderText = "First Name";
            this.clm_BorrowerFirstName.Name = "clm_BorrowerFirstName";
            this.clm_BorrowerFirstName.ReadOnly = true;
            // 
            // clm_BorrowerMiddleName
            // 
            this.clm_BorrowerMiddleName.HeaderText = "Middle Name";
            this.clm_BorrowerMiddleName.Name = "clm_BorrowerMiddleName";
            this.clm_BorrowerMiddleName.ReadOnly = true;
            // 
            // clm_BorrowerLastName
            // 
            this.clm_BorrowerLastName.HeaderText = "Last Name";
            this.clm_BorrowerLastName.Name = "clm_BorrowerLastName";
            this.clm_BorrowerLastName.ReadOnly = true;
            // 
            // clm_BorrowedBookID
            // 
            this.clm_BorrowedBookID.HeaderText = "Book ID";
            this.clm_BorrowedBookID.Name = "clm_BorrowedBookID";
            this.clm_BorrowedBookID.ReadOnly = true;
            // 
            // clm_BorrowedBookTitle
            // 
            this.clm_BorrowedBookTitle.HeaderText = "Title";
            this.clm_BorrowedBookTitle.Name = "clm_BorrowedBookTitle";
            this.clm_BorrowedBookTitle.ReadOnly = true;
            // 
            // clm_BorrowedBookQuantity
            // 
            this.clm_BorrowedBookQuantity.HeaderText = "Quantity";
            this.clm_BorrowedBookQuantity.Name = "clm_BorrowedBookQuantity";
            this.clm_BorrowedBookQuantity.ReadOnly = true;
            // 
            // clm_BorrowedDate
            // 
            this.clm_BorrowedDate.HeaderText = "Borrowed Date";
            this.clm_BorrowedDate.Name = "clm_BorrowedDate";
            this.clm_BorrowedDate.ReadOnly = true;
            // 
            // clm_returnCondition
            // 
            this.clm_returnCondition.HeaderText = "Return Condition";
            this.clm_returnCondition.Name = "clm_returnCondition";
            this.clm_returnCondition.ReadOnly = true;
            // 
            // clm_ReportAssignedStaff
            // 
            this.clm_ReportAssignedStaff.HeaderText = "Assigned Staff";
            this.clm_ReportAssignedStaff.Name = "clm_ReportAssignedStaff";
            this.clm_ReportAssignedStaff.ReadOnly = true;
            // 
            // tb_BorrowAndReturn
            // 
            this.tb_BorrowAndReturn.Controls.Add(this.tb_BorrowedBooks);
            this.tb_BorrowAndReturn.Controls.Add(this.tb_ReturnedBooks);
            this.tb_BorrowAndReturn.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BorrowAndReturn.Location = new System.Drawing.Point(119, 156);
            this.tb_BorrowAndReturn.Name = "tb_BorrowAndReturn";
            this.tb_BorrowAndReturn.SelectedIndex = 0;
            this.tb_BorrowAndReturn.Size = new System.Drawing.Size(950, 550);
            this.tb_BorrowAndReturn.TabIndex = 0;
            // 
            // tb_ReturnedBooks
            // 
            this.tb_ReturnedBooks.BackColor = System.Drawing.Color.Transparent;
            this.tb_ReturnedBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_ReturnedBooks.BackgroundImage")));
            this.tb_ReturnedBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_ReturnedBooks.Controls.Add(this.dgv_ReturnedList);
            this.tb_ReturnedBooks.Location = new System.Drawing.Point(4, 28);
            this.tb_ReturnedBooks.Name = "tb_ReturnedBooks";
            this.tb_ReturnedBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tb_ReturnedBooks.Size = new System.Drawing.Size(942, 518);
            this.tb_ReturnedBooks.TabIndex = 1;
            this.tb_ReturnedBooks.Text = "Returned Book";
            this.tb_ReturnedBooks.Click += new System.EventHandler(this.tb_ReturnedBooks_Click);
            // 
            // dgv_ReturnedList
            // 
            this.dgv_ReturnedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ReturnedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReturnedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgv_ReturnedList.Location = new System.Drawing.Point(21, 65);
            this.dgv_ReturnedList.Name = "dgv_ReturnedList";
            this.dgv_ReturnedList.Size = new System.Drawing.Size(900, 400);
            this.dgv_ReturnedList.TabIndex = 1;
            this.dgv_ReturnedList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ReturnedList_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Report ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Borrow ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Borrower ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Title";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Returned Date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Return Condition";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Assigned Staff";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(27, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 38;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-2, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 32);
            this.label4.TabIndex = 43;
            this.label4.Text = "              Book Reports     ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1077, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1118, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 47;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GeneralSession_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_BorrowAndReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSession_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralSession_Report";
            this.Load += new System.EventHandler(this.GeneralSession_Report_Load);
            this.tb_BorrowedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowedList)).EndInit();
            this.tb_BorrowAndReturn.ResumeLayout(false);
            this.tb_ReturnedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReturnedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tb_BorrowedBooks;
        private System.Windows.Forms.TabControl tb_BorrowAndReturn;
        private System.Windows.Forms.TabPage tb_ReturnedBooks;
        private System.Windows.Forms.DataGridView dgv_BorrowedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_reportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowerMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowerLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowedBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowedBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowedBookQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_returnCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ReportAssignedStaff;
        private System.Windows.Forms.DataGridView dgv_ReturnedList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;


    }
}