namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip
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
            this.btn_Print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rv_Payroll_Payslip = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Print
            // 
            this.btn_Print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Print.BorderRadius = 0;
            this.btn_Print.ButtonText = "Print";
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Print.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Print.Iconimage = null;
            this.btn_Print.Iconimage_right = null;
            this.btn_Print.Iconimage_right_Selected = null;
            this.btn_Print.Iconimage_Selected = null;
            this.btn_Print.IconMarginLeft = 0;
            this.btn_Print.IconMarginRight = 0;
            this.btn_Print.IconRightVisible = true;
            this.btn_Print.IconRightZoom = 0D;
            this.btn_Print.IconVisible = true;
            this.btn_Print.IconZoom = 90D;
            this.btn_Print.IsTab = false;
            this.btn_Print.Location = new System.Drawing.Point(319, 390);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Print.selected = false;
            this.btn_Print.Size = new System.Drawing.Size(139, 34);
            this.btn_Print.TabIndex = 25;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Print.Textcolor = System.Drawing.Color.White;
            this.btn_Print.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Print, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rv_Payroll_Payslip, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.95621F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0438F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rv_Payroll_Payslip
            // 
            this.rv_Payroll_Payslip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_Payroll_Payslip.LocalReport.ReportEmbeddedResource = "MythicalCafe_ICMS_BackEnd.MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Paysl" +
    "ip.rdlc";
            this.rv_Payroll_Payslip.Location = new System.Drawing.Point(3, 3);
            this.rv_Payroll_Payslip.Name = "rv_Payroll_Payslip";
            this.rv_Payroll_Payslip.ServerReport.BearerToken = null;
            this.rv_Payroll_Payslip.Size = new System.Drawing.Size(772, 375);
            this.rv_Payroll_Payslip.TabIndex = 26;
            // 
            // MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(778, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Payslip_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Print;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer rv_Payroll_Payslip;
    }
}