namespace Net.M.A008.Exercise4
{
    class Program
    {
        /// <summary>
        /// Give an array that has data type is numeric such as int, float, double, decimal, long,...
        /// Write extension methods named:
        /// +) ElementOfOrder2(this int[] array) returns the 2nd largest number in the array.
        /// +) ElementOfOrder<T>(this T[] array, int orderLargest) returns the orderLargest th largest element in
        /// the array. If orderLargest greater than the length of the array should throw an exception.
        /// </summary>
        /// <param name="args">The array list</param>
        static void Main(string[] args)
        {
            // Define an integer array
            int[] array = new int[] { 3, 2, 5, 6, 1, 7, 7, 5, 2 };

            //Output result
            Console.WriteLine("List: { 3, 2, 5, 6, 1, 7, 7, 5, 2 }");
            Console.WriteLine("ElementOfOrder2: " + array.ElementOfOrder2());
            Console.WriteLine("ElementOfOrder(2): " + array.ElementOfOrder(2));
            Console.WriteLine("ElementOfOrder(3): " + array.ElementOfOrder(3));

            try
            {
                Console.WriteLine("ElementOfOrder(20): " + array.ElementOfOrder(20));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ElementOfOrder(20): " + ex.Message);
            }


            // Repeat the process for other array list
            int[] array1 = new int[] { 3, 2, 4, 3, 2, 5, 4, 6, 7, 8, 8, 1, 9, 3, 4 };

            //Output result
            Console.WriteLine("\nList: { 3, 2, 4, 3, 2, 5, 4, 6, 7, 8, 8, 1, 9, 3, 4 }");
            Console.WriteLine("ElementOfOrder2: " + array1.ElementOfOrder2());
            Console.WriteLine("ElementOfOrder(3): " + array1.ElementOfOrder(3));
            Console.WriteLine("ElementOfOrder(4): " + array1.ElementOfOrder(4));

            try
            {
                Console.WriteLine("ElementOfOrder(10): " + array1.ElementOfOrder(10));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ElementOfOrder(10): " + ex.Message);
            }


            // Repeat the process for other array list
            int[] array2 = new int[] { 4, 3, 3, 2, 5, 2, 7, 8, 0, 2, 3, 5, 5, 3, 6 };

            //Output result
            Console.WriteLine("\nList: { 4, 3, 3, 2, 5, 2, 7, 8, 0, 2, 3, 5, 5, 3, 6 }");
            Console.WriteLine("ElementOfOrder2: " + array2.ElementOfOrder2());
            Console.WriteLine("ElementOfOrder(5): " + array2.ElementOfOrder(5));
            Console.WriteLine("ElementOfOrder(7): " + array2.ElementOfOrder(7));

            try
            {
                Console.WriteLine("ElementOfOrder(15): " + array2.ElementOfOrder(15));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ElementOfOrder(15): " + ex.Message);
            }
        }
    }
}
