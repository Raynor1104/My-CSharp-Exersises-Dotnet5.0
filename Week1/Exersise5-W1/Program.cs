using System;

namespace Exersise5_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            Console.WriteLine("Enter a symbol: "); 
            symbol = Console.ReadKey().KeyChar;
    
            if (symbol == 'u' || symbol == 'e' || symbol == 'o' || symbol == 'a' || symbol == 'i')
            { 
                Console.WriteLine($" is a lowercase vowel.");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine(" is a degit.");
            }
            else
            {
                Console.WriteLine(" is an other symbol.");
            }
        }
    }
}