using System;

namespace Exersise2_W2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            int[] a= new int[100];

            Console.Write("Enter array length: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0} : ",i);
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("\nSum of all element of the array: {0}", sum);
        }
    }
}
