using System.Collections;

namespace Net.M.A008.Exercise1
{
    class Program
    {
        /// <summary>
        /// Give an ArrayList. Write extension methods named:
        /// +) CountInt(this ArrayList array) : returns number of elements in the array has data type is int.
        /// +) CountOf(this ArrayList array, Type dataType) : returns number of elements in the array has data type is dataType.
        /// +) CountOf<T>(this ArrayList array): returns number of elements in the array has data type is T.
        /// +) MaxOf<T>(this ArrayList array): returns the max element if T is a numeric data type, otherwise throw an exception.
        /// </summary>
        /// <param name="args">The array list</param>
        static void Main(string[] args)
        {
            // Create a  array list
            ArrayList array = new ArrayList();
            // Add value in array list
            array.Add("Hung");
            array.Add("Vu");
            array.Add(1);
            array.Add(2);
            array.Add("Van");
            array.Add(3.9d);

            // Output result
            Console.WriteLine("List: \"Hung\", \"Vu\", 1, 2, \"Van\", 3.9d");
            Console.WriteLine("CountInt: " + array.CountInt());
            Console.WriteLine("CountOf(typeof(int)): " + array.CountOf(typeof(int)));
            Console.WriteLine("CountOf<string>(): " + array.CountOf<string>());
            Console.WriteLine("MaxOf<int>(): " + array.MaxOf<int>());


            // Repeat the process for other array list
            ArrayList array1 = new ArrayList();
            array1.Add("Hoang");
            array1.Add("Anh");
            array1.Add(9);
            array1.Add(5);
            array1.Add("Khanh");
            array1.Add(4.2d);

            Console.WriteLine("\nList: \"Hoang\", \"Anh\", 9, 5, \"Khanh\", 4.2d");
            Console.WriteLine("CountInt: " + array1.CountInt());
            Console.WriteLine("CountOf(typeof(int)): " + array1.CountOf(typeof(int)));
            Console.WriteLine("CountOf<double>(): " + array1.CountOf<double>());
            Console.WriteLine("MaxOf<double>(): " + array1.MaxOf<double>());

            // Repeat the process for other array list
            ArrayList array2 = new ArrayList();
            array2.Add("Nam");
            array2.Add("Anh");
            array2.Add(15);
            array2.Add(5);
            array2.Add("Huy");
            array2.Add(4.2d);
            array2.Add(9);
            array2.Add(7.2d);
            array2.Add(5.6d);

            Console.WriteLine("\nList: \"Nam\", \"Anh\", 15, 5, \"Huy\", 4.2d, 9, 7.2d, 5.6d");
            Console.WriteLine("CountInt: " + array2.CountInt());
            Console.WriteLine("CountOf(typeof(double)): " + array2.CountOf(typeof(double)));
            Console.WriteLine("CountOf<string>(): " + array2.CountOf<string>());
            Console.WriteLine("MaxOf<double>(): " + array2.MaxOf<double>());
        }
    }
}
