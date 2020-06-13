using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Security.Cryptography;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL nhanvienDAL = new NhanVienDAL();

        public bool KtraDangNhap(string username,string password, ref string NameofUser,ref int PhanQuyen)
        {
            List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();
            dsNhanVien = nhanvienDAL.LayDSNhanVien();

            foreach(NhanVienDTO i in dsNhanVien)
            {
                if (i.TaiKhoan == username && i.MatKhau == GetMD5(password))
                {
                    NameofUser = i.HoTenNV;
                    PhanQuyen = i.Quyen;
                    return true;
                }

            }
            return false;
        }
        public List<NhanVienDTO> LayDSNhanVien()
        {
            return nhanvienDAL.LayDSNhanVien();
        }

        public String GetMD5(string MatKhau)
        {
            String str = String.Empty;
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(MatKhau);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);

            foreach(Byte b in buffer)
            {
                str += b.ToString("x2");
            }


            return str;
        }
    }
}
