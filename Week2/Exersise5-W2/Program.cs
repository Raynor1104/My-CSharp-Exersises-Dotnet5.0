using System;

namespace Exersise5_W2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, j;

            Console.Write("Enter array length: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write($"Element {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                    }
                }
            }

            Console.Write("Softed array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
