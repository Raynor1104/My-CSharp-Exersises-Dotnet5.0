using System;

namespace Exersise3_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operation: ");
            string? operation = Console.ReadLine();
            Console.Write("Enter second number: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            if (operation == "+") 
            {
                result = firstnumber + secondnumber;
            }
            else if (operation == "-") 
            {
                result = firstnumber - secondnumber;
            }
            else if (operation == "x") 
            {
                result = firstnumber * secondnumber;
            }
            else if (operation == "/") 
            {
                result = firstnumber / secondnumber;
            }
            else 
            {
                Console.WriteLine("Invalid Operation");
            }

            Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
        }
    }
}
