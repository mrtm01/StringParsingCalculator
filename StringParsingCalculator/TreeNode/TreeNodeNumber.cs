using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    class TreeNodeNumber : TreeNode
    {
        public TreeNodeNumber(double number)
        {
            _number = number;
        }

        double _number;

        public override double Eval(IContext context)
        {
            return _number;
        }
    }
}