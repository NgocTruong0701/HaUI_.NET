using System;

namespace Bai_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());
            TimUCLN[] DS = new TimUCLN[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}",i+1);
                DS[i] = new TimUCLN();
                DS[i].Sothunhat = double.Parse(Console.ReadLine());
                DS[i].Sothuhai = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Danh sach cac so va uoc chung lon nhat:");
            foreach(TimUCLN i in DS)
            {
                Console.WriteLine("UCLN cua {0} va {1} la : {2}", i.Sothunhat, i.Sothuhai, i.Giai2());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
