using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpFundamentals.Math;

namespace cSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var chris = new Person();

            chris.FirstName = "Chris";
            chris.LastName = "Lamothe";
            chris.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
