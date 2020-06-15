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
        public DocGiaDTO timDocGia(string MaDG)
        {
            DocGiaDTO docGiaDTO = new DocGiaDTO();

            DocGia docgia = data.DocGias.SingleOrDefault(u => u.MaDocGia == MaDG && u.TrangThai == true);

            docGiaDTO.MaDocGia = docgia.MaDocGia;
            docGiaDTO.TenDocGia = docgia.TenDocGia;
            docGiaDTO.DiaChi = docgia.DiaChi;
            docGiaDTO.CMND = docgia.CMND;
            docGiaDTO.SoThe = docgia.SoThe;
            docgia.TrangThai = docgia.TrangThai;

            return docGiaDTO;
            
        }

        public int phatsinhma()
        {
            return data.DocGias.Count()+1;
   
        }

        public bool themDocGia(DocGiaDTO docGiaDTO)
        {
            try
            {
                DocGia docGia = new DocGia {

                    MaDocGia = docGiaDTO.MaDocGia,
                    TenDocGia = docGiaDTO.TenDocGia,
                    CMND = docGiaDTO.CMND,
                    DiaChi = docGiaDTO.DiaChi,
                    SoThe = docGiaDTO.SoThe,
                    TrangThai = true
                
                
                };
                data.DocGias.Add(docGia);
                data.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool xoaDocGia(string MaDG)
        {
            try
            {
                DocGia docGia = new DocGia();
                docGia = data.DocGias.SingleOrDefault(u => u.MaDocGia == MaDG && u.TrangThai == true);
                docGia.TrangThai = false;
                data.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool suaDocGia(DocGiaDTO docGiaDTO)
        {
            try 
            {
                DocGia docGia = new DocGia();
                docGia = data.DocGias.SingleOrDefault(u => u.MaDocGia == docGiaDTO.MaDocGia && u.TrangThai == true);
                docGia.TenDocGia = docGiaDTO.TenDocGia;
                docGia.CMND = docGiaDTO.CMND;
                docGia.DiaChi = docGiaDTO.DiaChi;

                data.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        
    }
}
