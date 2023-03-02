using System;
using System.Collections.Generic;

namespace Bai2._2
{
    internal class Program
    {
        // khai bao 2 hang chuyen 1 hang 55 la cac ki tu A B C D E F khi chuyen qua so thi cong ki tu ay them 55
        const char CHAR_55 = (char)55;
        // hang 44 la cac ki tu so 0 - 9 chuyen thanh so cong them 48
        const char CHAR_48 = (char)48;

        // ham chuyen doi tu co so 10 qua co so khac
        static void TentoOther(int n, int b)
        {

            //kiem tra co so nhap co hop le
            if (b < 0 || b < 2 || b > 16)
            {
                Console.WriteLine("Khong co he co so ay");
            }    
            else
            {
                // khai bao mang char de chua cac ki tu so sau khi chuyen, dung no de doc nguoc lai ra so sau khi chuyen
                List<char> numbers = new List<char>();
                int du;// bien chia lay du
                int remainder = n;// bien luu gia tri ban dau n sau do chia lay nguyen de ha dan 
                while(remainder > 0)
                {
                    du = remainder % b;// chia lay du
                    if (du >= 10) // neu du lon hon 10 la : A B C D E F tuong dung voi 10 - 15 thi cong them 55 de tu 10-15 ra ki tu A - F;
                        numbers.Add((char)(du + CHAR_55));
                    else
                        numbers.Add((char)(du + CHAR_48)); // neu chua lon hon 10 la cac so 0-9 thi cong them 48 de tu khi ep kieu char phair cong them 48 de ra cac ki tu so 0-9

                    remainder /= b;
                }

                // Hien thi he co so
                for (int i = numbers.Count - 1; i >= 0; i--)
                    Console.Write(numbers[i]);

            }
        }

        static void OtherToTen(string m, int c)
        {
            if (c < 0 || c < 2 || c > 16)
            {
                Console.WriteLine("Khong co he co so ay");
            }
            else
            {

                char[] letters = new char[m.Length];
                for(int i = 0;i < m.Length;i++)
                    letters[i] = m[i];
                Array.Reverse(letters);
                int[] num = new int[letters.Length];
                for(int i = 0;i < letters.Length;i++)
                    num[i] = (int)letters[i];
                double sum = 0;
                for(int i = num.Length - 1; i >= 0; i--)
                {
                    if (num[i] >= 65 && num[i] <= 70)
                        sum += (num[i] - 55) * Math.Pow(c,i);
                    if (num[i] >= 48 && num[i] <= 57)
                        sum += (num[i] - 48) * Math.Pow(c,i) ;
                }

                Console.WriteLine("So sau khi chuyen qua co so 10: " + sum);
            }
        }
        static void Main(string[] args)
        {
            // tu co so 10 chuyen qua co so khac
            /*
            int n, b;
            Console.WriteLine("Nhap so muon chuyen doi:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap co so muon chuyen:");
            b = int.Parse(Console.ReadLine());
            TentoOther(n, b);
            */
            // tu co so khac chuyen qua co so 10
            int c;
            string m;
            Console.WriteLine("Nhap so muon chuyen doi:");
            m = Console.ReadLine();
            Console.WriteLine("Nhap co so cua so nay:");
            c = int.Parse(Console.ReadLine());
            OtherToTen(m, c);

            Console.ReadKey();
        }
    }
}
