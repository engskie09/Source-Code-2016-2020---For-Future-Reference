namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Log_List
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
            this.rv_Log = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dp_DateTime_To = new Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dp_DateTime_From = new Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker();
            this.lbl_getAction = new System.Windows.Forms.Label();
            this.btn_DateTime_Select = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Log = new System.Windows.Forms.DataGridView();
            this.Log_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log_DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Log_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_Arrow = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_Log
            // 
            this.rv_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_Log.DocumentMapWidth = 1;
            this.rv_Log.LocalReport.ReportEmbeddedResource = "MythicalCafe_ICMS_BackEnd.MythicalCafe_BackEnd_Log_List.rdlc";
            this.rv_Log.Location = new System.Drawing.Point(677, 45);
            this.rv_Log.Name = "rv_Log";
            this.rv_Log.ServerReport.BearerToken = null;
            this.rv_Log.Size = new System.Drawing.Size(1, 520);
            this.rv_Log.TabIndex = 27;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 36);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.Controls.Add(this.dp_DateTime_To, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(194, 30);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // dp_DateTime_To
            // 
            this.dp_DateTime_To.AllowDrop = true;
            this.dp_DateTime_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_To.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dp_DateTime_To.BinaryCultureInfo = new System.Globalization.CultureInfo("en-US");
            this.dp_DateTime_To.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_To.CalendarForeColor = System.Drawing.Color.White;
            this.dp_DateTime_To.CalendarInactiveDateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_To.CalendarLegendDisplay = false;
            this.dp_DateTime_To.CalendarMonthAndYearTrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_To.CalendarMonthBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_To.CalendarMonthTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_To.CalenderDropDownArrowGlassRenderingColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_To.CalenderDropDownGlassRenderingEndColor = System.Drawing.Color.White;
            this.dp_DateTime_To.CalenderDropDownGlassRenderingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_To.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_To.CloseButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_To.CloseButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_To.CloseButtonText = "Close";
            this.dp_DateTime_To.CustomDateXMLFeed = "";
            this.dp_DateTime_To.CustomDropDownImage = null;
            this.dp_DateTime_To.CustomFormat = "d";
            this.dp_DateTime_To.DisplayTextState = true;
            this.dp_DateTime_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dp_DateTime_To.DotBorderDepth = 4;
            this.dp_DateTime_To.DotBorderGap = 10;
            this.dp_DateTime_To.DrawBorderAs = Binarymission.WinForms.Controls.DateTimeControls.BorderState.Normal;
            this.dp_DateTime_To.DropWindowIsShowing = true;
            this.dp_DateTime_To.EnableCustomDateXMLFeed = false;
            this.dp_DateTime_To.Font = new System.Drawing.Font("Georgia", 12F);
            this.dp_DateTime_To.ForeColor = System.Drawing.Color.White;
            this.dp_DateTime_To.Format = Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePickerFormat.Custom;
            this.dp_DateTime_To.HostedFromChildContainer = false;
            this.dp_DateTime_To.IsReadOnly = false;
            this.dp_DateTime_To.Location = new System.Drawing.Point(71, 4);
            this.dp_DateTime_To.Margin = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_To.MarkSelectedDate = true;
            this.dp_DateTime_To.MaxValue = new System.DateTime(9999, 12, 31, 8, 15, 23, 538);
            this.dp_DateTime_To.MinValue = new System.DateTime(1, 2, 1, 8, 15, 23, 538);
            this.dp_DateTime_To.Name = "dp_DateTime_To";
            this.dp_DateTime_To.NullDateString = "";
            this.dp_DateTime_To.Padding = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_To.RenderDropDownButtonWithVisualStyles = true;
            this.dp_DateTime_To.SelectionDateEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_To.SelectionDateForeColor = System.Drawing.Color.White;
            this.dp_DateTime_To.ShowBorderAlways = true;
            this.dp_DateTime_To.ShowCustomMenu = true;
            this.dp_DateTime_To.ShowDropDownCalendarWindowAfterAdjustingForVirtualAvaliableScreenSpace = false;
            this.dp_DateTime_To.ShowPopupOnEnter = true;
            this.dp_DateTime_To.Size = new System.Drawing.Size(119, 26);
            this.dp_DateTime_To.SpecialDates = new System.DateTime[0];
            this.dp_DateTime_To.SpecialDatesFillColor = System.Drawing.Color.White;
            this.dp_DateTime_To.SpecialDatesForeColor = System.Drawing.Color.White;
            this.dp_DateTime_To.TabIndex = 13;
            this.dp_DateTime_To.TabStop = false;
            this.dp_DateTime_To.TodayButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_To.TodayButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_To.TodayButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_To.TodayButtonText = "Max";
            this.dp_DateTime_To.TodayCloseButtonsAreVisible = true;
            this.dp_DateTime_To.TodayEllipseColor = System.Drawing.Color.White;
            this.dp_DateTime_To.TodayForeColor = System.Drawing.Color.White;
            this.dp_DateTime_To.UseDropDownImageStyle = Binarymission.WinForms.Controls.DateTimeControls.DropDownImageStyle.GlassRendering;
            this.dp_DateTime_To.Value = new System.DateTime(2019, 11, 5, 8, 15, 23, 538);
            this.dp_DateTime_To.ValueIsNull = false;
            this.dp_DateTime_To.TextChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
            this.dp_DateTime_To.MouseCaptureChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 6);
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
            this.tableLayoutPanel4.Controls.Add(this.dp_DateTime_From, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_getAction, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 30);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dp_DateTime_From
            // 
            this.dp_DateTime_From.AllowDrop = true;
            this.dp_DateTime_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_From.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dp_DateTime_From.BinaryCultureInfo = new System.Globalization.CultureInfo("en-US");
            this.dp_DateTime_From.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_From.CalendarForeColor = System.Drawing.Color.White;
            this.dp_DateTime_From.CalendarInactiveDateForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_From.CalendarLegendDisplay = false;
            this.dp_DateTime_From.CalendarMonthAndYearTrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_From.CalendarMonthBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_From.CalendarMonthTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_From.CalenderDropDownArrowGlassRenderingColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_From.CalenderDropDownGlassRenderingEndColor = System.Drawing.Color.White;
            this.dp_DateTime_From.CalenderDropDownGlassRenderingStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_From.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_From.CloseButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_From.CloseButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_From.CloseButtonText = "Close";
            this.dp_DateTime_From.CustomDateXMLFeed = "";
            this.dp_DateTime_From.CustomDropDownImage = null;
            this.dp_DateTime_From.CustomFormat = "d";
            this.dp_DateTime_From.DisplayTextState = true;
            this.dp_DateTime_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dp_DateTime_From.DotBorderDepth = 4;
            this.dp_DateTime_From.DotBorderGap = 10;
            this.dp_DateTime_From.DrawBorderAs = Binarymission.WinForms.Controls.DateTimeControls.BorderState.Normal;
            this.dp_DateTime_From.DropWindowIsShowing = true;
            this.dp_DateTime_From.EnableCustomDateXMLFeed = false;
            this.dp_DateTime_From.Font = new System.Drawing.Font("Georgia", 12F);
            this.dp_DateTime_From.ForeColor = System.Drawing.Color.White;
            this.dp_DateTime_From.Format = Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePickerFormat.Custom;
            this.dp_DateTime_From.HostedFromChildContainer = false;
            this.dp_DateTime_From.IsReadOnly = false;
            this.dp_DateTime_From.Location = new System.Drawing.Point(71, 4);
            this.dp_DateTime_From.Margin = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_From.MarkSelectedDate = true;
            this.dp_DateTime_From.MaxValue = new System.DateTime(9999, 12, 31, 8, 15, 23, 556);
            this.dp_DateTime_From.MinValue = new System.DateTime(1, 2, 1, 8, 15, 23, 556);
            this.dp_DateTime_From.Name = "dp_DateTime_From";
            this.dp_DateTime_From.NullDateString = "";
            this.dp_DateTime_From.Padding = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_From.RenderDropDownButtonWithVisualStyles = true;
            this.dp_DateTime_From.SelectionDateEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.dp_DateTime_From.SelectionDateForeColor = System.Drawing.Color.White;
            this.dp_DateTime_From.ShowBorderAlways = true;
            this.dp_DateTime_From.ShowCustomMenu = true;
            this.dp_DateTime_From.ShowDropDownCalendarWindowAfterAdjustingForVirtualAvaliableScreenSpace = false;
            this.dp_DateTime_From.ShowPopupOnEnter = true;
            this.dp_DateTime_From.Size = new System.Drawing.Size(119, 26);
            this.dp_DateTime_From.SpecialDates = new System.DateTime[0];
            this.dp_DateTime_From.SpecialDatesFillColor = System.Drawing.Color.White;
            this.dp_DateTime_From.SpecialDatesForeColor = System.Drawing.Color.White;
            this.dp_DateTime_From.TabIndex = 13;
            this.dp_DateTime_From.TabStop = false;
            this.dp_DateTime_From.TodayButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.dp_DateTime_From.TodayButtonFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.dp_DateTime_From.TodayButtonForeColor = System.Drawing.Color.White;
            this.dp_DateTime_From.TodayButtonText = "Max";
            this.dp_DateTime_From.TodayCloseButtonsAreVisible = true;
            this.dp_DateTime_From.TodayEllipseColor = System.Drawing.Color.White;
            this.dp_DateTime_From.TodayForeColor = System.Drawing.Color.White;
            this.dp_DateTime_From.UseDropDownImageStyle = Binarymission.WinForms.Controls.DateTimeControls.DropDownImageStyle.GlassRendering;
            this.dp_DateTime_From.Value = new System.DateTime(2019, 11, 5, 8, 15, 23, 556);
            this.dp_DateTime_From.ValueIsNull = false;
            this.dp_DateTime_From.TextChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
            this.dp_DateTime_From.MouseCaptureChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
            // 
            // lbl_getAction
            // 
            this.lbl_getAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_getAction.AutoSize = true;
            this.lbl_getAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_getAction.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_getAction.ForeColor = System.Drawing.Color.White;
            this.lbl_getAction.Location = new System.Drawing.Point(5, 6);
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
            this.btn_DateTime_Select.Location = new System.Drawing.Point(404, 4);
            this.btn_DateTime_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DateTime_Select.Name = "btn_DateTime_Select";
            this.btn_DateTime_Select.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DateTime_Select.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DateTime_Select.selected = false;
            this.btn_DateTime_Select.Size = new System.Drawing.Size(139, 28);
            this.btn_DateTime_Select.TabIndex = 25;
            this.btn_DateTime_Select.Text = "Select Date";
            this.btn_DateTime_Select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DateTime_Select.Textcolor = System.Drawing.Color.White;
            this.btn_DateTime_Select.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_DateTime_Select.Click += new System.EventHandler(this.btn_DateTime_Select_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Print.BorderRadius = 0;
            this.btn_Print.ButtonText = "Print";
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Print.Font = new System.Drawing.Font("Georgia", 12F);
            this.btn_Print.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Print.Iconimage = null;
            this.btn_Print.Iconimage_right = null;
            this.btn_Print.Iconimage_right_Selected = null;
            this.btn_Print.Iconimage_Selected = null;
            this.btn_Print.IconMarginLeft = 0;
            this.btn_Print.IconMarginRight = 0;
            this.btn_Print.IconRightVisible = true;
            this.btn_Print.IconRightZoom = 0D;
            this.btn_Print.IconVisible = true;
            this.btn_Print.IconZoom = 90D;
            this.btn_Print.IsTab = false;
            this.btn_Print.Location = new System.Drawing.Point(267, 574);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_Print.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Print.selected = false;
            this.btn_Print.Size = new System.Drawing.Size(139, 34);
            this.btn_Print.TabIndex = 26;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Print.Textcolor = System.Drawing.Color.White;
            this.btn_Print.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Print, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Log, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rv_Log, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.394366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.60564F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 614);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgv_Log
            // 
            this.dgv_Log.AllowUserToAddRows = false;
            this.dgv_Log.AllowUserToDeleteRows = false;
            this.dgv_Log.AllowUserToResizeColumns = false;
            this.dgv_Log.AllowUserToResizeRows = false;
            this.dgv_Log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Log.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Log_Identity,
            this.Log_Type,
            this.Log_DateTime,
            this.User_Identity,
            this.Log_Description});
            this.dgv_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Log.Location = new System.Drawing.Point(3, 45);
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.ReadOnly = true;
            this.dgv_Log.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Log.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Log.RowTemplate.Height = 50;
            this.dgv_Log.Size = new System.Drawing.Size(668, 520);
            this.dgv_Log.TabIndex = 1;
            // 
            // Log_Identity
            // 
            this.Log_Identity.HeaderText = "Log_Identity";
            this.Log_Identity.Name = "Log_Identity";
            this.Log_Identity.ReadOnly = true;
            this.Log_Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Log_Identity.Visible = false;
            // 
            // Log_Type
            // 
            this.Log_Type.HeaderText = "Log_Type";
            this.Log_Type.Name = "Log_Type";
            this.Log_Type.ReadOnly = true;
            this.Log_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Log_Type.Visible = false;
            // 
            // Log_DateTime
            // 
            this.Log_DateTime.FillWeight = 106.599F;
            this.Log_DateTime.HeaderText = "Date Time";
            this.Log_DateTime.Name = "Log_DateTime";
            this.Log_DateTime.ReadOnly = true;
            this.Log_DateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // User_Identity
            // 
            this.User_Identity.FillWeight = 78.30001F;
            this.User_Identity.HeaderText = "ID";
            this.User_Identity.Name = "User_Identity";
            this.User_Identity.ReadOnly = true;
            this.User_Identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Log_Description
            // 
            this.Log_Description.FillWeight = 120.101F;
            this.Log_Description.HeaderText = "Description";
            this.Log_Description.Name = "Log_Description";
            this.Log_Description.ReadOnly = true;
            this.Log_Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // img_Arrow
            // 
            this.img_Arrow.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.img_Arrow.ImageSize = new System.Drawing.Size(16, 16);
            this.img_Arrow.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MythicalCafe_BackEnd_Log_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 614);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Log_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Log_List";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Log_List_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rv_Log;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Print;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker dp_DateTime_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker dp_DateTime_From;
        private System.Windows.Forms.Label lbl_getAction;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DateTime_Select;
        private System.Windows.Forms.DataGridView dgv_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log_DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Log_Description;
        private System.Windows.Forms.ImageList img_Arrow;
    }
}