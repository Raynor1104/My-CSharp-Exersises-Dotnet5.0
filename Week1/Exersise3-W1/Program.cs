using System;

namespace Exersise3_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operation: ");
            string? operation = Console.ReadLine();
            Console.WriteLine("Enter second number: ");
            int secondnumber = Convert.ToInt32(Console.ReadLine());

            int result;
            if (operation == "+") 
            {
                result = firstnumber + secondnumber;
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
            }
            else if (operation == "-") 
            {
                result = firstnumber - secondnumber;
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
            }
            else if (operation == "x") 
            {
                result = firstnumber * secondnumber;
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
            }
            else if (operation == "/") 
            {
                result = firstnumber / secondnumber;
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
            }
            else 
            {
                Console.WriteLine("Invalid Operation");
            } 
        }
    }
}
