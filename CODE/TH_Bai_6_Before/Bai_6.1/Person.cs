using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6._1
{
    internal class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public Person()
        {
            id = 0;
            name = null;
            address = null;
        }

        public Person(int id)
        {
            this.id = id;
        }

        public Person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public virtual void Input()
        {
            Console.Write("Nhap id: "); id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ten: "); name = Console.ReadLine();
            Console.Write("Nhap dia chi: "); address = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.Write("{0,-10}{1,-20}{2,-20}", id, name, address);
        }
    }
}
