using System;

namespace Exersise3_W2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int[] frequency = new int[100];
            int i, n, j, count;

            Console.Write("Enter array length: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                frequency[i] = -1;
            }

            for (i = 0; i < n; i++)
            {
                count = 1;
                for (j = i + 1; j < n ; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        frequency[j] = 0;
                    }
                }

                if (frequency[i] != 0)
                {
                    frequency[i] = count;
                }
            }

            for (i = 0; i < n; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine("\nElement: {0} , Frequency: {1}", a[i], frequency[i]);
                }
            }
        }
    }
}
