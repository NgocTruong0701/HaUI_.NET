using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3a
{
    class Student
    {
        // Khai bao cac thuoc tinh SID, TenSV, Khoa, DiemTV {get; set} do khong co dieu kien gi ve du lieu
        public int SID { get; set; }
        public string TenSV { get; set; }
        public string Khoa { get; set; }
        public double DiemTB { get; set; }

        public Student[] dssv;

        public int n { get; set; }

        // Khai bao constructor khong tham so
        public Student()
        {
            SID = 0;
            TenSV = null;
            Khoa = null;
            DiemTB = 0;
        }

        //Khai bao constructor co tham so
        public Student(int x, string y, string z, double w)
        {
            SID = x;
            TenSV = y;
            Khoa = z;
            DiemTB = w;
        }

        // Khai bao phuong thuc nhap 1 sv
        public void Nhap1()
        {
            Console.WriteLine("Nhap ma sv:");
            SID = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten sv:");
            TenSV = Console.ReadLine();
            Console.WriteLine("Nhap ten khoa:");
            Khoa = Console.ReadLine();
            Console.WriteLine("Nhap diem trung binh:");
            DiemTB = double.Parse(Console.ReadLine());
        }

        // Khai bao phuong thuc xuat 1 sv
        public void Xuat1()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-10}", SID, TenSV, Khoa, DiemTB);
        }

        // Khai bao phuong thuc nhap dssv
        public void NhapDS()
        {
            Console.WriteLine("Nhap so luong sinh vien:");
            n = int.Parse(Console.ReadLine());
            dssv = new Student[n];

            Console.WriteLine("Nhap thong tin sinh vien:");
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine("Mhap tt sinh vien thu " + (i + 1));
                dssv[i] = new Student();
                dssv[i].Nhap1();
            }
        }

        // Khai bao phuong thuc xuat danh sach
        public void XuatDS()
        {
            Console.WriteLine("======DANH SACH SINH VIEN=========");
            Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-10}", "SID", "TenSV", "Khoa", "DiemTB");
            foreach (Student i in dssv)
                i.Xuat1();
        }
    }
}
