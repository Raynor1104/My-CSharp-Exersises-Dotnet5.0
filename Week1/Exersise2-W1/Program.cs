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
                    string Table = String.Format($"|{j} x {i,2}  = {ji,2}");
                    Console.Write(Table);
                }
            Console.WriteLine("|");
            }
        }
    }
}
