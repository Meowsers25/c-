using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Larger_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var num1 = Console.ReadLine();
            var newNum1 = Convert.ToInt32(num1);
            Console.WriteLine("Enter another number");
            var num2 = Console.ReadLine();
            var newNum2 = Convert.ToInt32(num2);


            //Console.WriteLine(newNum1 + newNum2);
            if (newNum1 > newNum2)
            {
                Console.WriteLine(newNum1 + " is larger.");
            }
            else
            {
                Console.WriteLine(newNum2 + " is larger.");
            }
        }
    }
}
