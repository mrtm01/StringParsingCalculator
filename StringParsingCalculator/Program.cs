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
            string expression = "-7.9";
            StringParsingCalc sp = new StringParsingCalc(expression);

            Console.ReadLine();
        }
    }
}
