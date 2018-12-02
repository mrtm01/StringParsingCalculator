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
        private CommandHistory _commandHistory;
        private System.Windows.Forms.TextBox _tb;
        private readonly MainForm _mainForm;
        private Parser _parser;
        private readonly IContext _context;
        private HistoryDisplay _historyDisplay;
        public CalculatorHandeler(System.Windows.Forms.TextBox textBox, MainForm mainForm, HistoryDisplay historyDisplay)
        {
            _context = new DefaultContext();
            _tb = textBox;
            _mainForm = mainForm;
            _historyDisplay = historyDisplay;
            _commandHistory = new CommandHistory();
        }
        /*
         * Returns true on success and false on any error.
         */
        public bool GetResult()
        {
            if (InternalCommand(_tb.Text)) return true;
            else
            {
                string input = _tb.Text;
                _parser = new Parser(new Lexer(input));
                try
                {
                    TreeNode parsedTree = _parser.ParseExpression(_context);
                    double result = parsedTree.Eval(_context);
                    _context.AssignVariable("last", result);
                    _tb.Text = "";
                    _historyDisplay.AddLine(input + " = " + result.ToString().TrimStart());
                    _commandHistory.Add(input);
                }
                catch (Exception e)
                {
                    _tb.Text = "Error: " + e.Message;
                    return false;
                }
                AdjustCursor();
                return true;
            }
        }
        private bool InternalCommand(string s)
        {
            switch(s.ToLower())
            {
                case "clear":
                    _historyDisplay.Clear();
                    _tb.Text = "";
                    return true;
                case "list":
                    _tb.Text = "";
                    _historyDisplay.Text = _context.GetCurrentIdentifiers();
                    _historyDisplay.EnterMessageMode();
                    return true;
                    
                default:
                    return false;
            }
        }
        public void AddSymbol(string s)
        {
            if (_tb.SelectedText == _tb.Text) //all is selected.
            {
                _tb.Text = s;
            }
            else
            {
                _tb.Text = _tb.Text + s;
            }
            AdjustCursor();
        }
        public void AdjustCursor()
        {
            _tb.SelectionStart = _tb.Text.Length;
        }

        public void HistoryUp()
        {
            _tb.Text = _commandHistory.Up(_tb.Text);
            AdjustCursor();
        }
        public void HistoryDown()
        {
            _tb.Text = _commandHistory.Down(_tb.Text);
            AdjustCursor();
        }
        public void HistoryDisplayReset()
        {
            _tb.Text = _commandHistory.Reset();
            AdjustCursor();
        }
    }
}
