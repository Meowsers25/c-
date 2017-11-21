using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum ShippingMethods
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethods.Express;
            Console.WriteLine((int)method);
            //Console.WriteLine(method); prints "Express"

            var methodId = 2;
            Console.WriteLine((ShippingMethods)methodId);

            Console.WriteLine(method.ToString());//same as above

            var methodName = "Express";
            var shippingMethod = (ShippingMethods) Enum.Parse(typeof(ShippingMethods), methodName);

            Console.WriteLine(shippingMethod);
        }

    }
}
