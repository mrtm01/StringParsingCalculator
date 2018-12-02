using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUICalculator
{
    class CommandHistory
    {
        public CommandHistory()
        {
            index = 0;
            _history = new List<string>();
        }
        private readonly List<string> _history;
        private int index;
        private string _initialValue;
        private bool firstpass = true;

        public void Add(string s)
        {
            _history.Insert(0, s);
            Reset();
        }
        public string Up(string initial)
        {
            if (index == 0 && firstpass)
            {
                _initialValue = initial;
                firstpass = false;
            }
            if(index<_history.Count) index++;
            return _history[index-1];
        }

        public string Down(string initial)
        {
            if (index > 0) index--;
            return _history[index];
        }
        public string Reset()
        {
            firstpass = true;
            string retVal = _initialValue;
            index = 0;
            return retVal;
        }
    }
}
