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

        public bool ThemSachMoi(SachDTO sachDTO)
        {
            return sachDAL.AddBook(sachDTO);
        }

        public bool NhapThemSachCu(string MaSach, int SoLuongThem)
        {
            return sachDAL.ThemSachCu(MaSach, SoLuongThem);
        }

        public string PhatSinhMa()
        {
            string Ma = "Sa";
            int so = sachDAL.DemSo();

            int idem = 0;
            foreach (char i in so.ToString())
            {
                idem++;
            }

            for (int j = 0; j < 8 - idem; j++)
            {
                Ma += "0";
            }

            return Ma + so.ToString();
        }

        public List<SachDTO> SearchBookWithName(string ten)
        {
            return sachDAL.SearchBookWithName(ten);
        }

        public List<SachDTO> LayDSSachDuocChon(List<string> ds)
        {
            return sachDAL.LayDSDuocChon(ds);
        }
    }
}
