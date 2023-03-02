using System;
using System.Collections.Generic;

#nullable disable

namespace WPF_DB_QLKETQUA.Models
{
    public partial class Kq
    {
        public string MaSv { get; set; }
        public string MaMh { get; set; }
        public decimal? Diem { get; set; }

        public virtual Mon MaMhNavigation { get; set; }
        public virtual Sv MaSvNavigation { get; set; }
    }
}
