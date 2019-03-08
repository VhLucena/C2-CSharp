using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class MobileRepository
    {

        public IMobile GetMobileByName(MobileTypes mobileName)
        {
            var nullMobile = NullObject.Instance;

            switch (mobileName)
            {
                case MobileTypes.AppleIphone:
                    return new Iphone();

                case MobileTypes.SamsungGalaxy:
                    return new SamsungGalaxy();

                case MobileTypes.NokiaN97:
                    return new NokiaN97();

                default:
                    return nullMobile;
            }

        }

    }
}
