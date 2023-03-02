using System;
using System.Collections.Generic;

namespace CauTruc
{
    internal class Program
    {
        public struct HocSinh
        {
            public string fullName;
            public int Age;
            public bool sex;
        }
        static void Main(string[] args)
        {
            // Khai bao nang Hoc sinh gom 5 phan tu
            HocSinh []dshs = new HocSinh[5];
            for(int i = 0; i < 5;i++)
            {
                Console.WriteLine("Nhap ho ten hs thu " + (i + 1));
                dshs[i].fullName = Console.ReadLine();
                Console.WriteLine("Nhap tuoi hs thu " + (i + 1));
                dshs[i].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap gioi tinh (nam = true, nu = false) hs thu " + (i + 1));
                dshs[i].sex = bool.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (HocSinh i in dshs)
                sum += i.Age;
            Console.WriteLine("Tong tuoi cua 5 hoc sinh: " + sum);
            
            Console.ReadKey();
        }
    }
}
