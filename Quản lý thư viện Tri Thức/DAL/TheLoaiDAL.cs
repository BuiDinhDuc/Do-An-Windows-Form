using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TheLoaiDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public List<TheLoaiDTO> LayDSTheLoai()
        {
            List<TheLoaiDTO> result = new List<TheLoaiDTO>();

            
            result = data.TheLoais.Where(u => u.TrangThai.Value == true).Select(u => new TheLoaiDTO
            {
               TenTheLoai = u.TenTheLoai,
                MaTheLoai = u.MaTheLoai,
            }).ToList();



            return result;
        }

        public TheLoaiDTO timTheLoai(string MaTheLoai)
        {
            TheLoaiDTO theLoaiDTO = new TheLoaiDTO();

            TheLoai tl = data.TheLoais.SingleOrDefault(u => u.MaTheLoai == MaTheLoai);
            theLoaiDTO.MaTheLoai = tl.MaTheLoai;
            theLoaiDTO.TenTheLoai = tl.TenTheLoai;
            theLoaiDTO.TrangThai = tl.TrangThai.Value;

            return theLoaiDTO;

        }

        public TheLoaiDTO timTheLoaitheoten(string TenTheLoai)
        {
            TheLoaiDTO theLoaiDTO = new TheLoaiDTO();

            TheLoai tl = data.TheLoais.SingleOrDefault(u => u.TenTheLoai == TenTheLoai);
            theLoaiDTO.MaTheLoai = tl.MaTheLoai;
            theLoaiDTO.TenTheLoai = tl.TenTheLoai;
            theLoaiDTO.TrangThai = tl.TrangThai.Value;

            return theLoaiDTO;

        }

        public int DemSo()
        {
            return data.TheLoais.Count() + 1;
        }

        public bool ThemTheLoai(TheLoaiDTO theLoaiDTO)
        {
            try
            {
                TheLoai theLoai = new TheLoai
                {
                    MaTheLoai = theLoaiDTO.MaTheLoai,
                    TenTheLoai = theLoaiDTO.TenTheLoai,
                    TrangThai = true,
                };

                data.TheLoais.Add(theLoai);
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
