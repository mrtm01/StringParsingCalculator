using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public interface IContext
    {
        bool UseRadians { get; set; }
        double ResolveVariable(string name);
        void AssignVariable(string name, double value);
        double EvaluateFunction(string name, List<double> parameters);
        void DumpCurrentIdentifiers();
    }
}
