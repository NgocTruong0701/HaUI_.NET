using System;
using System.Collections.Generic;

namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao list voi kieu string chua ten cac thanh pho
            List<string> ThanhPho = new List<string>();
            Console.WriteLine("Them 5 thanh pho:");
            //Them 5 thanh pho
            for(int i = 0;i < 5 ;i++)
            {
                Console.WriteLine("Thanh pho thu " + (i + 1));
                ThanhPho.Add(Console.ReadLine());
            }


            // Dung phuong thuc sort cua class List de sap xep tang dan A - Z
            ThanhPho.Sort();
            // In ra danh sach thanh pho sau khi sap xep
            Console.WriteLine("Danh sach thanh pho sau khi sap xep tu A - Z:");
            foreach (string i in ThanhPho)
                Console.WriteLine(i);

            // Dung ham remove de xoa thanh pho co ten "Ha Noi", sau do dung ham for de add them 5 thanh pho khac va in lai
            ThanhPho.Remove("Ha Noi");

            for(int i = 0; i < 5;i++)
            {
                Console.WriteLine("Nhap them thanh pho thu " + (i + 1));
                ThanhPho.Add(Console.ReadLine());
            }

            // In ra danh sach thanh pho
            Console.WriteLine("Danh sach thanh pho sau khi xoa thanh pho \"Ha Noi\" va them moi 5 thanh pho moi:");
            foreach (string i in ThanhPho)
                Console.WriteLine(i);



            Console.ReadKey();
        }
    }
}
