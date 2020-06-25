using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTTraSachDTO
    {

        public string MaTra { get; set; }
        public string TenSach { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoLuong { get; set; }
      
        public decimal TienPhat { get; set; }
        public bool TrangThai { get; set; }
 
    }
}
