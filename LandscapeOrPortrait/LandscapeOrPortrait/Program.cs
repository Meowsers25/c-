using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeOrPortrait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the width of your image?");
            var width = Console.ReadLine();
            Console.WriteLine("What is the height of your image?");
            var height = Console.ReadLine();
            var newWidth = Convert.ToInt32(width);
            var newHeight = Convert.ToInt32(height);

            if (newWidth > newHeight)
            {
                Console.WriteLine("Your image is in landscape mode.");
            }
            else
            {
                Console.WriteLine("Your image is in portrait mode");
            }
        }
    }
}
