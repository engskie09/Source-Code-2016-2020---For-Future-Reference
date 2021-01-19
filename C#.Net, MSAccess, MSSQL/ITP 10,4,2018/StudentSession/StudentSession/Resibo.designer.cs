namespace CanteenKiosk
{
    partial class bilhin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilhin));
            this.recipecurrentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteen_dbDataSet = new StudentSession.canteen_dbDataSet();
            this.reportVresibo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.recipecurrentTableAdapter = new StudentSession.canteen_dbDataSetTableAdapters.recipecurrentTableAdapter();
            this.btnFinishnaXD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipecurrentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteen_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // recipecurrentBindingSource
            // 
            this.recipecurrentBindingSource.DataMember = "recipecurrent";
            this.recipecurrentBindingSource.DataSource = this.canteen_dbDataSet;
            // 
            // canteen_dbDataSet
            // 
            this.canteen_dbDataSet.DataSetName = "canteen_dbDataSet";
            this.canteen_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportVresibo
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.recipecurrentBindingSource;
            this.reportVresibo.LocalReport.DataSources.Add(reportDataSource1);
            this.reportVresibo.LocalReport.ReportEmbeddedResource = "StudentSession.Report1.rdlc";
            this.reportVresibo.Location = new System.Drawing.Point(12, 12);
            this.reportVresibo.Name = "reportVresibo";
            this.reportVresibo.Size = new System.Drawing.Size(408, 607);
            this.reportVresibo.TabIndex = 0;
            this.reportVresibo.Load += new System.EventHandler(this.reportVresibo_Load);
            // 
            // recipecurrentTableAdapter
            // 
            this.recipecurrentTableAdapter.ClearBeforeFill = true;
            // 
            // btnFinishnaXD
            // 
            this.btnFinishnaXD.BackColor = System.Drawing.Color.Transparent;
            this.btnFinishnaXD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishnaXD.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishnaXD.ForeColor = System.Drawing.Color.White;
            this.btnFinishnaXD.Location = new System.Drawing.Point(12, 631);
            this.btnFinishnaXD.Name = "btnFinishnaXD";
            this.btnFinishnaXD.Size = new System.Drawing.Size(404, 58);
            this.btnFinishnaXD.TabIndex = 13;
            this.btnFinishnaXD.Text = "End of Transaction";
            this.btnFinishnaXD.UseVisualStyleBackColor = false;
            this.btnFinishnaXD.Click += new System.EventHandler(this.btnFinishnaXD_Click_1);
            // 
            // bilhin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 701);
            this.Controls.Add(this.btnFinishnaXD);
            this.Controls.Add(this.reportVresibo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bilhin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bilhin";
            this.Load += new System.EventHandler(this.Resibo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipecurrentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteen_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportVresibo;
        private StudentSession.canteen_dbDataSet canteen_dbDataSet;
        private System.Windows.Forms.BindingSource recipecurrentBindingSource;
        private StudentSession.canteen_dbDataSetTableAdapters.recipecurrentTableAdapter recipecurrentTableAdapter;
        private System.Windows.Forms.Button btnFinishnaXD;
    }
}