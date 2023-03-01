namespace Net.M.A001.Exercise3
{
    /// <summary>
    /// Write code to get greatest common divisor of an array
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = { 12, 18, 24};
            Console.Write("GCD of an array { 12, 18, 24 } is: ");
            GCDArray(arrays);
        }
        /// <summary>
        /// Write code to get greatest common divisor of an array
        /// </summary>
        /// <param name="numGCD"></param>
        /// <returns>result</returns>
        private static int GCDArray(int[] numGCD)
        {
            int length = numGCD.Length;
            int result = numGCD[0];
            for (int i = 1; i < length; i++)
            {
                result = gcd(numGCD[i], result);
                
            }
            Console.WriteLine(result);
            Console.ReadKey();
            return result;
        }
        /// <summary>
        /// Greatest common divisor of 2 numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>gcd</returns>
        private static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

    }
}