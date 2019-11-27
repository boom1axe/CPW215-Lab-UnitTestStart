using System;
using System.Linq;

namespace BusinessLogic
{
    public static class Validator
    {
        private const int ssnMinLength = 9;

        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            if (ssn.Contains("-"))
            {
                ssn.Replace("-", "");
            }
            bool isnum = ssn.All(char.IsDigit);
            return ssn.Length == ssnMinLength && isnum == true;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            return numToTest <= maxValue && numToTest >= maxValue;
        }
    }
}
