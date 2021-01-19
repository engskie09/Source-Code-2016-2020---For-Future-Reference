namespace engskie09ApartmentSystem
{
    partial class AdminSession6_Reports_Report_
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.adminsession_reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.engskie09apartmentsystemDataSet = new engskie09ApartmentSystem.engskie09apartmentsystemDataSet();
            this.adminsessionreportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsession_reportsTableAdapter = new engskie09ApartmentSystem.engskie09apartmentsystemDataSetTableAdapters.adminsession_reportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adminsession_reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engskie09apartmentsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsessionreportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminsession_reportsBindingSource
            // 
            this.adminsession_reportsBindingSource.DataMember = "adminsession_reports";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(77)))), ((int)(((byte)(80)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1047, 30);
            this.panel4.TabIndex = 24;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.btnClose.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20F);
            this.btnClose.Location = new System.Drawing.Point(442, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 36);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dtset_CustomerChekcInOut";
            reportDataSource1.Value = this.adminsessionreportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "engskie09ApartmentSystem.admin_report(Customer_CheckInOut).rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1023, 394);
            this.reportViewer1.TabIndex = 27;
            // 
            // engskie09apartmentsystemDataSet
            // 
            this.engskie09apartmentsystemDataSet.DataSetName = "engskie09apartmentsystemDataSet";
            this.engskie09apartmentsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsessionreportsBindingSource
            // 
            this.adminsessionreportsBindingSource.DataMember = "adminsession_reports";
            this.adminsessionreportsBindingSource.DataSource = this.engskie09apartmentsystemDataSet;
            // 
            // adminsession_reportsTableAdapter
            // 
            this.adminsession_reportsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminSession6_Reports_Report_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1047, 484);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSession6_Reports_Report_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerSession6_Check_Out_Receipt_";
            this.Load += new System.EventHandler(this.AdminSession6_Reports_Report__Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminsession_reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engskie09apartmentsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsessionreportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource adminsession_reportsBindingSource;
        private engskie09apartmentsystemDataSet engskie09apartmentsystemDataSet;
        private System.Windows.Forms.BindingSource adminsessionreportsBindingSource;
        private engskie09apartmentsystemDataSetTableAdapters.adminsession_reportsTableAdapter adminsession_reportsTableAdapter;
        
    }
}