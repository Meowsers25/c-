using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysChapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 12, 4, 8, 5, 33, 42 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 5);
            Console.WriteLine("Index of 5 is {0}", index);

            //Clear
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("The effect of clear is()");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
