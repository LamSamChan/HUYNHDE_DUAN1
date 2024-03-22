using Aspose.Cells.Charts;
using BUS;
using HUYNHDE_DUAN1.FormExportFile;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1.formShowClickGrid
{
    public partial class formShowStock : Form
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
        private void panelLinearGradient1_MouseDown_1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion MouseDown Form

        private formStock stock;

        public formShowStock(formStock _stock)
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
        private int iD;

        public void bindindDataGrid(List<string> data)
        {
            iD = Convert.ToInt32(data[0]);
            title.Text = data[1];
            txtMaCK.Text = data[1];
            txtTen.Text = data[2];
            txtTruSo.Text = data[3];
            txtSdt.Text = data[4];
            txtGPTL.Text = data[5];
            txtNganh.Text = data[6];
            txtNguoiDD.Text = data[7];
            txtNguoiCB.Text = data[8];
            txtBangCao.Text = data[9];
            txtKiemSoat.Text = data[10];
            txtGiaoDich.Text = data[11];
            DateTime dateTimeParsed;
            if (DateTime.TryParse(data[12], out dateTimeParsed))
                dateTimePicker.Value = dateTimeParsed;
            txtVon.Text = data[13];
            txtKLLH.Text = data[14];
            txtKLNY.Text = data[15];
            txtLink.Text = data[16];

        }
        public DataTable getdata()
        {
            DataTable data = new DataTable();

            List<string> text = new List<string>();
            text.Add(iD.ToString());
            text.Add(txtMaCK.Text);
            text.Add(txtTen.Text);
            text.Add(txtTruSo.Text);
            text.Add(txtSdt.Text);
            text.Add(txtGPTL.Text);
            text.Add(txtNganh.Text);
            text.Add(txtNguoiDD.Text);
            text.Add(txtNguoiCB.Text);
            text.Add(txtBangCao.Text);
            text.Add(txtKiemSoat.Text);
            text.Add(txtGiaoDich.Text);
            text.Add(dateTimePicker.Text);
            text.Add(txtVon.Text);
            text.Add(txtKLLH.Text);
            text.Add(txtKLNY.Text);
            text.Add(txtLink.Text);

            data.Columns.Add("ID");
            data.Columns.Add("Mã CK");
            data.Columns.Add("Tên TCPH");
            data.Columns.Add("Trụ sở chính");
            data.Columns.Add("Số điện thoại");
            data.Columns.Add("GTPL/ĐKKD");
            data.Columns.Add("Tên ngành");
            data.Columns.Add("Người đại diện pháp luật");
            data.Columns.Add("Người công bố thông tin");
            data.Columns.Add("Bản cáo bạch");
            data.Columns.Add("Trạng thái kiểm soát");
            data.Columns.Add("Trạng thái giao dịch");
            data.Columns.Add("Ngày GD đầu tiên");
            data.Columns.Add("Vốn điều lệ (Nghìn đồng)");
            data.Columns.Add("KLLH (Cổ phiếu)");
            data.Columns.Add("KLNY (Cổ phiếu)");
            data.Columns.Add("Link_BCB");

            DataRow row = data.NewRow();

            for (int i = 0; i < data.Columns.Count; i++)
            {
                row[i] = text[i];
            }
            data.Rows.Add(row);

            return data;

        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            formExShowStock show = new formExShowStock(this);
            show.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formMessage mess = new formMessage();

            try
            {
                string MaCk = txtMaCK.Text;
                string TenTCPH = txtTen.Text;
                string TruSoChinh = txtTruSo.Text;
                string DiaChiLienlac = txtSdt.Text;
                string GPTL = txtGPTL.Text;
                string TenNganh = txtNganh.Text;
                string NguoiDaiDien = txtNguoiDD.Text;
                string NguoiCongBo = txtNguoiCB.Text;
                string BanCaoBach = txtBangCao.Text;
                string TrangThaiKiemSoat = txtKiemSoat.Text;
                string TrangThaiGiaoDich = txtGiaoDich.Text;
                DateTime NgayGDDauTien = DateTime.ParseExact(dateTimePicker.Text, "dd/MM/yyyy", null);
                float VonDieuLe = float.Parse(txtVon.Text);
                float KLLH = float.Parse(txtKLLH.Text);
                float KLNY = float.Parse(txtKLNY.Text);
                string Link_BanCaoBach = txtLink.Text;
                if (BUS_HoSoCuPhieu.Instance.upGradeDataHoSo(MaCk, TenTCPH, TruSoChinh, DiaChiLienlac, GPTL, TenNganh, NguoiDaiDien, NguoiCongBo, BanCaoBach, TrangThaiKiemSoat, TrangThaiGiaoDich, NgayGDDauTien, VonDieuLe, KLLH, KLNY, Link_BanCaoBach))
                {
                    mess.showMessage("Thông báo", "Thêm thông tin thành công.", "icon_success.png", "Đóng");
                    stock.LoadGrid();
                }
            }
            catch (Exception)
            {
                mess.showMessage("Thông báo", "Có lỗi khi thêm dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            formMessage mess = new formMessage();
            try
            {
                 BUS_HoSoCuPhieu.Instance.DeleteData(txtMaCK.Text);
                mess.showMessage("Thông báo", "Xóa thông tin thành công.", "icon_success.png", "Đóng");
                stock.LoadGrid();
            }
            catch 
            {
                mess.showMessage("Thông báo", "Có lỗi khi thêm dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");

            }
        }

   
    }
}