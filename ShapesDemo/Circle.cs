using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public class Circle: Shape
    {
        private readonly double _r;

        public Circle(double r)
        {
            if (r <= 0) throw new ArgumentException("Radius must be positive");
            _r= r;
        }

        public override double Area() => Math.PI * _r * _r;
        public override double Perimeter() => 2*Math.PI * _r;

    }
}
