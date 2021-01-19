namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Product_List
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbx_Search_Filter = new Binarymission.WinForms.Controls.ListControls.BinaryImageComboBox();
            this.img_Arrow = new System.Windows.Forms.ImageList(this.components);
            this.txtbx_Product_Search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.Product_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Product_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Product, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.85765F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 560);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.cmbx_Search_Filter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtbx_Product_Search, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1134, 50);
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
            "Name",
            "Quantity",
            "M-Cash",
            "Points",
            "Category",
            "Description",
            "Status"});
            this.cmbx_Search_Filter.Location = new System.Drawing.Point(931, 10);
            this.cmbx_Search_Filter.Margin = new System.Windows.Forms.Padding(0);
            this.cmbx_Search_Filter.MultiColumnDropDownWindowBorderThickness = 0F;
            this.cmbx_Search_Filter.MultiColumnWindowColumnsHorizontalAlignments = null;
            this.cmbx_Search_Filter.Name = "cmbx_Search_Filter";
            this.cmbx_Search_Filter.ShouldApplyMultiColumnWindowColumnsAlignmentsToAutoCompleteDropDown = false;
            this.cmbx_Search_Filter.ShouldDisplayColumnHeadersWhenInMultiColumnMode = true;
            this.cmbx_Search_Filter.ShouldDrawExtendedDropdownButton = false;
            this.cmbx_Search_Filter.ShowBorderAlways = true;
            this.cmbx_Search_Filter.Size = new System.Drawing.Size(179, 30);
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
            // txtbx_Product_Search
            // 
            this.txtbx_Product_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Product_Search.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Product_Search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Product_Search.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Product_Search.BorderThickness = 3;
            this.txtbx_Product_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Product_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Product_Search.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Product_Search.ForeColor = System.Drawing.Color.White;
            this.txtbx_Product_Search.isPassword = false;
            this.txtbx_Product_Search.Location = new System.Drawing.Point(4, 4);
            this.txtbx_Product_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Product_Search.Name = "txtbx_Product_Search";
            this.txtbx_Product_Search.Size = new System.Drawing.Size(899, 42);
            this.txtbx_Product_Search.TabIndex = 1;
            this.txtbx_Product_Search.Text = "Search Product";
            this.txtbx_Product_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_Product_Search.OnValueChanged += new System.EventHandler(this.txtbx_Product_Search_OnValueChanged);
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            this.dgv_Product.AllowUserToDeleteRows = false;
            this.dgv_Product.AllowUserToResizeColumns = false;
            this.dgv_Product.AllowUserToResizeRows = false;
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Image,
            this.Product_Identity,
            this.Product_Name,
            this.Product_Quantity,
            this.Product_Price_Cash,
            this.Product_Price_Point,
            this.Product_Category,
            this.Product_Description,
            this.Product_Status});
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.Location = new System.Drawing.Point(3, 59);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Product.RowTemplate.Height = 80;
            this.dgv_Product.Size = new System.Drawing.Size(1134, 498);
            this.dgv_Product.TabIndex = 1;
            this.dgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellClick);
            // 
            // Product_Image
            // 
            this.Product_Image.FillWeight = 100.9378F;
            this.Product_Image.HeaderText = "Image";
            this.Product_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Product_Image.Name = "Product_Image";
            this.Product_Image.ReadOnly = true;
            this.Product_Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Product_Identity
            // 
            this.Product_Identity.FillWeight = 133.1348F;
            this.Product_Identity.HeaderText = "ID";
            this.Product_Identity.Name = "Product_Identity";
            this.Product_Identity.ReadOnly = true;
            this.Product_Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product_Name.FillWeight = 81.97997F;
            this.Product_Name.HeaderText = "Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product_Name.Width = 56;
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.FillWeight = 111.8957F;
            this.Product_Quantity.HeaderText = "Quantity";
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.ReadOnly = true;
            this.Product_Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Price_Cash
            // 
            this.Product_Price_Cash.FillWeight = 141.2713F;
            this.Product_Price_Cash.HeaderText = "Price M-Cash";
            this.Product_Price_Cash.Name = "Product_Price_Cash";
            this.Product_Price_Cash.ReadOnly = true;
            this.Product_Price_Cash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Price_Point
            // 
            this.Product_Price_Point.FillWeight = 100.9378F;
            this.Product_Price_Point.HeaderText = "Price Points";
            this.Product_Price_Point.Name = "Product_Price_Point";
            this.Product_Price_Point.ReadOnly = true;
            this.Product_Price_Point.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Category
            // 
            this.Product_Category.FillWeight = 100.9378F;
            this.Product_Category.HeaderText = "Category";
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.ReadOnly = true;
            this.Product_Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Description
            // 
            this.Product_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Product_Description.HeaderText = "Description";
            this.Product_Description.Name = "Product_Description";
            this.Product_Description.ReadOnly = true;
            this.Product_Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product_Description.Width = 94;
            // 
            // Product_Status
            // 
            this.Product_Status.FillWeight = 100.9378F;
            this.Product_Status.HeaderText = "Status";
            this.Product_Status.Name = "Product_Status";
            this.Product_Status.ReadOnly = true;
            this.Product_Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MythicalCafe_BackEnd_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MythicalCafe_BackEnd_Product_List";
            this.Text = "MythicalCafe_BackEnd_Product_List";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Product_List_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Binarymission.WinForms.Controls.ListControls.BinaryImageComboBox cmbx_Search_Filter;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Product_Search;
        private System.Windows.Forms.ImageList img_Arrow;
        private System.Windows.Forms.DataGridViewImageColumn Product_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price_Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price_Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Status;
    }
}