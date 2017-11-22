using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit");
            var limit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(limit + 2);

            Console.WriteLine("Please enter speed of vehicle");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed < limit)
            {
                Console.WriteLine("Ok");
            }
            else if (speed > limit && speed <= limit + 5)
            {
                Console.WriteLine("1 demerit");
            }
            else if (speed > limit + 5 && speed <= limit + 10)
            {
                Console.WriteLine("2 demerits");
            }
            else if (speed > limit + 10 && speed <= limit + 15)
            {
                Console.WriteLine("3 demerits");
            }
            else if (speed > limit + 15 && speed <= limit + 20)
            {
                Console.WriteLine("4 demerits");
            }
            else if (speed > limit + 20 && speed <= limit + 25)
            {
                Console.WriteLine("5 demerits");
            }
            else if (speed > limit + 25 && speed <= limit + 30)
            {
                Console.WriteLine("6 demerits");
            }
            else if (speed > limit + 30 && speed <= limit + 35)
            {
                Console.WriteLine("7 demerits");
            }
            else if (speed > limit + 35 && speed <= limit + 40)
            {
                Console.WriteLine("8 demerits");
            }
            else if (speed > limit + 40 && speed <= limit + 45)
            {
                Console.WriteLine("9 demerits");
            }
            else if (speed > limit + 45 && speed <= limit + 50)
            {
                Console.WriteLine("10 demerits");
            }
            else if (speed > limit + 50 && speed <= limit + 55)
            {
                Console.WriteLine("11 demerits");
            }
            else if (speed > limit + 55 && speed <= limit + 60)
            {
                Console.WriteLine("12 demerits");
            }
            else
            { 
                Console.WriteLine("License suspended!");
            }

        }
    }
}
