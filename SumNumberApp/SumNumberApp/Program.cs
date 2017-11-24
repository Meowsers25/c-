using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number to factorialize?");
            var number = Convert.ToInt32(Console.ReadLine());
            var newNumber = 1;

            //Console.WriteLine(number);

            for (var i = 1; i <= number; i++)
            {
                //newNumber = newNumber * i;
                newNumber *= i;
            }
            Console.WriteLine("{0}! = {1}", number, newNumber);
        }
    }
}
