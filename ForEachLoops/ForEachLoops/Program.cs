using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Katie Nichols";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
