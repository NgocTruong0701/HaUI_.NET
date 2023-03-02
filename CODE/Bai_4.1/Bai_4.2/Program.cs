using System;

namespace Bai_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Circle circle1 = new Circle(2.5);

            Console.WriteLine("Area circle1 is {0}", circle.Area());
            Console.WriteLine("Perimeter circle1 is {0}",circle.Perimeter());

            Console.WriteLine();
            Console.WriteLine("Area circle2 is {0}",circle.Area());
            Console.WriteLine("Perimeter circle2 is {0}", circle.Perimeter());

            Console.ReadKey();
        }
    }
}
