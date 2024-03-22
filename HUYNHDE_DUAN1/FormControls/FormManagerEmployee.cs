using Aspose.Cells;
using BUS;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HUYNHDE_DUAN1
{
    public partial class FormManagerEmployee : Form
    {
        private formMessage f = new formMessage();
        public FormManagerEmployee()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            formChildManagerEmployee mf = new formChildManagerEmployee(this);
            main.Opacity = 70;
            mf.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        public void LoadData()
        {
            dataGridNV.ForeColor = System.Drawing.Color.Black;
            dataGridNV.DataSource = BUS_NhanVien.Instance.LoadData();
        }
        string image_temp;
        private void dataGridNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridNV.SelectedRows)
            {
                tb_maNV.Text = r.Cells[0].Value.ToString();
                tb_hoTen.Text = r.Cells[1].Value.ToString();
                tb_Email.Text = r.Cells[2].Value.ToString();
                if (r.Cells[3].Value.ToString() == "Nam")
                {
                    Nam.Checked = true;
                }
                else
                {
                    Nu.Checked = true;
                }
                tb_sDth.Text = r.Cells[4].Value.ToString();
                tb_CCCD.Text = r.Cells[5].Value.ToString();
                string[] date = dataGridNV.CurrentRow.Cells[6].Value.ToString().Split('-');
                string new_format = date[2] + "/" + date[1] + "/" + date[0];
                ngay.Text = new_format.ToString();
                tb_diaChi.Text = r.Cells[7].Value.ToString();
                if (r.Cells[8].Value.ToString() == "Quản Trị")
                {
                    qTri.Checked = true;
                }
                else
                {
                    nVien.Checked = true;
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = Image.FromFile($"../../img/Avatar_user/{r.Cells[10].Value}");
                image_temp = r.Cells[10].Value.ToString();
                tb_note.Text = r.Cells[9].Value.ToString();
            }
        }

        private string filePathImg;

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png)|*.jpg; *.jpeg; *.bmp; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //pic.Image = new Bitmap(ofd.FileName);
                filePathImg = ofd.FileName;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                using (Image image = Image.FromFile(filePathImg, true))
                {
                    pic.Image = new Bitmap(image);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string CorrectFile ="";
                string targetPath = "";
                string workingDirectory = "";
                if (filePathImg != null)
                {
                    workingDirectory = Environment.CurrentDirectory;

                    targetPath = Directory.GetParent(workingDirectory).Parent.FullName + @"\img\Avatar_user\";
                    CorrectFile = System.IO.Path.GetFileName(filePathImg);
                    System.IO.File.Copy(filePathImg, targetPath + CorrectFile, true);
                }
                else
                {
                    CorrectFile = image_temp;
                }

                string maNV = tb_maNV.Text;
                string hoTen = tb_hoTen.Text;
                string Email = tb_Email.Text;
                string GioiTinh;
                if (Nam.Checked)
                {
                    GioiTinh = "Nam";
                }
                else
                {
                    GioiTinh = "Nữ";
                }
                string SoDienThoai = tb_sDth.Text;
                string CMND = tb_CCCD.Text;
                DateTime ngaySinh = DateTime.ParseExact(ngay.Text, "dd/MM/yyyy", null);
                string DiaChi = tb_diaChi.Text;
                string ChucVu;
                if (qTri.Checked)
                {
                    ChucVu = "Quản Trị";
                }
                else
                {
                    ChucVu = "Nhân Viên";
                }
                string Anh = CorrectFile;
                string GhiChu = tb_note.Text;

                if (BUS_NhanVien.Instance.editData(maNV, hoTen, Email, GioiTinh, SoDienThoai, CMND,
                    ngaySinh, DiaChi, ChucVu, Anh, GhiChu))
                {
                    LoadData();
                    formMessage f = new formMessage();
                    f.showMessage("Thông báo", "Cập nhật thông tin thành công.", "icon_success.png", "Đóng");
                }
            }
            catch (IOException)
            {
                formMessage f = new formMessage();
                f.showMessage("Thông báo", "Có lỗi khi cập nhật dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            formMessage f = new formMessage();
            f.showMessage("Thông báo", "Bạn có chắc muốn xoá dữ liệu không?", "icon_info.png", "Xác nhận");

            try
            {
                if (tb_maNV.Text == "Admin")
                {
                    f.showMessage("Thông báo", "Đây là tài khoản Admin không thể xoá.", "icon_info.png", "Đóng");
                }else if (Properties.Settings.Default.email == tb_Email.Text)
                {
                    f.showMessage("Thông báo", "Bạn không thể tự xoá chính mình.", "icon_info.png", "Đóng");
                }else
                if (f.xacnhan)
                {
                    BUS_NhanVien.Instance.deleteData(tb_maNV.Text);
                    clear();
                    f.showMessage("Thông báo", "Xoá dữ liệu thành công.", "icon_success.png", "Đóng");
                }
            }
            catch (Exception)
            {
                f.showMessage("Thông báo", "Có lỗi khi xoá dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
        }

        public void clear()
        {
            tb_maNV.Text = "";
            tb_hoTen.Text = "";
            tb_Email.Text = "";
            qTri.Checked = true;
            Nam.Checked = true;
            ngay.Value = DateTime.Today;
            tb_sDth.Text = "";
            tb_CCCD.Text = "";
            tb_diaChi.Text = "";
            pic.Image = null;
            tb_note.Text = "";
            LoadData();
        }

        public void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_tim_TextChanged(object sender, EventArgs e)
        {
            dataGridNV.DataSource = BUS_NhanVien.Instance.findData(tb_tim.Text.Replace('/', '-'));
        }
    }
}