using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TheLoaiBUS
    {
        TheLoaiDAL theloaiDAL = new TheLoaiDAL();

        public List<TheLoaiDTO> LayDSTheLoai()
        {
            return theloaiDAL.LayDSTheLoai();
        }

        public TheLoaiDTO timTheLoai(string MaTheLoai)
        {
            return theloaiDAL.timTheLoai(MaTheLoai);
        }

        public TheLoaiDTO timTheLoaitheoten(string TenTheLoai)
        {
            return theloaiDAL.timTheLoaitheoten(TenTheLoai);
        }

        public string PhatSinhMa()
        {
            string Ma = "TL";
            int so = theloaiDAL.DemSo();

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

        public bool themTheLoai(TheLoaiDTO theLoaiDTO)
        {
            return theloaiDAL.ThemTheLoai(theLoaiDTO);
        }
    }
}
