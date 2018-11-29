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
            string exp1 = "pow(10;3)";
            //string exp2 = "variabel/2";
            //TestLexer(input);
            IContext globalContext = new DefaultContext();
            Parser p = new Parser(new Lexer(exp1));

            TreeNode t = p.ParseExpression(globalContext);
            Console.WriteLine("t.Eval(): " + t.Eval(globalContext));

            //p = new Parser(new Lexer(exp2));
            //t = p.ParseExpression(globalContext);
            //Console.WriteLine("t.Eval(): " + t.Eval(globalContext));
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
