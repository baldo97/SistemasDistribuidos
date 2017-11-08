using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newshore.Common
{
    /// <summary>
    /// Provides argument exception handling 
    /// </summary>
    public static class Require
    {
        public static void ArgumentNotNull(object argument, string argumentName)
        {
            if (argument == null)
                throw new ArgumentNullException(argumentName);
        }

        public static void ArgumentNotNullOrEmpty(string argument, string argumentName)
        {
            if (string.IsNullOrEmpty(argument))
                throw new ArgumentNullException(argumentName);
        }

        public static void ArgumentMeetsCondition(bool condition, string errorMessage)
        {
            if (!condition)
                throw new ArgumentException(errorMessage);
        }

        public static void NotNullOrEmpty(string value, string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
                throw new InvalidOperationException(errorMessage);
        }

        public static void NotNull(object value, string errorMessage)
        {
            if (value == null)
                throw new InvalidOperationException(errorMessage);
        }

        public static void ConditionMet(bool condition, string message)
        {
            if (!condition)
                throw new InvalidOperationException(message);
        }

        public static void ArgumentIntNotZero(int value, string message)
        {
            if (value == 0)
                throw new ArgumentException(message);
        }        
    }
}
