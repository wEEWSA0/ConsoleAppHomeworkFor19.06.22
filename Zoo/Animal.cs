using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animal
    {
        public virtual void GetRoar()
        {
            Console.WriteLine("Standart animal roar");
        }
    }
}
