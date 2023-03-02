using System;
using System.Collections.Generic;

#nullable disable

namespace WPF_DB_QLKETQUA.Models
{
    public partial class Sv
    {
        public Sv()
        {
            Kqs = new HashSet<Kq>();
        }

        public string MaSv { get; set; }
        public string TenSv { get; set; }
        public string Que { get; set; }

        public virtual ICollection<Kq> Kqs { get; set; }
    }
}
