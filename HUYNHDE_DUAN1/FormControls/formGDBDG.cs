using BUS;
using HUYNHDE_DUAN1.FormChildCotrols;
using HUYNHDE_DUAN1.FormExportFile;
using HUYNHDE_DUAN1.formShowClickGrid;
using HUYNHDE_DUAN1.FormUI;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media;
using static HUYNHDE_DUAN1.formMessage;

namespace HUYNHDE_DUAN1
{
    public partial class formGDBDG : Form
    {
        public formGDBDG()
        {
            InitializeComponent();
            fromdate_bdg.Value = DateTime.Today;
            fromdate_tkcc.Value = DateTime.Today;
            fromdate_vh.Value = DateTime.Today;
            todate_tkcc.Value = DateTime.Today;
            fromdate_bdg.Value = DateTime.Today;
            todate_vh.Value = DateTime.Today;
        }
        private void panel1_Click(object sender, System.EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel2_Click(object sender, System.EventArgs e)
        {
            this.ActiveControl = null;
        }



        #region Controls btn BDG
        private void btnAddBDG_Click(object sender, System.EventArgs e)
        {
            formChildGDBDG dg = new formChildGDBDG(this);
            dg.ShowDialog();
        }
       /* private void btnExportsBDG_Click(object sender, System.EventArgs e)
        {
            formMesageExFile showFormMessageEx = new formMesageExFile();
            showFormMessageEx.ShowDialog();

        }*/

        private void btnUpGradeBDG_Click(object sender, System.EventArgs e)
        {
            formMessage f = new formMessage();
            Thread mess = new Thread(new ThreadStart(() =>
            {
                f.showMessage("Thông báo", "Đang cập nhật dữ liệu...", "icon_info.png", "Đóng");
            }));
            if (BUS_BienDongGia.Instance.DongBoBDG() == true)
            {
                f.showMessage("Thông báo", "Dung cap nhat", "icon_info.png", "Đóng");
            }
            else { f.showMessage("Thông báo", "câp nhật thành công", "icon_info.png", "Đóng"); loadform(); }
        }
        #endregion   

        #region Controls btn TKCC
        private void btnUpGradeTKCC_Click(object sender, System.EventArgs e)
        {
            formMessage f = new formMessage();
            Thread mess = new Thread(new ThreadStart(() =>
            {
                f.showMessage("Thông báo", "Đang cập nhật dữ liệu...", "icon_info.png", "Đóng");
            }));

            if (BUS_CungCau.Instance.DongBoCungCau() == true)
            {
                f.showMessage("Thông báo", "Dung cap nhat", "icon_info.png", "Đóng");
            }
            else { f.showMessage("Thông báo", "câp nhật thành công", "icon_info.png", "Đóng"); loadform(); }
        }

        private void btnAddTKCC_Click(object sender, System.EventArgs e)
        {
            formChildTKCC tk = new formChildTKCC(this);
            tk.ShowDialog();
        }

        /* private void btnExportTKCC_Click(object sender, System.EventArgs e)
         {
             formMesageExFile showFormMessageEx = new formMesageExFile();
             showFormMessageEx.ShowDialog();
         }*/
        #endregion

        #region Controls btn VH
        private void btnUpgradeVH_Click(object sender, System.EventArgs e)
        {
            formMessage f = new formMessage();
            Thread mess = new Thread(new ThreadStart(() =>
            {
                f.showMessage("Thông báo", "Đang cập nhật dữ liệu...", "icon_info.png", "Đóng");
            }));

            if (BUS_VonHoa.Instance.DongBoVonHoa() == true)
            {
                f.showMessage("Thông báo", "Dung cap nhat", "icon_info.png", "Đóng");
            }
            else { f.showMessage("Thông báo", "câp nhật thành công", "icon_info.png", "Đóng"); loadform(); }
        }

        private void btnAddVH_Click(object sender, System.EventArgs e)
        {
            formChildVH vh = new formChildVH(this);
            vh.ShowDialog();
        }

        /*private void btnExportVH_Click(object sender, System.EventArgs e)
        {
            formMesageExFile showFormMessageEx = new formMesageExFile();
            showFormMessageEx.ShowDialog();
        }*/
        #endregion
        public void Loadd()
        {
            GridBDG.ForeColor = System.Drawing.Color.Black;
            GridCungCau.ForeColor = System.Drawing.Color.Black;
            GridVonHoa.ForeColor = System.Drawing.Color.Black;
            BUS_BienDongGia.Instance.LoadBGD(GridBDG);
            BUS_CungCau.Instance.loadCungCau(GridCungCau);
            BUS_VonHoa.Instance.loadCVonHoa(GridVonHoa);

        }
        public void loadform()
        {
            formShowBDG BDG = new formShowBDG(this);
            formShowTKCC CC = new formShowTKCC(this);
            formShowVH VH = new formShowVH(this);
            GridBDG.DataSource = null;
            GridBDG.ForeColor = System.Drawing.Color.Black;
            BUS_BienDongGia.Instance.LoadBGD(GridBDG);
            BUS_CungCau.Instance.loadCungCau(GridCungCau);
            BUS_VonHoa.Instance.loadCVonHoa(GridVonHoa);
        }

        private void GridBDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

                if (Convert.ToBoolean(Vaitro) == true)
                {
                    formShowBDG f = new formShowBDG(this);
                    f.title.Text = GridBDG.CurrentRow.Cells[0].Value.ToString();
                    f.txtNgayGiaoDich.Text = GridBDG.CurrentRow.Cells[1].Value.ToString().Replace('-', '/');
                    f.txtMaCk.Text = GridBDG.CurrentRow.Cells[2].Value.ToString();
                    f.txtThamChieu.Text = GridBDG.CurrentRow.Cells[3].Value.ToString();
                    f.txtGiaTran.Text = GridBDG.CurrentRow.Cells[4].Value.ToString();
                    f.txtGiaSan.Text = GridBDG.CurrentRow.Cells[5].Value.ToString();
                    f.txtGiaMo.Text = GridBDG.CurrentRow.Cells[6].Value.ToString();
                    f.txtGiaDong.Text = GridBDG.CurrentRow.Cells[7].Value.ToString();
                    f.txtGiaCao.Text = GridBDG.CurrentRow.Cells[8].Value.ToString();
                    f.txtGiaThap.Text = GridBDG.CurrentRow.Cells[9].Value.ToString();
                    f.txtGia.Text = GridBDG.CurrentRow.Cells[10].Value.ToString();
                    f.txtPhanTram.Text = GridBDG.CurrentRow.Cells[11].Value.ToString();

                    f.ShowDialog();
                }
            }
            catch { }
        }

        private void GridCungCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

                if (Convert.ToBoolean(Vaitro) == true)
                {
                    formShowTKCC f = new formShowTKCC(this);

                    f.title.Text = GridCungCau.CurrentRow.Cells[0].Value.ToString();
                    f.txtNgayGiaoDich.Text = GridCungCau.CurrentRow.Cells[1].Value.ToString().Replace('-', '/');
                    f.txtMaCK.Text = GridCungCau.CurrentRow.Cells[2].Value.ToString();
                    f.txtGiaDong.Text = GridCungCau.CurrentRow.Cells[3].Value.ToString();
                    f.txtLenhMua.Text = GridCungCau.CurrentRow.Cells[4].Value.ToString();
                    f.txtLuongMua.Text = GridCungCau.CurrentRow.Cells[5].Value.ToString();
                    f.txtLenhBan.Text = GridCungCau.CurrentRow.Cells[6].Value.ToString();
                    f.txtLuongBan.Text = GridCungCau.CurrentRow.Cells[7].Value.ToString();
                    f.txtDuMua.Text = GridCungCau.CurrentRow.Cells[8].Value.ToString();
                    f.txtDuBan.Text = GridCungCau.CurrentRow.Cells[9].Value.ToString();
                    f.txtKLGD.Text = GridCungCau.CurrentRow.Cells[10].Value.ToString();
                    f.txtGTGD.Text = GridCungCau.CurrentRow.Cells[11].Value.ToString();

                    f.ShowDialog();
                }
            }
            catch { }


            
        }

        private void GridVonHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

                if (Convert.ToBoolean(Vaitro) == true)
                {
                    formShowVH f = new formShowVH(this);
                    f.title.Text = GridVonHoa.CurrentRow.Cells[0].Value.ToString();
                    f.txtMaCK.Text = GridVonHoa.CurrentRow.Cells[1].Value.ToString();
                    f.txtNgayGiaoDich.Text = GridVonHoa.CurrentRow.Cells[2].Value.ToString().Replace('-', '/');
                    f.txtGiaDong.Text = GridVonHoa.CurrentRow.Cells[3].Value.ToString();
                    f.txtVonHoa.Text = GridVonHoa.CurrentRow.Cells[4].Value.ToString();
                    f.txtThiTruong.Text = GridVonHoa.CurrentRow.Cells[5].Value.ToString();

                    f.ShowDialog();
                }
            }
            catch { }


          
        }

        private void btnFindBDG_Click(object sender, System.EventArgs e)
        {
            DateTime temp;
            if (fromdate_bdg.Value > todate_bdg.Value)
            {
                temp = fromdate_bdg.Value;
                fromdate_bdg.Value = todate_bdg.Value;
                todate_bdg.Value = temp;
            }
            GridBDG.DataSource = BUS_BienDongGia.Instance.findDataBDG(txtMaCKBDG.Text, fromdate_bdg.Value, todate_bdg.Value);
        }

        public void formGDBDG_Load(object sender, System.EventArgs e)
        {
            Loadd();
            string Vaitro = BUS_TaiKhoan.Instance.classifyAccount(formLoginGrogram.Email);

            if (Convert.ToBoolean(Vaitro) == false)
            {
                btnAddBDG.Visible= false;
                btnAddTKCC.Visible= false;
                btnAddVH.Visible = false;
                btnUpGradeBDG.Visible= false;
                btnUpGradeTKCC.Visible= false;
                btnUpgradeVH.Visible= false;
            }

        }

        private void btnExportsBDG_Click(object sender, EventArgs e)
        {
            formExBDG show = new formExBDG(this);
            show.ShowDialog();
        }

        private void btnExportTKCC_Click(object sender, EventArgs e)
        {
            formExKC show = new formExKC(this );
            show.ShowDialog();
        }

        private void btnExportVH_Click(object sender, EventArgs e)
        {
            formExVH show = new formExVH(this);
            show.ShowDialog();
        }

        private void btnFindTKCC_Click(object sender, EventArgs e)
        {
            DateTime temp;
            if (fromdate_tkcc.Value > todate_tkcc.Value)
            {
                temp = fromdate_tkcc.Value;
                fromdate_tkcc.Value = todate_tkcc.Value;
                todate_tkcc.Value = temp;
            }
            GridCungCau.DataSource = BUS_CungCau.Instance.findDataCC(txtMaCKCC.Text, fromdate_tkcc.Value, todate_tkcc.Value);
        }

        private void btnFindVH_Click(object sender, EventArgs e)
        {
            DateTime temp;
            if (fromdate_vh.Value > todate_vh.Value)
            {
                temp = fromdate_vh.Value;
                fromdate_vh.Value = todate_vh.Value;
                todate_vh.Value = temp;
            }
            GridVonHoa.DataSource = BUS_VonHoa.Instance.findDataVH(txtMaCKVH.Text, fromdate_vh.Value, todate_vh.Value);
        }
    }
}