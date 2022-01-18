using System;

namespace Exersise6_W2
{
    class Program
    {
        static void InReverse(int[] a, int n)
        {
            int i;
            Console.Write("\nDisplay the element in reverse:\n");
            for (i = n - 1; i >= 0 ; i--)
            {
                Console.Write("{0} ", a[i]);
            }
        }

        static void ElementSum(int[] a, int n)
        {
            int i;
            int sum = 0;

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("\nSum of all element of the array:\n{0}", sum);
        }

        static void Frequency(int[] a, int[] frequency, int n)
        {
            int i, j, count;

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
            
            Console.WriteLine("Frequency: ");
            for (i = 0; i < n; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine("Element: {0} , Frequency: {1}", a[i], frequency[i]);
                }
            }         
        }

        static void AddNewElement(int[] a, int n)
        {
            int i;
            Console.WriteLine("Add new element:");
            Console.Write("Current array: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }

            Console.Write("\nEnter new element: ");
            int newElement = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("New array: ");
            for (i = 0; i < n + 1; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = newElement;
                }
                Console.Write($"{a[i]} ");   
            }
        }

        static void AscendingSort(int[] a, int n)
        {
            Console.Write("Ascending Sort:\n");
            int i, j;
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

        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];
            int[] frequency = new int[100];

            Console.Write("Enter array length: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
                frequency[i] = -1;
            }

            InReverse(a, n);
            ElementSum(a, n);
            Frequency(a, frequency, n);
            AddNewElement(a, n);
            AscendingSort(a, n);
        }
    }
}
