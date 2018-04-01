namespace ArrayUtil
{
    /// <summary>
    /// Has one method which will check value if it appropriates some predicate
    /// </summary>
    public interface IPredicate
    {
        /// <summary>
        /// Method to ovverride
        /// </summary>
        /// <param name="value">
        /// Number, which will be checked
        /// </param>
        /// <returns>
        /// true if is appropriate, false in other cases
        /// </returns>
        bool IsAppropriate(int value);
    }
}