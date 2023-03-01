namespace Net.M.A008.Exercise4
{
    /// <summary>
    /// Extension methods for ArrayList class.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Returns the 2nd largest number in the array.
        /// </summary>
        /// <param name="array">The array of numbers.</param>
        /// <returns>The 2nd largest number in the array.</returns>
        public static int ElementOfOrder2(this int[] array)
        {
            return ElementOfOrder(array, 2);
        }

        /// <summary>
        /// Returns the orderLargestth largest element in the array.
        /// </summary>
        /// <typeparam name="T">The data type of the elements in the array (should be a numeric type).</typeparam>
        /// <param name="array">The array of elements.</param>
        /// <param name="orderLargest">The order of the largest element to return.</param>
        /// <returns>The orderLargestth largest element in the array.</returns>
        public static T ElementOfOrder<T>(this T[] array, int orderLargest) where T : IComparable
        {
            // Check if the length of the array is less than the order of the largest element
            if (array.Length < orderLargest)
            {
                throw new Exception($"The length of the array is less than the order of the largest element ({orderLargest})." +
                    $" Cannot find {orderLargest} largest element.");
            }

            // Sort the array in descending order
            var sortedArray = array.OrderByDescending(x => x).ToArray();

            // Return the orderLargestth largest element
            return sortedArray[orderLargest];
        }
    }
}

