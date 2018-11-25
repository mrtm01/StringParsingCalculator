using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringParsingCalculator;

namespace StringParsingCalcTests
{
    [TestClass]
    public class LexerTests
    {
        [TestMethod]
        public void Zero()
        {
            string input = "0";
            Lexer l = new Lexer(input);
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(l.Token.GetValue(), 0);
        }

        [TestMethod]
        public void Addition1()
        {
            string input = "-10 + 10";
            Lexer l = new Lexer(input);
            Assert.AreEqual(TokenType.OPERATOR_SUBTRACT, l.Token.GetTokenType());


            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());
            l.NextToken();
            Assert.AreEqual(TokenType.OPERATOR_ADD, l.Token.GetTokenType());
            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());

        }
        [TestMethod]
        public void Subtraction1()
        {
            string input = "-10 - 10";
            Lexer l = new Lexer(input);
            Assert.AreEqual(TokenType.OPERATOR_SUBTRACT, l.Token.GetTokenType());


            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());
            l.NextToken();
            Assert.AreEqual(TokenType.OPERATOR_SUBTRACT, l.Token.GetTokenType());
            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());

        }

        [TestMethod]
        public void Multiplication1()
        {
            string input = "-10 * 10";
            Lexer l = new Lexer(input);
            Assert.AreEqual(TokenType.OPERATOR_SUBTRACT, l.Token.GetTokenType());


            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());
            l.NextToken();
            Assert.AreEqual(TokenType.OPERATOR_MULTIPLY, l.Token.GetTokenType());
            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());

        }

        [TestMethod]
        public void Divison1()
        {
            string input = "-10 / 10";
            Lexer l = new Lexer(input);
            Assert.AreEqual(TokenType.OPERATOR_SUBTRACT, l.Token.GetTokenType());


            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());
            l.NextToken();
            Assert.AreEqual(TokenType.OPERATOR_DIVIDE, l.Token.GetTokenType());
            l.NextToken();
            Assert.AreEqual(TokenType.NUMBER, l.Token.GetTokenType());
            Assert.AreEqual(10, l.Token.GetValue());

        }
    }
}
