using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public enum TokenType { NONE, NUMBER, OPERATOR_ADD, OPERATOR_SUBTRACT, OPERATOR_MULTIPLY, OPERATOR_DIVIDE, OPERATOR_LPARENTHESIS, OPERATOR_RPARENTHESIS, ENDTOKEN }

    public class Token
    {
        public Token(double value)
        {
            type = TokenType.NUMBER;
            this.value = value;
        }
        public Token(TokenType t)
        {
            if(t==TokenType.NUMBER)
            {
                throw new System.ArgumentException("Can not create Token Object with TokenType TokenType.NUMBER. Use Token(double).");
            }
            type = t;
        }
        public TokenType GetTokenType() { return type; }
        public double GetValue()
        {
            if (type == TokenType.NUMBER)
                return value;
            else throw new Exception("Token not of type number. Can't return value.");
        }
        public override string ToString()
        {
            switch(type)
            {
                case TokenType.NONE:
                    return "Token of type None";
                    break;
                case TokenType.NUMBER:
                    return value.ToString();
                    break;
                case TokenType.OPERATOR_ADD:
                    return "Operator +";
                    break;
                case TokenType.OPERATOR_DIVIDE:
                    return "Operator /";
                    break;
                case TokenType.OPERATOR_LPARENTHESIS:
                    return "Operator (";
                    break;
                case TokenType.OPERATOR_RPARENTHESIS:
                    return "Operator )";
                    break;
                case TokenType.OPERATOR_MULTIPLY:
                    return "Operator *";
                    break;
                case TokenType.OPERATOR_SUBTRACT:
                    return "Operator -";
                    break;
                default:
                    return "INVALID TOKEN";
                    break;
            }
        }

        private double value;
        private TokenType type;
    }
}
