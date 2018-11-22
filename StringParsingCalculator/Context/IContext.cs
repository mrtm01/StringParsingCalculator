using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public interface IContext
    {
        double ResolveVariable(string name);
        void AssignVariable(string name, double value);
        void Dump();
    }
}
