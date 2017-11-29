using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a set of numbers seperated by a comma");
            var numbers = Console.ReadLine();

            var newNum = numbers.Split(',');

            var maxNum = Convert.ToInt32(newNum[0]);
            
            foreach (var num in newNum)
            {
                var number = Convert.ToInt32(num);
                if (number > maxNum)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine("The largest number is: {0}", maxNum);

        }
    }
}
