using System;

namespace Exersise2_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <=9; j++) 
                {
                    int ji = j * i;
                    Console.Write($"|{j} x {i} = {ji}\t");
                }
            Console.WriteLine();
            }
        }
    }
}
