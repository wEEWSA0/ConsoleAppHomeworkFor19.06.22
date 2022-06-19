using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        const double pi = 3.14;
        private int _radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            _radius = radius;
        }

        public override void GetArea()
        {
            Console.WriteLine(_radius * _radius * pi);
        }
    }
}
