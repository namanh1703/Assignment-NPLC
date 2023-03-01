namespace Net.M.A008.Exercise2
{
    class Program
    {
        /// <summary>
        /// Give an Array. Write extension methods named:
        /// +) RemoveDuplicate(this int[] array) : returns the array of distinct elements.
        /// +) RemoveDuplicate<T>(this T[] array): returns the array of distinct elements.
        /// </summary>
        /// <param name="args">The array list</param>
        static void Main(string[] args)
        {
            // Define an integer array
            Console.WriteLine("\nList: { 1, 2, 3, 3, 5, 6, 5, 2 }");
            int[] intArray = new int[] { 1, 2, 3, 3, 5, 6, 5, 2 };
            // Define a string array
            Console.WriteLine("List: { \"Hung\", \"Vu\", \"Van\", \"Hung\", \"Quang\", \"Huy\", \"Vu\" }");
            string[] stringArray = new string[] { "Hung", "Vu", "Van", "Hung", "Quang", "Huy", "Vu" };

            // Get the distinct integers in the array
            int[] distinctInts = intArray.RemoveDuplicate();
            // Get the distinct strings in the array
            string[] distinctStrings = stringArray.RemoveDuplicate();

            // Output the distinct integers
            Console.WriteLine("Distinct integers: " + string.Join(", ", distinctInts));
            // Output the distinct strings
            Console.WriteLine("Distinct strings: " + string.Join(", ", distinctStrings));


            // Repeat the process for other array list
            Console.WriteLine("\nList: { 1, 8, 5, 4, 12, 14, 15, 53, 76, 14, 12, 1 }");
            int[] intArray1 = new int[] { 1, 8, 5, 4, 12, 14, 15, 53, 76, 14, 12, 1 };
            Console.WriteLine("List: { \"Anh\", \"Nam\", \"Huy\", \"Dam\", \"Vu\", \"Anh\" }");
            string[] stringArray1 = new string[] { "Anh", "Nam", "Huy", "Dam", "Vu", "Anh" };

            int[] distinctInts1 = intArray1.RemoveDuplicate();
            string[] distinctStrings1 = stringArray1.RemoveDuplicate();

            Console.WriteLine("Distinct integers: " + string.Join(", ", distinctInts1));
            Console.WriteLine("Distinct strings: " + string.Join(", ", distinctStrings1));

            // Repeat the process for other array list
            Console.WriteLine("\nList: { 4, 2, 6, 8, 4, 0, 8, 1, 10, 4, 2 }");
            int[] intArray2 = new int[] { 4, 2, 6, 8, 4, 0, 8, 1, 10, 4, 2 };
            Console.WriteLine("List: { \"Hung\", \"Vu\", \"Giang\", \"Linh\", \"Huy\", \"Tuan\", \"Linh\", \"Huy\" }");
            string[] stringArray2 = new string[] { "Hung", "Vu", "Giang", "Linh", "Huy", "Tuan", "Linh", "Huy" };

            int[] distinctInts2 = intArray2.RemoveDuplicate();
            string[] distinctStrings2 = stringArray2.RemoveDuplicate();

            Console.WriteLine("Distinct integers: " + string.Join(", ", distinctInts2));
            Console.WriteLine("Distinct strings: " + string.Join(", ", distinctStrings2));
        }
    }
}
