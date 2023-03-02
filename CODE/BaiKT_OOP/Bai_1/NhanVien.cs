using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public double Luong1Hour { get; set; }
        public double SoGioL { get; set; }

        public NhanVien()
        {
            this.MaNV = String.Empty;
            this.Luong1Hour = 0;
            this.SoGioL = 0;
        }

        public NhanVien(string manv, double luong1h, double sogiol)
        {
            this.MaNV = manv;
            this.Luong1Hour = luong1h;
            this.SoGioL = sogiol;
        }

        public NhanVien(string manv)
        {
            this.MaNV = manv;
        }

        public string Salary()
        {
            return (this.Luong1Hour * SoGioL).ToString();
        }

        public override string ToString()
        {
            return String.Format("{0,-10}{1,-10}{2,-8}", MaNV, Luong1Hour, SoGioL);
        }

        public override bool Equals(object obj)
        {
            NhanVien nv = (NhanVien)obj;
            return (this.MaNV.Equals(nv.MaNV));
        }
    }
}
