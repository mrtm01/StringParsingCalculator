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

            //TestLexer(input);
            IContext globalContext = new IContext();
            Parser p = new Parser(new Lexer(input));

            TreeNode t = p.ParseExpression(globalContext);
            Console.WriteLine("t.Eval(): " + t.Eval(globalContext));
            
        }
        private void TestLexer(string input)
        {
            Lexer l = new Lexer(input);

            while (true)
            {
                Console.WriteLine("Lexer found: " + l.Token.GetTokenType().ToString());
                if (l.Token.GetTokenType() == TokenType.VARIABLE) Console.WriteLine("Identifier name: " + l.Token.GetIdentifierName());
                if (l.Token.GetTokenType() == TokenType.ENDTOKEN) break;
                l.NextToken();
            }
        }
    }
}
