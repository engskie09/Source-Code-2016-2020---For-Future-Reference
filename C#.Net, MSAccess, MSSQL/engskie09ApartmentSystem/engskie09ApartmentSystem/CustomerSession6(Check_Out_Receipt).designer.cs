namespace engskie09ApartmentSystem
{
    partial class CustomerSession6_Check_Out_Receipt_
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.customer_checkout_receipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 30);
            this.panel4.TabIndex = 24;
            // 
            // customer_checkout_receipt
            // 
            this.customer_checkout_receipt.LocalReport.ReportEmbeddedResource = "engskie09ApartmentSystem.customer_receipt.rdlc";
            this.customer_checkout_receipt.Location = new System.Drawing.Point(12, 36);
            this.customer_checkout_receipt.Name = "customer_checkout_receipt";
            this.customer_checkout_receipt.Size = new System.Drawing.Size(395, 391);
            this.customer_checkout_receipt.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btnClose.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btnClose.Location = new System.Drawing.Point(124, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 36);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustomerSession6_Check_Out_Receipt_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(419, 484);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.customer_checkout_receipt);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerSession6_Check_Out_Receipt_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerSession6_Check_Out_Receipt_";
            this.Load += new System.EventHandler(this.CustomerSession6_Check_Out_Receipt__Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Microsoft.Reporting.WinForms.ReportViewer customer_checkout_receipt;
        private System.Windows.Forms.Button btnClose;
    }
}