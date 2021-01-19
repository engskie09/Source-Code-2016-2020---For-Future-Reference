namespace PeyRole
{
    partial class Time_in_out
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empDatagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTimeIn = new System.Windows.Forms.Button();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTimeOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.empDatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // empDatagrid
            // 
            this.empDatagrid.AllowUserToAddRows = false;
            this.empDatagrid.AllowUserToDeleteRows = false;
            this.empDatagrid.AllowUserToResizeColumns = false;
            this.empDatagrid.AllowUserToResizeRows = false;
            this.empDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empDatagrid.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Modern No. 20", 15F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.empDatagrid.ColumnHeadersHeight = 60;
            this.empDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.empDatagrid.Location = new System.Drawing.Point(65, 48);
            this.empDatagrid.Name = "empDatagrid";
            this.empDatagrid.ReadOnly = true;
            this.empDatagrid.RowHeadersVisible = false;
            this.empDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Modern No. 20", 15F);
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.empDatagrid.RowTemplate.Height = 50;
            this.empDatagrid.Size = new System.Drawing.Size(897, 420);
            this.empDatagrid.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Full Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Time In";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Time Out";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // buttonTimeIn
            // 
            this.buttonTimeIn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTimeIn.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.buttonTimeIn.Location = new System.Drawing.Point(176, 74);
            this.buttonTimeIn.Name = "buttonTimeIn";
            this.buttonTimeIn.Size = new System.Drawing.Size(96, 45);
            this.buttonTimeIn.TabIndex = 71;
            this.buttonTimeIn.Text = "Time In";
            this.buttonTimeIn.UseVisualStyleBackColor = false;
            this.buttonTimeIn.Click += new System.EventHandler(this.buttonTimeIn_Click);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.PowderBlue;
            this.txtEmployeeID.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.txtEmployeeID.Location = new System.Drawing.Point(176, 27);
            this.txtEmployeeID.MaxLength = 11;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(198, 36);
            this.txtEmployeeID.TabIndex = 70;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.buttonTimeOut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmployeeID);
            this.panel1.Controls.Add(this.buttonTimeIn);
            this.panel1.Location = new System.Drawing.Point(65, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 136);
            this.panel1.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 73;
            this.label3.Text = "EmployeeID:";
            // 
            // buttonTimeOut
            // 
            this.buttonTimeOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonTimeOut.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.buttonTimeOut.Location = new System.Drawing.Point(278, 74);
            this.buttonTimeOut.Name = "buttonTimeOut";
            this.buttonTimeOut.Size = new System.Drawing.Size(96, 45);
            this.buttonTimeOut.TabIndex = 74;
            this.buttonTimeOut.Text = "Time Out";
            this.buttonTimeOut.UseVisualStyleBackColor = false;
            this.buttonTimeOut.Click += new System.EventHandler(this.buttonTimeOut_Click);
            // 
            // Time_in_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 633);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.empDatagrid);
            this.Name = "Time_in_out";
            this.Load += new System.EventHandler(this.Time_in_out_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonTimeIn;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTimeOut;
    }
}