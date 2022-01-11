using System;

namespace Exersise4_W2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];
            

            Console.Write("Enter array length: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Current array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            Console.Write("\nEnter new element: ");
            int newElement = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter position to insert this element: ");
            int position = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[n + 1];

            for (i = 0; i < n + 1; i++) 
            {
                if (i < position - 1)
                {
                    b[i] = a[i];
                }
                else if (i == position - 1)
                {
                    b[i] = newElement;
                }
                else
                {
                    b[i] = a[i - 1];
                }
            }

            Console.Write("New array: ");
            for (i = 0; i < n + 1; i++)
            {
                Console.Write("{0} ", b[i]);
            }
        }
    }
}
