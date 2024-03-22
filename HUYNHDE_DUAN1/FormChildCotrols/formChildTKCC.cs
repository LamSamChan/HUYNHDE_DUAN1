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

namespace HUYNHDE_DUAN1.FormChildCotrols
{
    public partial class formChildTKCC : Form
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

        #region MoveDownForm
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panelControlForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);


            }
        }

        #endregion
        private formGDBDG gdbdg;
        public formChildTKCC(formGDBDG _gdbdg)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            gdbdg = _gdbdg;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChildTKCC_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string mack = txtMaCK.Text;
                DateTime ngayGiaoDich = DateTime.ParseExact(txtNgayGiaoDich.Text, "dd/MM/yyyy", null);
                double giaDong = Convert.ToDouble(txtGiaDong.Text);
                double lenhMua = Convert.ToDouble(txtLenhMua.Text);
                double luongMua = Convert.ToDouble(txtLuongMua.Text);
                double lenhBan = Convert.ToDouble(txtLenhBan.Text);
                double luongBan = Convert.ToDouble(txtLuongban.Text);
                double duMua = Convert.ToDouble(txtDuMua.Text);
                double duBan = Convert.ToDouble(txtDuBan.Text);
                double kLGD = Convert.ToDouble(txtKLGD.Text);
                double gTGD = Convert.ToDouble(txtGTGD.Text);

                if (BUS_CungCau.Instance.AddCC(ngayGiaoDich, mack, giaDong, lenhMua, luongMua, lenhBan, luongBan, duMua, duBan, kLGD, gTGD))
                {
                    formMessage f = new formMessage();
                    f.showMessage("Thông báo", "Cập nhật thông tin thành công.", "icon_success.png", "Đóng");
                }
            }
            catch (Exception)
            {
                formMessage f = new formMessage();
                f.showMessage("Thông báo", "Có lỗi khi cập nhật dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
            finally
            {
                gdbdg.loadform();
            }
        }
    }
}
