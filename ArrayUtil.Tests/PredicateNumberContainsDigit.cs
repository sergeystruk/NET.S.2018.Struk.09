using System;

namespace ArrayUtil.Tests
{
    /// <summary>
    /// Overrides IsAppropriate method for checking if number contains any digit
    /// </summary>
    public class PredicateNumberContainsDigit : IPredicate
    {
        /// <summary>
        /// This field is used to set the value of checking digit
        /// </summary>
        private const int digit = 9;

        /// <summary>
        /// Overrided method
        /// </summary>
        /// <param name="value">
        /// Number, which will be checked
        /// </param>
        /// <returns>
        /// true, if number contains digit, false in other cases
        /// </returns>
        public bool IsAppropriate(int value)
        {
            int absoluteValue = Math.Abs(value);
            while (absoluteValue != 0)
            {
                if (absoluteValue % 10 == digit)
                {
                    return true;
                }

                absoluteValue /= 10;
            }

            return false;
        }
    }
}