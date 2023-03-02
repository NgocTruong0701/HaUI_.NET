using System;

namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong cua danh sach: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[n];
            for(int i = 0;i < n;i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}", i + 1);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Cac so chan: ");
            for (int i = 0; i < n; i++)
                if (nums[i] % 2 == 0)
                    Console.Write(nums[i] + " ");
            Console.WriteLine();

            Console.Write("Cac so le: ");
            for (int i = 0; i < n; i++)
                if (nums[i] % 2 != 0)
                    Console.Write(nums[i] + " ");
            Console.WriteLine();

            Console.Write("Cac so nguyen to: ");
            for (int i = 0; i < n; i++)
            {
                if (nums[i] < 2)
                    continue;
                else
                {
                    int count = 0;
                    for (int j = 2; j <= nums[i] / 2; j++)
                        if (nums[i] % j == 0)
                            count++;
                    if (count == 0)
                        Console.Write(nums[i] + " ");
                    else
                        continue;
                }
            }

            Console.ReadKey();
        }
    }
}
