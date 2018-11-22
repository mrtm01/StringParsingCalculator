using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    // NodeUnary for unary operations such as Negate
    class TreeNodeUnary : TreeNode
    {
        // Constructor accepts the two nodes to be operated on and function
        // that performs the actual operation
        public TreeNodeUnary(TreeNode rhs, Func<double, double> op)
        {
            _rhs = rhs;
            _op = op;
        }

        TreeNode _rhs;                              // Right hand side of the operation
        Func<double, double> _op;               // The callback operator

        public override double Eval(IContext context)
        {
            // Evaluate RHS
            var rhsVal = _rhs.Eval(context);

            // Evaluate and return
            var result = _op(rhsVal);
            return result;
        }
    }
}
