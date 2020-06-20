using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DauSachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public List<DauSachDTO> LayDSDauSach()
        {
            List<DauSachDTO> result = new List<DauSachDTO>();
            result = data.DauSaches.Where(u => u.TrangThai == true).Select(u => new DauSachDTO
            {
                MaDauSach = u.MaDauSach,
                TenDauSach = u.TenDauSach,
                MaTheLoai = u.MaTheLoai,           
            }
            ).ToList();

            return result;
        }

        public string timTheLoai(string MaDauSach)
        {
            DauSach dauSach = data.DauSaches.SingleOrDefault(u => u.MaDauSach == MaDauSach );
            return dauSach.MaTheLoai;
        }
    }
}
