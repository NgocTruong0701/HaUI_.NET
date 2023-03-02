using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5._3
{
    internal class TimUCLN
    {
        public double Sothunhat { get; set; }
        public double Sothuhai { get; set; }

        public TimUCLN()
        {
            Sothunhat = 0;
            Sothuhai = 0;
        }

        public TimUCLN(double sothunhat, double sothuhai)
        {
            this.Sothunhat = sothunhat;
            this.Sothuhai = sothuhai;
        }
        public double Giai2()
        {
            // lap cho toi khi 1 trong 2 so = 0
            while(Sothunhat * Sothuhai != 0)// dung tich de kiem tra 1 trong 2 so co bang 0?
            {
                if (Sothunhat > Sothuhai)
                    Sothunhat %= Sothuhai;
                else
                    Sothuhai %= Sothunhat;
            }
            return Sothunhat + Sothuhai;//luc nay se co 1 trong 2 so = 0 nen la return tong 2 so
        }
    }
}
