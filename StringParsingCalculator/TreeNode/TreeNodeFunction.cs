using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public class TreeNodeFunction : TreeNode
    {

        public TreeNodeFunction(string identifier, List<double> arguments)
        {
            _identifier = identifier;
            _arguments = arguments;
        }

        string _identifier;
        List<double> _arguments;

        public override double Eval(IContext context)
        {
            return context.EvaluateFunction(_identifier,_arguments);
        }
        public override string GetIdentifierName()
        {
            return _identifier;
        }
    }
}
