using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string MaDauSach { get; set; }
        public string MaTheLoai { get; set; }
        public string TenTacGia { get; set; }
        public string TenNhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public decimal DonGia { get; set; }
        public bool TrangThai { get; set; }

        public bool SachHiem { get; set; }
        public int SoLuong { get; set; }
    }
}
