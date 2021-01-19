namespace JSP_LibrarySystem
{
    partial class GeneralSession_NoiseMonitoring
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
            this.pctbox_bulb1 = new System.Windows.Forms.PictureBox();
            this.btn_switch1 = new System.Windows.Forms.Button();
            this.btn_switch2 = new System.Windows.Forms.Button();
            this.pctbox_bulb2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tm_setTimber = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_bulb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_bulb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbox_bulb1
            // 
            this.pctbox_bulb1.Image = global::JSP_LibrarySystem.Properties.Resources.lightoff;
            this.pctbox_bulb1.Location = new System.Drawing.Point(12, 12);
            this.pctbox_bulb1.Name = "pctbox_bulb1";
            this.pctbox_bulb1.Size = new System.Drawing.Size(186, 154);
            this.pctbox_bulb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_bulb1.TabIndex = 0;
            this.pctbox_bulb1.TabStop = false;
            // 
            // btn_switch1
            // 
            this.btn_switch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switch1.Location = new System.Drawing.Point(13, 210);
            this.btn_switch1.Name = "btn_switch1";
            this.btn_switch1.Size = new System.Drawing.Size(185, 59);
            this.btn_switch1.TabIndex = 1;
            this.btn_switch1.Text = "OFF";
            this.btn_switch1.UseVisualStyleBackColor = true;
            this.btn_switch1.Click += new System.EventHandler(this.btn_switch1_Click);
            // 
            // btn_switch2
            // 
            this.btn_switch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_switch2.Location = new System.Drawing.Point(251, 210);
            this.btn_switch2.Name = "btn_switch2";
            this.btn_switch2.Size = new System.Drawing.Size(185, 59);
            this.btn_switch2.TabIndex = 3;
            this.btn_switch2.Text = "OFF";
            this.btn_switch2.UseVisualStyleBackColor = true;
            this.btn_switch2.Click += new System.EventHandler(this.btn_switch2_Click);
            // 
            // pctbox_bulb2
            // 
            this.pctbox_bulb2.Image = global::JSP_LibrarySystem.Properties.Resources.lightoff;
            this.pctbox_bulb2.Location = new System.Drawing.Point(250, 12);
            this.pctbox_bulb2.Name = "pctbox_bulb2";
            this.pctbox_bulb2.Size = new System.Drawing.Size(186, 154);
            this.pctbox_bulb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_bulb2.TabIndex = 2;
            this.pctbox_bulb2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tm_setTimber
            // 
            this.tm_setTimber.Tick += new System.EventHandler(this.tm_setTimber_Tick);
            // 
            // GeneralSession_NoiseMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 340);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_switch2);
            this.Controls.Add(this.pctbox_bulb2);
            this.Controls.Add(this.btn_switch1);
            this.Controls.Add(this.pctbox_bulb1);
            this.Name = "GeneralSession_NoiseMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralSession_NoiseMonitoring";
            this.Load += new System.EventHandler(this.GeneralSession_NoiseMonitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_bulb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_bulb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctbox_bulb1;
        private System.Windows.Forms.Button btn_switch1;
        private System.Windows.Forms.Button btn_switch2;
        private System.Windows.Forms.PictureBox pctbox_bulb2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Timer tm_setTimber;

    }
}