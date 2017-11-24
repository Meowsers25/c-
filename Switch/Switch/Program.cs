using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sprred limit");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Speed");
            var speed = Convert.ToInt32(Console.ReadLine());

            switch (speed)
            {
                case 0:
                    if (speed <= limit)
                        Console.WriteLine("Ok");
                    break;

                case 1:
                    if (speed > limit && speed <= limit + 5)
                        Console.WriteLine("1");
                    break;
                    
                        
                    
                         

            }
        }
    }
}
