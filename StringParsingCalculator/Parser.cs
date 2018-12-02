using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Parser very much based on:
 * https://medium.com/@CantabileApp/writing-a-simple-math-expression-engine-in-c-d414de18d4ce
 */


namespace StringParsingCalculator
{
    public class Parser
    {

        //DEBUG
        //static int parserPass = 0;
        // Constructor - just store the lexer
        public Parser(Lexer lexer)
        {
            _lexer = lexer;
        }

        Lexer _lexer;

        // Parse an entire expression and check EOF was reached
        public TreeNode ParseExpression(IContext context)
        {
            //parserPass++;
            //Console.WriteLine("Parser pass: " + parserPass);
            if(_lexer.Token.GetTokenType() == TokenType.ENDTOKEN) //Empty expression.
            {
                return new TreeNodeNumber(0);
            }

            TreeNode expressionTree = ParseAddSubtract(context);

            // Check everything was consumed
            if (_lexer.Token.GetTokenType() != TokenType.ENDTOKEN)
                throw new SyntaxException("Unexpected characters at end of expression: "+ _lexer.Token.GetTokenType().ToString() );

            return expressionTree;
        }

        // Parse an sequence of add/subtract operators
        TreeNode ParseAddSubtract(IContext context)
        {
            // Parse the left hand side
            var lhs = ParseMultiplyDivide(context);

            while (true)
            {
                bool operator_assign = false;
                // Work out the operator
                Func<double, double, double> op = null;
                if (_lexer.Token.GetTokenType() == TokenType.OPERATOR_ADD)
                {
                    op = (a, b) => a + b;
                }
                else if (_lexer.Token.GetTokenType() == TokenType.OPERATOR_SUBTRACT)
                {
                    op = (a, b) => a - b;
                }
                else if(_lexer.Token.GetTokenType() == TokenType.OPERATOR_ASSIGN)
                {
                    operator_assign = true;
                }

                // Binary operator not found?
                if (op == null && !operator_assign)
                    return lhs;             // not found

                // Skip the operator
                _lexer.NextToken();
                TreeNode rhs;
                // Parse the right hand side of the expression
                if (operator_assign) //
                {
                    rhs = ParseAddSubtract(context);
                    lhs = new TreeNodeAssign(lhs, rhs, context);
                }
                else
                {
                    rhs = ParseMultiplyDivide(context);
                    lhs = new TreeNodeBinary(lhs, rhs, op);// Create a binary node and use it as the left-hand side from now on
                }
            }
        }

        TreeNode ParseMultiplyDivide(IContext context)
        {
            // Parse the left hand side
            var lhs = ParseUnary(context);

            while (true)
            {
                // Work out the operator
                Func<double, double, double> op = null;
                if (_lexer.Token.GetTokenType() == TokenType.OPERATOR_MULTIPLY)
                {
                    op = (a, b) => a * b;
                }
                else if (_lexer.Token.GetTokenType() == TokenType.OPERATOR_DIVIDE)
                {
                    op = (a, b) => a / b;
                }

                // Binary operator not found?
                if (op == null)
                    return lhs;             // not found

                // Skip the operator
                _lexer.NextToken();

                // Parse the right hand side of the expression
                var rhs = ParseUnary(context);

                // Create a binary node and use it as the left-hand side from now on
                lhs = new TreeNodeBinary(lhs, rhs, op);
            }
        }
        // Parse a unary operator (eg: negative/positive)
        TreeNode ParseUnary(IContext context)
        {
            // Positive operator is a no-op so just skip it
            if (_lexer.Token.GetTokenType() == TokenType.OPERATOR_ADD)
            {
                // Skip
                _lexer.NextToken();
                return ParseUnary(context);
            }

            // Negative operator
            if (_lexer.Token.GetTokenType() == TokenType.OPERATOR_SUBTRACT)
            {
                // Skip
                _lexer.NextToken();

                // Parse RHS 
                // Note this recurses to self to support negative of a negative
                var rhs = ParseUnary(context);

                // Create unary node
                return new TreeNodeUnary(rhs, (a) => -a);
            }

            return ParseLeaf(context);
        }

        // Parse a leaf node. Variable, number or parenthesis
        TreeNode ParseLeaf(IContext context)
        {
            // Parenthesis?
            if (_lexer.Token.GetTokenType() == TokenType.OPERATOR_LPARENTHESIS)
            {
                // Skip '('
                _lexer.NextToken();

                // Parse a top-level expression
                var node = ParseAddSubtract(context);

                // Check and skip ')'
                if (_lexer.Token.GetTokenType() != TokenType.OPERATOR_RPARENTHESIS)
                    throw new SyntaxException("Missing close parenthesis");
                _lexer.NextToken();

                // Return
                return node;
            }
            // Is it a number?
            if (_lexer.Token.GetTokenType() == TokenType.NUMBER)
            {
                var node = new TreeNodeNumber(_lexer.Token.GetValue());
                _lexer.NextToken();
                return node;
            }
            if(_lexer.Token.GetTokenType() == TokenType.VARIABLE)
            {
                var node = new TreeNodeVariable(_lexer.Token.GetIdentifierName());
                _lexer.NextToken();
                return node;
            }
            if(_lexer.Token.GetTokenType() == TokenType.FUNCTION)
            {
                List<double> arguments = new List<double>();
                foreach(string s in _lexer.Token.GetFunctionArguments())
                {
                    Parser p = new Parser(new Lexer(s));
                    arguments.Add(p.ParseExpression(context).Eval(context));
                }
                var node = new TreeNodeFunction(_lexer.Token.GetIdentifierName(), arguments);
                _lexer.NextToken();
                return node;
            }

            // Don't Understand
            throw new SyntaxException($"Unexpect token: {_lexer.Token.GetTokenType()} at index {_lexer.GetCurrentIndex()} ");
        }

    }
}
