using System;
using System.Collections.Generic;

namespace Bai_5._1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(@"1. Nhap thong tin 1 thi sinh.
2. Hien thi danh sach cac thi sinh.
3. Hien thi danh sach cac thi sinh theo tong diem.
4. Hien thi danh sach cac thi sinh theo dia chi.
5. Tim kiem theo so bao danh.
6. Ket thuc chuong trinh.");
            List<ThiSinhA> DSTS = new List<ThiSinhA>();
            while(true)
            {
                Console.WriteLine("Nhap lua chon cua ban:");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        {
                            ThiSinhA sv = new ThiSinhA();
                            sv.input();
                            DSTS.Add(sv);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("{0,-15}{1,-20}{2,-20}{3,-8}{4,-8}{5,-8}{6,-8}{7,-8}", "So bao danh", "Ho ten", "Dia chi", "Diem toan", "Diem li", "Diem hoa", "Diem uu tien", "Tong diem");
                            foreach (ThiSinhA sv in DSTS)
                                sv.output();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nhap tong diem can tim:");
                            double td = double.Parse(Console.ReadLine());
                            Console.WriteLine("Danh sach sinh vien theo tong diem\n");
                            Console.WriteLine("{0,-15}{1,-20}{2,-20}{3,-8}{4,-8}{5,-8}{6,-8}{7,-8}", "So bao danh", "Ho ten", "Dia chi", "Diem toan", "Diem li", "Diem hoa", "Diem uu tien", "Tong diem");
                            foreach (ThiSinhA sv in DSTS)
                            {
                                if (sv.TongD >= td)
                                    sv.output();
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Nhap dia chi can kiem tra:");
                            string dc = Console.ReadLine();
                            Console.WriteLine("Danh sach sinh vien theo dia chi:\n");
                            Console.WriteLine("{0,-15}{1,-20}{2,-20}{3,-8}{4,-8}{5,-8}{6,-8}{7,-8}", "So bao danh", "Ho ten", "Dia chi", "Diem toan", "Diem li", "Diem hoa", "Diem uu tien", "Tong diem");
                            foreach (ThiSinhA sv in DSTS)
                                if (String.Compare(sv.Address, dc) == 0)
                                    sv.output();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Nhap so bao danh can search thong tin:");
                            string sbd = Console.ReadLine();
                            int index = DSTS.FindIndex(n => n.SID == sbd);
                            Console.WriteLine("{0,-15}{1,-20}{2,-20}{3,-8}{4,-8}{5,-8}{6,-8}{7,-8}", "So bao danh", "Ho ten", "Dia chi", "Diem toan", "Diem li", "Diem hoa", "Diem uu tien", "Tong diem");
                            DSTS[index].output();
                            break;
                        }
                    case 6:
                        {
                            return;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nhap sai.Khong co tac vu nay");
                            break;
                        }
                }
            }
        }
    }
}
