namespace CanteenManager
{
    partial class MonitorQueuing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NWOrder1 = new System.Windows.Forms.Label();
            this.NPOrder1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Now Serving....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(348, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Now Preparing....";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::CanteenManager.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(719, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 229);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // NWOrder1
            // 
            this.NWOrder1.AutoSize = true;
            this.NWOrder1.BackColor = System.Drawing.Color.Transparent;
            this.NWOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NWOrder1.ForeColor = System.Drawing.Color.White;
            this.NWOrder1.Location = new System.Drawing.Point(14, 100);
            this.NWOrder1.Name = "NWOrder1";
            this.NWOrder1.Size = new System.Drawing.Size(70, 25);
            this.NWOrder1.TabIndex = 4;
            this.NWOrder1.Text = "label4";
            this.NWOrder1.Click += new System.EventHandler(this.NWOrder1_Click);
            // 
            // NPOrder1
            // 
            this.NPOrder1.AutoSize = true;
            this.NPOrder1.BackColor = System.Drawing.Color.Transparent;
            this.NPOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NPOrder1.ForeColor = System.Drawing.Color.White;
            this.NPOrder1.Location = new System.Drawing.Point(350, 100);
            this.NPOrder1.Name = "NPOrder1";
            this.NPOrder1.Size = new System.Drawing.Size(82, 25);
            this.NPOrder1.TabIndex = 22;
            this.NPOrder1.Text = "label30";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::CanteenManager.Properties.Resources.tumblr_o5hdsyqZzh1s2wio8o1_500;
            this.pictureBox2.Location = new System.Drawing.Point(719, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 365);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // MonitorQueuing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CanteenManager.Properties.Resources.blue_fade_logon_by_ksbansal_d3f3v5q;
            this.ClientSize = new System.Drawing.Size(1125, 636);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.NPOrder1);
            this.Controls.Add(this.NWOrder1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MonitorQueuing";
            this.Text = "MonitorQueuing";
            this.Load += new System.EventHandler(this.MonitorQueuing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NWOrder1;
        private System.Windows.Forms.Label NPOrder1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}