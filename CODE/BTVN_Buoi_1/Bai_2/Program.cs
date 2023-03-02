using System;

namespace Bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary, bonus;
            Console.WriteLine("Nhap tien luong: ");
            salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien thuong: ");
            bonus = Convert.ToDouble(Console.ReadLine());

            double earnings = salary + bonus;
            if (earnings < 9000000)
                Console.WriteLine("Khong dong thue");
            else
            {
                if (earnings < 15000000)
                    Console.WriteLine("Thue can dong la 10% tien thu nhap : {0}", (earnings) * 10 / 100 );
                else
                {
                    if (earnings <= 30000000)
                        Console.WriteLine("Thue can dong la 15% tien thu nhap : {0}", earnings * 15 / 100);
                    else
                        Console.WriteLine("Thue can dong la 20% tien thu nhap : {0}", earnings * 20 / 100);
                }
            }

            Console.ReadLine();
        }
    }
}
