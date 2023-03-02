using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_Bai7
{
    internal class NhanVien
    {
        public string ID { get; set; }
        public string NameNV { get; set; }
        public double LuongN { get; set; }
        public double SoN { get; set; }

        public NhanVien(string iD, string nameNV, double luongN, double soN)
        {
            ID = iD;
            NameNV = nameNV;
            LuongN = luongN;
            SoN = soN;
        }

        public double Salary()
        {
            if (SoN <= 24)
                return SoN * LuongN;
            else
                return (24 + (SoN - 24) * 2) * LuongN;
        }
    }
}
