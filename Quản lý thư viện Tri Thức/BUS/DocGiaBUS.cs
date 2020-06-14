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
    }
}
