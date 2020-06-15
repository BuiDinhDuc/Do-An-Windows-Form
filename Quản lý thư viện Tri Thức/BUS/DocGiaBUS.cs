using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class DocGiaBUS
    {
        DocGiaDAL docgiaDAL = new DocGiaDAL();

        public List<DocGiaDTO> LayDSDocGia()
        {
            return docgiaDAL.LayDSDocGia();
        }

        public DocGiaDTO timDOcGia(string MaDG)
        {
            return docgiaDAL.timDocGia(MaDG);
        }

        public string phatsinhma()
        {
            string Ma = "DG";
            int so = docgiaDAL.phatsinhma();

            int idem = 0;
            foreach(char i in so.ToString())
            {
                idem++;
            }

            for(int j = 0;j< 8- idem;j++)
            {
                Ma += "0";
            }

            return Ma + so.ToString();

        }

        public bool themDocGia(DocGiaDTO docGiaDTO)
        {
            return docgiaDAL.themDocGia(docGiaDTO);
        }

        public bool xoaDocGia(string MaDG)
        {
            return docgiaDAL.xoaDocGia(MaDG);
        }

        public bool suaDocGia(DocGiaDTO docGiaDTO)
        {
            return docgiaDAL.suaDocGia(docGiaDTO);
        }
    }
}
