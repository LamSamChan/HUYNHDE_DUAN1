using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using static BUS.BUS_NhanVien;
namespace BUS
{
    public class BUS_TaiKhoan
    {

        BUS_NhanVien nv = new BUS_NhanVien();
        private static BUS_TaiKhoan instance;
         
        public static BUS_TaiKhoan Instance
        {
            get { if (instance == null) instance = new BUS_TaiKhoan(); return BUS_TaiKhoan.instance; }

            private set { BUS_TaiKhoan.instance = value; }
        }

        public bool check_emailExist(string email)
        {
            DataTable data = new DataTable();
            data = DAL_TaiKhoan.Instance.check_email();
            foreach (DataRow item in data.Rows)
            {
                string _email = item[data.Columns["Email"]] as string;
                if (email == _email)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Login(string username, string password)
        {
            password = enCodeOneWay(password);
            return DAL_TaiKhoan.Instance.Login(username, password);
        }

        public string classifyAccount(string usName)
        {
            return DAL_TaiKhoan.Instance.classifyAccount(usName);
        }


        public string enCodeOneWay(string _input)
        {
            using(MD5 md5Hash = MD5.Create())
            {
                string hash;
                return hash = GetmD5Hash(md5Hash, _input);
            }
        }
        /*public  string enCodeTwoWay(string _input)
        {
            char[] inPut_PassEn = _input.ToCharArray();
            var input_WithPass = inPut_PassEn.Select((val, ind) => new {val, ind }).ToArray();
            var char_input_Encode = input_WithPass.Select( c => c.val + c.ind + (input_WithPass.Length > c.ind + 1 ? input_WithPass[c.ind + 1].val % 2 : 0)).Select(c =>(char)c).ToArray(); 
            string res = new string(char_input_Encode);
            return res;
        }*/
        // MD5
        public static string GetmD5Hash(MD5 hash ,string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public bool resetPW(string email)
        {
            Random rd = new Random();
            string body = "Mật khẩu mới của bạn là:";
            string MatKhau = rd.Next(1000000000, int.MaxValue).ToString();
            nv.SendMail(email, MatKhau, "con người quên mật khẩu", body);
            MatKhau = enCodeOneWay(MatKhau);

            return DAL_TaiKhoan.Instance.ResetPW(email, MatKhau);
        }
        string key;
        public void sendkey(string email)
        {
            Random rd = new Random();
            string body = "Mã xác nhận của bạn là:";
            key = rd.Next(10000000, 99999999).ToString();
            nv.SendMail(email, key, "con người quên mật khẩu", body);
        }

        public void sendkeyChange(string email)
        {
            Random rd = new Random();
            string body = "Mã xác nhận của bạn là:";
            key = rd.Next(10000000, 99999999).ToString();
            nv.SendMail(email, key, "có phải bạn muốn đổi mật khẩu", body);
        }
        public bool ChangePW(string manv,string pwo, string pwn)
        {
            pwo = enCodeOneWay(pwo);
            pwn = enCodeOneWay(pwn);
            return DAL_TaiKhoan.Instance.ChangePW(manv, pwo, pwn);
        }


        public bool checkKey(string _key)
        {
            if (key == _key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
