using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public List<SachDTO> LayDSSach()
        {
            List<SachDTO> result = new List<SachDTO>();
            result = data.Saches.Where(u => u.TrangThai.Value == true).Select(u => new SachDTO
            {
                MaSach = u.MaSach,
                TenSach = u.TenSach,
                MaTheLoai = u.DauSach.MaTheLoai,
                TenTacGia = u.TenTacGia,
                TenNhaXuatBan = u.TenNhaXuatBan,
                NamXuatBan = u.NamXuatBan.Value,
                TrangThai = u.TrangThai.Value,
                SoLuong = u.SoLuong.Value,
                SachHiem = u.SachHiem.Value,
                DonGia = (int)u.DonGia,

            }).ToList();

           

            return result;
        }

        //------------------------------
       public void DeleteBooks(string MaSach)
        {
            Sach s = data.Saches.SingleOrDefault(u => u.MaSach == MaSach && u.TrangThai.Value == true);
            s.TrangThai = false;
            data.SaveChanges();
                    
        }

        public SachDTO timSach(string MaSach)
        {
            SachDTO result = new SachDTO();
            result = data.Saches.Where(u => u.TrangThai.Value == true).Select(u => new SachDTO
            {
                MaSach = u.MaSach,
                TenSach = u.TenSach,
                MaTheLoai = u.DauSach.MaTheLoai,
                TenTacGia = u.TenTacGia,
                TenNhaXuatBan = u.TenNhaXuatBan,
                NamXuatBan = u.NamXuatBan.Value,
                TrangThai = u.TrangThai.Value,
                SoLuong = u.SoLuong.Value,
                SachHiem = u.SachHiem.Value,
                DonGia = (int)u.DonGia,
            }).SingleOrDefault();


            return result;
        }

        public void EditBook(SachDTO sach)
        {
            Sach s = data.Saches.SingleOrDefault(u => u.MaSach == sach.MaSach && u.TrangThai.Value == true);


            s.TenSach = sach.TenSach;
            s.DauSach.MaTheLoai = sach.MaTheLoai;
            s.TenTacGia = sach.TenTacGia;
            s.TenNhaXuatBan = sach.TenNhaXuatBan;
            s.NamXuatBan = sach.NamXuatBan;
            s.SoLuong = sach.SoLuong;
            s.SachHiem = sach.SachHiem;
            s.DonGia = sach.DonGia;  

            data.SaveChanges();

        }

        public List<SachDTO> SearchBook(string tieuchi)
        {

            List<SachDTO> ketqua = new List<SachDTO>();
            ketqua = data.Saches.Where(c => (c.MaSach.Contains(tieuchi) ||
                                             c.TenSach.Contains(tieuchi) ||
                                             c.DauSach.TenDauSach.Contains(tieuchi) ||
                                             c.DauSach.TheLoai.TenTheLoai.Contains(tieuchi) ||
                                             c.TenTacGia.Contains(tieuchi) ||
                                             c.TenNhaXuatBan.Contains(tieuchi)
                                            ) && c.TrangThai.Value == true).Select(c => new SachDTO
                                                   {

                                                       MaSach = c.MaSach,
                                                       TenSach = c.TenSach,
                                                       MaTheLoai = c.DauSach.MaTheLoai,
                                                       TenTacGia = c.TenTacGia,
                                                       TenNhaXuatBan = c.TenNhaXuatBan,
                                                       NamXuatBan = c.NamXuatBan.Value,
                                                       TrangThai = c.TrangThai.Value,
                                                       SoLuong = c.SoLuong.Value,
                                                       SachHiem = c.SachHiem.Value,
                                                       DonGia = (int)c.DonGia.Value
                                                   }


                                                    ).ToList();
            return ketqua;
        }
    }
}
