using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Iphone : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning Off iPhone");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning On iPhone");
        }

        public override string ToString()
        {
            return "Apple iPhone";
        }
    }
}
