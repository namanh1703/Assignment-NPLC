namespace Net.M.A008.Exercise3
{
    class Program
    {
        /// <summary>
        /// Give an array. Write an extension method named:
        /// +) LastIndexOf<T>(this T[] array, T elementValue): returns the last index of element has value equal
        /// elementValue in the array.
        /// </summary>
        /// <param name="args">The array list</param>
        static void Main(string[] args)
        {
            // Define an integer array
            int[] array = new int[] { 1, 2, 3, 5, 7, 3, 2 };
            // Returns the last index of element
            int lastIndex = array.LastIndexOf(3);
            // Output the last index of element
            Console.WriteLine("List: { 1, 2, 3, 5, 7, 3, 2 } -- Last index 3");
            Console.WriteLine("Output: " + lastIndex);

            // Define a string array
            string[] stringArray = new string[] { "Nguyen", "Van", "A", "Vu", "Van", "Hung" };
            // Returns the last index of element
            int lastIndexOfVan = stringArray.LastIndexOf("Van");
            // Output the last index of element
            Console.WriteLine("List: { \"Nguyen\", \"Van\", \"A\", \"Vu\", \"Van\", \"Hung\" } -- Last index of \"Van\"");
            Console.WriteLine("Output: " + lastIndexOfVan);



            // Repeat the process for other array list
            int[] array1 = new int[] { 1, 2, 3, 4, 3, 2, 1, 5, 6 };
            int lastIndex1 = array1.LastIndexOf(1);
            Console.WriteLine("\nList: { 1, 2, 3, 4, 3, 2, 1, 5, 6 } -- Last index 1");
            Console.WriteLine("Output: " + lastIndex1);

            string[] stringArray1 = new string[] { "Nguyen", "A", "Anh", "Nam", "Dam", "Huy" };
            int lastIndexOfNam = stringArray1.LastIndexOf("Nam");
            Console.WriteLine("List: { \"Nguyen\", \"A\", \"Anh\", \"Nam\", \"Dam\", \"Huy\" } -- Last index of \"Nam\"");
            Console.WriteLine("Output: " + lastIndexOfNam);


            // Repeat the process for other array list
            int[] array2 = new int[] { 2, 3, 7, 8, 6, 6, 5, 3, 4 };
            int lastIndex2 = array2.LastIndexOf(6);
            Console.WriteLine("\nList: { 2, 3, 7, 8, 6, 6, 5, 3, 4 } -- Last index 6");
            Console.WriteLine("Output: " + lastIndex2);

            string[] stringArray2 = new string[] { "Nguyen", "Van", "A", "Hai", "Hoang", "Quynh", "Giang" };
            int lastIndexOfGiang = stringArray2.LastIndexOf("Giang");
            Console.WriteLine("List: { \"Nguyen\", \"Van\", \"A\", \"Hai\", \"Hoang\", \"Quynh\", \"Giang\" } -- Last index of \"Giang\"");
            Console.WriteLine("Output: " + lastIndexOfGiang);
        }
    }
}