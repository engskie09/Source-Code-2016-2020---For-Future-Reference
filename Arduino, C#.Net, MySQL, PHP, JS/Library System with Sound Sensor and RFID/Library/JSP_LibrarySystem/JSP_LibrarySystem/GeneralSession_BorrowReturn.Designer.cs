namespace JSP_LibrarySystem
{
    partial class GeneralSession_BorrowReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralSession_BorrowReturn));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_Borrow = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_getBookCondition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_getReturnCondition = new System.Windows.Forms.TextBox();
            this.lbl_setStudentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_setStudentMiddleName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_setStudentAdviser = new System.Windows.Forms.Label();
            this.lbl_setStudentSection = new System.Windows.Forms.Label();
            this.lbl_setStudentFirstName = new System.Windows.Forms.Label();
            this.lbl_setStudentLastName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_StudentList = new System.Windows.Forms.DataGridView();
            this.clm_StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_StudentFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_StudentMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_StudentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_StudentYearLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_StudentSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_StudentAdviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_BorrowBook = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_BorrowingList = new System.Windows.Forms.DataGridView();
            this.clm_BorrowBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowBookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BookList = new System.Windows.Forms.DataGridView();
            this.clm_BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BookCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BookTotalCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Return = new System.Windows.Forms.TabPage();
            this.dgv_BorrowList = new System.Windows.Forms.DataGridView();
            this.clm_BookBorrowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BookCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BookBorrowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowerFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowerMiddlename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowerLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_BorrowedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_ReturnCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_bookAssignedStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tb_Borrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookList)).BeginInit();
            this.tb_Return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_Borrow);
            this.tabControl1.Controls.Add(this.tb_Return);
            this.tabControl1.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.tabControl1.Location = new System.Drawing.Point(59, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1250, 600);
            this.tabControl1.TabIndex = 2;
            // 
            // tb_Borrow
            // 
            this.tb_Borrow.BackColor = System.Drawing.Color.Transparent;
            this.tb_Borrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_Borrow.BackgroundImage")));
            this.tb_Borrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_Borrow.Controls.Add(this.label3);
            this.tb_Borrow.Controls.Add(this.cmb_getBookCondition);
            this.tb_Borrow.Controls.Add(this.label1);
            this.tb_Borrow.Controls.Add(this.txt_getReturnCondition);
            this.tb_Borrow.Controls.Add(this.lbl_setStudentID);
            this.tb_Borrow.Controls.Add(this.label4);
            this.tb_Borrow.Controls.Add(this.lbl_setStudentMiddleName);
            this.tb_Borrow.Controls.Add(this.label2);
            this.tb_Borrow.Controls.Add(this.textBox9);
            this.tb_Borrow.Controls.Add(this.label13);
            this.tb_Borrow.Controls.Add(this.lbl_setStudentAdviser);
            this.tb_Borrow.Controls.Add(this.lbl_setStudentSection);
            this.tb_Borrow.Controls.Add(this.lbl_setStudentFirstName);
            this.tb_Borrow.Controls.Add(this.lbl_setStudentLastName);
            this.tb_Borrow.Controls.Add(this.label8);
            this.tb_Borrow.Controls.Add(this.label7);
            this.tb_Borrow.Controls.Add(this.label6);
            this.tb_Borrow.Controls.Add(this.label5);
            this.tb_Borrow.Controls.Add(this.dgv_StudentList);
            this.tb_Borrow.Controls.Add(this.btn_BorrowBook);
            this.tb_Borrow.Controls.Add(this.textBox1);
            this.tb_Borrow.Controls.Add(this.label9);
            this.tb_Borrow.Controls.Add(this.dgv_BorrowingList);
            this.tb_Borrow.Controls.Add(this.dgv_BookList);
            this.tb_Borrow.Location = new System.Drawing.Point(4, 28);
            this.tb_Borrow.Name = "tb_Borrow";
            this.tb_Borrow.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Borrow.Size = new System.Drawing.Size(1242, 568);
            this.tb_Borrow.TabIndex = 0;
            this.tb_Borrow.Text = "BORROW";
            this.tb_Borrow.Click += new System.EventHandler(this.tb_Borrow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Book Condition:";
            // 
            // cmb_getBookCondition
            // 
            this.cmb_getBookCondition.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_getBookCondition.FormattingEnabled = true;
            this.cmb_getBookCondition.Items.AddRange(new object[] {
            "Old",
            "New",
            "Fine"});
            this.cmb_getBookCondition.Location = new System.Drawing.Point(392, 6);
            this.cmb_getBookCondition.Name = "cmb_getBookCondition";
            this.cmb_getBookCondition.Size = new System.Drawing.Size(98, 27);
            this.cmb_getBookCondition.TabIndex = 56;
            this.cmb_getBookCondition.SelectedIndexChanged += new System.EventHandler(this.cmb_getBookCondition_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Conditions of Returning:";
            // 
            // txt_getReturnCondition
            // 
            this.txt_getReturnCondition.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_getReturnCondition.Location = new System.Drawing.Point(356, 69);
            this.txt_getReturnCondition.Multiline = true;
            this.txt_getReturnCondition.Name = "txt_getReturnCondition";
            this.txt_getReturnCondition.Size = new System.Drawing.Size(94, 56);
            this.txt_getReturnCondition.TabIndex = 54;
            // 
            // lbl_setStudentID
            // 
            this.lbl_setStudentID.AutoSize = true;
            this.lbl_setStudentID.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setStudentID.Location = new System.Drawing.Point(133, 132);
            this.lbl_setStudentID.Name = "lbl_setStudentID";
            this.lbl_setStudentID.Size = new System.Drawing.Size(34, 19);
            this.lbl_setStudentID.TabIndex = 53;
            this.lbl_setStudentID.Text = "-----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Student ID:";
            // 
            // lbl_setStudentMiddleName
            // 
            this.lbl_setStudentMiddleName.AutoSize = true;
            this.lbl_setStudentMiddleName.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setStudentMiddleName.Location = new System.Drawing.Point(133, 90);
            this.lbl_setStudentMiddleName.Name = "lbl_setStudentMiddleName";
            this.lbl_setStudentMiddleName.Size = new System.Drawing.Size(34, 19);
            this.lbl_setStudentMiddleName.TabIndex = 51;
            this.lbl_setStudentMiddleName.Text = "-----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "MIddle Name:";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(152, 249);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(272, 27);
            this.textBox9.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(68, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 19);
            this.label13.TabIndex = 48;
            this.label13.Text = "Search:";
            // 
            // lbl_setStudentAdviser
            // 
            this.lbl_setStudentAdviser.AutoSize = true;
            this.lbl_setStudentAdviser.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setStudentAdviser.Location = new System.Drawing.Point(133, 178);
            this.lbl_setStudentAdviser.Name = "lbl_setStudentAdviser";
            this.lbl_setStudentAdviser.Size = new System.Drawing.Size(34, 19);
            this.lbl_setStudentAdviser.TabIndex = 47;
            this.lbl_setStudentAdviser.Text = "-----";
            // 
            // lbl_setStudentSection
            // 
            this.lbl_setStudentSection.AutoSize = true;
            this.lbl_setStudentSection.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setStudentSection.Location = new System.Drawing.Point(133, 156);
            this.lbl_setStudentSection.Name = "lbl_setStudentSection";
            this.lbl_setStudentSection.Size = new System.Drawing.Size(34, 19);
            this.lbl_setStudentSection.TabIndex = 46;
            this.lbl_setStudentSection.Text = "-----";
            // 
            // lbl_setStudentFirstName
            // 
            this.lbl_setStudentFirstName.AutoSize = true;
            this.lbl_setStudentFirstName.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setStudentFirstName.Location = new System.Drawing.Point(133, 71);
            this.lbl_setStudentFirstName.Name = "lbl_setStudentFirstName";
            this.lbl_setStudentFirstName.Size = new System.Drawing.Size(34, 19);
            this.lbl_setStudentFirstName.TabIndex = 45;
            this.lbl_setStudentFirstName.Text = "-----";
            // 
            // lbl_setStudentLastName
            // 
            this.lbl_setStudentLastName.AutoSize = true;
            this.lbl_setStudentLastName.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_setStudentLastName.Location = new System.Drawing.Point(133, 108);
            this.lbl_setStudentLastName.Name = "lbl_setStudentLastName";
            this.lbl_setStudentLastName.Size = new System.Drawing.Size(34, 19);
            this.lbl_setStudentLastName.TabIndex = 44;
            this.lbl_setStudentLastName.Text = "-----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "Adviser:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Section:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Last Name:";
            // 
            // dgv_StudentList
            // 
            this.dgv_StudentList.AllowUserToAddRows = false;
            this.dgv_StudentList.AllowUserToDeleteRows = false;
            this.dgv_StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_StudentID,
            this.clm_StudentFirstName,
            this.clm_StudentMiddleName,
            this.clm_StudentLastName,
            this.clm_StudentYearLevel,
            this.clm_StudentSection,
            this.clm_StudentAdviser});
            this.dgv_StudentList.Location = new System.Drawing.Point(465, 108);
            this.dgv_StudentList.Name = "dgv_StudentList";
            this.dgv_StudentList.ReadOnly = true;
            this.dgv_StudentList.Size = new System.Drawing.Size(737, 168);
            this.dgv_StudentList.TabIndex = 33;
            this.dgv_StudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StudentList_CellContentClick);
            // 
            // clm_StudentID
            // 
            this.clm_StudentID.Frozen = true;
            this.clm_StudentID.HeaderText = "Student ID";
            this.clm_StudentID.Name = "clm_StudentID";
            this.clm_StudentID.ReadOnly = true;
            // 
            // clm_StudentFirstName
            // 
            this.clm_StudentFirstName.Frozen = true;
            this.clm_StudentFirstName.HeaderText = "First Name";
            this.clm_StudentFirstName.Name = "clm_StudentFirstName";
            this.clm_StudentFirstName.ReadOnly = true;
            // 
            // clm_StudentMiddleName
            // 
            this.clm_StudentMiddleName.Frozen = true;
            this.clm_StudentMiddleName.HeaderText = "Middle Name";
            this.clm_StudentMiddleName.Name = "clm_StudentMiddleName";
            this.clm_StudentMiddleName.ReadOnly = true;
            // 
            // clm_StudentLastName
            // 
            this.clm_StudentLastName.Frozen = true;
            this.clm_StudentLastName.HeaderText = "Last Name";
            this.clm_StudentLastName.Name = "clm_StudentLastName";
            this.clm_StudentLastName.ReadOnly = true;
            // 
            // clm_StudentYearLevel
            // 
            this.clm_StudentYearLevel.Frozen = true;
            this.clm_StudentYearLevel.HeaderText = "Year Level";
            this.clm_StudentYearLevel.Name = "clm_StudentYearLevel";
            this.clm_StudentYearLevel.ReadOnly = true;
            // 
            // clm_StudentSection
            // 
            this.clm_StudentSection.Frozen = true;
            this.clm_StudentSection.HeaderText = "Section";
            this.clm_StudentSection.Name = "clm_StudentSection";
            this.clm_StudentSection.ReadOnly = true;
            // 
            // clm_StudentAdviser
            // 
            this.clm_StudentAdviser.Frozen = true;
            this.clm_StudentAdviser.HeaderText = "Adviser";
            this.clm_StudentAdviser.Name = "clm_StudentAdviser";
            this.clm_StudentAdviser.ReadOnly = true;
            // 
            // btn_BorrowBook
            // 
            this.btn_BorrowBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BorrowBook.BackgroundImage")));
            this.btn_BorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrowBook.ForeColor = System.Drawing.Color.White;
            this.btn_BorrowBook.Location = new System.Drawing.Point(353, 131);
            this.btn_BorrowBook.Name = "btn_BorrowBook";
            this.btn_BorrowBook.Size = new System.Drawing.Size(100, 50);
            this.btn_BorrowBook.TabIndex = 28;
            this.btn_BorrowBook.Text = "Borrow";
            this.btn_BorrowBook.UseVisualStyleBackColor = true;
            this.btn_BorrowBook.Click += new System.EventHandler(this.btn_BorrowBook_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(750, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 27);
            this.textBox1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(687, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Search:";
            // 
            // dgv_BorrowingList
            // 
            this.dgv_BorrowingList.AllowUserToAddRows = false;
            this.dgv_BorrowingList.AllowUserToDeleteRows = false;
            this.dgv_BorrowingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BorrowingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_BorrowBookID,
            this.clm_BorrowBookTitle,
            this.clm_BorrowBookQuantity});
            this.dgv_BorrowingList.Location = new System.Drawing.Point(618, 295);
            this.dgv_BorrowingList.Name = "dgv_BorrowingList";
            this.dgv_BorrowingList.ReadOnly = true;
            this.dgv_BorrowingList.Size = new System.Drawing.Size(486, 214);
            this.dgv_BorrowingList.TabIndex = 16;
            this.dgv_BorrowingList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BorrowList_CellContentDoubleClick);
            // 
            // clm_BorrowBookID
            // 
            this.clm_BorrowBookID.Frozen = true;
            this.clm_BorrowBookID.HeaderText = "Book ID";
            this.clm_BorrowBookID.Name = "clm_BorrowBookID";
            this.clm_BorrowBookID.ReadOnly = true;
            // 
            // clm_BorrowBookTitle
            // 
            this.clm_BorrowBookTitle.Frozen = true;
            this.clm_BorrowBookTitle.HeaderText = "Book Title";
            this.clm_BorrowBookTitle.Name = "clm_BorrowBookTitle";
            this.clm_BorrowBookTitle.ReadOnly = true;
            // 
            // clm_BorrowBookQuantity
            // 
            this.clm_BorrowBookQuantity.Frozen = true;
            this.clm_BorrowBookQuantity.HeaderText = "Book Quantity";
            this.clm_BorrowBookQuantity.Name = "clm_BorrowBookQuantity";
            this.clm_BorrowBookQuantity.ReadOnly = true;
            // 
            // dgv_BookList
            // 
            this.dgv_BookList.AllowUserToAddRows = false;
            this.dgv_BookList.AllowUserToDeleteRows = false;
            this.dgv_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_BookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_BookID,
            this.clm_BookTitle,
            this.clm_BookCategory,
            this.clm_BookTotalCopies});
            this.dgv_BookList.Location = new System.Drawing.Point(47, 295);
            this.dgv_BookList.Name = "dgv_BookList";
            this.dgv_BookList.ReadOnly = true;
            this.dgv_BookList.Size = new System.Drawing.Size(443, 250);
            this.dgv_BookList.TabIndex = 0;
            this.dgv_BookList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BookList_CellContentDoubleClick);
            // 
            // clm_BookID
            // 
            this.clm_BookID.Frozen = true;
            this.clm_BookID.HeaderText = "ID";
            this.clm_BookID.Name = "clm_BookID";
            this.clm_BookID.ReadOnly = true;
            // 
            // clm_BookTitle
            // 
            this.clm_BookTitle.Frozen = true;
            this.clm_BookTitle.HeaderText = "Title";
            this.clm_BookTitle.Name = "clm_BookTitle";
            this.clm_BookTitle.ReadOnly = true;
            // 
            // clm_BookCategory
            // 
            this.clm_BookCategory.Frozen = true;
            this.clm_BookCategory.HeaderText = "Category";
            this.clm_BookCategory.Name = "clm_BookCategory";
            this.clm_BookCategory.ReadOnly = true;
            // 
            // clm_BookTotalCopies
            // 
            this.clm_BookTotalCopies.Frozen = true;
            this.clm_BookTotalCopies.HeaderText = "Total Copies";
            this.clm_BookTotalCopies.Name = "clm_BookTotalCopies";
            this.clm_BookTotalCopies.ReadOnly = true;
            // 
            // tb_Return
            // 
            this.tb_Return.BackColor = System.Drawing.Color.Transparent;
            this.tb_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb_Return.BackgroundImage")));
            this.tb_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tb_Return.Controls.Add(this.dgv_BorrowList);
            this.tb_Return.Location = new System.Drawing.Point(4, 28);
            this.tb_Return.Name = "tb_Return";
            this.tb_Return.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Return.Size = new System.Drawing.Size(1242, 568);
            this.tb_Return.TabIndex = 1;
            this.tb_Return.Text = "RETURN";
            // 
            // dgv_BorrowList
            // 
            this.dgv_BorrowList.AllowUserToAddRows = false;
            this.dgv_BorrowList.AllowUserToDeleteRows = false;
            this.dgv_BorrowList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BorrowList.ColumnHeadersHeight = 50;
            this.dgv_BorrowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_BookBorrowID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.clm_BookCondition,
            this.clm_BookBorrowerID,
            this.clm_BorrowerFirstname,
            this.clm_BorrowerMiddlename,
            this.clm_BorrowerLastname,
            this.clm_BorrowedDate,
            this.clm_ReturnDate,
            this.clm_ReturnCondition,
            this.clm_bookAssignedStaff});
            this.dgv_BorrowList.Location = new System.Drawing.Point(52, 53);
            this.dgv_BorrowList.Name = "dgv_BorrowList";
            this.dgv_BorrowList.ReadOnly = true;
            this.dgv_BorrowList.Size = new System.Drawing.Size(1135, 433);
            this.dgv_BorrowList.TabIndex = 17;
            this.dgv_BorrowList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BorrowList_CellContentDoubleClick_1);
            // 
            // clm_BookBorrowID
            // 
            this.clm_BookBorrowID.HeaderText = "Borrow ID";
            this.clm_BookBorrowID.Name = "clm_BookBorrowID";
            this.clm_BookBorrowID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Book ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Book Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // clm_BookCondition
            // 
            this.clm_BookCondition.HeaderText = "Book Condition";
            this.clm_BookCondition.Name = "clm_BookCondition";
            this.clm_BookCondition.ReadOnly = true;
            // 
            // clm_BookBorrowerID
            // 
            this.clm_BookBorrowerID.HeaderText = "Borrower ID";
            this.clm_BookBorrowerID.Name = "clm_BookBorrowerID";
            this.clm_BookBorrowerID.ReadOnly = true;
            // 
            // clm_BorrowerFirstname
            // 
            this.clm_BorrowerFirstname.HeaderText = "First Name";
            this.clm_BorrowerFirstname.Name = "clm_BorrowerFirstname";
            this.clm_BorrowerFirstname.ReadOnly = true;
            // 
            // clm_BorrowerMiddlename
            // 
            this.clm_BorrowerMiddlename.HeaderText = "Middle Name";
            this.clm_BorrowerMiddlename.Name = "clm_BorrowerMiddlename";
            this.clm_BorrowerMiddlename.ReadOnly = true;
            // 
            // clm_BorrowerLastname
            // 
            this.clm_BorrowerLastname.HeaderText = "Last Name";
            this.clm_BorrowerLastname.Name = "clm_BorrowerLastname";
            this.clm_BorrowerLastname.ReadOnly = true;
            // 
            // clm_BorrowedDate
            // 
            this.clm_BorrowedDate.HeaderText = "Borrowed Date";
            this.clm_BorrowedDate.Name = "clm_BorrowedDate";
            this.clm_BorrowedDate.ReadOnly = true;
            // 
            // clm_ReturnDate
            // 
            this.clm_ReturnDate.HeaderText = "Return Date";
            this.clm_ReturnDate.Name = "clm_ReturnDate";
            this.clm_ReturnDate.ReadOnly = true;
            // 
            // clm_ReturnCondition
            // 
            this.clm_ReturnCondition.HeaderText = "Return Condition";
            this.clm_ReturnCondition.Name = "clm_ReturnCondition";
            this.clm_ReturnCondition.ReadOnly = true;
            // 
            // clm_bookAssignedStaff
            // 
            this.clm_bookAssignedStaff.HeaderText = "Assigned Staff";
            this.clm_bookAssignedStaff.Name = "clm_bookAssignedStaff";
            this.clm_bookAssignedStaff.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(32, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 37;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1233, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1274, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 43;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.label10.Font = new System.Drawing.Font("Myriad Pro", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 32);
            this.label10.TabIndex = 45;
            this.label10.Text = "              Transactions     ";
            // 
            // GeneralSession_BorrowReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 750);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSession_BorrowReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralSession_BorrowReturn";
            this.Load += new System.EventHandler(this.GeneralSession_BorrowReturn_Load);
            this.tabControl1.ResumeLayout(false);
            this.tb_Borrow.ResumeLayout(false);
            this.tb_Borrow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookList)).EndInit();
            this.tb_Return.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BorrowList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_Borrow;
        private System.Windows.Forms.Label lbl_setStudentFirstName;
        private System.Windows.Forms.Label lbl_setStudentLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_StudentList;
        private System.Windows.Forms.Button btn_BorrowBook;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_BorrowingList;
        private System.Windows.Forms.DataGridView dgv_BookList;
        private System.Windows.Forms.TabPage tb_Return;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BookCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BookTotalCopies;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowBookQuantity;
        private System.Windows.Forms.Label lbl_setStudentAdviser;
        private System.Windows.Forms.Label lbl_setStudentSection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_setStudentMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_setStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StudentFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StudentMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StudentLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StudentYearLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StudentSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_StudentAdviser;
        private System.Windows.Forms.DataGridView dgv_BorrowList;
        private System.Windows.Forms.TextBox txt_getReturnCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_getBookCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BookBorrowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BookCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BookBorrowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowerFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowerMiddlename;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowerLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_BorrowedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_ReturnCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_bookAssignedStaff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
    }
}