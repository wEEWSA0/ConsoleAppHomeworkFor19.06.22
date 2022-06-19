using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Coor
    {
        private int _x, _y;

        public Coor() { _x = 0; _y = 0; }
        
        public Coor(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X { get { return _x; } }
        public int Y { get { return _y; } }
    }
}
