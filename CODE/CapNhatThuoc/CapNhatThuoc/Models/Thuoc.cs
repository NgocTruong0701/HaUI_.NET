using System;
using System.Collections.Generic;

#nullable disable

namespace CapNhatThuoc.Models
{
    public partial class Thuoc
    {
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string MaLoai { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }

        public virtual LoaiThuoc MaLoaiNavigation { get; set; }
    }
}
