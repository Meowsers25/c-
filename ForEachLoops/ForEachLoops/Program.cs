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

            
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            
        }
    }
}
