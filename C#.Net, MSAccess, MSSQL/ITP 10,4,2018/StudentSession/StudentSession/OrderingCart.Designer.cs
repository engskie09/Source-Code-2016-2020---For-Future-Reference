namespace CanteenKiosk
{
    partial class OrderingCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderingCart));
            this.CrazyKart = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FinishNa = new System.Windows.Forms.Button();
            this.PlusQuantity = new System.Windows.Forms.Button();
            this.MinusQuantity = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdateKart = new System.Windows.Forms.Button();
            this.btnRemoveFromKart = new System.Windows.Forms.Button();
            this.QuantityToBuy = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalAll = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedFood = new System.Windows.Forms.Label();
            this.mealName4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CrazyKart)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CrazyKart
            // 
            this.CrazyKart.AllowUserToAddRows = false;
            this.CrazyKart.AllowUserToDeleteRows = false;
            this.CrazyKart.AllowUserToResizeColumns = false;
            this.CrazyKart.AllowUserToResizeRows = false;
            this.CrazyKart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CrazyKart.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CrazyKart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CrazyKart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrazyKart.Location = new System.Drawing.Point(28, 66);
            this.CrazyKart.Name = "CrazyKart";
            this.CrazyKart.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CrazyKart.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CrazyKart.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrazyKart.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.CrazyKart.RowTemplate.Height = 50;
            this.CrazyKart.Size = new System.Drawing.Size(511, 498);
            this.CrazyKart.TabIndex = 0;
            this.CrazyKart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CrazyKart_CellContentClick);
            this.CrazyKart.SelectionChanged += new System.EventHandler(this.CrazyKart_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel6.Controls.Add(this.FinishNa);
            this.panel6.Controls.Add(this.PlusQuantity);
            this.panel6.Controls.Add(this.MinusQuantity);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.btnUpdateKart);
            this.panel6.Controls.Add(this.btnRemoveFromKart);
            this.panel6.Controls.Add(this.QuantityToBuy);
            this.panel6.Location = new System.Drawing.Point(558, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(454, 496);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // FinishNa
            // 
            this.FinishNa.BackColor = System.Drawing.Color.RoyalBlue;
            this.FinishNa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FinishNa.FlatAppearance.BorderSize = 2;
            this.FinishNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishNa.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishNa.ForeColor = System.Drawing.Color.White;
            this.FinishNa.Location = new System.Drawing.Point(33, 338);
            this.FinishNa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FinishNa.Name = "FinishNa";
            this.FinishNa.Size = new System.Drawing.Size(399, 133);
            this.FinishNa.TabIndex = 72;
            this.FinishNa.Text = "Proceed";
            this.FinishNa.UseVisualStyleBackColor = false;
            this.FinishNa.Click += new System.EventHandler(this.FinishNa_Click);
            // 
            // PlusQuantity
            // 
            this.PlusQuantity.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PlusQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlusQuantity.Enabled = false;
            this.PlusQuantity.FlatAppearance.BorderSize = 0;
            this.PlusQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusQuantity.ForeColor = System.Drawing.Color.White;
            this.PlusQuantity.Image = global::StudentSession.Properties.Resources.plus__1_;
            this.PlusQuantity.Location = new System.Drawing.Point(291, 232);
            this.PlusQuantity.Name = "PlusQuantity";
            this.PlusQuantity.Size = new System.Drawing.Size(72, 66);
            this.PlusQuantity.TabIndex = 14;
            this.PlusQuantity.UseVisualStyleBackColor = false;
            this.PlusQuantity.Click += new System.EventHandler(this.PlusQuantity_Click);
            // 
            // MinusQuantity
            // 
            this.MinusQuantity.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MinusQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinusQuantity.Enabled = false;
            this.MinusQuantity.FlatAppearance.BorderSize = 0;
            this.MinusQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusQuantity.ForeColor = System.Drawing.Color.White;
            this.MinusQuantity.Image = global::StudentSession.Properties.Resources.minus;
            this.MinusQuantity.Location = new System.Drawing.Point(90, 232);
            this.MinusQuantity.Name = "MinusQuantity";
            this.MinusQuantity.Size = new System.Drawing.Size(72, 66);
            this.MinusQuantity.TabIndex = 12;
            this.MinusQuantity.UseVisualStyleBackColor = false;
            this.MinusQuantity.Click += new System.EventHandler(this.MinusQuantity_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity";
            // 
            // btnUpdateKart
            // 
            this.btnUpdateKart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUpdateKart.Enabled = false;
            this.btnUpdateKart.FlatAppearance.BorderSize = 0;
            this.btnUpdateKart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateKart.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateKart.ForeColor = System.Drawing.Color.White;
            this.btnUpdateKart.Image = global::StudentSession.Properties.Resources.rotate1;
            this.btnUpdateKart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdateKart.Location = new System.Drawing.Point(237, 27);
            this.btnUpdateKart.Name = "btnUpdateKart";
            this.btnUpdateKart.Size = new System.Drawing.Size(193, 139);
            this.btnUpdateKart.TabIndex = 10;
            this.btnUpdateKart.Text = "\r\n\r\nUpdate Order Quantity";
            this.btnUpdateKart.UseVisualStyleBackColor = false;
            this.btnUpdateKart.Click += new System.EventHandler(this.btnUpdateKart_Click);
            // 
            // btnRemoveFromKart
            // 
            this.btnRemoveFromKart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRemoveFromKart.Enabled = false;
            this.btnRemoveFromKart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromKart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromKart.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromKart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromKart.Image = global::StudentSession.Properties.Resources.cart;
            this.btnRemoveFromKart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveFromKart.Location = new System.Drawing.Point(22, 27);
            this.btnRemoveFromKart.Name = "btnRemoveFromKart";
            this.btnRemoveFromKart.Size = new System.Drawing.Size(193, 139);
            this.btnRemoveFromKart.TabIndex = 1;
            this.btnRemoveFromKart.Text = "\r\n\r\nRemove From Cart";
            this.btnRemoveFromKart.UseVisualStyleBackColor = false;
            this.btnRemoveFromKart.Click += new System.EventHandler(this.btnRemoveFromKart_Click);
            // 
            // QuantityToBuy
            // 
            this.QuantityToBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityToBuy.Enabled = false;
            this.QuantityToBuy.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityToBuy.Location = new System.Drawing.Point(157, 232);
            this.QuantityToBuy.Name = "QuantityToBuy";
            this.QuantityToBuy.Size = new System.Drawing.Size(138, 65);
            this.QuantityToBuy.TabIndex = 13;
            this.QuantityToBuy.Text = "1";
            this.QuantityToBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::StudentSession.Properties.Resources.philippines_peso_currency_symbol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(268, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // TotalAll
            // 
            this.TotalAll.AutoSize = true;
            this.TotalAll.BackColor = System.Drawing.Color.Transparent;
            this.TotalAll.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAll.ForeColor = System.Drawing.Color.White;
            this.TotalAll.Location = new System.Drawing.Point(342, 115);
            this.TotalAll.Name = "TotalAll";
            this.TotalAll.Size = new System.Drawing.Size(93, 42);
            this.TotalAll.TabIndex = 16;
            this.TotalAll.Text = "-----";
            this.TotalAll.Click += new System.EventHandler(this.TotalAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Food Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // selectedFood
            // 
            this.selectedFood.AutoSize = true;
            this.selectedFood.BackColor = System.Drawing.Color.Transparent;
            this.selectedFood.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFood.ForeColor = System.Drawing.Color.White;
            this.selectedFood.Location = new System.Drawing.Point(148, 16);
            this.selectedFood.Name = "selectedFood";
            this.selectedFood.Size = new System.Drawing.Size(44, 19);
            this.selectedFood.TabIndex = 7;
            this.selectedFood.Text = "-----";
            // 
            // mealName4
            // 
            this.mealName4.AutoSize = true;
            this.mealName4.BackColor = System.Drawing.Color.Transparent;
            this.mealName4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealName4.ForeColor = System.Drawing.Color.White;
            this.mealName4.Location = new System.Drawing.Point(70, 124);
            this.mealName4.Name = "mealName4";
            this.mealName4.Size = new System.Drawing.Size(192, 33);
            this.mealName4.TabIndex = 4;
            this.mealName4.Text = "Amount Due:";
            this.mealName4.Click += new System.EventHandler(this.mealName4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(28, 8);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 51);
            this.button6.TabIndex = 55;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(110, 571);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 162);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(298, 571);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 162);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedPrice
            // 
            this.selectedPrice.AutoSize = true;
            this.selectedPrice.BackColor = System.Drawing.Color.Transparent;
            this.selectedPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPrice.ForeColor = System.Drawing.Color.White;
            this.selectedPrice.Location = new System.Drawing.Point(148, 46);
            this.selectedPrice.Name = "selectedPrice";
            this.selectedPrice.Size = new System.Drawing.Size(44, 19);
            this.selectedPrice.TabIndex = 8;
            this.selectedPrice.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Food Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mealName4);
            this.panel1.Controls.Add(this.TotalAll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.selectedPrice);
            this.panel1.Controls.Add(this.selectedFood);
            this.panel1.Location = new System.Drawing.Point(558, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 175);
            this.panel1.TabIndex = 73;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(203)))), ((int)(((byte)(58)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::StudentSession.Properties.Resources.edit__2_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(271, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 51);
            this.button3.TabIndex = 73;
            this.button3.Text = "Edit Order";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OrderingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.CrazyKart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.OrderingCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CrazyKart)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CrazyKart;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label mealName4;
        private System.Windows.Forms.Button btnRemoveFromKart;
        private System.Windows.Forms.Label selectedFood;
        private System.Windows.Forms.Button btnUpdateKart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MinusQuantity;
        private System.Windows.Forms.TextBox QuantityToBuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalAll;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button FinishNa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label selectedPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PlusQuantity;
    }
}