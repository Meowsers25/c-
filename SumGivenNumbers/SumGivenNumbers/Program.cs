using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumGivenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Please enter a number or enter 'ok' to exit");
                var input = Console.ReadLine();

                if (input == "ok")
                {
                    break;
                }
                else
                {
                    sum += Convert.ToInt32(input);
                }
                Console.WriteLine("The sum of your numbers is {0}", sum);
            }


        }
    }
}
