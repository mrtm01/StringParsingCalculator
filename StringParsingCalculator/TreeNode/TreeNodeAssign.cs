using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public class TreeNodeAssign : TreeNode
    {
        public TreeNodeAssign(TreeNode lhs, TreeNode rhs, IContext context)
        {
            _lhs = lhs;
            _rhs = rhs;
            _context = context;
        }

        TreeNode _lhs; // Left hand side of the operation
        TreeNode _rhs; // Right hand side of the operation
        IContext _context;

        public override double Eval(IContext context)
        {
            // Only evaluate rhs
            //var lhsVal = _lhs.Eval(context);
            var rhsVal = _rhs.Eval(context);

            Console.WriteLine("Setting variable " + _lhs.GetIdentifierName() + "to :" + rhsVal);
            context.AssignVariable(_lhs.GetIdentifierName(), rhsVal);
            // Evaluate and return
            return rhsVal;
        }
    }
}
