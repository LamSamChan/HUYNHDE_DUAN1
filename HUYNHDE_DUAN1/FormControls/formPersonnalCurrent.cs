using BUS;
using HUYNHDE_DUAN1.FormUI;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Image = System.Drawing.Image;

namespace HUYNHDE_DUAN1
{
    public partial class formPersonnalCurrent : Form
    {
        public static string IdNv;

        string email = Properties.Settings.Default.email;
        public formPersonnalCurrent()
        {
            InitializeComponent();
        }

        private void formPersonnalCurrent_Load(object sender, EventArgs e)
        {
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox2.Image = Image.FromFile("../../img/Group 2.png");
            loadData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        #region clear focus textbox

        private void panel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        #endregion clear focus textbox

        private void btnChangPass_Click(object sender, EventArgs e)
        {
            IdNv = manv;
            formChangesPass changesPass = new formChangesPass();
            changesPass.ShowDialog();
        }
        string manv;
        string image_temp;
        void loadData()
        {
            
            DataTable data = new DataTable();
            data = BUS_NhanVien.Instance.getPersonData(email);
            foreach (DataRow row in data.Rows)
            {
                manv = row[0].ToString();
                hovaten.Text = row[1].ToString();
                lb_mail.Text = row[2].ToString();
                if (lb_mail.Text == "Admin")
                {
                    lb_mail.Visible = false;
                }
                string[] date = row[6].ToString().Split('-');
                string new_format = date[2] + "/" + date[1] + "/" + date[0];
                ngay.Text = new_format;
                gioitinh.Text = row[3].ToString();
                chucvu.Text = row[8].ToString();
                sodienthoai.Text = row[4].ToString();
                cmnd.Text = row[5].ToString();
                diachi.Text = row[7].ToString();
                avatar.Image = Image.FromFile($"../../img/Avatar_user/{row[10].ToString()}");
                image_temp = row[10].ToString();
            }
        }
        string filePathImg;
        private void circularPictureBox2_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
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
                    CorrectFile = image_temp;
                }

                string sdth = sodienthoai.Text;
                string CCCD = cmnd.Text;
                string dc = diachi.Text;
                string img = CorrectFile;
                if (BUS_NhanVien.Instance.edit_infoPerson(manv, sdth, CCCD, dc,img))
                {
                    loadData();
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            formMessage f = new formMessage();
            f.showMessage("Thông báo", "Bạn có chắc chắn muốn thoát không ?", "icon_info.png", "Thoát");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            formMessage f = new formMessage();
            f.showMessage("Thông báo", "Bạn có chắc chắn muốn đăng xuất chứ?", "icon_info.png", "Đăng xuất");
        }
    }
}