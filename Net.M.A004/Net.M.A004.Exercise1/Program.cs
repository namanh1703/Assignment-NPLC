namespace Net.M.A004.Exercise1
{
    class Program
    {
        /// <summary>
        /// Write code to evaluate of a polynomial: y = 2x^3 – 6x^2 + 2x -1
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Example: y = 2x^3 – 6x^2 + 2x -1");
            int[] polynomial = { 2, -6, 2, -1};

            //Input x value
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //print result
            int n = polynomial.Length; //count string length
            int y = horner(polynomial, n, x);
            Console.Write("x = {0} => y= {1}", x, y);
        }
        /// <summary>
        /// Evaluate value of polynomial
        /// </summary>
        /// <param name="poly"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        static int horner(int[] poly, int n, int x)
        {
            //initialize result
            int result = poly[0];

            //using Horner's method
            for (int i = 1; i < n; i++)
                result = result * x + poly[i];

            return result;
        }

    }
}