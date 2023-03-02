using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // su dung constructor khong co tham so
            GiaiPTbac1 pt = new GiaiPTbac1();
            pt.Nhap();
            pt.Giai();
            Console.WriteLine();

            // su dung constructor co tham so
            GiaiPTbac1 pt1 = new GiaiPTbac1(1, 2);
            pt1.Giai();

            Console.ReadKey();
        }
    }
}
