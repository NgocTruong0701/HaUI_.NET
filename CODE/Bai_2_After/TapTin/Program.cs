using System;
using System.IO;

namespace TapTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"E:\Download\KiPhu_2\C#_.NET\CODE\Bai_2_After\TapTin\Mang.txt");
            string doc = sr.ReadToEnd();
            sr.Close();

            // for (int index = 0;if < doc.Length;i++)
            int[] mang = new int[doc.Length];
            doc.Replace(" ", String.Empty);

            char[] chars = doc.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
                Console.Write(chars[i] +" ");
                
            

            Console.ReadKey();
        }
    }
}
