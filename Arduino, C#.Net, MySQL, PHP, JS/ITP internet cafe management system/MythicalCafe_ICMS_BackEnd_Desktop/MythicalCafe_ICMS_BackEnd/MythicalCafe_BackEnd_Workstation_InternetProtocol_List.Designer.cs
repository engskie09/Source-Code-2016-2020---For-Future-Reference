namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Workstation_InternetProtocol_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Workstation_Client_InternetProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Workstation = new System.Windows.Forms.DataGridView();
            this.lbl_getAction = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workstation)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_getAction, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Workstation, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.46025F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.53975F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Workstation_Client_InternetProtocol
            // 
            this.Workstation_Client_InternetProtocol.FillWeight = 110.8561F;
            this.Workstation_Client_InternetProtocol.HeaderText = "IP";
            this.Workstation_Client_InternetProtocol.Name = "Workstation_Client_InternetProtocol";
            this.Workstation_Client_InternetProtocol.ReadOnly = true;
            // 
            // dgv_Workstation
            // 
            this.dgv_Workstation.AllowUserToAddRows = false;
            this.dgv_Workstation.AllowUserToDeleteRows = false;
            this.dgv_Workstation.AllowUserToResizeColumns = false;
            this.dgv_Workstation.AllowUserToResizeRows = false;
            this.dgv_Workstation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Workstation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Workstation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Workstation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Workstation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Workstation_Client_InternetProtocol});
            this.dgv_Workstation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Workstation.Location = new System.Drawing.Point(3, 52);
            this.dgv_Workstation.Name = "dgv_Workstation";
            this.dgv_Workstation.ReadOnly = true;
            this.dgv_Workstation.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Workstation.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Workstation.RowTemplate.Height = 30;
            this.dgv_Workstation.Size = new System.Drawing.Size(534, 423);
            this.dgv_Workstation.TabIndex = 2;
            // 
            // lbl_getAction
            // 
            this.lbl_getAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_getAction.AutoSize = true;
            this.lbl_getAction.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_getAction.ForeColor = System.Drawing.Color.White;
            this.lbl_getAction.Location = new System.Drawing.Point(221, 15);
            this.lbl_getAction.Name = "lbl_getAction";
            this.lbl_getAction.Size = new System.Drawing.Size(97, 18);
            this.lbl_getAction.TabIndex = 3;
            this.lbl_getAction.Text = "Available PC";
            // 
            // MythicalCafe_BackEnd_Workstation_InternetProtocolAddress_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 478);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Workstation_InternetProtocolAddress_List";
            this.Text = "MythicalCafe_BackEnd_Workstation_InternetProtocolAddress_List";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Workstation_InternetProtocol_List_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workstation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Workstation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workstation_Client_InternetProtocol;
        private System.Windows.Forms.Label lbl_getAction;
    }
}