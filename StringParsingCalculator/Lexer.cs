using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Lexer implementation based on and altered to match parser.
 *  https://lukaszwrobel.pl/blog/math-parser-part-3-implementation/
 */

namespace StringParsingCalculator
{
    public class Lexer
    {
        public Lexer(String input)
        {
            currentIndex = 0;
            this.input = input;
            NextToken();
        }
        private char _decimalSeparator = ',';

        public Token Token { get; private set; }

        public void NextToken()
        {
            while (currentIndex < input.Length && input[currentIndex].Equals(' ')) currentIndex++; //increment past any whitespace.
            if (currentIndex >= input.Length) Token = new Token(TokenType.ENDTOKEN); //we are past string length.
            else if (input[currentIndex].Equals('*'))
            {
                Token = new Token(TokenType.OPERATOR_MULTIPLY);
            }
            else if (input[currentIndex].Equals('/'))
            {
                Token = new Token(TokenType.OPERATOR_DIVIDE);
            }
            else if (input[currentIndex].Equals('+'))
            {
                Token = new Token(TokenType.OPERATOR_ADD);
            }
            else if (input[currentIndex].Equals('-'))
            {
                Token = new Token(TokenType.OPERATOR_SUBTRACT);
            }
            else if (input[currentIndex].Equals('('))
            {
                Token = new Token(TokenType.OPERATOR_LPARENTHESIS);
            }
            else if (input[currentIndex].Equals(')'))
            {
                Token = new Token(TokenType.OPERATOR_RPARENTHESIS);
            }

            else if ( isDigitOrDecimalPoint(input[currentIndex].ToString() ))
            {
                int start = currentIndex;
                while (currentIndex < input.Length - 1)
                {
                    if (isDigitOrDecimalPoint(input[currentIndex+1].ToString()) ) currentIndex++;
                    else break;
                }
                double value = Convert.ToDouble(input.Substring(start, currentIndex - start+1));
                Token = new Token(value);
            }
            else
            {
                Token = new Token(TokenType.NONE); //should not reach this code.
            }
            currentIndex++;
        }

        private string input;
        private int currentIndex;
 

        private bool isDigitOrDecimalPoint(string s)
        {
            if (s[0].ToString().All(Char.IsDigit) || s[0].Equals(_decimalSeparator) ) return true;
            else return false;
        }
    }
}
