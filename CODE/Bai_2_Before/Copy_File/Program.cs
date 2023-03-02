using System;
using System.IO;

namespace Copy_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Le Ngoc Truong yeu all!";
            StreamWriter sw = new StreamWriter(@"E:\Download\KiPhu_2\C#_.NET\CODE\Bai_2_Before\Copy_File\nguon.txt", false); 
            sw.WriteLine(name);
            sw.Close();
            Console.WriteLine("Da ghi vao file bang StreamWriter");

            StreamReader sr = new StreamReader(@"E:\Download\KiPhu_2\C#_.NET\CODE\Bai_2_Before\Copy_File\nguon.txt");
            string doc = sr.ReadToEnd();
            Console.WriteLine(doc); 
            sr.Close();

             
            File.WriteAllText(@"E:\Download\KiPhu_2\C#_.NET\CODE\Bai_2_Before\Copy_File\nguon1.txt", name);// Tao file va ghi du lieu vao file
            Console.WriteLine(File.ReadAllText(@"E:\Download\KiPhu_2\C#_.NET\CODE\Bai_2_Before\Copy_File\nguon1.txt"));//doc file
            Console.ReadKey();
        }
    }
}
