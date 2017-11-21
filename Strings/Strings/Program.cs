using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Chris";
            var firstName = "Chris";
            var lastName = "Lamothe";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1} ", firstName, lastName);
            var names = new string[3] {"Luna", "Beatrice", "Meowsers"};
            var formattedNames = string.Join(", ", names);

            Console.WriteLine(formattedNames);

           // var text = "Hi Katie\nlook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            //Console.WriteLine(text);

            var text = @"Hi Katie
look into the following paths
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text);
        }
    }
}
