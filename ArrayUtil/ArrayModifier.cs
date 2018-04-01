using System;
using System.Collections.Generic;

namespace ArrayUtil
{
    public class ArrayModifier
    {
        /// <summary>
        /// Returns an array with numbers that appropriate some filter
        /// </summary>
        /// <param name="array">
        /// Array which is needed to be filtered
        /// </param>
        /// <param name="IPredicate">
        /// A predicate which is used like a filter
        /// </param>
        /// <returns>
        /// A filtered array
        /// </returns>
        public static int[] FilterDigits(int[] array, IPredicate predicate)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }
            
            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate.IsAppropriate(array[i]))
                {
                    list.Add(array[i]);
                }
            }

            return list.ToArray();
        }
    }
}
