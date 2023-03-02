using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._2
{
    internal class Circle
    {
        // bien private cua class
        private double radius;
        // thuoc tinh de truy nhap bien Radius (ban kinh)
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Constructor khong tham so
        public Circle()
        {
            this.Radius = 0;
        }

        // Constructor co tham so
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        // Create method Area() de tinh dien tich hinh tron
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        // Create method Perimeter() de tinh chu vi hinh tron
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
