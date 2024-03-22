using BUS;
using HUYNHDE_DUAN1.FormExportFile;
using HUYNHDE_DUAN1.FormUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Documents;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1.formShowClickGrid
{
    public partial class formShowGDTP : Form
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

        private formDataTP gdtp;

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

        public formShowGDTP(formDataTP _gdtp)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            gdtp = _gdtp;
        }

        private int id, stt;

        public void showData(List<string> data)
        {
            id = Convert.ToInt32(data[0]);
            stt = Convert.ToInt32(data[1]);

            DateTime dateTimeParsed;
            if (DateTime.TryParse(data[2], out dateTimeParsed))
                ngay.Value = dateTimeParsed;
            ngay.Enabled = false;
            title.Text = data[3];
            maCK.Text = data[3];
            //ngay.Text = data[2].Replace('-', '/');
            GiaDC.Text = data[4];
            TKLLC.Text = data[5];
            TGTLC.Text = data[6];
            TKLLL.Text = data[7];
            TGTLL.Text = data[8];
            tongKLGDLC.Text = data[9];
            tongGTGDLC.Text = data[10];
            tongKLGDLL.Text = data[11];
            tongGTGDLL.Text = data[12];
            this.ShowDialog();
        }

        public DataTable getdata()
        {
            DataTable data = new DataTable();

            List<string> text = new List<string>();
            text.Add(id.ToString());
            text.Add(stt.ToString());
            text.Add(ngay.Text);
            text.Add(maCK.Text);
            text.Add(GiaDC.Text);
            text.Add(TKLLC.Text);
            text.Add(TGTLC.Text);
            text.Add(TKLLL.Text);
            text.Add(TGTLL.Text);
            text.Add(tongKLGDLC.Text);
            text.Add(tongGTGDLC.Text);
            text.Add(tongKLGDLL.Text);
            text.Add(tongGTGDLL.Text);

            data.Columns.Add("ID");
            data.Columns.Add("STT");
            data.Columns.Add("Ngày giao dịch");
            data.Columns.Add("Mã chứng khoán");
            data.Columns.Add("Giá ĐC");
            data.Columns.Add("TKL GDKL lô chẵn");
            data.Columns.Add("TGT GDKL lô chẵn");
            data.Columns.Add("TKL GDKL lô lẻ");
            data.Columns.Add("TGT GDKL lô lẻ");
            data.Columns.Add("Tổng KLGD thỏa thuận lô chẵn");
            data.Columns.Add("Tổng GTGD thỏa thuận lô chẵn");
            data.Columns.Add("Tổng KLGD thỏa thuận lô lẻ");
            data.Columns.Add("Tổng GTGD thỏa thuận lô lẻ");

            DataRow row = data.NewRow();

            for (int i = 0; i < data.Columns.Count; i++)
            {
                row[i] = text[i];
            }
            data.Rows.Add(row);

            return data;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            formMessage f = new formMessage();
            f.showMessage("Thông báo", "Bạn có chắc muốn xoá dữ liệu không?", "icon_info.png", "Xác nhận");

            try
            {
                if (f.xacnhan)
                {
                    BUS_GiaoDichTraiPhieu.Instance.deleteData(id);
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
                gdtp.loadform();
            }

        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            formExShowTP show = new formExShowTP(this);
            show.ShowDialog();

        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = id;
                int Stt = stt;
                string Ma_CK = maCK.Text;
                float Gia_DC = float.Parse(GiaDC.Text);
                float TKL_LC = float.Parse(TKLLC.Text);
                float TGT_LC = float.Parse(TGTLC.Text);
                float TKL_LL = float.Parse(TKLLL.Text);
                float TGT_LL = float.Parse(TGTLL.Text);
                float tong_KLGDLC = float.Parse(tongKLGDLC.Text);
                float tong_GTGDLC = float.Parse(tongGTGDLC.Text);
                float tong_KLGDLL = float.Parse(tongKLGDLL.Text);
                float tong_GTGDLL = float.Parse(tongGTGDLL.Text);
                DateTime ngayGD = DateTime.ParseExact(ngay.Text, "dd/MM/yyyy", null);

                if (BUS_GiaoDichTraiPhieu.Instance.editData(Id, Stt, ngayGD, Ma_CK, Gia_DC, TKL_LC, TGT_LC, TKL_LL, TGT_LL, tong_KLGDLC, tong_GTGDLC, tong_KLGDLL, tong_GTGDLL))
                {
                    gdtp.loadform();
                    formMessage f = new formMessage();
                    f.showMessage("Thông báo", "Cập nhật thông tin thành công.", "icon_success.png", "Đóng");
                }
            }
            catch (Exception)
            {
                formMessage f = new formMessage();
                f.showMessage("Thông báo", "Có lỗi khi cập nhật dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
        }
    }
}