using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1.FormUI
{
    public partial class formChangesPass : Form
    {
        #region Border Forms
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nleftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWitdthEllipse,
            int nHeightEllipse
        );
        #endregion

        #region MouseDown Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

        #endregion
        private formMessage form = new formMessage();
        string passOld = formLoginGrogram.passCu;
        string Manv = formPersonnalCurrent.IdNv;
        public formChangesPass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.ActiveControl = null;
        }

        private void formChangesPass_Load(object sender, EventArgs e)
        {
            logoTeams.Image = Image.FromFile("../../img/huynhde_small.png");

            tb_email.Text = Properties.Settings.Default.email;
            lb_mkc.Visible=false;
            lb_mkm.Visible = false;
            lb_nlmk.Visible = false;
            btnShowPass.Visible = false;
            btnHidePass.Visible = false;
            iconPictureBox1.Visible = false;
            iconPictureBox2.Visible = false;
            iconPictureBox3.Visible = false;
            iconPictureBox4.Visible = false;
            txtPassNew.Visible = false;
            txtPassOld.Visible = false;
            txtReversePass.Visible = false;
         
        }

        #region 1
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPassOld.UseSystemPasswordChar == true)
            {
                btnHidePass.BringToFront();
                txtPassOld.UseSystemPasswordChar = false;
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassOld.UseSystemPasswordChar == false)
            {
                btnShowPass.BringToFront();
                txtPassOld.UseSystemPasswordChar = true;
            }
        }




        #endregion

        #region 2
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassNew.UseSystemPasswordChar == true)
            {
                iconPictureBox2.BringToFront();
                txtPassNew.UseSystemPasswordChar = false;
            }
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            if (txtPassNew.UseSystemPasswordChar == false)
            {
                iconPictureBox1.BringToFront();
                txtPassNew.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #region 3
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            if (txtReversePass.UseSystemPasswordChar == true)
            {
                iconPictureBox4.BringToFront();
                txtReversePass.UseSystemPasswordChar = false;
            }
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            if (txtReversePass.UseSystemPasswordChar == false)
            {
                iconPictureBox3.BringToFront();
                txtReversePass.UseSystemPasswordChar = true;
            }
        }


        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formMessage form = new formMessage();
            form.showMessage("Thông báo", "Bạn chắc chắn muốn đóng ?", "icon_info.png", "Xác nhận");
            if (form.xacnhan)
            {
                this.Close();
            }
        }

        private void ExitForms_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {
            
            lb_mkc.Visible = false;
            lb_mkm.Visible = false;
            lb_nlmk.Visible = false;
            btnShowPass.Visible = false;
            btnHidePass.Visible = false;
            iconPictureBox1.Visible = false;
            iconPictureBox2.Visible = false;
            iconPictureBox3.Visible = false;
            iconPictureBox4.Visible = false;
            txtPassNew.Visible = false;
            txtPassOld.Visible = false;
            txtReversePass.Visible = false;
            lb_xacnhan.Visible = true;
            xacnhan.Visible = true;
            btnConfirm.Text = "Xác nhận";
            BUS_TaiKhoan.Instance.sendkeyChange(tb_email.Text);
            form.showMessage("Thông báo", "Mã xác nhận đã được gửi đến email.", "icon_info.png", "Đóng");

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (btnConfirm.Text =="Xác nhận")
            {
                if (BUS_TaiKhoan.Instance.checkKey(xacnhan.Text))
                {
                    lb_mkc.Visible = true;
                    lb_mkm.Visible = true;
                    lb_nlmk.Visible = true;
                    btnShowPass.Visible = true;
                    btnHidePass.Visible = true;
                    iconPictureBox1.Visible = true;
                    iconPictureBox2.Visible = true;
                    iconPictureBox3.Visible = true;
                    iconPictureBox4.Visible = true;
                    txtPassNew.Visible = true;
                    txtPassOld.Visible = true;
                    txtReversePass.Visible = true;
                    lb_xacnhan.Visible = false;
                    xacnhan.Visible = false;
                    btnConfirm.Text = "Đổi mật khẩu";
                }
                else
                {
                    form.showMessage("Thông báo", "Mã xác nhận sai!!!", "icon_error.png", "Đóng");
                }
            }
            else
            {
                if (txtPassOld.Text != passOld)
                {
                    form.showMessage("Thông báo", "Sai mật khẩu cũ!!!", "icon_info.png", "Đóng");
                }
                else if (txtReversePass.Text != txtPassNew.Text)
                {
                    form.showMessage("Thông báo", "Mật khẩu không trùng!!!", "icon_info.png", "Đóng");
                }
                else if (String.IsNullOrEmpty(txtPassOld.Text) || String.IsNullOrEmpty(txtReversePass.Text) || String.IsNullOrEmpty(txtPassNew.Text) )
                {
                    form.showMessage("Thông báo", "Không để trống mật khẩu!!!", "icon_info.png", "Đóng");
                }
                else
                {
                    BUS_TaiKhoan.Instance.ChangePW(Manv, txtPassOld.Text, txtPassNew.Text);
                    form.showMessage("Thông báo", "Đổi mật khẩu thành công, \n" +
                        "bạn hãy đăng nhập lại.", "icon_success.png", "Đóng");
                    Properties.Settings.Default.PassWord = "";
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Application.Restart();
                }
            }
        }

    }
}
