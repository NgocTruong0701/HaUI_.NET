using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._1
{
    internal class ThiSinhA
    {
        // Tao cac bien noi bo cua class
        private string sID;
        private string name;
        private string address;
        private double diemT;
        private double diemL;
        private double diemH;
        private double diemUT;
        private double tongD;

        // Tao cac thuoc tinh de truy cap vao bien
        public string SID { get => sID; set => sID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public double DiemT { get => diemT; set => diemT = value; }
        public double DiemL { get => diemL; set => diemL = value; }
        public double DiemH { get => diemH; set => diemH = value; }
        public double DiemUT { get => diemUT; set => diemUT = value; }
        // Thuoc tinh nay khong co gan gia tri nhap ma dua vao cac diem toan ly hoa va uu tien de tinh nen cho co get de dua ra
        public double TongD
        {
            get
            {
                tongD = diemT + diemL + diemH + diemUT;
                return tongD;
            }
        }

        // Create Method to Input data
        public void input()
        {
            Console.WriteLine("Nhap so bao danh:");
            SID = Console.ReadLine();
            Console.WriteLine("Nhap ten:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:");
            Address = Console.ReadLine();
            Console.WriteLine("Nhap diem toan:");
            DiemT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem li:");
            DiemL = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa");
            DiemH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem uu tien:");
            DiemUT = double.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("{0,-15}{1,-20}{2,-20}{3,-8}{4,-8}{5,-8}{6,-8}{7,-8}",SID,Name,Address,DiemT,DiemL,DiemH,DiemUT,TongD);
        }
    }
}
