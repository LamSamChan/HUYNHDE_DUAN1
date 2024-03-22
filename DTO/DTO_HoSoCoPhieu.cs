using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoSoCoPhieu
    {
        private static DTO_HoSoCoPhieu instance;

        public static DTO_HoSoCoPhieu Instance
        {
            get { if (instance == null) instance = new DTO_HoSoCoPhieu(); return DTO_HoSoCoPhieu.instance; }

            private set { DTO_HoSoCoPhieu.instance = value; }
        }

        private string maCk;
        private string tenTCPH;
        private string truSoChinh;
        private string diaChiLienlac;
        private string gPTL;
        private string tenNganh;
        private string nguoiDaiDien;
        private string nguoiCongBo;
        private string banCaoBach;
        private string trangThaiKiemSoat;
        private string trangThaiGiaoDich;
        private DateTime ngayGDDauTien;
        private double vonDieuLe;
        private double kLLH;
        private double kLNY;
        private string link_BanCaoBach;


        public string MaCk { get => maCk; set => maCk = value; }
        public string TenTCPH { get => tenTCPH; set => tenTCPH = value; }
        public string TruSoChinh { get => truSoChinh; set => truSoChinh = value; }
        public string DiaChiLienlac { get => diaChiLienlac; set => diaChiLienlac = value; }
        public string GPTL { get => gPTL; set => gPTL = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }
        public string NguoiDaiDien { get => nguoiDaiDien; set => nguoiDaiDien = value; }
        public string NguoiCongBo { get => nguoiCongBo; set => nguoiCongBo = value; }
        public string BanCaoBach { get => banCaoBach; set => banCaoBach = value; }
        public string TrangThaiKiemSoat { get => trangThaiKiemSoat; set => trangThaiKiemSoat = value; }
        public string TrangThaiGiaoDich { get => trangThaiGiaoDich; set => trangThaiGiaoDich = value; }
        public DateTime NgayGDDauTien { get => ngayGDDauTien; set => ngayGDDauTien = value; }
        public double VonDieuLe { get => vonDieuLe; set => vonDieuLe = value; }
        public double KLLH { get => kLLH; set => kLLH = value; }
        public double KLNY { get => kLNY; set => kLNY = value; }
        public string Link_BanCaoBach { get => link_BanCaoBach; set => link_BanCaoBach = value; }


        public DTO_HoSoCoPhieu() { }

        public DTO_HoSoCoPhieu(DataRow row)
        {
            this.MaCk = (string)row["mack"];
            this.TenTCPH = (string)row["tenTCPH"];
            this.TruSoChinh = (string)row["truSoChinh"];
            this.DiaChiLienlac = (string)row["diaChiLienlac"];
            this.GPTL = (string)row["gPTL"];
            this.TenNganh = (string)row["tenNganh"];
            this.NguoiDaiDien = (string)row["nguoiDaiDien"];
            this.NguoiCongBo = (string)row["nguoiCongBo"];
            this.BanCaoBach = (string)row["banCaoBach"];
            this.TrangThaiKiemSoat = (string)row["trangThaiKiemSoat"];
            this.TrangThaiGiaoDich = (string)row["trangThaiGiaoDich"];
            this.NgayGDDauTien = (DateTime)row["ngayGDDauTien"];
            this.VonDieuLe = (double)row["vonDieuLe"];
            this.KLLH = (double)row["kLLH"];
            this.KLNY = (double)row["kLNY"];
            this.Link_BanCaoBach = (string)row["link_BanCaoBach"];
        }
        public DTO_HoSoCoPhieu(string mack, string tenTCPH, string truSoChinh, string diaChiLienLac, string gPTL, string tenNganh, string nguoiDaiDien,
            string nguoiCongBo, string banCaoBach, string trangThaiKiemSoat, string trangThaiGiaoDich, DateTime ngayGDDauTien, double vonDieuLe, double kLLH, double kLNY,string link_BanCaoBach)
        {
            this.maCk = mack;
            this.tenTCPH = tenTCPH;
            this.truSoChinh = truSoChinh;
            this.diaChiLienlac = diaChiLienLac;
            this.gPTL = gPTL;
            this.tenNganh = tenNganh;
            this.nguoiDaiDien = nguoiDaiDien;
            this.nguoiCongBo = nguoiCongBo;
            this.banCaoBach = banCaoBach;
            this.trangThaiKiemSoat = trangThaiKiemSoat;
            this.trangThaiGiaoDich = trangThaiGiaoDich;
            this.ngayGDDauTien = ngayGDDauTien;
            this.vonDieuLe = vonDieuLe;
            this.kLLH = kLLH;
            this.kLNY = kLNY;
            this.link_BanCaoBach = link_BanCaoBach;
        }

    }
}
