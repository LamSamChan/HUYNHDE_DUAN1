using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BienDongGia
    {
        private static DTO_BienDongGia instance;

        public static DTO_BienDongGia Instance
        {
            get { if (instance == null) instance = new DTO_BienDongGia(); return DTO_BienDongGia.instance; }

            private set { DTO_BienDongGia.instance = value; }
        }
        private DateTime ngayGiaoDich;
        private string maCk;
        private double giaThamChieu;
        private double giaTran;
        private double giaSan;
        private double giaMo;
        private double giaDong;
        private double giaCao;
        private double giaThap;
        private double diem;
        private double phanTram;

        public string MaCk { get => maCk; set => maCk = value; }
        public double GiaThamChieu { get => giaThamChieu; set => giaThamChieu = value; }
        public double GiaTran { get => giaTran; set => giaTran = value; }
        public double GiaSan { get => giaSan; set => giaSan = value; }
        public double GiaMo { get => giaMo; set => giaMo = value; }
        public double GiaDong { get => giaDong; set => giaDong = value; }
        public double GiaThap { get => giaThap; set => giaThap = value; }
        public double GiaCao { get => giaCao; set => giaCao = value; }
        public double Diem { get => diem; set => diem = value; }
        public double PhanTram { get => phanTram; set => phanTram = value; }
        public DateTime NgayGiaoDich { get => ngayGiaoDich; set => ngayGiaoDich = value; }

        public DTO_BienDongGia() { }
        public DTO_BienDongGia(DateTime ngayGiaoDich, string maCk, double giaThamChieu, double giaTran, double giaSan, double giaMo, double giaDong, double giaCao, double giaThap, double diem, double phanTram)
        {
            this.NgayGiaoDich = ngayGiaoDich;
            this.maCk = maCk;
            this.GiaThamChieu = giaThamChieu;
            this.GiaTran = giaTran;
            this.GiaSan = giaSan;
            this.GiaMo = giaMo;
            this.GiaDong = giaDong;
            this.GiaCao = giaCao;
            this.GiaThap = giaThap;
            this.Diem = diem;
            this.PhanTram = phanTram;

        }

        public DTO_BienDongGia(DataRow rowItem)
        {
        }
    }
}
