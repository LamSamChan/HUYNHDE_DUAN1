using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoDichTraiPhieu
    {
        private static DTO_GiaoDichTraiPhieu instance;

        public static DTO_GiaoDichTraiPhieu Instance
        {
            get { if (instance == null) instance = new DTO_GiaoDichTraiPhieu(); return DTO_GiaoDichTraiPhieu.instance; }

            private set { DTO_GiaoDichTraiPhieu.instance = value; }
        }

        private int iD_tpdn;
        private int sTT;
        private DateTime ngay_GD;
        private string ma_Ck;
        private double gia_DC;
        private int tKL_GDKL_LoChan;
        private double tGT_GDKL_LoChan;
        private int tKL_GDKL_LoLe;
        private double tGT_GDKL_LoLe;
        private int tong_KLGD_TT_LoChan;
        private double tong_GTGD_TT_LoChan;
        private int tong_KLGD_TT_LoLe;
        private double tong_GTGD_TT_LoLe;

        public int ID_tpdn { get => iD_tpdn; set => iD_tpdn = value; }
        public int STT { get => sTT; set => sTT = value; }
        public DateTime Ngay_GD { get => ngay_GD; set => ngay_GD = value; }
        public string Ma_Ck { get => ma_Ck; set => ma_Ck = value; }
        public double Gia_DC { get => gia_DC; set => gia_DC = value; }
        public int TKL_GDKL_LoChan { get => tKL_GDKL_LoChan; set => tKL_GDKL_LoChan = value; }
        public double TGT_GDKL_LoChan { get => tGT_GDKL_LoChan; set => tGT_GDKL_LoChan = value; }
        public int TKL_GDKL_LoLe { get => tKL_GDKL_LoLe; set => tKL_GDKL_LoLe = value; }
        public double TGT_GDKL_LoLe { get => tGT_GDKL_LoLe; set => tGT_GDKL_LoLe = value; }
        public int Tong_KLGD_TT_LoChan { get => tong_KLGD_TT_LoChan; set => tong_KLGD_TT_LoChan = value; }
        public double Tong_GTGD_TT_LoChan { get => tong_GTGD_TT_LoChan; set => tong_GTGD_TT_LoChan = value; }
        public int Tong_KLGD_TT_LoLe { get => tong_KLGD_TT_LoLe; set => tong_KLGD_TT_LoLe = value; }
        public double Tong_GTGD_TT_LoLe { get => tong_GTGD_TT_LoLe; set => tong_GTGD_TT_LoLe = value; }

        public DTO_GiaoDichTraiPhieu(int iD_tpdn, int sTT, DateTime ngay_GD, string ma_Ck, double gia_DC, int tKL_GDKL_LoChan, double tGT_GDKL_LoChan, int tKL_GDKL_LoLe, double tGT_GDKL_LoLe, int tong_KLGD_TT_LoChan, double tong_GTGD_TT_LoChan, int tong_KLGD_TT_LoLe, double tong_GTGD_TT_LoLe)
        {
            this.ID_tpdn = iD_tpdn;
            this.STT = sTT;
            this.Ngay_GD = ngay_GD;
            this.Ma_Ck = ma_Ck;
            this.Gia_DC = gia_DC;
            this.TKL_GDKL_LoChan = tKL_GDKL_LoChan;
            this.TGT_GDKL_LoChan = tGT_GDKL_LoChan;
            this.TKL_GDKL_LoLe = tKL_GDKL_LoLe;
            this.TGT_GDKL_LoLe = tGT_GDKL_LoLe;
            this.Tong_KLGD_TT_LoChan = tong_KLGD_TT_LoChan;
            this.Tong_GTGD_TT_LoChan = tong_GTGD_TT_LoChan;
            this.Tong_KLGD_TT_LoLe = tong_KLGD_TT_LoLe;
            this.Tong_GTGD_TT_LoLe = tong_GTGD_TT_LoLe;
        }
        public DTO_GiaoDichTraiPhieu() { }
    }
}
