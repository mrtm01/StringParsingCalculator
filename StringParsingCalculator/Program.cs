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
            string expression = "1*PI";
            StringParsingCalc sp = new StringParsingCalc(expression);

            Console.ReadLine();
        }
    }
}
