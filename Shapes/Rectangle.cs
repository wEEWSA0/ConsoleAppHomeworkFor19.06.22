using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        private Coor _point2;

        public Rectangle(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            _point2 = new Coor(x2, y2);
        }

        public override void GetArea()
        {
            int a = Math.Abs(_point2.X - GetPoint1().X);
            int b = Math.Abs(_point2.Y - GetPoint1().Y);
            Console.WriteLine(a * b);
        }
    }
}
