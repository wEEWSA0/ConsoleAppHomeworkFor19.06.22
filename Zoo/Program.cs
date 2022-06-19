using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Animal(), new Bear(), new Tiger(), new Dog(), new Cat() };

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].GetRoar();
            }

            Console.ReadKey();
        }
    }
}
