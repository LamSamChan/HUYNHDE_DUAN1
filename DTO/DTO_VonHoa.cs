using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_VonHoa
    {
        private static DTO_VonHoa instance;

        public static DTO_VonHoa Instance
        {
            get { if (instance == null) instance = new DTO_VonHoa(); return DTO_VonHoa.instance; }

            private set { DTO_VonHoa.instance = value; }
        }
        private DateTime ngayGiaoDich;
        private string maCk;
        private double giaDOng;
        private double giaTriVonHoa;
        private double phanTramThiTruong;

        public DTO_VonHoa() { }
        public DTO_VonHoa(DateTime ngayGiaoDich, string maCk, double giaDOng, double giaTriVonHoa, double phanTramThiTruong)
        {
            this.NgayGiaoDich = ngayGiaoDich;
            this.MaCk = maCk;
            this.GiaDOng = giaDOng;
            this.GiaTriVonHoa = giaTriVonHoa;
            this.PhanTramThiTruong = phanTramThiTruong;
        }

        public DateTime NgayGiaoDich { get => ngayGiaoDich; set => ngayGiaoDich = value; }
        public string MaCk { get => maCk; set => maCk = value; }
        public double GiaDOng { get => giaDOng; set => giaDOng = value; }
        public double GiaTriVonHoa { get => giaTriVonHoa; set => giaTriVonHoa = value; }
        public double PhanTramThiTruong { get => phanTramThiTruong; set => phanTramThiTruong = value; }
    }
}
