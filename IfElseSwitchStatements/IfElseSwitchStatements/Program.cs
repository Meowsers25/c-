using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseSwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We have a promotion");
                    break;

                default:
                    Console.WriteLine("I dont understand the season");
                    break;
            }
        }
    }
}
