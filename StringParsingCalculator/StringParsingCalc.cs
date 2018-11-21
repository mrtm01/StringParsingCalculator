using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    class StringParsingCalc
    {
        public StringParsingCalc(string input)
        {
            /*Lexer l = new Lexer(input);
            l.NextToken();
            while (l.Token.GetTokenType() != TokenType.ENDTOKEN)
            {
                Console.WriteLine("Found token: " + l.Token.ToString());
                l.NextToken();
            }*/

            Parser p = new Parser(new Lexer(input));

            TreeNode t = p.ParseExpression();
            Console.WriteLine("t.Eval(): " + t.Eval());
            Console.WriteLine("t.Eval()==50: " + (t.Eval() == 50));
        }
    }
}
