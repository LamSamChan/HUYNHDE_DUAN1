namespace HUYNHDE_DUAN1
{
    partial class formStock
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
            this.cbbListValue = new System.Windows.Forms.Panel();
            this.btnRefesh = new FontAwesome.Sharp.IconButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GridViewHoSo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExports = new FontAwesome.Sharp.IconButton();
            this.btnUpGrade = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFind = new FontAwesome.Sharp.IconButton();
            this.cbbListValue.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHoSo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbListValue
            // 
            this.cbbListValue.BackColor = System.Drawing.Color.White;
            this.cbbListValue.Controls.Add(this.btnRefesh);
            this.cbbListValue.Controls.Add(this.txtFind);
            this.cbbListValue.Controls.Add(this.panel2);
            this.cbbListValue.Controls.Add(this.panel1);
            this.cbbListValue.Controls.Add(this.label2);
            this.cbbListValue.Controls.Add(this.panel5);
            this.cbbListValue.Controls.Add(this.btnFind);
            this.cbbListValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbListValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbbListValue.Location = new System.Drawing.Point(0, 0);
            this.cbbListValue.Name = "cbbListValue";
            this.cbbListValue.Size = new System.Drawing.Size(1300, 850);
            this.cbbListValue.TabIndex = 4;
            this.cbbListValue.Click += new System.EventHandler(this.panel4_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.FlatAppearance.BorderSize = 4;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefesh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnRefesh.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateForward;
            this.btnRefesh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.btnRefesh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefesh.IconSize = 25;
            this.btnRefesh.Location = new System.Drawing.Point(1007, 89);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(114, 45);
            this.btnRefesh.TabIndex = 358;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFind.BackColor = System.Drawing.Color.White;
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.txtFind.Location = new System.Drawing.Point(527, 109);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(300, 19);
            this.txtFind.TabIndex = 133;
            this.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.GridViewHoSo);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 533);
            this.panel2.TabIndex = 132;
            // 
            // GridViewHoSo
            // 
            this.GridViewHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewHoSo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.GridViewHoSo.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GridViewHoSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewHoSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewHoSo.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridViewHoSo.Location = new System.Drawing.Point(0, 0);
            this.GridViewHoSo.Name = "GridViewHoSo";
            this.GridViewHoSo.Size = new System.Drawing.Size(1300, 533);
            this.GridViewHoSo.TabIndex = 131;
            this.GridViewHoSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewHoSo_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExports);
            this.panel1.Controls.Add(this.btnUpGrade);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 690);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 160);
            this.panel1.TabIndex = 130;
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
            this.btnExports.Location = new System.Drawing.Point(804, 37);
            this.btnExports.Name = "btnExports";
            this.btnExports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExports.Size = new System.Drawing.Size(119, 45);
            this.btnExports.TabIndex = 170;
            this.btnExports.Text = "Xuất";
            this.btnExports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExports.UseVisualStyleBackColor = true;
            this.btnExports.Click += new System.EventHandler(this.btnExports_Click);
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
            this.btnUpGrade.Location = new System.Drawing.Point(400, 37);
            this.btnUpGrade.Name = "btnUpGrade";
            this.btnUpGrade.Size = new System.Drawing.Size(119, 45);
            this.btnUpGrade.TabIndex = 128;
            this.btnUpGrade.Text = "Cập nhật";
            this.btnUpGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpGrade.UseVisualStyleBackColor = true;
            this.btnUpGrade.Click += new System.EventHandler(this.btnUpGrade_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(605, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(119, 45);
            this.btnAdd.TabIndex = 127;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.label2.Location = new System.Drawing.Point(405, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 122;
            this.label2.Text = "Tìm kiếm:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.panel5.Location = new System.Drawing.Point(527, 132);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 2);
            this.panel5.TabIndex = 124;
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
            this.btnFind.Location = new System.Drawing.Point(885, 89);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(87, 45);
            this.btnFind.TabIndex = 123;
            this.btnFind.Text = "Tìm";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // formStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 850);
            this.Controls.Add(this.cbbListValue);
            this.Name = "formStock";
            this.Text = "Quản lý hồ sơ chứng khoán";
            this.Load += new System.EventHandler(this.formStock_Load);
            this.cbbListValue.ResumeLayout(false);
            this.cbbListValue.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewHoSo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel cbbListValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnFind;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnExports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFind;
        private FontAwesome.Sharp.IconButton btnRefesh;
        public System.Windows.Forms.DataGridView GridViewHoSo;
        private FontAwesome.Sharp.IconButton btnUpGrade;
        private FontAwesome.Sharp.IconButton btnAdd;
    }
}