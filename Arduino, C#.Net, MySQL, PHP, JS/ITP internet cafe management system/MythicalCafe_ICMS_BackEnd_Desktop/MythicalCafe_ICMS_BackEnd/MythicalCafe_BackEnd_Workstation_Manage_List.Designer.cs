namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Workstation_Manage_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Action = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_Workstation = new System.Windows.Forms.DataGridView();
            this.Workstation_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workstation_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workstation_Client_InternetProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Workstation_Server_Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_getAction = new System.Windows.Forms.Label();
            this.pnl_Workstation_Information = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Server_Host = new MythicalCafe_SelectablePanel();
            this.lbl_Server_Host = new System.Windows.Forms.Label();
            this.txtbx_Client_InternetProtocol = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbx_Workstation_Name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workstation)).BeginInit();
            this.pnl_Workstation_Information.SuspendLayout();
            this.pnl_Server_Host.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.64162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.35838F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Action, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Workstation, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_getAction, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Workstation_Information, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 246);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Action
            // 
            this.btn_Action.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Action.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Action.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Action.BorderRadius = 0;
            this.btn_Action.ButtonText = "Action";
            this.btn_Action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Action.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Action.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Action.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Action.Iconimage = null;
            this.btn_Action.Iconimage_right = null;
            this.btn_Action.Iconimage_right_Selected = null;
            this.btn_Action.Iconimage_Selected = null;
            this.btn_Action.IconMarginLeft = 0;
            this.btn_Action.IconMarginRight = 0;
            this.btn_Action.IconRightVisible = true;
            this.btn_Action.IconRightZoom = 0D;
            this.btn_Action.IconVisible = true;
            this.btn_Action.IconZoom = 90D;
            this.btn_Action.IsTab = false;
            this.btn_Action.Location = new System.Drawing.Point(555, 202);
            this.btn_Action.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Action.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Action.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Action.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Action.selected = false;
            this.btn_Action.Size = new System.Drawing.Size(200, 40);
            this.btn_Action.TabIndex = 16;
            this.btn_Action.Text = "Action";
            this.btn_Action.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Action.Textcolor = System.Drawing.Color.White;
            this.btn_Action.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // dgv_Workstation
            // 
            this.dgv_Workstation.AllowUserToAddRows = false;
            this.dgv_Workstation.AllowUserToDeleteRows = false;
            this.dgv_Workstation.AllowUserToResizeColumns = false;
            this.dgv_Workstation.AllowUserToResizeRows = false;
            this.dgv_Workstation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Workstation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Workstation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Workstation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Workstation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Workstation_Identity,
            this.Workstation_Name,
            this.Workstation_Client_InternetProtocol,
            this.Workstation_Server_Host});
            this.dgv_Workstation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Workstation.Location = new System.Drawing.Point(3, 3);
            this.dgv_Workstation.Name = "dgv_Workstation";
            this.dgv_Workstation.ReadOnly = true;
            this.dgv_Workstation.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Workstation.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tableLayoutPanel1.SetRowSpan(this.dgv_Workstation, 3);
            this.dgv_Workstation.RowTemplate.Height = 30;
            this.dgv_Workstation.Size = new System.Drawing.Size(527, 240);
            this.dgv_Workstation.TabIndex = 0;
            this.dgv_Workstation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Workstation_List_CellClick);
            // 
            // Workstation_Identity
            // 
            this.Workstation_Identity.FillWeight = 67.96684F;
            this.Workstation_Identity.HeaderText = "ID";
            this.Workstation_Identity.Name = "Workstation_Identity";
            this.Workstation_Identity.ReadOnly = true;
            this.Workstation_Identity.Visible = false;
            // 
            // Workstation_Name
            // 
            this.Workstation_Name.FillWeight = 81.21828F;
            this.Workstation_Name.HeaderText = "Name";
            this.Workstation_Name.Name = "Workstation_Name";
            this.Workstation_Name.ReadOnly = true;
            // 
            // Workstation_Client_InternetProtocol
            // 
            this.Workstation_Client_InternetProtocol.FillWeight = 110.8561F;
            this.Workstation_Client_InternetProtocol.HeaderText = "IP";
            this.Workstation_Client_InternetProtocol.Name = "Workstation_Client_InternetProtocol";
            this.Workstation_Client_InternetProtocol.ReadOnly = true;
            // 
            // Workstation_Server_Host
            // 
            this.Workstation_Server_Host.FillWeight = 139.9587F;
            this.Workstation_Server_Host.HeaderText = "Host";
            this.Workstation_Server_Host.Name = "Workstation_Server_Host";
            this.Workstation_Server_Host.ReadOnly = true;
            // 
            // lbl_getAction
            // 
            this.lbl_getAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_getAction.AutoSize = true;
            this.lbl_getAction.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_getAction.ForeColor = System.Drawing.Color.White;
            this.lbl_getAction.Location = new System.Drawing.Point(577, 13);
            this.lbl_getAction.Name = "lbl_getAction";
            this.lbl_getAction.Size = new System.Drawing.Size(155, 18);
            this.lbl_getAction.TabIndex = 0;
            this.lbl_getAction.Text = "Manage Workstation";
            // 
            // pnl_Workstation_Information
            // 
            this.pnl_Workstation_Information.ColumnCount = 1;
            this.pnl_Workstation_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnl_Workstation_Information.Controls.Add(this.pnl_Server_Host, 0, 2);
            this.pnl_Workstation_Information.Controls.Add(this.txtbx_Client_InternetProtocol, 0, 3);
            this.pnl_Workstation_Information.Controls.Add(this.txtbx_Workstation_Name, 0, 4);
            this.pnl_Workstation_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Workstation_Information.Location = new System.Drawing.Point(536, 48);
            this.pnl_Workstation_Information.Name = "pnl_Workstation_Information";
            this.pnl_Workstation_Information.RowCount = 4;
            this.pnl_Workstation_Information.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_Workstation_Information.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_Workstation_Information.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_Workstation_Information.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnl_Workstation_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnl_Workstation_Information.Size = new System.Drawing.Size(238, 147);
            this.pnl_Workstation_Information.TabIndex = 2;
            // 
            // pnl_Server_Host
            // 
            this.pnl_Server_Host.ColumnCount = 1;
            this.pnl_Server_Host.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Server_Host.Controls.Add(this.lbl_Server_Host, 0, 0);
            this.pnl_Server_Host.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Server_Host.Location = new System.Drawing.Point(5, 5);
            this.pnl_Server_Host.Margin = new System.Windows.Forms.Padding(5);
            this.pnl_Server_Host.Name = "pnl_Server_Host";
            this.pnl_Server_Host.RowCount = 1;
            this.pnl_Server_Host.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnl_Server_Host.Size = new System.Drawing.Size(228, 39);
            this.pnl_Server_Host.TabIndex = 33;
            this.pnl_Server_Host.TabStop = true;
            // 
            // lbl_Server_Host
            // 
            this.lbl_Server_Host.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Server_Host.AutoSize = true;
            this.lbl_Server_Host.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_Server_Host.ForeColor = System.Drawing.Color.White;
            this.lbl_Server_Host.Location = new System.Drawing.Point(67, 10);
            this.lbl_Server_Host.Name = "lbl_Server_Host";
            this.lbl_Server_Host.Size = new System.Drawing.Size(93, 18);
            this.lbl_Server_Host.TabIndex = 0;
            this.lbl_Server_Host.Text = "Server Host";
            // 
            // txtbx_Client_InternetProtocol
            // 
            this.txtbx_Client_InternetProtocol.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Client_InternetProtocol.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Client_InternetProtocol.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Client_InternetProtocol.BorderThickness = 3;
            this.txtbx_Client_InternetProtocol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Client_InternetProtocol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Client_InternetProtocol.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Client_InternetProtocol.ForeColor = System.Drawing.Color.White;
            this.txtbx_Client_InternetProtocol.isPassword = false;
            this.txtbx_Client_InternetProtocol.Location = new System.Drawing.Point(4, 53);
            this.txtbx_Client_InternetProtocol.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Client_InternetProtocol.Name = "txtbx_Client_InternetProtocol";
            this.txtbx_Client_InternetProtocol.Size = new System.Drawing.Size(230, 42);
            this.txtbx_Client_InternetProtocol.TabIndex = 1;
            this.txtbx_Client_InternetProtocol.Text = "Client Internet Protocol";
            this.txtbx_Client_InternetProtocol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_Client_InternetProtocol.Click += new System.EventHandler(this.txtbx_Client_InternetProtocol_Click);
            // 
            // txtbx_Workstation_Name
            // 
            this.txtbx_Workstation_Name.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Workstation_Name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Workstation_Name.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Workstation_Name.BorderThickness = 3;
            this.txtbx_Workstation_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Workstation_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Workstation_Name.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Workstation_Name.ForeColor = System.Drawing.Color.White;
            this.txtbx_Workstation_Name.isPassword = false;
            this.txtbx_Workstation_Name.Location = new System.Drawing.Point(4, 103);
            this.txtbx_Workstation_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Workstation_Name.Name = "txtbx_Workstation_Name";
            this.txtbx_Workstation_Name.Size = new System.Drawing.Size(230, 40);
            this.txtbx_Workstation_Name.TabIndex = 2;
            this.txtbx_Workstation_Name.Text = "Workstation Name";
            this.txtbx_Workstation_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MythicalCafe_BackEnd_Workstation_Manage_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 246);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Workstation_Manage_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Workstation_Manage_List_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Workstation)).EndInit();
            this.pnl_Workstation_Information.ResumeLayout(false);
            this.pnl_Server_Host.ResumeLayout(false);
            this.pnl_Server_Host.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Workstation;
        private System.Windows.Forms.Label lbl_getAction;
        private System.Windows.Forms.TableLayoutPanel pnl_Workstation_Information;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Workstation_Name;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Client_InternetProtocol;
        private MythicalCafe_SelectablePanel pnl_Server_Host;
        private System.Windows.Forms.Label lbl_Server_Host;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workstation_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workstation_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workstation_Client_InternetProtocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Workstation_Server_Host;
        public Bunifu.Framework.UI.BunifuFlatButton btn_Action;
    }
}