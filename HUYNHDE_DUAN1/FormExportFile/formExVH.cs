using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1.FormExportFile
{
    public partial class formExVH : Form
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

        private void panelLinearGradient1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);


            }
        }
        #endregion
        formMessage f = new formMessage();
        formGDBDG GDBDG;
        public formExVH(formGDBDG _GDBDG)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            GDBDG = _GDBDG;
        }
        private void excel_Click(object sender, EventArgs e)
        {
            DataGridView data = new DataGridView();
            data = GDBDG.GridVonHoa;
            string title = "DỮ LIỆU GIAO DICH THỐNG KÊ VỐN HOÁ ";
            List<char> kytu = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F' };
            if (data.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XLSX (*.xlsx)|*.xlsx";
                sfd.FileName = "DuLieuVH.xlsx";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            f.showMessage("ex.Message", $"Không thể lưu dữ liệu vào ổ đĩa!", "icon_error", "Đóng");
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            BUS_ExportFile.Instance.ExportFileXLSX_GDTP2(sfd.FileName, data, title, kytu);
                            f.showMessage("Thông báo", "Xuất dữ liệu thành công!", "icon_success.png", "Đóng");
                        }
                        catch (Exception ex)
                        {
                            f.showMessage("Thông báo", $"{ex.Message}", "icon_error", "Đóng");
                        }
                    }
                }
            }
            else
            {
                f.showMessage("Thông báo", "Không có dữ liệu để xuất!", "icon_error.png", "Đóng");
            }
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            DataGridView data = new DataGridView();
            data = GDBDG.GridVonHoa;
            float[] widths = new float[] { 20f, 50f, 40f, 40f, 50f , 50f};
            string title = "DỮ LIỆU GIAO DỊCH THỐNG KÊ VỐN HOÁ  ";
            if (data.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "DuLieuVH.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            f.showMessage($"{ex.Message}", $"Không thể lưu dữ liệu vào ổ đĩa!", "icon_error", "Đóng");
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            BUS_ExportFile.Instance.ExportFilePDF2(sfd.FileName, data, title, widths);
                            f.showMessage("Thông báo", "Xuất dữ liệu thành công!", "icon_success.png", "Đóng");
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                f.showMessage("Thông báo", "Không có dữ liệu để xuất!", "icon_error.png", "Đóng");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
