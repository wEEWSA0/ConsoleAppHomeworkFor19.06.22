using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    internal class WaterDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Летает вблизи воды");
        }
    }
}
