using System;
using System.Collections.Generic;

namespace Bai3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sv:");
            int n = int.Parse(Console.ReadLine());
            List<Student> dssv = new List<Student>();
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine("Nhap thong tin sv thu " + (i + 1));
                Student sv = new Student();
                sv.Nhap1();
                dssv.Add(sv);
            }

            Console.WriteLine("======DANH SACH SINH VIEN=========");
            Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-10}", "SID", "TenSV", "Khoa", "DiemTB");
            foreach (Student i in dssv)
                i.Xuat1();
        }
    }
}
