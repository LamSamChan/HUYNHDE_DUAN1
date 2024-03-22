using BUS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    public partial class formChildDataTP : Form
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
        private formDataTP gdtp;
        public formChildDataTP(formDataTP _gdtp)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            gdtp = _gdtp;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChildDataTP_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            stt.Text = "";
            mack.Text = "";
            ngay.Value = DateTime.Today;
            giadc.Text = "";
            tkl_lc.Text = "";
            tgt_lochan.Text = "";
            tkl_ll.Text = "";
            tgt_ll.Text = "";
            tong_kl_lc.Text = "";
            tong_gt_ll.Text = "";
            tong_gt_ll.Text = "";
            tong_gt_ll.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formMessage f = new formMessage();
            try
            {
                int Stt = Convert.ToInt32(stt.Text);
                string Ma_CK = mack.Text;
                float Gia_DC = float.Parse(giadc.Text);
                float TKL_LC = float.Parse(tkl_lc.Text);
                float TGT_LC = float.Parse(tgt_lochan.Text);
                float TKL_LL = float.Parse(tkl_ll.Text);
                float TGT_LL = float.Parse(tong_kl_lc.Text);
                float tong_KLGDLC = float.Parse(tong_kl_lc.Text);
                float tong_GTGDLC = float.Parse(tong_gt_lcgf.Text);
                float tong_KLGDLL = float.Parse(tong_kl_llgg.Text);
                float tong_GTGDLL = float.Parse(tong_gt_ll.Text);
                DateTime ngayGD = DateTime.ParseExact(ngay.Text, "dd/MM/yyyy", null);

                if (BUS_GiaoDichTraiPhieu.Instance.addData(Stt, ngayGD, Ma_CK, Gia_DC, TKL_LC, TGT_LC, TKL_LL, TGT_LL, tong_KLGDLC, tong_GTGDLC, tong_KLGDLL, tong_GTGDLL))
                {
                    f.showMessage("Thông báo", "Thêm thông tin thành công.", "icon_success.png", "Đóng");
                    gdtp.loadform();
                }
            }
            catch (Exception)
            {
                f.showMessage("Thông báo", "Có lỗi khi thêm dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
        }

        private void formChildDataTP_Load(object sender, EventArgs e)
        {

        }
    }
}