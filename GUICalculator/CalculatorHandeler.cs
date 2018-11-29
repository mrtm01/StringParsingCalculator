using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringParsingCalculator;

namespace GUICalculator
{
    class CalculatorHandeler
    {
        private System.Windows.Forms.TextBox _tb;
        private Parser _parser;
        private IContext _context;
        public CalculatorHandeler(System.Windows.Forms.TextBox textBox)
        {
            _context = new DefaultContext();
            _tb = textBox;
        }
        public void GetResult()
        {
            string input = _tb.Text;
            _parser = new Parser(new Lexer(input));
            TreeNode parsedTree = _parser.ParseExpression(_context);
            double result = parsedTree.Eval(_context);
            _tb.Text = result.ToString();
            AdjustCursor();
        }

        public void AdjustCursor()
        {
            _tb.SelectionStart = _tb.Text.Length;

        }
    }
}
