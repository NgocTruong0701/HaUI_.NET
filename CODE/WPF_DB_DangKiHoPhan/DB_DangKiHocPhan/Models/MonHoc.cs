using System;
using System.Collections.Generic;

#nullable disable

namespace DB_DangKiHocPhan.Models
{
    public partial class MonHoc
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public string MaKhoa { get; set; }
        public int? SoTin { get; set; }
        public decimal? DonGia { get; set; }
    }
}
