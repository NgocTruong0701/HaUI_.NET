using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class NhanVien
    {
        public string Name { get; set; }
        public string Phong { get; set; }
        public string Date { get; set; }
        public string GT { get; set; }
        public int SLB { get; set; }

        public NhanVien(string name, string phong, string date, string gT, int sLB)
        {
            Name = name;
            Phong = phong;
            Date = date;
            GT = gT;
            SLB = sLB;
        }
    }
}
