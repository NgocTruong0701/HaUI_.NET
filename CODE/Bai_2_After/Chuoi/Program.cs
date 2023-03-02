using System;

namespace Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string chuoi1;
            Console.WriteLine("nhap chuoi de hien thi ki tu:");
            chuoi1 = Console.ReadLine();
            foreach (char i in chuoi1)
                Console.Write(i + " ");
            Console.WriteLine();

            string chuoi2;
            Console.Write("nhap chuoi 2 de hien thi tu trong chuoi: ");
            chuoi2 = Console.ReadLine();
            chuoi2.Trim();
            string[] tu = chuoi2.Split(" ");
            foreach(string t in tu)
                Console.WriteLine(t);

            string chuoi3;
            Console.WriteLine("nhap chuoi 3 de hien thi cac ki tu trong chuoi: ");
            chuoi3 = Console.ReadLine();
            string chuoicopy = chuoi3.Replace(" ", string.Empty);
            string chuoicopy1 = chuoi3.Replace(" ", string.Empty);

            while (chuoicopy.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < chuoicopy.Length; i++)
                {
                    if (chuoicopy[0] == chuoicopy[i])
                        count++;
                }
                Console.WriteLine($"Ki tu {chuoicopy[0]} xuat hien " + count);
                chuoicopy = chuoicopy.Replace(chuoicopy[0].ToString(), String.Empty);
            }   

            for(int i = 0;i < chuoicopy1.Length;i++)
            {
                int dem = 0;
                for (int j = i; j < chuoicopy1.Length; j++)
                    if (chuoicopy1[i] == chuoicopy1[j])
                    {
                        dem++;
                    }
                Console.WriteLine($"Ki tu {chuoicopy1[i]} xuat hien " + dem);
                chuoicopy1 = chuoicopy1.Replace(chuoicopy1[i].ToString(), String.Empty);
                i--;
            }

            Console.ReadKey();

        }
    }
}
