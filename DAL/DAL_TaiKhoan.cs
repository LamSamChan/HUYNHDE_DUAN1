using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;

        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return DAL_TaiKhoan.instance; }

            private set { DAL_TaiKhoan.instance = value; }
        }

        public DataTable check_email()
        {
            DataTable data = new DataTable();
            string query = "check_email_exist";

            return data = DataProvider.Instance.Executequery(query);
        }

        public bool Login (string userName, string passWord)
        {
            string query = "GetAccountToLogin @usernam , @password";
            DataTable result = DataProvider.Instance.Executequery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public bool ResetPW (string email, string password)
        {
            string query = "Reset_PW @email , @password";
            DataTable result = DataProvider.Instance.Executequery(query, new object[] { email, password });
            return result.Rows.Count > 0;
            
        }
        public string classifyAccount(string usName)
        {
            string query = "get_vaiTro_Account @us";
            DataTable dt = DataProvider.Instance.Executequery(query, new object[] { usName });
            string vaitro = dt.Rows[0][0].ToString();
            return vaitro;
        }

        public bool ChangePW(string manv, string pwo, string pwn)
        {
            string query = "Change_PW @manv , @pwo , @pwn";
            DataTable result = DataProvider.Instance.Executequery(query, new object[] { manv, pwo,pwn });
            return result.Rows.Count > 0;

        }

    }
}
