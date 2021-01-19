namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Account_Staff_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbx_Search_Filter = new Binarymission.WinForms.Controls.ListControls.BinaryImageComboBox();
            this.img_Arrow = new System.Windows.Forms.ImageList(this.components);
            this.txtbx_Staff_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Staff_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Account
            // 
            this.dgv_Account.AllowUserToAddRows = false;
            this.dgv_Account.AllowUserToDeleteRows = false;
            this.dgv_Account.AllowUserToResizeColumns = false;
            this.dgv_Account.AllowUserToResizeRows = false;
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Staff_Identity,
            this.Staff_FullName,
            this.Staff_Position});
            this.dgv_Account.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Account.Location = new System.Drawing.Point(3, 48);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.ReadOnly = true;
            this.dgv_Account.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Account.RowTemplate.Height = 80;
            this.dgv_Account.Size = new System.Drawing.Size(427, 399);
            this.dgv_Account.TabIndex = 1;
            this.dgv_Account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Account, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.85765F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.14988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.85012F));
            this.tableLayoutPanel2.Controls.Add(this.cmbx_Search_Filter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbx_Staff_Search, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(427, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // cmbx_Search_Filter
            // 
            this.cmbx_Search_Filter.AlphaBlendFactorForControlPainting = 100;
            this.cmbx_Search_Filter.AlphaBlendFactorForDropDownPressedColor = 70;
            this.cmbx_Search_Filter.AlphaBlendFactorForItemSelectionColor = 70;
            this.cmbx_Search_Filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbx_Search_Filter.BackColor = System.Drawing.SystemColors.Window;
            this.cmbx_Search_Filter.Bitmaps = null;
            this.cmbx_Search_Filter.BitmapsAssociatedText = null;
            this.cmbx_Search_Filter.ColorForDrawingRectangleAroundImage = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.cmbx_Search_Filter.ControlArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.cmbx_Search_Filter.CustomControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.cmbx_Search_Filter.CustomControlBorderColorWhenNotInFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbx_Search_Filter.CustomControlDropDownButtonFillColorWhenNotInFocus = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbx_Search_Filter.CustomPaintingColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.cmbx_Search_Filter.DesiredHeightForDrawingTheImages = 24;
            this.cmbx_Search_Filter.DesiredWidthForDrawingTheImages = 20;
            this.cmbx_Search_Filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbx_Search_Filter.DrawRectangleAroundImage = true;
            this.cmbx_Search_Filter.DropDownItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbx_Search_Filter.DropDownItemTextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmbx_Search_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Search_Filter.DropDownWindowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.cmbx_Search_Filter.DropDownWindowBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbx_Search_Filter.DropDownWindowBorderThickness = 1F;
            this.cmbx_Search_Filter.ExtendedDropdownButtonImage = null;
            this.cmbx_Search_Filter.ExtendedDropdownButtonInternalImage = null;
            this.cmbx_Search_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbx_Search_Filter.Font = new System.Drawing.Font("Georgia", 12F);
            this.cmbx_Search_Filter.ForeColor = System.Drawing.Color.White;
            this.cmbx_Search_Filter.FormattingEnabled = true;
            this.cmbx_Search_Filter.Imagelist = this.img_Arrow;
            this.cmbx_Search_Filter.IsInExtendedReadOnlyMode = false;
            this.cmbx_Search_Filter.ItemHeight = 24;
            this.cmbx_Search_Filter.Items.AddRange(new object[] {
            "All",
            "ID",
            "Name"});
            this.cmbx_Search_Filter.Location = new System.Drawing.Point(290, 4);
            this.cmbx_Search_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.cmbx_Search_Filter.MultiColumnDropDownWindowBorderThickness = 0F;
            this.cmbx_Search_Filter.MultiColumnWindowColumnsHorizontalAlignments = null;
            this.cmbx_Search_Filter.Name = "cmbx_Search_Filter";
            this.cmbx_Search_Filter.ShouldApplyMultiColumnWindowColumnsAlignmentsToAutoCompleteDropDown = false;
            this.cmbx_Search_Filter.ShouldDisplayColumnHeadersWhenInMultiColumnMode = true;
            this.cmbx_Search_Filter.ShouldDrawExtendedDropdownButton = false;
            this.cmbx_Search_Filter.ShowBorderAlways = true;
            this.cmbx_Search_Filter.Size = new System.Drawing.Size(137, 30);
            this.cmbx_Search_Filter.TabIndex = 6;
            this.cmbx_Search_Filter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.cmbx_Search_Filter.UseImageListForComboBox = true;
            // 
            // img_Arrow
            // 
            this.img_Arrow.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.img_Arrow.ImageSize = new System.Drawing.Size(16, 16);
            this.img_Arrow.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtbx_Staff_Search
            // 
            this.txtbx_Staff_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Staff_Search.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Staff_Search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Staff_Search.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Staff_Search.BorderThickness = 3;
            this.txtbx_Staff_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Staff_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Staff_Search.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Staff_Search.ForeColor = System.Drawing.Color.White;
            this.txtbx_Staff_Search.isPassword = false;
            this.txtbx_Staff_Search.Location = new System.Drawing.Point(4, 4);
            this.txtbx_Staff_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Staff_Search.Name = "txtbx_Staff_Search";
            this.txtbx_Staff_Search.Size = new System.Drawing.Size(282, 31);
            this.txtbx_Staff_Search.TabIndex = 1;
            this.txtbx_Staff_Search.Text = "Search Staff";
            this.txtbx_Staff_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Staff_Identity
            // 
            this.Staff_Identity.HeaderText = "Staff_Identity";
            this.Staff_Identity.Name = "Staff_Identity";
            this.Staff_Identity.ReadOnly = true;
            this.Staff_Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Staff_Identity.Visible = false;
            // 
            // Staff_FullName
            // 
            this.Staff_FullName.HeaderText = "Name";
            this.Staff_FullName.Name = "Staff_FullName";
            this.Staff_FullName.ReadOnly = true;
            this.Staff_FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Staff_Position
            // 
            this.Staff_Position.HeaderText = "Position";
            this.Staff_Position.Name = "Staff_Position";
            this.Staff_Position.ReadOnly = true;
            this.Staff_Position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MythicalCafe_BackEnd_Account_Staff_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Account_Staff_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Account_Staff_List";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Account_Staff_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Binarymission.WinForms.Controls.ListControls.BinaryImageComboBox cmbx_Search_Filter;
        private System.Windows.Forms.ImageList img_Arrow;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Staff_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Position;
    }
}