using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_VonHoa
    {
        private static DAL_VonHoa instance;

        public static DAL_VonHoa Instance
        {
            get { if (instance == null) instance = new DAL_VonHoa(); return DAL_VonHoa.instance; }

            private set { DAL_VonHoa.instance = value; }
        }
        public DataTable getListVonHoa()
        {
            DataTable dt = new DataTable();

            string query = "exec ShowData_VH";

            dt = DataProvider.Instance.Executequery(query);

            return dt;
        }
        public bool update(DTO_VonHoa VH)
        {
            string query = "Update_VH @NgayGiaoDich , @MaCk , @GiaDong , @VonHoa , @ThiTruong ";

            object[] para = new object[] { VH.NgayGiaoDich, VH.MaCk, VH.GiaDOng, VH.GiaTriVonHoa, VH.PhanTramThiTruong };

            if (DataProvider.Instance.ExecuteNonquery(query, para) > 0) { return true; }
            return false;
        }
        public bool deleteData(int iD)
        {
            string query = "Delete_VH @iD";
            int result = DataProvider.Instance.ExecuteNonquery(query, new object[] { iD});
            return result > 0;
        }
        public bool adddata(DTO_VonHoa VH)
        {
            string query = "Add_VH @NgayGiaoDich , @MaCk , @GiaDong , @VonHoa , @ThiTruong ";

            object[] para = new object[] { VH.NgayGiaoDich, VH.MaCk, VH.GiaDOng, VH.GiaTriVonHoa, VH.PhanTramThiTruong };

            if (DataProvider.Instance.ExecuteNonquery(query, para) > 0) { return true; }
            return false;
        }
        public DataTable findData(string MACK, DateTime from, DateTime to)
        {
            DataTable dtb = new DataTable();
            string query = " Find_VH @MaCK , @fromDate , @toDate";
            return dtb = DataProvider.Instance.Executequery(query, new object[] { MACK, from.ToString("MM/dd/yyyy"), to.ToString("MM/dd/yyyy") });
        }
    }
}
