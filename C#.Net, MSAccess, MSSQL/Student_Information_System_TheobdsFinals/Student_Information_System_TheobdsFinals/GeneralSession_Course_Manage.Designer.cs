namespace Student_Information_System_TheobdsFinals
{
    partial class GeneralSession_Course_Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbx_getYearLevel = new System.Windows.Forms.ComboBox();
            this.btn_Action = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_getCourseDescription = new System.Windows.Forms.TextBox();
            this.txt_getCourseName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_courseList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.cmbx_getYearLevel);
            this.panel2.Controls.Add(this.btn_Action);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.txt_getCourseDescription);
            this.panel2.Controls.Add(this.txt_getCourseName);
            this.panel2.Location = new System.Drawing.Point(563, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 325);
            this.panel2.TabIndex = 6;
            // 
            // cmbx_getYearLevel
            // 
            this.cmbx_getYearLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.cmbx_getYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_getYearLevel.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.cmbx_getYearLevel.FormattingEnabled = true;
            this.cmbx_getYearLevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.cmbx_getYearLevel.Location = new System.Drawing.Point(8, 138);
            this.cmbx_getYearLevel.Name = "cmbx_getYearLevel";
            this.cmbx_getYearLevel.Size = new System.Drawing.Size(238, 34);
            this.cmbx_getYearLevel.TabIndex = 11;
            // 
            // btn_Action
            // 
            this.btn_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_Action.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.btn_Action.ForeColor = System.Drawing.Color.White;
            this.btn_Action.Location = new System.Drawing.Point(28, 199);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(201, 41);
            this.btn_Action.TabIndex = 7;
            this.btn_Action.Text = "Select Action";
            this.btn_Action.UseVisualStyleBackColor = false;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_Delete.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(166, 251);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(63, 41);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_Update.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(97, 251);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(63, 41);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_Add.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(28, 251);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 41);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_getCourseDescription
            // 
            this.txt_getCourseDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txt_getCourseDescription.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_getCourseDescription.Location = new System.Drawing.Point(8, 49);
            this.txt_getCourseDescription.Multiline = true;
            this.txt_getCourseDescription.Name = "txt_getCourseDescription";
            this.txt_getCourseDescription.Size = new System.Drawing.Size(238, 83);
            this.txt_getCourseDescription.TabIndex = 2;
            this.txt_getCourseDescription.Text = "\r\nEnter Course Description";
            this.txt_getCourseDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_getCourseDescription.Enter += new System.EventHandler(this.txt_getCourseDescription_Enter);
            this.txt_getCourseDescription.Leave += new System.EventHandler(this.txt_getCourseDescription_Leave);
            // 
            // txt_getCourseName
            // 
            this.txt_getCourseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txt_getCourseName.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_getCourseName.Location = new System.Drawing.Point(8, 12);
            this.txt_getCourseName.Name = "txt_getCourseName";
            this.txt_getCourseName.Size = new System.Drawing.Size(238, 31);
            this.txt_getCourseName.TabIndex = 1;
            this.txt_getCourseName.Text = "Enter Course Name";
            this.txt_getCourseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_getCourseName.Enter += new System.EventHandler(this.txt_getCourseName_Enter);
            this.txt_getCourseName.Leave += new System.EventHandler(this.txt_getCourseName_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.dgv_courseList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 424);
            this.panel1.TabIndex = 5;
            // 
            // dgv_courseList
            // 
            this.dgv_courseList.AllowUserToAddRows = false;
            this.dgv_courseList.AllowUserToDeleteRows = false;
            this.dgv_courseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_courseList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_courseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dgv_courseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_courseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_courseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_courseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_courseList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_courseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.dgv_courseList.Location = new System.Drawing.Point(11, 12);
            this.dgv_courseList.Name = "dgv_courseList";
            this.dgv_courseList.ReadOnly = true;
            this.dgv_courseList.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_courseList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_courseList.Size = new System.Drawing.Size(487, 401);
            this.dgv_courseList.TabIndex = 1;
            this.dgv_courseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_courseList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Course ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Course Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Year Level";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GeneralSession_Course_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(826, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSession_Course_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneralSession_Course_Manage";
            this.Load += new System.EventHandler(this.GeneralSession_Course_Manage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_courseList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbx_getYearLevel;
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_getCourseDescription;
        private System.Windows.Forms.TextBox txt_getCourseName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_courseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}