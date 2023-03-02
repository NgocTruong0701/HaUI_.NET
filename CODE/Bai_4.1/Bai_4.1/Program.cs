using System;

namespace Bai_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Input();
            person1.Output();
            person1.CheckAge();

            Console.ReadKey();
        }
    }
}
