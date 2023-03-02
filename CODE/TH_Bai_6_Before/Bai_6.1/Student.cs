using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6._1
{
    internal class Student : Person
    {
        public byte maths { get; set; }
        public byte physics { get; set; }

        public Student() : base()
        {
            maths = 0;
            physics = 0;
        }

        public Student(int id, string name, string address, byte maths, byte physics) : base(id, name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public Student(int id):base(id)
        {
            maths = 0;
            physics = 0;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap diem toan: "); maths = byte.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: "); physics = byte.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.Write("{0,-5}{1,-5}", maths, physics);
        }

        public void Total()
        {
            Console.WriteLine("{0}",maths + physics);
        }
    }
}
