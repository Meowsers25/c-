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

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
                foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
                foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            


        }
    }
}
