using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class DauSachBUS
    {
        DauSachDAL dausachDAL = new DauSachDAL();

        public List<DauSachDTO> LayDSDauSach()
        {
            return dausachDAL.LayDSDauSach();
        }

        public string timTheLoai(string MaDauSach)
        {
            return dausachDAL.timTheLoai(MaDauSach);
        }

      
        public string PhatSinhMa()
            {
                string Ma = "DS";
                int so = dausachDAL.demso();

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

        public bool ThemDauSach(DauSachDTO dauSachDTO)
        {
            return dausachDAL.ThemDauSach(dauSachDTO);
        }
        
    }
}
