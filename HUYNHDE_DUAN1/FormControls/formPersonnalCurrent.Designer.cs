namespace HUYNHDE_DUAN1
{
    partial class formPersonnalCurrent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangPass = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.diachi = new System.Windows.Forms.TextBox();
            this.cmnd = new System.Windows.Forms.TextBox();
            this.sodienthoai = new System.Windows.Forms.TextBox();
            this.chucvu = new System.Windows.Forms.TextBox();
            this.gioitinh = new System.Windows.Forms.TextBox();
            this.hovaten = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_mail = new System.Windows.Forms.Label();
            this.circularPictureBox2 = new HUYNHDE_DUAN1.contructions_functions.CircularPictureBox();
            this.avatar = new HUYNHDE_DUAN1.contructions_functions.CircularPictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 852);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnChangPass);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(968, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 852);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnChangPass
            // 
            this.btnChangPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangPass.FlatAppearance.BorderSize = 4;
            this.btnChangPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChangPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnChangPass.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChangPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnChangPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangPass.IconSize = 25;
            this.btnChangPass.Location = new System.Drawing.Point(32, 619);
            this.btnChangPass.Name = "btnChangPass";
            this.btnChangPass.Size = new System.Drawing.Size(120, 50);
            this.btnChangPass.TabIndex = 36;
            this.btnChangPass.Text = "Đổi mật khẩu";
            this.btnChangPass.UseVisualStyleBackColor = true;
            this.btnChangPass.Click += new System.EventHandler(this.btnChangPass_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 4;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnThoat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 25;
            this.btnThoat.Location = new System.Drawing.Point(32, 768);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(120, 50);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 4;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDangXuat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.IconSize = 25;
            this.btnDangXuat.Location = new System.Drawing.Point(32, 694);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(120, 50);
            this.btnDangXuat.TabIndex = 34;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ngay);
            this.panel3.Controls.Add(this.circularPictureBox2);
            this.panel3.Controls.Add(this.avatar);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.diachi);
            this.panel3.Controls.Add(this.cmnd);
            this.panel3.Controls.Add(this.sodienthoai);
            this.panel3.Controls.Add(this.chucvu);
            this.panel3.Controls.Add(this.gioitinh);
            this.panel3.Controls.Add(this.hovaten);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lb_mail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 852);
            this.panel3.TabIndex = 2;
            // 
            // ngay
            // 
            this.ngay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ngay.CustomFormat = "dd/MM/yyyy";
            this.ngay.Enabled = false;
            this.ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay.Location = new System.Drawing.Point(216, 415);
            this.ngay.MaximumSize = new System.Drawing.Size(347, 25);
            this.ngay.Name = "ngay";
            this.ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ngay.Size = new System.Drawing.Size(131, 23);
            this.ngay.TabIndex = 356;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 4;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 25;
            this.btnSave.Location = new System.Drawing.Point(312, 768);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // diachi
            // 
            this.diachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diachi.BackColor = System.Drawing.Color.White;
            this.diachi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.diachi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.diachi.Location = new System.Drawing.Point(216, 708);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(369, 19);
            this.diachi.TabIndex = 32;
            // 
            // cmnd
            // 
            this.cmnd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmnd.BackColor = System.Drawing.Color.White;
            this.cmnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.cmnd.Location = new System.Drawing.Point(238, 634);
            this.cmnd.Name = "cmnd";
            this.cmnd.Size = new System.Drawing.Size(347, 19);
            this.cmnd.TabIndex = 31;
            // 
            // sodienthoai
            // 
            this.sodienthoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sodienthoai.BackColor = System.Drawing.Color.White;
            this.sodienthoai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sodienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sodienthoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.sodienthoai.Location = new System.Drawing.Point(216, 560);
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.Size = new System.Drawing.Size(369, 19);
            this.sodienthoai.TabIndex = 30;
            // 
            // chucvu
            // 
            this.chucvu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chucvu.BackColor = System.Drawing.Color.White;
            this.chucvu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chucvu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.chucvu.Location = new System.Drawing.Point(216, 486);
            this.chucvu.Name = "chucvu";
            this.chucvu.ReadOnly = true;
            this.chucvu.Size = new System.Drawing.Size(366, 19);
            this.chucvu.TabIndex = 29;
            // 
            // gioitinh
            // 
            this.gioitinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gioitinh.BackColor = System.Drawing.Color.White;
            this.gioitinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.gioitinh.Location = new System.Drawing.Point(476, 411);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Size = new System.Drawing.Size(108, 19);
            this.gioitinh.TabIndex = 28;
            // 
            // hovaten
            // 
            this.hovaten.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hovaten.BackColor = System.Drawing.Color.White;
            this.hovaten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hovaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hovaten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.hovaten.Location = new System.Drawing.Point(216, 338);
            this.hovaten.Name = "hovaten";
            this.hovaten.ReadOnly = true;
            this.hovaten.Size = new System.Drawing.Size(366, 19);
            this.hovaten.TabIndex = 26;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel8.Location = new System.Drawing.Point(216, 736);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(368, 2);
            this.panel8.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel7.Location = new System.Drawing.Point(238, 662);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(347, 2);
            this.panel7.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel6.Location = new System.Drawing.Point(216, 588);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(369, 2);
            this.panel6.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel5.Location = new System.Drawing.Point(216, 514);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 2);
            this.panel5.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel4.Location = new System.Drawing.Point(216, 439);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 2);
            this.panel4.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel9.Location = new System.Drawing.Point(477, 439);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(108, 2);
            this.panel9.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label8.Location = new System.Drawing.Point(99, 643);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số CCCD/CMND:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label7.Location = new System.Drawing.Point(99, 717);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label6.Location = new System.Drawing.Point(99, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label5.Location = new System.Drawing.Point(99, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Chức vụ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label4.Location = new System.Drawing.Point(99, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label3.Location = new System.Drawing.Point(366, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giới tính:";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel10.Location = new System.Drawing.Point(216, 366);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(369, 2);
            this.panel10.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(99, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ và tên: ";
            // 
            // lb_mail
            // 
            this.lb_mail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_mail.AutoSize = true;
            this.lb_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.lb_mail.Location = new System.Drawing.Point(309, 297);
            this.lb_mail.Name = "lb_mail";
            this.lb_mail.Size = new System.Drawing.Size(133, 15);
            this.lb_mail.TabIndex = 11;
            this.lb_mail.Text = "do272443@gmail.com";
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circularPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.circularPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circularPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circularPictureBox2.Location = new System.Drawing.Point(426, 240);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(35, 35);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox2.TabIndex = 136;
            this.circularPictureBox2.TabStop = false;
            this.circularPictureBox2.Click += new System.EventHandler(this.circularPictureBox2_Click);
            // 
            // avatar
            // 
            this.avatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.avatar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.avatar.Location = new System.Drawing.Point(272, 85);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(200, 200);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // formPersonnalCurrent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 852);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formPersonnalCurrent";
            this.Text = "Quản lý thông tin cá nhân";
            this.Load += new System.EventHandler(this.formPersonnalCurrent_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_mail;
        private System.Windows.Forms.TextBox hovaten;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox cmnd;
        private System.Windows.Forms.TextBox sodienthoai;
        private System.Windows.Forms.TextBox chucvu;
        private System.Windows.Forms.TextBox gioitinh;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnSave;
        private contructions_functions.CircularPictureBox avatar;
        private contructions_functions.CircularPictureBox circularPictureBox2;
        private FontAwesome.Sharp.IconButton btnChangPass;
        private System.Windows.Forms.DateTimePicker ngay;
    }
}