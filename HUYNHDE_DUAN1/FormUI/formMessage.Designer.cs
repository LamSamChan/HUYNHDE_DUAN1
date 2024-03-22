namespace HUYNHDE_DUAN1
{
    partial class formMessage
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
            this.panelLinearGradient1 = new HUYNHDE_DUAN1.contructions_functions.panelLinearGradient();
            this.button = new FontAwesome.Sharp.IconButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnEx = new FontAwesome.Sharp.IconButton();
            this.info = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.Label();
            this.panelLinearGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLinearGradient1
            // 
            this.panelLinearGradient1.BackColor = System.Drawing.Color.Transparent;
            this.panelLinearGradient1.Colorleft = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.panelLinearGradient1.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(200)))));
            this.panelLinearGradient1.Controls.Add(this.button);
            this.panelLinearGradient1.Controls.Add(this.pic);
            this.panelLinearGradient1.Controls.Add(this.btnEx);
            this.panelLinearGradient1.Controls.Add(this.info);
            this.panelLinearGradient1.Controls.Add(this.tt);
            this.panelLinearGradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLinearGradient1.Location = new System.Drawing.Point(0, 0);
            this.panelLinearGradient1.Name = "panelLinearGradient1";
            this.panelLinearGradient1.Size = new System.Drawing.Size(549, 252);
            this.panelLinearGradient1.TabIndex = 0;
            this.panelLinearGradient1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLinearGradient1_MouseDown);
            // 
            // button
            // 
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.FlatAppearance.BorderSize = 4;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button.IconSize = 25;
            this.button.Location = new System.Drawing.Point(426, 200);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(111, 40);
            this.button.TabIndex = 36;
            this.button.Text = "Đóng";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(17, 79);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(140, 132);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 13;
            this.pic.TabStop = false;
            // 
            // btnEx
            // 
            this.btnEx.BackColor = System.Drawing.Color.Transparent;
            this.btnEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEx.FlatAppearance.BorderSize = 0;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.ForeColor = System.Drawing.Color.Transparent;
            this.btnEx.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnEx.IconColor = System.Drawing.Color.White;
            this.btnEx.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEx.IconSize = 20;
            this.btnEx.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEx.Location = new System.Drawing.Point(513, 3);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(33, 30);
            this.btnEx.TabIndex = 12;
            this.btnEx.UseVisualStyleBackColor = false;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(173, 112);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(43, 25);
            this.info.TabIndex = 11;
            this.info.Text = "text";
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(251)))));
            this.tt.Location = new System.Drawing.Point(12, 9);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(124, 29);
            this.tt.TabIndex = 1;
            this.tt.Text = "Cảnh báo";
            // 
            // formMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(549, 252);
            this.Controls.Add(this.panelLinearGradient1);
            this.Name = "formMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formMessage";
            this.Load += new System.EventHandler(this.formMessage_Load);
            this.panelLinearGradient1.ResumeLayout(false);
            this.panelLinearGradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private contructions_functions.panelLinearGradient panelLinearGradient1;
        public System.Windows.Forms.Label tt;
        public System.Windows.Forms.Label info;
        private FontAwesome.Sharp.IconButton btnEx;
        private System.Windows.Forms.PictureBox pic;
        private FontAwesome.Sharp.IconButton button;
    }
}