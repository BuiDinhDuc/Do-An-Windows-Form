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
            List<NhanVien> dsNhanVien = new List<NhanVien>();
            dsNhanVien = nhanvienDAL.getDSNhanVien();

            foreach(var i in dsNhanVien)
            {
                if (i.MaNV == username && i.MatKhau == GetMD5(password) && i.TrangThai == true)
                {
                    NameofUser = i.HoTenNV;

                    if (i.MaNV.Contains("NV")) PhanQuyen = 0;
                    else if (i.MaNV.Contains("QL")) PhanQuyen = 1;

                    return true;
                }

            }
            return false;
        }
        public List<NhanVien> LoadDSNhanVien()
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();
            
            foreach (var i in nhanvienDAL.getDSNhanVien())
            {
                if (Boolean.Parse(i.TrangThai.Value.ToString()))
                    dsNhanVien.Add(i);

            }
            return dsNhanVien;
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
