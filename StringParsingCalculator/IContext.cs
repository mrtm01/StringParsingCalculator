using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public class IContext
    {
        public double ResolveVariable(string name)
        {
            if (name.Equals("PI")) return Math.PI;
            else return 0;
        }
    }
}
