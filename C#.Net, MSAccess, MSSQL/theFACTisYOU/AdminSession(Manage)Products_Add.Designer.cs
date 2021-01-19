namespace theFACTisYOU
{
    partial class AdminSession_Manage_Products_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSession_Manage_Products_add));
            this.panel3 = new System.Windows.Forms.Panel();
            this.QuantityProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.piktyur = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Category_Select = new System.Windows.Forms.ComboBox();
            this.Cost_Input = new System.Windows.Forms.TextBox();
            this.Description_Input = new System.Windows.Forms.TextBox();
            this.Name_Input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timexD = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piktyur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.panel3.Controls.Add(this.QuantityProduct);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.piktyur);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.Category_Select);
            this.panel3.Controls.Add(this.Cost_Input);
            this.panel3.Controls.Add(this.Description_Input);
            this.panel3.Controls.Add(this.Name_Input);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(335, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 559);
            this.panel3.TabIndex = 10;
            this.panel3.Tag = "";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // QuantityProduct
            // 
            this.QuantityProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.QuantityProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.QuantityProduct.Location = new System.Drawing.Point(223, 406);
            this.QuantityProduct.MaxLength = 3;
            this.QuantityProduct.Multiline = true;
            this.QuantityProduct.Name = "QuantityProduct";
            this.QuantityProduct.Size = new System.Drawing.Size(55, 28);
            this.QuantityProduct.TabIndex = 23;
            this.QuantityProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityProduct_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.label6.Location = new System.Drawing.Point(16, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quantity on Hand";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.button2.Location = new System.Drawing.Point(97, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 21;
            this.button2.Text = "Upload Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // piktyur
            // 
            this.piktyur.Location = new System.Drawing.Point(223, 176);
            this.piktyur.Name = "piktyur";
            this.piktyur.Size = new System.Drawing.Size(233, 196);
            this.piktyur.TabIndex = 20;
            this.piktyur.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.button3.Location = new System.Drawing.Point(223, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 38);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Category_Select
            // 
            this.Category_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.Category_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Category_Select.FormattingEnabled = true;
            this.Category_Select.Location = new System.Drawing.Point(223, 82);
            this.Category_Select.Name = "Category_Select";
            this.Category_Select.Size = new System.Drawing.Size(233, 33);
            this.Category_Select.TabIndex = 14;
            // 
            // Cost_Input
            // 
            this.Cost_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.Cost_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Cost_Input.Location = new System.Drawing.Point(223, 451);
            this.Cost_Input.MaxLength = 5;
            this.Cost_Input.Multiline = true;
            this.Cost_Input.Name = "Cost_Input";
            this.Cost_Input.Size = new System.Drawing.Size(100, 28);
            this.Cost_Input.TabIndex = 13;
            this.Cost_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cost_Input_KeyPress);
            // 
            // Description_Input
            // 
            this.Description_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.Description_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Description_Input.Location = new System.Drawing.Point(223, 123);
            this.Description_Input.MaxLength = 50;
            this.Description_Input.Multiline = true;
            this.Description_Input.Name = "Description_Input";
            this.Description_Input.Size = new System.Drawing.Size(233, 47);
            this.Description_Input.TabIndex = 12;
            // 
            // Name_Input
            // 
            this.Name_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.Name_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Name_Input.Location = new System.Drawing.Point(223, 42);
            this.Name_Input.MaxLength = 15;
            this.Name_Input.Multiline = true;
            this.Name_Input.Name = "Name_Input";
            this.Name_Input.Size = new System.Drawing.Size(233, 28);
            this.Name_Input.TabIndex = 10;
            this.Name_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Input_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(145, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.label4.Location = new System.Drawing.Point(73, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(148)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hi (Admin Name)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 145);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 253);
            this.panel2.TabIndex = 9;
            this.panel2.Tag = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(121)))), ((int)(((byte)(147)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(19)))), ((int)(((byte)(30)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "<------";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminSession_Manage_Products_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "AdminSession_Manage_Products_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSession(Manage)Products_Add";
            this.Load += new System.EventHandler(this.AdminSession_Manage_Products_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piktyur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Category_Select;
        private System.Windows.Forms.TextBox Cost_Input;
        private System.Windows.Forms.TextBox Description_Input;
        private System.Windows.Forms.TextBox Name_Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox piktyur;
        private System.Windows.Forms.TextBox QuantityProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timexD;
        
    }
}