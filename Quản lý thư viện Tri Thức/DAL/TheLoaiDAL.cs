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
        ThuVienEntities data = new ThuVienEntities();

        public List<TheLoai> getDSTheLoai()
        {
            List<TheLoai> dsTheLoai = new List<TheLoai>();

            var dstheloai = from c in data.TheLoais
                            select c;

            foreach(var i in dstheloai)
            {
                TheLoai tl = new TheLoai();
                tl.MaTheLoai = i.MaTheLoai;
                tl.TenTheLoai = i.TenTheLoai;
                tl.TrangThai = i.TrangThai;

                dsTheLoai.Add(tl);
            }
            return dsTheLoai;
        }
    }
}
