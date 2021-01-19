namespace CanteenKiosk
{
    partial class AddcartBF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddcartBF));
            this.PlusQuantity = new System.Windows.Forms.Button();
            this.MinusQuantity = new System.Windows.Forms.Button();
            this.AddtoCrazyKart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderPrice = new System.Windows.Forms.Label();
            this.QuantityToBuy = new System.Windows.Forms.TextBox();
            this.OrderPicture = new System.Windows.Forms.PictureBox();
            this.OrderName = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.Availability = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PlusQuantity
            // 
            this.PlusQuantity.BackColor = System.Drawing.Color.Chartreuse;
            this.PlusQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlusQuantity.FlatAppearance.BorderSize = 0;
            this.PlusQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusQuantity.ForeColor = System.Drawing.Color.White;
            this.PlusQuantity.Location = new System.Drawing.Point(231, 319);
            this.PlusQuantity.Name = "PlusQuantity";
            this.PlusQuantity.Size = new System.Drawing.Size(69, 65);
            this.PlusQuantity.TabIndex = 11;
            this.PlusQuantity.Text = "+";
            this.PlusQuantity.UseVisualStyleBackColor = false;
            this.PlusQuantity.Click += new System.EventHandler(this.PlusQuantity_Click);
            // 
            // MinusQuantity
            // 
            this.MinusQuantity.BackColor = System.Drawing.Color.Red;
            this.MinusQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinusQuantity.FlatAppearance.BorderSize = 0;
            this.MinusQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusQuantity.ForeColor = System.Drawing.Color.White;
            this.MinusQuantity.Location = new System.Drawing.Point(39, 319);
            this.MinusQuantity.Name = "MinusQuantity";
            this.MinusQuantity.Size = new System.Drawing.Size(69, 65);
            this.MinusQuantity.TabIndex = 9;
            this.MinusQuantity.Text = "-";
            this.MinusQuantity.UseVisualStyleBackColor = false;
            this.MinusQuantity.Click += new System.EventHandler(this.MinusQuantity_Click);
            // 
            // AddtoCrazyKart
            // 
            this.AddtoCrazyKart.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddtoCrazyKart.FlatAppearance.BorderSize = 0;
            this.AddtoCrazyKart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddtoCrazyKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoCrazyKart.ForeColor = System.Drawing.Color.White;
            this.AddtoCrazyKart.Image = global::StudentSession.Properties.Resources.cart__1_;
            this.AddtoCrazyKart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddtoCrazyKart.Location = new System.Drawing.Point(40, 470);
            this.AddtoCrazyKart.Name = "AddtoCrazyKart";
            this.AddtoCrazyKart.Size = new System.Drawing.Size(256, 73);
            this.AddtoCrazyKart.TabIndex = 13;
            this.AddtoCrazyKart.Text = "Add to Tray";
            this.AddtoCrazyKart.UseVisualStyleBackColor = false;
            this.AddtoCrazyKart.Click += new System.EventHandler(this.AddtoCrazyKart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.OrderPrice);
            this.panel1.Location = new System.Drawing.Point(40, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 66);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::StudentSession.Properties.Resources.philippines_peso_currency_symbol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // OrderPrice
            // 
            this.OrderPrice.AutoSize = true;
            this.OrderPrice.BackColor = System.Drawing.Color.Transparent;
            this.OrderPrice.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderPrice.ForeColor = System.Drawing.Color.White;
            this.OrderPrice.Location = new System.Drawing.Point(133, 16);
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.Size = new System.Drawing.Size(37, 37);
            this.OrderPrice.TabIndex = 1;
            this.OrderPrice.Text = "0";
            // 
            // QuantityToBuy
            // 
            this.QuantityToBuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityToBuy.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityToBuy.Location = new System.Drawing.Point(96, 319);
            this.QuantityToBuy.Name = "QuantityToBuy";
            this.QuantityToBuy.ReadOnly = true;
            this.QuantityToBuy.Size = new System.Drawing.Size(147, 65);
            this.QuantityToBuy.TabIndex = 10;
            this.QuantityToBuy.Text = "1";
            this.QuantityToBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderPicture
            // 
            this.OrderPicture.Location = new System.Drawing.Point(60, 12);
            this.OrderPicture.Name = "OrderPicture";
            this.OrderPicture.Size = new System.Drawing.Size(216, 187);
            this.OrderPicture.TabIndex = 7;
            this.OrderPicture.TabStop = false;
            // 
            // OrderName
            // 
            this.OrderName.AutoSize = true;
            this.OrderName.BackColor = System.Drawing.Color.Transparent;
            this.OrderName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderName.ForeColor = System.Drawing.Color.White;
            this.OrderName.Location = new System.Drawing.Point(116, 218);
            this.OrderName.MaximumSize = new System.Drawing.Size(180, 50);
            this.OrderName.Name = "OrderName";
            this.OrderName.Size = new System.Drawing.Size(100, 19);
            this.OrderName.TabIndex = 14;
            this.OrderName.Text = "Food Name";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(300, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 32);
            this.button13.TabIndex = 16;
            this.button13.Text = "X";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(92, 288);
            this.label.MaximumSize = new System.Drawing.Size(180, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 19);
            this.label.TabIndex = 17;
            this.label.Text = "Availability:";
            // 
            // Availability
            // 
            this.Availability.AutoSize = true;
            this.Availability.BackColor = System.Drawing.Color.Transparent;
            this.Availability.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availability.ForeColor = System.Drawing.Color.White;
            this.Availability.Location = new System.Drawing.Point(199, 288);
            this.Availability.MaximumSize = new System.Drawing.Size(180, 50);
            this.Availability.Name = "Availability";
            this.Availability.Size = new System.Drawing.Size(44, 19);
            this.Availability.TabIndex = 18;
            this.Availability.Text = "-----";
            // 
            // AddcartBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(336, 565);
            this.Controls.Add(this.Availability);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.OrderName);
            this.Controls.Add(this.PlusQuantity);
            this.Controls.Add(this.MinusQuantity);
            this.Controls.Add(this.AddtoCrazyKart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuantityToBuy);
            this.Controls.Add(this.OrderPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddcartBF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddcartBF";
            this.Load += new System.EventHandler(this.AddcartBF_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusQuantity;
        private System.Windows.Forms.Button MinusQuantity;
        private System.Windows.Forms.Button AddtoCrazyKart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OrderPrice;
        private System.Windows.Forms.TextBox QuantityToBuy;
        private System.Windows.Forms.PictureBox OrderPicture;
        private System.Windows.Forms.Label OrderName;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Availability;
    }
}