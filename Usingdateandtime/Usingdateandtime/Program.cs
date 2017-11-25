using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usingdateandtime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2017, 11, 25);

            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
        }
    }
}
