using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract internal class Shape
    {
        private Coor _point1;

        public Shape(int x, int y)
        {
            _point1 = new Coor(x, y);
        }

        public Coor GetPoint1()
        {
            return _point1;
        }

        public abstract void GetArea();
    }
}
