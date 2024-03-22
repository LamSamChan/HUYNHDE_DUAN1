using BUS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    public partial class formChildGDBDG : Form
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
        public formChildGDBDG(formGDBDG _gdbdg)
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

        private void formChildGDBDG_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string mack = txtMaCk.Text;
                DateTime ngayGiaoDich = DateTime.ParseExact(txtNgayGiaoDich.Text, "dd/MM/yyyy", null);
                double giaThamChieu = Convert.ToDouble(txtThamChieu.Text);
                double giaTran = Convert.ToDouble(txtGiaTran.Text);
                double giaSan = Convert.ToDouble(txtGiaSan.Text);
                double giaMo = Convert.ToDouble(txtGiaMo.Text);
                double giaDong = Convert.ToDouble(txtGiaDong.Text);
                double giaCao = Convert.ToDouble(txtGiaCao.Text);
                double giaThap = Convert.ToDouble(txtGiaThap.Text);
                double diem = Convert.ToDouble(txtGia.Text);
                double phanTram = Convert.ToDouble(txtPhanTram.Text);

                if (BUS_BienDongGia.Instance.AddBDG(ngayGiaoDich, mack, giaThamChieu, giaTran, giaSan, giaMo, giaDong, giaCao, giaThap, diem, phanTram))
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