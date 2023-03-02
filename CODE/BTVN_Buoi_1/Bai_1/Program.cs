using System;

namespace Bai_1
{
    internal class Program
    {
        static void PTB2()
        {
            double a, b, c;
            Console.WriteLine("Nhap he so thu nhat: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so thu hai: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap he so thu 3 : ");
            c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co vo so nghiem");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                    Console.WriteLine("a = 0, Phuong trinh da cho la phuong trinh bac nhat co nghiem x = {0}", -c / b);
            }
            else
            {
                double denta = Math.Pow(b, 2) - 4 * a * c;
                if (denta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if (denta == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep x = {0}", -b / 2 * a);
                else
                {
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet:\n {0} \n {1}", Math.Round(-b - Math.Sqrt(denta)) / 2 * a, Math.Round(-b + Math.Sqrt(denta)) / 2 * a);
                }
            }
        }
        static void Main(string[] args)
        {
            PTB2();
            Console.ReadKey();
        }
    }
}
