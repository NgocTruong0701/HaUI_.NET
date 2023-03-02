using System;


namespace TongHop
{
    internal class Program
    {
        public struct SinhVien
        {
            public int SID;
            public string Name;
            public string Sex;
            public int Age;
            public double DiemT;
            public double DiemL;
            public double DiemH;
            public double _DiemTB;
            public string _HocLuc;

            public double DiemTB
            {
                get
                {
                    _DiemTB = (DiemT + DiemL + DiemH) / 3;
                    return _DiemTB;
                }
            }

            public string HocLuc
            {
                get
                {
                    if (_DiemTB >= 8)
                        _HocLuc = "Gioi";
                    else if (DiemTB < 8 && DiemTB >= 6.5)
                        _HocLuc = "Kha";
                    else if (DiemTB < 6.5 && DiemTB >= 5)
                        _HocLuc = "Trung Binh";
                    else
                        _HocLuc = "Yeu";

                    return _HocLuc;
                }
            }
        }


        static void Main(string[] args)
        {
            int luachon;
            Console.WriteLine("==============BANG LUA CHON=================");
            Console.WriteLine("1. Thêm sinh viên.");
            Console.WriteLine("2.Cập nhật thông tin sinh viên bởi ID."); 
            Console.WriteLine("3.Xóa sinh viên bởi ID.");
            Console.WriteLine("4.Tìm kiếm sinh viên theo tên.");
            Console.WriteLine("5.Sắp xếp sinh viên theo điểm trung binh.");
            Console.WriteLine("6.Sắp xếp sinh viên theo tên.");
            Console.WriteLine("7.Hiển thị danh sách sinh viên.");
            Console.WriteLine("8.Ghi danh sách sinh viên vào file \"student.txt\".");
            Console.WriteLine("Nhap lua chon:");
            try
            {
                luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        {

                        }
                }
            }
        }
    }
}
