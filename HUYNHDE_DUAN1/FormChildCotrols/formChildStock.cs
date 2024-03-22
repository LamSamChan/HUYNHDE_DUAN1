using BUS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    public partial class formChildStock : Form
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
        private void panelLinearGradient1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion MouseDown Form
        private formStock stock;
        public formChildStock(formStock _stock)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            stock = _stock;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChildStock_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formMessage mess = new formMessage();
            try
            {
                string MaCk = txtMack.Text;
                string TenTCPH = txtTen.Text;
                string TruSoChinh = txtTruSo.Text;
                string DiaChiLienlac = txtSdt.Text;
                string GPTL = txtGPTL.Text;
                string TenNganh = txtNganh.Text;
                string NguoiDaiDien = txtNguoiDD.Text;
                string NguoiCongBo = txtNguoiCB.Text;
                string BanCaoBach = txtBanCao.Text;
                string TrangThaiKiemSoat = txtKiemSoat.Text;
                string TrangThaiGiaoDich = txtGiaoDich.Text;
                DateTime NgayGDDauTien = DateTime.ParseExact(dateTimePicker.Text, "dd/MM/yyyy", null);
                float VonDieuLe = float.Parse(txtVon.Text);
                float KLLH = float.Parse(txtKL.Text);
                float KLNY = float.Parse(txtKN.Text);
                string Link_BanCaoBach = txtLink.Text;
                if (BUS_HoSoCuPhieu.Instance.addDataHoSo(MaCk, TenTCPH, TruSoChinh, DiaChiLienlac, GPTL, TenNganh, NguoiDaiDien, NguoiCongBo, BanCaoBach, TrangThaiKiemSoat, TrangThaiGiaoDich, NgayGDDauTien, VonDieuLe, KLLH, KLNY, Link_BanCaoBach))
                {
                    mess.showMessage("Thông báo", "Chỉnh sửa thông tin thành công.", "icon_success.png", "Đóng");
                    stock.LoadGrid();
                }
            }
            catch (Exception)
            {
                mess.showMessage("Thông báo", "Có lỗi khi thêm dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
        }
    }
}