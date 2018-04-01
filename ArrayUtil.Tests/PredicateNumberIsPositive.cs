namespace ArrayUtil.Tests
{
    /// <summary>
    /// Overrides IsAppropriate method for checking if number is positive
    /// </summary>
    public class PredicateNumberIsPositive : IPredicate
    {
        /// <summary>
        /// Overrided Method
        /// </summary>
        /// <param name="value">
        /// Number, which will be checked 
        /// </param>
        /// <returns>
        /// true, if number is positive, false in other cases
        /// </returns>
        public bool IsAppropriate(int value)
        {
            return value > 0;
        }
    }
}