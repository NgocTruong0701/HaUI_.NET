using System;

namespace Bai_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap kich thuoc cua mang: ");
            int n = int.Parse(Console.ReadLine());

            double[]arr = new double[n];
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}", i + 1);
                arr[i] = double.Parse(Console.ReadLine());
            }

            double max = arr[0];
            double min = arr[0];
            double sumOfArr = 0;

            foreach(double d in arr)
            {
                if (d > max)
                    max = d;
                if (d < min)
                    min = d;
                sumOfArr += d;
            }

            Console.WriteLine("Max of arr:" + max);
            Console.WriteLine("Min of arr:" + min);
            Console.WriteLine("Sum of arr:" + sumOfArr);

            Console.ReadKey();
        }
    }
}
