namespace PeyRole
{
    partial class AdminSession_Employee_List_
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.empDatagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datetoday = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeToday = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.returnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timestart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empDatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.empDatagrid.ColumnHeadersHeight = 60;
            this.empDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column7});
            this.empDatagrid.Location = new System.Drawing.Point(408, 64);
            this.empDatagrid.Name = "empDatagrid";
            this.empDatagrid.ReadOnly = true;
            this.empDatagrid.RowHeadersVisible = false;
            this.empDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 15F);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.empDatagrid.RowTemplate.Height = 50;
            this.empDatagrid.Size = new System.Drawing.Size(1504, 695);
            this.empDatagrid.TabIndex = 0;
            this.empDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empDatagrid_CellContentClick);
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
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Birthdate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Age";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Gender";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Contact No.";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Designation";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date Hired";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.selectedID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.UpdateEmployee);
            this.panel1.Controls.Add(this.AddEmployee);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(408, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 46);
            this.panel1.TabIndex = 3;
            this.panel1.Tag = "";
            // 
            // selectedID
            // 
            this.selectedID.AutoSize = true;
            this.selectedID.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.selectedID.Location = new System.Drawing.Point(994, 12);
            this.selectedID.Name = "selectedID";
            this.selectedID.Size = new System.Drawing.Size(66, 22);
            this.selectedID.TabIndex = 10;
            this.selectedID.Text = "--------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label6.Location = new System.Drawing.Point(841, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Selected EmpID:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.button3.Location = new System.Drawing.Point(701, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpdateEmployee.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.UpdateEmployee.Location = new System.Drawing.Point(556, 7);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(125, 32);
            this.UpdateEmployee.TabIndex = 7;
            this.UpdateEmployee.Text = "Update";
            this.UpdateEmployee.UseVisualStyleBackColor = false;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AddEmployee.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.AddEmployee.Location = new System.Drawing.Point(410, 7);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(125, 32);
            this.AddEmployee.TabIndex = 6;
            this.AddEmployee.Text = "Add";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.login.Location = new System.Drawing.Point(252, 7);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(125, 32);
            this.login.TabIndex = 5;
            this.login.Text = "Show/Hide";
            this.login.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Worker ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.textBox1.Location = new System.Drawing.Point(137, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 29);
            this.textBox1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.datetoday);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.timeToday);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.returnBack);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 340);
            this.panel2.TabIndex = 4;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label2.Location = new System.Drawing.Point(139, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "------";
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
            // returnBack
            // 
            this.returnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.returnBack.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.returnBack.Location = new System.Drawing.Point(26, 10);
            this.returnBack.Name = "returnBack";
            this.returnBack.Size = new System.Drawing.Size(125, 32);
            this.returnBack.TabIndex = 6;
            this.returnBack.Text = "Return";
            this.returnBack.UseVisualStyleBackColor = false;
            this.returnBack.Click += new System.EventHandler(this.returnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15F);
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Admin Name: ";
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
            // AdminSession_Employee_List_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 851);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.empDatagrid);
            this.Name = "AdminSession_Employee_List_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSession_Employee_List_";
            this.Load += new System.EventHandler(this.AdminSession_Employee_List__Load);
            ((System.ComponentModel.ISupportInitialize)(this.empDatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empDatagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label datetoday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timeToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timestart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label selectedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}