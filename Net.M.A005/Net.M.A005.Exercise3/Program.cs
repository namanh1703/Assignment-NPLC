namespace Net.M.A005.Exercise3
{   /// <summary>
    /// Write code to check a positive integer is prime number or not.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Enter number:  ");
            }
            // Check if the input data can be converted to integer form, if not, then re-enter it
            while (!int.TryParse(Console.ReadLine(), out x));

            if (CheckPrimeNumber(x))
            {
                Console.WriteLine("{0} is prime number", x);
            }
            else
            {
                Console.WriteLine("{0} is NOT prime number", x);
            }
        }
        /// <summary>
        /// Check Prime number function
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static bool CheckPrimeNumber(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}