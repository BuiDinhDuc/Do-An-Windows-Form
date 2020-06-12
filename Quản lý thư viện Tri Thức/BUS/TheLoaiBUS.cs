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
    }
}
