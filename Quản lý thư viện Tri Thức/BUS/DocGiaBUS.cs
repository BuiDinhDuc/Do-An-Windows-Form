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

        public List<DocGia> LoadDSDocGia()
        {
            List<DocGia> dsSach = new List<DocGia>();

            foreach(var i in docgiaDAL.getDSDocGia())
            {
                if (i.TrangThai == true)
                    dsSach.Add(i);

            }

            return dsSach;
        }
    }
}
