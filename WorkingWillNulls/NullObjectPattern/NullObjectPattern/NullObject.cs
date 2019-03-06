using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class NullObject : IMobile
    {
        private static NullObject _instance;

        private NullObject() { }

        public static NullObject Instance
        {
            get
            {
                if ( _instance == null )
                    return new NullObject();
                return _instance;
            }
        }


        public void TurnOff() { }

        public void TurnOn() { }
    }
}
