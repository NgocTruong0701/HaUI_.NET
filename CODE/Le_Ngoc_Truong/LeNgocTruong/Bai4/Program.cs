using System;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dung phuong thuc khoi tao khong tham so
            HocSinh a = new HocSinh();
            a.Xuat();

            // Dung phuong thuc khoi tao co tham so
            HocSinh b = new HocSinh("Le Ngoc Truong", 20, 10, 10, 10);
            b.Xuat();
            b.XepLoai();

            // Dung nhap 1 danh sach hoc sinh
            HocSinh c = new HocSinh();
            c.NhapDS();
            c.XuatDS();

            Console.ReadKey();
        }
    }
}
