﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    internal class FlyDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Парит у облаков");
        }
    }
}
