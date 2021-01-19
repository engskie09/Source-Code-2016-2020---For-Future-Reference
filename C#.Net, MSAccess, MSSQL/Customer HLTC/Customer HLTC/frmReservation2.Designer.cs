namespace Customer_HLTC
{
    partial class frmReservation2
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.comboTime = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBusType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPickup = new System.Windows.Forms.TextBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkMyAccount = new System.Windows.Forms.LinkLabel();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.lnkReservation = new System.Windows.Forms.LinkLabel();
            this.lnkHome = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(600, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Landmark Location";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(616, 467);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(194, 28);
            this.btnUpload.TabIndex = 44;
            this.btnUpload.Text = "Upload Photo....";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // comboTime
            // 
            this.comboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTime.FormattingEnabled = true;
            this.comboTime.Items.AddRange(new object[] {
            "12:00 AM",
            "1:00 AM",
            "2:00 AM",
            "3:00 AM",
            "4:00 AM",
            "5:00 AM",
            "6:00 AM",
            "7:00 AM ",
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "2:00 PM\t",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM",
            "10:00 PM",
            "11:00PM"});
            this.comboTime.Location = new System.Drawing.Point(243, 308);
            this.comboTime.Name = "comboTime";
            this.comboTime.Size = new System.Drawing.Size(315, 21);
            this.comboTime.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Time:";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(450, 277);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(105, 20);
            this.dateEnd.TabIndex = 15;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "End Date:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(398, 531);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(122, 39);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mode of Payment:";
            // 
            // comboDestination
            // 
            this.comboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDestination.FormattingEnabled = true;
            this.comboDestination.Location = new System.Drawing.Point(243, 373);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(315, 21);
            this.comboDestination.TabIndex = 9;
            this.comboDestination.SelectedIndexChanged += new System.EventHandler(this.comboDestination_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Destination:";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(243, 277);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(105, 20);
            this.dateStart.TabIndex = 7;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Start Date:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(226, 245);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "try";
            this.lblName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unit Code:";
            this.label4.Visible = false;
            // 
            // lblBusType
            // 
            this.lblBusType.AutoSize = true;
            this.lblBusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusType.Location = new System.Drawing.Point(131, 212);
            this.lblBusType.Name = "lblBusType";
            this.lblBusType.Size = new System.Drawing.Size(83, 20);
            this.lblBusType.TabIndex = 2;
            this.lblBusType.Text = "Bus Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESERVATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "HIGH LEVEL TRANSPORT CORPORATION";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPickup);
            this.panel1.Controls.Add(this.cmbPayment);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.pbProfilePic);
            this.panel1.Controls.Add(this.comboTime);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboDestination);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblBusType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(163, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 645);
            this.panel1.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(230, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 39);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(243, 406);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(315, 20);
            this.txtAddress.TabIndex = 50;
            // 
            // txtPickup
            // 
            this.txtPickup.Location = new System.Drawing.Point(243, 343);
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.Size = new System.Drawing.Size(315, 20);
            this.txtPickup.TabIndex = 49;
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Bank Deposit",
            "Cash"});
            this.cmbPayment.Location = new System.Drawing.Point(290, 440);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(268, 21);
            this.cmbPayment.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(131, 406);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(131, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Pickup:";
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.BackColor = System.Drawing.Color.White;
            this.pbProfilePic.Location = new System.Drawing.Point(604, 257);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(224, 201);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 43;
            this.pbProfilePic.TabStop = false;
            this.pbProfilePic.Click += new System.EventHandler(this.pbProfilePic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Customer_HLTC.Properties.Resources.reservation;
            this.pictureBox1.Location = new System.Drawing.Point(455, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel.Controls.Add(this.linkLogout);
            this.Panel.Controls.Add(this.lnkMyAccount);
            this.Panel.Controls.Add(this.linkLogin);
            this.Panel.Controls.Add(this.linkLabel2);
            this.Panel.Controls.Add(this.linkAbout);
            this.Panel.Controls.Add(this.lnkReservation);
            this.Panel.Controls.Add(this.lnkHome);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.pictureBox3);
            this.Panel.Controls.Add(this.pictureBox2);
            this.Panel.Location = new System.Drawing.Point(-1, 1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1372, 74);
            this.Panel.TabIndex = 4;
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLogout.LinkColor = System.Drawing.Color.White;
            this.linkLogout.Location = new System.Drawing.Point(1281, 30);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(78, 18);
            this.linkLogout.TabIndex = 20;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "LOGOUT";
            this.linkLogout.Visible = false;
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // lnkMyAccount
            // 
            this.lnkMyAccount.AutoSize = true;
            this.lnkMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMyAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lnkMyAccount.LinkColor = System.Drawing.Color.White;
            this.lnkMyAccount.Location = new System.Drawing.Point(750, 30);
            this.lnkMyAccount.Name = "lnkMyAccount";
            this.lnkMyAccount.Size = new System.Drawing.Size(118, 18);
            this.lnkMyAccount.TabIndex = 19;
            this.lnkMyAccount.TabStop = true;
            this.lnkMyAccount.Text = "MY ACCOUNT";
            this.lnkMyAccount.Visible = false;
            this.lnkMyAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMyAccount_LinkClicked);
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLogin.LinkColor = System.Drawing.Color.White;
            this.linkLogin.Location = new System.Drawing.Point(1303, 30);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(59, 18);
            this.linkLogin.TabIndex = 18;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "LOGIN";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(1135, 30);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(115, 18);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "CONTACT US";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAbout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkAbout.LinkColor = System.Drawing.Color.White;
            this.linkAbout.Location = new System.Drawing.Point(1065, 30);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(64, 18);
            this.linkAbout.TabIndex = 16;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "ABOUT";
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // lnkReservation
            // 
            this.lnkReservation.AutoSize = true;
            this.lnkReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkReservation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lnkReservation.LinkColor = System.Drawing.Color.White;
            this.lnkReservation.Location = new System.Drawing.Point(938, 30);
            this.lnkReservation.Name = "lnkReservation";
            this.lnkReservation.Size = new System.Drawing.Size(124, 18);
            this.lnkReservation.TabIndex = 15;
            this.lnkReservation.TabStop = true;
            this.lnkReservation.Text = "RESERVATION";
            this.lnkReservation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReservation_LinkClicked);
            // 
            // lnkHome
            // 
            this.lnkHome.AutoSize = true;
            this.lnkHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lnkHome.LinkColor = System.Drawing.Color.White;
            this.lnkHome.Location = new System.Drawing.Point(874, 30);
            this.lnkHome.Name = "lnkHome";
            this.lnkHome.Size = new System.Drawing.Size(58, 18);
            this.lnkHome.TabIndex = 14;
            this.lnkHome.TabStop = true;
            this.lnkHome.Text = "HOME";
            this.lnkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHome_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Customer_HLTC.Properties.Resources.logo_transparent;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Location = new System.Drawing.Point(137, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(239, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 53;
            // 
            // frmReservation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panel);
            this.Name = "frmReservation2";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.frmReservation2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.ComboBox comboTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBusType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.LinkLabel lnkMyAccount;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.LinkLabel lnkReservation;
        private System.Windows.Forms.LinkLabel lnkHome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPickup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
    }
}