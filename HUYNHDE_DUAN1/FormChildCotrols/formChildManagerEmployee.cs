using Aspose.Cells;
using BUS;
using HUYNHDE_DUAN1.FormChildCotrols;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;

namespace HUYNHDE_DUAN1
{
    public partial class formChildManagerEmployee : Form
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
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion MouseDown Form
        private FormManagerEmployee qlnv;
        formMessage f = new formMessage();
        
        public formChildManagerEmployee(FormManagerEmployee _qlnv)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            // CallBack BorderForms
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            qlnv = _qlnv;
            QTri.Checked = true;
            Nam.Checked = true;
            tb_maNV.Text = BUS_NhanVien.Instance.getIDNV();
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string CorrectFile = "";
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
                    Exception img = new IMGException();
                    throw img;

                }

                string maNV = tb_maNV.Text;
                string hoTen = tb_hoVaTen.Text;
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
                string SoDienThoai = tb_soDienThoai.Text;
                string CMND = tb_cccD.Text;
                DateTime ngaySinh = DateTime.ParseExact(ngay.Text, "dd/MM/yyyy", null);
                string DiaChi = tb_diaChi.Text;
                string ChucVu;
                if (QTri.Checked)
                {
                    ChucVu = "Quản Trị";
                }
                else
                {
                    ChucVu = "Nhân Viên";
                }
                string Anh = CorrectFile;
                string GhiChu = tb_Note.Text;
                string MatKhau = "123";
                if (String.IsNullOrEmpty(tb_hoVaTen.Text) || String.IsNullOrEmpty(tb_cccD.Text) || String.IsNullOrEmpty(tb_diaChi.Text) ||
                    String.IsNullOrEmpty(tb_Email.Text) || String.IsNullOrEmpty(tb_soDienThoai.Text))
                {
                    Exception nul = new NULLException();
                    throw nul;
                }
                if (IsValidEmail(Email) == false)
                {
                    Exception mail = new MAILException();
                    throw mail;
                }
                if (BUS_TaiKhoan.Instance.check_emailExist(Email))
                {
                    CHECKMAILException exist = new CHECKMAILException();
                    throw exist;
                }
                if (BUS_NhanVien.Instance.addData(maNV, hoTen, Email, GioiTinh, SoDienThoai, CMND,
                    ngaySinh, DiaChi, ChucVu, Anh, MatKhau, GhiChu))
                {
                    qlnv.LoadData();
                    
                    f.showMessage("Thông báo", "Mật khẩu sẽ được gửi đến email của bạn,\n" +
                        "dùng email để đăng nhập ứng dụng.", "icon_success.png", "Đóng");
                }
            }
            catch (IOException)
            {
               
                f.showMessage("Thông báo", "Có lỗi khi cập nhật dữ liệu, hãy kiểm tra lại!", "icon_error.png", "Đóng");
            }
            catch (IMGException img)
            {
                f.showMessage("Thông báo", "Không để ảnh trống.", "icon_info.png", "Đóng");
            }
            catch (MAILException mail)
            {
                f.showMessage("Thông báo", "Địa chỉ email không đúng cú pháp!", "icon_info.png", "Đóng");
            }
            catch (NULLException mail)
            {
                f.showMessage("Thông báo", "Không để trống thông tin cá nhân.", "icon_info.png", "Đóng");
            }
            catch (CHECKMAILException exist)
            {
                f.showMessage("Thông báo", "Email đã tồn tại.", "icon_info.png", "Đóng");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formChildManagerEmployee_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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
                avatar.SizeMode = PictureBoxSizeMode.StretchImage;

                using (Image image = Image.FromFile(filePathImg, true))
                {
                    avatar.Image = new Bitmap(image);
                }
            }
        }

    }
}