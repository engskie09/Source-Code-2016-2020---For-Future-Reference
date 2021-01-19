namespace theFACTisYOU
{
    partial class AdminStaffSession_PrintReceipt_
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
            this.PrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new theFACTisYOU.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PrintTableAdapter = new theFACTisYOU.DataSet1TableAdapters.PrintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintBindingSource
            // 
            this.PrintBindingSource.DataMember = "Print";
            this.PrintBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "theFACTisYOU.resibo.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(950, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // PrintTableAdapter
            // 
            this.PrintTableAdapter.ClearBeforeFill = true;
            // 
            // AdminStaffSession_PrintReceipt_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 528);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AdminStaffSession_PrintReceipt_";
            this.Text = "AdminStaffSession_PrintReceipt_";
            this.Load += new System.EventHandler(this.AdminStaffSession_PrintReceipt__Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PrintBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PrintTableAdapter PrintTableAdapter;
    }
}