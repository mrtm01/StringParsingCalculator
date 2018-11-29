using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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
        private readonly char _decimalSeparator = ',';

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
            else if (input[currentIndex].Equals('='))
            {
                Token = new Token(TokenType.OPERATOR_ASSIGN);
            }
            else if (input[currentIndex].Equals('('))
            {
                Token = new Token(TokenType.OPERATOR_LPARENTHESIS);
            }
            else if (input[currentIndex].Equals(')'))
            {
                Token = new Token(TokenType.OPERATOR_RPARENTHESIS);
            }

            else if ( IsDigitOrDecimalPoint(input[currentIndex].ToString() ))
            {
                int start = currentIndex;
                while (currentIndex < input.Length - 1)
                {
                    if (IsDigitOrDecimalPoint(input[currentIndex+1].ToString()) ) currentIndex++;
                    else break;
                }
                double value = StringToDouble(input.Substring(start, currentIndex - start+1));
                Token = new Token(value);
            }

            else if (IsValidIdentifierChar(input[currentIndex].ToString())) //found variable or function
            {
                int start = currentIndex;
                while (currentIndex < input.Length - 1)
                {
                    if (IsValidIdentifierChar(input[currentIndex + 1].ToString())) currentIndex++;
                    else break;
                }
                string name = input.Substring(start, currentIndex - start + 1);

                if (currentIndex +1 < input.Length && input[currentIndex + 1] == '(')
                {
                    currentIndex+=2; //increment past '('
                    start = currentIndex;
                    int parenthesisCount = 1;
                    while (currentIndex < input.Length-1)
                    {
                        if (input[currentIndex] == '(')
                        {
                            parenthesisCount++;
                            Console.WriteLine("Found open parenthesis. Count is now: " + parenthesisCount);
                        }

                        if (input[currentIndex] == ')')
                        {
                            parenthesisCount--;
                            if (parenthesisCount == 0) break;
                            Console.WriteLine("Found close parenthesis. Count is now: " + parenthesisCount);
                        }

                        currentIndex++;
                    }
                    List<string> arguments = new List<string>( input.Substring(start, currentIndex - start).Split(';') );
                    Token = new Token(name, arguments);
                    Console.WriteLine("Function: " + name + " found. Arguments: "); //DEBUG
                    foreach (string s in arguments) Console.Write(s + ", ");//DEBUG: found function
                    Console.WriteLine(); //DEBUG
                }

                else Token = new Token(name);
            }

            else
            {
                Token = new Token(TokenType.NONE); //should not reach this code.
            }
            currentIndex++;
        }

        private string input;
        private int currentIndex;
 

        private bool IsDigitOrDecimalPoint(string s)
        {
            if (s[0].ToString().All(Char.IsDigit) || s[0].Equals(_decimalSeparator) ) return true;
            else return false;
        }
        private bool IsValidIdentifierChar(string s)
        {
            if (s[0].ToString().All(Char.IsLetter) ) return true;
            else return false;
        }

        private double StringToDouble(string input)
        {
            string internationalized = input.Replace(_decimalSeparator.ToString(),
                CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator);
            //Console.WriteLine("Converting string: " + internationalized + " to double");
            return Convert.ToDouble(internationalized);
        }
    }
}
