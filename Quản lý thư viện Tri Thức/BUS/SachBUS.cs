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
        
        public List<Sach> LoadDSSach()
        {
            List<Sach> dsS = new List<Sach>();

            foreach(var i in sachDAL.getDSSach())
            {
                if (i.TrangThai == true)
                {
                    dsS.Add(i);
                }
                    
            }
            return dsS;      
        }

        public void DeleteBooks(string MaSach)
        {
            sachDAL.DeleteBooks(MaSach);
        }

        public Sach timSach(string MaSach)
        {
            return sachDAL.timSach(MaSach);
        }

        public void Editbook(Sach sach)
        {
            sachDAL.EditBook(sach);
        }

        public List<Sach> SearchBook(string tieuchi)
        {
            return sachDAL.SearchBook(tieuchi);
        }
    }
}
