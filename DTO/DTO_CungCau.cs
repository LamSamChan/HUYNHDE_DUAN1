using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CungCau
    {
        private static DTO_CungCau instance;

        public static DTO_CungCau Instance
        {
            get { if (instance == null) instance = new DTO_CungCau(); return DTO_CungCau.instance; }

            private set { DTO_CungCau.instance = value; }
        }

        private DateTime ngayGiaoDich;
        private string mack;
        private double giaDong;
        private double soLenhMua;
        private double khoiLuongMua;
        private double soLenhBan;
        private double khoiLuongBan;
        private double duMua;
        private double duBan;
        private double khoiLuongGD;
        private double giaTriGD;
        public string Mack { get => mack; set => mack = value; }
        public double GiaDong { get => giaDong; set => giaDong = value; }
        public double SoLenhMua { get => soLenhMua; set => soLenhMua = value; }
        public double KhoiLuongMua { get => khoiLuongMua; set => khoiLuongMua = value; }
        public double KhoiLuongGD { get => khoiLuongGD; set => khoiLuongGD = value; }
        public double GiaTriGD { get => giaTriGD; set => giaTriGD = value; }
        public double DuBan { get => duBan; set => duBan = value; }
        public double DuMua { get => duMua; set => duMua = value; }
        public double KhoiLuongBan { get => khoiLuongBan; set => khoiLuongBan = value; }
        public double SoLenhBan { get => soLenhBan; set => soLenhBan = value; }
        public DateTime NgayGiaoDich { get => ngayGiaoDich; set => ngayGiaoDich = value; }

        public DTO_CungCau() { }
        public DTO_CungCau(DateTime ngayGiaoDich, string mack, double giaDong, double soLenhMua, double khoiLuongMua, double soLenhBan, double khoiLuongBan, double duMua, double duBan, double khoiLuongGD, double giaTriGD)
        {
            this.NgayGiaoDich = ngayGiaoDich;
            this.mack = mack;
            this.GiaDong = giaDong;
            this.SoLenhMua = soLenhMua;
            this.KhoiLuongMua = khoiLuongMua;
            this.SoLenhBan = soLenhBan;
            this.KhoiLuongBan = khoiLuongBan;
            this.DuMua = duMua;
            this.DuBan = duBan;
            this.KhoiLuongGD = khoiLuongGD;
            this.GiaTriGD = giaTriGD;

        }
    }
}
