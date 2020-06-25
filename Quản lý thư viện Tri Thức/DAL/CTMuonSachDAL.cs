using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CTMuonSachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        
        
        public bool ThemCTMuonSach(List<CTMuonSachDTO> lstCTMuon)
        {
         
            try
            {
                foreach(CTMuonSachDTO ct in lstCTMuon)
                {
                    CTMuonSach cT = new CTMuonSach { 
                    
                    MaMuon = ct.MaMuon,
                    MaSach = ct.MaSach,
                    SoLuong = ct.SoLuong,
                    TrangThai = ct.TrangThai,
                    GiaSach = 0
                   
                    };

                    data.CTMuonSaches.Add(cT);
          
                }
                data.SaveChanges();


                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
