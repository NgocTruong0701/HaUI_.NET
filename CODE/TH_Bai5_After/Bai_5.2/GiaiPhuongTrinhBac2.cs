using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._2
{
    internal class GiaiPhuongTrinhBac2
    {
        private int a, b, c;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public GiaiPhuongTrinhBac2()
        {
            A = 0;
            B = 0;
            C = 0;
        }

        public GiaiPhuongTrinhBac2(int x, int y, int z)
        {
            A = x;
            B = y;
            C = z;
        }

        public void Giai()
        {
            if(a == 0)
            {
                Console.WriteLine("Phuong trinh tro thanh phuong trinh bac nhat {0}x + {1} = 0",B,C);
                if(B == 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                    Console.WriteLine("Phuong trinh co nghiem don la: {0}",(double) - C/B);
            }
            else
            {
                double dental = B*B - (4 * A * C);
                if(dental < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else if(dental == 0)
                    Console.WriteLine("Phuong trinh co nghiem kep: {0}",(double) - B / 2*a);
                else
                {
                    double x1 = (double)((-B - Math.Sqrt(dental)) / 2 * A);
                    double x2 = (double)((-B + Math.Sqrt(dental)) / 2 * A);
                  
                    Console.WriteLine("Phuong trinh {0}x^2 + {1}x + {2} = 0 co hai nghiem phan biet:\n x1 = {3} \n x2 = {4}",A,B,C,x1,x2);
                }
                    
            }    
        }
    }
}
