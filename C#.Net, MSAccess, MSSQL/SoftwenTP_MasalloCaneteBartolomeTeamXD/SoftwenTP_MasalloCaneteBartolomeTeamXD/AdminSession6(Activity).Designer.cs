namespace SoftwenTP_MasalloCaneteBartolomeTeamXD
{
    partial class AdminSession6_Activity_
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
            this.PanelActivitylist = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmActivityname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivitycategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivitytrainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelActivitylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelActivitylist
            // 
            this.PanelActivitylist.Controls.Add(this.dataGridView1);
            this.PanelActivitylist.Controls.Add(this.label1);
            this.PanelActivitylist.Controls.Add(this.textBox1);
            this.PanelActivitylist.Controls.Add(this.label2);
            this.PanelActivitylist.Location = new System.Drawing.Point(12, 35);
            this.PanelActivitylist.Name = "PanelActivitylist";
            this.PanelActivitylist.Size = new System.Drawing.Size(588, 604);
            this.PanelActivitylist.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmActivityname,
            this.clmActivitycategory,
            this.clmActivitytrainer,
            this.clmAction});
            this.dataGridView1.Location = new System.Drawing.Point(17, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(562, 542);
            this.dataGridView1.TabIndex = 17;
            // 
            // clmActivityname
            // 
            this.clmActivityname.HeaderText = "Activity Name";
            this.clmActivityname.Name = "clmActivityname";
            this.clmActivityname.ReadOnly = true;
            // 
            // clmActivitycategory
            // 
            this.clmActivitycategory.HeaderText = "Activity Category";
            this.clmActivitycategory.Name = "clmActivitycategory";
            this.clmActivitycategory.ReadOnly = true;
            // 
            // clmActivitytrainer
            // 
            this.clmActivitytrainer.HeaderText = "Activity Trainer";
            this.clmActivitytrainer.Name = "clmActivitytrainer";
            this.clmActivitytrainer.ReadOnly = true;
            // 
            // clmAction
            // 
            this.clmAction.HeaderText = "Action";
            this.clmAction.Name = "clmAction";
            this.clmAction.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Activity List";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.textBox1.Location = new System.Drawing.Point(437, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 33);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F);
            this.label2.Location = new System.Drawing.Point(349, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Search:";
            // 
            // AdminSession6_Activity_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(599, 683);
            this.Controls.Add(this.PanelActivitylist);
            this.Name = "AdminSession6_Activity_";
            this.Text = "Gym Senpaaaaaaaaai!";
            this.Load += new System.EventHandler(this.AdminSession6_Activity__Load);
            this.PanelActivitylist.ResumeLayout(false);
            this.PanelActivitylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelActivitylist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivityname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivitycategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivitytrainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;

    }
}