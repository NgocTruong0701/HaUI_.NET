using System;

namespace Bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int Tich = 1;
            Console.WriteLine("Nhap so n:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0 ||n == 1)
                Console.WriteLine("Giai thua cua {0} la: 1",n);
            else
            {
                for (int i = 1; i <= n; i++)
                    Tich *= i;
                Console.WriteLine("Giai thua cua so {0} la: {1}", n,Tich);
            }

            Console.ReadKey();
        }
    }
}
