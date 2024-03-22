using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private static DTO_TaiKhoan instance;

        public static DTO_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DTO_TaiKhoan(); return DTO_TaiKhoan.instance; }

            private set { DTO_TaiKhoan.instance = value; }
        }
        private string maNV;
        private string taiKhoan;
        private string matKhau;
        private int vaiTro;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public int VaiTro { get => vaiTro; set => vaiTro = value; }

        public DTO_TaiKhoan(string maNV, string taiKhoan, string matKhau, int vaiTro)
        {
            this.MaNV = maNV;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
            this.VaiTro = vaiTro;
        }
        public DTO_TaiKhoan() { }
    }
}
