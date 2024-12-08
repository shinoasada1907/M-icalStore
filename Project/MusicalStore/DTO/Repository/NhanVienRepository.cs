﻿using DTO.IRepository;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Repository
{
    public class NhanVienRepository : INhanVienRespository
    {
        private readonly MusicalStoreContext _context;
        public NhanVienRepository(MusicalStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<NhanVien> GetListNhanVien()
        {
            return _context.NhanViens.Select(nv => new NhanVien
            {
                MaCv = nv.MaCv,
                MaNv = nv.MaNv,
                TenNv = nv.TenNv,  
                GioiTinh = nv.GioiTinh, 
                NgaySinh = nv.NgaySinh, 
                DienThoai = nv.DienThoai,
                Cccd  = nv.Cccd,
            }).ToList();
        }
    }
}
