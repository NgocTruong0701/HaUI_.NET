using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._1
{
    internal class Employee
    {
        double salary;
        public const int _PRICE = 50;
        public string ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkingDays { get; set; }
        public double Salary
        {
            get
            {
                salary = WorkingDays * _PRICE;
                return salary;
            }
        }

        public Employee()
        {
            ID = null;
            Name = null;
            Age = 0;
            WorkingDays = 0;
        }

        public Employee(string iD, string name, int age, int workingDays)
        {
            this.ID = iD;
            this.Name = name;
            this.Age = age;
            this.WorkingDays = workingDays;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ID:");
            ID = Console.ReadLine();
            Console.WriteLine("Nhap ten NV:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi NV:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay lam cua NV:");
            WorkingDays = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}{4,-10}", "ID", "Name", "Age", "WorkingDays", "Salary");
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-10}{4,-10}",ID,Name,Age,WorkingDays,Salary);
        }
    }
}
