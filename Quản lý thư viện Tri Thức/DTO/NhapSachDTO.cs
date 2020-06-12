using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapSachDTO
    {
       
        public string MaNhap { get; set; }
        public string TenNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
    
    }
}
