using System;
using System.Collections.Generic;
using System.IO;

namespace Bai1._1
{
    internal class Program
    {
        static void Nhap(List<double> list_t)
        {
            string num;
            Console.WriteLine("Nhap so vao danh sach(dung khi nhap k/K): ");
            do
            {
                num = Console.ReadLine();
                if (num == "k" || num == "K")
                    break;
                list_t.Add(Double.Parse(num));
            }
            while (num != "k" && num != "K");
        }

        static void HienThiDS(List<double> list_t)
        {
            foreach (double i in list_t)
                Console.Write(i + " ");
        }

        static void SortUp(List<double> list_t)
        {
            list_t.Sort();
        }

        static void DelNegativeNumbers(List<double> list_t)
        {
            for(int i = 0;i <list_t.Count;i++)
                if(list_t[i] < 0)
                {
                    list_t.RemoveAt(i);
                    i--;
                }
        }

        static void insertSort(List<double> list_t)
        {
            Console.WriteLine("Nhap so can chen: ");
            double x = double.Parse(Console.ReadLine());

            for(int i = 0;i < list_t.Count;i++)
            {
                if (list_t[i] < x)
                    continue;
                else
                {
                    list_t.Insert(i, x);
                    break;
                }
            }
            if (x > list_t[list_t.Count - 1])
                list_t.Add(x);
        }

        static void RecordFile(List<double> list_t)
        {
            StreamWriter sw = new StreamWriter(@"E:\Download\KiPhu_2\C#_.NET\CODE\List_Review\Bai1.1\lIST_T.txt", false);
            foreach (double i in list_t)
                sw.Write(i + " ");
            Console.WriteLine("Danh sach da duoc ghi vao file");
            sw.Close();
        }

        static void ReadFile()
        {
            StreamReader sr = new StreamReader(@"E:\Download\KiPhu_2\C#_.NET\CODE\List_Review\Bai1.1\lIST_T.txt");
            Console.WriteLine("List doc o file:");
            while(sr.Peek() != -1)
            {
                Console.Write(sr.ReadLine() + " ");
            }
            sr.Close();
        }

        static void Main(string[] args)
        {
            List<double> list_t = new List<double>();
            Nhap(list_t);

            Console.WriteLine("List vua nhap: ");
            HienThiDS(list_t);
            Console.WriteLine();

            SortUp(list_t);
            Console.WriteLine("List sau khi sap xep tang dan:");
            HienThiDS(list_t);
            Console.WriteLine();

            DelNegativeNumbers(list_t);
            Console.WriteLine("List sau khi xoa cac so am:");
            HienThiDS(list_t);
            Console.WriteLine();

            insertSort(list_t);
            Console.WriteLine("List sau khi chen:");
            HienThiDS(list_t);
            Console.WriteLine();

            RecordFile(list_t);
            Console.WriteLine();

            ReadFile();

            Console.ReadKey();
        }
    }
}
