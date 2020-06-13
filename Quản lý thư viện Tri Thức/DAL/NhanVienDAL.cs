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

        public bool suaNhanVien(NhanVienDTO nhanvienDTO)
        {
            try
            {
                NhanVien nhanvien = data.NhanViens.SingleOrDefault(u => u.MaNV == nhanvienDTO.MaNV && u.TrangThai == true);
                nhanvien.HoTenNV = nhanvienDTO.HoTenNV;
                nhanvien.NgSinh = nhanvienDTO.NgSinh;
                nhanvien.SDT = nhanvienDTO.SDT;
                data.SaveChanges();
                return true;
            } catch(Exception)
            {
                return false;
            }
        }

        public bool themNhanVien(NhanVienDTO nv)
        {
            try
            {
                NhanVien nhanvien = new NhanVien();
                nhanvien.MaNV = nv.MaNV;
                nhanvien.HoTenNV = nv.HoTenNV;
                nhanvien.NgSinh = nv.NgSinh;
                nhanvien.SDT = nv.SDT;
                nhanvien.TaiKhoan = nv.TaiKhoan;
                nhanvien.MatKhau = nv.MatKhau;
                nhanvien.Quyen = nv.Quyen;
                nhanvien.TrangThai = true;

                data.NhanViens.Add(nhanvien);
                data.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public int PhatSinhSo()
        {
            return data.NhanViens.Count() + 1;
        }
    }
}
