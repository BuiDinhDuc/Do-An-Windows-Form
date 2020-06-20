using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhapSachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public int DemSLNhap()
        {
            return data.NhapSaches.Count() + 1;
        }

        public bool _NhapSach(NhapSachDTO nhapSachDTO)
        {
            try
            {
                NhapSach nhapSach = new NhapSach();
                nhapSach.MaNhap = nhapSachDTO.MaNhap;
                nhapSach.MaNV = nhapSachDTO.MaNV;
                nhapSach.NgayNhap = nhapSachDTO.NgayNhap;
                nhapSach.ThanhTien = nhapSachDTO.ThanhTien;
                nhapSach.TrangThai = true;
                data.NhapSaches.Add(nhapSach);
                data.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

    }
}
