namespace Student_Information_System_TheobdsFinals
{
    partial class GeneralSession_Student_Manage
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
            this.dgv_studentList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbx_getYearLevel = new System.Windows.Forms.ComboBox();
            this.btn_Action = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_getPhoneNo = new System.Windows.Forms.TextBox();
            this.rdbtn_getGenderFemale = new System.Windows.Forms.RadioButton();
            this.rdbtn_getGenderMale = new System.Windows.Forms.RadioButton();
            this.dtp_getBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txt_getLastname = new System.Windows.Forms.TextBox();
            this.txt_getFirstname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_studentList
            // 
            this.dgv_studentList.AllowUserToAddRows = false;
            this.dgv_studentList.AllowUserToDeleteRows = false;
            this.dgv_studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_studentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_studentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dgv_studentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_studentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_studentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_studentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_studentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.dgv_studentList.Location = new System.Drawing.Point(10, 13);
            this.dgv_studentList.Name = "dgv_studentList";
            this.dgv_studentList.ReadOnly = true;
            this.dgv_studentList.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_studentList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_studentList.Size = new System.Drawing.Size(487, 401);
            this.dgv_studentList.TabIndex = 0;
            this.dgv_studentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_studentList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Student ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Birthdate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Gender";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone No";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Year Level";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.dgv_studentList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 424);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.cmbx_getYearLevel);
            this.panel2.Controls.Add(this.btn_Action);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.txt_getPhoneNo);
            this.panel2.Controls.Add(this.rdbtn_getGenderFemale);
            this.panel2.Controls.Add(this.rdbtn_getGenderMale);
            this.panel2.Controls.Add(this.dtp_getBirthdate);
            this.panel2.Controls.Add(this.txt_getLastname);
            this.panel2.Controls.Add(this.txt_getFirstname);
            this.panel2.Location = new System.Drawing.Point(563, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 371);
            this.panel2.TabIndex = 2;
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
            this.cmbx_getYearLevel.Location = new System.Drawing.Point(8, 205);
            this.cmbx_getYearLevel.Name = "cmbx_getYearLevel";
            this.cmbx_getYearLevel.Size = new System.Drawing.Size(238, 34);
            this.cmbx_getYearLevel.TabIndex = 11;
            // 
            // btn_Action
            // 
            this.btn_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.btn_Action.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.btn_Action.ForeColor = System.Drawing.Color.White;
            this.btn_Action.Location = new System.Drawing.Point(28, 260);
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
            this.btn_Delete.Location = new System.Drawing.Point(166, 312);
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
            this.btn_Update.Location = new System.Drawing.Point(97, 312);
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
            this.btn_Add.Location = new System.Drawing.Point(28, 312);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 41);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_getPhoneNo
            // 
            this.txt_getPhoneNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txt_getPhoneNo.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_getPhoneNo.Location = new System.Drawing.Point(8, 159);
            this.txt_getPhoneNo.Name = "txt_getPhoneNo";
            this.txt_getPhoneNo.Size = new System.Drawing.Size(238, 31);
            this.txt_getPhoneNo.TabIndex = 6;
            this.txt_getPhoneNo.Text = "Enter Phone No.";
            this.txt_getPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_getPhoneNo.Enter += new System.EventHandler(this.txt_getPhoneNo_Enter);
            this.txt_getPhoneNo.Leave += new System.EventHandler(this.txt_getPhoneNo_Leave);
            // 
            // rdbtn_getGenderFemale
            // 
            this.rdbtn_getGenderFemale.AutoSize = true;
            this.rdbtn_getGenderFemale.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.rdbtn_getGenderFemale.Location = new System.Drawing.Point(106, 123);
            this.rdbtn_getGenderFemale.Name = "rdbtn_getGenderFemale";
            this.rdbtn_getGenderFemale.Size = new System.Drawing.Size(97, 30);
            this.rdbtn_getGenderFemale.TabIndex = 5;
            this.rdbtn_getGenderFemale.Text = "Female";
            this.rdbtn_getGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtn_getGenderMale
            // 
            this.rdbtn_getGenderMale.AutoSize = true;
            this.rdbtn_getGenderMale.Checked = true;
            this.rdbtn_getGenderMale.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.rdbtn_getGenderMale.Location = new System.Drawing.Point(27, 123);
            this.rdbtn_getGenderMale.Name = "rdbtn_getGenderMale";
            this.rdbtn_getGenderMale.Size = new System.Drawing.Size(73, 30);
            this.rdbtn_getGenderMale.TabIndex = 4;
            this.rdbtn_getGenderMale.TabStop = true;
            this.rdbtn_getGenderMale.Text = "Male";
            this.rdbtn_getGenderMale.UseVisualStyleBackColor = true;
            // 
            // dtp_getBirthdate
            // 
            this.dtp_getBirthdate.CalendarFont = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold);
            this.dtp_getBirthdate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dtp_getBirthdate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.dtp_getBirthdate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.dtp_getBirthdate.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.dtp_getBirthdate.Location = new System.Drawing.Point(8, 86);
            this.dtp_getBirthdate.Name = "dtp_getBirthdate";
            this.dtp_getBirthdate.Size = new System.Drawing.Size(238, 31);
            this.dtp_getBirthdate.TabIndex = 3;
            // 
            // txt_getLastname
            // 
            this.txt_getLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txt_getLastname.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_getLastname.Location = new System.Drawing.Point(8, 49);
            this.txt_getLastname.Name = "txt_getLastname";
            this.txt_getLastname.Size = new System.Drawing.Size(238, 31);
            this.txt_getLastname.TabIndex = 2;
            this.txt_getLastname.Text = "Enter Lastname";
            this.txt_getLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_getLastname.Enter += new System.EventHandler(this.txt_getLastname_Enter);
            this.txt_getLastname.Leave += new System.EventHandler(this.txt_getLastname_Leave);
            // 
            // txt_getFirstname
            // 
            this.txt_getFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txt_getFirstname.Font = new System.Drawing.Font("Trebuchet MS", 15F);
            this.txt_getFirstname.Location = new System.Drawing.Point(8, 12);
            this.txt_getFirstname.Name = "txt_getFirstname";
            this.txt_getFirstname.Size = new System.Drawing.Size(238, 31);
            this.txt_getFirstname.TabIndex = 1;
            this.txt_getFirstname.Text = "Enter Firstname";
            this.txt_getFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_getFirstname.Enter += new System.EventHandler(this.txt_getFirstname_Enter);
            this.txt_getFirstname.Leave += new System.EventHandler(this.txt_getFirstname_Leave);
            // 
            // GeneralSession_Student_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(826, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSession_Student_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneralSession_Student_Manage";
            this.Load += new System.EventHandler(this.GeneralSession_Student_Manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_studentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_studentList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_getFirstname;
        private System.Windows.Forms.TextBox txt_getLastname;
        private System.Windows.Forms.DateTimePicker dtp_getBirthdate;
        private System.Windows.Forms.RadioButton rdbtn_getGenderMale;
        private System.Windows.Forms.RadioButton rdbtn_getGenderFemale;
        private System.Windows.Forms.TextBox txt_getPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Action;
        private System.Windows.Forms.ComboBox cmbx_getYearLevel;
    }
}