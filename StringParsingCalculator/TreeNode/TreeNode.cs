using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Very much influenced by
 * https://medium.com/@CantabileApp/writing-a-simple-math-expression-engine-in-c-d414de18d4ce 
 * 
 */

namespace StringParsingCalculator
{
    public abstract class TreeNode
    {
        public abstract double Eval(IContext context);
        public virtual string GetIdentifierName()
        {
            return "NOT A VARIABLE";
        }
    }
}
