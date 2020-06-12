using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class SachBUS
    {
        SachDAL sachDAL = new SachDAL();
        TheLoaiDAL theloaiDAL = new TheLoaiDAL();
        
        public List<SachDTO> LayDSSach()
        {
           
            return sachDAL.LayDSSach();      
        }

        public void DeleteBooks(string MaSach)
        {
            sachDAL.DeleteBooks(MaSach);
        }

        public SachDTO timSach(string MaSach)
        {
            return sachDAL.timSach(MaSach);
        }

        public void Editbook(SachDTO sach)
        {
            sachDAL.EditBook(sach);
        }

        public List<SachDTO> SearchBook(string tieuchi)
        {
            return sachDAL.SearchBook(tieuchi);
        }
    }
}
