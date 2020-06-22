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

        public bool KtraDangNhap(string username,string password, ref string NameofUser,ref int PhanQuyen,ref string MaNV,ref string TaiKhoan)
        {
            List<NhanVienDTO> dsNhanVien = new List<NhanVienDTO>();
            dsNhanVien = nhanvienDAL.LayDSNhanVien();

            foreach(NhanVienDTO i in dsNhanVien)
            {
                if (i.TaiKhoan == username && i.MatKhau == GetMD5(password))
                {
                    NameofUser = i.HoTenNV;
                    PhanQuyen = i.Quyen;
                    MaNV = i.MaNV;
                    TaiKhoan = i.TaiKhoan;
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

        public NhanVienDTO timNhanVien(string MaNV)
        {
            return nhanvienDAL.timNhanVien(MaNV);
        }

        public bool xoaNhanVien(string MaNV)
        {
            return nhanvienDAL.xoaNhanVien(MaNV);
        }

        public bool suaNhanVien(NhanVienDTO nhanVienDTO)
        {
            return nhanvienDAL.suaNhanVien(nhanVienDTO);
        }

        public string phatsinhma()
        {
           string so =  nhanvienDAL.PhatSinhSo().ToString();
            int idem = 0;
            string MaNV = "NV";
            foreach( char i in so)
            {
                idem++;
            }

            for(int i = 0; i< 8-idem;i++)
            {
                MaNV += "0";
            }

            MaNV += so;

            return MaNV;
        }

        public bool themNhanVien(NhanVienDTO nhanVien)
        {
            return nhanvienDAL.themNhanVien(nhanVien);
        }

        public bool KiemTraMatKhau(string username, string Pass)
        {
            return nhanvienDAL.KiemTraMatKhau(username, GetMD5(Pass));
        }

        public bool DoiMatKhau(string username,string newpass)
        {
            string pass = GetMD5(newpass);
            return nhanvienDAL.DoiMatKhau(username, pass);
        }
    }
}
