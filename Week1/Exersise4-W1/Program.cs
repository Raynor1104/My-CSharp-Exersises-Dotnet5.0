using System;

namespace Exersise4_W1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of circle: ");
            double RadiusOfCircle = Convert.ToDouble(Console.ReadLine());
            
            double PerimeterOfCircle = RadiusOfCircle * 2 * Math.PI;
            Console.WriteLine($"Perimeter of Circle: {PerimeterOfCircle}");
        }
    }
}
