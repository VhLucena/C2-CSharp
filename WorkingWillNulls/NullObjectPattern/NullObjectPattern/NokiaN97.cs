using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class NokiaN97 : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("Turning Off NokiaN97");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning On NokiaN97");
        }

        public override string ToString()
        {
            return "NokiaN97";
        }
    }
}
