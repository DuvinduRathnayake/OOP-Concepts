using System;
using System.Collections.Generic;

namespace ShapesDemo
{
    internal class Program
    {
        static void Main()
        {
            var shapes = new List<Shape>
            {
                new Circle(1),
                new Rectangle(3, 4),
                new Square(2)
            };

            double totalArea = 0, totalPerim = 0;
            foreach (var s in shapes)
            {
                Console.WriteLine(s); // uses Shape.ToString()
                totalArea += s.Area();
                totalPerim += s.Perimeter();
            }

            Console.WriteLine($"Total Area: {totalArea:0.###}");
            Console.WriteLine($"Total Perimeter: {totalPerim:0.###}");
        }
    }
}
