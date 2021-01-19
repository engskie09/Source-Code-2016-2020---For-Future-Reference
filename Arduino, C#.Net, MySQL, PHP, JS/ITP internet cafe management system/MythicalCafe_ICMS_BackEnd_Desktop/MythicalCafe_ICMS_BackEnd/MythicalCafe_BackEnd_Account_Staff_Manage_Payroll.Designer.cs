namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Account_Staff_Manage_Payroll
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
            this.dgv_Account_Attendance = new System.Windows.Forms.DataGridView();
            this.Attendance_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance_DateTime_In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance_DateTime_Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Salary_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dp_DateTime_In_To = new Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dp_DateTime_In_From = new Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker();
            this.lbl_getAction = new System.Windows.Forms.Label();
            this.btn_DateTime_Select = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Payroll_Generate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Salary_Net = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.txtbx_Deduction = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account_Attendance)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Account_Attendance
            // 
            this.dgv_Account_Attendance.AllowUserToAddRows = false;
            this.dgv_Account_Attendance.AllowUserToDeleteRows = false;
            this.dgv_Account_Attendance.AllowUserToResizeColumns = false;
            this.dgv_Account_Attendance.AllowUserToResizeRows = false;
            this.dgv_Account_Attendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account_Attendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account_Attendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Account_Attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account_Attendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attendance_Identity,
            this.Attendance_DateTime_In,
            this.Attendance_DateTime_Out,
            this.Staff_Salary_Amount});
            this.dgv_Account_Attendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Account_Attendance.Location = new System.Drawing.Point(3, 50);
            this.dgv_Account_Attendance.Name = "dgv_Account_Attendance";
            this.dgv_Account_Attendance.ReadOnly = true;
            this.dgv_Account_Attendance.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Account_Attendance.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Account_Attendance.RowTemplate.Height = 80;
            this.dgv_Account_Attendance.Size = new System.Drawing.Size(471, 415);
            this.dgv_Account_Attendance.TabIndex = 1;
            // 
            // Attendance_Identity
            // 
            this.Attendance_Identity.HeaderText = "Attendance_Identity";
            this.Attendance_Identity.Name = "Attendance_Identity";
            this.Attendance_Identity.ReadOnly = true;
            this.Attendance_Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Attendance_Identity.Visible = false;
            // 
            // Attendance_DateTime_In
            // 
            this.Attendance_DateTime_In.HeaderText = "Date Time In";
            this.Attendance_DateTime_In.Name = "Attendance_DateTime_In";
            this.Attendance_DateTime_In.ReadOnly = true;
            this.Attendance_DateTime_In.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Attendance_DateTime_Out
            // 
            this.Attendance_DateTime_Out.HeaderText = "Date Time Out";
            this.Attendance_DateTime_Out.Name = "Attendance_DateTime_Out";
            this.Attendance_DateTime_Out.ReadOnly = true;
            this.Attendance_DateTime_Out.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Staff_Salary_Amount
            // 
            this.Staff_Salary_Amount.HeaderText = "Salary";
            this.Staff_Salary_Amount.Name = "Staff_Salary_Amount";
            this.Staff_Salary_Amount.ReadOnly = true;
            this.Staff_Salary_Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Account_Attendance, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.14235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.85765F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 468);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_DateTime_Select, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(680, 41);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.Controls.Add(this.dp_DateTime_In_To, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(207, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(198, 35);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // dp_DateTime_In_To
            // 
            this.dp_DateTime_In_To.AllowDrop = true;
            this.dp_DateTime_In_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_To.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dp_DateTime_In_To.BinaryCultureInfo = new System.Globalization.CultureInfo("en-US");
            this.dp_DateTime_In_To.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_To.CalendarForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.CalendarInactiveDateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_To.CalendarLegendDisplay = false;
            this.dp_DateTime_In_To.CalendarMonthAndYearTrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_To.CalendarMonthBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_To.CalendarMonthTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_To.CalenderDropDownArrowGlassRenderingColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_To.CalenderDropDownGlassRenderingEndColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.CalenderDropDownGlassRenderingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_To.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_To.CloseButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_In_To.CloseButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.CloseButtonText = "Close";
            this.dp_DateTime_In_To.CustomDateXMLFeed = "";
            this.dp_DateTime_In_To.CustomDropDownImage = null;
            this.dp_DateTime_In_To.CustomFormat = "d";
            this.dp_DateTime_In_To.DisplayTextState = true;
            this.dp_DateTime_In_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dp_DateTime_In_To.DotBorderDepth = 4;
            this.dp_DateTime_In_To.DotBorderGap = 10;
            this.dp_DateTime_In_To.DrawBorderAs = Binarymission.WinForms.Controls.DateTimeControls.BorderState.Normal;
            this.dp_DateTime_In_To.DropWindowIsShowing = true;
            this.dp_DateTime_In_To.EnableCustomDateXMLFeed = false;
            this.dp_DateTime_In_To.Font = new System.Drawing.Font("Georgia", 12F);
            this.dp_DateTime_In_To.ForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.Format = Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePickerFormat.Custom;
            this.dp_DateTime_In_To.HostedFromChildContainer = false;
            this.dp_DateTime_In_To.IsReadOnly = false;
            this.dp_DateTime_In_To.Location = new System.Drawing.Point(73, 4);
            this.dp_DateTime_In_To.Margin = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_In_To.MarkSelectedDate = true;
            this.dp_DateTime_In_To.MaxValue = new System.DateTime(9999, 12, 31, 18, 40, 16, 180);
            this.dp_DateTime_In_To.MinValue = new System.DateTime(1, 2, 1, 18, 40, 16, 180);
            this.dp_DateTime_In_To.Name = "dp_DateTime_In_To";
            this.dp_DateTime_In_To.NullDateString = "";
            this.dp_DateTime_In_To.Padding = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_In_To.RenderDropDownButtonWithVisualStyles = true;
            this.dp_DateTime_In_To.SelectionDateEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_To.SelectionDateForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.ShowBorderAlways = true;
            this.dp_DateTime_In_To.ShowCustomMenu = true;
            this.dp_DateTime_In_To.ShowDropDownCalendarWindowAfterAdjustingForVirtualAvaliableScreenSpace = false;
            this.dp_DateTime_In_To.ShowPopupOnEnter = true;
            this.dp_DateTime_In_To.Size = new System.Drawing.Size(121, 26);
            this.dp_DateTime_In_To.SpecialDates = new System.DateTime[0];
            this.dp_DateTime_In_To.SpecialDatesFillColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.SpecialDatesForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.TabIndex = 13;
            this.dp_DateTime_In_To.TabStop = false;
            this.dp_DateTime_In_To.TodayButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_To.TodayButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_In_To.TodayButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.TodayButtonText = "Max";
            this.dp_DateTime_In_To.TodayCloseButtonsAreVisible = true;
            this.dp_DateTime_In_To.TodayEllipseColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.TodayForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_To.UseDropDownImageStyle = Binarymission.WinForms.Controls.DateTimeControls.DropDownImageStyle.GlassRendering;
            this.dp_DateTime_In_To.Value = new System.DateTime(2019, 11, 4, 18, 40, 16, 180);
            this.dp_DateTime_In_To.ValueIsNull = false;
            this.dp_DateTime_In_To.TextChanged += new System.EventHandler(this.set_dp_DateTime_In_Validation);
            this.dp_DateTime_In_To.MouseCaptureChanged += new System.EventHandler(this.set_dp_DateTime_In_Validation);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "To :";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Controls.Add(this.dp_DateTime_In_From, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_getAction, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(198, 35);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dp_DateTime_In_From
            // 
            this.dp_DateTime_In_From.AllowDrop = true;
            this.dp_DateTime_In_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_From.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dp_DateTime_In_From.BinaryCultureInfo = new System.Globalization.CultureInfo("en-US");
            this.dp_DateTime_In_From.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_From.CalendarForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.CalendarInactiveDateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_From.CalendarLegendDisplay = false;
            this.dp_DateTime_In_From.CalendarMonthAndYearTrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_From.CalendarMonthBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_From.CalendarMonthTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_From.CalenderDropDownArrowGlassRenderingColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_From.CalenderDropDownGlassRenderingEndColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.CalenderDropDownGlassRenderingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_From.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_From.CloseButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_In_From.CloseButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.CloseButtonText = "Close";
            this.dp_DateTime_In_From.CustomDateXMLFeed = "";
            this.dp_DateTime_In_From.CustomDropDownImage = null;
            this.dp_DateTime_In_From.CustomFormat = "d";
            this.dp_DateTime_In_From.DisplayTextState = true;
            this.dp_DateTime_In_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dp_DateTime_In_From.DotBorderDepth = 4;
            this.dp_DateTime_In_From.DotBorderGap = 10;
            this.dp_DateTime_In_From.DrawBorderAs = Binarymission.WinForms.Controls.DateTimeControls.BorderState.Normal;
            this.dp_DateTime_In_From.DropWindowIsShowing = true;
            this.dp_DateTime_In_From.EnableCustomDateXMLFeed = false;
            this.dp_DateTime_In_From.Font = new System.Drawing.Font("Georgia", 12F);
            this.dp_DateTime_In_From.ForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.Format = Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePickerFormat.Custom;
            this.dp_DateTime_In_From.HostedFromChildContainer = false;
            this.dp_DateTime_In_From.IsReadOnly = false;
            this.dp_DateTime_In_From.Location = new System.Drawing.Point(73, 4);
            this.dp_DateTime_In_From.Margin = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_In_From.MarkSelectedDate = true;
            this.dp_DateTime_In_From.MaxValue = new System.DateTime(9999, 12, 31, 18, 40, 16, 203);
            this.dp_DateTime_In_From.MinValue = new System.DateTime(1, 2, 1, 18, 40, 16, 203);
            this.dp_DateTime_In_From.Name = "dp_DateTime_In_From";
            this.dp_DateTime_In_From.NullDateString = "";
            this.dp_DateTime_In_From.Padding = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_In_From.RenderDropDownButtonWithVisualStyles = true;
            this.dp_DateTime_In_From.SelectionDateEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_In_From.SelectionDateForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.ShowBorderAlways = true;
            this.dp_DateTime_In_From.ShowCustomMenu = true;
            this.dp_DateTime_In_From.ShowDropDownCalendarWindowAfterAdjustingForVirtualAvaliableScreenSpace = false;
            this.dp_DateTime_In_From.ShowPopupOnEnter = true;
            this.dp_DateTime_In_From.Size = new System.Drawing.Size(121, 26);
            this.dp_DateTime_In_From.SpecialDates = new System.DateTime[0];
            this.dp_DateTime_In_From.SpecialDatesFillColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.SpecialDatesForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.TabIndex = 13;
            this.dp_DateTime_In_From.TabStop = false;
            this.dp_DateTime_In_From.TodayButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_In_From.TodayButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_In_From.TodayButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.TodayButtonText = "Max";
            this.dp_DateTime_In_From.TodayCloseButtonsAreVisible = true;
            this.dp_DateTime_In_From.TodayEllipseColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.TodayForeColor = System.Drawing.Color.White;
            this.dp_DateTime_In_From.UseDropDownImageStyle = Binarymission.WinForms.Controls.DateTimeControls.DropDownImageStyle.GlassRendering;
            this.dp_DateTime_In_From.Value = new System.DateTime(2019, 11, 4, 18, 40, 16, 203);
            this.dp_DateTime_In_From.ValueIsNull = false;
            this.dp_DateTime_In_From.TextChanged += new System.EventHandler(this.set_dp_DateTime_In_Validation);
            this.dp_DateTime_In_From.MouseCaptureChanged += new System.EventHandler(this.set_dp_DateTime_In_Validation);
            // 
            // lbl_getAction
            // 
            this.lbl_getAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_getAction.AutoSize = true;
            this.lbl_getAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_getAction.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_getAction.ForeColor = System.Drawing.Color.White;
            this.lbl_getAction.Location = new System.Drawing.Point(6, 8);
            this.lbl_getAction.Name = "lbl_getAction";
            this.lbl_getAction.Size = new System.Drawing.Size(56, 18);
            this.lbl_getAction.TabIndex = 14;
            this.lbl_getAction.Text = "From :";
            // 
            // btn_DateTime_Select
            // 
            this.btn_DateTime_Select.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DateTime_Select.BorderRadius = 0;
            this.btn_DateTime_Select.ButtonText = "Select Date";
            this.btn_DateTime_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DateTime_Select.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DateTime_Select.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_DateTime_Select.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_DateTime_Select.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_DateTime_Select.Iconimage = null;
            this.btn_DateTime_Select.Iconimage_right = null;
            this.btn_DateTime_Select.Iconimage_right_Selected = null;
            this.btn_DateTime_Select.Iconimage_Selected = null;
            this.btn_DateTime_Select.IconMarginLeft = 0;
            this.btn_DateTime_Select.IconMarginRight = 0;
            this.btn_DateTime_Select.IconRightVisible = true;
            this.btn_DateTime_Select.IconRightZoom = 0D;
            this.btn_DateTime_Select.IconVisible = true;
            this.btn_DateTime_Select.IconZoom = 90D;
            this.btn_DateTime_Select.IsTab = false;
            this.btn_DateTime_Select.Location = new System.Drawing.Point(412, 4);
            this.btn_DateTime_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DateTime_Select.Name = "btn_DateTime_Select";
            this.btn_DateTime_Select.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DateTime_Select.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DateTime_Select.selected = false;
            this.btn_DateTime_Select.Size = new System.Drawing.Size(139, 33);
            this.btn_DateTime_Select.TabIndex = 25;
            this.btn_DateTime_Select.Text = "Select Date";
            this.btn_DateTime_Select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DateTime_Select.Textcolor = System.Drawing.Color.White;
            this.btn_DateTime_Select.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_DateTime_Select.Click += new System.EventHandler(this.btn_DateTime_Select_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Payroll_Generate, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(480, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.54217F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.71084F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.60241F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.90361F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(203, 415);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btn_Payroll_Generate
            // 
            this.btn_Payroll_Generate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Payroll_Generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Payroll_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Payroll_Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Payroll_Generate.BorderRadius = 0;
            this.btn_Payroll_Generate.ButtonText = "Generate Payroll";
            this.btn_Payroll_Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Payroll_Generate.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Payroll_Generate.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Payroll_Generate.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Payroll_Generate.Iconimage = null;
            this.btn_Payroll_Generate.Iconimage_right = null;
            this.btn_Payroll_Generate.Iconimage_right_Selected = null;
            this.btn_Payroll_Generate.Iconimage_Selected = null;
            this.btn_Payroll_Generate.IconMarginLeft = 0;
            this.btn_Payroll_Generate.IconMarginRight = 0;
            this.btn_Payroll_Generate.IconRightVisible = true;
            this.btn_Payroll_Generate.IconRightZoom = 0D;
            this.btn_Payroll_Generate.IconVisible = true;
            this.btn_Payroll_Generate.IconZoom = 90D;
            this.btn_Payroll_Generate.IsTab = false;
            this.btn_Payroll_Generate.Location = new System.Drawing.Point(32, 358);
            this.btn_Payroll_Generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Payroll_Generate.Name = "btn_Payroll_Generate";
            this.btn_Payroll_Generate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Payroll_Generate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Payroll_Generate.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Payroll_Generate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Payroll_Generate.selected = false;
            this.btn_Payroll_Generate.Size = new System.Drawing.Size(139, 46);
            this.btn_Payroll_Generate.TabIndex = 24;
            this.btn_Payroll_Generate.Text = "Generate Payroll";
            this.btn_Payroll_Generate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Payroll_Generate.Textcolor = System.Drawing.Color.White;
            this.btn_Payroll_Generate.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Payroll_Generate.Click += new System.EventHandler(this.btn_Payroll_Generate_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.lbl_Salary_Net, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbl_Salary, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtbx_Deduction, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 109);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(197, 192);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // lbl_Salary_Net
            // 
            this.lbl_Salary_Net.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Salary_Net.AutoSize = true;
            this.lbl_Salary_Net.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Salary_Net.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_Salary_Net.ForeColor = System.Drawing.Color.White;
            this.lbl_Salary_Net.Location = new System.Drawing.Point(47, 151);
            this.lbl_Salary_Net.Name = "lbl_Salary_Net";
            this.lbl_Salary_Net.Size = new System.Drawing.Size(102, 18);
            this.lbl_Salary_Net.TabIndex = 27;
            this.lbl_Salary_Net.Text = "Net Salary: 0";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Salary.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_Salary.ForeColor = System.Drawing.Color.White;
            this.lbl_Salary.Location = new System.Drawing.Point(62, 23);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(72, 18);
            this.lbl_Salary.TabIndex = 26;
            this.lbl_Salary.Text = "Salary: 0";
            // 
            // txtbx_Deduction
            // 
            this.txtbx_Deduction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbx_Deduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Deduction.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Deduction.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Deduction.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Deduction.BorderThickness = 3;
            this.txtbx_Deduction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Deduction.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Deduction.ForeColor = System.Drawing.Color.White;
            this.txtbx_Deduction.isPassword = false;
            this.txtbx_Deduction.Location = new System.Drawing.Point(21, 76);
            this.txtbx_Deduction.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Deduction.Name = "txtbx_Deduction";
            this.txtbx_Deduction.Size = new System.Drawing.Size(154, 39);
            this.txtbx_Deduction.TabIndex = 25;
            this.txtbx_Deduction.Text = "Deduction";
            this.txtbx_Deduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_Deduction.OnValueChanged += new System.EventHandler(this.txtbx_Deduction_OnValueChanged);
            // 
            // MythicalCafe_BackEnd_Account_Staff_Manage_Payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Account_Staff_Manage_Payroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Account_Staff_Manage_Payroll";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Account_Staff_Manage_Payroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account_Attendance)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Account_Attendance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance_DateTime_In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance_DateTime_Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Salary_Amount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Payroll_Generate;
        private Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker dp_DateTime_In_From;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_getAction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker dp_DateTime_In_To;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DateTime_Select;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Deduction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lbl_Salary_Net;
        private System.Windows.Forms.Label lbl_Salary;
    }
}