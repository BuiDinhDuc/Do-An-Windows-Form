using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TheLoaiDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public List<TheLoaiDTO> LayDSTheLoai()
        {
            List<TheLoaiDTO> result = new List<TheLoaiDTO>();

            
            result = data.TheLoais.Where(u => u.TrangThai.Value == true).Select(u => new TheLoaiDTO
            {
               TenTheLoai = u.TenTheLoai,
                MaTheLoai = u.MaTheLoai,
            }).ToList();



            return result;
        }
    }
}
