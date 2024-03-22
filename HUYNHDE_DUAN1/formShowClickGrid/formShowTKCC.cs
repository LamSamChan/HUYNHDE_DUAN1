using BUS;
using HUYNHDE_DUAN1.FormExportFile;
using HUYNHDE_DUAN1.FormUI;
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

namespace HUYNHDE_DUAN1.formShowClickGrid
{
    public partial class formShowTKCC : Form
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

        #region MouseDown Form

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
        #endregion MouseDown Form
        private formGDBDG gdbdg;
        public formShowTKCC(formGDBDG _gdbdg)
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
            formGDBDG formGDBDG = new formGDBDG();
            //   formGDBDG.Loadd();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string mack = txtMaCK.Text;
                DateTime ngayGiaoDich = DateTime.ParseExact(txtNgayGiaoDich.Text, "dd/MM/yyyy", null);
                double GiaDong = Convert.ToDouble(txtGiaDong.Text);
                double LenhMua = Convert.ToDouble(txtLenhMua.Text);
                double LuongMua = Convert.ToDouble(txtLuongMua.Text);
                double LenhBan = Convert.ToDouble(txtLenhBan.Text);
                double LuongBan = Convert.ToDouble(txtLuongBan.Text);
                double DuMua = Convert.ToDouble(txtDuMua.Text);
                double DuBan = Convert.ToDouble(txtDuBan.Text);
                double KhoiLuongGd = Convert.ToDouble(txtKLGD.Text);
                double GiaTriGD = Convert.ToDouble(txtGTGD.Text);

                if (BUS_CungCau.Instance.UpdateCC(ngayGiaoDich, mack, GiaDong, LenhMua, LuongMua, LenhBan, LuongBan, DuMua, DuBan, KhoiLuongGd, GiaTriGD))
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            formMessage f = new formMessage();
            f.showMessage("Thông báo", "Bạn có chắc muốn xoá dữ liệu không?", "icon_info.png", "Xác nhận");
            int id = int.Parse(title.Text);
            DateTime ngayGiaoDich = DateTime.ParseExact(txtNgayGiaoDich.Text, "dd/MM/yyyy", null);
            try
            {
                if (f.xacnhan)
                {
                    BUS_CungCau.Instance.deleteCC(id);
                    this.Close();
                    f.showMessage("Thông báo", "Xoá dữ liệu thành công.", "icon_success.png", "Đóng");
                }
            }
            catch (Exception)
            {
                f.showMessage("Thông báo", "Có lỗi khi xoá dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
            finally
            {
                gdbdg.loadform();
            }
        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            FormExShowKC show = new FormExShowKC();
            show.ShowDialog();
        }

       
    }
}
