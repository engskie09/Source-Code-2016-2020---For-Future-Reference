namespace engskie09ApartmentSystem
{
    partial class AdminSession5_Manage_Staffs_
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
            this.dgvStafflist = new System.Windows.Forms.DataGridView();
            this.clmCustomer_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer_MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblgetAge = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pctBoxShowpassword = new System.Windows.Forms.PictureBox();
            this.dtpgetBirthday = new System.Windows.Forms.DateTimePicker();
            this.btngetAction = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtgetPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgetUsername = new System.Windows.Forms.TextBox();
            this.rbtngetGenderFemale = new System.Windows.Forms.RadioButton();
            this.rbtngetGenderMale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblgetStaffID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgetLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgetMiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgetFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExitform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStafflist)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxShowpassword)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStafflist
            // 
            this.dgvStafflist.AllowUserToAddRows = false;
            this.dgvStafflist.AllowUserToDeleteRows = false;
            this.dgvStafflist.AllowUserToResizeColumns = false;
            this.dgvStafflist.AllowUserToResizeRows = false;
            this.dgvStafflist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStafflist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStafflist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStafflist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStafflist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStafflist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCustomer_CustomerID,
            this.clmCustomer_FirstName,
            this.clmCustomer_MiddleName,
            this.clmCustomer_LastName});
            this.dgvStafflist.Location = new System.Drawing.Point(12, 61);
            this.dgvStafflist.MultiSelect = false;
            this.dgvStafflist.Name = "dgvStafflist";
            this.dgvStafflist.ReadOnly = true;
            this.dgvStafflist.RowHeadersVisible = false;
            this.dgvStafflist.RowHeadersWidth = 50;
            this.dgvStafflist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dgvStafflist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStafflist.Size = new System.Drawing.Size(529, 668);
            this.dgvStafflist.TabIndex = 33;
            this.dgvStafflist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStafflist_CellClick);
            // 
            // clmCustomer_CustomerID
            // 
            this.clmCustomer_CustomerID.HeaderText = "Staff ID";
            this.clmCustomer_CustomerID.Name = "clmCustomer_CustomerID";
            this.clmCustomer_CustomerID.ReadOnly = true;
            this.clmCustomer_CustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmCustomer_FirstName
            // 
            this.clmCustomer_FirstName.HeaderText = "First Name";
            this.clmCustomer_FirstName.Name = "clmCustomer_FirstName";
            this.clmCustomer_FirstName.ReadOnly = true;
            this.clmCustomer_FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmCustomer_MiddleName
            // 
            this.clmCustomer_MiddleName.HeaderText = "Middle Name";
            this.clmCustomer_MiddleName.Name = "clmCustomer_MiddleName";
            this.clmCustomer_MiddleName.ReadOnly = true;
            this.clmCustomer_MiddleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmCustomer_LastName
            // 
            this.clmCustomer_LastName.HeaderText = "Last Name";
            this.clmCustomer_LastName.Name = "clmCustomer_LastName";
            this.clmCustomer_LastName.ReadOnly = true;
            this.clmCustomer_LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.panel3.Controls.Add(this.lblgetAge);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pctBoxShowpassword);
            this.panel3.Controls.Add(this.dtpgetBirthday);
            this.panel3.Controls.Add(this.btngetAction);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtgetPassword);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtgetUsername);
            this.panel3.Controls.Add(this.rbtngetGenderFemale);
            this.panel3.Controls.Add(this.rbtngetGenderMale);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblgetStaffID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtgetLastName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtgetMiddleName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtgetFirstName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(547, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 504);
            this.panel3.TabIndex = 34;
            // 
            // lblgetAge
            // 
            this.lblgetAge.AutoSize = true;
            this.lblgetAge.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgetAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblgetAge.Location = new System.Drawing.Point(159, 320);
            this.lblgetAge.Name = "lblgetAge";
            this.lblgetAge.Size = new System.Drawing.Size(0, 19);
            this.lblgetAge.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label5.Location = new System.Drawing.Point(104, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Age:";
            // 
            // pctBoxShowpassword
            // 
            this.pctBoxShowpassword.Image = global::engskie09ApartmentSystem.Properties.Resources.showpassword;
            this.pctBoxShowpassword.Location = new System.Drawing.Point(279, 400);
            this.pctBoxShowpassword.Name = "pctBoxShowpassword";
            this.pctBoxShowpassword.Size = new System.Drawing.Size(31, 30);
            this.pctBoxShowpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxShowpassword.TabIndex = 43;
            this.pctBoxShowpassword.TabStop = false;
            this.pctBoxShowpassword.Click += new System.EventHandler(this.pctBoxShowpassword_Click);
            // 
            // dtpgetBirthday
            // 
            this.dtpgetBirthday.Enabled = false;
            this.dtpgetBirthday.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.dtpgetBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpgetBirthday.Location = new System.Drawing.Point(159, 220);
            this.dtpgetBirthday.Name = "dtpgetBirthday";
            this.dtpgetBirthday.Size = new System.Drawing.Size(136, 30);
            this.dtpgetBirthday.TabIndex = 38;
            this.dtpgetBirthday.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpgetBirthday.ValueChanged += new System.EventHandler(this.dtpgetBirthday_ValueChanged);
            // 
            // btngetAction
            // 
            this.btngetAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btngetAction.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btngetAction.Location = new System.Drawing.Point(78, 460);
            this.btngetAction.Name = "btngetAction";
            this.btngetAction.Size = new System.Drawing.Size(180, 36);
            this.btngetAction.TabIndex = 42;
            this.btngetAction.UseVisualStyleBackColor = false;
            this.btngetAction.Visible = false;
            this.btngetAction.Click += new System.EventHandler(this.btngetAction_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label9.Location = new System.Drawing.Point(54, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Password:";
            // 
            // txtgetPassword
            // 
            this.txtgetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.txtgetPassword.Enabled = false;
            this.txtgetPassword.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.txtgetPassword.Location = new System.Drawing.Point(159, 400);
            this.txtgetPassword.MaxLength = 10;
            this.txtgetPassword.Name = "txtgetPassword";
            this.txtgetPassword.PasswordChar = '*';
            this.txtgetPassword.Size = new System.Drawing.Size(114, 30);
            this.txtgetPassword.TabIndex = 38;
            this.txtgetPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLetterNumber_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label11.Location = new System.Drawing.Point(44, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "User Name:";
            // 
            // txtgetUsername
            // 
            this.txtgetUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.txtgetUsername.Enabled = false;
            this.txtgetUsername.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.txtgetUsername.Location = new System.Drawing.Point(159, 360);
            this.txtgetUsername.MaxLength = 10;
            this.txtgetUsername.Name = "txtgetUsername";
            this.txtgetUsername.Size = new System.Drawing.Size(114, 30);
            this.txtgetUsername.TabIndex = 36;
            this.txtgetUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLetterNumber_KeyPress);
            // 
            // rbtngetGenderFemale
            // 
            this.rbtngetGenderFemale.AutoSize = true;
            this.rbtngetGenderFemale.Enabled = false;
            this.rbtngetGenderFemale.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.rbtngetGenderFemale.Location = new System.Drawing.Point(159, 280);
            this.rbtngetGenderFemale.Name = "rbtngetGenderFemale";
            this.rbtngetGenderFemale.Size = new System.Drawing.Size(87, 23);
            this.rbtngetGenderFemale.TabIndex = 35;
            this.rbtngetGenderFemale.TabStop = true;
            this.rbtngetGenderFemale.Text = "Female";
            this.rbtngetGenderFemale.UseVisualStyleBackColor = true;
            // 
            // rbtngetGenderMale
            // 
            this.rbtngetGenderMale.AutoSize = true;
            this.rbtngetGenderMale.Enabled = false;
            this.rbtngetGenderMale.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.rbtngetGenderMale.Location = new System.Drawing.Point(159, 260);
            this.rbtngetGenderMale.Name = "rbtngetGenderMale";
            this.rbtngetGenderMale.Size = new System.Drawing.Size(67, 23);
            this.rbtngetGenderMale.TabIndex = 34;
            this.rbtngetGenderMale.TabStop = true;
            this.rbtngetGenderMale.Text = "Male";
            this.rbtngetGenderMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label10.Location = new System.Drawing.Point(74, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label8.Location = new System.Drawing.Point(54, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Birthday:";
            // 
            // lblgetStaffID
            // 
            this.lblgetStaffID.AutoSize = true;
            this.lblgetStaffID.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgetStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lblgetStaffID.Location = new System.Drawing.Point(155, 60);
            this.lblgetStaffID.Name = "lblgetStaffID";
            this.lblgetStaffID.Size = new System.Drawing.Size(0, 19);
            this.lblgetStaffID.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(54, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Staff ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(44, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Last Name:";
            // 
            // txtgetLastName
            // 
            this.txtgetLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.txtgetLastName.Enabled = false;
            this.txtgetLastName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.txtgetLastName.Location = new System.Drawing.Point(159, 180);
            this.txtgetLastName.MaxLength = 10;
            this.txtgetLastName.Name = "txtgetLastName";
            this.txtgetLastName.Size = new System.Drawing.Size(114, 30);
            this.txtgetLastName.TabIndex = 26;
            this.txtgetLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLetter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(24, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Middle Name:";
            // 
            // txtgetMiddleName
            // 
            this.txtgetMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.txtgetMiddleName.Enabled = false;
            this.txtgetMiddleName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.txtgetMiddleName.Location = new System.Drawing.Point(159, 140);
            this.txtgetMiddleName.MaxLength = 10;
            this.txtgetMiddleName.Name = "txtgetMiddleName";
            this.txtgetMiddleName.Size = new System.Drawing.Size(114, 30);
            this.txtgetMiddleName.TabIndex = 24;
            this.txtgetMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLetter_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "First Name:";
            // 
            // txtgetFirstName
            // 
            this.txtgetFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.txtgetFirstName.Enabled = false;
            this.txtgetFirstName.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F);
            this.txtgetFirstName.Location = new System.Drawing.Point(159, 100);
            this.txtgetFirstName.MaxLength = 10;
            this.txtgetFirstName.Name = "txtgetFirstName";
            this.txtgetFirstName.Size = new System.Drawing.Size(114, 30);
            this.txtgetFirstName.TabIndex = 21;
            this.txtgetFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxLetter_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(43, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Staff Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.btnDeleteStaff);
            this.panel1.Controls.Add(this.btnUpdateStaff);
            this.panel1.Controls.Add(this.btnAddStaff);
            this.panel1.Location = new System.Drawing.Point(547, 571);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 158);
            this.panel1.TabIndex = 36;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btnDeleteStaff.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btnDeleteStaff.Location = new System.Drawing.Point(60, 100);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(235, 36);
            this.btnDeleteStaff.TabIndex = 40;
            this.btnDeleteStaff.Text = "Delete Staff";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnSetButtonAction_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btnUpdateStaff.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btnUpdateStaff.Location = new System.Drawing.Point(60, 60);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(235, 36);
            this.btnUpdateStaff.TabIndex = 39;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnSetButtonAction_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btnAddStaff.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btnAddStaff.Location = new System.Drawing.Point(60, 20);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(235, 36);
            this.btnAddStaff.TabIndex = 38;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnSetButtonAction_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.btnExitform);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 30);
            this.panel2.TabIndex = 37;
            // 
            // btnExitform
            // 
            this.btnExitform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.btnExitform.FlatAppearance.BorderSize = 0;
            this.btnExitform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitform.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitform.Location = new System.Drawing.Point(858, 0);
            this.btnExitform.Name = "btnExitform";
            this.btnExitform.Size = new System.Drawing.Size(37, 30);
            this.btnExitform.TabIndex = 5;
            this.btnExitform.Text = "X";
            this.btnExitform.UseVisualStyleBackColor = false;
            this.btnExitform.Click += new System.EventHandler(this.btnExitform_Click);
            // 
            // AdminSession5_Manage_Staffs_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(894, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvStafflist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSession5_Manage_Staffs_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSession5_Manage_Staffs_";
            this.Load += new System.EventHandler(this.AdminSession5_Manage_Staffs__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStafflist)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxShowpassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStafflist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgetFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgetMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgetLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblgetStaffID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbtngetGenderMale;
        private System.Windows.Forms.RadioButton rbtngetGenderFemale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtgetPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgetUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExitform;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btngetAction;
        private System.Windows.Forms.DateTimePicker dtpgetBirthday;
        private System.Windows.Forms.PictureBox pctBoxShowpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblgetAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer_CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer_MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer_LastName;
    }
}