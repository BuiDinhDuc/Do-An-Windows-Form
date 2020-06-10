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
        ThuVienEntities data = new ThuVienEntities();
        public List<NhanVien> getDSNhanVien()
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            var dsNV = from c in data.NhanViens
                       
                       select c;

            foreach (var i in dsNV)
            {
                NhanVien nv = new NhanVien();

                nv.MaNV = i.MaNV;
                nv.HoTenNV = i.HoTenNV;
                nv.NgSinh = i.NgSinh;
                nv.SDT = i.SDT;
                nv.MatKhau = i.MatKhau;
                nv.TrangThai = i.TrangThai;

                dsNhanVien.Add(nv);
            }


            return dsNhanVien;
        }
    }
}
