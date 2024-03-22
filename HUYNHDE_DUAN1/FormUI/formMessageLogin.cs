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

namespace HUYNHDE_DUAN1
{
    public partial class formMessageLogin : Form
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

        #region MoveDownForm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelLinearGradient1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);


            }
        }
        #endregion
        public formMessageLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }
        public void showMessage(string title, string text, string icon, string textbutton)
        {
            tt.Text = title;
            info.Text = text;
            pic.Image = Image.FromFile($"../../img/icon_info/{icon}");
            button.Text = textbutton.Trim();
            this.ShowDialog();

            //using static HUYNHDE_DUAN1.formMessage;
            /*formMessage form = new formMessage();
            form.showMessage("Thông báo", "Thiếu thông tin", "icon_info_main.png");*/
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (button.Text == "Thoát")
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

       
    }
}
