namespace HUYNHDE_DUAN1
{
    partial class formDataTP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridGDTP = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExports = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpGrade = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ma_CK = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnFind = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_MACK = new System.Windows.Forms.ComboBox();
            this.Chart_GDTP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.saveChart = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGDTP)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_GDTP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1424, 887);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1416, 854);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin dữ liệu trái phiếu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridGDTP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1410, 553);
            this.panel3.TabIndex = 10;
            // 
            // dataGridGDTP
            // 
            this.dataGridGDTP.AllowUserToAddRows = false;
            this.dataGridGDTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGDTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGDTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridGDTP.Location = new System.Drawing.Point(0, 0);
            this.dataGridGDTP.Name = "dataGridGDTP";
            this.dataGridGDTP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGDTP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridGDTP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridGDTP.Size = new System.Drawing.Size(1410, 553);
            this.dataGridGDTP.TabIndex = 5;
            this.dataGridGDTP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGDTP_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnExports);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUpGrade);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 688);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1410, 163);
            this.panel2.TabIndex = 9;
            // 
            // btnExports
            // 
            this.btnExports.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExports.FlatAppearance.BorderSize = 4;
            this.btnExports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnExports.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnExports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnExports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExports.IconSize = 20;
            this.btnExports.Location = new System.Drawing.Point(873, 29);
            this.btnExports.Name = "btnExports";
            this.btnExports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExports.Size = new System.Drawing.Size(119, 45);
            this.btnExports.TabIndex = 169;
            this.btnExports.Text = "Xuất";
            this.btnExports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExports.UseVisualStyleBackColor = true;
            this.btnExports.Click += new System.EventHandler(this.btnExports_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 4;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(663, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(119, 45);
            this.btnAdd.TabIndex = 168;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpGrade
            // 
            this.btnUpGrade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpGrade.FlatAppearance.BorderSize = 4;
            this.btnUpGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnUpGrade.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.btnUpGrade.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnUpGrade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpGrade.IconSize = 20;
            this.btnUpGrade.Location = new System.Drawing.Point(452, 29);
            this.btnUpGrade.Name = "btnUpGrade";
            this.btnUpGrade.Size = new System.Drawing.Size(119, 45);
            this.btnUpGrade.TabIndex = 167;
            this.btnUpGrade.Text = "Cập nhật";
            this.btnUpGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpGrade.UseVisualStyleBackColor = true;
            this.btnUpGrade.Click += new System.EventHandler(this.btnUpGrade_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ma_CK);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.todate);
            this.panel1.Controls.Add(this.fromdate);
            this.panel1.Controls.Add(this.panel16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 132);
            this.panel1.TabIndex = 8;
            // 
            // ma_CK
            // 
            this.ma_CK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ma_CK.BackColor = System.Drawing.Color.White;
            this.ma_CK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ma_CK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ma_CK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.ma_CK.Location = new System.Drawing.Point(297, 84);
            this.ma_CK.MinimumSize = new System.Drawing.Size(150, 25);
            this.ma_CK.Name = "ma_CK";
            this.ma_CK.Size = new System.Drawing.Size(150, 19);
            this.ma_CK.TabIndex = 358;
            this.ma_CK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 4;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(1119, 70);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(113, 45);
            this.iconButton1.TabIndex = 357;
            this.iconButton1.Text = "Làm mới";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // todate
            // 
            this.todate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todate.CustomFormat = "dd/MM/yyyy";
            this.todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todate.Location = new System.Drawing.Point(832, 80);
            this.todate.MaximumSize = new System.Drawing.Size(347, 25);
            this.todate.Name = "todate";
            this.todate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.todate.Size = new System.Drawing.Size(150, 23);
            this.todate.TabIndex = 356;
            // 
            // fromdate
            // 
            this.fromdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fromdate.CustomFormat = "dd/MM/yyyy";
            this.fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdate.Location = new System.Drawing.Point(556, 80);
            this.fromdate.MaximumSize = new System.Drawing.Size(347, 25);
            this.fromdate.Name = "fromdate";
            this.fromdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromdate.Size = new System.Drawing.Size(150, 23);
            this.fromdate.TabIndex = 355;
            // 
            // panel16
            // 
            this.panel16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel16.Location = new System.Drawing.Point(556, 109);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(150, 2);
            this.panel16.TabIndex = 97;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label17.Location = new System.Drawing.Point(215, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 20);
            this.label17.TabIndex = 110;
            this.label17.Text = "Mã CK:";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label16.Location = new System.Drawing.Point(464, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 109;
            this.label16.Text = "Từ ngày:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(722, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Đến ngày:";
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel11.Location = new System.Drawing.Point(297, 109);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(150, 2);
            this.panel11.TabIndex = 96;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 4;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnFind.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFind.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnFind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFind.IconSize = 25;
            this.btnFind.Location = new System.Drawing.Point(1016, 70);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 45);
            this.btnFind.TabIndex = 93;
            this.btnFind.Text = "Tìm";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel5.Location = new System.Drawing.Point(832, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 2);
            this.panel5.TabIndex = 94;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveChart);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cb_MACK);
            this.tabPage2.Controls.Add(this.Chart_GDTP);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1416, 854);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Biểu đồ trái phiếu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_MACK
            // 
            this.cb_MACK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_MACK.FormattingEnabled = true;
            this.cb_MACK.Location = new System.Drawing.Point(260, 34);
            this.cb_MACK.Name = "cb_MACK";
            this.cb_MACK.Size = new System.Drawing.Size(246, 28);
            this.cb_MACK.TabIndex = 1;
            this.cb_MACK.SelectionChangeCommitted += new System.EventHandler(this.cb_MACK_SelectionChangeCommitted);
            // 
            // Chart_GDTP
            // 
            this.Chart_GDTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.Chart_GDTP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart_GDTP.Legends.Add(legend2);
            this.Chart_GDTP.Location = new System.Drawing.Point(0, 68);
            this.Chart_GDTP.Name = "Chart_GDTP";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "BindingX";
            series2.YValueMembers = "Binding";
            this.Chart_GDTP.Series.Add(series2);
            this.Chart_GDTP.Size = new System.Drawing.Size(1416, 644);
            this.Chart_GDTP.TabIndex = 0;
            this.Chart_GDTP.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.BorderWidth = 2;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title2.Name = "Title1";
            this.Chart_GDTP.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(183, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 111;
            this.label1.Text = "Mã CK:";
            // 
            // saveChart
            // 
            this.saveChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChart.FlatAppearance.BorderSize = 4;
            this.saveChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.saveChart.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.saveChart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.saveChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveChart.IconSize = 20;
            this.saveChart.Location = new System.Drawing.Point(606, 704);
            this.saveChart.Name = "saveChart";
            this.saveChart.Size = new System.Drawing.Size(119, 45);
            this.saveChart.TabIndex = 168;
            this.saveChart.Text = "Lưu ảnh";
            this.saveChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveChart.UseVisualStyleBackColor = true;
            this.saveChart.Click += new System.EventHandler(this.saveChart_Click);
            // 
            // formDataTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.tabControl1);
            this.Name = "formDataTP";
            this.Text = "Quản lý dữ liệu giao dịch trái phiếu";
            this.Load += new System.EventHandler(this.formDataTP_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGDTP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_GDTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridGDTP;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnExports;
        public FontAwesome.Sharp.IconButton btnAdd;
        public FontAwesome.Sharp.IconButton btnUpGrade;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox ma_CK;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton btnFind;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_GDTP;
        private System.Windows.Forms.ComboBox cb_MACK;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton saveChart;
    }
}