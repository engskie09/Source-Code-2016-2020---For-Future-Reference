namespace MythicalCafe_ICMS_BackEnd
{
    partial class MythicalCafe_BackEnd_Report
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dp_DateTime_To = new Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker();
            this.dp_DateTime_From = new Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_getAction = new System.Windows.Forms.Label();
            this.btn_DateTime_Select = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtbx_Expenses_Other = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbx_Bill_Water = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbx_Bill_Electric = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbx_Bill_Electric_Number = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtbx_Bill_Water_Number = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Print = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rv_Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 594F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rv_Report, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.75758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 340);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.84022F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.15978F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_DateTime_Select, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 76);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6087F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.3913F));
            this.tableLayoutPanel4.Controls.Add(this.dp_DateTime_To, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.dp_DateTime_From, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_getAction, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(191, 70);
            this.tableLayoutPanel4.TabIndex = 0;
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
            this.dp_DateTime_To.Location = new System.Drawing.Point(66, 39);
            this.dp_DateTime_To.Margin = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_To.MarkSelectedDate = true;
            this.dp_DateTime_To.MaxValue = new System.DateTime(9999, 12, 31, 6, 34, 42, 295);
            this.dp_DateTime_To.MinValue = new System.DateTime(1, 2, 1, 6, 34, 42, 295);
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
            this.dp_DateTime_To.Size = new System.Drawing.Size(121, 26);
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
            this.dp_DateTime_To.Value = new System.DateTime(2019, 11, 6, 6, 34, 42, 295);
            this.dp_DateTime_To.ValueIsNull = false;
            this.dp_DateTime_To.TextChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
            this.dp_DateTime_To.MouseCaptureChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
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
            this.dp_DateTime_From.Location = new System.Drawing.Point(66, 4);
            this.dp_DateTime_From.Margin = new System.Windows.Forms.Padding(4);
            this.dp_DateTime_From.MarkSelectedDate = true;
            this.dp_DateTime_From.MaxValue = new System.DateTime(9999, 12, 31, 6, 34, 42, 305);
            this.dp_DateTime_From.MinValue = new System.DateTime(1, 2, 1, 6, 34, 42, 305);
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
            this.dp_DateTime_From.Size = new System.Drawing.Size(121, 26);
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
            this.dp_DateTime_From.Value = new System.DateTime(2019, 11, 6, 6, 34, 42, 305);
            this.dp_DateTime_From.ValueIsNull = false;
            this.dp_DateTime_From.TextChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
            this.dp_DateTime_From.MouseCaptureChanged += new System.EventHandler(this.set_dp_DateTime_Validation);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Georgia", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "To :";
            // 
            // lbl_getAction
            // 
            this.lbl_getAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_getAction.AutoSize = true;
            this.lbl_getAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_getAction.Font = new System.Drawing.Font("Georgia", 12F);
            this.lbl_getAction.ForeColor = System.Drawing.Color.White;
            this.lbl_getAction.Location = new System.Drawing.Point(3, 8);
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
            this.btn_DateTime_Select.ButtonText = "Generate";
            this.btn_DateTime_Select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DateTime_Select.DisabledColor = System.Drawing.Color.Gray;
            this.btn_DateTime_Select.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.btn_DateTime_Select.Location = new System.Drawing.Point(201, 4);
            this.btn_DateTime_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DateTime_Select.Name = "btn_DateTime_Select";
            this.btn_DateTime_Select.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.btn_DateTime_Select.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_DateTime_Select.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_DateTime_Select.selected = false;
            this.btn_DateTime_Select.Size = new System.Drawing.Size(95, 68);
            this.btn_DateTime_Select.TabIndex = 25;
            this.btn_DateTime_Select.Text = "Generate";
            this.btn_DateTime_Select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DateTime_Select.Textcolor = System.Drawing.Color.White;
            this.btn_DateTime_Select.TextFont = new System.Drawing.Font("Georgia", 12F);
            this.btn_DateTime_Select.Click += new System.EventHandler(this.btn_DateTime_Select_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtbx_Expenses_Other, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtbx_Bill_Water, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtbx_Bill_Electric, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtbx_Bill_Electric_Number, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtbx_Bill_Water_Number, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_Print, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 85);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(300, 252);
            this.tableLayoutPanel3.TabIndex = 28;
            // 
            // txtbx_Expenses_Other
            // 
            this.txtbx_Expenses_Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Expenses_Other.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Expenses_Other.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Expenses_Other.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Expenses_Other.BorderThickness = 3;
            this.txtbx_Expenses_Other.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Expenses_Other.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Expenses_Other.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Expenses_Other.ForeColor = System.Drawing.Color.White;
            this.txtbx_Expenses_Other.isPassword = false;
            this.txtbx_Expenses_Other.Location = new System.Drawing.Point(4, 130);
            this.txtbx_Expenses_Other.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Expenses_Other.Name = "txtbx_Expenses_Other";
            this.txtbx_Expenses_Other.Size = new System.Drawing.Size(142, 55);
            this.txtbx_Expenses_Other.TabIndex = 3;
            this.txtbx_Expenses_Other.Text = "Other Expenses";
            this.txtbx_Expenses_Other.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_Bill_Water
            // 
            this.txtbx_Bill_Water.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Bill_Water.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Bill_Water.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Bill_Water.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Bill_Water.BorderThickness = 3;
            this.txtbx_Bill_Water.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Bill_Water.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Bill_Water.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Bill_Water.ForeColor = System.Drawing.Color.White;
            this.txtbx_Bill_Water.isPassword = false;
            this.txtbx_Bill_Water.Location = new System.Drawing.Point(4, 67);
            this.txtbx_Bill_Water.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Bill_Water.Name = "txtbx_Bill_Water";
            this.txtbx_Bill_Water.Size = new System.Drawing.Size(142, 55);
            this.txtbx_Bill_Water.TabIndex = 2;
            this.txtbx_Bill_Water.Text = "Water Bill";
            this.txtbx_Bill_Water.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_Bill_Electric
            // 
            this.txtbx_Bill_Electric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Bill_Electric.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Bill_Electric.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Bill_Electric.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Bill_Electric.BorderThickness = 3;
            this.txtbx_Bill_Electric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Bill_Electric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbx_Bill_Electric.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Bill_Electric.ForeColor = System.Drawing.Color.White;
            this.txtbx_Bill_Electric.isPassword = false;
            this.txtbx_Bill_Electric.Location = new System.Drawing.Point(4, 4);
            this.txtbx_Bill_Electric.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Bill_Electric.Name = "txtbx_Bill_Electric";
            this.txtbx_Bill_Electric.Size = new System.Drawing.Size(142, 55);
            this.txtbx_Bill_Electric.TabIndex = 1;
            this.txtbx_Bill_Electric.Text = "Electric Bill";
            this.txtbx_Bill_Electric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_Bill_Electric_Number
            // 
            this.txtbx_Bill_Electric_Number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Bill_Electric_Number.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Bill_Electric_Number.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Bill_Electric_Number.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Bill_Electric_Number.BorderThickness = 3;
            this.txtbx_Bill_Electric_Number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Bill_Electric_Number.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Bill_Electric_Number.ForeColor = System.Drawing.Color.White;
            this.txtbx_Bill_Electric_Number.isPassword = false;
            this.txtbx_Bill_Electric_Number.Location = new System.Drawing.Point(154, 4);
            this.txtbx_Bill_Electric_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Bill_Electric_Number.Name = "txtbx_Bill_Electric_Number";
            this.txtbx_Bill_Electric_Number.Size = new System.Drawing.Size(142, 55);
            this.txtbx_Bill_Electric_Number.TabIndex = 27;
            this.txtbx_Bill_Electric_Number.Text = "O.R number";
            this.txtbx_Bill_Electric_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_Bill_Water_Number
            // 
            this.txtbx_Bill_Water_Number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(255)))));
            this.txtbx_Bill_Water_Number.BorderColorFocused = System.Drawing.Color.White;
            this.txtbx_Bill_Water_Number.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(202)))), ((int)(((byte)(168)))));
            this.txtbx_Bill_Water_Number.BorderColorMouseHover = System.Drawing.Color.White;
            this.txtbx_Bill_Water_Number.BorderThickness = 3;
            this.txtbx_Bill_Water_Number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_Bill_Water_Number.Font = new System.Drawing.Font("Georgia", 12F);
            this.txtbx_Bill_Water_Number.ForeColor = System.Drawing.Color.White;
            this.txtbx_Bill_Water_Number.isPassword = false;
            this.txtbx_Bill_Water_Number.Location = new System.Drawing.Point(154, 67);
            this.txtbx_Bill_Water_Number.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Bill_Water_Number.Name = "txtbx_Bill_Water_Number";
            this.txtbx_Bill_Water_Number.Size = new System.Drawing.Size(142, 55);
            this.txtbx_Bill_Water_Number.TabIndex = 28;
            this.txtbx_Bill_Water_Number.Text = "O.R number";
            this.txtbx_Bill_Water_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_Print.Location = new System.Drawing.Point(5, 203);
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
            // rv_Report
            // 
            this.rv_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_Report.LocalReport.ReportEmbeddedResource = "MythicalCafe_ICMS_BackEnd.MythicalCafe_BackEnd_Report.rdlc";
            this.rv_Report.Location = new System.Drawing.Point(309, 3);
            this.rv_Report.Name = "rv_Report";
            this.tableLayoutPanel1.SetRowSpan(this.rv_Report, 2);
            this.rv_Report.ServerReport.BearerToken = null;
            this.rv_Report.Size = new System.Drawing.Size(588, 334);
            this.rv_Report.TabIndex = 27;
            // 
            // MythicalCafe_BackEnd_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 340);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MythicalCafe_BackEnd_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MythicalCafe_BackEnd_Report";
            this.Load += new System.EventHandler(this.MythicalCafe_BackEnd_Report_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Print;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker dp_DateTime_To;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Binarymission.WinForms.Controls.DateTimeControls.BinaryDatePicker dp_DateTime_From;
        private System.Windows.Forms.Label lbl_getAction;
        private Bunifu.Framework.UI.BunifuFlatButton btn_DateTime_Select;
        private Microsoft.Reporting.WinForms.ReportViewer rv_Report;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Expenses_Other;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Bill_Water;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Bill_Electric;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Bill_Electric_Number;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtbx_Bill_Water_Number;
    }
}