using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class MuonSachDAO
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        public int TimSLMaMuon()
        {
            return data.MuonSaches.Count() + 1;
        }

        public bool ThemMuonSach(MuonSachDTO muonSachDTO)
        {
            try
            {
                MuonSach muonSach = new MuonSach();
                muonSach.MaMuon = muonSachDTO.MaMuon;
                muonSach.SoThe = muonSachDTO.SoThe;
                muonSach.MaNV = muonSachDTO.MaNV;
                muonSach.NgayMuon = muonSachDTO.NgayMuon;
                muonSach.NgayPhaiTra = muonSachDTO.NgayPhaiTra;
                muonSach.TrangThai = true;
               

                data.MuonSaches.Add(muonSach);

                data.SaveChanges();

                return true;
            }catch(Exception)
            {
                return false;
            }
        }
      
    }
}
