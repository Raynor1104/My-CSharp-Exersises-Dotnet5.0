using System;

namespace Exersise1_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days;

            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            if (month > 0 && month <= 12)
            {
               if (month == 2 && year % 4 == 0)
                {
                    days = 29;
                    Console.WriteLine($"This month has {days} days");
                }
                else if (month == 2 && year % 4 != 0) 
                {
                    days = 28;
                    Console.WriteLine($"This month has {days} days");
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    days = 30;
                    Console.WriteLine($"This month has {days} days");
                }
                else 
                {
                    days = 31;
                    Console.WriteLine($"This month has {days} days");
                }
            }
            else
            {
                 Console.WriteLine("Invalid month");
            }
        }
    }
}
