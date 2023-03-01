namespace Net.M.A005.Exercise2
{
    /// <summary>
    /// Write code to list out first n number of Fibonacci array. Each number is printed in 1 line
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Enter the line number of the Fibonacci sequence:  ");
            }
            while (!int.TryParse(Console.ReadLine(), out x));
            Console.WriteLine("Fibonacci sequence:  ");
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(PrintFibonacci(i));
                
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Print the Fibonacci array.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int PrintFibonacci(int n)
        {
            int x0 = 0;
            int x1 = 1;
            int xn = 1;
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    x0 = x1;
                    x1 = xn;
                    xn = x0 + x1;
                }
            }
            return xn;
        }
    }
}