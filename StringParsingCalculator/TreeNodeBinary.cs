using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    class TreeNodeBinary : TreeNode
    {
        public TreeNodeBinary(TreeNode lhs, TreeNode rhs, Func<double, double, double> op)
        {
            _lhs = lhs;
            _rhs = rhs;
            _op = op;
        }

        TreeNode _lhs; // Left hand side of the operation
        TreeNode _rhs; // Right hand side of the operation
        Func<double, double, double> _op; // The callback operator

        public override double Eval(IContext context)
        {
            // Evaluate both sides
            var lhsVal = _lhs.Eval( context);
            var rhsVal = _rhs.Eval( context);

            // Evaluate and return
            var result = _op(lhsVal, rhsVal);
            return result;
        }
    }
}
