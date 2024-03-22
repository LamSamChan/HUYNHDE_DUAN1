using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CungCau
    {
        private static DAL_CungCau instance;

        public static DAL_CungCau Instance
        {
            get { if (instance == null) instance = new DAL_CungCau(); return DAL_CungCau.instance; }

            private set { DAL_CungCau.instance = value; }
        }
        public DataTable getListCungCau()
        {
            DataTable dt = new DataTable();

            string query = "exec ShowData_TKCC";

            dt = DataProvider.Instance.Executequery(query);

            return dt;
        }
        public bool update(DTO_CungCau CC)
        {
            string query = "Update_TKCC @NgayGiaoDich , @MaCk , @GiaDong , @SoLenhMua , @KhoiLuongMua , @SoLenhBan , @KhoiLuongban , @DuMua , @DuBan , @KhoiLuongGD , @GiaTriGD ";

            object[] para = new object[] { CC.NgayGiaoDich, CC.Mack, CC.GiaDong, CC.SoLenhMua, CC.KhoiLuongMua, CC.SoLenhBan, CC.KhoiLuongBan, CC.DuMua, CC.DuBan, CC.KhoiLuongGD, CC.GiaTriGD };

            if (DataProvider.Instance.ExecuteNonquery(query, para) > 0) { return true; }
            return false;
        }
        public bool deleteData(int iD)
        {
            string query = "Delete_TKKC @iD";
            int result = DataProvider.Instance.ExecuteNonquery(query, new object[] { iD });
            return result > 0;
        }
        public bool adddata(DTO_CungCau CC)
        {
            string query = "Add_TKCC @NgayGiaoDich , @MaCk , @GiaDong , @SoLenhMua , @KhoiLuongMua , @SoLenhBan , @KhoiLuongban , @DuMua , @DuBan , @KhoiLuongGD , @GiaTriGD ";

            object[] para = new object[] { CC.NgayGiaoDich, CC.Mack, CC.GiaDong, CC.SoLenhMua, CC.KhoiLuongMua, CC.SoLenhBan, CC.KhoiLuongBan, CC.DuMua, CC.DuBan, CC.KhoiLuongGD, CC.GiaTriGD };

            if (DataProvider.Instance.ExecuteNonquery(query, para) > 0) { return true; }
            return false;
        }
        public DataTable findData(string MACK, DateTime from, DateTime to)
        {
            DataTable dtb = new DataTable();
            string query = " Find_TKCC @MaCK , @fromDate , @toDate";
            return dtb = DataProvider.Instance.Executequery(query, new object[] { MACK, from.ToString("MM/dd/yyyy"), to.ToString("MM/dd/yyyy") });
        }
    }
}
