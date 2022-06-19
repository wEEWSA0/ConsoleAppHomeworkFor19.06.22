using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        private int _side;

        public Square(int x, int y, int side) : base(x, y)
        {
            _side = side;
        }

        public override void GetArea()
        {
            Console.WriteLine(_side * _side);
        }
    }
}
