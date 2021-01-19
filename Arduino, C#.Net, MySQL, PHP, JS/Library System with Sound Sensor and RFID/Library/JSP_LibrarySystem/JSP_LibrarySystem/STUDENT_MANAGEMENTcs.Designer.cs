namespace JSP_LibrarySystem
{
    partial class STUDENT_MANAGEMENTcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STUDENT_MANAGEMENTcs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StuNumber = new System.Windows.Forms.Label();
            this.Mname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbYearLvl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Section = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StuAdviser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StuAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CpNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.Search = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.stucardID = new System.Windows.Forms.TextBox();
            this.student_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_cardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_middlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_yearlevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_adviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_CPnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_picture = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.student_id,
            this.student_cardid,
            this.student_firstname,
            this.student_middlename,
            this.student_lastname,
            this.student_gender,
            this.student_yearlevel,
            this.student_section,
            this.student_adviser,
            this.student_address,
            this.student_CPnumber,
            this.student_picture});
            this.dataGridView1.Location = new System.Drawing.Point(36, 429);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 90;
            this.dataGridView1.Size = new System.Drawing.Size(1291, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(492, 226);
            this.Fname.Margin = new System.Windows.Forms.Padding(4);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(249, 27);
            this.Fname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Card ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StuNumber
            // 
            this.StuNumber.AutoSize = true;
            this.StuNumber.BackColor = System.Drawing.Color.Transparent;
            this.StuNumber.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuNumber.Location = new System.Drawing.Point(492, 169);
            this.StuNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StuNumber.Name = "StuNumber";
            this.StuNumber.Size = new System.Drawing.Size(29, 19);
            this.StuNumber.TabIndex = 7;
            this.StuNumber.Text = "----";
            this.StuNumber.Click += new System.EventHandler(this.StuNumber_Click);
            // 
            // Mname
            // 
            this.Mname.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mname.Location = new System.Drawing.Point(492, 260);
            this.Mname.Margin = new System.Windows.Forms.Padding(4);
            this.Mname.Name = "Mname";
            this.Mname.Size = new System.Drawing.Size(249, 27);
            this.Mname.TabIndex = 10;
            this.Mname.TextChanged += new System.EventHandler(this.Mname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Middle Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(492, 296);
            this.Lname.Margin = new System.Windows.Forms.Padding(4);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(249, 27);
            this.Lname.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Last Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(835, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gender:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(904, 196);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(115, 27);
            this.cbGender.TabIndex = 14;
            // 
            // cbYearLvl
            // 
            this.cbYearLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYearLvl.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYearLvl.FormattingEnabled = true;
            this.cbYearLvl.Items.AddRange(new object[] {
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10"});
            this.cbYearLvl.Location = new System.Drawing.Point(904, 231);
            this.cbYearLvl.Margin = new System.Windows.Forms.Padding(4);
            this.cbYearLvl.Name = "cbYearLvl";
            this.cbYearLvl.Size = new System.Drawing.Size(180, 27);
            this.cbYearLvl.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(819, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Year Level";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Section
            // 
            this.Section.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.Location = new System.Drawing.Point(904, 266);
            this.Section.Margin = new System.Windows.Forms.Padding(4);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(180, 27);
            this.Section.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(837, 269);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Section";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // StuAdviser
            // 
            this.StuAdviser.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuAdviser.Location = new System.Drawing.Point(904, 301);
            this.StuAdviser.Margin = new System.Windows.Forms.Padding(4);
            this.StuAdviser.Name = "StuAdviser";
            this.StuAdviser.Size = new System.Drawing.Size(180, 27);
            this.StuAdviser.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(781, 304);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Student Adviser";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // StuAddress
            // 
            this.StuAddress.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StuAddress.Location = new System.Drawing.Point(492, 347);
            this.StuAddress.Margin = new System.Windows.Forms.Padding(4);
            this.StuAddress.Name = "StuAddress";
            this.StuAddress.Size = new System.Drawing.Size(592, 27);
            this.StuAddress.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 350);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Student Address:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // CpNumber
            // 
            this.CpNumber.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpNumber.Location = new System.Drawing.Point(904, 161);
            this.CpNumber.Margin = new System.Windows.Forms.Padding(4);
            this.CpNumber.Name = "CpNumber";
            this.CpNumber.Size = new System.Drawing.Size(180, 27);
            this.CpNumber.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(701, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Student Cellphone Number:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Browse
            // 
            this.Browse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Browse.BackgroundImage")));
            this.Browse.ForeColor = System.Drawing.Color.White;
            this.Browse.Location = new System.Drawing.Point(80, 373);
            this.Browse.Margin = new System.Windows.Forms.Padding(4);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(100, 50);
            this.Browse.TabIndex = 28;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Add
            // 
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(1153, 184);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 50);
            this.Add.TabIndex = 29;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Update
            // 
            this.Update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Update.BackgroundImage")));
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Location = new System.Drawing.Point(1153, 242);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(100, 50);
            this.Update.TabIndex = 30;
            this.Update.Text = "UPDATE";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DELETE.BackgroundImage")));
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.ForeColor = System.Drawing.Color.White;
            this.DELETE.Location = new System.Drawing.Point(1153, 300);
            this.DELETE.Margin = new System.Windows.Forms.Padding(4);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(100, 50);
            this.DELETE.TabIndex = 31;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "STUDENT NUMBER",
            "STUDENT CARD ID",
            "FIRST NAME",
            "MIDDLE NAME",
            "LAST NAME",
            "GENDER",
            "YEAR LEVEL",
            "SECTION",
            "ADVISER",
            "ADDRESS",
            "CELLPHONE NUMBER"});
            this.cbSearch.Location = new System.Drawing.Point(550, 385);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(160, 27);
            this.cbSearch.TabIndex = 32;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(719, 385);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(239, 27);
            this.Search.TabIndex = 33;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(57, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 39;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(185, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 40;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-277, -22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 295);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(398, 31);
            this.label12.TabIndex = 42;
            this.label12.Text = "             Student Management     ";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1234, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 48;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(1275, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 47;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1153, 358);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 50);
            this.button5.TabIndex = 49;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(485, 389);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 19);
            this.label13.TabIndex = 50;
            this.label13.Text = "Search:";
            // 
            // stucardID
            // 
            this.stucardID.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stucardID.Location = new System.Drawing.Point(492, 196);
            this.stucardID.Margin = new System.Windows.Forms.Padding(4);
            this.stucardID.Name = "stucardID";
            this.stucardID.Size = new System.Drawing.Size(249, 27);
            this.stucardID.TabIndex = 51;
            // 
            // student_id
            // 
            this.student_id.HeaderText = "student_id";
            this.student_id.MinimumWidth = 100;
            this.student_id.Name = "student_id";
            this.student_id.ReadOnly = true;
            this.student_id.Width = 150;
            // 
            // student_cardid
            // 
            this.student_cardid.HeaderText = "student_cardid";
            this.student_cardid.Name = "student_cardid";
            this.student_cardid.ReadOnly = true;
            // 
            // student_firstname
            // 
            this.student_firstname.HeaderText = "student_firstname";
            this.student_firstname.Name = "student_firstname";
            this.student_firstname.ReadOnly = true;
            // 
            // student_middlename
            // 
            this.student_middlename.HeaderText = "student_middlename";
            this.student_middlename.Name = "student_middlename";
            this.student_middlename.ReadOnly = true;
            // 
            // student_lastname
            // 
            this.student_lastname.HeaderText = "student_lastname";
            this.student_lastname.Name = "student_lastname";
            this.student_lastname.ReadOnly = true;
            // 
            // student_gender
            // 
            this.student_gender.HeaderText = "student_gender";
            this.student_gender.Name = "student_gender";
            this.student_gender.ReadOnly = true;
            // 
            // student_yearlevel
            // 
            this.student_yearlevel.HeaderText = "student_yearlevel";
            this.student_yearlevel.Name = "student_yearlevel";
            this.student_yearlevel.ReadOnly = true;
            // 
            // student_section
            // 
            this.student_section.HeaderText = "student_section";
            this.student_section.Name = "student_section";
            this.student_section.ReadOnly = true;
            // 
            // student_adviser
            // 
            this.student_adviser.HeaderText = "student_adviser";
            this.student_adviser.Name = "student_adviser";
            this.student_adviser.ReadOnly = true;
            // 
            // student_address
            // 
            this.student_address.HeaderText = "student_address";
            this.student_address.Name = "student_address";
            this.student_address.ReadOnly = true;
            // 
            // student_CPnumber
            // 
            this.student_CPnumber.HeaderText = "student_CPnumber";
            this.student_CPnumber.Name = "student_CPnumber";
            this.student_CPnumber.ReadOnly = true;
            // 
            // student_picture
            // 
            this.student_picture.HeaderText = "student_picture";
            this.student_picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.student_picture.Name = "student_picture";
            this.student_picture.ReadOnly = true;
            this.student_picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.student_picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // STUDENT_MANAGEMENTcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 663);
            this.Controls.Add(this.stucardID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CpNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.StuAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.StuAdviser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbYearLvl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Mname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StuNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "STUDENT_MANAGEMENTcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT_MANAGEMENTcs";
            this.Load += new System.EventHandler(this.STUDENT_MANAGEMENTcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StuNumber;
        private System.Windows.Forms.TextBox Mname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbYearLvl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Section;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StuAdviser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StuAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CpNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox stucardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_cardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_middlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_yearlevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_section;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_adviser;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_CPnumber;
        private System.Windows.Forms.DataGridViewImageColumn student_picture;
    }
}