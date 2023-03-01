namespace Net.M.A001.Exercise1
{
    ///<summary>
    ///Write code to get maximum and minimum of the inputted array
    ///</summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = new int[]{ 5, 8, 12, -10, 6, 4 };
            MaxMinArray(arrays); //MaxMinArray(5, 8, 12, -10, 6, 4);
        }
        /// <summary>
        /// Write code to get maximum and minimum of the inputted array
        /// </summary>
        /// <param name="numbers"></param>

        private static void MaxMinArray(int[] numbers) //params int[] numbers
        {
            int length = numbers.Length;
            int minArray = numbers[0];
            int maxArray = numbers[0];
            for (int i = 1; i < length; i++)
            {
                //Check number is max
                if (numbers[i] >=maxArray)
                {
                    maxArray = numbers[i];
                }
                //Check number is min
                if (numbers[i] <= minArray)
                {
                    minArray = numbers[i];
                }
            }
            Console.WriteLine($"Min in array: {minArray}");
            Console.WriteLine($"Max in array: {maxArray}");
            Console.ReadKey();
        }
    }
}
