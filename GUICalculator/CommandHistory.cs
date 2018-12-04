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
            _history = new List<string>
            {
                "last", //0
                "" //1
            };
            _index = BASEINDEX;
        }
        private enum Direction { Up, Down };
        const int BASEINDEX = 1;
        private readonly List<string> _history;
        private int _index;
        
        public void Add(string s)
        {
            _history.Insert(BASEINDEX+1, s);
            Reset();
        }
        public string Up(string initial)
        {
            return Step(Direction.Up, initial);
        }

        public string Down(string initial)
        {
            return Step(Direction.Down, initial);
        }
        private string Step(Direction d, string initial)
        {
            if (_index == BASEINDEX) _history[BASEINDEX] = initial;
            if(d == Direction.Up)
            {
                if(_index < _history.Count-1)
                {
                    _index++;
                    return _history[_index];
                }
            }
            else
            {
                if(_index>0)
                {
                    _index--;
                    return _history[_index];
                }
            }
            return initial;
        }
        public string Reset()
        {
            _index = BASEINDEX;
            return _history[BASEINDEX];
        }
    }
}
