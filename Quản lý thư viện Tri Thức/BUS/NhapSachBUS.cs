using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class NhapSachBUS
    {
        NhapSachDAL nhapSachDAL = new NhapSachDAL();

        public string phatSinhMa()
        {
            string Ma = "MN";
            int so = nhapSachDAL.DemSLNhap();

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

        public bool NhapSach(NhapSachDTO nhapSachDTO)
        {
            return nhapSachDAL._NhapSach(nhapSachDTO);
        }
    }
}
