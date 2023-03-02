using System;

namespace Bai_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee nv1 = new Employee();
            nv1.Output();

            Employee nv2 = new Employee("NV002", "Le Van B", 20, 29);
            nv2.Output();

            Employee nv3 = new Employee();
            nv3.Input();
            nv3.Output();

            Console.ReadKey();
        }
    }
}
