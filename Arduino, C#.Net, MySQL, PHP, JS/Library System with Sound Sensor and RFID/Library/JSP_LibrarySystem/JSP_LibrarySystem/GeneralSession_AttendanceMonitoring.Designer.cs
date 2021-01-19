namespace JSP_LibrarySystem
{
    partial class GeneralSession_AttendanceMonitoring
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
            this.dgv_AttendanceList = new System.Windows.Forms.DataGridView();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_yearlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AttendanceList
            // 
            this.dgv_AttendanceList.AllowUserToAddRows = false;
            this.dgv_AttendanceList.AllowUserToDeleteRows = false;
            this.dgv_AttendanceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AttendanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AttendanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.student_firstname,
            this.student_middlename,
            this.student_lastname,
            this.student_gender,
            this.student_yearlevel,
            this.student_section});
            this.dgv_AttendanceList.Location = new System.Drawing.Point(12, 12);
            this.dgv_AttendanceList.Name = "dgv_AttendanceList";
            this.dgv_AttendanceList.ReadOnly = true;
            this.dgv_AttendanceList.Size = new System.Drawing.Size(975, 320);
            this.dgv_AttendanceList.TabIndex = 2;
            // 
            // student_id
            // 
            this.student_id.HeaderText = "ID";
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            // 
            // student_firstname
            // 
            this.student_firstname.HeaderText = "First Name";
            this.student_firstname.Name = "student_firstname";
            this.student_firstname.ReadOnly = true;
            // 
            // student_middlename
            // 
            this.student_middlename.HeaderText = "Middle Name";
            this.student_middlename.Name = "student_middlename";
            this.student_middlename.ReadOnly = true;
            // 
            // student_lastname
            // 
            this.student_lastname.HeaderText = "Last Name";
            this.student_lastname.Name = "student_lastname";
            this.student_lastname.ReadOnly = true;
            // 
            // student_gender
            // 
            this.student_gender.HeaderText = "Gender";
            this.student_gender.Name = "student_gender";
            this.student_gender.ReadOnly = true;
            // 
            // student_yearlevel
            // 
            this.student_yearlevel.HeaderText = "Year Level";
            this.student_yearlevel.Name = "student_yearlevel";
            this.student_yearlevel.ReadOnly = true;
            // 
            // student_section
            // 
            this.student_section.HeaderText = "Section";
            this.student_section.Name = "student_section";
            this.student_section.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GeneralSession_AttendanceMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 344);
            this.Controls.Add(this.dgv_AttendanceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSession_AttendanceMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralSession_AttendanceMonitoring";
            this.Load += new System.EventHandler(this.GeneralSession_AttendanceMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AttendanceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AttendanceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_yearlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_section;
        private System.Windows.Forms.Timer timer1;
    }
}