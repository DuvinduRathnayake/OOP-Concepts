using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract double Perimeter();
        public override string ToString() => $"{GetType().Name} | A={Area():0.###}, P={Perimeter():0.###}";

    }
}
