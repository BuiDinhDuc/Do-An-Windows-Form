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
        QuanLyThuVienEntities quanLyThuVienEntities = new QuanLyThuVienEntities();
        
        
        public bool ThemCTMuonSach(List<CTMuonSachDTO> lstCTMuon)
        {
            // MA code
            try
            {
                foreach (CTMuonSachDTO ctMuon in lstCTMuon)
                {
                    CTMuonSach cTMuonSach = new CTMuonSach();
                    cTMuonSach.MaMuon = ctMuon.MaMuon;
                    cTMuonSach.MaSach = ctMuon.MaSach;
                    cTMuonSach.SoLuong = ctMuon.SoLuong;
                    cTMuonSach.TrangThai = true;

                    quanLyThuVienEntities.CTMuonSaches.Add(cTMuonSach);
                    quanLyThuVienEntities.SaveChanges();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
