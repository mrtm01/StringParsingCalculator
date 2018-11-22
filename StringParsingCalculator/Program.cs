using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "minVariabel=(1+PI)*(5+5)";
            StringParsingCalc sp = new StringParsingCalc(expression);

            Console.ReadLine();
        }
    }
}
