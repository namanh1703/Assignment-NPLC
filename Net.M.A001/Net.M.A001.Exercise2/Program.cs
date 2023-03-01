namespace Net.M.A001.Exercise2
{
    ///<summary>
    ///Write code to get greatest common divisor of 2 numbers
    ///</summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 12;
            GreatestCommonDivisor(x,y);
        }
        /// <summary>
        /// Write code to get greatest common divisor of 2 numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private static void GreatestCommonDivisor(int x, int y)
        {
            int gcd = 1;
            int temp;

            if (x > y)
            {
                temp = x;
                x = y;
                y = temp;
            }
            
            //If both numbers are divisible by i, then it modifies the GCD
            for (int i = 1; i < (x + 1); i++)
            {
                if (x % i == 0 && y % i == 0)
                    gcd = i;
            }
            Console.WriteLine("GCD of " + x + " and " + y + " is: " + gcd);
            Console.ReadKey();
        }     
    }
}