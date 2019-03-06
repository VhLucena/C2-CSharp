using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobileRepository = new MobileRepository();

            var mobile = mobileRepository.GetMobileByName("Galaxy");

            Console.WriteLine(mobile);
        }
    }
}
