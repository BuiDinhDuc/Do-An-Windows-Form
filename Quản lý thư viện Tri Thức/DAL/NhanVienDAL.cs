using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public List<NhanVienDTO> LayDSNhanVien()
        {
            List<NhanVienDTO> result = new List<NhanVienDTO>();
            result = data.NhanViens.Where(u => u.TrangThai.Value == true).Select(u => new NhanVienDTO
            {
                MaNV = u.MaNV,
                HoTenNV = u.HoTenNV,
                NgSinh = u.NgSinh.Value,
                SDT = u.SDT,
                TaiKhoan = u.TaiKhoan,
                MatKhau = u.MatKhau,
                Quyen = u.Quyen.Value

            }).ToList();

            return result;

        }

        public NhanVienDTO timNhanVien(string MaNV)
        {
            NhanVienDTO nhanvienDTO = new NhanVienDTO();
            NhanVien nhanVien = new NhanVien();
            nhanVien = data.NhanViens.SingleOrDefault(u => u.MaNV == MaNV && u.TrangThai == true);
            nhanvienDTO.MaNV = nhanVien.MaNV;
            nhanvienDTO.HoTenNV = nhanVien.HoTenNV;
            nhanvienDTO.NgSinh = nhanVien.NgSinh.Value;
            nhanvienDTO.SDT = nhanVien.SDT;
            nhanvienDTO.TaiKhoan = nhanVien.TaiKhoan;
            nhanvienDTO.MatKhau = nhanVien.MatKhau;
            nhanvienDTO.Quyen = nhanVien.Quyen.Value;

            return nhanvienDTO;
        }

        public bool xoaNhanVien(string MaNV)
        {
            try
            {
                NhanVien nhanVien = data.NhanViens.SingleOrDefault(u => u.MaNV == MaNV && u.TrangThai == true);

                nhanVien.TrangThai = false;
                data.SaveChanges();
                return true;
            } catch( Exception)
            {
                return false;
            }
        }
    }
}
