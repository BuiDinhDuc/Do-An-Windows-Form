using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class CTNhapSachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public void Update_ThanhTien(string MaNhap)
        {
            NhapSach nhapSach = new NhapSach();
            nhapSach = data.NhapSaches.SingleOrDefault(u => u.MaNhap == MaNhap);

            nhapSach.ThanhTien = TinhThanhTien(MaNhap);
        }

        public decimal TinhThanhTien(string MaNhap)
        {
            decimal TongTien = 0;

            foreach (CTNhapSach cT in data.CTNhapSaches)
            {
                if (cT.MaNhap == MaNhap)
                {
                    TongTien += cT.SoLuong.Value * (decimal)cT.DonGia.Value;
                }
            }

            return TongTien;
        }

        public bool ThemCTNhapSach(CTNhapSachDTO cTNhapSachDTO)
        {
            try
            {
                CTNhapSach cTNhapSach = new CTNhapSach();
                cTNhapSach.MaNhap = cTNhapSachDTO.MaNhap;
                cTNhapSach.MaSach = cTNhapSachDTO.MaSach;
                cTNhapSach.SoLuong = cTNhapSachDTO.SoLuong;
                cTNhapSach.DonGia = cTNhapSachDTO.DonGia;
                cTNhapSach.TrangThai = true;

                data.CTNhapSaches.Add(cTNhapSach);

                data.SaveChanges();

                Update_ThanhTien(cTNhapSach.MaNhap);

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
