using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace StringParsingCalculator
{
    public class ReflectionContext : IContext
    {

        private readonly Assembly MathLib;
        public bool UseRadians { get; set; }

        readonly Type mathLibType;
        readonly object mathLibInstance;

        private Dictionary<string, double> _constants;
        private Dictionary<string, double> _variables;
        public ReflectionContext()
        {
            try
            {
                MathLib = Assembly.LoadFile(System.IO.Directory.GetCurrentDirectory() + @"\SimpleMathLib.dll");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("error loading math library: " + e.Message);
                MathLib = null;
            }

            mathLibType = MathLib.GetType("SimpleMathLib.SimpleMathLib");
            try
            {
                mathLibInstance = Activator.CreateInstance(mathLibType);
            }
            catch (Exception e) { System.Console.WriteLine("Error creating math lib instance: " + e.Message);  }

            UseRadians = false;
            _constants = new Dictionary<string, double>
            {
                { "PI",Math.PI }
                ,{"E",Math.E }
                ,{"MEANINGOFLIFE",42 }
                
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
            sb.Append("Functions:\n");
            MethodInfo[] mi= mathLibType.GetMethods();
            foreach(var info in mi)
            {
                sb.Append(info.Name);
                sb.Append("(), ");
            }
            return sb.ToString();
        }

        public double EvaluateFunction(string name, List<double> arguments)
        {
            //CheckArguments(1, ref arguments, name);
            var mi = mathLibInstance.GetType().GetMethod(name);

            if (mi == null)
                throw new Exception($"Unknown function: '{name}'");

            // Convert double array to object array
            var argObjs = arguments.Select(x => (object)x).ToArray();

            // Call the method
            return (double)mi.Invoke(mathLibInstance, argObjs);
        }
    }
}
