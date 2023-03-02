using System;

namespace Bai1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            do
            {
                Console.WriteLine("Nhap canh thu nhat : ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap canh thu hai : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap canh thu ba : ");
                c = int.Parse(Console.ReadLine());
                if (a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (b + c) > a)
                    Console.WriteLine("Nhap sai hinh tam giac, nhap lai: ");
            }
            while ((a <= 0 || b <= 0 || c <= 0) && ((a + b) >= c || (a + c) >= b || (b + c) >= a));
            float S, CV, P;
            CV = a + b + c;
            P = CV / 2;
            S = (float)Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine("Chu vi cua tam giac do la : {0}", CV);
            Console.WriteLine("Dien tich cua tam giac do la : {0}",S);
            Console.ReadKey();
        }
    }
}
