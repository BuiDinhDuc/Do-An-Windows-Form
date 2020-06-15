using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class TheThuVienBUS
    {
        TheThuVienDAL theThuVienDAL = new TheThuVienDAL();
        public DateTime LayNgayBatDau(string MaThe)
        {
            return theThuVienDAL.LayNgayBatDau(MaThe);
        }

        public string phatsinhma()
        {
            string Ma = "Th";
            int so = theThuVienDAL.phatsinhma();

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

        public bool themTheTV( TheThuVienDTO theThuVienDTO)
        {
            return theThuVienDAL.themTheTV(theThuVienDTO);
        }

        public bool xoaTheTV(string SoThe)
        {
            return theThuVienDAL.xoaTheThuVien(SoThe);
        }

        public bool suaTheTV (TheThuVienDTO theThuVienDTO)
        {
            return theThuVienDAL.suaTheThuVien(theThuVienDTO);
        }
    }
}
