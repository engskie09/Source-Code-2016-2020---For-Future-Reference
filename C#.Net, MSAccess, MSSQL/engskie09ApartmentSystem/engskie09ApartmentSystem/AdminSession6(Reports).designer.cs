namespace engskie09ApartmentSystem
{
    partial class AdminSession6_Reports_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExitform = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlShowRoomByGrid = new System.Windows.Forms.Panel();
            this.dgvCustomerCheckInOutlist = new System.Windows.Forms.DataGridView();
            this.clmFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheckinDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLengthofstay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFloorNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoomAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlShowRoomByGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerCheckInOutlist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitform
            // 
            this.btnExitform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btnExitform.FlatAppearance.BorderSize = 0;
            this.btnExitform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitform.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitform.Location = new System.Drawing.Point(1053, 0);
            this.btnExitform.Name = "btnExitform";
            this.btnExitform.Size = new System.Drawing.Size(37, 30);
            this.btnExitform.TabIndex = 5;
            this.btnExitform.Text = "X";
            this.btnExitform.UseVisualStyleBackColor = false;
            this.btnExitform.Click += new System.EventHandler(this.btnExitform_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.btnExitform);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 30);
            this.panel1.TabIndex = 17;
            // 
            // pnlShowRoomByGrid
            // 
            this.pnlShowRoomByGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.pnlShowRoomByGrid.Controls.Add(this.dgvCustomerCheckInOutlist);
            this.pnlShowRoomByGrid.Location = new System.Drawing.Point(12, 36);
            this.pnlShowRoomByGrid.Name = "pnlShowRoomByGrid";
            this.pnlShowRoomByGrid.Size = new System.Drawing.Size(1066, 552);
            this.pnlShowRoomByGrid.TabIndex = 16;
            // 
            // dgvCustomerCheckInOutlist
            // 
            this.dgvCustomerCheckInOutlist.AllowUserToAddRows = false;
            this.dgvCustomerCheckInOutlist.AllowUserToDeleteRows = false;
            this.dgvCustomerCheckInOutlist.AllowUserToResizeColumns = false;
            this.dgvCustomerCheckInOutlist.AllowUserToResizeRows = false;
            this.dgvCustomerCheckInOutlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCustomerCheckInOutlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomerCheckInOutlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerCheckInOutlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerCheckInOutlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerCheckInOutlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstname,
            this.clmLastname,
            this.clmMiddleName,
            this.clmCustomerID,
            this.clmGender,
            this.clmCheckinDate,
            this.clmCheckoutDate,
            this.clmLengthofstay,
            this.clmRoomNo,
            this.clmRoomType,
            this.clmFloorNo,
            this.clmRoomAmount,
            this.clmTotalAmount,
            this.clmAction});
            this.dgvCustomerCheckInOutlist.Location = new System.Drawing.Point(23, 31);
            this.dgvCustomerCheckInOutlist.MultiSelect = false;
            this.dgvCustomerCheckInOutlist.Name = "dgvCustomerCheckInOutlist";
            this.dgvCustomerCheckInOutlist.ReadOnly = true;
            this.dgvCustomerCheckInOutlist.RowHeadersVisible = false;
            this.dgvCustomerCheckInOutlist.RowHeadersWidth = 50;
            this.dgvCustomerCheckInOutlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dgvCustomerCheckInOutlist.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerCheckInOutlist.RowTemplate.Height = 80;
            this.dgvCustomerCheckInOutlist.RowTemplate.ReadOnly = true;
            this.dgvCustomerCheckInOutlist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerCheckInOutlist.Size = new System.Drawing.Size(1027, 506);
            this.dgvCustomerCheckInOutlist.TabIndex = 32;
            // 
            // clmFirstname
            // 
            this.clmFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmFirstname.Frozen = true;
            this.clmFirstname.HeaderText = "First Name";
            this.clmFirstname.Name = "clmFirstname";
            this.clmFirstname.ReadOnly = true;
            this.clmFirstname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmFirstname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFirstname.Width = 107;
            // 
            // clmLastname
            // 
            this.clmLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmLastname.Frozen = true;
            this.clmLastname.HeaderText = "Last Name";
            this.clmLastname.Name = "clmLastname";
            this.clmLastname.ReadOnly = true;
            this.clmLastname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmLastname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmMiddleName
            // 
            this.clmMiddleName.HeaderText = "Middle Name";
            this.clmMiddleName.Name = "clmMiddleName";
            this.clmMiddleName.ReadOnly = true;
            this.clmMiddleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmMiddleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmMiddleName.Width = 96;
            // 
            // clmCustomerID
            // 
            this.clmCustomerID.HeaderText = "Customer ID";
            this.clmCustomerID.Name = "clmCustomerID";
            this.clmCustomerID.ReadOnly = true;
            this.clmCustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCustomerID.Width = 92;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "Gender";
            this.clmGender.Name = "clmGender";
            this.clmGender.ReadOnly = true;
            this.clmGender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmGender.Width = 68;
            // 
            // clmCheckinDate
            // 
            this.clmCheckinDate.HeaderText = "Check in Date";
            this.clmCheckinDate.Name = "clmCheckinDate";
            this.clmCheckinDate.ReadOnly = true;
            this.clmCheckinDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCheckinDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCheckinDate.Width = 73;
            // 
            // clmCheckoutDate
            // 
            this.clmCheckoutDate.HeaderText = "Check out Date";
            this.clmCheckoutDate.Name = "clmCheckoutDate";
            this.clmCheckoutDate.ReadOnly = true;
            this.clmCheckoutDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCheckoutDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCheckoutDate.Width = 82;
            // 
            // clmLengthofstay
            // 
            this.clmLengthofstay.HeaderText = "Length of Stay";
            this.clmLengthofstay.Name = "clmLengthofstay";
            this.clmLengthofstay.ReadOnly = true;
            this.clmLengthofstay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmLengthofstay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmLengthofstay.Width = 79;
            // 
            // clmRoomNo
            // 
            this.clmRoomNo.HeaderText = "Room No";
            this.clmRoomNo.Name = "clmRoomNo";
            this.clmRoomNo.ReadOnly = true;
            this.clmRoomNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmRoomNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmRoomNo.Width = 72;
            // 
            // clmRoomType
            // 
            this.clmRoomType.HeaderText = "Room Type";
            this.clmRoomType.Name = "clmRoomType";
            this.clmRoomType.ReadOnly = true;
            this.clmRoomType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmRoomType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmRoomType.Width = 86;
            // 
            // clmFloorNo
            // 
            this.clmFloorNo.HeaderText = "Floor No";
            this.clmFloorNo.Name = "clmFloorNo";
            this.clmFloorNo.ReadOnly = true;
            this.clmFloorNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmFloorNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmFloorNo.Width = 68;
            // 
            // clmRoomAmount
            // 
            this.clmRoomAmount.HeaderText = "Room Amount";
            this.clmRoomAmount.Name = "clmRoomAmount";
            this.clmRoomAmount.ReadOnly = true;
            this.clmRoomAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmRoomAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmRoomAmount.Width = 103;
            // 
            // clmTotalAmount
            // 
            this.clmTotalAmount.HeaderText = "Total Amount";
            this.clmTotalAmount.Name = "clmTotalAmount";
            this.clmTotalAmount.ReadOnly = true;
            this.clmTotalAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmTotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmTotalAmount.Width = 99;
            // 
            // clmAction
            // 
            this.clmAction.HeaderText = "Action";
            this.clmAction.Name = "clmAction";
            this.clmAction.ReadOnly = true;
            this.clmAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmAction.Width = 59;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btnPrint.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btnPrint.Location = new System.Drawing.Point(418, 594);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(235, 36);
            this.btnPrint.TabIndex = 39;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // AdminSession6_Reports_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1090, 640);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlShowRoomByGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSession6_Reports_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSession6_Reports_";
            this.Load += new System.EventHandler(this.AdminSession6_Reports__Load);
            this.panel1.ResumeLayout(false);
            this.pnlShowRoomByGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerCheckInOutlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitform;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlShowRoomByGrid;
        public System.Windows.Forms.DataGridView dgvCustomerCheckInOutlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheckinDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLengthofstay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFloorNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoomAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAction;
        private System.Windows.Forms.Button btnPrint;
    }
}