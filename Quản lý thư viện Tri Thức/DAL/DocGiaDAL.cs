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
        public List<DocGia> getDSDocGia()
        {
            List<DocGia> dsDocGia = new List<DocGia>();

            var dsDG = from c in data.DocGias
                       select c;

            foreach(var i in dsDG)
            {
                DocGia dg = new DocGia();

                dg.MaDocGia = i.MaDocGia;
                dg.TenDocGia = i.TenDocGia;
                dg.CMND = i.CMND;
                dg.DiaChi = i.DiaChi;
                dg.SoThe = i.SoThe;
                dg.TrangThai = i.TrangThai;

                dsDocGia.Add(dg);
            }

            return dsDocGia;
        }

        
    }
}
