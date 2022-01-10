using System;

namespace Exersise4_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle: ");
            double radiusOfCircle = Convert.ToDouble(Console.ReadLine());
            
            double perimeterOfCircle = radiusOfCircle * 2 * Math.PI;
            Console.WriteLine($"Perimeter of Circle: {perimeterOfCircle}");
        }
    }
}
