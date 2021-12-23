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
            int secondnumber = Convert.ToInt32(Console.ReadLine());;
            int minus = firstnumber - secondnumber;
            int plus = firstnumber + secondnumber;
            int divide = firstnumber / secondnumber;
            int multiple = firstnumber * secondnumber;
            if (operation == "+" || operation == "-" || operation == "x" || operation == "/")
            {
                if (operation == "+") 
                {
                    Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {plus}");
                }
                if (operation == "-") 
                {
                    Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {minus}");
                }
                if (operation == "x") 
                {
                    Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {multiple}");
                }
                if (operation == "/") 
                {
                    Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {divide}");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }
    }
}
