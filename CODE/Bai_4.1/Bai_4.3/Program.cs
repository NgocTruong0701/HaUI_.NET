using System;

namespace Bai_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", student1.Id, student1.Name, student1.Mark, student1.Scholarship);

            Console.WriteLine();
            Student student2 = new Student("ST001");
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", student2.Id, student2.Name, student2.Mark, student2.Scholarship);

            Console.WriteLine();
            Student student3 = new Student("ST002", "Le Ngoc Truong", 9);
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}", student3.Id, student3.Name, student3.Mark, student3.Scholarship);

            Console.ReadKey();
        }
    }
}
