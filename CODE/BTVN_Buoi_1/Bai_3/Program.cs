using System;

namespace Bai_3
{
    internal class Program
    {
        static bool CheckYear(int year)
        {
            if (year % 400 == 0)
                return true;
            else if (year % 4 == 0 && year % 100 != 0)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());
            int number_of_days;

            if(month == 2)
            {
                if(CheckYear(year))
                    number_of_days = 29;
                else
                    number_of_days = 28;
            }
            else
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        {
                            number_of_days = 31;
                            break;
                        }
                    case 4:
                    case 6:
                    case 9:
                        {
                            number_of_days = 30;
                            break;
                        }
                    default:
                        {
                            number_of_days = 28;
                            break;
                        }
                }
            }
            Console.WriteLine("Thang {0} cua nam {1} co {2} ngay",month,year, number_of_days);
            Console.ReadKey();
        }
    }
}
