using BUS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    public partial class formForgetPass : Form
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

        #endregion Border Forms

        private formMessageLogin form = new formMessageLogin();

        public formForgetPass()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void formForgetPass_Load(object sender, EventArgs e)
        {
            ImgForgetLogin.Image = Image.FromFile("../../img/bannerForget.png");
            logoForgetLogin.Image = Image.FromFile("../../img/forgetUseLogin.png");
        }

        private void ExitForms_Click(object sender, EventArgs e)
        {
            form.showMessage("Thông báo", "Bạn có thực sự muốn thoát chương trình?", "icon_info_login.png", "Thoát");
        }

        #region MouseDown Form

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ImgForgetLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion MouseDown Form

        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void btnSendkey_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txtUsername.Text) == false)
            {
                form.showMessage("Thông báo", "Bạn hãy điền đúng địa chỉ email!!", "icon_info_login.png", "Đóng");
            }
            else
            {
                BUS_TaiKhoan.Instance.sendkey(txtUsername.Text);
                form.showMessage("Thông báo", "Mã xác nhận đã được gửi đến email.", "icon_info_login.png", "Đóng");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (BUS_TaiKhoan.Instance.checkKey(txtPassword.Text))
            {
                BUS_TaiKhoan.Instance.resetPW(txtUsername.Text);

                form.showMessage("Thông báo", "Đặt lại mật khẩu thành công,\n" +
                "Mật khẩu mới đã được gửi đến email.", "icon_success_login.png", "Đóng");
            }
            else
            {
                form.showMessage("Thông báo", "Sai mã xác nhận !!!", "icon_info_login.png", "Đóng");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnConfirm_Click(sender, e);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnConfirm_Click(sender, e);
            }
        }

        private void ImgForgetLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelLinearGradient2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void back_Click(object sender, EventArgs e)
        {
            formLoginGrogram fg = new formLoginGrogram();
            fg.Show();
            this.Hide();
        }
    }
}