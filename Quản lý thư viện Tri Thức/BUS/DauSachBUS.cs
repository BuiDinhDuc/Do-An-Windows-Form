﻿using System;
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
    }
}
