using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class MuonSachBUS
    {
        MuonSachDAO muonSachDAO = new MuonSachDAO();
        public string phatSinhMa()
        {
            string Ma = "MS";
            int so = muonSachDAO.TimSLMaMuon();

            int idem = 0;
            foreach (char i in so.ToString())
            {
                idem++;
            }

            for (int j = 0; j < 7 - idem; j++)
            {
                Ma += "0";
            }

            return Ma + so.ToString();
        }

        public bool ThemMuonSach(MuonSachDTO muonSachDTO)
        {
            return muonSachDAO.ThemMuonSach(muonSachDTO);
        }
    }
}
