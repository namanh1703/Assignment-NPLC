using System.Collections;
using System.Xml.Linq;

namespace Net.M.A008.Exercise1
{
    /// <summary>
    /// Extension methods for ArrayList class.
    /// </summary>
    public static class ArrayListExtensions
    {
        /// <summary>
        /// Returns the number of elements in the array with data type int.
        /// </summary>
        /// <param name="array">The ArrayList to count elements from.</param>
        /// <returns>The number of elements with data type int.</returns>
        public static int CountInt(this ArrayList array)
        {
            int count = 0;
            foreach (var item in array)
            {
                // Check if the item is of type int
                if (item is int) 
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Returns the number of elements in the array with data type specified by dataType.
        /// </summary>
        /// <param name="array">The ArrayList to count elements from.</param>
        /// <param name="dataType">The Type to compare elements' data type to.</param>
        /// <returns>The number of elements with data type dataType.</returns>
        public static int CountOf(this ArrayList array, Type dataType)
        {
            int count = 0;
            foreach (var item in array)
            {
                // Check if the item's type is equal to dataType
                if (item.GetType() == dataType) 
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Returns the number of elements in the array with data type T.
        /// </summary>
        /// <typeparam name="T">The type to compare elements' data type to.</typeparam>
        /// <param name="array">The ArrayList to count elements from.</param>
        /// <returns>The number of elements with data type T.</returns>
        public static int CountOf<T>(this ArrayList array)
        {
            int count = 0;
            foreach (var item in array)
            {
                // Check if the item is of type T
                if (item is T) 
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Returns the maximum element in the array if T is a numeric data type, otherwise throws an exception.
        /// </summary>
        /// <typeparam name="T">The type of elements in the ArrayList. Must implement IComparable.</typeparam>
        /// <param name="array">The ArrayList to find the maximum element from.</param>
        /// <returns>The maximum element in the ArrayList.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the ArrayList does not contain any elements of type T.</exception>
        public static T MaxOf<T>(this ArrayList array) where T : IComparable
        {
            // Defines a local variable "max" of type T and sets it to the default value of its type.
            T max = default(T);

            // Sets a boolean variable "first" to true, which will be used to determine if this is the first element in the ArrayList.
            bool first = true;

            // Loop iterates through each item in the ArrayList and attempts to cast it to type T.
            foreach (var item in array)
            {
                if (item is T)
                {
                    //If successful, it compares the item to the max and if greater.
                    T casted = (T)item;
                    if (first)
                    {
                        //sets it to the new max.
                        max = casted;
                        first = false;
                    }
                    else
                    {
                        if (casted.CompareTo(max) > 0)
                        {
                            max = casted;
                        }
                    }
                }
            }
            //If the loop is finished without parsing any elements, this line throws an exception.
            if (first)
            {
                throw new InvalidOperationException("The ArrayList does not contain any elements of type " + typeof(T).Name);
            }
            // If the loop has gone through all elements, this line returns the max.
            return max;
        }
    }
}
