using System;

namespace Exersise5_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol: ");
            string? symbol = Console.ReadLine();

            if (symbol != null)
            {
                if (symbol.Length == 1)
                {
                    if (symbol == symbol.ToLower() && (symbol == "u" || symbol == "e" || symbol == "o" || symbol == "a" || symbol == "i"))
                    {
                        Console.WriteLine("It's a lowercase vowel.");
                    } 
                    else if (symbol == "1" || symbol == "2" || symbol == "3" || symbol == "4" || symbol == "5" || symbol == "6" || symbol == "7" || symbol == "8" || symbol == "9") 
                    {
                        Console.WriteLine("It's a degit.");
                    } 
                    else
                    {
                        Console.WriteLine("It's an other symbol.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid symbol");
                }
            }
        }
    }
}
