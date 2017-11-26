using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Chris Lamothe ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("first name: " + firstName);
            Console.WriteLine("last name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First name: " + names[0]);
            Console.WriteLine("Last name: " + names[1]);

            Console.WriteLine(fullName.Replace("Chris", "Christian")); 

            if(String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("Invalid");
            }




        }
    }
}
