using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public class IdentifierNotFoundException : Exception
    {
        public IdentifierNotFoundException(string message)
            : base(message)
        {
        }
    }
}
