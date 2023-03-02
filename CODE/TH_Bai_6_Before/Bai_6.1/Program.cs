using System;
using System.Collections.Generic;

namespace Bai_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> dssv = new List<Student>();
            int choice;
            do
            {
                Console.WriteLine("=================DANH SACH LUA CHON===============");
                Console.WriteLine("1. Them 1 sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Tim kiem sinh vien theo id");
                Console.WriteLine("4. Tim kiem sinh vien theo address");
                Console.WriteLine("5. Xoa mot sinh vien theo id");
                Console.WriteLine("6. Ket thuc chuong trinh");
                Console.WriteLine();
                Console.Write("***Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student sv = new Student();
                        sv.Input();
                        dssv.Add(sv);
                        break;
                    case 2:
                        Console.WriteLine("============OUTPUT===========");
                        Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-5}{4,-5}{5,-5}", "ID", "Ten", "DC", "Math", "Phys", "Total");
                        foreach (var i in dssv)
                        {
                            i.Output();
                            i.Total();
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        List<Student> dssvid = new List<Student>();
                        Console.Write("Nhap id can tim: ");
                        int id = int.Parse(Console.ReadLine());
                        foreach (var y in dssv)
                            if (y.id == id)
                                dssvid.Add(y);
                        if (dssvid.Count > 0)
                        {
                            Console.WriteLine("========DANH SACH SV TIM THEO ID===========");
                            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-5}{4,-5}{5,-5}", "ID", "Ten", "DC", "Math", "Phys", "Total");
                            foreach (var y in dssvid)
                            {
                                y.Output();
                                y.Total();
                                Console.WriteLine();
                            }
                        }
                        else
                            Console.WriteLine("Khong tim thay sinh vien co id nay");
                        break;
                    case 4:
                        List<Student> dssvad = new List<Student>();
                        Console.Write("Nhap dia chi can tim: ");
                        string dc = Console.ReadLine();
                        foreach (var i in dssv)
                            if (i.address == dc)
                                dssvad.Add(i);
                        if (dssvad.Count > 0)
                        {
                            Console.WriteLine("========DANH SACH SV TIM THEO DIA CHI===========");
                            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-5}{4,-5}{5,-5}", "ID", "Ten", "DC", "Math", "Phys", "Total");
                            foreach (var i in dssvad)
                            {
                                i.Output();
                                i.Total();
                                Console.WriteLine();
                            }
                        }
                        else
                            Console.WriteLine("Khong tim thay sinh vien co dia chi nay");
                        break;

                    case 5:
                        Console.Write("Nhap id muon xoa:");
                        int xoa = int.Parse(Console.ReadLine());
                        Student student = new Student(xoa);
                        
                        if (index != -1)
                        {
                            dssv.Remove(student);
                            Console.WriteLine("===========DANH SACH SV SAU KHI XOA=============");
                            Console.WriteLine("{0,-10}{1,-20}{2,-20}{3,-5}{4,-5}{5,-5}", "ID", "Ten", "DC", "Math", "Phys", "Total");
                            foreach (var i in dssv)
                            {
                                i.Output();
                                i.Total();
                                Console.WriteLine();
                            }
                        }
                        else
                            Console.WriteLine("Khong tim thay sinh vien co id nay de xoa");
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Khong co lua chon nay.Nhap lai!");
                        break;
                }
            }
            while (choice >=1 || choice < 6);

            Console.ReadKey();
        }
    }
}
