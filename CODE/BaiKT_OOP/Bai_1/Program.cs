using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                int choice;
                Console.WriteLine("============DANH SÁCH MENU LỰA CHỌN=============");
                Console.WriteLine();
                Console.WriteLine("1. Nhập thông tin nhân viên");
                Console.WriteLine("2. Hiển thị danh sách nhân viên");
                Console.WriteLine("3. Xóa nhân viên");
                Console.WriteLine("4. Tìm nhân viên");
                Console.WriteLine("5. Thoát");

                Console.Write("Mời chọn lựa chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhập thông tin nhân viên: ");
                        NhanVien nv = new NhanVien();
                        Console.Write("Nhập mã nhân viên: ");
                        nv.MaNV = Console.ReadLine();
                        Console.Write("Nhập lương 1 giờ: ");
                        nv.Luong1Hour = double.Parse(Console.ReadLine());
                        Console.Write("Nhập sô giờ làm: ");
                        nv.SoGioL = double.Parse(Console.ReadLine());

                        dsnv.Add(nv);
                        break;

                    case 2:
                        Console.WriteLine("{0,-10}{1,-10}{2,-8}{3,-10}", "Ma NV","Luong1H", "Gio lam", "Luong");
                        foreach (NhanVien i1 in dsnv)
                        {
                            Console.Write(i1.ToString());
                            Console.WriteLine("{0,-10}",i1.Salary());
                        }
                        
                        break;

                    case 3:
                        Console.Write("Nhập vị trí cần xóa nhân viên: ");
                        int i = int.Parse(Console.ReadLine());
                        if (i < 0 || i > dsnv.Count)
                            Console.WriteLine("Vị trí không hợp lệ.");
                        else
                        {
                            dsnv.RemoveAt(i-1);
                        }
                        break;

                    case 4:
                        Console.Write("Nhập mã nv cần tìm: ");
                        string manv = Console.ReadLine();
                        NhanVien nv1 = new NhanVien(manv);
                        int index = dsnv.IndexOf(nv1);
                        if (index == -1)
                            Console.WriteLine("Không có nhân viên này");
                        else
                        {
                            Console.WriteLine("Thông tin nhân viên cần tìm: ");
                            Console.WriteLine("{0,-10}{1,-10}{2,-8}{3,-10}", "Ma NV","Luong1H", "Gio lam", "Luong");
                            Console.Write(dsnv[index].ToString());
                            Console.WriteLine("{0,-10}", dsnv[index].Salary());
                        }
                        break;

                    case 5:
                        Console.WriteLine("GOOD BYE!");
                        return;

                    default:
                        Console.WriteLine("Không có lựa chọn này, mời chọn lại");
                        Console.WriteLine();
                        break;
                }
            }
            while (true);
        }
    }
}
