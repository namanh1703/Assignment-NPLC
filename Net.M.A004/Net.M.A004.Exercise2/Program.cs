namespace Net.M.A004.Exercise2
{
    class Program
    {
        /// <summary>
        /// Write code to implement Horner’s method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Horner’s method");
            Console.WriteLine("f(x) = a0*x^n + a1*x^(n-1) + a2*x^(n-2) + a3*x^(n-3) +.....+ an ");
            Console.WriteLine("Test:");

            //Enter the degree of the polynomial
            Console.Write("Input the degree (n): ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            Console.WriteLine("----------------------");

            //Input the coefficient of the polynomial
            Input(a, n);
            Console.WriteLine("----------------------");

            //Input x value
            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //print result
            int y = horner(a, n, x);
            Console.WriteLine("At x = {0} -> y = {1}", x, y);
        }
        /// <summary>
        /// Enter the coefficient of the polynomial
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        private static void Input(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }


        /// <summary>
        /// Evaluate value of polynomial
        /// </summary>
        /// <param name="poly"></param>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        private static int horner(int[] poly, int n, int x)
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
