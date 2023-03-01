namespace Net.M.A008.Exercise3
{
    /// <summary>
    /// Extension methods for ArrayList class.
    /// </summary>
    static class ExtensionMethods
    {
        /// <summary>
        /// Returns the last index of the element in the array that has a value equal to the provided value.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The array to search for the last occurrence of the element.</param>
        /// <param name="elementValue">The value to search for in the array.</param>
        /// <returns>The last index of the element in the array that has a value equal to the provided value. If the element is not found, returns -1.</returns>
        public static int LastIndexOf<T>(this T[] array, T elementValue)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i].Equals(elementValue))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

