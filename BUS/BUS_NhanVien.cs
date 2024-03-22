using DAL;
using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web.Security;

namespace BUS
{
    public class BUS_NhanVien
    {
        
        private static BUS_NhanVien instance;

        public static BUS_NhanVien Instance
        {
            get { if (instance == null) instance = new BUS_NhanVien(); return BUS_NhanVien.instance; }

            private set { BUS_NhanVien.instance = value; }
        }

        public DataTable LoadData()
        {
            return DAL_NhanVien.Instance.loadData();
        }

        public string getIDNV()
        {
            DataTable data = new DataTable();
            data = DAL_NhanVien.Instance.getIDNV();
            DataRow lastRow = data.Rows[data.Rows.Count - 1];
            var value = lastRow["ID"] as string;
            int idNum;
            try
            {
                idNum = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                 lastRow = data.Rows[data.Rows.Count - 2];
                 value = lastRow["ID"] as string;
                idNum = Convert.ToInt32(value);
            }
            idNum++;
            string id = $"HD{idNum}";
            if (id.Count() == 3)
            {
                id = id.Replace(idNum.ToString(), $"00{idNum}");
            }
            else if (id.Count() == 4)
            {
                id = id.Replace(idNum.ToString(), $"0{idNum}");
            }
            return id;
        }

        public bool editData(string MaNV, string Ten, string Email, string GioiTinh, string SoDienThoai, string CMND, DateTime NgaySinh, string DiaChi,
           string ChucVu, string GhiChu, string Anh)
        {
            return DAL_NhanVien.Instance.editData(MaNV, Ten, Email, GioiTinh, SoDienThoai, CMND, NgaySinh, DiaChi,
            ChucVu, GhiChu, Anh);
        }

        public bool deleteData(string ID)
        {
            return DAL_NhanVien.Instance.deleteData(ID);
        }

        public DataTable findData(string StringFind)
        {
            return DAL_NhanVien.Instance.findData(StringFind);
        }

        public void SendMail(string maillAd, string pass, string name, string body)
        {
            var fromAddress = new MailAddress("huynh.de.vip.pro.2002.2003@gmail.com", "HUYNH DE");
            var toAddress = new MailAddress($"{maillAd}");
            const string fromPassword = "huynhde123";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "xomhsfugkdddcdgb")
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = $"Xin chào {name}.",
                Body = $"{body} {pass}"
            })
            {
                smtp.Send(message);
            }
        }

        public bool addData(string MaNV, string Ten, string Email, string GioiTinh, string SoDienThoai, string CMND, DateTime NgaySinh, string DiaChi,
           string ChucVu, string Anh, string MatKhau, string GhiChu)
        {
            BUS_TaiKhoan md5 = new BUS_TaiKhoan();
            Random rd = new Random();
            string body = $"Chào mừng bạn đến với công ty HuynhDe Cào Cào !!!\n" +
                $"Mật khẩu đăng nhập của bạn là:";
            MatKhau = rd.Next(1000000000, int.MaxValue).ToString();
            SendMail(Email, MatKhau, Ten, body);
            MatKhau = md5.enCodeOneWay(MatKhau);
            return DAL_NhanVien.Instance.addData(MaNV, Ten, Email, GioiTinh, SoDienThoai, CMND, NgaySinh, DiaChi,
            ChucVu, Anh, MatKhau, GhiChu);
        }

        public DataTable getPersonData(string email)
        {
            return DAL_NhanVien.Instance.getPersonData(email);
        }

        public bool edit_infoPerson(string manv, string sdth, string cmnd, string diachi , string img)
        {
            return DAL_NhanVien.Instance.edit_dataPersonal(manv,sdth,cmnd,diachi,img);
        }
    }
}