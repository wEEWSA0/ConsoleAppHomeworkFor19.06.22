using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Square(1, 1, 3), new Circle(6, 0, 3), new Rectangle(0, 8, 4, 6) };
            
            foreach (Shape shape in shapes)
            {
                shape.GetArea();
            }

            Console.ReadKey();
        }
    }
}
