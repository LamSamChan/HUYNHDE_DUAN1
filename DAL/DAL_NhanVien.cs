using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien instance;

        public static DAL_NhanVien Instance
        {
            get { if (instance == null) instance = new DAL_NhanVien(); return DAL_NhanVien.instance; }

            private set { DAL_NhanVien.instance = value; }
        }

        public DataTable loadData()
        {
            DataTable data = new DataTable();
            string query = "ShowData_NV";

            return data = DataProvider.Instance.Executequery(query);
        }

        public DataTable getIDNV()
        {
            DataTable data = new DataTable();
            string query = "get_NV_ID";

            return data = DataProvider.Instance.Executequery(query);
        }

        public bool editData(string MaNV, string Ten, string Email, string GioiTinh, string SoDienThoai, string CMND, DateTime NgaySinh, string DiaChi,
            string ChucVu, string GhiChu, string Anh)
        {
            string query = "Update_NV @MaNV , @Ten , @Email , @GioiTinh , @SoDienThoai , @CMND , @NgaySinh , @DiaChi , @ChucVu , @GhiChu , @Anh";

            int result = DataProvider.Instance.ExecuteNonquery(query, new object[] { MaNV , Ten , Email, GioiTinh, SoDienThoai, CMND , NgaySinh.ToString("MM/dd/yyyy"), DiaChi,
            ChucVu, GhiChu, Anh});

            return result > 0;
        }

        public bool addData(string MaNV, string Ten, string Email, string GioiTinh, string SoDienThoai, string CMND, DateTime NgaySinh, string DiaChi,
            string ChucVu, string Anh, string MatKhau, string GhiChu)
        {
            string query = "Add_NV_TK @MaNV , @Ten , @Email , @GioiTinh , @SoDienThoai , @CMND , @NgaySinh , @DiaChi , @ChucVu , @Anh , @MatKhau , @GhiChu";

            int result = DataProvider.Instance.ExecuteNonquery(query, new object[] { MaNV , Ten , Email, GioiTinh, SoDienThoai, CMND , NgaySinh.ToString("MM/dd/yyyy"), DiaChi,
            ChucVu, Anh, MatKhau, GhiChu});

            return result > 0;
        }

        public bool deleteData(string ID)
        {
            string query = "Delete_NV @ID";
            int result = DataProvider.Instance.ExecuteNonquery(query, new object[] { ID });
            return result > 0;

        }

        public DataTable findData(string stringFind)
        {
            DataTable dtb = new DataTable();
            string query = " Find_NV @StringFind";
            return dtb = DataProvider.Instance.Executequery(query, new object[] { stringFind });
        }
        public DataTable getPersonData(string email)
        {
            DataTable dtb = new DataTable();
            string query = " show_info_personal @email";
            return dtb = DataProvider.Instance.Executequery(query, new object[] { email });
        }

       public bool edit_dataPersonal(string maNV, string sdth, string cmnd, string diachi, string img)
        {
            string query = "update_info_personal @MaNV , @sodth , @cmnd , @diachi , @anh";
            int result = DataProvider.Instance.ExecuteNonquery(query, new object[] { maNV, sdth, cmnd, diachi, img });

            return result > 0;
        }
    }
}
