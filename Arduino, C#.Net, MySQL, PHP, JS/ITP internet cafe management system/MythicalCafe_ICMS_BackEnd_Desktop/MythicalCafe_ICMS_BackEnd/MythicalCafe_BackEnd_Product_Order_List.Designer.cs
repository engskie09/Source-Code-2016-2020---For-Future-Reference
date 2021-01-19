namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Product_Order_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MythicalCafe_BackEnd_Product_Order_List));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Product_Order = new System.Windows.Forms.DataGridView();
            this.Customer_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Order_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_List = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Border_Top = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Order)).BeginInit();
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(556, 463);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Product_Order, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Border_Top, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.911447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.08855F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Product_Order
            // 
            this.dgv_Product_Order.AllowUserToAddRows = false;
            this.dgv_Product_Order.AllowUserToDeleteRows = false;
            this.dgv_Product_Order.AllowUserToResizeColumns = false;
            this.dgv_Product_Order.AllowUserToResizeRows = false;
            this.dgv_Product_Order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
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
            this.Customer_Image,
            this.Order_Identity,
            this.Customer_Identity,
            this.Customer_FullName,
            this.Order_List});
            this.dgv_Product_Order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product_Order.Location = new System.Drawing.Point(3, 35);
            this.dgv_Product_Order.Name = "dgv_Product_Order";
            this.dgv_Product_Order.ReadOnly = true;
            this.dgv_Product_Order.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_Order.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Product_Order.RowTemplate.Height = 80;
            this.dgv_Product_Order.Size = new System.Drawing.Size(550, 425);
            this.dgv_Product_Order.TabIndex = 3;
            this.dgv_Product_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_Order_CellClick);
            // 
            // Customer_Image
            // 
            this.Customer_Image.FillWeight = 64.16092F;
            this.Customer_Image.HeaderText = "Image";
            this.Customer_Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Customer_Image.Name = "Customer_Image";
            this.Customer_Image.ReadOnly = true;
            this.Customer_Image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Order_Identity
            // 
            this.Order_Identity.FillWeight = 140F;
            this.Order_Identity.HeaderText = "Order ID";
            this.Order_Identity.Name = "Order_Identity";
            this.Order_Identity.ReadOnly = true;
            this.Order_Identity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Order_Identity.Visible = false;
            // 
            // Customer_Identity
            // 
            this.Customer_Identity.HeaderText = "Customer ID";
            this.Customer_Identity.Name = "Customer_Identity";
            this.Customer_Identity.ReadOnly = true;
            this.Customer_Identity.Visible = false;
            // 
            // Customer_FullName
            // 
            this.Customer_FullName.FillWeight = 158.7983F;
            this.Customer_FullName.HeaderText = "Name";
            this.Customer_FullName.Name = "Customer_FullName";
            this.Customer_FullName.ReadOnly = true;
            this.Customer_FullName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Customer_FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Order_List
            // 
            this.Order_List.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.Order_List.HeaderText = "Order List";
            this.Order_List.Name = "Order_List";
            this.Order_List.ReadOnly = true;
            this.Order_List.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Order_List.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Order_List.Width = 88;
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
            this.pnl_Border_Top.Size = new System.Drawing.Size(550, 26);
            this.pnl_Border_Top.TabIndex = 17;
            // 
            // MythicalCafe_BackEnd_Product_Order_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 463);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Product_Order_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Product_Order_List";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Product_Order_List_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Product_Order;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_Border_Top;
        private System.Windows.Forms.DataGridViewImageColumn Customer_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_List;
    }
}