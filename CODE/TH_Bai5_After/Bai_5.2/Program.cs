using System;

namespace Bai_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiaiPhuongTrinhBac2 pt1 = new GiaiPhuongTrinhBac2();
            pt1.Giai();

            GiaiPhuongTrinhBac2 pt2 = new GiaiPhuongTrinhBac2(1,2,-3);
            pt2.Giai();

            Console.ReadKey();
        }
    }
}
