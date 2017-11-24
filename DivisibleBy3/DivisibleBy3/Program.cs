using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 100;

            for (var i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
