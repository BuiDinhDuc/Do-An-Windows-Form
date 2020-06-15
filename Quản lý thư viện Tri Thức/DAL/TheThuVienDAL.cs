using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TheThuVienDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public DateTime LayNgayBatDau(string MaThe)
        {
            TheThuVien the = data.TheThuViens.SingleOrDefault(u => u.SoThe == MaThe && u.TrangThai == true);

            return the.NgayBatDau.Value;
        }

        public int phatsinhma()
        {
            return data.TheThuViens.Count() + 1;
        }

        public bool themTheTV(TheThuVienDTO theThuVienDTO)
        {
            try
            {
                TheThuVien theThuVien = new TheThuVien
                {
                    SoThe = theThuVienDTO.SoThe,
                    NgayBatDau = theThuVienDTO.NgayBatDau,
                    TrangThai = true

                };

                data.TheThuViens.Add(theThuVien);
                data.SaveChanges();

                return true;
            } catch(Exception)
            {
                return false;
            }

        }

        public bool xoaTheThuVien(string MaThe)
        {
            try
            {
                TheThuVien theThuVien = new TheThuVien();
                theThuVien = data.TheThuViens.SingleOrDefault(u => u.SoThe == MaThe && u.TrangThai == true);

                theThuVien.TrangThai = false;
                data.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
  
        }

        public bool suaTheThuVien(TheThuVienDTO theThuVienDTO)
        {
            try
            {
                TheThuVien theThuVien = data.TheThuViens.SingleOrDefault(u => u.SoThe == theThuVienDTO.SoThe && u.TrangThai == true);
                theThuVien.NgayBatDau = theThuVienDTO.NgayBatDau;
                data.SaveChanges();
                return true;
            } catch(Exception)
            {
                return false;
            }
        }
    }
}
