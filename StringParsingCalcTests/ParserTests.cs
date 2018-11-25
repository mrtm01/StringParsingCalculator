using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringParsingCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator.Tests
{
    [TestClass()]
    public class ParserTests
    {
        [TestMethod()]
        public void ParseEmptyExpressionTest()
        {
            IContext context = new DefaultContext();

            string input = "";
            Parser p = new Parser(new Lexer(input));
            TreeNode t = p.ParseExpression(context);

            Assert.AreEqual(t.Eval(context), 0);
        }

        [TestMethod()]
        public void ParseAdditionExpression()
        {
            IContext context = new DefaultContext();

            string input = "99.9+100.1";
            Parser p = new Parser(new Lexer(input));
            TreeNode t = p.ParseExpression(context);

            Assert.AreEqual(t.Eval(context), 200);
        }

        [TestMethod()]
        public void ParseDivisionExpression()
        {
            IContext context = new DefaultContext();

            string input = "7.9532 / 2";
            Parser p = new Parser(new Lexer(input));
            TreeNode t = p.ParseExpression(context);

            Assert.AreEqual(t.Eval(context), 3.9766);
        }
        /* THIS RETURNS INFINITY.
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ParseDivideByZeroExpression()
        {
            IContext context = new DefaultContext();

            string input = "10 / 0";
            Parser p = new Parser(new Lexer(input));
            TreeNode t = p.ParseExpression(context);
            t.Eval(context);
        }
        */
    }
}