using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._1
{
    internal class Person
    {
        // Bien cua class
        private string id;
        private string name;
        private int age;
        private string email;
        private string address;

        // Cac thuoc tinh de truy nhap bien cua class
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        // Khai bao phuong thuc checkAge()
        public void CheckAge()
        {
            string kq = Age >= 18 ? "Ban du tuoi bau cu" : "Ban con nho";
            Console.WriteLine(kq);
        }

        // Khai bao phuong thuc input()
        public void Input()
        {
            Console.WriteLine("Nhap id:");
            Id = Console.ReadLine();
            Console.WriteLine("Nhap ten:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi:");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dia chi email:");
            Email = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:");
            Address = Console.ReadLine();
        }

        // Khai bao phuong thuc output()
        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-20}{4,-20}", "Id", "Name", "Age", "Email", "Address");
            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,-20}{4,-20}", Id, Name, Age, Email, Address);
        }
    }
}
