namespace Library_Attendance
{
    partial class OTHERFORM
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
            this.setTimer = new System.Windows.Forms.Timer(this.components);
            this.pctboxGetStudentPicture = new System.Windows.Forms.PictureBox();
            this.txtGetstudentcardID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxGetStudentPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(112)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tap your ID";
            // 
            // pctboxGetStudentPicture
            // 
            this.pctboxGetStudentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctboxGetStudentPicture.Location = new System.Drawing.Point(164, 66);
            this.pctboxGetStudentPicture.Name = "pctboxGetStudentPicture";
            this.pctboxGetStudentPicture.Size = new System.Drawing.Size(439, 320);
            this.pctboxGetStudentPicture.TabIndex = 7;
            this.pctboxGetStudentPicture.TabStop = false;
            this.pctboxGetStudentPicture.Visible = false;
            // 
            // txtGetstudentcardID
            // 
            this.txtGetstudentcardID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
            this.txtGetstudentcardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetstudentcardID.Location = new System.Drawing.Point(191, 201);
            this.txtGetstudentcardID.Name = "txtGetstudentcardID";
            this.txtGetstudentcardID.PasswordChar = '*';
            this.txtGetstudentcardID.Size = new System.Drawing.Size(292, 62);
            this.txtGetstudentcardID.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Library_Attendance.Properties.Resources.tapID;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(86, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(439, 320);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "YOU ARE BEEN LOGOUT";
            // 
            // OTHERFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(224)))), ((int)(((byte)(167)))));
            this.ClientSize = new System.Drawing.Size(582, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctboxGetStudentPicture);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtGetstudentcardID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OTHERFORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OTHERFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxGetStudentPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer setTimer;
        private System.Windows.Forms.PictureBox pctboxGetStudentPicture;
        private System.Windows.Forms.TextBox txtGetstudentcardID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;

    }
}