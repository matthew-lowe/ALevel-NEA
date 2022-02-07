using System;
using System.Collections.Generic;

namespace MathsLibrary
{
    public delegate double FuncHandler(double a);
    
    public static class FunctionRegistry
    {
        private static Dictionary<string, FuncHandler> _registeredFunctions;
        private static Dictionary<string, double> _registeredConstants;

        static FunctionRegistry()
        {
            _registeredFunctions = new Dictionary<string, FuncHandler>();
            _registeredConstants = new Dictionary<string, double>();
            
            _registeredFunctions.Add("sin", Math.Sin);
            _registeredFunctions.Add("cos", Math.Cos);
            _registeredFunctions.Add("tan", Math.Tan);
            
            _registeredConstants.Add("e", Math.E);
            _registeredConstants.Add("pi", Math.PI);
        }

        public static FuncHandler GetFunction(string name)
        {
            return _registeredFunctions.ContainsKey(name) ? _registeredFunctions[name] : null;
        }

        public static double? GetConstant(string name)
        {
            return _registeredConstants.ContainsKey(name) ? _registeredConstants[name] : null;
        }
    }
}