using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    internal class Duck
    {
        public string name;
        
        public virtual void Fly() 
        {
            Console.WriteLine("Летает");
        }
    }
}
