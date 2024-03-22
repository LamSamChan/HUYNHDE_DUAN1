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
    public partial class formChildVH : Form
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
        private void panelControlForm_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);


            }
        }

        #endregion

        private formGDBDG gdbdg;
        public formChildVH(formGDBDG _gdbdg)
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

        private void formChildVH_Click(object sender, EventArgs e)
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
                double vonHoa = Convert.ToDouble(txtVonHoa.Text);
                double thiTruong = Convert.ToDouble(txtThiTruong.Text);
               

                if (BUS_VonHoa.Instance.AddVH(ngayGiaoDich, mack, giaDong, vonHoa, thiTruong))
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
