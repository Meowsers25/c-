using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new Random().Next(1, 10);
            //Console.WriteLine(num);

            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the number");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == num)
                {
                    Console.WriteLine("You have chosen wisely, Grasshopper");
                    return;
                }
            }
            Console.WriteLine("You have lost");
        }
    }
}
