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
    }
}
