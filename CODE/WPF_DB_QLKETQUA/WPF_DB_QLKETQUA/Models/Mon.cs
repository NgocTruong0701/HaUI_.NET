using System;
using System.Collections.Generic;

#nullable disable

namespace WPF_DB_QLKETQUA.Models
{
    public partial class Mon
    {
        public Mon()
        {
            Kqs = new HashSet<Kq>();
        }

        public string MaMh { get; set; }
        public string TenMh { get; set; }
        public int? Sotc { get; set; }

        public virtual ICollection<Kq> Kqs { get; set; }
    }
}
