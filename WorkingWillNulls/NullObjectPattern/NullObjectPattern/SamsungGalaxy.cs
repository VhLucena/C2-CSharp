using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class SamsungGalaxy : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning Off Samsung Galaxy");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning On Samsung Galaxy");
        }

        public override string ToString()
        {
            return "Samsung Galaxy";
        }
    }
}
