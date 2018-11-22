using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    class TreeNodeVariable : TreeNode
    {
        public TreeNodeVariable(string identifier)
        {
            _identifier = identifier;
        }

        string _identifier;

        public override double Eval(IContext context)
        {
            return context.ResolveVariable(_identifier);
        }
    }
}