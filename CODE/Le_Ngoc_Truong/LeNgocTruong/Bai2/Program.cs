using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sv:");
            int n = int.Parse(Console.ReadLine());

            Student[] sv = new Student[n];
            Console.WriteLine("Nhap danh sach sinh vien:");
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine("Nhap thong tin sv thu " + (i + 1));
                sv[i] = new Student();
                sv[i].Nhap1();
            }

            Console.WriteLine("======DANH SACH SINH VIEN=========");
            Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-10}", "SID", "TenSV", "Khoa", "DiemTB");
            foreach (Student i in sv)
                i.Xuat1();

            Console.ReadKey();

        }
    }
}
