using System;

namespace Exersise4_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle: ");
            double radiusCircle = Convert.ToDouble(Console.ReadLine());
            
            double perimeterCircle = radiusCircle * 2 * Math.PI;
            Console.WriteLine($"Perimeter of Circle: {perimeterCircle}");
        }
    }
}
