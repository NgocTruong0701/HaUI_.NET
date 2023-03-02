using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class GiaiPTbac1
    {
        // tao thuoc tinh he so a,b 
        public double a { get; set; }
        public double b { get; set; }

        // tao constructor(phuong thuc khoi tao) khong tham so
        public GiaiPTbac1()
        {
            a = 0;
            b = 0;
        }

        // tao constructor co tham so
        public GiaiPTbac1(double x, double y)
        {
            a = x;
            b = y;
        }

        // tao phuong thuc nhap
        public void Nhap()
        {
            Console.WriteLine("Nhap he so a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap he so b:");
            b = double.Parse(Console.ReadLine());
        }

        // tao phuong thuc giai phuong trinh
        public void Giai()
        {
            if (a != 0)
                Console.WriteLine("Nghiem cua phuong trinh " + a +"x + " + b + " = 0 la : " + (-b / a));
            else if (b == 0)
                Console.WriteLine("Phuong trinh vo so nghiem");
            else
                Console.WriteLine("Phuong trinh vo nghiem");
        }

    }
}
