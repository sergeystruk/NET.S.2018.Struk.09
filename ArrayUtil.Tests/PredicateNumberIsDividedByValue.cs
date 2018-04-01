namespace ArrayUtil.Tests
{
    /// <summary>
    /// Overrides IsAppropriate method for checking if number can be divided by any digit
    /// </summary>
    public class PredicateNumberIsDividedByValue : IPredicate
    {
        /// <summary>
        /// Field to set the value of number for checking
        /// </summary>
        private const int divider = 13;
        
        /// <summary>
        /// Overrided Method
        /// </summary>
        /// <param name="value">
        /// Number, which will be checked
        /// </param>
        /// <returns>
        /// true, if value is divided by number, false in other cases
        /// </returns>
        public bool IsAppropriate(int value)
        {
            return value % divider == 0;
        }
    }
}