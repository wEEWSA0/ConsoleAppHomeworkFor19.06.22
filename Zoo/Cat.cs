using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Cat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
