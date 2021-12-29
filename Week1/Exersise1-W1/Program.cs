using System;

namespace Exersise1_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            int day31 = 31;
            int day30 = 30;
            int day29 = 29;
            int day28 = 28;

            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            if (month > 0 && month <= 12)
            {
               if (month == 2 && year % 4 == 0)
                {
                    Console.WriteLine($"This month has {day29} days");
                }
                else if (month == 2 && year % 4 != 0) 
                {
                    Console.WriteLine($"This month has {day28} days");
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine($"This month has {day30} days");
                }
                else 
                {
                    Console.WriteLine($"This month has {day31} days");
                }
            }
            else
            {
                 Console.WriteLine("Invalid month");
            }
        }
    }
}
