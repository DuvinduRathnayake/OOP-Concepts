using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public class Rectangle : Shape
    {
        private readonly double _x, _y;

        public Rectangle(double x, double y)
        {
            if (x <= 0 || y <= 0) throw new ArgumentException("Width and Height must be positive");
            _x = x;
            _y = y;
        }

        public override double Area() => _x * _y;
        public override double Perimeter() => 2 * (_x+_y);
    }
}
