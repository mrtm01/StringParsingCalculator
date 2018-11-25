using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public class DefaultContext : IContext
    {
        private Dictionary<string, double> _constants;
        private Dictionary<string, double> _variables;
        public DefaultContext()
        {
            _constants = new Dictionary<string, double>
            {
                { "PI",Math.PI }
                //,{"MEANINGOFLIFE",42 }
            };
            _variables = new Dictionary<string, double>();
        }

        public double ResolveVariable(string name)
        {
            if (_constants.ContainsKey(name) ) return _constants[name];
            else if (_variables.ContainsKey(name)) return _variables[name];
            else return 0;
        }
        public void AssignVariable(string name, double value)
        {
            if (_constants.ContainsKey(name)) //can't have variable with same name as constant
            {
                throw new SyntaxException("Identifier " + name + " already defined as constant.");
            }
            else if (_variables.ContainsKey(name))
            {
                _variables[name] = value;
            }
            else _variables.Add(name, value);
        }
        public void Dump()
        {
            foreach(KeyValuePair<string,double> kp in _constants)
            {
                Console.WriteLine("key: " + kp.Key + " value: " + kp.Value);
            }
            foreach (KeyValuePair<string, double> kp in _variables)
            {
                Console.WriteLine("key: " + kp.Key + " value: " + kp.Value);
            }
        }
    }
}
