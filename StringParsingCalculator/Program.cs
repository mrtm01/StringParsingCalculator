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
            string expression = "(((1+1)*5)*(5+3+2-5+5)*0,5)/3,14159*3,14159";
            StringParsingCalc sp = new StringParsingCalc(expression);

            Console.ReadLine();
        }
    }
}
