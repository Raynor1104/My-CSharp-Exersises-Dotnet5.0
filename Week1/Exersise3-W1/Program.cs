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


            if (operation == "+") 
            {
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {firstnumber + secondnumber}");
            }
            else if (operation == "-") 
            {
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {firstnumber - secondnumber}");
            }
            else if (operation == "x") 
            {
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {firstnumber * secondnumber}");
            }
            else if (operation == "/") 
            {
                Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {firstnumber / secondnumber}");
            }
            else 
            {
                Console.WriteLine("Invalid Operation");
            } 
        }
    }
}
