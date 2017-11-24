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
            var divisible = 0;

            for (var i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    divisible++;
                }
            }
            Console.WriteLine("There are {0} numbers between 0 and 100 that are divisible by 3", divisible);
        }
    }
}
