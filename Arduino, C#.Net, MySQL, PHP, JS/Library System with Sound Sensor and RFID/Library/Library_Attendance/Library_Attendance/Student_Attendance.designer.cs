namespace Library_Attendance
{
    partial class Student_Attendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGetstudentcardID = new System.Windows.Forms.TextBox();
            this.setTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pctboxGetStudentPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxGetStudentPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(112)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(109, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tap your ID";
            // 
            // txtGetstudentcardID
            // 
            this.txtGetstudentcardID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
            this.txtGetstudentcardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetstudentcardID.Location = new System.Drawing.Point(171, 195);
            this.txtGetstudentcardID.Name = "txtGetstudentcardID";
            this.txtGetstudentcardID.PasswordChar = '*';
            this.txtGetstudentcardID.Size = new System.Drawing.Size(292, 62);
            this.txtGetstudentcardID.TabIndex = 1;
            this.txtGetstudentcardID.TextChanged += new System.EventHandler(this.txtGetstudentcardID_TextChanged);
            // 
            // setTimer
            // 
            this.setTimer.Tick += new System.EventHandler(this.setTimer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctboxGetStudentPicture
            // 
            this.pctboxGetStudentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctboxGetStudentPicture.Location = new System.Drawing.Point(79, 75);
            this.pctboxGetStudentPicture.Name = "pctboxGetStudentPicture";
            this.pctboxGetStudentPicture.Size = new System.Drawing.Size(439, 320);
            this.pctboxGetStudentPicture.TabIndex = 2;
            this.pctboxGetStudentPicture.TabStop = false;
            this.pctboxGetStudentPicture.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Library_Attendance.Properties.Resources.tapID;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(79, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 320);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Student_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(582, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctboxGetStudentPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGetstudentcardID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Attendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Attendance";
            this.Load += new System.EventHandler(this.Student_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxGetStudentPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctboxGetStudentPicture;
        private System.Windows.Forms.TextBox txtGetstudentcardID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer setTimer;
        private System.Windows.Forms.Button button1;
    }
}