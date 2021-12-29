﻿using System;

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
            do 
            {
                int result;
            
            switch (operation)
                {
                    case "+":
                        result = firstnumber + secondnumber;
                        Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
                        break;
                    case "-":
                        result = firstnumber - secondnumber;
                        Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
                        break;
                    case "x":
                        result = firstnumber * secondnumber;
                        Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
                        break;
                    case "/":
                        result = firstnumber / secondnumber;
                        Console.WriteLine($"{firstnumber} {operation} {secondnumber} = {result}");
                        break;
                    default:
                        Console.WriteLine("Invalid operation, please type the correct operation.");
                        operation = "\0";
                        break;
                }
            } while (operation == "\0");
        }
    }
}
/*
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
            } */
