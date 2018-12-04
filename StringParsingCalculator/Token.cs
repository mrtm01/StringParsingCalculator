using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public enum TokenType { NONE,
        NUMBER,
        VARIABLE,
        FUNCTION,
        OPERATOR_ADD,
        OPERATOR_SUBTRACT,
        OPERATOR_MULTIPLY,
        OPERATOR_DIVIDE,
        OPERATOR_LPARENTHESIS,
        OPERATOR_RPARENTHESIS,
        OPERATOR_ASSIGN,
        OPERATOR_EXPONENT,
        ENDTOKEN }

    public class Token
    {
        private double _value;
        private TokenType _type;
        private string _identifier;
        private List<string> _arguments;

        public Token(double value)
        {
            _type = TokenType.NUMBER;
            _value = value;
        }
        public Token(string identifierName)
        {
            _type = TokenType.VARIABLE;
            _identifier = identifierName;
        }
        public Token(string identifierName, List<string> arguments)
        {
            _type = TokenType.FUNCTION;
            _identifier = identifierName;
            _arguments = arguments;
        }

        public List<string> GetFunctionArguments()
        {
            return _arguments;
        }
        public Token(TokenType t)
        {
            if(t==TokenType.NUMBER)
            {
                throw new System.ArgumentException("Can not create Token Object with TokenType TokenType.NUMBER. Use Token(double).");
            }
            else if(t==TokenType.VARIABLE)
            {
                throw new System.ArgumentException("Can not create Token Object with TokenType TokenType.VARIABLE. Use Token(string).");
            }
            _type = t;
        }
        public TokenType GetTokenType() { return _type; }
        public double GetValue()
        {
            if (_type == TokenType.NUMBER)
                return _value;
            else throw new Exception("Token not of type number. Can't return value.");
        }
        public string GetIdentifierName()
        {
            if (_type == TokenType.VARIABLE || _type == TokenType.FUNCTION) return _identifier;
            else throw new Exception("Token of type " + _type.ToString() + "Has no IdentifierName");
        }
        public override string ToString()
        {
            switch(_type)
            {
                case TokenType.NONE:
                    return "Token of type None";
                    //break;
                case TokenType.NUMBER:
                    return _value.ToString();
                    //break;
                case TokenType.OPERATOR_ADD:
                    return "Operator +";
                    //break;
                case TokenType.OPERATOR_DIVIDE:
                    return "Operator /";
                    //break;
                case TokenType.OPERATOR_LPARENTHESIS:
                    return "Operator (";
                    //break;
                case TokenType.OPERATOR_RPARENTHESIS:
                    return "Operator )";
                    //break;
                case TokenType.OPERATOR_MULTIPLY:
                    return "Operator *";
                    //break;
                case TokenType.OPERATOR_SUBTRACT:
                    return "Operator -";
                //break;
                case TokenType.FUNCTION:
                    return "Function";
                case TokenType.VARIABLE:
                    return "Variable";
                default:
                    return "INVALID TOKEN";
                    //break;
            }
        }


    }
}
