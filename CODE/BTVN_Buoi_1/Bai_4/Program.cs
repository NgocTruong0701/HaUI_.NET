using System;

namespace Bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap so nguyen duong n(0 < n <= 100): ");
                n = int.Parse(Console.ReadLine());
                
                if(n <= 0 || n > 100)
                    Console.WriteLine("Khong thoa man, nhap lai!");
            }
            while(n <= 0 || n > 100);

            int sum1 = 0, sum2 = 0, sum3 = 0;
            int i = 1;
            while(i <= n)
            {
                sum1 += i;
                i++;
            }
            int j = 1;
            do
            {
                sum2 += j;
                j++;
            }
            while(j <= n);
            for (int z = 1; z <= n; z++)
                sum3 += z;
            Console.WriteLine("While {0}\n Do_While {1} \n For {2}",sum1,sum2,sum3);
            Console.ReadKey();
        }
    }
}
