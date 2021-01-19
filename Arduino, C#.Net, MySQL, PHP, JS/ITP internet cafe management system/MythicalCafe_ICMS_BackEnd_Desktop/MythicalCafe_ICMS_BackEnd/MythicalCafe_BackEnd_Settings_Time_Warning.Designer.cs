namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Settings_Time_Warning
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
            this.dgv_Time_Warning = new System.Windows.Forms.DataGridView();
            this.Time_Warning_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Warning_TimeSpan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Warning_Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtbx_Message = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_Time_Warning = new System.Windows.Forms.Label();
            this.btn_Insert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Update = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Time_Warning)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Time_Warning, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 505);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Time_Warning
            // 
            this.dgv_Time_Warning.AllowUserToAddRows = false;
            this.dgv_Time_Warning.AllowUserToDeleteRows = false;
            this.dgv_Time_Warning.AllowUserToResizeColumns = false;
            this.dgv_Time_Warning.AllowUserToResizeRows = false;
            this.dgv_Time_Warning.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Time_Warning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Time_Warning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Time_Warning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Time_Warning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time_Warning_Identity,
            this.Time_Warning_TimeSpan,
            this.Time_Warning_Message});
            this.dgv_Time_Warning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Time_Warning.Location = new System.Drawing.Point(3, 3);
            this.dgv_Time_Warning.Name = "dgv_Time_Warning";
            this.dgv_Time_Warning.ReadOnly = true;
            this.dgv_Time_Warning.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Time_Warning.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Time_Warning.RowTemplate.Height = 30;
            this.dgv_Time_Warning.Size = new System.Drawing.Size(502, 320);
            this.dgv_Time_Warning.TabIndex = 27;
            this.dgv_Time_Warning.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Time_Warning_CellClick);
            // 
            // Time_Warning_Identity
            // 
            this.Time_Warning_Identity.FillWeight = 67.96684F;
            this.Time_Warning_Identity.HeaderText = "ID";
            this.Time_Warning_Identity.Name = "Time_Warning_Identity";
            this.Time_Warning_Identity.ReadOnly = true;
            this.Time_Warning_Identity.Visible = false;
            // 
            // Time_Warning_TimeSpan
            // 
            this.Time_Warning_TimeSpan.FillWeight = 81.21828F;
            this.Time_Warning_TimeSpan.HeaderText = "Time";
            this.Time_Warning_TimeSpan.Name = "Time_Warning_TimeSpan";
            this.Time_Warning_TimeSpan.ReadOnly = true;
            // 
            // Time_Warning_Message
            // 
            this.Time_Warning_Message.FillWeight = 110.8561F;
            this.Time_Warning_Message.HeaderText = "Message";
            this.Time_Warning_Message.Name = "Time_Warning_Message";
            this.Time_Warning_Message.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.06773F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.93227F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Save, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtbx_Message, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Time_Warning, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Insert, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Delete, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_Update, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 329);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 173);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // btn_Save
            // 
            this.btn_Save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.BorderRadius = 0;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Save.Iconimage = null;
            this.btn_Save.Iconimage_right = null;
            this.btn_Save.Iconimage_right_Selected = null;
            this.btn_Save.Iconimage_Selected = null;
            this.btn_Save.IconMarginLeft = 0;
            this.btn_Save.IconMarginRight = 0;
            this.btn_Save.IconRightVisible = true;
            this.btn_Save.IconRightZoom = 0D;
            this.btn_Save.IconVisible = true;
            this.btn_Save.IconZoom = 90D;
            this.btn_Save.IsTab = false;
            this.btn_Save.Location = new System.Drawing.Point(15, 133);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save.selected = false;
            this.btn_Save.Size = new System.Drawing.Size(135, 35);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Save.Textcolor = System.Drawing.Color.White;
            this.btn_Save.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // txtbx_Message
            // 
            this.txtbx_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Message.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Message.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Message.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Message.BorderThickness = 3;
            this.txtbx_Message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Message.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Message.ForeColor = System.Drawing.Color.White;
            this.txtbx_Message.isPassword = false;
            this.txtbx_Message.Location = new System.Drawing.Point(170, 47);
            this.txtbx_Message.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Message.Name = "txtbx_Message";
            this.tableLayoutPanel2.SetRowSpan(this.txtbx_Message, 2);
            this.txtbx_Message.Size = new System.Drawing.Size(328, 78);
            this.txtbx_Message.TabIndex = 31;
            this.txtbx_Message.Text = "Message";
            this.txtbx_Message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Time_Warning
            // 
            this.lbl_Time_Warning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Time_Warning.AutoSize = true;
            this.lbl_Time_Warning.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_Time_Warning.ForeColor = System.Drawing.Color.White;
            this.lbl_Time_Warning.Location = new System.Drawing.Point(307, 12);
            this.lbl_Time_Warning.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Time_Warning.Name = "lbl_Time_Warning";
            this.lbl_Time_Warning.Size = new System.Drawing.Size(54, 18);
            this.lbl_Time_Warning.TabIndex = 30;
            this.lbl_Time_Warning.Text = "Time: ";
            this.lbl_Time_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Time_Warning.Click += new System.EventHandler(this.lbl_Time_Warning_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Insert.BorderRadius = 0;
            this.btn_Insert.ButtonText = "Insert";
            this.btn_Insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Insert.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Insert.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Insert.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Insert.Iconimage = null;
            this.btn_Insert.Iconimage_right = null;
            this.btn_Insert.Iconimage_right_Selected = null;
            this.btn_Insert.Iconimage_Selected = null;
            this.btn_Insert.IconMarginLeft = 0;
            this.btn_Insert.IconMarginRight = 0;
            this.btn_Insert.IconRightVisible = true;
            this.btn_Insert.IconRightZoom = 0D;
            this.btn_Insert.IconVisible = true;
            this.btn_Insert.IconZoom = 90D;
            this.btn_Insert.IsTab = false;
            this.btn_Insert.Location = new System.Drawing.Point(15, 5);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Insert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Insert.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Insert.selected = false;
            this.btn_Insert.Size = new System.Drawing.Size(135, 33);
            this.btn_Insert.TabIndex = 29;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Textcolor = System.Drawing.Color.White;
            this.btn_Insert.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.BorderRadius = 0;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Delete.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Delete.Iconimage = null;
            this.btn_Delete.Iconimage_right = null;
            this.btn_Delete.Iconimage_right_Selected = null;
            this.btn_Delete.Iconimage_Selected = null;
            this.btn_Delete.IconMarginLeft = 0;
            this.btn_Delete.IconMarginRight = 0;
            this.btn_Delete.IconRightVisible = true;
            this.btn_Delete.IconRightZoom = 0D;
            this.btn_Delete.IconVisible = true;
            this.btn_Delete.IconZoom = 90D;
            this.btn_Delete.IsTab = false;
            this.btn_Delete.Location = new System.Drawing.Point(15, 90);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Delete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Delete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Delete.selected = false;
            this.btn_Delete.Size = new System.Drawing.Size(135, 35);
            this.btn_Delete.TabIndex = 32;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Textcolor = System.Drawing.Color.White;
            this.btn_Delete.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update.BorderRadius = 0;
            this.btn_Update.ButtonText = "Update";
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Update.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Update.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Update.Iconimage = null;
            this.btn_Update.Iconimage_right = null;
            this.btn_Update.Iconimage_right_Selected = null;
            this.btn_Update.Iconimage_Selected = null;
            this.btn_Update.IconMarginLeft = 0;
            this.btn_Update.IconMarginRight = 0;
            this.btn_Update.IconRightVisible = true;
            this.btn_Update.IconRightZoom = 0D;
            this.btn_Update.IconVisible = true;
            this.btn_Update.IconZoom = 90D;
            this.btn_Update.IsTab = false;
            this.btn_Update.Location = new System.Drawing.Point(15, 48);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Update.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Update.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Update.selected = false;
            this.btn_Update.Size = new System.Drawing.Size(135, 33);
            this.btn_Update.TabIndex = 33;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Update.Textcolor = System.Drawing.Color.White;
            this.btn_Update.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // MythicalCafe_BackEnd_Settings_Time_Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Settings_Time_Warning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Settings_Time_Warning";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Settings_Time_Warning_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Time_Warning)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Time_Warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Warning_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Warning_TimeSpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Warning_Message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Insert;
        private System.Windows.Forms.Label lbl_Time_Warning;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Message;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Delete;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Update;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Save;
    }
}