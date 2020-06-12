using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DocGiaDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public List<DocGiaDTO> LayDSDocGia()
        {
            List<DocGiaDTO> dsDocGia = new List<DocGiaDTO>();

            dsDocGia = data.DocGias.Where(u => u.TrangThai.Value == true).Select(u => new DocGiaDTO
            {

                MaDocGia = u.MaDocGia,
                TenDocGia = u.TenDocGia,
                CMND = u.CMND,
                DiaChi = u.DiaChi,
                SoThe = u.SoThe,

            }).ToList();

            return dsDocGia;
        }

        
    }
}
