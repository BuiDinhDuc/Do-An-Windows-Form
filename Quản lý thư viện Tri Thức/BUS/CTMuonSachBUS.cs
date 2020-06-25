using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class CTMuonSachBUS
    {
        CTMuonSachDAL ctmuonDAL = new CTMuonSachDAL();
        public bool ThemCTMuonSach(List<CTMuonSachDTO> lstCTMuon)
        {
            return ctmuonDAL.ThemCTMuonSach(lstCTMuon);
        }
    }
}
