using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesDemo
{
    public class Square : Rectangle
    {
        public Square(double s) : base(s, s)
        {
            if (s <= 0) throw new ArgumentException("Side must be positive.");
        }
    }
}
