using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class MobileRepository
    {

        public IMobile GetMobileByName(string name)
        {
            var nullMobile = NullObject.Instance;
            string mobileName = name.ToLower();

            switch (mobileName)
            {
                case "iphone":
                    return new Iphone();

                case "galaxy":
                    return new SamsungGalaxy();

                case "nokia":
                    return new NokiaN97();

                default:
                    return nullMobile;
            }

        }

    }
}
