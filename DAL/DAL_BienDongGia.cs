using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BienDongGia
    {
        private static DAL_BienDongGia instance;

        public static DAL_BienDongGia Instance
        {
            get { if (instance == null) instance = new DAL_BienDongGia(); return DAL_BienDongGia.instance; }

            private set { DAL_BienDongGia.instance = value; }
        }
        public DataTable getListBDG()
        {
            DataTable dt = new DataTable();

            string query = "exec ShowData_BDG";

            dt = DataProvider.Instance.Executequery(query);

            return dt;
        }
        
        public bool update( DTO_BienDongGia BDG)
        {
            string query = "Update_BDG @ngayGiaoDich , @maCk , @giaThamChieu , @giaTran , @giaSan , @giaMo , @giaDong , @giaCao , @giaThap , @diem , @phanTram ";

            object[] para = new object[] {BDG.NgayGiaoDich,BDG.MaCk, BDG.GiaThamChieu, BDG.GiaTran, BDG.GiaSan, BDG.GiaMo, BDG.GiaDong, BDG.GiaCao, BDG.GiaThap, BDG.Diem, BDG.PhanTram  };

            if(DataProvider.Instance.ExecuteNonquery(query,para) > 0) { return true; }
            return false;
        }
        public bool deleteData(int iD )
        {
            string query = "Delete_BDG @iD";
            int result = DataProvider.Instance.ExecuteNonquery(query, new object[] { iD });
            return result > 0;
        }
        public bool adddata(DTO_BienDongGia BDG)
        {
            string query = "Add_BDG  @NgayGiaoDich , @MaCk , @GiaThamChieu , @GiaTran , @GiaSan , @GiaMo , @GiaDong , @GiaCao , @GiaThap , @Diem , @PhanTram  ";

            object[] para = new object[] { BDG.NgayGiaoDich, BDG.MaCk, BDG.GiaThamChieu, BDG.GiaTran, BDG.GiaSan, BDG.GiaMo, BDG.GiaDong, BDG.GiaCao, BDG.GiaThap, BDG.Diem, BDG.PhanTram };

            if (DataProvider.Instance.ExecuteNonquery(query, para) > 0) { return true; }
            return false;
        }
        public DataTable findData(string MACK, DateTime from, DateTime to)
        {
            DataTable dtb = new DataTable();
            string query = " Find_BDG @MaCK , @fromDate , @toDate";
            return dtb = DataProvider.Instance.Executequery(query, new object[] { MACK, from.ToString("MM/dd/yyyy"), to.ToString("MM/dd/yyyy") });
        }
    }
}
