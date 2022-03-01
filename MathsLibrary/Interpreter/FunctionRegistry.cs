using System;
using System.Collections.Generic;

namespace MathsLibrary.Interpreter
{
    /// <summary>
    /// Represents a function handler
    /// </summary>
    /// <param name="a">The input to the function</param>
    public delegate double FuncHandler(double a);
    
    /// <summary>
    /// A class for storing and fetching functions
    /// </summary>
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
            _registeredFunctions.Add("ln", Math.Log);
            _registeredFunctions.Add("log", Math.Log10);
            
            _registeredConstants.Add("e", Math.E);
            _registeredConstants.Add("pi", Math.PI);
        }

        /// <summary>
        /// Get a function by it's name
        /// </summary>
        /// <param name="name">The name of the function to get</param>
        /// <returns>The handler of the function to fetch. Null if none are found</returns>
        public static FuncHandler GetFunction(string name)
        {
            return _registeredFunctions.ContainsKey(name) ? _registeredFunctions[name] : null;
        }

        /// <summary>
        /// Get a constant by it's name
        /// </summary>
        /// <param name="name">The name of the constant to get</param>
        /// <returns>The value of the constant to fetch. Null if none are found</returns>
        public static double? GetConstant(string name)
        {
            return _registeredConstants.ContainsKey(name) ? _registeredConstants[name] : null;
        }
    }
}