using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParsingCalculator
{
    public class DefaultContext : IContext
    {
        public bool UseRadians { get; set; }

        private Dictionary<string, double> _constants;
        private Dictionary<string, double> _variables;
        public DefaultContext()
        {
            UseRadians = false;
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

        public string GetCurrentIdentifiers()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Constants:\n");
            foreach (KeyValuePair<string,double> kp in _constants)
            {
                //Console.WriteLine("key: " + kp.Key + " value: " + kp.Value);
                sb.Append(kp.Key);
                sb.Append(" = ");
                sb.Append(kp.Value);
                sb.Append("\n");
            }
            sb.Append("Variables:\n");
            foreach (KeyValuePair<string, double> kp in _variables)
            {
                sb.Append(kp.Key);
                sb.Append(" = ");
                sb.Append(kp.Value);
                sb.Append("\n");
                //Console.WriteLine("key: " + kp.Key + " value: " + kp.Value);
            }
            return sb.ToString();
        }

        public double EvaluateFunction(string name, List<double> arguments)
        {
            Console.WriteLine("Evaluate function: " + name.ToLower() + " argument 0: "+ arguments[0]);
            name = name.ToLower();
            switch (name)
            {
                case "sqrt":
                    CheckArguments(1, ref arguments, name);
                    return Math.Sqrt(arguments[0]);
                case "pow":
                    CheckArguments(2, ref arguments, name);
                    return Math.Pow(arguments[0], arguments[1]);

                    //Trig
                case "sin":
                    CheckArguments(1, ref arguments, name);
                    if (UseRadians) return Math.Sin(arguments[0]);
                    else return Math.Sin(DegreesToRadians(arguments[0]) );
                case "cos":
                    CheckArguments(1, ref arguments, name);
                    if (UseRadians) return Math.Cos(arguments[0]);
                    else return Math.Cos(DegreesToRadians(arguments[0]));
                case "tan":
                    CheckArguments(1, ref arguments, name);
                    if (UseRadians) return Math.Tan(arguments[0]);
                    else return Math.Tan(DegreesToRadians(arguments[0]) );

                    //Reverse Trig
                case "asin":
                    CheckArguments(1, ref arguments, name);
                    if (UseRadians) return Math.Asin(arguments[0]);
                    else return RadiansToDegrees(Math.Asin(arguments[0]));
                case "acos":
                    CheckArguments(1, ref arguments, name);
                    if (UseRadians) return Math.Acos(arguments[0]);
                    else return RadiansToDegrees(Math.Acos(arguments[0]));
                case "atan":
                    CheckArguments(1, ref arguments, name);
                    if (UseRadians) return Math.Atan(arguments[0]);
                    else return RadiansToDegrees(Math.Atan(arguments[0]));


                default:
                    throw new SyntaxException("Function not found: " + name);
            }
        }
        private void CheckArguments(int RequiredArguments,ref List<double> arguments, string FunctionName)
        {
            if (arguments.Count() < RequiredArguments) throw new SyntaxException("Too few arguments to function " + FunctionName);
        }
        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        private double RadiansToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
    }
}
