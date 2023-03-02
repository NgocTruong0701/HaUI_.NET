using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class HocSinh
    {
        string Hoten; // bien hoten
        int Tuoi; // bien tuoi
        public int DiemT { get; set; } // Thuoc tinh get set cua bien diemt -> truy xuat bien diemt
        public int DiemL { get; set; }
        public int DiemH { get; set; }

        List<HocSinh> dshs;

       
        public string GSHoTen // thuoc tinh getset hoten --> truy xuat vao bien hoten
        {
            get { return Hoten; }
            set { Hoten = value; }
        }

        public int GSTuoi // thuoc tinh get set tuoi -> truy xuat vao bien tuoi
        {
            get { return Tuoi; }
            set { Tuoi = value; }
        }

        public HocSinh()
        {
            Hoten = null;
            Tuoi = DiemH = DiemL = DiemT = 0;
        }

        public HocSinh(string x, int  y,int z, int w,int u)
        {
            Hoten = x;
            Tuoi = y;
            DiemT = z;
            DiemL = w;
            DiemH = u;
        }


        public void Nhap()
        {
            Console.WriteLine("Nhap ho ten hoc sinh:");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhap tuoi hoc sinh:");
            Tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem toan:");
            DiemT = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly:");
            DiemL = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa:");
            DiemH = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}", Hoten, Tuoi, DiemT, DiemL, DiemH);
        }

        public void XepLoai()
        {
            double trungB = (double)(DiemT + DiemL + DiemH) / 3;
            if (trungB >= 5)
                if (trungB >= 8.5)
                    if (trungB <= 10)
                        Console.WriteLine("Xep loai gioi");
                    else
                        Console.WriteLine("Xep loai kha");
                else
                    Console.WriteLine("Xep loai trung binh");
            else
                Console.WriteLine("Xep loai yeu");
        }

        public void NhapDS()
        {
            Console.WriteLine("Nhap so luong hoc sinh:");
            int n = int.Parse(Console.ReadLine());
            dshs = new List<HocSinh>();
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine("Nhap thong tin hoc sinh thu " + (i + 1));
                HocSinh hs = new HocSinh();
                hs.Nhap();
                dshs.Add(hs);
            }
        }

        public void XuatDS()
        {
            Console.WriteLine("=============DANH SACH SINH VIEN====================");
            Console.WriteLine("{0,-20}{1,-10}{2,-10}{3,-10}{4,-10}","Ho ten", "Tuoi", "Diem toan", "Diem ly", "Diem hoa");
            foreach (HocSinh i in dshs)
                i.Xuat();
        }
    }
}
