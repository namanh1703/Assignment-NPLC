namespace Net.M.A008.Exercise2
{
    /// <summary>
    /// Extension methods for ArrayList class.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Removes duplicate elements from an array of integers.
        /// </summary>
        /// <param name="array">The input array.</param>
        /// <returns>The array with distinct elements.</returns>
        public static int[] RemoveDuplicate(this int[] array)
        {
            HashSet<int> set = new HashSet<int>(array);
            return set.ToArray();
        }

        /// <summary>
        /// Removes duplicate elements from an array of generic type T.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The input array.</param>
        /// <returns>The array with distinct elements.</returns>
        public static T[] RemoveDuplicate<T>(this T[] array)
        {
            HashSet<T> set = new HashSet<T>(array);
            return set.ToArray();
        }
    }
}
