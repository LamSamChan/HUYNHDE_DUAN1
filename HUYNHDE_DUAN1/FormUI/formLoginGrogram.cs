using BUS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    public partial class formLoginGrogram : Form
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


        
        public static string Email;
        public static string passCu;
        public formLoginGrogram()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.ActiveControl = null;
        }


        private void ExitForms_Click(object sender, EventArgs e)
        {
            formMessageLogin form = new formMessageLogin();
            form.showMessage("Thông báo", "Bạn có thực sự muốn thoát chương trình?", "icon_info_login.png", "Thoát");
        }

        private void formLoginGrogram_Load(object sender, EventArgs e)
        {
            imgLogin.Image = Image.FromFile("../../img/login_bg.png");
            logoLogin.Image = Image.FromFile("../../img/user_login.png");
            txtPassword.UseSystemPasswordChar = true;
            passCu = txtPassword.Text;

            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txtUsername.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.PassWord;
                checkReme.Checked = true;
            }

        }


        #region MouseDown Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void imgLogin_MouseDown(object sender, MouseEventArgs e)
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

        #endregion

        private void btnSignin_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            formGDBDG bg = new formGDBDG();
            formDataTP tp = new formDataTP();
            formStock st = new formStock();
           

            var userName = txtUsername.Text;
            var passWord = txtPassword.Text;
            passCu = txtPassword.Text;
            Email = txtUsername.Text;

            string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(userName);
            if (Convert.ToBoolean(Vaitro) == false)
            {
                f.btnFormManagerEmplyee.Visible = false;

            }


            if (checkReme.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.PassWord = txtPassword.Text;
                Properties.Settings.Default.email = txtUsername.Text;
                Properties.Settings.Default.Save();
            }
            else if (checkReme.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.Save();
            }

            formMessageLogin msLogin = new formMessageLogin();
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                msLogin.showMessage("Thông báo", "Không được để trống thông tin!", "icon_info_login.png", "Đóng");
            }
            else if (BUS_TaiKhoan.Instance.Login(userName, passWord))
            {
                
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                msLogin.showMessage("Thông báo", "Sai tài khoản hoặc mật khẩu!", "icon_error_login.png", "Đóng");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formForgetPass fg = new formForgetPass();
            fg.Show();
            this.Hide();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnSignin_Click(sender, e);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnSignin_Click(sender, e);
            }
        }

        private void imgLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panelLinearGradient2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

       

        //private void txtUsername_Leave(object sender, EventArgs e)
        //{
        //    if (txtUsername.Text.Length == 0)
        //    {
        //        txtUsername.Text = "Enter UserName";
        //        txtUsername.ForeColor = Color.Gray;
        //        SelectNextControl(txtUsername, true, true, false, true);
        //    }
        //}

        //private void txtPassword_Leave(object sender, EventArgs e)
        //{
        //    if (txtPassword.Text.Length == 0)
        //    {
        //        txtPassword.ForeColor = Color.Gray;
        //        txtPassword.Text = "Enter PassWord";
        //        txtPassword.UseSystemPasswordChar = false;
        //        SelectNextControl(txtPassword, true, true, false, true);
        //    }
        //}

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == true)
            {
                btnHidePass.BringToFront();
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                btnShowPass.BringToFront();
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            formMessageLogin msLogin = new formMessageLogin();
            msLogin.showMessage("Thông báo", "Bạn chắc chắc muốn thoát chứ ??", "icon_info_login.png", "Thoát");
        }
    }
}
