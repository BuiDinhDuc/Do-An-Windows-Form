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
        ThuVienEntities data = new ThuVienEntities();
        public List<Sach> getDSSach()
        {
            List<Sach> dsSach = new List<Sach>();
            var dsS = from c in data.Saches
                      select c;

            foreach(var i in dsS)
            {
                Sach s = new Sach();
                s.MaSach = i.MaSach;
                s.TenSach = i.TenSach;
                s.MaTheLoai = i.MaTheLoai;
                s.TenTacGia = i.TenTacGia;
                s.TenNhaXuatBan = i.TenNhaXuatBan;                
                s.NamXuatBan = i.NamXuatBan;
                s.TrangThai = i.TrangThai;
                s.SoLuong = i.SoLuong;
                s.SachHiem = i.SachHiem;
                s.DonGia =(int)i.DonGia;
                dsSach.Add(s);
            }

            return dsSach;
        }

       public void DeleteBooks(string MaSach)
        {
            Sach s = (from c in data.Saches
                      where c.MaSach == MaSach
                     select c).SingleOrDefault();

            s.TrangThai = false;

            data.SaveChanges();
                    
        }

        public Sach timSach(string MaSach)
        {
            Sach s = (from c in data.Saches
                      where c.MaSach == MaSach
                      select c).SingleOrDefault();

            return s;
        }

        public void EditBook(Sach sach)
        {
            Sach s = (from c in data.Saches
                      where c.MaSach == sach.MaSach
                      select c).SingleOrDefault();

            s.TenSach = sach.TenSach;
            s.MaTheLoai = sach.MaTheLoai;
            s.TenTacGia = sach.TenTacGia;
            s.TenNhaXuatBan = sach.TenNhaXuatBan;
            s.NamXuatBan = sach.NamXuatBan;
            s.SoLuong = sach.SoLuong;
            s.SachHiem = sach.SachHiem;
            s.DonGia = sach.DonGia;  

            data.SaveChanges();

        }

        public List<Sach> SearchBook(string tieuchi)
        {
         
            List<Sach> ketqua = new List<Sach>();
            var dsS = from c in data.Saches
                      where (c.MaSach.Contains(tieuchi) ||
                            c.TenSach.Contains(tieuchi) ||
                            c.TheLoai.TenTheLoai.Contains(tieuchi) ||
                            c.TenTacGia.Contains(tieuchi) ||
                            c.TenNhaXuatBan.Contains(tieuchi)
                            
                           ) && c.TrangThai == true
                          select c;
            
            foreach (var i in dsS)
            {
                Sach s = new Sach();
                s.MaSach = i.MaSach;
                s.TenSach = i.TenSach;
                s.MaTheLoai = i.MaTheLoai;
                s.TenTacGia = i.TenTacGia;
                s.TenNhaXuatBan = i.TenNhaXuatBan;
                s.NamXuatBan = i.NamXuatBan;
                s.TrangThai = i.TrangThai;
                s.SoLuong = i.SoLuong;
                s.SachHiem = i.SachHiem;
                s.DonGia = i.DonGia;
                ketqua.Add(s);
            }

            return ketqua;

        }
    }
}
