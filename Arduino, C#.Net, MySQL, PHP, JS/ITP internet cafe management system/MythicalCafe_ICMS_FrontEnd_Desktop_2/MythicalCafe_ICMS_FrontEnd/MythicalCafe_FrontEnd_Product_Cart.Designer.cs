namespace MythicalCafe_ICMS_FrontEnd
{
    partial class MythicalCafe_FrontEnd_Product_Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MythicalCafe_FrontEnd_Product_Cart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Product_Order = new System.Windows.Forms.DataGridView();
            this.Product_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Product_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Order_Quantity_Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Order_Quantity_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Border_Top = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Order_Clear = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_Balance_Check = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Order_Process = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_Cash_Change = new System.Windows.Forms.Label();
            this.lbl_Point_Change = new System.Windows.Forms.Label();
            this.lbl_Price_Point_Total = new System.Windows.Forms.Label();
            this.lbl_Price_Cash_Total = new System.Windows.Forms.Label();
            this.lbl_Remaining_Cash = new System.Windows.Forms.Label();
            this.lbl_Remaining_Point = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Order)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(940, 750);
            this.bunifuGradientPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Product_Order, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Border_Top, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.53333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 750);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Product_Order
            // 
            this.dgv_Product_Order.AllowUserToAddRows = false;
            this.dgv_Product_Order.AllowUserToDeleteRows = false;
            this.dgv_Product_Order.AllowUserToResizeColumns = false;
            this.dgv_Product_Order.AllowUserToResizeRows = false;
            this.dgv_Product_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Image,
            this.Product_Identity,
            this.Product_Name,
            this.Product_Price_Cash,
            this.Product_Order_Quantity_Cash,
            this.Product_Price_Point,
            this.Product_Order_Quantity_Point});
            this.dgv_Product_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product_Order.Location = new System.Drawing.Point(3, 38);
            this.dgv_Product_Order.Name = "dgv_Product_Order";
            this.dgv_Product_Order.ReadOnly = true;
            this.dgv_Product_Order.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_Order.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Product_Order.RowTemplate.Height = 80;
            this.dgv_Product_Order.Size = new System.Drawing.Size(934, 433);
            this.dgv_Product_Order.TabIndex = 3;
            this.dgv_Product_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_Order_CellClick);
            // 
            // Product_Image
            // 
            this.Product_Image.FillWeight = 123.0335F;
            this.Product_Image.HeaderText = "Image";
            this.Product_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Product_Image.Name = "Product_Image";
            this.Product_Image.ReadOnly = true;
            this.Product_Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Product_Identity
            // 
            this.Product_Identity.FillWeight = 140F;
            this.Product_Identity.HeaderText = "ID";
            this.Product_Identity.Name = "Product_Identity";
            this.Product_Identity.ReadOnly = true;
            this.Product_Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Product_Identity.Visible = false;
            // 
            // Product_Name
            // 
            this.Product_Name.FillWeight = 99.92572F;
            this.Product_Name.HeaderText = "Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Price_Cash
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product_Price_Cash.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product_Price_Cash.FillWeight = 87.42437F;
            this.Product_Price_Cash.HeaderText = "Price (M-Cash)";
            this.Product_Price_Cash.Name = "Product_Price_Cash";
            this.Product_Price_Cash.ReadOnly = true;
            // 
            // Product_Order_Quantity_Cash
            // 
            this.Product_Order_Quantity_Cash.FillWeight = 101.3328F;
            this.Product_Order_Quantity_Cash.HeaderText = "Quantity";
            this.Product_Order_Quantity_Cash.Name = "Product_Order_Quantity_Cash";
            this.Product_Order_Quantity_Cash.ReadOnly = true;
            this.Product_Order_Quantity_Cash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Product_Price_Point
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product_Price_Point.DefaultCellStyle = dataGridViewCellStyle3;
            this.Product_Price_Point.FillWeight = 80.3579F;
            this.Product_Price_Point.HeaderText = "Price (Points)";
            this.Product_Price_Point.Name = "Product_Price_Point";
            this.Product_Price_Point.ReadOnly = true;
            // 
            // Product_Order_Quantity_Point
            // 
            this.Product_Order_Quantity_Point.HeaderText = "Quantity";
            this.Product_Order_Quantity_Point.Name = "Product_Order_Quantity_Point";
            this.Product_Order_Quantity_Point.ReadOnly = true;
            // 
            // pnl_Border_Top
            // 
            this.pnl_Border_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Border_Top.BackgroundImage")));
            this.pnl_Border_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Border_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Border_Top.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Border_Top.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Border_Top.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Border_Top.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.pnl_Border_Top.Location = new System.Drawing.Point(3, 3);
            this.pnl_Border_Top.Name = "pnl_Border_Top";
            this.pnl_Border_Top.Quality = 10;
            this.pnl_Border_Top.Size = new System.Drawing.Size(934, 29);
            this.pnl_Border_Top.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Order_Clear, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Balance_Check, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Order_Process, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Cash_Change, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Point_Change, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Price_Point_Total, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Price_Cash_Total, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Remaining_Cash, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Remaining_Point, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 477);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 270);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // btn_Order_Clear
            // 
            this.btn_Order_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Order_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Clear.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Order_Clear.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Order_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Order_Clear.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Order_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Order_Clear.Image = global::MythicalCafe_ICMS_FrontEnd.Properties.Resources.png_Clear;
            this.btn_Order_Clear.ImagePosition = 9;
            this.btn_Order_Clear.ImageZoom = 50;
            this.btn_Order_Clear.LabelPosition = 30;
            this.btn_Order_Clear.LabelText = "Clear Order";
            this.btn_Order_Clear.Location = new System.Drawing.Point(749, 10);
            this.btn_Order_Clear.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.btn_Order_Clear.Name = "btn_Order_Clear";
            this.tableLayoutPanel2.SetRowSpan(this.btn_Order_Clear, 2);
            this.btn_Order_Clear.Size = new System.Drawing.Size(135, 114);
            this.btn_Order_Clear.TabIndex = 30;
            this.btn_Order_Clear.Click += new System.EventHandler(this.btn_Order_Clear_Click);
            // 
            // lbl_Balance_Check
            // 
            this.lbl_Balance_Check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Balance_Check.AutoSize = true;
            this.lbl_Balance_Check.Font = new System.Drawing.Font("Georgia", 15F);
            this.lbl_Balance_Check.ForeColor = System.Drawing.Color.White;
            this.lbl_Balance_Check.Location = new System.Drawing.Point(16, 9);
            this.lbl_Balance_Check.Name = "lbl_Balance_Check";
            this.lbl_Balance_Check.Size = new System.Drawing.Size(200, 48);
            this.lbl_Balance_Check.TabIndex = 22;
            this.lbl_Balance_Check.Text = "Your Balance \r\n(Click here to check.)";
            this.lbl_Balance_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Balance_Check.Click += new System.EventHandler(this.lbl_Balance_Check_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Change";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Order";
            // 
            // btn_Order_Process
            // 
            this.btn_Order_Process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Order_Process.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Order_Process.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Order_Process.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Order_Process.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_Process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Order_Process.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Order_Process.ForeColor = System.Drawing.Color.White;
            this.btn_Order_Process.Image = ((System.Drawing.Image)(resources.GetObject("btn_Order_Process.Image")));
            this.btn_Order_Process.ImagePosition = 9;
            this.btn_Order_Process.ImageZoom = 50;
            this.btn_Order_Process.LabelPosition = 30;
            this.btn_Order_Process.LabelText = "Process Order";
            this.btn_Order_Process.Location = new System.Drawing.Point(749, 144);
            this.btn_Order_Process.Margin = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.btn_Order_Process.Name = "btn_Order_Process";
            this.tableLayoutPanel2.SetRowSpan(this.btn_Order_Process, 2);
            this.btn_Order_Process.Size = new System.Drawing.Size(135, 116);
            this.btn_Order_Process.TabIndex = 28;
            this.btn_Order_Process.Click += new System.EventHandler(this.btn_Order_Process_Click);
            // 
            // lbl_Cash_Change
            // 
            this.lbl_Cash_Change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Cash_Change.AutoSize = true;
            this.lbl_Cash_Change.Font = new System.Drawing.Font("Georgia", 15F);
            this.lbl_Cash_Change.ForeColor = System.Drawing.Color.White;
            this.lbl_Cash_Change.Location = new System.Drawing.Point(560, 88);
            this.lbl_Cash_Change.Name = "lbl_Cash_Change";
            this.lbl_Cash_Change.Size = new System.Drawing.Size(45, 24);
            this.lbl_Cash_Change.TabIndex = 32;
            this.lbl_Cash_Change.Text = "-----";
            // 
            // lbl_Point_Change
            // 
            this.lbl_Point_Change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Point_Change.AutoSize = true;
            this.lbl_Point_Change.Font = new System.Drawing.Font("Georgia", 15F);
            this.lbl_Point_Change.ForeColor = System.Drawing.Color.White;
            this.lbl_Point_Change.Location = new System.Drawing.Point(556, 155);
            this.lbl_Point_Change.Name = "lbl_Point_Change";
            this.lbl_Point_Change.Size = new System.Drawing.Size(52, 24);
            this.lbl_Point_Change.TabIndex = 31;
            this.lbl_Point_Change.Text = "------";
            // 
            // lbl_Price_Point_Total
            // 
            this.lbl_Price_Point_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Price_Point_Total.AutoSize = true;
            this.lbl_Price_Point_Total.Font = new System.Drawing.Font("Georgia", 15F);
            this.lbl_Price_Point_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Price_Point_Total.Location = new System.Drawing.Point(327, 155);
            this.lbl_Price_Point_Total.Name = "lbl_Price_Point_Total";
            this.lbl_Price_Point_Total.Size = new System.Drawing.Size(45, 24);
            this.lbl_Price_Point_Total.TabIndex = 19;
            this.lbl_Price_Point_Total.Text = "-----";
            // 
            // lbl_Price_Cash_Total
            // 
            this.lbl_Price_Cash_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Price_Cash_Total.AutoSize = true;
            this.lbl_Price_Cash_Total.Font = new System.Drawing.Font("Georgia", 15F);
            this.lbl_Price_Cash_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Price_Cash_Total.Location = new System.Drawing.Point(327, 88);
            this.lbl_Price_Cash_Total.Name = "lbl_Price_Cash_Total";
            this.lbl_Price_Cash_Total.Size = new System.Drawing.Size(45, 24);
            this.lbl_Price_Cash_Total.TabIndex = 20;
            this.lbl_Price_Cash_Total.Text = "-----";
            // 
            // lbl_Remaining_Cash
            // 
            this.lbl_Remaining_Cash.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Remaining_Cash.AutoSize = true;
            this.lbl_Remaining_Cash.Font = new System.Drawing.Font("Georgia", 15F);
            this.lbl_Remaining_Cash.ForeColor = System.Drawing.Color.White;
            this.lbl_Remaining_Cash.Location = new System.Drawing.Point(3, 88);
            this.lbl_Remaining_Cash.Name = "lbl_Remaining_Cash";
            this.lbl_Remaining_Cash.Size = new System.Drawing.Size(103, 24);
            this.lbl_Remaining_Cash.TabIndex = 24;
            this.lbl_Remaining_Cash.Text = "M-Cash: 0";
            // 
            // lbl_Remaining_Point
            // 
            this.lbl_Remaining_Point.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_Remaining_Point.AutoSize = true;
            this.lbl_Remaining_Point.Font = new System.Drawing.Font("Georgia", 15F);
            this.lbl_Remaining_Point.ForeColor = System.Drawing.Color.White;
            this.lbl_Remaining_Point.Location = new System.Drawing.Point(3, 155);
            this.lbl_Remaining_Point.Name = "lbl_Remaining_Point";
            this.lbl_Remaining_Point.Size = new System.Drawing.Size(90, 24);
            this.lbl_Remaining_Point.TabIndex = 23;
            this.lbl_Remaining_Point.Text = "Points: 0";
            // 
            // MythicalCafe_FrontEnd_Product_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(940, 750);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_FrontEnd_Product_Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_FrontEnd_Product_Cart";
            this.Load += new System.EventHandler(this.MythicalCafe_FrontEnd_Product_Cart_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Order)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Product_Order;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Border_Top;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_Price_Cash_Total;
        private System.Windows.Forms.Label lbl_Price_Point_Total;
        private System.Windows.Forms.Label lbl_Balance_Check;
        private System.Windows.Forms.Label lbl_Remaining_Point;
        private System.Windows.Forms.Label lbl_Remaining_Cash;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_Order_Process;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton btn_Order_Clear;
        private System.Windows.Forms.Label lbl_Point_Change;
        private System.Windows.Forms.Label lbl_Cash_Change;
        private System.Windows.Forms.DataGridViewImageColumn Product_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price_Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Order_Quantity_Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price_Point;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Order_Quantity_Point;
    }
}