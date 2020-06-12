using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string HoTenNV { get; set; }
        public DateTime NgSinh { get; set; }
        public string SDT { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }

        public int Quyen { get; set; }
        public bool TrangThai { get; set; }

        
    }
}
