namespace HUYNHDE_DUAN1
{
    partial class FormMain
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
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            this.panel = new HUYNHDE_DUAN1.contructions_functions.panelLinearGradient();
            this.label1 = new System.Windows.Forms.Label();
            this.fillIconButton = new FontAwesome.Sharp.IconButton();
            this.pnFillChildForms = new HUYNHDE_DUAN1.contructions_functions.panelLinearGradient();
            this.panelOpacity = new System.Windows.Forms.Panel();
            this.lbCongra = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.logoDisplay = new System.Windows.Forms.PictureBox();
            this.pnControlButtons = new HUYNHDE_DUAN1.contructions_functions.panelLinearGradient();
            this.btnFormPersonalCurrent = new FontAwesome.Sharp.IconButton();
            this.btnFormManagerEmplyee = new FontAwesome.Sharp.IconButton();
            this.btnFormDataTP = new FontAwesome.Sharp.IconButton();
            this.btnFormGDBDG = new FontAwesome.Sharp.IconButton();
            this.btnFormStock = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcLogoHome = new System.Windows.Forms.PictureBox();
            this.panelLinearGradient2 = new HUYNHDE_DUAN1.contructions_functions.panelLinearGradient();
            this.btnMinimized = new FontAwesome.Sharp.IconButton();
            this.btnMaximized = new FontAwesome.Sharp.IconButton();
            this.btnEx = new FontAwesome.Sharp.IconButton();
            this.panel.SuspendLayout();
            this.pnFillChildForms.SuspendLayout();
            this.panelOpacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoDisplay)).BeginInit();
            this.pnControlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogoHome)).BeginInit();
            this.panelLinearGradient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerLoad
            // 
            this.TimerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // panel
            // 
            this.panel.Colorleft = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.panel.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.fillIconButton);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(300, 30);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1143, 50);
            this.panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // fillIconButton
            // 
            this.fillIconButton.BackColor = System.Drawing.Color.Transparent;
            this.fillIconButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.fillIconButton.FlatAppearance.BorderSize = 0;
            this.fillIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillIconButton.ForeColor = System.Drawing.Color.Violet;
            this.fillIconButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.fillIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.fillIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fillIconButton.IconSize = 30;
            this.fillIconButton.Location = new System.Drawing.Point(0, 0);
            this.fillIconButton.Name = "fillIconButton";
            this.fillIconButton.Size = new System.Drawing.Size(39, 50);
            this.fillIconButton.TabIndex = 0;
            this.fillIconButton.UseVisualStyleBackColor = false;
            // 
            // pnFillChildForms
            // 
            this.pnFillChildForms.Colorleft = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.pnFillChildForms.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.pnFillChildForms.Controls.Add(this.panelOpacity);
            this.pnFillChildForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFillChildForms.Location = new System.Drawing.Point(300, 30);
            this.pnFillChildForms.Name = "pnFillChildForms";
            this.pnFillChildForms.Size = new System.Drawing.Size(1143, 827);
            this.pnFillChildForms.TabIndex = 2;
            // 
            // panelOpacity
            // 
            this.panelOpacity.BackColor = System.Drawing.Color.White;
            this.panelOpacity.Controls.Add(this.lbCongra);
            this.panelOpacity.Controls.Add(this.lbTime);
            this.panelOpacity.Controls.Add(this.lbDate);
            this.panelOpacity.Controls.Add(this.logoDisplay);
            this.panelOpacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpacity.ForeColor = System.Drawing.Color.Transparent;
            this.panelOpacity.Location = new System.Drawing.Point(0, 0);
            this.panelOpacity.Name = "panelOpacity";
            this.panelOpacity.Size = new System.Drawing.Size(1143, 827);
            this.panelOpacity.TabIndex = 0;
            // 
            // lbCongra
            // 
            this.lbCongra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCongra.AutoSize = true;
            this.lbCongra.BackColor = System.Drawing.Color.Transparent;
            this.lbCongra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCongra.ForeColor = System.Drawing.Color.Transparent;
            this.lbCongra.Location = new System.Drawing.Point(314, 617);
            this.lbCongra.Name = "lbCongra";
            this.lbCongra.Size = new System.Drawing.Size(93, 33);
            this.lbCongra.TabIndex = 7;
            this.lbCongra.Text = "label3";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Transparent;
            this.lbTime.Location = new System.Drawing.Point(492, 539);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(186, 42);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "00:00:00\"";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Transparent;
            this.lbDate.Location = new System.Drawing.Point(507, 470);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(228, 42);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "dd/MM/yyyy";
            // 
            // logoDisplay
            // 
            this.logoDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoDisplay.BackColor = System.Drawing.Color.Transparent;
            this.logoDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoDisplay.Location = new System.Drawing.Point(289, 79);
            this.logoDisplay.Name = "logoDisplay";
            this.logoDisplay.Size = new System.Drawing.Size(635, 371);
            this.logoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDisplay.TabIndex = 4;
            this.logoDisplay.TabStop = false;
            // 
            // pnControlButtons
            // 
            this.pnControlButtons.Colorleft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.pnControlButtons.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.pnControlButtons.Controls.Add(this.btnFormPersonalCurrent);
            this.pnControlButtons.Controls.Add(this.btnFormManagerEmplyee);
            this.pnControlButtons.Controls.Add(this.btnFormDataTP);
            this.pnControlButtons.Controls.Add(this.btnFormGDBDG);
            this.pnControlButtons.Controls.Add(this.btnFormStock);
            this.pnControlButtons.Controls.Add(this.panel1);
            this.pnControlButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnControlButtons.Location = new System.Drawing.Point(0, 30);
            this.pnControlButtons.Name = "pnControlButtons";
            this.pnControlButtons.Size = new System.Drawing.Size(300, 827);
            this.pnControlButtons.TabIndex = 1;
            // 
            // btnFormPersonalCurrent
            // 
            this.btnFormPersonalCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.btnFormPersonalCurrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormPersonalCurrent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormPersonalCurrent.FlatAppearance.BorderSize = 0;
            this.btnFormPersonalCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormPersonalCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormPersonalCurrent.ForeColor = System.Drawing.Color.White;
            this.btnFormPersonalCurrent.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnFormPersonalCurrent.IconColor = System.Drawing.Color.White;
            this.btnFormPersonalCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormPersonalCurrent.IconSize = 30;
            this.btnFormPersonalCurrent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormPersonalCurrent.Location = new System.Drawing.Point(0, 550);
            this.btnFormPersonalCurrent.Name = "btnFormPersonalCurrent";
            this.btnFormPersonalCurrent.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFormPersonalCurrent.Size = new System.Drawing.Size(300, 100);
            this.btnFormPersonalCurrent.TabIndex = 13;
            this.btnFormPersonalCurrent.Text = "Cá nhân";
            this.btnFormPersonalCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormPersonalCurrent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormPersonalCurrent.UseVisualStyleBackColor = false;
            this.btnFormPersonalCurrent.Click += new System.EventHandler(this.btnFormPersonalCurrent_Click_1);
            // 
            // btnFormManagerEmplyee
            // 
            this.btnFormManagerEmplyee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.btnFormManagerEmplyee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormManagerEmplyee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormManagerEmplyee.FlatAppearance.BorderSize = 0;
            this.btnFormManagerEmplyee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormManagerEmplyee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormManagerEmplyee.ForeColor = System.Drawing.Color.White;
            this.btnFormManagerEmplyee.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnFormManagerEmplyee.IconColor = System.Drawing.Color.White;
            this.btnFormManagerEmplyee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormManagerEmplyee.IconSize = 30;
            this.btnFormManagerEmplyee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormManagerEmplyee.Location = new System.Drawing.Point(0, 450);
            this.btnFormManagerEmplyee.Name = "btnFormManagerEmplyee";
            this.btnFormManagerEmplyee.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFormManagerEmplyee.Size = new System.Drawing.Size(300, 100);
            this.btnFormManagerEmplyee.TabIndex = 12;
            this.btnFormManagerEmplyee.Text = "Quản lý nhân viên";
            this.btnFormManagerEmplyee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormManagerEmplyee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormManagerEmplyee.UseVisualStyleBackColor = false;
            this.btnFormManagerEmplyee.Click += new System.EventHandler(this.btnFormManagerEmplyee_Click_1);
            // 
            // btnFormDataTP
            // 
            this.btnFormDataTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.btnFormDataTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormDataTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormDataTP.FlatAppearance.BorderSize = 0;
            this.btnFormDataTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormDataTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormDataTP.ForeColor = System.Drawing.Color.White;
            this.btnFormDataTP.IconChar = FontAwesome.Sharp.IconChar.ChartGantt;
            this.btnFormDataTP.IconColor = System.Drawing.Color.White;
            this.btnFormDataTP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormDataTP.IconSize = 30;
            this.btnFormDataTP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormDataTP.Location = new System.Drawing.Point(0, 350);
            this.btnFormDataTP.Name = "btnFormDataTP";
            this.btnFormDataTP.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFormDataTP.Size = new System.Drawing.Size(300, 100);
            this.btnFormDataTP.TabIndex = 10;
            this.btnFormDataTP.Text = "Dữ liệu GDTP";
            this.btnFormDataTP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormDataTP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormDataTP.UseVisualStyleBackColor = false;
            this.btnFormDataTP.Click += new System.EventHandler(this.btnFormDataTP_Click);
            // 
            // btnFormGDBDG
            // 
            this.btnFormGDBDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.btnFormGDBDG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormGDBDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormGDBDG.FlatAppearance.BorderSize = 0;
            this.btnFormGDBDG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormGDBDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormGDBDG.ForeColor = System.Drawing.Color.White;
            this.btnFormGDBDG.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnFormGDBDG.IconColor = System.Drawing.Color.White;
            this.btnFormGDBDG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormGDBDG.IconSize = 30;
            this.btnFormGDBDG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormGDBDG.Location = new System.Drawing.Point(0, 250);
            this.btnFormGDBDG.Name = "btnFormGDBDG";
            this.btnFormGDBDG.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFormGDBDG.Size = new System.Drawing.Size(300, 100);
            this.btnFormGDBDG.TabIndex = 8;
            this.btnFormGDBDG.Text = "Dữ liệu giao dịch";
            this.btnFormGDBDG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormGDBDG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormGDBDG.UseVisualStyleBackColor = false;
            this.btnFormGDBDG.Click += new System.EventHandler(this.btnFormGDBDG_Click);
            // 
            // btnFormStock
            // 
            this.btnFormStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.btnFormStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormStock.FlatAppearance.BorderSize = 0;
            this.btnFormStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormStock.ForeColor = System.Drawing.Color.White;
            this.btnFormStock.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnFormStock.IconColor = System.Drawing.Color.White;
            this.btnFormStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormStock.IconSize = 30;
            this.btnFormStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormStock.Location = new System.Drawing.Point(0, 150);
            this.btnFormStock.Name = "btnFormStock";
            this.btnFormStock.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFormStock.Size = new System.Drawing.Size(300, 100);
            this.btnFormStock.TabIndex = 6;
            this.btnFormStock.Text = "Hồ sơ chứng khoán";
            this.btnFormStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFormStock.UseVisualStyleBackColor = false;
            this.btnFormStock.Click += new System.EventHandler(this.btnFormStock_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(167)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pcLogoHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 150);
            this.panel1.TabIndex = 0;
            // 
            // pcLogoHome
            // 
            this.pcLogoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.pcLogoHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcLogoHome.Location = new System.Drawing.Point(0, 0);
            this.pcLogoHome.Name = "pcLogoHome";
            this.pcLogoHome.Size = new System.Drawing.Size(300, 150);
            this.pcLogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLogoHome.TabIndex = 0;
            this.pcLogoHome.TabStop = false;
            this.pcLogoHome.Click += new System.EventHandler(this.pcLogoHome_Click);
            // 
            // panelLinearGradient2
            // 
            this.panelLinearGradient2.Colorleft = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.panelLinearGradient2.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panelLinearGradient2.Controls.Add(this.btnMinimized);
            this.panelLinearGradient2.Controls.Add(this.btnMaximized);
            this.panelLinearGradient2.Controls.Add(this.btnEx);
            this.panelLinearGradient2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLinearGradient2.Location = new System.Drawing.Point(0, 0);
            this.panelLinearGradient2.Name = "panelLinearGradient2";
            this.panelLinearGradient2.Size = new System.Drawing.Size(1443, 30);
            this.panelLinearGradient2.TabIndex = 0;
            this.panelLinearGradient2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLinearGradient2_MouseDown);
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimized.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimized.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimized.IconColor = System.Drawing.Color.White;
            this.btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimized.IconSize = 25;
            this.btnMinimized.Location = new System.Drawing.Point(1344, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(33, 30);
            this.btnMinimized.TabIndex = 2;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximized.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximized.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMaximized.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMaximized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximized.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnMaximized.Location = new System.Drawing.Point(1377, 0);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(33, 30);
            this.btnMaximized.TabIndex = 1;
            this.btnMaximized.Text = "❐";
            this.btnMaximized.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximized.UseVisualStyleBackColor = false;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnEx
            // 
            this.btnEx.BackColor = System.Drawing.Color.Transparent;
            this.btnEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEx.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEx.FlatAppearance.BorderSize = 0;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.Transparent;
            this.btnEx.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnEx.IconColor = System.Drawing.Color.White;
            this.btnEx.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEx.IconSize = 20;
            this.btnEx.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEx.Location = new System.Drawing.Point(1410, 0);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(33, 30);
            this.btnEx.TabIndex = 0;
            this.btnEx.UseVisualStyleBackColor = false;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pnFillChildForms);
            this.Controls.Add(this.pnControlButtons);
            this.Controls.Add(this.panelLinearGradient2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "formMainGrogram";
            this.Load += new System.EventHandler(this.formMainGrogram_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.pnFillChildForms.ResumeLayout(false);
            this.panelOpacity.ResumeLayout(false);
            this.panelOpacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoDisplay)).EndInit();
            this.pnControlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogoHome)).EndInit();
            this.panelLinearGradient2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

       
        private contructions_functions.panelLinearGradient panelLinearGradient2;
        private contructions_functions.panelLinearGradient pnControlButtons;
        private FontAwesome.Sharp.IconButton btnFormDataTP;
        private FontAwesome.Sharp.IconButton btnFormGDBDG;
        private FontAwesome.Sharp.IconButton btnFormStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcLogoHome;
        private contructions_functions.panelLinearGradient pnFillChildForms;
        private System.Windows.Forms.Panel panelOpacity;
        private System.Windows.Forms.Timer TimerLoad;
        private contructions_functions.panelLinearGradient panel;
        private FontAwesome.Sharp.IconButton fillIconButton;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMinimized;
        private FontAwesome.Sharp.IconButton btnMaximized;
        private FontAwesome.Sharp.IconButton btnEx;
        private System.Windows.Forms.Label lbCongra;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.PictureBox logoDisplay;
        private FontAwesome.Sharp.IconButton btnFormPersonalCurrent;
        public FontAwesome.Sharp.IconButton btnFormManagerEmplyee;
    }
}