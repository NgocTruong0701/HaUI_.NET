using System;
using System.Collections.Generic;

#nullable disable

namespace CapNhatThuoc.Models
{
    public partial class LoaiThuoc
    {
        public LoaiThuoc()
        {
            Thuocs = new HashSet<Thuoc>();
        }

        public string MaLoai { get; set; }
        public string TenLoai { get; set; }

        public virtual ICollection<Thuoc> Thuocs { get; set; }
    }
}
